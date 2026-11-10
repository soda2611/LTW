using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Course_Registration
{
    /// <summary>
    /// Lớp tiện ích bảo mật, mã hóa đối xứng AES-256 và băm mật khẩu chuẩn PBKDF2 (RFC 2898) với Salt ngẫu nhiên.
    /// </summary>
    public static class SecurityHelper
    {
        // Cấu hình chuẩn băm mật khẩu PBKDF2
        private const int SaltSizeBytes = 16;       // 128 bit salt
        private const int HashSizeBytes = 32;       // 256 bit hash
        private const int Pbkdf2Iterations = 10000; // 10,000 vòng lặp chuẩn OWASP
        private const string HashPrefix = "PBKDF2$";

        // Khóa mã hóa đối xứng AES-256 mặc định của hệ thống
        private const string DefaultAesKey = "CourseReg#2026!Key@AES256Security";

        #region 1. Băm & Xác thực mật khẩu (One-way Password Hashing)

        /// <summary>
        /// Băm mật khẩu bằng thuật toán PBKDF2 với Salt ngẫu nhiên 16 bytes.
        /// Chuỗi kết quả có dạng: PBKDF2${salt_base64}${hash_base64} (độ dài 76 ký tự, vừa vặn NVarChar(100)).
        /// </summary>
        public static string HashPassword(string rawPassword)
        {
            if (string.IsNullOrEmpty(rawPassword))
            {
                return string.Empty;
            }

            byte[] salt = new byte[SaltSizeBytes];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(rawPassword, salt, Pbkdf2Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSizeBytes);
                return string.Format("{0}{1}${2}", HashPrefix, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
            }
        }

        /// <summary>
        /// Xác thực mật khẩu nhập vào so với mật khẩu đã lưu trong CSDL.
        /// Hỗ trợ tương thích ngược thông minh: nếu mật khẩu cũ dạng Plaintext thì tự nhận diện và trả về true.
        /// </summary>
        public static bool VerifyPassword(string inputPassword, string storedPassword)
        {
            if (string.IsNullOrEmpty(inputPassword) || string.IsNullOrEmpty(storedPassword))
            {
                return false;
            }

            // Tương thích ngược: Nếu mật khẩu trong DB chưa được mã hóa (dữ liệu mẫu cũ)
            if (!IsHashed(storedPassword))
            {
                return string.Equals(inputPassword, storedPassword, StringComparison.Ordinal);
            }

            try
            {
                string[] parts = storedPassword.Split('$');
                if (parts.Length != 3 || parts[0] != "PBKDF2")
                {
                    return false;
                }

                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] expectedHash = Convert.FromBase64String(parts[2]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, Pbkdf2Iterations))
                {
                    byte[] actualHash = pbkdf2.GetBytes(expectedHash.Length);
                    return ConstantTimeEquals(expectedHash, actualHash);
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra xem chuỗi mật khẩu đã được băm theo chuẩn PBKDF2 hay chưa.
        /// </summary>
        public static bool IsHashed(string password)
        {
            return !string.IsNullOrEmpty(password) && password.StartsWith(HashPrefix);
        }

        /// <summary>
        /// So sánh mảng byte với thời gian không đổi (Constant-time comparison) để chống tấn công Timing Attack.
        /// </summary>
        private static bool ConstantTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }

        #endregion

        #region 2. Mã hóa & Giải mã 2 chiều AES-256 (Symmetric Encryption)

        /// <summary>
        /// Mã hóa chuỗi văn bản bằng thuật toán AES-256 (CBC Mode, PKCS7 Padding, IV ngẫu nhiên).
        /// </summary>
        public static string EncryptAes(string plainText, string key = null)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            byte[] keyBytes = DeriveKey(key ?? DefaultAesKey);

            using (var aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;
                aes.GenerateIV();

                using (var ms = new MemoryStream())
                {
                    // Ghi IV 16 bytes vào đầu luồng để phục vụ giải mã
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.FlushFinalBlock();
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        /// <summary>
        /// Giải mã chuỗi AES-256 đã mã hóa.
        /// </summary>
        public static string DecryptAes(string cipherText, string key = null)
        {
            if (string.IsNullOrEmpty(cipherText))
            {
                return string.Empty;
            }

            try
            {
                byte[] cipherWithIv = Convert.FromBase64String(cipherText);
                if (cipherWithIv.Length < 16)
                {
                    return string.Empty;
                }

                byte[] keyBytes = DeriveKey(key ?? DefaultAesKey);

                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Key = keyBytes;

                    // Đọc IV 16 bytes từ đầu tệp
                    byte[] iv = new byte[16];
                    Buffer.BlockCopy(cipherWithIv, 0, iv, 0, 16);
                    aes.IV = iv;

                    using (var ms = new MemoryStream(cipherWithIv, 16, cipherWithIv.Length - 16))
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs, Encoding.UTF8))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        private static byte[] DeriveKey(string rawKey)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(rawKey));
            }
        }

        #endregion

        #region 3. Băm dữ liệu SHA-256 (Checksum & Fingerprint)

        /// <summary>
        /// Tạo mã băm SHA-256 dạng Hex cho chuỗi bất kỳ (dùng kiểm tra toàn vẹn giao dịch).
        /// </summary>
        public static string ComputeSha256(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        #endregion
    }
}

