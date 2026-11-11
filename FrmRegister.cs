using System;
using System.Linq;
using System.Windows.Forms;

namespace Course_Registration
{
    public partial class FrmRegister : Form
    {
        public string RegisteredUsername { get; private set; }

        public FrmRegister()
        {
            InitializeComponent();
            try { this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath); } catch { }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc (*).", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 4 || username.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 4 ký tự và không chứa khoảng trắng.",
                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (CourseRegistrationDataContext db = DbHelper.CreateContext())
                {
                    bool exists = db.Users.Any(u => u.Username.ToLower() == username.ToLower());
                    if (exists)
                    {
                        MessageBox.Show("Tên đăng nhập này đã được sử dụng. Vui lòng chọn tên đăng nhập khác.",
                            "Trùng tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    User newUser = new User
                    {
                        Username = username,
                        Password = SecurityHelper.HashPassword(password),
                        FullName = fullName,
                        Email = string.IsNullOrEmpty(email) ? null : email,
                        Phone = string.IsNullOrEmpty(phone) ? null : phone,
                        Role = "Student",
                        Balance = 0m,
                        IsActive = true,
                        CreatedAt = DateTime.Now
                    };

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    RegisteredUsername = username;
                    MessageBox.Show("Đăng ký tài khoản học viên thành công.\nBạn có thể sử dụng tài khoản này để đăng nhập ngay.",
                        "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hoàn tất đăng ký:\n" + ex.Message, "Lỗi hệ thống",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
