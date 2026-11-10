namespace Course_Registration
{
    partial class FrmStudentMain
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

            this.components = new System.ComponentModel.Container();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentReviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCat_CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_ScheduleShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_RatingDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_MyState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_EnrollmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_ScheduleText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_EnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMy_StatusDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_D7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT_DCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuRev_CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyTx_TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyTx_TypeLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyTx_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyTx_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyTx_CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();



            System.Windows.Forms.DataGridViewCellStyle dgvHeader1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlt1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeader2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlt2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeader3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellWrap = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeader4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlt4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeader5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlt5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlStudentHeader = new System.Windows.Forms.Panel();
            this.btnStudentLogout = new System.Windows.Forms.Button();
            this.btnStudentAbout = new System.Windows.Forms.Button();
            this.btnQuickTopUp = new System.Windows.Forms.Button();
            this.lblHeaderBalance = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPortalTitle = new System.Windows.Forms.Label();
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabCatalog = new System.Windows.Forms.TabPage();
            this.pnlCatalogMain = new System.Windows.Forms.Panel();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.pnlCatalogFilter = new System.Windows.Forms.Panel();
            this.btnCatalogReset = new System.Windows.Forms.Button();
            this.cboCatalogSort = new System.Windows.Forms.ComboBox();
            this.cboCatalogCategory = new System.Windows.Forms.ComboBox();
            this.txtCatalogSearch = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.grpCourseCheckout = new System.Windows.Forms.GroupBox();
            this.btnBuyCourse = new System.Windows.Forms.Button();
            this.txtBuyNote = new System.Windows.Forms.TextBox();
            this.lblBuyNote = new System.Windows.Forms.Label();
            this.lblSelPrice = new System.Windows.Forms.Label();
            this.lblVoucherStatus = new System.Windows.Forms.Label();
            this.btnApplyVoucher = new System.Windows.Forms.Button();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.lblVoucherTitle = new System.Windows.Forms.Label();
            this.txtSelDescription = new System.Windows.Forms.TextBox();
            this.lblSelDescTitle = new System.Windows.Forms.Label();
            this.lblConflictWarning = new System.Windows.Forms.Label();
            this.lblSelSlots = new System.Windows.Forms.Label();
            this.lblSelClassTime = new System.Windows.Forms.Label();
            this.lblSelSchedule = new System.Windows.Forms.Label();
            this.lblSelInstructor = new System.Windows.Forms.Label();
            this.lblSelCategory = new System.Windows.Forms.Label();
            this.lblSelName = new System.Windows.Forms.Label();
            this.lblSelRating = new System.Windows.Forms.Label();
            this.lblSelCode = new System.Windows.Forms.Label();
            this.tabMyCourses = new System.Windows.Forms.TabPage();
            this.pnlMyCoursesList = new System.Windows.Forms.Panel();
            this.dgvMyCourses = new System.Windows.Forms.DataGridView();
            this.pnlMyCoursesFilter = new System.Windows.Forms.Panel();
            this.btnExportMyCourses = new System.Windows.Forms.Button();
            this.lblMySummary = new System.Windows.Forms.Label();
            this.cboMyCourseStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchMyCourse = new System.Windows.Forms.TextBox();
            this.lblMySearch = new System.Windows.Forms.Label();
            this.grpMyCourseDetail = new System.Windows.Forms.GroupBox();
            this.btnCancelMyCourse = new System.Windows.Forms.Button();
            this.btnPrintStudentReceipt = new System.Windows.Forms.Button();
            this.btnSaveMyNote = new System.Windows.Forms.Button();
            this.txtMyEnrollNote = new System.Windows.Forms.TextBox();
            this.lblMyNote = new System.Windows.Forms.Label();
            this.lblMyEnrollInfo = new System.Windows.Forms.Label();
            this.txtMyCourseTitle = new System.Windows.Forms.TextBox();
            this.lblMyCourseTitle = new System.Windows.Forms.Label();
            this.txtMyEnrollmentId = new System.Windows.Forms.TextBox();
            this.lblMyEnrollId = new System.Windows.Forms.Label();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.pnlTimetableTop = new System.Windows.Forms.Panel();
            this.btnExportTimetable = new System.Windows.Forms.Button();
            this.lblTimetableSummary = new System.Windows.Forms.Label();
            this.lblTimetableTitle = new System.Windows.Forms.Label();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.pnlReviewsMain = new System.Windows.Forms.Panel();
            this.dgvStudentReviews = new System.Windows.Forms.DataGridView();
            this.pnlReviewsFilter = new System.Windows.Forms.Panel();
            this.lblCourseAvgSummary = new System.Windows.Forms.Label();
            this.cboFilterReviewCourse = new System.Windows.Forms.ComboBox();
            this.lblFilterRevCourse = new System.Windows.Forms.Label();
            this.grpWriteReview = new System.Windows.Forms.GroupBox();
            this.btnDeleteMyReview = new System.Windows.Forms.Button();
            this.btnSaveReview = new System.Windows.Forms.Button();
            this.lblRevHint = new System.Windows.Forms.Label();
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.lblRevComment = new System.Windows.Forms.Label();
            this.cboReviewRating = new System.Windows.Forms.ComboBox();
            this.lblRevStars = new System.Windows.Forms.Label();
            this.cboReviewCourse = new System.Windows.Forms.ComboBox();
            this.lblRevCourse = new System.Windows.Forms.Label();
            this.tabWallet = new System.Windows.Forms.TabPage();
            this.pnlWalletHistory = new System.Windows.Forms.Panel();
            this.dgvMyTransactions = new System.Windows.Forms.DataGridView();
            this.pnlTxFilter = new System.Windows.Forms.Panel();
            this.btnExportMyTx = new System.Windows.Forms.Button();
            this.lblWalletStats = new System.Windows.Forms.Label();
            this.cboFilterTxType = new System.Windows.Forms.ComboBox();
            this.lblFilterTx = new System.Windows.Forms.Label();
            this.grpTopUp = new System.Windows.Forms.GroupBox();
            this.btnConfirmTopUp = new System.Windows.Forms.Button();
            this.txtTopUpNote = new System.Windows.Forms.TextBox();
            this.lblTopUpNote = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.btnTop2M = new System.Windows.Forms.Button();
            this.btnTop1M = new System.Windows.Forms.Button();
            this.btnTop500k = new System.Windows.Forms.Button();
            this.btnTop200k = new System.Windows.Forms.Button();
            this.nudTopUpAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlBalanceBox = new System.Windows.Forms.Panel();
            this.lblWalletBigBalance = new System.Windows.Forms.Label();
            this.lblWalletBoxTitle = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.grpChangePass = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.chkProfileShowPass = new System.Windows.Forms.CheckBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.grpProfileInfo = new System.Windows.Forms.GroupBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.lblProfPhone = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfEmail = new System.Windows.Forms.Label();
            this.txtProfileFullName = new System.Windows.Forms.TextBox();
            this.lblProfFullName = new System.Windows.Forms.Label();
            this.txtProfileRole = new System.Windows.Forms.TextBox();
            this.lblProfRole = new System.Windows.Forms.Label();
            this.txtProfileUsername = new System.Windows.Forms.TextBox();
            this.lblProfUsername = new System.Windows.Forms.Label();
            this.printDocReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewReceipt = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileStudentExcel = new System.Windows.Forms.SaveFileDialog();
            this.pnlStudentHeader.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabCatalog.SuspendLayout();
            this.pnlCatalogMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.pnlCatalogFilter.SuspendLayout();
            this.grpCourseCheckout.SuspendLayout();
            this.tabMyCourses.SuspendLayout();
            this.pnlMyCoursesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCourses)).BeginInit();
            this.pnlMyCoursesFilter.SuspendLayout();
            this.grpMyCourseDetail.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.pnlTimetableTop.SuspendLayout();
            this.tabReviews.SuspendLayout();
            this.pnlReviewsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReviews)).BeginInit();
            this.pnlReviewsFilter.SuspendLayout();
            this.grpWriteReview.SuspendLayout();
            this.tabWallet.SuspendLayout();
            this.pnlWalletHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTransactions)).BeginInit();
            this.pnlTxFilter.SuspendLayout();
            this.grpTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUpAmount)).BeginInit();
            this.pnlBalanceBox.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.grpChangePass.SuspendLayout();
            this.grpProfileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStudentHeader
            // 
            this.pnlStudentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlStudentHeader.Controls.Add(this.btnStudentAbout);
            this.pnlStudentHeader.Controls.Add(this.btnStudentLogout);
            this.pnlStudentHeader.Controls.Add(this.btnQuickTopUp);
            this.pnlStudentHeader.Controls.Add(this.lblHeaderBalance);
            this.pnlStudentHeader.Controls.Add(this.lblStudentName);
            this.pnlStudentHeader.Controls.Add(this.lblPortalTitle);
            this.pnlStudentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentHeader.Name = "pnlStudentHeader";
            this.pnlStudentHeader.Size = new System.Drawing.Size(1280, 60);
            this.pnlStudentHeader.TabIndex = 0;
            // 
            // btnStudentAbout
            // 
            this.btnStudentAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnStudentAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnStudentAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStudentAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnStudentAbout.Location = new System.Drawing.Point(1058, 14);
            this.btnStudentAbout.Name = "btnStudentAbout";
            this.btnStudentAbout.Size = new System.Drawing.Size(102, 32);
            this.btnStudentAbout.TabIndex = 5;
            this.btnStudentAbout.Text = "👥 Giới thiệu";
            this.btnStudentAbout.UseVisualStyleBackColor = false;
            this.btnStudentAbout.Click += new System.EventHandler(this.btnStudentAbout_Click);
            // 
            // btnStudentLogout
            // 
            this.btnStudentLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnStudentLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnStudentLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStudentLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnStudentLogout.Location = new System.Drawing.Point(1168, 14);
            this.btnStudentLogout.Name = "btnStudentLogout";
            this.btnStudentLogout.Size = new System.Drawing.Size(100, 32);
            this.btnStudentLogout.TabIndex = 4;
            this.btnStudentLogout.Text = "Đăng xuất";
            this.btnStudentLogout.UseVisualStyleBackColor = false;
            this.btnStudentLogout.Click += new System.EventHandler(this.btnStudentLogout_Click);
            // 
            // btnQuickTopUp
            // 
            this.btnQuickTopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnQuickTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickTopUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnQuickTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickTopUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuickTopUp.ForeColor = System.Drawing.Color.White;
            this.btnQuickTopUp.Location = new System.Drawing.Point(946, 14);
            this.btnQuickTopUp.Name = "btnQuickTopUp";
            this.btnQuickTopUp.Size = new System.Drawing.Size(104, 32);
            this.btnQuickTopUp.TabIndex = 3;
            this.btnQuickTopUp.Text = "Nộp học phí";
            this.btnQuickTopUp.UseVisualStyleBackColor = false;
            this.btnQuickTopUp.Click += new System.EventHandler(this.btnQuickTopUp_Click);
            // 
            // lblHeaderBalance
            // 
            this.lblHeaderBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.lblHeaderBalance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderBalance.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBalance.Location = new System.Drawing.Point(725, 14);
            this.lblHeaderBalance.Name = "lblHeaderBalance";
            this.lblHeaderBalance.Size = new System.Drawing.Size(210, 32);
            this.lblHeaderBalance.TabIndex = 2;
            this.lblHeaderBalance.Text = "Số dư học phí: 0 VNĐ";
            this.lblHeaderBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStudentName.Location = new System.Drawing.Point(430, 19);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(285, 22);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Học viên: ---";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPortalTitle
            // 
            this.lblPortalTitle.AutoSize = true;
            this.lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblPortalTitle.ForeColor = System.Drawing.Color.White;
            this.lblPortalTitle.Location = new System.Drawing.Point(16, 17);
            this.lblPortalTitle.Name = "lblPortalTitle";
            this.lblPortalTitle.Size = new System.Drawing.Size(224, 23);
            this.lblPortalTitle.TabIndex = 0;
            this.lblPortalTitle.Text = "Cổng thông tin học viên";
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabCatalog);
            this.tabStudent.Controls.Add(this.tabMyCourses);
            this.tabStudent.Controls.Add(this.tabTimetable);
            this.tabStudent.Controls.Add(this.tabReviews);
            this.tabStudent.Controls.Add(this.tabWallet);
            this.tabStudent.Controls.Add(this.tabProfile);
            this.tabStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStudent.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.tabStudent.ItemSize = new System.Drawing.Size(198, 34);
            this.tabStudent.Location = new System.Drawing.Point(0, 60);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(1280, 680);
            this.tabStudent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStudent.TabIndex = 1;
            this.tabStudent.SelectedIndexChanged += new System.EventHandler(this.tabStudent_SelectedIndexChanged);
            // 
            // tabCatalog
            // 
            this.tabCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabCatalog.Controls.Add(this.pnlCatalogMain);
            this.tabCatalog.Controls.Add(this.grpCourseCheckout);
            this.tabCatalog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabCatalog.Location = new System.Drawing.Point(4, 38);
            this.tabCatalog.Name = "tabCatalog";
            this.tabCatalog.Padding = new System.Windows.Forms.Padding(10);
            this.tabCatalog.Size = new System.Drawing.Size(1272, 638);
            this.tabCatalog.TabIndex = 0;
            this.tabCatalog.Text = "Danh sách khóa học";
            // 
            // pnlCatalogMain
            // 
            this.pnlCatalogMain.Controls.Add(this.dgvCatalog);
            this.pnlCatalogMain.Controls.Add(this.pnlCatalogFilter);
            this.pnlCatalogMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCatalogMain.Location = new System.Drawing.Point(10, 10);
            this.pnlCatalogMain.Name = "pnlCatalogMain";
            this.pnlCatalogMain.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlCatalogMain.Size = new System.Drawing.Size(867, 618);
            this.pnlCatalogMain.TabIndex = 0;
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataSource = typeof(Course_Registration.Course);
            // 
            // myCoursesBindingSource
            // 
            this.myCoursesBindingSource.DataSource = typeof(Course_Registration.Enrollment);
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // studentReviewsBindingSource
            // 
            this.studentReviewsBindingSource.DataSource = typeof(Course_Registration.CourseReview);
            // 
            // myTransactionsBindingSource
            // 
            this.myTransactionsBindingSource.DataSource = typeof(Course_Registration.WalletTransaction);
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            dgvAlt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCatalog.AlternatingRowsDefaultCellStyle = dgvAlt1;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dgvHeader1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeader1.ForeColor = System.Drawing.Color.White;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle = dgvHeader1;
            this.dgvCatalog.ColumnHeadersHeight = 36;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalog.AutoGenerateColumns = false;
            this.dgvCatalog.DataSource = this.catalogBindingSource;
            this.dgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalog.EnableHeadersVisualStyles = false;
                        this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCat_CourseID,

                this.colCat_CourseCode,

                this.colCat_CourseName,

                this.colCat_Instructor,

                this.colCat_ScheduleShort,

                this.colCat_Room,

                this.colCat_RatingDisplay,

                this.colCat_Price,

                this.colCat_Remaining,

                this.colCat_MyState
            });

            this.dgvCatalog.Location = new System.Drawing.Point(0, 52);
            this.dgvCatalog.MultiSelect = false;
            this.dgvCatalog.Name = "dgvCatalog";
            // 
            // colCat_CourseID
            // 
            this.colCat_CourseID.DataPropertyName = "CourseID";
            this.colCat_CourseID.HeaderText = "Mã ID";
            this.colCat_CourseID.Name = "colCat_CourseID";
            this.colCat_CourseID.ReadOnly = true;
            this.colCat_CourseID.FillWeight = 30F;
            this.colCat_CourseID.Width = 60;
            this.colCat_CourseID.Visible = false;
            // 
            // colCat_CourseCode
            // 
            this.colCat_CourseCode.DataPropertyName = "CourseCode";
            this.colCat_CourseCode.HeaderText = "Mã khóa học";
            this.colCat_CourseCode.Name = "colCat_CourseCode";
            this.colCat_CourseCode.ReadOnly = true;
            this.colCat_CourseCode.FillWeight = 62F;
            this.colCat_CourseCode.Width = 62;
            // 
            // colCat_CourseName
            // 
            this.colCat_CourseName.DataPropertyName = "CourseName";
            this.colCat_CourseName.HeaderText = "Tên khóa học";
            this.colCat_CourseName.Name = "colCat_CourseName";
            this.colCat_CourseName.ReadOnly = true;
            this.colCat_CourseName.FillWeight = 165F;
            this.colCat_CourseName.Width = 165;
            // 
            // colCat_Instructor
            // 
            this.colCat_Instructor.DataPropertyName = "Instructor";
            this.colCat_Instructor.HeaderText = "Giảng viên";
            this.colCat_Instructor.Name = "colCat_Instructor";
            this.colCat_Instructor.ReadOnly = true;
            this.colCat_Instructor.FillWeight = 105F;
            this.colCat_Instructor.Width = 105;
            // 
            // colCat_ScheduleShort
            // 
            this.colCat_ScheduleShort.DataPropertyName = "ScheduleShort";
            this.colCat_ScheduleShort.HeaderText = "Lịch học";
            this.colCat_ScheduleShort.Name = "colCat_ScheduleShort";
            this.colCat_ScheduleShort.ReadOnly = true;
            this.colCat_ScheduleShort.FillWeight = 108F;
            this.colCat_ScheduleShort.Width = 108;
            // 
            // colCat_Room
            // 
            this.colCat_Room.DataPropertyName = "Room";
            this.colCat_Room.HeaderText = "Phòng";
            this.colCat_Room.Name = "colCat_Room";
            this.colCat_Room.ReadOnly = true;
            this.colCat_Room.FillWeight = 82F;
            this.colCat_Room.Width = 82;
            // 
            // colCat_RatingDisplay
            // 
            this.colCat_RatingDisplay.DataPropertyName = "RatingDisplay";
            this.colCat_RatingDisplay.HeaderText = "Đánh giá";
            this.colCat_RatingDisplay.Name = "colCat_RatingDisplay";
            this.colCat_RatingDisplay.ReadOnly = true;
            this.colCat_RatingDisplay.FillWeight = 82F;
            this.colCat_RatingDisplay.Width = 82;
            // 
            // colCat_Price
            // 
            this.colCat_Price.DataPropertyName = "Price";
            this.colCat_Price.HeaderText = "Học phí (VNĐ)";
            this.colCat_Price.Name = "colCat_Price";
            this.colCat_Price.ReadOnly = true;
            this.colCat_Price.FillWeight = 88F;
            this.colCat_Price.Width = 88;
            this.colCat_Price.DefaultCellStyle.Format = "N0";
            // 
            // colCat_Remaining
            // 
            this.colCat_Remaining.DataPropertyName = "Remaining";
            this.colCat_Remaining.HeaderText = "Còn trống";
            this.colCat_Remaining.Name = "colCat_Remaining";
            this.colCat_Remaining.ReadOnly = true;
            this.colCat_Remaining.FillWeight = 64F;
            this.colCat_Remaining.Width = 64;
            // 
            // colCat_MyState
            // 
            this.colCat_MyState.DataPropertyName = "MyState";
            this.colCat_MyState.HeaderText = "Trạng thái";
            this.colCat_MyState.Name = "colCat_MyState";
            this.colCat_MyState.ReadOnly = true;
            this.colCat_MyState.FillWeight = 88F;
            this.colCat_MyState.Width = 88;


            // 
            // colCatalog_CourseID
            // 
            // 
            // colCatalog_CourseCode
            // 
            // 
            // colCatalog_CourseName
            // 
            // 
            // colCatalog_Instructor
            // 
            // 
            // colCatalog_ScheduleShort
            // 
            // 
            // colCatalog_Room
            // 
            // 
            // colCatalog_RatingDisplay
            // 
            // 
            // colCatalog_Price
            // 
            // 
            // colCatalog_Remaining
            // 
            // 
            // colCatalog_MyState
            // 
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.RowTemplate.Height = 32;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(857, 566);
            this.dgvCatalog.TabIndex = 1;
            this.dgvCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellClick);
            this.dgvCatalog.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCatalog_CellFormatting);
            this.dgvCatalog.SelectionChanged += new System.EventHandler(this.dgvCatalog_SelectionChanged);
            // 
            // pnlCatalogFilter
            // 
            this.pnlCatalogFilter.BackColor = System.Drawing.Color.White;
            this.pnlCatalogFilter.Controls.Add(this.btnCatalogReset);
            this.pnlCatalogFilter.Controls.Add(this.cboCatalogSort);
            this.pnlCatalogFilter.Controls.Add(this.cboCatalogCategory);
            this.pnlCatalogFilter.Controls.Add(this.txtCatalogSearch);
            this.pnlCatalogFilter.Controls.Add(this.lblFind);
            this.pnlCatalogFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCatalogFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlCatalogFilter.Name = "pnlCatalogFilter";
            this.pnlCatalogFilter.Size = new System.Drawing.Size(857, 52);
            this.pnlCatalogFilter.TabIndex = 0;
            // 
            // btnCatalogReset
            // 
            this.btnCatalogReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnCatalogReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCatalogReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogReset.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnCatalogReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCatalogReset.Location = new System.Drawing.Point(752, 11);
            this.btnCatalogReset.Name = "btnCatalogReset";
            this.btnCatalogReset.Size = new System.Drawing.Size(92, 29);
            this.btnCatalogReset.TabIndex = 4;
            this.btnCatalogReset.Text = "Đặt lại";
            this.btnCatalogReset.UseVisualStyleBackColor = false;
            this.btnCatalogReset.Click += new System.EventHandler(this.btnCatalogReset_Click);
            // 
            // cboCatalogSort
            // 
            this.cboCatalogSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatalogSort.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboCatalogSort.Items.AddRange(new object[] {
            "Sắp xếp: Mới nhất",
            "Học phí tăng dần",
            "Học phí giảm dần",
            "Sắp khai giảng",
            "Đánh giá cao nhất"});
            this.cboCatalogSort.Location = new System.Drawing.Point(550, 13);
            this.cboCatalogSort.Name = "cboCatalogSort";
            this.cboCatalogSort.Size = new System.Drawing.Size(192, 24);
            this.cboCatalogSort.TabIndex = 3;
            this.cboCatalogSort.SelectedIndexChanged += new System.EventHandler(this.CatalogFilter_Changed);
            // 
            // cboCatalogCategory
            // 
            this.cboCatalogCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatalogCategory.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboCatalogCategory.Location = new System.Drawing.Point(330, 13);
            this.cboCatalogCategory.Name = "cboCatalogCategory";
            this.cboCatalogCategory.Size = new System.Drawing.Size(210, 24);
            this.cboCatalogCategory.TabIndex = 2;
            this.cboCatalogCategory.SelectedIndexChanged += new System.EventHandler(this.CatalogFilter_Changed);
            // 
            // txtCatalogSearch
            // 
            this.txtCatalogSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatalogSearch.Location = new System.Drawing.Point(82, 13);
            this.txtCatalogSearch.Name = "txtCatalogSearch";
            this.txtCatalogSearch.Size = new System.Drawing.Size(238, 24);
            this.txtCatalogSearch.TabIndex = 1;
            this.txtCatalogSearch.TextChanged += new System.EventHandler(this.CatalogFilter_Changed);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFind.Location = new System.Drawing.Point(12, 16);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(62, 15);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Tìm kiếm:";
            // 
            // grpCourseCheckout
            // 
            this.grpCourseCheckout.BackColor = System.Drawing.Color.White;
            this.grpCourseCheckout.Controls.Add(this.btnBuyCourse);
            this.grpCourseCheckout.Controls.Add(this.txtBuyNote);
            this.grpCourseCheckout.Controls.Add(this.lblBuyNote);
            this.grpCourseCheckout.Controls.Add(this.lblSelPrice);
            this.grpCourseCheckout.Controls.Add(this.lblVoucherStatus);
            this.grpCourseCheckout.Controls.Add(this.btnApplyVoucher);
            this.grpCourseCheckout.Controls.Add(this.txtVoucherCode);
            this.grpCourseCheckout.Controls.Add(this.lblVoucherTitle);
            this.grpCourseCheckout.Controls.Add(this.txtSelDescription);
            this.grpCourseCheckout.Controls.Add(this.lblSelDescTitle);
            this.grpCourseCheckout.Controls.Add(this.lblConflictWarning);
            this.grpCourseCheckout.Controls.Add(this.lblSelSlots);
            this.grpCourseCheckout.Controls.Add(this.lblSelClassTime);
            this.grpCourseCheckout.Controls.Add(this.lblSelSchedule);
            this.grpCourseCheckout.Controls.Add(this.lblSelInstructor);
            this.grpCourseCheckout.Controls.Add(this.lblSelCategory);
            this.grpCourseCheckout.Controls.Add(this.lblSelName);
            this.grpCourseCheckout.Controls.Add(this.lblSelRating);
            this.grpCourseCheckout.Controls.Add(this.lblSelCode);
            this.grpCourseCheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpCourseCheckout.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.grpCourseCheckout.Location = new System.Drawing.Point(877, 10);
            this.grpCourseCheckout.Name = "grpCourseCheckout";
            this.grpCourseCheckout.Size = new System.Drawing.Size(385, 618);
            this.grpCourseCheckout.TabIndex = 1;
            this.grpCourseCheckout.TabStop = false;
            this.grpCourseCheckout.Text = "Thông tin và đăng ký khóa học";
            // 
            // lblSelCode
            // 
            this.lblSelCode.AutoSize = true;
            this.lblSelCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSelCode.Location = new System.Drawing.Point(16, 26);
            this.lblSelCode.Name = "lblSelCode";
            this.lblSelCode.Size = new System.Drawing.Size(96, 15);
            this.lblSelCode.TabIndex = 0;
            this.lblSelCode.Text = "Mã khóa học: ---";
            // 
            // lblSelRating
            // 
            this.lblSelRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblSelRating.Location = new System.Drawing.Point(188, 25);
            this.lblSelRating.Name = "lblSelRating";
            this.lblSelRating.Size = new System.Drawing.Size(181, 18);
            this.lblSelRating.TabIndex = 1;
            this.lblSelRating.Text = "Đánh giá: ---";
            this.lblSelRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelName
            // 
            this.lblSelName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSelName.Location = new System.Drawing.Point(16, 48);
            this.lblSelName.Name = "lblSelName";
            this.lblSelName.Size = new System.Drawing.Size(353, 44);
            this.lblSelName.TabIndex = 2;
            this.lblSelName.Text = "Chọn một khóa học bên trái";
            // 
            // lblSelCategory
            // 
            this.lblSelCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelCategory.Location = new System.Drawing.Point(16, 94);
            this.lblSelCategory.Name = "lblSelCategory";
            this.lblSelCategory.Size = new System.Drawing.Size(353, 20);
            this.lblSelCategory.TabIndex = 3;
            this.lblSelCategory.Text = "Danh mục: ---";
            // 
            // lblSelInstructor
            // 
            this.lblSelInstructor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelInstructor.Location = new System.Drawing.Point(16, 116);
            this.lblSelInstructor.Name = "lblSelInstructor";
            this.lblSelInstructor.Size = new System.Drawing.Size(353, 20);
            this.lblSelInstructor.TabIndex = 4;
            this.lblSelInstructor.Text = "Giảng viên: ---";
            // 
            // lblSelSchedule
            // 
            this.lblSelSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelSchedule.Location = new System.Drawing.Point(16, 138);
            this.lblSelSchedule.Name = "lblSelSchedule";
            this.lblSelSchedule.Size = new System.Drawing.Size(353, 20);
            this.lblSelSchedule.TabIndex = 5;
            this.lblSelSchedule.Text = "Thời lượng: --- | Khai giảng: ---";
            // 
            // lblSelClassTime
            // 
            this.lblSelClassTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelClassTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblSelClassTime.Location = new System.Drawing.Point(16, 160);
            this.lblSelClassTime.Name = "lblSelClassTime";
            this.lblSelClassTime.Size = new System.Drawing.Size(353, 20);
            this.lblSelClassTime.TabIndex = 6;
            this.lblSelClassTime.Text = "Lịch học: --- | Phòng: ---";
            // 
            // lblSelSlots
            // 
            this.lblSelSlots.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelSlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelSlots.Location = new System.Drawing.Point(16, 182);
            this.lblSelSlots.Name = "lblSelSlots";
            this.lblSelSlots.Size = new System.Drawing.Size(353, 20);
            this.lblSelSlots.TabIndex = 7;
            this.lblSelSlots.Text = "Chỗ còn trống: ---";
            // 
            // lblConflictWarning
            // 
            this.lblConflictWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblConflictWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConflictWarning.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblConflictWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblConflictWarning.Location = new System.Drawing.Point(16, 205);
            this.lblConflictWarning.Name = "lblConflictWarning";
            this.lblConflictWarning.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblConflictWarning.Size = new System.Drawing.Size(353, 40);
            this.lblConflictWarning.TabIndex = 8;
            this.lblConflictWarning.Text = "Cảnh báo trùng lịch học";
            this.lblConflictWarning.Visible = false;
            // 
            // lblSelDescTitle
            // 
            this.lblSelDescTitle.AutoSize = true;
            this.lblSelDescTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelDescTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelDescTitle.Location = new System.Drawing.Point(16, 250);
            this.lblSelDescTitle.Name = "lblSelDescTitle";
            this.lblSelDescTitle.Size = new System.Drawing.Size(108, 15);
            this.lblSelDescTitle.TabIndex = 9;
            this.lblSelDescTitle.Text = "Nội dung tóm tắt:";
            // 
            // txtSelDescription
            // 
            this.txtSelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSelDescription.Location = new System.Drawing.Point(16, 270);
            this.txtSelDescription.Multiline = true;
            this.txtSelDescription.Name = "txtSelDescription";
            this.txtSelDescription.ReadOnly = true;
            this.txtSelDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelDescription.Size = new System.Drawing.Size(353, 76);
            this.txtSelDescription.TabIndex = 10;
            // 
            // lblVoucherTitle
            // 
            this.lblVoucherTitle.AutoSize = true;
            this.lblVoucherTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVoucherTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblVoucherTitle.Location = new System.Drawing.Point(16, 354);
            this.lblVoucherTitle.Name = "lblVoucherTitle";
            this.lblVoucherTitle.Size = new System.Drawing.Size(196, 15);
            this.lblVoucherTitle.TabIndex = 11;
            this.lblVoucherTitle.Text = "Mã học bổng / miễn giảm học phí:";
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVoucherCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtVoucherCode.Location = new System.Drawing.Point(16, 374);
            this.txtVoucherCode.MaxLength = 30;
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(228, 24);
            this.txtVoucherCode.TabIndex = 12;
            // 
            // btnApplyVoucher
            // 
            this.btnApplyVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnApplyVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyVoucher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnApplyVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyVoucher.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnApplyVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnApplyVoucher.Location = new System.Drawing.Point(252, 372);
            this.btnApplyVoucher.Name = "btnApplyVoucher";
            this.btnApplyVoucher.Size = new System.Drawing.Size(117, 28);
            this.btnApplyVoucher.TabIndex = 13;
            this.btnApplyVoucher.Text = "Áp dụng mã";
            this.btnApplyVoucher.UseVisualStyleBackColor = false;
            this.btnApplyVoucher.Click += new System.EventHandler(this.btnApplyVoucher_Click);
            // 
            // lblVoucherStatus
            // 
            this.lblVoucherStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVoucherStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVoucherStatus.Location = new System.Drawing.Point(16, 404);
            this.lblVoucherStatus.Name = "lblVoucherStatus";
            this.lblVoucherStatus.Size = new System.Drawing.Size(353, 34);
            this.lblVoucherStatus.TabIndex = 14;
            this.lblVoucherStatus.Text = "Có thể nhập mã học bổng nếu đủ điều kiện.";
            // 
            // lblSelPrice
            // 
            this.lblSelPrice.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblSelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblSelPrice.Location = new System.Drawing.Point(16, 444);
            this.lblSelPrice.Name = "lblSelPrice";
            this.lblSelPrice.Size = new System.Drawing.Size(353, 26);
            this.lblSelPrice.TabIndex = 15;
            this.lblSelPrice.Text = "Học phí thanh toán: 0 VNĐ";
            // 
            // lblBuyNote
            // 
            this.lblBuyNote.AutoSize = true;
            this.lblBuyNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuyNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBuyNote.Location = new System.Drawing.Point(16, 478);
            this.lblBuyNote.Name = "lblBuyNote";
            this.lblBuyNote.Size = new System.Drawing.Size(96, 15);
            this.lblBuyNote.TabIndex = 16;
            this.lblBuyNote.Text = "Ghi chú đăng ký:";
            // 
            // txtBuyNote
            // 
            this.txtBuyNote.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuyNote.Location = new System.Drawing.Point(16, 498);
            this.txtBuyNote.MaxLength = 200;
            this.txtBuyNote.Name = "txtBuyNote";
            this.txtBuyNote.Size = new System.Drawing.Size(353, 24);
            this.txtBuyNote.TabIndex = 17;
            // 
            // btnBuyCourse
            // 
            this.btnBuyCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnBuyCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyCourse.FlatAppearance.BorderSize = 0;
            this.btnBuyCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuyCourse.ForeColor = System.Drawing.Color.White;
            this.btnBuyCourse.Location = new System.Drawing.Point(16, 538);
            this.btnBuyCourse.Name = "btnBuyCourse";
            this.btnBuyCourse.Size = new System.Drawing.Size(353, 44);
            this.btnBuyCourse.TabIndex = 18;
            this.btnBuyCourse.Text = "Đăng ký khóa học";
            this.btnBuyCourse.UseVisualStyleBackColor = false;
            this.btnBuyCourse.Click += new System.EventHandler(this.btnBuyCourse_Click);
            // 
            // tabMyCourses
            // 
            this.tabMyCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabMyCourses.Controls.Add(this.pnlMyCoursesList);
            this.tabMyCourses.Controls.Add(this.grpMyCourseDetail);
            this.tabMyCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabMyCourses.Location = new System.Drawing.Point(4, 38);
            this.tabMyCourses.Name = "tabMyCourses";
            this.tabMyCourses.Padding = new System.Windows.Forms.Padding(10);
            this.tabMyCourses.Size = new System.Drawing.Size(1272, 638);
            this.tabMyCourses.TabIndex = 1;
            this.tabMyCourses.Text = "Khóa học đã đăng ký";
            // 
            // pnlMyCoursesList
            // 
            this.pnlMyCoursesList.Controls.Add(this.dgvMyCourses);
            this.pnlMyCoursesList.Controls.Add(this.pnlMyCoursesFilter);
            this.pnlMyCoursesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyCoursesList.Location = new System.Drawing.Point(10, 10);
            this.pnlMyCoursesList.Name = "pnlMyCoursesList";
            this.pnlMyCoursesList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlMyCoursesList.Size = new System.Drawing.Size(877, 618);
            this.pnlMyCoursesList.TabIndex = 0;
            // 
            // dgvMyCourses
            // 
            this.dgvMyCourses.AllowUserToAddRows = false;
            this.dgvMyCourses.AllowUserToDeleteRows = false;
            dgvAlt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvMyCourses.AlternatingRowsDefaultCellStyle = dgvAlt2;
            this.dgvMyCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dgvHeader2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeader2.ForeColor = System.Drawing.Color.White;
            this.dgvMyCourses.ColumnHeadersDefaultCellStyle = dgvHeader2;
            this.dgvMyCourses.ColumnHeadersHeight = 36;
            this.dgvMyCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyCourses.AutoGenerateColumns = false;
            this.dgvMyCourses.DataSource = this.myCoursesBindingSource;
            this.dgvMyCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyCourses.EnableHeadersVisualStyles = false;
                        this.dgvMyCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMy_EnrollmentID,

                this.colMy_CourseCode,

                this.colMy_CourseName,

                this.colMy_ScheduleText,

                this.colMy_Room,

                this.colMy_OriginalPrice,

                this.colMy_DiscountAmount,

                this.colMy_PaidAmount,

                this.colMy_EnrollDate,

                this.colMy_StatusDisplay
            });

            this.dgvMyCourses.Location = new System.Drawing.Point(0, 52);
            this.dgvMyCourses.MultiSelect = false;
            this.dgvMyCourses.Name = "dgvMyCourses";
            // 
            // colMy_EnrollmentID
            // 
            this.colMy_EnrollmentID.DataPropertyName = "EnrollmentID";
            this.colMy_EnrollmentID.HeaderText = "Mã ĐK";
            this.colMy_EnrollmentID.Name = "colMy_EnrollmentID";
            this.colMy_EnrollmentID.ReadOnly = true;
            this.colMy_EnrollmentID.FillWeight = 52F;
            this.colMy_EnrollmentID.Width = 60;
            // 
            // colMy_CourseCode
            // 
            this.colMy_CourseCode.DataPropertyName = "CourseCode";
            this.colMy_CourseCode.HeaderText = "Mã khóa học";
            this.colMy_CourseCode.Name = "colMy_CourseCode";
            this.colMy_CourseCode.ReadOnly = true;
            this.colMy_CourseCode.FillWeight = 62F;
            this.colMy_CourseCode.Width = 62;
            // 
            // colMy_CourseName
            // 
            this.colMy_CourseName.DataPropertyName = "CourseName";
            this.colMy_CourseName.HeaderText = "Tên khóa học";
            this.colMy_CourseName.Name = "colMy_CourseName";
            this.colMy_CourseName.ReadOnly = true;
            this.colMy_CourseName.FillWeight = 165F;
            this.colMy_CourseName.Width = 165;
            // 
            // colMy_ScheduleText
            // 
            this.colMy_ScheduleText.DataPropertyName = "ScheduleText";
            this.colMy_ScheduleText.HeaderText = "Lịch học";
            this.colMy_ScheduleText.Name = "colMy_ScheduleText";
            this.colMy_ScheduleText.ReadOnly = true;
            this.colMy_ScheduleText.FillWeight = 105F;
            this.colMy_ScheduleText.Width = 105;
            // 
            // colMy_Room
            // 
            this.colMy_Room.DataPropertyName = "Room";
            this.colMy_Room.HeaderText = "Phòng";
            this.colMy_Room.Name = "colMy_Room";
            this.colMy_Room.ReadOnly = true;
            this.colMy_Room.FillWeight = 82F;
            this.colMy_Room.Width = 82;
            // 
            // colMy_OriginalPrice
            // 
            this.colMy_OriginalPrice.DataPropertyName = "OriginalPrice";
            this.colMy_OriginalPrice.HeaderText = "Học phí gốc (VNĐ)";
            this.colMy_OriginalPrice.Name = "colMy_OriginalPrice";
            this.colMy_OriginalPrice.ReadOnly = true;
            this.colMy_OriginalPrice.FillWeight = 82F;
            this.colMy_OriginalPrice.Width = 82;
            this.colMy_OriginalPrice.DefaultCellStyle.Format = "N0";
            // 
            // colMy_DiscountAmount
            // 
            this.colMy_DiscountAmount.DataPropertyName = "DiscountAmount";
            this.colMy_DiscountAmount.HeaderText = "Miễn giảm (VNĐ)";
            this.colMy_DiscountAmount.Name = "colMy_DiscountAmount";
            this.colMy_DiscountAmount.ReadOnly = true;
            this.colMy_DiscountAmount.FillWeight = 76F;
            this.colMy_DiscountAmount.Width = 76;
            this.colMy_DiscountAmount.DefaultCellStyle.Format = "N0";
            // 
            // colMy_PaidAmount
            // 
            this.colMy_PaidAmount.DataPropertyName = "PaidAmount";
            this.colMy_PaidAmount.HeaderText = "Thực đóng (VNĐ)";
            this.colMy_PaidAmount.Name = "colMy_PaidAmount";
            this.colMy_PaidAmount.ReadOnly = true;
            this.colMy_PaidAmount.FillWeight = 84F;
            this.colMy_PaidAmount.Width = 84;
            this.colMy_PaidAmount.DefaultCellStyle.Format = "N0";
            // 
            // colMy_EnrollDate
            // 
            this.colMy_EnrollDate.DataPropertyName = "EnrollDate";
            this.colMy_EnrollDate.HeaderText = "Ngày đăng ký";
            this.colMy_EnrollDate.Name = "colMy_EnrollDate";
            this.colMy_EnrollDate.ReadOnly = true;
            this.colMy_EnrollDate.FillWeight = 80F;
            this.colMy_EnrollDate.Width = 80;
            this.colMy_EnrollDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            // 
            // colMy_StatusDisplay
            // 
            this.colMy_StatusDisplay.DataPropertyName = "StatusDisplay";
            this.colMy_StatusDisplay.HeaderText = "Trạng thái";
            this.colMy_StatusDisplay.Name = "colMy_StatusDisplay";
            this.colMy_StatusDisplay.ReadOnly = true;
            this.colMy_StatusDisplay.FillWeight = 82F;
            this.colMy_StatusDisplay.Width = 82;


            // 
            // colMyCourses_EnrollmentID
            // 
            // 
            // colMyCourses_CourseCode
            // 
            // 
            // colMyCourses_CourseName
            // 
            // 
            // colMyCourses_ScheduleText
            // 
            // 
            // colMyCourses_Room
            // 
            // 
            // colMyCourses_OriginalPrice
            // 
            // 
            // colMyCourses_DiscountAmount
            // 
            // 
            // colMyCourses_PaidAmount
            // 
            // 
            // colMyCourses_EnrollDate
            // 
            // 
            // colMyCourses_StatusDisplay
            // 
            this.dgvMyCourses.ReadOnly = true;
            this.dgvMyCourses.RowHeadersVisible = false;
            this.dgvMyCourses.RowTemplate.Height = 32;
            this.dgvMyCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyCourses.Size = new System.Drawing.Size(867, 566);
            this.dgvMyCourses.TabIndex = 1;
            this.dgvMyCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyCourses_CellClick);
            // 
            // pnlMyCoursesFilter
            // 
            this.pnlMyCoursesFilter.BackColor = System.Drawing.Color.White;
            this.pnlMyCoursesFilter.Controls.Add(this.btnExportMyCourses);
            this.pnlMyCoursesFilter.Controls.Add(this.lblMySummary);
            this.pnlMyCoursesFilter.Controls.Add(this.cboMyCourseStatus);
            this.pnlMyCoursesFilter.Controls.Add(this.txtSearchMyCourse);
            this.pnlMyCoursesFilter.Controls.Add(this.lblMySearch);
            this.pnlMyCoursesFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMyCoursesFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlMyCoursesFilter.Name = "pnlMyCoursesFilter";
            this.pnlMyCoursesFilter.Size = new System.Drawing.Size(867, 52);
            this.pnlMyCoursesFilter.TabIndex = 0;
            // 
            // btnExportMyCourses
            // 
            this.btnExportMyCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportMyCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportMyCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportMyCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportMyCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportMyCourses.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportMyCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportMyCourses.Location = new System.Drawing.Point(752, 11);
            this.btnExportMyCourses.Name = "btnExportMyCourses";
            this.btnExportMyCourses.Size = new System.Drawing.Size(102, 29);
            this.btnExportMyCourses.TabIndex = 4;
            this.btnExportMyCourses.Text = "Xuất Excel";
            this.btnExportMyCourses.UseVisualStyleBackColor = false;
            this.btnExportMyCourses.Click += new System.EventHandler(this.btnExportMyCourses_Click);
            // 
            // lblMySummary
            // 
            this.lblMySummary.AutoSize = true;
            this.lblMySummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblMySummary.Location = new System.Drawing.Point(432, 17);
            this.lblMySummary.Name = "lblMySummary";
            this.lblMySummary.Size = new System.Drawing.Size(218, 15);
            this.lblMySummary.TabIndex = 3;
            this.lblMySummary.Text = "Đang theo học: 0 khóa | 0 VNĐ";
            // 
            // cboMyCourseStatus
            // 
            this.cboMyCourseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMyCourseStatus.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboMyCourseStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang theo học",
            "Đã hủy"});
            this.cboMyCourseStatus.Location = new System.Drawing.Point(272, 13);
            this.cboMyCourseStatus.Name = "cboMyCourseStatus";
            this.cboMyCourseStatus.Size = new System.Drawing.Size(148, 24);
            this.cboMyCourseStatus.TabIndex = 2;
            this.cboMyCourseStatus.SelectedIndexChanged += new System.EventHandler(this.MyCoursesFilter_Changed);
            // 
            // txtSearchMyCourse
            // 
            this.txtSearchMyCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchMyCourse.Location = new System.Drawing.Point(78, 13);
            this.txtSearchMyCourse.Name = "txtSearchMyCourse";
            this.txtSearchMyCourse.Size = new System.Drawing.Size(184, 24);
            this.txtSearchMyCourse.TabIndex = 1;
            this.txtSearchMyCourse.TextChanged += new System.EventHandler(this.MyCoursesFilter_Changed);
            // 
            // lblMySearch
            // 
            this.lblMySearch.AutoSize = true;
            this.lblMySearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMySearch.Location = new System.Drawing.Point(12, 16);
            this.lblMySearch.Name = "lblMySearch";
            this.lblMySearch.Size = new System.Drawing.Size(62, 15);
            this.lblMySearch.TabIndex = 0;
            this.lblMySearch.Text = "Tìm kiếm:";
            // 
            // grpMyCourseDetail
            // 
            this.grpMyCourseDetail.BackColor = System.Drawing.Color.White;
            this.grpMyCourseDetail.Controls.Add(this.btnCancelMyCourse);
            this.grpMyCourseDetail.Controls.Add(this.btnPrintStudentReceipt);
            this.grpMyCourseDetail.Controls.Add(this.btnSaveMyNote);
            this.grpMyCourseDetail.Controls.Add(this.txtMyEnrollNote);
            this.grpMyCourseDetail.Controls.Add(this.lblMyNote);
            this.grpMyCourseDetail.Controls.Add(this.lblMyEnrollInfo);
            this.grpMyCourseDetail.Controls.Add(this.txtMyCourseTitle);
            this.grpMyCourseDetail.Controls.Add(this.lblMyCourseTitle);
            this.grpMyCourseDetail.Controls.Add(this.txtMyEnrollmentId);
            this.grpMyCourseDetail.Controls.Add(this.lblMyEnrollId);
            this.grpMyCourseDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMyCourseDetail.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.grpMyCourseDetail.Location = new System.Drawing.Point(887, 10);
            this.grpMyCourseDetail.Name = "grpMyCourseDetail";
            this.grpMyCourseDetail.Size = new System.Drawing.Size(375, 618);
            this.grpMyCourseDetail.TabIndex = 1;
            this.grpMyCourseDetail.TabStop = false;
            this.grpMyCourseDetail.Text = "Chi tiết khóa học đăng ký";
            // 
            // lblMyEnrollId
            // 
            this.lblMyEnrollId.AutoSize = true;
            this.lblMyEnrollId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyEnrollId.Location = new System.Drawing.Point(16, 30);
            this.lblMyEnrollId.Name = "lblMyEnrollId";
            this.lblMyEnrollId.Size = new System.Drawing.Size(81, 15);
            this.lblMyEnrollId.TabIndex = 0;
            this.lblMyEnrollId.Text = "Mã đăng ký:";
            // 
            // txtMyEnrollmentId
            // 
            this.txtMyEnrollmentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMyEnrollmentId.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMyEnrollmentId.Location = new System.Drawing.Point(110, 27);
            this.txtMyEnrollmentId.Name = "txtMyEnrollmentId";
            this.txtMyEnrollmentId.ReadOnly = true;
            this.txtMyEnrollmentId.Size = new System.Drawing.Size(110, 24);
            this.txtMyEnrollmentId.TabIndex = 1;
            this.txtMyEnrollmentId.Text = "---";
            // 
            // lblMyCourseTitle
            // 
            this.lblMyCourseTitle.AutoSize = true;
            this.lblMyCourseTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyCourseTitle.Location = new System.Drawing.Point(16, 62);
            this.lblMyCourseTitle.Name = "lblMyCourseTitle";
            this.lblMyCourseTitle.Size = new System.Drawing.Size(61, 15);
            this.lblMyCourseTitle.TabIndex = 2;
            this.lblMyCourseTitle.Text = "Khóa học:";
            // 
            // txtMyCourseTitle
            // 
            this.txtMyCourseTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMyCourseTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtMyCourseTitle.Location = new System.Drawing.Point(16, 82);
            this.txtMyCourseTitle.Name = "txtMyCourseTitle";
            this.txtMyCourseTitle.ReadOnly = true;
            this.txtMyCourseTitle.Size = new System.Drawing.Size(342, 24);
            this.txtMyCourseTitle.TabIndex = 3;
            // 
            // lblMyEnrollInfo
            // 
            this.lblMyEnrollInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblMyEnrollInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyEnrollInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyEnrollInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMyEnrollInfo.Location = new System.Drawing.Point(16, 118);
            this.lblMyEnrollInfo.Name = "lblMyEnrollInfo";
            this.lblMyEnrollInfo.Padding = new System.Windows.Forms.Padding(10);
            this.lblMyEnrollInfo.Size = new System.Drawing.Size(342, 180);
            this.lblMyEnrollInfo.TabIndex = 4;
            this.lblMyEnrollInfo.Text = "Chọn một bản ghi đăng ký để xem chi tiết.";
            // 
            // lblMyNote
            // 
            this.lblMyNote.AutoSize = true;
            this.lblMyNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyNote.Location = new System.Drawing.Point(16, 312);
            this.lblMyNote.Name = "lblMyNote";
            this.lblMyNote.Size = new System.Drawing.Size(119, 15);
            this.lblMyNote.TabIndex = 5;
            this.lblMyNote.Text = "Ghi chú học tập cá nhân:";
            // 
            // txtMyEnrollNote
            // 
            this.txtMyEnrollNote.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMyEnrollNote.Location = new System.Drawing.Point(16, 332);
            this.txtMyEnrollNote.MaxLength = 240;
            this.txtMyEnrollNote.Multiline = true;
            this.txtMyEnrollNote.Name = "txtMyEnrollNote";
            this.txtMyEnrollNote.Size = new System.Drawing.Size(342, 82);
            this.txtMyEnrollNote.TabIndex = 6;
            // 
            // btnSaveMyNote
            // 
            this.btnSaveMyNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnSaveMyNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMyNote.FlatAppearance.BorderSize = 0;
            this.btnSaveMyNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMyNote.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveMyNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveMyNote.Location = new System.Drawing.Point(16, 430);
            this.btnSaveMyNote.Name = "btnSaveMyNote";
            this.btnSaveMyNote.Size = new System.Drawing.Size(342, 38);
            this.btnSaveMyNote.TabIndex = 7;
            this.btnSaveMyNote.Text = "Lưu ghi chú học tập";
            this.btnSaveMyNote.UseVisualStyleBackColor = false;
            this.btnSaveMyNote.Click += new System.EventHandler(this.btnSaveMyNote_Click);
            // 
            // btnPrintStudentReceipt
            // 
            this.btnPrintStudentReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnPrintStudentReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintStudentReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnPrintStudentReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintStudentReceipt.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnPrintStudentReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPrintStudentReceipt.Location = new System.Drawing.Point(16, 478);
            this.btnPrintStudentReceipt.Name = "btnPrintStudentReceipt";
            this.btnPrintStudentReceipt.Size = new System.Drawing.Size(342, 38);
            this.btnPrintStudentReceipt.TabIndex = 8;
            this.btnPrintStudentReceipt.Text = "Xem & In biên lai xác nhận học phí";
            this.btnPrintStudentReceipt.UseVisualStyleBackColor = false;
            this.btnPrintStudentReceipt.Click += new System.EventHandler(this.btnPrintStudentReceipt_Click);
            // 
            // btnCancelMyCourse
            // 
            this.btnCancelMyCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelMyCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMyCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCancelMyCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMyCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelMyCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelMyCourse.Location = new System.Drawing.Point(16, 528);
            this.btnCancelMyCourse.Name = "btnCancelMyCourse";
            this.btnCancelMyCourse.Size = new System.Drawing.Size(342, 38);
            this.btnCancelMyCourse.TabIndex = 9;
            this.btnCancelMyCourse.Text = "Hủy đăng ký và hoàn học phí";
            this.btnCancelMyCourse.UseVisualStyleBackColor = false;
            this.btnCancelMyCourse.Click += new System.EventHandler(this.btnCancelMyCourse_Click);
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabTimetable.Controls.Add(this.dgvTimetable);
            this.tabTimetable.Controls.Add(this.pnlTimetableTop);
            this.tabTimetable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabTimetable.Location = new System.Drawing.Point(4, 38);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(10);
            this.tabTimetable.Size = new System.Drawing.Size(1272, 638);
            this.tabTimetable.TabIndex = 2;
            this.tabTimetable.Text = "Thời khóa biểu";
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToDeleteRows = false;
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvHeader3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvHeader3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dgvHeader3.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            dgvHeader3.ForeColor = System.Drawing.Color.White;
            this.dgvTimetable.ColumnHeadersDefaultCellStyle = dgvHeader3;
            this.dgvTimetable.ColumnHeadersHeight = 40;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCellWrap.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dgvCellWrap.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellWrap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dgvCellWrap.Padding = new System.Windows.Forms.Padding(6);
            dgvCellWrap.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dgvCellWrap.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dgvCellWrap.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimetable.DefaultCellStyle = dgvCellWrap;
            this.dgvTimetable.AutoGenerateColumns = false;
            this.dgvTimetable.DataSource = this.timetableBindingSource;
            this.dgvTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimetable.EnableHeadersVisualStyles = false;
            this.dgvTimetable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
                        this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTT_Shift,

                this.colTT_D2,

                this.colTT_D3,

                this.colTT_D4,

                this.colTT_D5,

                this.colTT_D6,

                this.colTT_D7,

                this.colTT_DCN
            });

            this.dgvTimetable.Location = new System.Drawing.Point(10, 68);
            this.dgvTimetable.MultiSelect = false;
            this.dgvTimetable.Name = "dgvTimetable";
            // 
            // colTT_Shift
            // 
            this.colTT_Shift.DataPropertyName = "Shift";
            this.colTT_Shift.HeaderText = "Ca học / Thứ";
            this.colTT_Shift.Name = "colTT_Shift";
            this.colTT_Shift.ReadOnly = true;
            this.colTT_Shift.FillWeight = 115F;
            this.colTT_Shift.Width = 115;
            // 
            // colTT_D2
            // 
            this.colTT_D2.DataPropertyName = "D2";
            this.colTT_D2.HeaderText = "Thứ Hai";
            this.colTT_D2.Name = "colTT_D2";
            this.colTT_D2.ReadOnly = true;
            this.colTT_D2.FillWeight = 100F;
            this.colTT_D2.Width = 100;
            // 
            // colTT_D3
            // 
            this.colTT_D3.DataPropertyName = "D3";
            this.colTT_D3.HeaderText = "Thứ Ba";
            this.colTT_D3.Name = "colTT_D3";
            this.colTT_D3.ReadOnly = true;
            this.colTT_D3.FillWeight = 100F;
            this.colTT_D3.Width = 100;
            // 
            // colTT_D4
            // 
            this.colTT_D4.DataPropertyName = "D4";
            this.colTT_D4.HeaderText = "Thứ Tư";
            this.colTT_D4.Name = "colTT_D4";
            this.colTT_D4.ReadOnly = true;
            this.colTT_D4.FillWeight = 100F;
            this.colTT_D4.Width = 100;
            // 
            // colTT_D5
            // 
            this.colTT_D5.DataPropertyName = "D5";
            this.colTT_D5.HeaderText = "Thứ Năm";
            this.colTT_D5.Name = "colTT_D5";
            this.colTT_D5.ReadOnly = true;
            this.colTT_D5.FillWeight = 100F;
            this.colTT_D5.Width = 100;
            // 
            // colTT_D6
            // 
            this.colTT_D6.DataPropertyName = "D6";
            this.colTT_D6.HeaderText = "Thứ Sáu";
            this.colTT_D6.Name = "colTT_D6";
            this.colTT_D6.ReadOnly = true;
            this.colTT_D6.FillWeight = 100F;
            this.colTT_D6.Width = 100;
            // 
            // colTT_D7
            // 
            this.colTT_D7.DataPropertyName = "D7";
            this.colTT_D7.HeaderText = "Thứ Bảy";
            this.colTT_D7.Name = "colTT_D7";
            this.colTT_D7.ReadOnly = true;
            this.colTT_D7.FillWeight = 100F;
            this.colTT_D7.Width = 100;
            // 
            // colTT_DCN
            // 
            this.colTT_DCN.DataPropertyName = "DCN";
            this.colTT_DCN.HeaderText = "Chủ Nhật";
            this.colTT_DCN.Name = "colTT_DCN";
            this.colTT_DCN.ReadOnly = true;
            this.colTT_DCN.FillWeight = 100F;
            this.colTT_DCN.Width = 100;

            // colTimetable_Shift
            // 
            // 
            // colTimetable_D2
            // 
            // 
            // colTimetable_D3
            // 
            // 
            // colTimetable_D4
            // 
            // 
            // colTimetable_D5
            // 
            // 
            // colTimetable_D6
            // 
            // 
            // colTimetable_D7
            // 
            // 
            // colTimetable_DCN
            // 
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersVisible = false;
            this.dgvTimetable.RowTemplate.Height = 155;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(1252, 560);
            this.dgvTimetable.TabIndex = 1;
            this.dgvTimetable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTimetable_CellFormatting);
            // 
            // pnlTimetableTop
            // 
            this.pnlTimetableTop.BackColor = System.Drawing.Color.White;
            this.pnlTimetableTop.Controls.Add(this.btnExportTimetable);
            this.pnlTimetableTop.Controls.Add(this.lblTimetableSummary);
            this.pnlTimetableTop.Controls.Add(this.lblTimetableTitle);
            this.pnlTimetableTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimetableTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTimetableTop.Name = "pnlTimetableTop";
            this.pnlTimetableTop.Size = new System.Drawing.Size(1252, 58);
            this.pnlTimetableTop.TabIndex = 0;
            // 
            // btnExportTimetable
            // 
            this.btnExportTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportTimetable.FlatAppearance.BorderSize = 0;
            this.btnExportTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTimetable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportTimetable.ForeColor = System.Drawing.Color.White;
            this.btnExportTimetable.Location = new System.Drawing.Point(1038, 12);
            this.btnExportTimetable.Name = "btnExportTimetable";
            this.btnExportTimetable.Size = new System.Drawing.Size(200, 34);
            this.btnExportTimetable.TabIndex = 2;
            this.btnExportTimetable.Text = "Xuất thời khóa biểu (Excel)";
            this.btnExportTimetable.UseVisualStyleBackColor = false;
            this.btnExportTimetable.Click += new System.EventHandler(this.btnExportTimetable_Click);
            // 
            // lblTimetableSummary
            // 
            this.lblTimetableSummary.AutoSize = true;
            this.lblTimetableSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimetableSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTimetableSummary.Location = new System.Drawing.Point(16, 33);
            this.lblTimetableSummary.Name = "lblTimetableSummary";
            this.lblTimetableSummary.Size = new System.Drawing.Size(270, 15);
            this.lblTimetableSummary.TabIndex = 1;
            this.lblTimetableSummary.Text = "Đang theo học: 0 khóa học | Tổng số: 0 buổi/tuần";
            // 
            // lblTimetableTitle
            // 
            this.lblTimetableTitle.AutoSize = true;
            this.lblTimetableTitle.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTimetableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTimetableTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTimetableTitle.Name = "lblTimetableTitle";
            this.lblTimetableTitle.Size = new System.Drawing.Size(344, 19);
            this.lblTimetableTitle.TabIndex = 0;
            this.lblTimetableTitle.Text = "Thời khóa biểu hàng tuần các khóa học đang theo học";
            // 
            // tabReviews
            // 
            this.tabReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabReviews.Controls.Add(this.pnlReviewsMain);
            this.tabReviews.Controls.Add(this.grpWriteReview);
            this.tabReviews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabReviews.Location = new System.Drawing.Point(4, 38);
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Padding = new System.Windows.Forms.Padding(10);
            this.tabReviews.Size = new System.Drawing.Size(1272, 638);
            this.tabReviews.TabIndex = 3;
            this.tabReviews.Text = "Đánh giá khóa học";
            // 
            // pnlReviewsMain
            // 
            this.pnlReviewsMain.Controls.Add(this.dgvStudentReviews);
            this.pnlReviewsMain.Controls.Add(this.pnlReviewsFilter);
            this.pnlReviewsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReviewsMain.Location = new System.Drawing.Point(390, 10);
            this.pnlReviewsMain.Name = "pnlReviewsMain";
            this.pnlReviewsMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlReviewsMain.Size = new System.Drawing.Size(872, 618);
            this.pnlReviewsMain.TabIndex = 1;
            // 
            // dgvStudentReviews
            // 
            this.dgvStudentReviews.AllowUserToAddRows = false;
            this.dgvStudentReviews.AllowUserToDeleteRows = false;
            dgvAlt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvStudentReviews.AlternatingRowsDefaultCellStyle = dgvAlt4;
            this.dgvStudentReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvHeader4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dgvHeader4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeader4.ForeColor = System.Drawing.Color.White;
            this.dgvStudentReviews.ColumnHeadersDefaultCellStyle = dgvHeader4;
            this.dgvStudentReviews.ColumnHeadersHeight = 36;
            this.dgvStudentReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentReviews.AutoGenerateColumns = false;
            this.dgvStudentReviews.DataSource = this.studentReviewsBindingSource;
            this.dgvStudentReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentReviews.EnableHeadersVisualStyles = false;
                        this.dgvStudentReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStuRev_CourseCode,

                this.colStuRev_CourseName,

                this.colStuRev_StudentName,

                this.colStuRev_Stars,

                this.colStuRev_Comment,

                this.colStuRev_CreatedAt
            });

            this.dgvStudentReviews.Location = new System.Drawing.Point(10, 52);
            this.dgvStudentReviews.MultiSelect = false;
            this.dgvStudentReviews.Name = "dgvStudentReviews";
            // 
            // colStuRev_CourseCode
            // 
            this.colStuRev_CourseCode.DataPropertyName = "CourseCode";
            this.colStuRev_CourseCode.HeaderText = "Mã khóa học";
            this.colStuRev_CourseCode.Name = "colStuRev_CourseCode";
            this.colStuRev_CourseCode.ReadOnly = true;
            this.colStuRev_CourseCode.FillWeight = 62F;
            this.colStuRev_CourseCode.Width = 62;
            // 
            // colStuRev_CourseName
            // 
            this.colStuRev_CourseName.DataPropertyName = "CourseName";
            this.colStuRev_CourseName.HeaderText = "Tên khóa học";
            this.colStuRev_CourseName.Name = "colStuRev_CourseName";
            this.colStuRev_CourseName.ReadOnly = true;
            this.colStuRev_CourseName.FillWeight = 155F;
            this.colStuRev_CourseName.Width = 155;
            // 
            // colStuRev_StudentName
            // 
            this.colStuRev_StudentName.DataPropertyName = "StudentName";
            this.colStuRev_StudentName.HeaderText = "Học viên";
            this.colStuRev_StudentName.Name = "colStuRev_StudentName";
            this.colStuRev_StudentName.ReadOnly = true;
            this.colStuRev_StudentName.FillWeight = 115F;
            this.colStuRev_StudentName.Width = 115;
            // 
            // colStuRev_Stars
            // 
            this.colStuRev_Stars.DataPropertyName = "Stars";
            this.colStuRev_Stars.HeaderText = "Đánh giá sao";
            this.colStuRev_Stars.Name = "colStuRev_Stars";
            this.colStuRev_Stars.ReadOnly = true;
            this.colStuRev_Stars.FillWeight = 72F;
            this.colStuRev_Stars.Width = 72;
            // 
            // colStuRev_Comment
            // 
            this.colStuRev_Comment.DataPropertyName = "Comment";
            this.colStuRev_Comment.HeaderText = "Nhận xét của học viên";
            this.colStuRev_Comment.Name = "colStuRev_Comment";
            this.colStuRev_Comment.ReadOnly = true;
            this.colStuRev_Comment.FillWeight = 230F;
            this.colStuRev_Comment.Width = 230;
            // 
            // colStuRev_CreatedAt
            // 
            this.colStuRev_CreatedAt.DataPropertyName = "CreatedAt";
            this.colStuRev_CreatedAt.HeaderText = "Ngày gửi";
            this.colStuRev_CreatedAt.Name = "colStuRev_CreatedAt";
            this.colStuRev_CreatedAt.ReadOnly = true;
            this.colStuRev_CreatedAt.FillWeight = 95F;
            this.colStuRev_CreatedAt.Width = 95;
            this.colStuRev_CreatedAt.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";


            // 
            // colStuReviews_CourseCode
            // 
            // 
            // colStuReviews_CourseName
            // 
            // 
            // colStuReviews_StudentName
            // 
            // 
            // colStuReviews_Stars
            // 
            // 
            // colStuReviews_Comment
            // 
            // 
            // colStuReviews_CreatedAt
            // 
            this.dgvStudentReviews.ReadOnly = true;
            this.dgvStudentReviews.RowHeadersVisible = false;
            this.dgvStudentReviews.RowTemplate.Height = 34;
            this.dgvStudentReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentReviews.Size = new System.Drawing.Size(862, 566);
            this.dgvStudentReviews.TabIndex = 1;
            // 
            // pnlReviewsFilter
            // 
            this.pnlReviewsFilter.BackColor = System.Drawing.Color.White;
            this.pnlReviewsFilter.Controls.Add(this.lblCourseAvgSummary);
            this.pnlReviewsFilter.Controls.Add(this.cboFilterReviewCourse);
            this.pnlReviewsFilter.Controls.Add(this.lblFilterRevCourse);
            this.pnlReviewsFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReviewsFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlReviewsFilter.Name = "pnlReviewsFilter";
            this.pnlReviewsFilter.Size = new System.Drawing.Size(862, 52);
            this.pnlReviewsFilter.TabIndex = 0;
            // 
            // lblCourseAvgSummary
            // 
            this.lblCourseAvgSummary.AutoSize = true;
            this.lblCourseAvgSummary.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCourseAvgSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblCourseAvgSummary.Location = new System.Drawing.Point(438, 17);
            this.lblCourseAvgSummary.Name = "lblCourseAvgSummary";
            this.lblCourseAvgSummary.Size = new System.Drawing.Size(172, 17);
            this.lblCourseAvgSummary.TabIndex = 2;
            this.lblCourseAvgSummary.Text = "Điểm đánh giá TB: ---";
            // 
            // cboFilterReviewCourse
            // 
            this.cboFilterReviewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterReviewCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterReviewCourse.Location = new System.Drawing.Point(132, 13);
            this.cboFilterReviewCourse.Name = "cboFilterReviewCourse";
            this.cboFilterReviewCourse.Size = new System.Drawing.Size(290, 24);
            this.cboFilterReviewCourse.TabIndex = 1;
            this.cboFilterReviewCourse.SelectedIndexChanged += new System.EventHandler(this.cboFilterReviewCourse_SelectedIndexChanged);
            // 
            // lblFilterRevCourse
            // 
            this.lblFilterRevCourse.AutoSize = true;
            this.lblFilterRevCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterRevCourse.Location = new System.Drawing.Point(14, 16);
            this.lblFilterRevCourse.Name = "lblFilterRevCourse";
            this.lblFilterRevCourse.Size = new System.Drawing.Size(112, 15);
            this.lblFilterRevCourse.TabIndex = 0;
            this.lblFilterRevCourse.Text = "Lọc theo khóa học:";
            // 
            // grpWriteReview
            // 
            this.grpWriteReview.BackColor = System.Drawing.Color.White;
            this.grpWriteReview.Controls.Add(this.btnDeleteMyReview);
            this.grpWriteReview.Controls.Add(this.btnSaveReview);
            this.grpWriteReview.Controls.Add(this.lblRevHint);
            this.grpWriteReview.Controls.Add(this.txtReviewComment);
            this.grpWriteReview.Controls.Add(this.lblRevComment);
            this.grpWriteReview.Controls.Add(this.cboReviewRating);
            this.grpWriteReview.Controls.Add(this.lblRevStars);
            this.grpWriteReview.Controls.Add(this.cboReviewCourse);
            this.grpWriteReview.Controls.Add(this.lblRevCourse);
            this.grpWriteReview.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpWriteReview.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.grpWriteReview.Location = new System.Drawing.Point(10, 10);
            this.grpWriteReview.Name = "grpWriteReview";
            this.grpWriteReview.Size = new System.Drawing.Size(380, 618);
            this.grpWriteReview.TabIndex = 0;
            this.grpWriteReview.TabStop = false;
            this.grpWriteReview.Text = "Gửi phản hồi và đánh giá khóa học";
            // 
            // lblRevCourse
            // 
            this.lblRevCourse.AutoSize = true;
            this.lblRevCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevCourse.Location = new System.Drawing.Point(18, 34);
            this.lblRevCourse.Name = "lblRevCourse";
            this.lblRevCourse.Size = new System.Drawing.Size(134, 15);
            this.lblRevCourse.TabIndex = 0;
            this.lblRevCourse.Text = "Khóa học đã đăng ký (*):";
            // 
            // cboReviewCourse
            // 
            this.cboReviewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReviewCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboReviewCourse.Location = new System.Drawing.Point(18, 55);
            this.cboReviewCourse.Name = "cboReviewCourse";
            this.cboReviewCourse.Size = new System.Drawing.Size(342, 24);
            this.cboReviewCourse.TabIndex = 1;
            this.cboReviewCourse.SelectedIndexChanged += new System.EventHandler(this.cboReviewCourse_SelectedIndexChanged);
            // 
            // lblRevStars
            // 
            this.lblRevStars.AutoSize = true;
            this.lblRevStars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevStars.Location = new System.Drawing.Point(18, 96);
            this.lblRevStars.Name = "lblRevStars";
            this.lblRevStars.Size = new System.Drawing.Size(123, 15);
            this.lblRevStars.TabIndex = 2;
            this.lblRevStars.Text = "Mức độ hài lòng (*):";
            // 
            // cboReviewRating
            // 
            this.cboReviewRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReviewRating.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboReviewRating.Items.AddRange(new object[] {
            "5 sao - Rất hài lòng",
            "4 sao - Hài lòng",
            "3 sao - Bình thường",
            "2 sao - Chưa tốt",
            "1 sao - Cần cải thiện"});
            this.cboReviewRating.Location = new System.Drawing.Point(18, 117);
            this.cboReviewRating.Name = "cboReviewRating";
            this.cboReviewRating.Size = new System.Drawing.Size(342, 24);
            this.cboReviewRating.TabIndex = 3;
            // 
            // lblRevComment
            // 
            this.lblRevComment.AutoSize = true;
            this.lblRevComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevComment.Location = new System.Drawing.Point(18, 158);
            this.lblRevComment.Name = "lblRevComment";
            this.lblRevComment.Size = new System.Drawing.Size(126, 15);
            this.lblRevComment.TabIndex = 4;
            this.lblRevComment.Text = "Nhận xét chi tiết (*):";
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtReviewComment.Location = new System.Drawing.Point(18, 180);
            this.txtReviewComment.MaxLength = 500;
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReviewComment.Size = new System.Drawing.Size(342, 155);
            this.txtReviewComment.TabIndex = 5;
            // 
            // lblRevHint
            // 
            this.lblRevHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRevHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRevHint.Location = new System.Drawing.Point(18, 348);
            this.lblRevHint.Name = "lblRevHint";
            this.lblRevHint.Size = new System.Drawing.Size(342, 42);
            this.lblRevHint.TabIndex = 6;
            this.lblRevHint.Text = "Lưu ý: Học viên chỉ đánh giá các khóa học đã đăng ký. Nếu đã gửi đánh giá trước đ" +
    "ó, hệ thống sẽ cập nhật lại nội dung mới.";
            // 
            // btnSaveReview
            // 
            this.btnSaveReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnSaveReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveReview.FlatAppearance.BorderSize = 0;
            this.btnSaveReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReview.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveReview.ForeColor = System.Drawing.Color.White;
            this.btnSaveReview.Location = new System.Drawing.Point(18, 405);
            this.btnSaveReview.Name = "btnSaveReview";
            this.btnSaveReview.Size = new System.Drawing.Size(342, 40);
            this.btnSaveReview.TabIndex = 7;
            this.btnSaveReview.Text = "Gửi / Cập nhật đánh giá";
            this.btnSaveReview.UseVisualStyleBackColor = false;
            this.btnSaveReview.Click += new System.EventHandler(this.btnSaveReview_Click);
            // 
            // btnDeleteMyReview
            // 
            this.btnDeleteMyReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteMyReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMyReview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDeleteMyReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMyReview.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMyReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeleteMyReview.Location = new System.Drawing.Point(18, 456);
            this.btnDeleteMyReview.Name = "btnDeleteMyReview";
            this.btnDeleteMyReview.Size = new System.Drawing.Size(342, 38);
            this.btnDeleteMyReview.TabIndex = 8;
            this.btnDeleteMyReview.Text = "Xóa đánh giá của tôi";
            this.btnDeleteMyReview.UseVisualStyleBackColor = false;
            this.btnDeleteMyReview.Click += new System.EventHandler(this.btnDeleteMyReview_Click);
            // 
            // tabWallet
            // 
            this.tabWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabWallet.Controls.Add(this.pnlWalletHistory);
            this.tabWallet.Controls.Add(this.grpTopUp);
            this.tabWallet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabWallet.Location = new System.Drawing.Point(4, 38);
            this.tabWallet.Name = "tabWallet";
            this.tabWallet.Padding = new System.Windows.Forms.Padding(10);
            this.tabWallet.Size = new System.Drawing.Size(1272, 638);
            this.tabWallet.TabIndex = 4;
            this.tabWallet.Text = "Tài khoản học phí";
            // 
            // pnlWalletHistory
            // 
            this.pnlWalletHistory.Controls.Add(this.dgvMyTransactions);
            this.pnlWalletHistory.Controls.Add(this.pnlTxFilter);
            this.pnlWalletHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWalletHistory.Location = new System.Drawing.Point(380, 10);
            this.pnlWalletHistory.Name = "pnlWalletHistory";
            this.pnlWalletHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlWalletHistory.Size = new System.Drawing.Size(882, 618);
            this.pnlWalletHistory.TabIndex = 1;
            // 
            // dgvMyTransactions
            // 
            this.dgvMyTransactions.AllowUserToAddRows = false;
            this.dgvMyTransactions.AllowUserToDeleteRows = false;
            dgvAlt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvMyTransactions.AlternatingRowsDefaultCellStyle = dgvAlt5;
            this.dgvMyTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvHeader5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dgvHeader5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeader5.ForeColor = System.Drawing.Color.White;
            this.dgvMyTransactions.ColumnHeadersDefaultCellStyle = dgvHeader5;
            this.dgvMyTransactions.ColumnHeadersHeight = 36;
            this.dgvMyTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyTransactions.AutoGenerateColumns = false;
            this.dgvMyTransactions.DataSource = this.myTransactionsBindingSource;
            this.dgvMyTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyTransactions.EnableHeadersVisualStyles = false;
                        this.dgvMyTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMyTx_TransactionID,

                this.colMyTx_TypeLabel,

                this.colMyTx_Amount,

                this.colMyTx_Description,

                this.colMyTx_CreatedAt
            });

            this.dgvMyTransactions.Location = new System.Drawing.Point(10, 52);
            this.dgvMyTransactions.MultiSelect = false;
            this.dgvMyTransactions.Name = "dgvMyTransactions";
            // 
            // colMyTx_TransactionID
            // 
            this.colMyTx_TransactionID.DataPropertyName = "TransactionID";
            this.colMyTx_TransactionID.HeaderText = "Mã GD";
            this.colMyTx_TransactionID.Name = "colMyTx_TransactionID";
            this.colMyTx_TransactionID.ReadOnly = true;
            this.colMyTx_TransactionID.FillWeight = 60F;
            this.colMyTx_TransactionID.Width = 60;
            // 
            // colMyTx_TypeLabel
            // 
            this.colMyTx_TypeLabel.DataPropertyName = "TypeLabel";
            this.colMyTx_TypeLabel.HeaderText = "Loại giao dịch";
            this.colMyTx_TypeLabel.Name = "colMyTx_TypeLabel";
            this.colMyTx_TypeLabel.ReadOnly = true;
            this.colMyTx_TypeLabel.FillWeight = 100F;
            this.colMyTx_TypeLabel.Width = 100;
            // 
            // colMyTx_Amount
            // 
            this.colMyTx_Amount.DataPropertyName = "Amount";
            this.colMyTx_Amount.HeaderText = "Số tiền (VNĐ)";
            this.colMyTx_Amount.Name = "colMyTx_Amount";
            this.colMyTx_Amount.ReadOnly = true;
            this.colMyTx_Amount.FillWeight = 95F;
            this.colMyTx_Amount.Width = 95;
            this.colMyTx_Amount.DefaultCellStyle.Format = "+#,##0;-#,##0;0";
            // 
            // colMyTx_Description
            // 
            this.colMyTx_Description.DataPropertyName = "Description";
            this.colMyTx_Description.HeaderText = "Nội dung giao dịch";
            this.colMyTx_Description.Name = "colMyTx_Description";
            this.colMyTx_Description.ReadOnly = true;
            this.colMyTx_Description.FillWeight = 230F;
            this.colMyTx_Description.Width = 230;
            // 
            // colMyTx_CreatedAt
            // 
            this.colMyTx_CreatedAt.DataPropertyName = "CreatedAt";
            this.colMyTx_CreatedAt.HeaderText = "Thời gian";
            this.colMyTx_CreatedAt.Name = "colMyTx_CreatedAt";
            this.colMyTx_CreatedAt.ReadOnly = true;
            this.colMyTx_CreatedAt.FillWeight = 100F;
            this.colMyTx_CreatedAt.Width = 100;
            this.colMyTx_CreatedAt.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";


            // 
            // colMyTx_TransactionID
            // 
            // 
            // colMyTx_TypeLabel
            // 
            // 
            // colMyTx_Amount
            // 
            // 
            // colMyTx_Description
            // 
            // 
            // colMyTx_CreatedAt
            // 
            this.dgvMyTransactions.ReadOnly = true;
            this.dgvMyTransactions.RowHeadersVisible = false;
            this.dgvMyTransactions.RowTemplate.Height = 32;
            this.dgvMyTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyTransactions.Size = new System.Drawing.Size(872, 566);
            this.dgvMyTransactions.TabIndex = 1;
            // 
            // pnlTxFilter
            // 
            this.pnlTxFilter.BackColor = System.Drawing.Color.White;
            this.pnlTxFilter.Controls.Add(this.btnExportMyTx);
            this.pnlTxFilter.Controls.Add(this.lblWalletStats);
            this.pnlTxFilter.Controls.Add(this.cboFilterTxType);
            this.pnlTxFilter.Controls.Add(this.lblFilterTx);
            this.pnlTxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlTxFilter.Name = "pnlTxFilter";
            this.pnlTxFilter.Size = new System.Drawing.Size(872, 52);
            this.pnlTxFilter.TabIndex = 0;
            // 
            // btnExportMyTx
            // 
            this.btnExportMyTx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportMyTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportMyTx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportMyTx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportMyTx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportMyTx.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportMyTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportMyTx.Location = new System.Drawing.Point(756, 11);
            this.btnExportMyTx.Name = "btnExportMyTx";
            this.btnExportMyTx.Size = new System.Drawing.Size(104, 29);
            this.btnExportMyTx.TabIndex = 3;
            this.btnExportMyTx.Text = "Xuất Excel";
            this.btnExportMyTx.UseVisualStyleBackColor = false;
            this.btnExportMyTx.Click += new System.EventHandler(this.btnExportMyTx_Click);
            // 
            // lblWalletStats
            // 
            this.lblWalletStats.AutoSize = true;
            this.lblWalletStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWalletStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblWalletStats.Location = new System.Drawing.Point(312, 17);
            this.lblWalletStats.Name = "lblWalletStats";
            this.lblWalletStats.Size = new System.Drawing.Size(218, 15);
            this.lblWalletStats.TabIndex = 2;
            this.lblWalletStats.Text = "Tổng nộp: 0 VNĐ | Đã thanh toán: 0 VNĐ";
            // 
            // cboFilterTxType
            // 
            this.cboFilterTxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTxType.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterTxType.Items.AddRange(new object[] {
            "Tất cả giao dịch",
            "Nộp học phí",
            "Thanh toán khóa học",
            "Hoàn học phí"});
            this.cboFilterTxType.Location = new System.Drawing.Point(116, 13);
            this.cboFilterTxType.Name = "cboFilterTxType";
            this.cboFilterTxType.Size = new System.Drawing.Size(176, 24);
            this.cboFilterTxType.TabIndex = 1;
            this.cboFilterTxType.SelectedIndexChanged += new System.EventHandler(this.cboFilterTxType_SelectedIndexChanged);
            // 
            // lblFilterTx
            // 
            this.lblFilterTx.AutoSize = true;
            this.lblFilterTx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterTx.Location = new System.Drawing.Point(14, 16);
            this.lblFilterTx.Name = "lblFilterTx";
            this.lblFilterTx.Size = new System.Drawing.Size(92, 15);
            this.lblFilterTx.TabIndex = 0;
            this.lblFilterTx.Text = "Loại giao dịch:";
            // 
            // grpTopUp
            // 
            this.grpTopUp.BackColor = System.Drawing.Color.White;
            this.grpTopUp.Controls.Add(this.btnConfirmTopUp);
            this.grpTopUp.Controls.Add(this.txtTopUpNote);
            this.grpTopUp.Controls.Add(this.lblTopUpNote);
            this.grpTopUp.Controls.Add(this.cboPaymentMethod);
            this.grpTopUp.Controls.Add(this.lblPaymentMethod);
            this.grpTopUp.Controls.Add(this.btnTop2M);
            this.grpTopUp.Controls.Add(this.btnTop1M);
            this.grpTopUp.Controls.Add(this.btnTop500k);
            this.grpTopUp.Controls.Add(this.btnTop200k);
            this.grpTopUp.Controls.Add(this.nudTopUpAmount);
            this.grpTopUp.Controls.Add(this.lblAmount);
            this.grpTopUp.Controls.Add(this.pnlBalanceBox);
            this.grpTopUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpTopUp.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.grpTopUp.Location = new System.Drawing.Point(10, 10);
            this.grpTopUp.Name = "grpTopUp";
            this.grpTopUp.Size = new System.Drawing.Size(370, 618);
            this.grpTopUp.TabIndex = 0;
            this.grpTopUp.TabStop = false;
            this.grpTopUp.Text = "Nộp học phí vào tài khoản";
            // 
            // pnlBalanceBox
            // 
            this.pnlBalanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBalanceBox.Controls.Add(this.lblWalletBigBalance);
            this.pnlBalanceBox.Controls.Add(this.lblWalletBoxTitle);
            this.pnlBalanceBox.Location = new System.Drawing.Point(18, 30);
            this.pnlBalanceBox.Name = "pnlBalanceBox";
            this.pnlBalanceBox.Size = new System.Drawing.Size(332, 92);
            this.pnlBalanceBox.TabIndex = 0;
            // 
            // lblWalletBoxTitle
            // 
            this.lblWalletBoxTitle.AutoSize = true;
            this.lblWalletBoxTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWalletBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWalletBoxTitle.Location = new System.Drawing.Point(14, 14);
            this.lblWalletBoxTitle.Name = "lblWalletBoxTitle";
            this.lblWalletBoxTitle.Size = new System.Drawing.Size(145, 15);
            this.lblWalletBoxTitle.TabIndex = 0;
            this.lblWalletBoxTitle.Text = "Số dư học phí khả dụng:";
            // 
            // lblWalletBigBalance
            // 
            this.lblWalletBigBalance.AutoSize = true;
            this.lblWalletBigBalance.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblWalletBigBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblWalletBigBalance.Location = new System.Drawing.Point(14, 40);
            this.lblWalletBigBalance.Name = "lblWalletBigBalance";
            this.lblWalletBigBalance.Size = new System.Drawing.Size(87, 31);
            this.lblWalletBigBalance.TabIndex = 1;
            this.lblWalletBigBalance.Text = "0 VNĐ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmount.Location = new System.Drawing.Point(18, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(134, 15);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Số tiền nộp (VNĐ) (*):";
            // 
            // nudTopUpAmount
            // 
            this.nudTopUpAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.nudTopUpAmount.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudTopUpAmount.Location = new System.Drawing.Point(18, 164);
            this.nudTopUpAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTopUpAmount.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudTopUpAmount.Name = "nudTopUpAmount";
            this.nudTopUpAmount.Size = new System.Drawing.Size(332, 27);
            this.nudTopUpAmount.TabIndex = 2;
            this.nudTopUpAmount.ThousandsSeparator = true;
            this.nudTopUpAmount.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // btnTop200k
            // 
            this.btnTop200k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnTop200k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop200k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTop200k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop200k.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnTop200k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnTop200k.Location = new System.Drawing.Point(18, 202);
            this.btnTop200k.Name = "btnTop200k";
            this.btnTop200k.Size = new System.Drawing.Size(77, 30);
            this.btnTop200k.TabIndex = 3;
            this.btnTop200k.Text = "200.000";
            this.btnTop200k.UseVisualStyleBackColor = false;
            this.btnTop200k.Click += new System.EventHandler(this.btnTop200k_Click);
            // 
            // btnTop500k
            // 
            this.btnTop500k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnTop500k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop500k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTop500k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop500k.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnTop500k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnTop500k.Location = new System.Drawing.Point(103, 202);
            this.btnTop500k.Name = "btnTop500k";
            this.btnTop500k.Size = new System.Drawing.Size(77, 30);
            this.btnTop500k.TabIndex = 4;
            this.btnTop500k.Text = "500.000";
            this.btnTop500k.UseVisualStyleBackColor = false;
            this.btnTop500k.Click += new System.EventHandler(this.btnTop500k_Click);
            // 
            // btnTop1M
            // 
            this.btnTop1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnTop1M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop1M.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTop1M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop1M.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnTop1M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnTop1M.Location = new System.Drawing.Point(188, 202);
            this.btnTop1M.Name = "btnTop1M";
            this.btnTop1M.Size = new System.Drawing.Size(77, 30);
            this.btnTop1M.TabIndex = 5;
            this.btnTop1M.Text = "1.000.000";
            this.btnTop1M.UseVisualStyleBackColor = false;
            this.btnTop1M.Click += new System.EventHandler(this.btnTop1M_Click);
            // 
            // btnTop2M
            // 
            this.btnTop2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnTop2M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop2M.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTop2M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop2M.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnTop2M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnTop2M.Location = new System.Drawing.Point(273, 202);
            this.btnTop2M.Name = "btnTop2M";
            this.btnTop2M.Size = new System.Drawing.Size(77, 30);
            this.btnTop2M.TabIndex = 6;
            this.btnTop2M.Text = "2.000.000";
            this.btnTop2M.UseVisualStyleBackColor = false;
            this.btnTop2M.Click += new System.EventHandler(this.btnTop2M_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaymentMethod.Location = new System.Drawing.Point(18, 250);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(119, 15);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Hình thức nộp (*):";
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Chuyển khoản ngân hàng",
            "Nộp trực tiếp tại phòng tài vụ"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(18, 272);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(332, 24);
            this.cboPaymentMethod.TabIndex = 8;
            // 
            // lblTopUpNote
            // 
            this.lblTopUpNote.AutoSize = true;
            this.lblTopUpNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTopUpNote.Location = new System.Drawing.Point(18, 314);
            this.lblTopUpNote.Name = "lblTopUpNote";
            this.lblTopUpNote.Size = new System.Drawing.Size(124, 15);
            this.lblTopUpNote.TabIndex = 9;
            this.lblTopUpNote.Text = "Nội dung / Mã chứng từ:";
            // 
            // txtTopUpNote
            // 
            this.txtTopUpNote.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTopUpNote.Location = new System.Drawing.Point(18, 336);
            this.txtTopUpNote.MaxLength = 150;
            this.txtTopUpNote.Multiline = true;
            this.txtTopUpNote.Name = "txtTopUpNote";
            this.txtTopUpNote.Size = new System.Drawing.Size(332, 74);
            this.txtTopUpNote.TabIndex = 10;
            // 
            // btnConfirmTopUp
            // 
            this.btnConfirmTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnConfirmTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmTopUp.FlatAppearance.BorderSize = 0;
            this.btnConfirmTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTopUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmTopUp.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTopUp.Location = new System.Drawing.Point(18, 428);
            this.btnConfirmTopUp.Name = "btnConfirmTopUp";
            this.btnConfirmTopUp.Size = new System.Drawing.Size(332, 42);
            this.btnConfirmTopUp.TabIndex = 11;
            this.btnConfirmTopUp.Text = "Xác nhận nộp học phí";
            this.btnConfirmTopUp.UseVisualStyleBackColor = false;
            this.btnConfirmTopUp.Click += new System.EventHandler(this.btnConfirmTopUp_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabProfile.Controls.Add(this.grpChangePass);
            this.tabProfile.Controls.Add(this.grpProfileInfo);
            this.tabProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabProfile.Location = new System.Drawing.Point(4, 38);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(20);
            this.tabProfile.Size = new System.Drawing.Size(1272, 638);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Thông tin cá nhân";
            // 
            // grpProfileInfo
            // 
            this.grpProfileInfo.BackColor = System.Drawing.Color.White;
            this.grpProfileInfo.Controls.Add(this.btnSaveProfile);
            this.grpProfileInfo.Controls.Add(this.txtProfilePhone);
            this.grpProfileInfo.Controls.Add(this.lblProfPhone);
            this.grpProfileInfo.Controls.Add(this.txtProfileEmail);
            this.grpProfileInfo.Controls.Add(this.lblProfEmail);
            this.grpProfileInfo.Controls.Add(this.txtProfileFullName);
            this.grpProfileInfo.Controls.Add(this.lblProfFullName);
            this.grpProfileInfo.Controls.Add(this.txtProfileRole);
            this.grpProfileInfo.Controls.Add(this.lblProfRole);
            this.grpProfileInfo.Controls.Add(this.txtProfileUsername);
            this.grpProfileInfo.Controls.Add(this.lblProfUsername);
            this.grpProfileInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpProfileInfo.Location = new System.Drawing.Point(40, 26);
            this.grpProfileInfo.Name = "grpProfileInfo";
            this.grpProfileInfo.Size = new System.Drawing.Size(540, 440);
            this.grpProfileInfo.TabIndex = 0;
            this.grpProfileInfo.TabStop = false;
            this.grpProfileInfo.Text = "Hồ sơ học viên";
            // 
            // lblProfUsername
            // 
            this.lblProfUsername.AutoSize = true;
            this.lblProfUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfUsername.Location = new System.Drawing.Point(28, 44);
            this.lblProfUsername.Name = "lblProfUsername";
            this.lblProfUsername.Size = new System.Drawing.Size(89, 15);
            this.lblProfUsername.TabIndex = 0;
            this.lblProfUsername.Text = "Tên đăng nhập:";
            // 
            // txtProfileUsername
            // 
            this.txtProfileUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtProfileUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfileUsername.Location = new System.Drawing.Point(28, 66);
            this.txtProfileUsername.Name = "txtProfileUsername";
            this.txtProfileUsername.ReadOnly = true;
            this.txtProfileUsername.Size = new System.Drawing.Size(230, 25);
            this.txtProfileUsername.TabIndex = 1;
            // 
            // lblProfRole
            // 
            this.lblProfRole.AutoSize = true;
            this.lblProfRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfRole.Location = new System.Drawing.Point(280, 44);
            this.lblProfRole.Name = "lblProfRole";
            this.lblProfRole.Size = new System.Drawing.Size(96, 15);
            this.lblProfRole.TabIndex = 2;
            this.lblProfRole.Text = "Nhóm tài khoản:";
            // 
            // txtProfileRole
            // 
            this.txtProfileRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtProfileRole.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfileRole.Location = new System.Drawing.Point(280, 66);
            this.txtProfileRole.Name = "txtProfileRole";
            this.txtProfileRole.ReadOnly = true;
            this.txtProfileRole.Size = new System.Drawing.Size(230, 25);
            this.txtProfileRole.TabIndex = 3;
            // 
            // lblProfFullName
            // 
            this.lblProfFullName.AutoSize = true;
            this.lblProfFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfFullName.Location = new System.Drawing.Point(28, 112);
            this.lblProfFullName.Name = "lblProfFullName";
            this.lblProfFullName.Size = new System.Drawing.Size(96, 15);
            this.lblProfFullName.TabIndex = 4;
            this.lblProfFullName.Text = "Họ và tên (*):";
            // 
            // txtProfileFullName
            // 
            this.txtProfileFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfileFullName.Location = new System.Drawing.Point(28, 134);
            this.txtProfileFullName.Name = "txtProfileFullName";
            this.txtProfileFullName.Size = new System.Drawing.Size(482, 25);
            this.txtProfileFullName.TabIndex = 5;
            // 
            // lblProfEmail
            // 
            this.lblProfEmail.AutoSize = true;
            this.lblProfEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfEmail.Location = new System.Drawing.Point(28, 180);
            this.lblProfEmail.Name = "lblProfEmail";
            this.lblProfEmail.Size = new System.Drawing.Size(84, 15);
            this.lblProfEmail.TabIndex = 6;
            this.lblProfEmail.Text = "Email liên hệ:";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfileEmail.Location = new System.Drawing.Point(28, 202);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(482, 25);
            this.txtProfileEmail.TabIndex = 7;
            // 
            // lblProfPhone
            // 
            this.lblProfPhone.AutoSize = true;
            this.lblProfPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfPhone.Location = new System.Drawing.Point(28, 248);
            this.lblProfPhone.Name = "lblProfPhone";
            this.lblProfPhone.Size = new System.Drawing.Size(83, 15);
            this.lblProfPhone.TabIndex = 8;
            this.lblProfPhone.Text = "Số điện thoại:";
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfilePhone.Location = new System.Drawing.Point(28, 270);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(482, 25);
            this.txtProfilePhone.TabIndex = 9;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(28, 330);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(210, 40);
            this.btnSaveProfile.TabIndex = 10;
            this.btnSaveProfile.Text = "Lưu thông tin cá nhân";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // grpChangePass
            // 
            this.grpChangePass.BackColor = System.Drawing.Color.White;
            this.grpChangePass.Controls.Add(this.btnChangePassword);
            this.grpChangePass.Controls.Add(this.chkProfileShowPass);
            this.grpChangePass.Controls.Add(this.txtConfirmNewPassword);
            this.grpChangePass.Controls.Add(this.lblConfirmNewPass);
            this.grpChangePass.Controls.Add(this.txtNewPassword);
            this.grpChangePass.Controls.Add(this.lblNewPass);
            this.grpChangePass.Controls.Add(this.txtOldPassword);
            this.grpChangePass.Controls.Add(this.lblOldPass);
            this.grpChangePass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpChangePass.Location = new System.Drawing.Point(612, 26);
            this.grpChangePass.Name = "grpChangePass";
            this.grpChangePass.Size = new System.Drawing.Size(500, 440);
            this.grpChangePass.TabIndex = 1;
            this.grpChangePass.TabStop = false;
            this.grpChangePass.Text = "Đổi mật khẩu đăng nhập";
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOldPass.Location = new System.Drawing.Point(28, 44);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(124, 15);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Mật khẩu hiện tại (*):";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOldPassword.Location = new System.Drawing.Point(28, 66);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(440, 25);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewPass.Location = new System.Drawing.Point(28, 112);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(106, 15);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Mật khẩu mới (*):";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNewPassword.Location = new System.Drawing.Point(28, 134);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(440, 25);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.AutoSize = true;
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmNewPass.Location = new System.Drawing.Point(28, 180);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(161, 15);
            this.lblConfirmNewPass.TabIndex = 4;
            this.lblConfirmNewPass.Text = "Nhập lại mật khẩu mới (*):";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(28, 202);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(440, 25);
            this.txtConfirmNewPassword.TabIndex = 5;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // chkProfileShowPass
            // 
            this.chkProfileShowPass.AutoSize = true;
            this.chkProfileShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkProfileShowPass.Location = new System.Drawing.Point(28, 244);
            this.chkProfileShowPass.Name = "chkProfileShowPass";
            this.chkProfileShowPass.Size = new System.Drawing.Size(134, 19);
            this.chkProfileShowPass.TabIndex = 6;
            this.chkProfileShowPass.Text = "Hiển thị mật khẩu";
            this.chkProfileShowPass.UseVisualStyleBackColor = true;
            this.chkProfileShowPass.CheckedChanged += new System.EventHandler(this.chkProfileShowPass_CheckedChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(28, 330);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(210, 40);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Cập nhật mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // printDocReceipt
            // 
            this.printDocReceipt.DocumentName = "BienLaiDangKyKhoaHoc";
            this.printDocReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocReceipt_PrintPage);
            // 
            // printPreviewReceipt
            // 
            this.printPreviewReceipt.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewReceipt.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewReceipt.ClientSize = new System.Drawing.Size(960, 700);
            this.printPreviewReceipt.Document = this.printDocReceipt;
            this.printPreviewReceipt.Enabled = true;
            this.printPreviewReceipt.Name = "printPreviewReceipt";
            this.printPreviewReceipt.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.printPreviewReceipt.Text = "Xem trước biên lai xác nhận đăng ký khóa học";
            this.printPreviewReceipt.Visible = false;
            // 
            // saveFileStudentExcel
            // 
            this.saveFileStudentExcel.DefaultExt = "xls";
            this.saveFileStudentExcel.Filter = "Tệp Excel (*.xlsx)|*.xlsx|Tệp Excel cũ (*.xls)|*.xls|Tệp CSV UTF-8 (*.csv)|*.csv";
            this.saveFileStudentExcel.Title = "Xuất báo cáo ra Excel";
            // 
            // FrmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.tabStudent);
            this.Controls.Add(this.pnlStudentHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1140, 670);
            this.Name = "FrmStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cổng thông tin học viên - Phần mềm quản lý đào tạo và đăng ký khóa học";
            this.Load += new System.EventHandler(this.FrmStudentMain_Load);
            this.pnlStudentHeader.ResumeLayout(false);
            this.pnlStudentHeader.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.tabCatalog.ResumeLayout(false);
            this.pnlCatalogMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.pnlCatalogFilter.ResumeLayout(false);
            this.pnlCatalogFilter.PerformLayout();
            this.grpCourseCheckout.ResumeLayout(false);
            this.grpCourseCheckout.PerformLayout();
            this.tabMyCourses.ResumeLayout(false);
            this.pnlMyCoursesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCourses)).EndInit();
            this.pnlMyCoursesFilter.ResumeLayout(false);
            this.pnlMyCoursesFilter.PerformLayout();
            this.grpMyCourseDetail.ResumeLayout(false);
            this.grpMyCourseDetail.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.pnlTimetableTop.ResumeLayout(false);
            this.pnlTimetableTop.PerformLayout();
            this.tabReviews.ResumeLayout(false);
            this.pnlReviewsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReviews)).EndInit();
            this.pnlReviewsFilter.ResumeLayout(false);
            this.pnlReviewsFilter.PerformLayout();
            this.grpWriteReview.ResumeLayout(false);
            this.grpWriteReview.PerformLayout();
            this.tabWallet.ResumeLayout(false);
            this.pnlWalletHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTransactions)).EndInit();
            this.pnlTxFilter.ResumeLayout(false);
            this.pnlTxFilter.PerformLayout();
            this.grpTopUp.ResumeLayout(false);
            this.grpTopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUpAmount)).EndInit();
            this.pnlBalanceBox.ResumeLayout(false);
            this.pnlBalanceBox.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.grpChangePass.ResumeLayout(false);
            this.grpChangePass.PerformLayout();
            this.grpProfileInfo.ResumeLayout(false);
            this.grpProfileInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentHeader;
        private System.Windows.Forms.Button btnStudentAbout;
        private System.Windows.Forms.Button btnStudentLogout;
        private System.Windows.Forms.Button btnQuickTopUp;
        private System.Windows.Forms.Label lblHeaderBalance;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblPortalTitle;
        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tabCatalog;
        private System.Windows.Forms.Panel pnlCatalogMain;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Panel pnlCatalogFilter;
        private System.Windows.Forms.Button btnCatalogReset;
        private System.Windows.Forms.ComboBox cboCatalogSort;
        private System.Windows.Forms.ComboBox cboCatalogCategory;
        private System.Windows.Forms.TextBox txtCatalogSearch;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.GroupBox grpCourseCheckout;
        private System.Windows.Forms.Button btnBuyCourse;
        private System.Windows.Forms.TextBox txtBuyNote;
        private System.Windows.Forms.Label lblBuyNote;
        private System.Windows.Forms.Label lblSelPrice;
        private System.Windows.Forms.Label lblVoucherStatus;
        private System.Windows.Forms.Button btnApplyVoucher;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.Label lblVoucherTitle;
        private System.Windows.Forms.TextBox txtSelDescription;
        private System.Windows.Forms.Label lblSelDescTitle;
        private System.Windows.Forms.Label lblConflictWarning;
        private System.Windows.Forms.Label lblSelSlots;
        private System.Windows.Forms.Label lblSelClassTime;
        private System.Windows.Forms.Label lblSelSchedule;
        private System.Windows.Forms.Label lblSelInstructor;
        private System.Windows.Forms.Label lblSelCategory;
        private System.Windows.Forms.Label lblSelName;
        private System.Windows.Forms.Label lblSelRating;
        private System.Windows.Forms.Label lblSelCode;
        private System.Windows.Forms.TabPage tabMyCourses;
        private System.Windows.Forms.Panel pnlMyCoursesList;
        private System.Windows.Forms.DataGridView dgvMyCourses;
        private System.Windows.Forms.Panel pnlMyCoursesFilter;
        private System.Windows.Forms.Button btnExportMyCourses;
        private System.Windows.Forms.Label lblMySummary;
        private System.Windows.Forms.ComboBox cboMyCourseStatus;
        private System.Windows.Forms.TextBox txtSearchMyCourse;
        private System.Windows.Forms.Label lblMySearch;
        private System.Windows.Forms.GroupBox grpMyCourseDetail;
        private System.Windows.Forms.Button btnCancelMyCourse;
        private System.Windows.Forms.Button btnPrintStudentReceipt;
        private System.Windows.Forms.Button btnSaveMyNote;
        private System.Windows.Forms.TextBox txtMyEnrollNote;
        private System.Windows.Forms.Label lblMyNote;
        private System.Windows.Forms.Label lblMyEnrollInfo;
        private System.Windows.Forms.TextBox txtMyCourseTitle;
        private System.Windows.Forms.Label lblMyCourseTitle;
        private System.Windows.Forms.TextBox txtMyEnrollmentId;
        private System.Windows.Forms.Label lblMyEnrollId;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.Panel pnlTimetableTop;
        private System.Windows.Forms.Button btnExportTimetable;
        private System.Windows.Forms.Label lblTimetableSummary;
        private System.Windows.Forms.Label lblTimetableTitle;
        private System.Windows.Forms.TabPage tabReviews;
        private System.Windows.Forms.Panel pnlReviewsMain;
        private System.Windows.Forms.DataGridView dgvStudentReviews;
        private System.Windows.Forms.Panel pnlReviewsFilter;
        private System.Windows.Forms.Label lblCourseAvgSummary;
        private System.Windows.Forms.ComboBox cboFilterReviewCourse;
        private System.Windows.Forms.Label lblFilterRevCourse;
        private System.Windows.Forms.GroupBox grpWriteReview;
        private System.Windows.Forms.Button btnDeleteMyReview;
        private System.Windows.Forms.Button btnSaveReview;
        private System.Windows.Forms.Label lblRevHint;
        private System.Windows.Forms.TextBox txtReviewComment;
        private System.Windows.Forms.Label lblRevComment;
        private System.Windows.Forms.ComboBox cboReviewRating;
        private System.Windows.Forms.ComboBox cboReviewCourse;
        private System.Windows.Forms.Label lblRevStars;
        private System.Windows.Forms.Label lblRevCourse;
        private System.Windows.Forms.TabPage tabWallet;
        private System.Windows.Forms.Panel pnlWalletHistory;
        private System.Windows.Forms.DataGridView dgvMyTransactions;
        private System.Windows.Forms.Panel pnlTxFilter;
        private System.Windows.Forms.Button btnExportMyTx;
        private System.Windows.Forms.Label lblWalletStats;
        private System.Windows.Forms.ComboBox cboFilterTxType;
        private System.Windows.Forms.Label lblFilterTx;
        private System.Windows.Forms.GroupBox grpTopUp;
        private System.Windows.Forms.Button btnConfirmTopUp;
        private System.Windows.Forms.TextBox txtTopUpNote;
        private System.Windows.Forms.Label lblTopUpNote;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Button btnTop2M;
        private System.Windows.Forms.Button btnTop1M;
        private System.Windows.Forms.Button btnTop500k;
        private System.Windows.Forms.Button btnTop200k;
        private System.Windows.Forms.NumericUpDown nudTopUpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pnlBalanceBox;
        private System.Windows.Forms.Label lblWalletBigBalance;
        private System.Windows.Forms.Label lblWalletBoxTitle;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.GroupBox grpChangePass;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.CheckBox chkProfileShowPass;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.GroupBox grpProfileInfo;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.Label lblProfPhone;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblProfEmail;
        private System.Windows.Forms.TextBox txtProfileFullName;
        private System.Windows.Forms.Label lblProfFullName;
        private System.Windows.Forms.TextBox txtProfileRole;
        private System.Windows.Forms.Label lblProfRole;
        private System.Windows.Forms.TextBox txtProfileUsername;
        private System.Windows.Forms.Label lblProfUsername;
        private System.Drawing.Printing.PrintDocument printDocReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewReceipt;
        private System.Windows.Forms.SaveFileDialog saveFileStudentExcel;



        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_ScheduleShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_RatingDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_Remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_MyState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_EnrollmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_ScheduleText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_EnrollDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMy_StatusDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_D7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_DCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuRev_CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyTx_TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyTx_TypeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyTx_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyTx_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyTx_CreatedAt;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private System.Windows.Forms.BindingSource myCoursesBindingSource;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private System.Windows.Forms.BindingSource studentReviewsBindingSource;
        private System.Windows.Forms.BindingSource myTransactionsBindingSource;
    }
}