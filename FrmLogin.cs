using System;
using System.Linq;
using System.Windows.Forms;

namespace Course_Registration
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                LoginPreferenceInfo pref = UserSession.LoadPreferences();
                if (pref != null && pref.RememberMe)
                {
                    txtUsername.Text = pref.Username ?? string.Empty;
                    txtPassword.Text = pref.Password ?? string.Empty;
                    chkRememberMe.Checked = true;

                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        btnLogin.Focus();
                    }
                    else
                    {
                        txtPassword.Focus();
                    }
                }
            }
            catch
            {
            }
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnFillAdmin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "123456";
        }

        private void btnFillStudent_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "hocvien1";
            txtPassword.Text = "123456";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            try
            {
                using (CourseRegistrationDataContext db = DbHelper.CreateContext())
                {
                    User user = (from u in db.Users
                                 where u.Username == username
                                 select u).FirstOrDefault();

                    if (user == null || !SecurityHelper.VerifyPassword(password, user.Password))
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập thất bại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.SelectAll();
                        txtPassword.Focus();
                        return;
                    }

                    // Tự động nâng cấp mật khẩu cũ (Plaintext) sang mã băm bảo mật PBKDF2
                    if (!SecurityHelper.IsHashed(user.Password))
                    {
                        user.Password = SecurityHelper.HashPassword(password);
                        db.SubmitChanges();
                    }

                    if (!user.IsActive)
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản trị viên để được hỗ trợ.",
                            "Tài khoản bị khóa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // 1. Lưu thông tin đăng nhập an toàn nếu người dùng chọn
                    UserSession.SavePreferences(username, password, chkRememberMe.Checked);

                    // 2. Khởi tạo phiên làm việc (Session)
                    UserSession.StartSession(user);

                    this.Hide();

                    if (string.Equals(user.Role, "Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        using (FrmAdminMain frmAdmin = new FrmAdminMain(user.UserID))
                        {
                            frmAdmin.ShowDialog();
                        }
                    }
                    else
                    {
                        using (FrmStudentMain frmStudent = new FrmStudentMain(user.UserID))
                        {
                            frmStudent.ShowDialog();
                        }
                    }

                    // 3. Kết thúc phiên làm việc khi đăng xuất
                    UserSession.EndSession();

                    // Nạp lại thông tin nếu có tùy chọn ghi nhớ
                    LoginPreferenceInfo savedPref = UserSession.LoadPreferences();
                    if (savedPref != null && savedPref.RememberMe)
                    {
                        txtUsername.Text = savedPref.Username ?? string.Empty;
                        txtPassword.Text = savedPref.Password ?? string.Empty;
                        chkRememberMe.Checked = true;
                    }
                    else
                    {
                        txtPassword.Clear();
                        chkRememberMe.Checked = false;
                    }

                    this.Show();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu:\n" + ex.Message, "Lỗi hệ thống",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var f = new FrmAbout())
            {
                f.ShowDialog(this);
            }
        }

        private void btnOpenRegister_Click(object sender, EventArgs e)
        {
            using (FrmRegister frmReg = new FrmRegister())
            {
                if (frmReg.ShowDialog() == DialogResult.OK)
                {
                    txtUsername.Text = frmReg.RegisteredUsername;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}
