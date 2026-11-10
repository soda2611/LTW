namespace Course_Registration
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.pnlDemoHint = new System.Windows.Forms.Panel();
            this.btnFillStudent = new System.Windows.Forms.Button();
            this.btnFillAdmin = new System.Windows.Forms.Button();
            this.lblDemoAccounts = new System.Windows.Forms.Label();
            this.lblDemoHeader = new System.Windows.Forms.Label();
            this.lblBrandDesc = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandBadge = new System.Windows.Forms.Label();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.btnOpenRegister = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoginSub = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.pnlBrand.SuspendLayout();
            this.pnlDemoHint.SuspendLayout();
            this.pnlLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlBrand.Controls.Add(this.pnlDemoHint);
            this.pnlBrand.Controls.Add(this.lblBrandDesc);
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Controls.Add(this.lblBrandBadge);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(320, 460);
            this.pnlBrand.TabIndex = 0;
            // 
            // pnlDemoHint
            // 
            this.pnlDemoHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.pnlDemoHint.Controls.Add(this.btnFillStudent);
            this.pnlDemoHint.Controls.Add(this.btnFillAdmin);
            this.pnlDemoHint.Controls.Add(this.lblDemoAccounts);
            this.pnlDemoHint.Controls.Add(this.lblDemoHeader);
            this.pnlDemoHint.Location = new System.Drawing.Point(28, 315);
            this.pnlDemoHint.Name = "pnlDemoHint";
            this.pnlDemoHint.Size = new System.Drawing.Size(264, 118);
            this.pnlDemoHint.TabIndex = 3;
            // 
            // btnFillStudent
            // 
            this.btnFillStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnFillStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFillStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillStudent.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFillStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFillStudent.Location = new System.Drawing.Point(135, 80);
            this.btnFillStudent.Name = "btnFillStudent";
            this.btnFillStudent.Size = new System.Drawing.Size(117, 28);
            this.btnFillStudent.TabIndex = 3;
            this.btnFillStudent.Text = "Điền mẫu Học viên";
            this.btnFillStudent.UseVisualStyleBackColor = false;
            this.btnFillStudent.Click += new System.EventHandler(this.btnFillStudent_Click);
            // 
            // btnFillAdmin
            // 
            this.btnFillAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnFillAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFillAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillAdmin.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFillAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFillAdmin.Location = new System.Drawing.Point(12, 80);
            this.btnFillAdmin.Name = "btnFillAdmin";
            this.btnFillAdmin.Size = new System.Drawing.Size(115, 28);
            this.btnFillAdmin.TabIndex = 2;
            this.btnFillAdmin.Text = "Điền mẫu Quản trị";
            this.btnFillAdmin.UseVisualStyleBackColor = false;
            this.btnFillAdmin.Click += new System.EventHandler(this.btnFillAdmin_Click);
            // 
            // lblDemoAccounts
            // 
            this.lblDemoAccounts.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblDemoAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblDemoAccounts.Location = new System.Drawing.Point(12, 32);
            this.lblDemoAccounts.Name = "lblDemoAccounts";
            this.lblDemoAccounts.Size = new System.Drawing.Size(240, 42);
            this.lblDemoAccounts.TabIndex = 1;
            this.lblDemoAccounts.Text = "Quản trị viên: admin / 123456\r\nHọc viên: hocvien1 / 123456";
            // 
            // lblDemoHeader
            // 
            this.lblDemoHeader.AutoSize = true;
            this.lblDemoHeader.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblDemoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblDemoHeader.Location = new System.Drawing.Point(12, 10);
            this.lblDemoHeader.Name = "lblDemoHeader";
            this.lblDemoHeader.Size = new System.Drawing.Size(134, 15);
            this.lblDemoHeader.TabIndex = 0;
            this.lblDemoHeader.Text = "Tài khoản kiểm thử:";
            // 
            // lblBrandDesc
            // 
            this.lblBrandDesc.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblBrandDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandDesc.Location = new System.Drawing.Point(28, 196);
            this.lblBrandDesc.Name = "lblBrandDesc";
            this.lblBrandDesc.Size = new System.Drawing.Size(264, 82);
            this.lblBrandDesc.TabIndex = 2;
            this.lblBrandDesc.Text = "Quản lý danh mục học phần, tiếp nhận đăng ký khóa học, theo dõi học phí và tổng h" +
    "ợp báo cáo đào tạo.";
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(26, 84);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(270, 96);
            this.lblBrandTitle.TabIndex = 1;
            this.lblBrandTitle.Text = "Hệ thống Quản lý\r\nĐăng ký Khóa học";
            // 
            // lblBrandBadge
            // 
            this.lblBrandBadge.AutoSize = true;
            this.lblBrandBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrandBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandBadge.Location = new System.Drawing.Point(28, 52);
            this.lblBrandBadge.Name = "lblBrandBadge";
            this.lblBrandBadge.Size = new System.Drawing.Size(192, 15);
            this.lblBrandBadge.TabIndex = 0;
            this.lblBrandBadge.Text = "PHÒNG ĐÀO TẠO & HỌC VỤ";
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.BackColor = System.Drawing.Color.White;
            this.pnlLoginForm.Controls.Add(this.btnAbout);
            this.pnlLoginForm.Controls.Add(this.btnOpenRegister);
            this.pnlLoginForm.Controls.Add(this.lblNoAccount);
            this.pnlLoginForm.Controls.Add(this.btnLogin);
            this.pnlLoginForm.Controls.Add(this.chkRememberMe);
            this.pnlLoginForm.Controls.Add(this.chkShowPassword);
            this.pnlLoginForm.Controls.Add(this.txtPassword);
            this.pnlLoginForm.Controls.Add(this.lblPass);
            this.pnlLoginForm.Controls.Add(this.txtUsername);
            this.pnlLoginForm.Controls.Add(this.lblUser);
            this.pnlLoginForm.Controls.Add(this.lblLoginSub);
            this.pnlLoginForm.Controls.Add(this.lblLoginTitle);
            this.pnlLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginForm.Location = new System.Drawing.Point(320, 0);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(460, 460);
            this.pnlLoginForm.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAbout.Location = new System.Drawing.Point(296, 14);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(130, 28);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "👥 Giới thiệu";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOpenRegister
            // 
            this.btnOpenRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnOpenRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnOpenRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpenRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnOpenRegister.Location = new System.Drawing.Point(252, 378);
            this.btnOpenRegister.Name = "btnOpenRegister";
            this.btnOpenRegister.Size = new System.Drawing.Size(158, 34);
            this.btnOpenRegister.TabIndex = 5;
            this.btnOpenRegister.Text = "Đăng ký tài khoản";
            this.btnOpenRegister.UseVisualStyleBackColor = false;
            this.btnOpenRegister.Click += new System.EventHandler(this.btnOpenRegister_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNoAccount.Location = new System.Drawing.Point(50, 386);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(166, 17);
            this.lblNoAccount.TabIndex = 8;
            this.lblNoAccount.Text = "Chưa có tài khoản?";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.chkRememberMe.Location = new System.Drawing.Point(235, 272);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(155, 19);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "Lưu thông tin đăng nhập";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.chkShowPassword.Location = new System.Drawing.Point(50, 272);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(127, 19);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(50, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPass.Location = new System.Drawing.Point(47, 210);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(50, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblUser.Location = new System.Drawing.Point(47, 136);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Tên đăng nhập:";
            // 
            // lblLoginSub
            // 
            this.lblLoginSub.AutoSize = true;
            this.lblLoginSub.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblLoginSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLoginSub.Location = new System.Drawing.Point(47, 88);
            this.lblLoginSub.Name = "lblLoginSub";
            this.lblLoginSub.Size = new System.Drawing.Size(294, 17);
            this.lblLoginSub.TabIndex = 1;
            this.lblLoginSub.Text = "Nhập thông tin tài khoản để truy cập hệ thống";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(45, 50);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(124, 28);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Đăng nhập";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.pnlLoginForm);
            this.Controls.Add(this.pnlBrand);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Hệ thống Quản lý Đăng ký Khóa học";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlDemoHint.ResumeLayout(false);
            this.pnlDemoHint.PerformLayout();
            this.pnlLoginForm.ResumeLayout(false);
            this.pnlLoginForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandDesc;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandBadge;
        private System.Windows.Forms.Panel pnlDemoHint;
        private System.Windows.Forms.Button btnFillStudent;
        private System.Windows.Forms.Button btnFillAdmin;
        private System.Windows.Forms.Label lblDemoAccounts;
        private System.Windows.Forms.Label lblDemoHeader;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOpenRegister;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoginSub;
        private System.Windows.Forms.Label lblLoginTitle;
    }
}
