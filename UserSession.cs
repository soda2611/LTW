using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Course_Registration
{
    /// <summary>
    /// Lưu trữ thông tin tài khoản đang đăng nhập trong phiên làm việc (User Session).
    /// </summary>
    public class SessionUserInfo
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastActiveTime { get; set; }
        public string SessionToken { get; set; }

        public bool IsAdmin
        {
            get { return string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase); }
        }

        public bool IsStudent
        {
            get { return string.Equals(Role, "Student", StringComparison.OrdinalIgnoreCase); }
        }

        public TimeSpan SessionDuration
        {
            get { return DateTime.Now - LoginTime; }
        }

        public string FormattedDuration
        {
            get
            {
                TimeSpan duration = SessionDuration;
                if (duration.TotalMinutes < 1)
                {
                    return "Vừa mới đăng nhập";
                }
                if (duration.TotalHours < 1)
                {
                    return string.Format("{0} phút", (int)duration.TotalMinutes);
                }
                return string.Format("{0} giờ {1} phút", (int)duration.TotalHours, duration.Minutes);
            }
        }
    }

    /// <summary>
    /// Cấu trúc lưu trữ tùy chọn ghi nhớ đăng nhập của người dùng.
    /// </summary>
    public class LoginPreferenceInfo
    {
        public bool RememberMe { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    /// <summary>
    /// Lớp quản lý phiên làm việc tập trung (Session Manager) và lưu trữ thông tin đăng nhập an toàn.
    /// </summary>
    public static class UserSession
    {
        private static SessionUserInfo _currentUser;
        private static readonly object _lockObj = new object();

        // Đường dẫn file lưu trữ thông tin đăng nhập an toàn trong thư mục LocalAppData
        private static string PreferencesFilePath
        {
            get
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string appFolder = Path.Combine(appData, "CourseRegistration");
                if (!Directory.Exists(appFolder))
                {
                    Directory.CreateDirectory(appFolder);
                }
                return Path.Combine(appFolder, "session_pref.dat");
            }
        }

        /// <summary>
        /// Thông tin người dùng của phiên đăng nhập hiện tại.
        /// </summary>
        public static SessionUserInfo CurrentUser
        {
            get
            {
                lock (_lockObj)
                {
                    return _currentUser;
                }
            }
        }

        /// <summary>
        /// Kiểm tra xem hiện tại có người dùng nào đang đăng nhập hay không.
        /// </summary>
        public static bool IsLoggedIn
        {
            get
            {
                lock (_lockObj)
                {
                    return _currentUser != null;
                }
            }
        }

        /// <summary>
        /// Bắt đầu một phiên đăng nhập mới với thông tin tài khoản được cung cấp.
        /// </summary>
        public static void StartSession(User user)
        {
            if (user == null)
            {
                return;
            }

            lock (_lockObj)
            {
                _currentUser = new SessionUserInfo
                {
                    UserID = user.UserID,
                    Username = user.Username,
                    FullName = user.FullName,
                    Role = user.Role,
                    Email = user.Email,
                    Phone = user.Phone,
                    Balance = user.Balance,
                    LoginTime = DateTime.Now,
                    LastActiveTime = DateTime.Now,
                    SessionToken = Guid.NewGuid().ToString("N")
                };
            }
        }

        /// <summary>
        /// Cập nhật thời điểm hoạt động gần nhất của người dùng trong phiên.
        /// </summary>
        public static void TouchActivity()
        {
            lock (_lockObj)
            {
                if (_currentUser != null)
                {
                    _currentUser.LastActiveTime = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Đồng bộ lại thông tin số dư tài khoản từ CSDL vào phiên đăng nhập.
        /// </summary>
        public static void SyncBalanceFromDb()
        {
            lock (_lockObj)
            {
                if (_currentUser == null)
                {
                    return;
                }

                try
                {
                    using (CourseRegistrationDataContext db = DbHelper.CreateContext())
                    {
                        var u = db.Users.FirstOrDefault(x => x.UserID == _currentUser.UserID);
                        if (u != null)
                        {
                            _currentUser.Balance = u.Balance;
                            _currentUser.FullName = u.FullName;
                            _currentUser.Email = u.Email;
                            _currentUser.Phone = u.Phone;
                        }
                    }
                }
                catch
                {
                    // Giữ nguyên số dư hiện tại nếu có lỗi kết nối tạm thời
                }
            }
        }

        /// <summary>
        /// Kết thúc phiên đăng nhập (Đăng xuất).
        /// </summary>
        public static void EndSession()
        {
            lock (_lockObj)
            {
                _currentUser = null;
            }
        }

        #region Lưu & Nạp thông tin đăng nhập an toàn (Remember Me)

        /// <summary>
        /// Lưu thông tin đăng nhập vào máy cục bộ (mã hóa mật khẩu bằng AES-256).
        /// </summary>
        public static void SavePreferences(string username, string password, bool rememberMe)
        {
            try
            {
                string path = PreferencesFilePath;
                if (!rememberMe || string.IsNullOrEmpty(username))
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    return;
                }

                // Mã hóa dữ liệu mật khẩu trước khi ghi ra file
                string encryptedPass = SecurityHelper.EncryptAes(password ?? string.Empty);
                string payload = string.Format("{0}|{1}|{2}",
                    rememberMe ? "1" : "0",
                    username.Trim(),
                    encryptedPass);

                // Mã hóa toàn bộ khối dữ liệu một lần nữa để chống chỉnh sửa file
                string secureData = SecurityHelper.EncryptAes(payload);
                File.WriteAllText(path, secureData, Encoding.UTF8);
            }
            catch
            {
                // Bỏ qua lỗi I/O để không ảnh hưởng luồng chính của ứng dụng
            }
        }

        /// <summary>
        /// Nạp thông tin đăng nhập đã lưu từ máy cục bộ.
        /// </summary>
        public static LoginPreferenceInfo LoadPreferences()
        {
            try
            {
                string path = PreferencesFilePath;
                if (!File.Exists(path))
                {
                    return new LoginPreferenceInfo { RememberMe = false, Username = string.Empty, Password = string.Empty };
                }

                string secureData = File.ReadAllText(path, Encoding.UTF8).Trim();
                if (string.IsNullOrEmpty(secureData))
                {
                    return new LoginPreferenceInfo { RememberMe = false, Username = string.Empty, Password = string.Empty };
                }

                string payload = SecurityHelper.DecryptAes(secureData);
                string[] parts = payload.Split('|');
                if (parts.Length >= 3)
                {
                    bool rememberMe = parts[0] == "1";
                    string username = parts[1];
                    string password = SecurityHelper.DecryptAes(parts[2]);

                    return new LoginPreferenceInfo
                    {
                        RememberMe = rememberMe,
                        Username = username,
                        Password = password
                    };
                }
            }
            catch
            {
                // File lỗi hoặc giải mã thất bại thì bỏ qua
            }

            return new LoginPreferenceInfo { RememberMe = false, Username = string.Empty, Password = string.Empty };
        }

        /// <summary>
        /// Xóa sạch thông tin đăng nhập đã lưu.
        /// </summary>
        public static void ClearPreferences()
        {
            try
            {
                string path = PreferencesFilePath;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch
            {
            }
        }

        #endregion
    }
}

