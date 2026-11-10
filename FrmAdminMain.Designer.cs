namespace Course_Registration
{
    partial class FrmAdminMain
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
            this.colCourse_CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_ScheduleShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_EnrolledSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_RatingText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse_StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat_TotalCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_RoleDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_BoughtCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_EnrollmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_EnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_VoucherDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_StatusDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnroll_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_VoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_VoucherCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_ValueDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_MinOrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_QuotaDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucher_StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_ReviewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_StarsDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRev_CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_SoldSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_FillPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatRev_Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_TypeDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTx_CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

                        this.components = new System.ComponentModel.Container();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vouchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminReviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseRevenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAdminAbout = new System.Windows.Forms.Button();
            this.lblAdminWelcome = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.pnlCourseList = new System.Windows.Forms.Panel();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.pnlCourseFilter = new System.Windows.Forms.Panel();
            this.btnExportCourses = new System.Windows.Forms.Button();
            this.btnResetCourseFilter = new System.Windows.Forms.Button();
            this.cboFilterCourseStatus = new System.Windows.Forms.ComboBox();
            this.cboFilterCourseCategory = new System.Windows.Forms.ComboBox();
            this.lblFilterCat = new System.Windows.Forms.Label();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.lblSearchCourse = new System.Windows.Forms.Label();
            this.grpCourseForm = new System.Windows.Forms.GroupBox();
            this.btnCourseClear = new System.Windows.Forms.Button();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.btnCourseUpdate = new System.Windows.Forms.Button();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.txtCourseDesc = new System.Windows.Forms.TextBox();
            this.lblCourseDesc = new System.Windows.Forms.Label();
            this.chkCourseActive = new System.Windows.Forms.CheckBox();
            this.txtCourseRoom = new System.Windows.Forms.TextBox();
            this.lblCourseRoom = new System.Windows.Forms.Label();
            this.cboCourseShift = new System.Windows.Forms.ComboBox();
            this.lblCourseShift = new System.Windows.Forms.Label();
            this.cboCourseDays = new System.Windows.Forms.ComboBox();
            this.lblCourseDays = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.nudMaxStudents = new System.Windows.Forms.NumericUpDown();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.nudDurationHours = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nudCoursePrice = new System.Windows.Forms.NumericUpDown();
            this.lblCoursePrice = new System.Windows.Forms.Label();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.cboCourseCategory = new System.Windows.Forms.ComboBox();
            this.lblCourseCategory = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.pnlCategoryList = new System.Windows.Forms.Panel();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pnlCatFilter = new System.Windows.Forms.Panel();
            this.btnResetCatFilter = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.lblSearchCat = new System.Windows.Forms.Label();
            this.grpCategoryForm = new System.Windows.Forms.GroupBox();
            this.btnCatClear = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatUpdate = new System.Windows.Forms.Button();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.lblCatDesc = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCatId = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.pnlUserList = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlUserFilter = new System.Windows.Forms.Panel();
            this.btnResetUserFilter = new System.Windows.Forms.Button();
            this.cboFilterUserRole = new System.Windows.Forms.ComboBox();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.grpUserForm = new System.Windows.Forms.GroupBox();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.chkUserActive = new System.Windows.Forms.CheckBox();
            this.nudUserBalance = new System.Windows.Forms.NumericUpDown();
            this.lblUserBalance = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.txtUserFullName = new System.Windows.Forms.TextBox();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.lblUserUsername = new System.Windows.Forms.Label();
            this.cboUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.tabEnrollments = new System.Windows.Forms.TabPage();
            this.pnlEnrollList = new System.Windows.Forms.Panel();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.pnlEnrollFilter = new System.Windows.Forms.Panel();
            this.btnRdlcEnrollmentReport = new System.Windows.Forms.Button();
            this.btnExportEnrollments = new System.Windows.Forms.Button();
            this.btnResetEnrollFilter = new System.Windows.Forms.Button();
            this.cboFilterEnrollStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterEnrollStatus = new System.Windows.Forms.Label();
            this.txtSearchEnroll = new System.Windows.Forms.TextBox();
            this.lblSearchEnroll = new System.Windows.Forms.Label();
            this.grpEnrollForm = new System.Windows.Forms.GroupBox();
            this.btnPrintAdminReceipt = new System.Windows.Forms.Button();
            this.btnEnrollClear = new System.Windows.Forms.Button();
            this.btnEnrollDelete = new System.Windows.Forms.Button();
            this.btnEnrollRefundCancel = new System.Windows.Forms.Button();
            this.btnEnrollUpdate = new System.Windows.Forms.Button();
            this.btnEnrollAdd = new System.Windows.Forms.Button();
            this.txtEnrollNote = new System.Windows.Forms.TextBox();
            this.lblEnrollNote = new System.Windows.Forms.Label();
            this.chkDeductWalletOnAdminCreate = new System.Windows.Forms.CheckBox();
            this.nudEnrollPaid = new System.Windows.Forms.NumericUpDown();
            this.lblEnrollPaid = new System.Windows.Forms.Label();
            this.cboEnrollCourse = new System.Windows.Forms.ComboBox();
            this.lblEnrollCourse = new System.Windows.Forms.Label();
            this.cboEnrollStudent = new System.Windows.Forms.ComboBox();
            this.lblEnrollStudent = new System.Windows.Forms.Label();
            this.cboEnrollStatus = new System.Windows.Forms.ComboBox();
            this.lblEnrollStatus = new System.Windows.Forms.Label();
            this.txtEnrollmentId = new System.Windows.Forms.TextBox();
            this.lblEnrollId = new System.Windows.Forms.Label();
            this.tabVouchers = new System.Windows.Forms.TabPage();
            this.pnlVoucherMain = new System.Windows.Forms.Panel();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.pnlVoucherFilter = new System.Windows.Forms.Panel();
            this.btnResetVoucherFilter = new System.Windows.Forms.Button();
            this.cboFilterVoucherStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchVoucher = new System.Windows.Forms.TextBox();
            this.lblSearchVoucher = new System.Windows.Forms.Label();
            this.grpVoucherForm = new System.Windows.Forms.GroupBox();
            this.btnVoucherClear = new System.Windows.Forms.Button();
            this.btnVoucherDelete = new System.Windows.Forms.Button();
            this.btnVoucherUpdate = new System.Windows.Forms.Button();
            this.btnVoucherAdd = new System.Windows.Forms.Button();
            this.dtpVoucherExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblVoucherExpiry = new System.Windows.Forms.Label();
            this.txtVoucherUsedCount = new System.Windows.Forms.TextBox();
            this.lblVoucherUsed = new System.Windows.Forms.Label();
            this.nudVoucherUsageLimit = new System.Windows.Forms.NumericUpDown();
            this.lblVoucherLimit = new System.Windows.Forms.Label();
            this.nudVoucherMinOrder = new System.Windows.Forms.NumericUpDown();
            this.lblVoucherMinOrder = new System.Windows.Forms.Label();
            this.nudVoucherMaxDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblVoucherMax = new System.Windows.Forms.Label();
            this.nudVoucherAmount = new System.Windows.Forms.NumericUpDown();
            this.lblVoucherAmount = new System.Windows.Forms.Label();
            this.nudVoucherPercent = new System.Windows.Forms.NumericUpDown();
            this.lblVoucherPercent = new System.Windows.Forms.Label();
            this.txtVoucherDesc = new System.Windows.Forms.TextBox();
            this.lblVoucherDesc = new System.Windows.Forms.Label();
            this.txtVoucherCodeAdmin = new System.Windows.Forms.TextBox();
            this.lblVoucherCodeAdmin = new System.Windows.Forms.Label();
            this.chkVoucherActive = new System.Windows.Forms.CheckBox();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.lblVoucherId = new System.Windows.Forms.Label();
            this.tabAdminReviews = new System.Windows.Forms.TabPage();
            this.dgvAdminReviews = new System.Windows.Forms.DataGridView();
            this.pnlAdminReviewFilter = new System.Windows.Forms.Panel();
            this.btnAdminDeleteReview = new System.Windows.Forms.Button();
            this.btnExportReviews = new System.Windows.Forms.Button();
            this.lblAdminReviewStats = new System.Windows.Forms.Label();
            this.cboAdminReviewStars = new System.Windows.Forms.ComboBox();
            this.cboAdminReviewCourse = new System.Windows.Forms.ComboBox();
            this.lblAdminRevFilter = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.splitReports = new System.Windows.Forms.SplitContainer();
            this.grpRevenueByCourse = new System.Windows.Forms.GroupBox();
            this.dgvCourseRevenue = new System.Windows.Forms.DataGridView();
            this.grpAllTransactions = new System.Windows.Forms.GroupBox();
            this.dgvSystemTransactions = new System.Windows.Forms.DataGridView();
            this.splitCharts = new System.Windows.Forms.SplitContainer();
            this.grpChartRevenue = new System.Windows.Forms.GroupBox();
            this.chartCourseRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpChartCategory = new System.Windows.Forms.GroupBox();
            this.chartCategoryShare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlReportFilter = new System.Windows.Forms.Panel();
            this.btnExportTransactions = new System.Windows.Forms.Button();
            this.btnExportRevenue = new System.Windows.Forms.Button();
            this.btnRdlcRevenueReport = new System.Windows.Forms.Button();
            this.btnRefreshAllReport = new System.Windows.Forms.Button();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.dtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.lblReportTo = new System.Windows.Forms.Label();
            this.dtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.chkFilterByDate = new System.Windows.Forms.CheckBox();
            this.pnlKpiCards = new System.Windows.Forms.Panel();
            this.pnlCardEnrollments = new System.Windows.Forms.Panel();
            this.lblCardEnrollValue = new System.Windows.Forms.Label();
            this.lblCardEnrollTitle = new System.Windows.Forms.Label();
            this.pnlCardStudents = new System.Windows.Forms.Panel();
            this.lblCardStudentsValue = new System.Windows.Forms.Label();
            this.lblCardStudentsTitle = new System.Windows.Forms.Label();
            this.pnlCardActiveCourses = new System.Windows.Forms.Panel();
            this.lblCardCoursesValue = new System.Windows.Forms.Label();
            this.lblCardCoursesTitle = new System.Windows.Forms.Label();
            this.pnlCardRevenue = new System.Windows.Forms.Panel();
            this.lblCardRevenueValue = new System.Windows.Forms.Label();
            this.lblCardRevenueTitle = new System.Windows.Forms.Label();
            this.printDocAdminReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewAdminReceipt = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileAdminExcel = new System.Windows.Forms.SaveFileDialog();
            this.pnlTopBar.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.pnlCourseList.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.vouchersBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.adminReviewsBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.courseRevenueBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.systemTransactionsBindingSource)).BeginInit();

((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.pnlCourseFilter.SuspendLayout();
            this.grpCourseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursePrice)).BeginInit();
            this.tabCategories.SuspendLayout();
            this.pnlCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.pnlCatFilter.SuspendLayout();
            this.grpCategoryForm.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUserFilter.SuspendLayout();
            this.grpUserForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserBalance)).BeginInit();
            this.tabEnrollments.SuspendLayout();
            this.pnlEnrollList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.pnlEnrollFilter.SuspendLayout();
            this.grpEnrollForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnrollPaid)).BeginInit();
            this.tabVouchers.SuspendLayout();
            this.pnlVoucherMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.pnlVoucherFilter.SuspendLayout();
            this.grpVoucherForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherUsageLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherMinOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherMaxDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherPercent)).BeginInit();
            this.tabAdminReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReviews)).BeginInit();
            this.pnlAdminReviewFilter.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitReports)).BeginInit();
            this.splitReports.Panel1.SuspendLayout();
            this.splitReports.Panel2.SuspendLayout();
            this.splitReports.SuspendLayout();
            this.grpRevenueByCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRevenue)).BeginInit();
            this.grpAllTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).BeginInit();
            this.splitCharts.Panel1.SuspendLayout();
            this.splitCharts.Panel2.SuspendLayout();
            this.splitCharts.SuspendLayout();
            this.grpChartRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCourseRevenue)).BeginInit();
            this.grpChartCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryShare)).BeginInit();
            this.pnlReportFilter.SuspendLayout();
            this.pnlKpiCards.SuspendLayout();
            this.pnlCardEnrollments.SuspendLayout();
            this.pnlCardStudents.SuspendLayout();
            this.pnlCardActiveCourses.SuspendLayout();
            this.pnlCardRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlTopBar.Controls.Add(this.btnAdminAbout);
            this.pnlTopBar.Controls.Add(this.btnAdminLogout);
            this.pnlTopBar.Controls.Add(this.lblAdminWelcome);
            this.pnlTopBar.Controls.Add(this.lblAppTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1320, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnAdminAbout
            // 
            this.btnAdminAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnAdminAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnAdminAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnAdminAbout.Location = new System.Drawing.Point(1085, 14);
            this.btnAdminAbout.Name = "btnAdminAbout";
            this.btnAdminAbout.Size = new System.Drawing.Size(105, 32);
            this.btnAdminAbout.TabIndex = 3;
            this.btnAdminAbout.Text = "👥 Giới thiệu";
            this.btnAdminAbout.UseVisualStyleBackColor = false;
            this.btnAdminAbout.Click += new System.EventHandler(this.btnAdminAbout_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnAdminLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnAdminLogout.Location = new System.Drawing.Point(1200, 14);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(105, 32);
            this.btnAdminLogout.TabIndex = 2;
            this.btnAdminLogout.Text = "Đăng xuất";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // lblAdminWelcome
            // 
            this.lblAdminWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminWelcome.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblAdminWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblAdminWelcome.Location = new System.Drawing.Point(660, 19);
            this.lblAdminWelcome.Name = "lblAdminWelcome";
            this.lblAdminWelcome.Size = new System.Drawing.Size(410, 22);
            this.lblAdminWelcome.TabIndex = 1;
            this.lblAdminWelcome.Text = "Quản trị viên: ---";
            this.lblAdminWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(18, 17);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(385, 23);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Hệ thống Quản lý Đào tạo";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabCourses);
            this.tabAdmin.Controls.Add(this.tabCategories);
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Controls.Add(this.tabEnrollments);
            this.tabAdmin.Controls.Add(this.tabVouchers);
            this.tabAdmin.Controls.Add(this.tabAdminReviews);
            this.tabAdmin.Controls.Add(this.tabReports);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.tabAdmin.ItemSize = new System.Drawing.Size(182, 34);
            this.tabAdmin.Location = new System.Drawing.Point(0, 60);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1320, 720);
            this.tabAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tabCourses
            // 
            this.tabCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabCourses.Controls.Add(this.pnlCourseList);
            this.tabCourses.Controls.Add(this.grpCourseForm);
            this.tabCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabCourses.Location = new System.Drawing.Point(4, 38);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(10);
            this.tabCourses.Size = new System.Drawing.Size(1312, 678);
            this.tabCourses.TabIndex = 0;
            this.tabCourses.Text = "Quản lý khóa học";
            // 
            // pnlCourseList
            // 
            this.pnlCourseList.Controls.Add(this.dgvCourses);
            this.pnlCourseList.Controls.Add(this.pnlCourseFilter);
            this.pnlCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourseList.Location = new System.Drawing.Point(385, 10);
            this.pnlCourseList.Name = "pnlCourseList";
            this.pnlCourseList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlCourseList.Size = new System.Drawing.Size(917, 658);
            this.pnlCourseList.TabIndex = 1;
                        // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataSource = typeof(Course_Registration.Course);
// 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.ColumnHeadersHeight = 36;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.DataSource = this.coursesBindingSource;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.EnableHeadersVisualStyles = false;
                        this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCourse_CourseID,

                this.colCourse_CourseCode,

                this.colCourse_CourseName,

                this.colCourse_CategoryName,

                this.colCourse_Instructor,

                this.colCourse_ScheduleShort,

                this.colCourse_Room,

                this.colCourse_Price,

                this.colCourse_EnrolledSlot,

                this.colCourse_RatingText,

                this.colCourse_StartDate,

                this.colCourse_StatusText
            });

            this.dgvCourses.Location = new System.Drawing.Point(10, 54);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowTemplate.Height = 30;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(907, 604);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // colCourse_CourseID
            // 
            this.colCourse_CourseID.DataPropertyName = "CourseID";
            this.colCourse_CourseID.HeaderText = "Mã ID";
            this.colCourse_CourseID.Name = "colCourse_CourseID";
            this.colCourse_CourseID.ReadOnly = true;
            this.colCourse_CourseID.FillWeight = 38F;
            // 
            // colCourse_CourseCode
            // 
            this.colCourse_CourseCode.DataPropertyName = "CourseCode";
            this.colCourse_CourseCode.HeaderText = "Mã khóa học";
            this.colCourse_CourseCode.Name = "colCourse_CourseCode";
            this.colCourse_CourseCode.ReadOnly = true;
            this.colCourse_CourseCode.FillWeight = 62F;
            // 
            // colCourse_CourseName
            // 
            this.colCourse_CourseName.DataPropertyName = "CourseName";
            this.colCourse_CourseName.HeaderText = "Tên khóa học";
            this.colCourse_CourseName.Name = "colCourse_CourseName";
            this.colCourse_CourseName.ReadOnly = true;
            this.colCourse_CourseName.FillWeight = 155F;
            // 
            // colCourse_CategoryName
            // 
            this.colCourse_CategoryName.DataPropertyName = "CategoryName";
            this.colCourse_CategoryName.HeaderText = "Danh mục";
            this.colCourse_CategoryName.Name = "colCourse_CategoryName";
            this.colCourse_CategoryName.ReadOnly = true;
            this.colCourse_CategoryName.FillWeight = 100F;
            // 
            // colCourse_Instructor
            // 
            this.colCourse_Instructor.DataPropertyName = "Instructor";
            this.colCourse_Instructor.HeaderText = "Giảng viên";
            this.colCourse_Instructor.Name = "colCourse_Instructor";
            this.colCourse_Instructor.ReadOnly = true;
            this.colCourse_Instructor.FillWeight = 100F;
            // 
            // colCourse_ScheduleShort
            // 
            this.colCourse_ScheduleShort.DataPropertyName = "ScheduleShort";
            this.colCourse_ScheduleShort.HeaderText = "Lịch học";
            this.colCourse_ScheduleShort.Name = "colCourse_ScheduleShort";
            this.colCourse_ScheduleShort.ReadOnly = true;
            this.colCourse_ScheduleShort.FillWeight = 105F;
            // 
            // colCourse_Room
            // 
            this.colCourse_Room.DataPropertyName = "Room";
            this.colCourse_Room.HeaderText = "Phòng";
            this.colCourse_Room.Name = "colCourse_Room";
            this.colCourse_Room.ReadOnly = true;
            this.colCourse_Room.FillWeight = 78F;
            // 
            // colCourse_Price
            // 
            this.colCourse_Price.DataPropertyName = "Price";
            this.colCourse_Price.HeaderText = "Học phí (VNĐ)";
            this.colCourse_Price.Name = "colCourse_Price";
            this.colCourse_Price.ReadOnly = true;
            this.colCourse_Price.DefaultCellStyle.Format = "N0";
            this.colCourse_Price.FillWeight = 78F;
            // 
            // colCourse_EnrolledSlot
            // 
            this.colCourse_EnrolledSlot.DataPropertyName = "EnrolledSlot";
            this.colCourse_EnrolledSlot.HeaderText = "Sĩ số";
            this.colCourse_EnrolledSlot.Name = "colCourse_EnrolledSlot";
            this.colCourse_EnrolledSlot.ReadOnly = true;
            this.colCourse_EnrolledSlot.FillWeight = 55F;
            // 
            // colCourse_RatingText
            // 
            this.colCourse_RatingText.DataPropertyName = "RatingText";
            this.colCourse_RatingText.HeaderText = "Đánh giá";
            this.colCourse_RatingText.Name = "colCourse_RatingText";
            this.colCourse_RatingText.ReadOnly = true;
            this.colCourse_RatingText.FillWeight = 78F;
            // 
            // colCourse_StartDate
            // 
            this.colCourse_StartDate.DataPropertyName = "StartDate";
            this.colCourse_StartDate.HeaderText = "Khai giảng";
            this.colCourse_StartDate.Name = "colCourse_StartDate";
            this.colCourse_StartDate.ReadOnly = true;
            this.colCourse_StartDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colCourse_StartDate.FillWeight = 78F;
            // 
            // colCourse_StatusText
            // 
            this.colCourse_StatusText.DataPropertyName = "StatusText";
            this.colCourse_StatusText.HeaderText = "Trạng thái";
            this.colCourse_StatusText.Name = "colCourse_StatusText";
            this.colCourse_StatusText.ReadOnly = true;
            this.colCourse_StatusText.FillWeight = 72F;

// 
            // pnlCourseFilter
            // 
            this.pnlCourseFilter.BackColor = System.Drawing.Color.White;
            this.pnlCourseFilter.Controls.Add(this.btnExportCourses);
            this.pnlCourseFilter.Controls.Add(this.btnResetCourseFilter);
            this.pnlCourseFilter.Controls.Add(this.cboFilterCourseStatus);
            this.pnlCourseFilter.Controls.Add(this.cboFilterCourseCategory);
            this.pnlCourseFilter.Controls.Add(this.lblFilterCat);
            this.pnlCourseFilter.Controls.Add(this.txtSearchCourse);
            this.pnlCourseFilter.Controls.Add(this.lblSearchCourse);
            this.pnlCourseFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCourseFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlCourseFilter.Name = "pnlCourseFilter";
            this.pnlCourseFilter.Size = new System.Drawing.Size(907, 54);
            this.pnlCourseFilter.TabIndex = 0;
            // 
            // btnExportCourses
            // 
            this.btnExportCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCourses.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportCourses.Location = new System.Drawing.Point(796, 12);
            this.btnExportCourses.Name = "btnExportCourses";
            this.btnExportCourses.Size = new System.Drawing.Size(98, 29);
            this.btnExportCourses.TabIndex = 6;
            this.btnExportCourses.Text = "Xuất Excel";
            this.btnExportCourses.UseVisualStyleBackColor = false;
            this.btnExportCourses.Click += new System.EventHandler(this.btnExportCourses_Click);
            // 
            // btnResetCourseFilter
            // 
            this.btnResetCourseFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnResetCourseFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCourseFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetCourseFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCourseFilter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnResetCourseFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetCourseFilter.Location = new System.Drawing.Point(704, 12);
            this.btnResetCourseFilter.Name = "btnResetCourseFilter";
            this.btnResetCourseFilter.Size = new System.Drawing.Size(85, 29);
            this.btnResetCourseFilter.TabIndex = 5;
            this.btnResetCourseFilter.Text = "Đặt lại";
            this.btnResetCourseFilter.UseVisualStyleBackColor = false;
            this.btnResetCourseFilter.Click += new System.EventHandler(this.btnResetCourseFilter_Click);
            // 
            // cboFilterCourseStatus
            // 
            this.cboFilterCourseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCourseStatus.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterCourseStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang mở đăng ký",
            "Ngừng đăng ký"});
            this.cboFilterCourseStatus.Location = new System.Drawing.Point(554, 14);
            this.cboFilterCourseStatus.Name = "cboFilterCourseStatus";
            this.cboFilterCourseStatus.Size = new System.Drawing.Size(140, 23);
            this.cboFilterCourseStatus.TabIndex = 4;
            this.cboFilterCourseStatus.SelectedIndexChanged += new System.EventHandler(this.CourseFilter_Changed);
            // 
            // cboFilterCourseCategory
            // 
            this.cboFilterCourseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCourseCategory.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterCourseCategory.Location = new System.Drawing.Point(354, 14);
            this.cboFilterCourseCategory.Name = "cboFilterCourseCategory";
            this.cboFilterCourseCategory.Size = new System.Drawing.Size(190, 23);
            this.cboFilterCourseCategory.TabIndex = 3;
            this.cboFilterCourseCategory.SelectedIndexChanged += new System.EventHandler(this.CourseFilter_Changed);
            // 
            // lblFilterCat
            // 
            this.lblFilterCat.AutoSize = true;
            this.lblFilterCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterCat.Location = new System.Drawing.Point(282, 17);
            this.lblFilterCat.Name = "lblFilterCat";
            this.lblFilterCat.Size = new System.Drawing.Size(66, 15);
            this.lblFilterCat.TabIndex = 2;
            this.lblFilterCat.Text = "Danh mục:";
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchCourse.Location = new System.Drawing.Point(78, 14);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(194, 24);
            this.txtSearchCourse.TabIndex = 1;
            this.txtSearchCourse.TextChanged += new System.EventHandler(this.CourseFilter_Changed);
            // 
            // lblSearchCourse
            // 
            this.lblSearchCourse.AutoSize = true;
            this.lblSearchCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchCourse.Location = new System.Drawing.Point(12, 17);
            this.lblSearchCourse.Name = "lblSearchCourse";
            this.lblSearchCourse.Size = new System.Drawing.Size(62, 15);
            this.lblSearchCourse.TabIndex = 0;
            this.lblSearchCourse.Text = "Tìm kiếm:";
            // 
            // grpCourseForm
            // 
            this.grpCourseForm.BackColor = System.Drawing.Color.White;
            this.grpCourseForm.Controls.Add(this.btnCourseClear);
            this.grpCourseForm.Controls.Add(this.btnCourseDelete);
            this.grpCourseForm.Controls.Add(this.btnCourseUpdate);
            this.grpCourseForm.Controls.Add(this.btnCourseAdd);
            this.grpCourseForm.Controls.Add(this.txtCourseDesc);
            this.grpCourseForm.Controls.Add(this.lblCourseDesc);
            this.grpCourseForm.Controls.Add(this.chkCourseActive);
            this.grpCourseForm.Controls.Add(this.txtCourseRoom);
            this.grpCourseForm.Controls.Add(this.lblCourseRoom);
            this.grpCourseForm.Controls.Add(this.cboCourseShift);
            this.grpCourseForm.Controls.Add(this.lblCourseShift);
            this.grpCourseForm.Controls.Add(this.cboCourseDays);
            this.grpCourseForm.Controls.Add(this.lblCourseDays);
            this.grpCourseForm.Controls.Add(this.dtpStartDate);
            this.grpCourseForm.Controls.Add(this.lblStartDate);
            this.grpCourseForm.Controls.Add(this.nudMaxStudents);
            this.grpCourseForm.Controls.Add(this.lblMaxStudents);
            this.grpCourseForm.Controls.Add(this.nudDurationHours);
            this.grpCourseForm.Controls.Add(this.lblDuration);
            this.grpCourseForm.Controls.Add(this.nudCoursePrice);
            this.grpCourseForm.Controls.Add(this.lblCoursePrice);
            this.grpCourseForm.Controls.Add(this.txtInstructor);
            this.grpCourseForm.Controls.Add(this.lblInstructor);
            this.grpCourseForm.Controls.Add(this.cboCourseCategory);
            this.grpCourseForm.Controls.Add(this.lblCourseCategory);
            this.grpCourseForm.Controls.Add(this.txtCourseName);
            this.grpCourseForm.Controls.Add(this.lblCourseName);
            this.grpCourseForm.Controls.Add(this.txtCourseCode);
            this.grpCourseForm.Controls.Add(this.lblCourseCode);
            this.grpCourseForm.Controls.Add(this.txtCourseId);
            this.grpCourseForm.Controls.Add(this.lblCourseId);
            this.grpCourseForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCourseForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCourseForm.Location = new System.Drawing.Point(10, 10);
            this.grpCourseForm.Name = "grpCourseForm";
            this.grpCourseForm.Size = new System.Drawing.Size(375, 658);
            this.grpCourseForm.TabIndex = 0;
            this.grpCourseForm.TabStop = false;
            this.grpCourseForm.Text = "Thông tin khóa học";
            // 
            // btnCourseClear
            // 
            this.btnCourseClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnCourseClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCourseClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCourseClear.Location = new System.Drawing.Point(194, 572);
            this.btnCourseClear.Name = "btnCourseClear";
            this.btnCourseClear.Size = new System.Drawing.Size(164, 36);
            this.btnCourseClear.TabIndex = 16;
            this.btnCourseClear.Text = "Làm mới";
            this.btnCourseClear.UseVisualStyleBackColor = false;
            this.btnCourseClear.Click += new System.EventHandler(this.btnCourseClear_Click);
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCourseDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCourseDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCourseDelete.Location = new System.Drawing.Point(16, 572);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(166, 36);
            this.btnCourseDelete.TabIndex = 15;
            this.btnCourseDelete.Text = "Xóa";
            this.btnCourseDelete.UseVisualStyleBackColor = false;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCourseUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCourseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCourseUpdate.Location = new System.Drawing.Point(194, 528);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(164, 36);
            this.btnCourseUpdate.TabIndex = 14;
            this.btnCourseUpdate.Text = "Cập nhật";
            this.btnCourseUpdate.UseVisualStyleBackColor = false;
            this.btnCourseUpdate.Click += new System.EventHandler(this.btnCourseUpdate_Click);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnCourseAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseAdd.FlatAppearance.BorderSize = 0;
            this.btnCourseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseAdd.ForeColor = System.Drawing.Color.White;
            this.btnCourseAdd.Location = new System.Drawing.Point(16, 528);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(166, 36);
            this.btnCourseAdd.TabIndex = 13;
            this.btnCourseAdd.Text = "Thêm mới";
            this.btnCourseAdd.UseVisualStyleBackColor = false;
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // txtCourseDesc
            // 
            this.txtCourseDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCourseDesc.Location = new System.Drawing.Point(16, 458);
            this.txtCourseDesc.Multiline = true;
            this.txtCourseDesc.Name = "txtCourseDesc";
            this.txtCourseDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCourseDesc.Size = new System.Drawing.Size(342, 60);
            this.txtCourseDesc.TabIndex = 12;
            // 
            // lblCourseDesc
            // 
            this.lblCourseDesc.AutoSize = true;
            this.lblCourseDesc.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseDesc.Location = new System.Drawing.Point(14, 439);
            this.lblCourseDesc.Name = "lblCourseDesc";
            this.lblCourseDesc.Size = new System.Drawing.Size(93, 15);
            this.lblCourseDesc.TabIndex = 24;
            this.lblCourseDesc.Text = "Mô tả khóa học:";
            // 
            // chkCourseActive
            // 
            this.chkCourseActive.AutoSize = true;
            this.chkCourseActive.Checked = true;
            this.chkCourseActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCourseActive.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.chkCourseActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.chkCourseActive.Location = new System.Drawing.Point(214, 412);
            this.chkCourseActive.Name = "chkCourseActive";
            this.chkCourseActive.Size = new System.Drawing.Size(120, 19);
            this.chkCourseActive.TabIndex = 11;
            this.chkCourseActive.Text = "Đang mở đăng ký";
            this.chkCourseActive.UseVisualStyleBackColor = true;
            // 
            // txtCourseRoom
            // 
            this.txtCourseRoom.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCourseRoom.Location = new System.Drawing.Point(16, 408);
            this.txtCourseRoom.Name = "txtCourseRoom";
            this.txtCourseRoom.Size = new System.Drawing.Size(188, 24);
            this.txtCourseRoom.TabIndex = 10;
            this.txtCourseRoom.Text = "Phòng Lab A201";
            // 
            // lblCourseRoom
            // 
            this.lblCourseRoom.AutoSize = true;
            this.lblCourseRoom.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseRoom.Location = new System.Drawing.Point(14, 389);
            this.lblCourseRoom.Name = "lblCourseRoom";
            this.lblCourseRoom.Size = new System.Drawing.Size(84, 15);
            this.lblCourseRoom.TabIndex = 22;
            this.lblCourseRoom.Text = "Phòng học (*):";
            // 
            // cboCourseShift
            // 
            this.cboCourseShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseShift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCourseShift.Items.AddRange(new object[] {
            "Ca sáng (08:00 - 10:30)",
            "Ca chiều (14:00 - 16:30)",
            "Ca tối (18:00 - 20:30)"});
            this.cboCourseShift.Location = new System.Drawing.Point(146, 358);
            this.cboCourseShift.Name = "cboCourseShift";
            this.cboCourseShift.Size = new System.Drawing.Size(212, 23);
            this.cboCourseShift.TabIndex = 9;
            // 
            // lblCourseShift
            // 
            this.lblCourseShift.AutoSize = true;
            this.lblCourseShift.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseShift.Location = new System.Drawing.Point(144, 339);
            this.lblCourseShift.Name = "lblCourseShift";
            this.lblCourseShift.Size = new System.Drawing.Size(63, 15);
            this.lblCourseShift.TabIndex = 20;
            this.lblCourseShift.Text = "Ca học (*):";
            // 
            // cboCourseDays
            // 
            this.cboCourseDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCourseDays.Items.AddRange(new object[] {
            "2,4,6",
            "3,5,7",
            "7,CN",
            "2,4",
            "3,5"});
            this.cboCourseDays.Location = new System.Drawing.Point(16, 358);
            this.cboCourseDays.Name = "cboCourseDays";
            this.cboCourseDays.Size = new System.Drawing.Size(118, 23);
            this.cboCourseDays.TabIndex = 8;
            // 
            // lblCourseDays
            // 
            this.lblCourseDays.AutoSize = true;
            this.lblCourseDays.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseDays.Location = new System.Drawing.Point(14, 339);
            this.lblCourseDays.Name = "lblCourseDays";
            this.lblCourseDays.Size = new System.Drawing.Size(70, 15);
            this.lblCourseDays.TabIndex = 19;
            this.lblCourseDays.Text = "Thứ học (*):";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(198, 308);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 24);
            this.dtpStartDate.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblStartDate.Location = new System.Drawing.Point(196, 288);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 15);
            this.lblStartDate.TabIndex = 15;
            this.lblStartDate.Text = "Ngày khai giảng:";
            // 
            // nudMaxStudents
            // 
            this.nudMaxStudents.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudMaxStudents.Location = new System.Drawing.Point(16, 308);
            this.nudMaxStudents.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxStudents.Name = "nudMaxStudents";
            this.nudMaxStudents.Size = new System.Drawing.Size(166, 24);
            this.nudMaxStudents.TabIndex = 6;
            this.nudMaxStudents.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblMaxStudents.Location = new System.Drawing.Point(14, 288);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(67, 15);
            this.lblMaxStudents.TabIndex = 13;
            this.lblMaxStudents.Text = "Sĩ số tối đa:";
            // 
            // nudDurationHours
            // 
            this.nudDurationHours.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudDurationHours.Location = new System.Drawing.Point(198, 254);
            this.nudDurationHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDurationHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDurationHours.Name = "nudDurationHours";
            this.nudDurationHours.Size = new System.Drawing.Size(160, 24);
            this.nudDurationHours.TabIndex = 5;
            this.nudDurationHours.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblDuration.Location = new System.Drawing.Point(196, 234);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 15);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Thời lượng (giờ):";
            // 
            // nudCoursePrice
            // 
            this.nudCoursePrice.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudCoursePrice.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudCoursePrice.Location = new System.Drawing.Point(16, 254);
            this.nudCoursePrice.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.nudCoursePrice.Name = "nudCoursePrice";
            this.nudCoursePrice.Size = new System.Drawing.Size(166, 24);
            this.nudCoursePrice.TabIndex = 4;
            this.nudCoursePrice.ThousandsSeparator = true;
            this.nudCoursePrice.Value = new decimal(new int[] {
            750000,
            0,
            0,
            0});
            // 
            // lblCoursePrice
            // 
            this.lblCoursePrice.AutoSize = true;
            this.lblCoursePrice.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCoursePrice.Location = new System.Drawing.Point(14, 234);
            this.lblCoursePrice.Name = "lblCoursePrice";
            this.lblCoursePrice.Size = new System.Drawing.Size(87, 15);
            this.lblCoursePrice.TabIndex = 9;
            this.lblCoursePrice.Text = "Học phí (VNĐ):";
            // 
            // txtInstructor
            // 
            this.txtInstructor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtInstructor.Location = new System.Drawing.Point(16, 202);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(342, 24);
            this.txtInstructor.TabIndex = 3;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblInstructor.Location = new System.Drawing.Point(14, 182);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(82, 15);
            this.lblInstructor.TabIndex = 7;
            this.lblInstructor.Text = "Giảng viên (*):";
            // 
            // cboCourseCategory
            // 
            this.cboCourseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCourseCategory.Location = new System.Drawing.Point(16, 150);
            this.cboCourseCategory.Name = "cboCourseCategory";
            this.cboCourseCategory.Size = new System.Drawing.Size(342, 25);
            this.cboCourseCategory.TabIndex = 2;
            // 
            // lblCourseCategory
            // 
            this.lblCourseCategory.AutoSize = true;
            this.lblCourseCategory.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseCategory.Location = new System.Drawing.Point(14, 130);
            this.lblCourseCategory.Name = "lblCourseCategory";
            this.lblCourseCategory.Size = new System.Drawing.Size(81, 15);
            this.lblCourseCategory.TabIndex = 5;
            this.lblCourseCategory.Text = "Danh mục (*):";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCourseName.Location = new System.Drawing.Point(16, 98);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(342, 24);
            this.txtCourseName.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseName.Location = new System.Drawing.Point(14, 78);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(97, 15);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Tên khóa học (*):";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCourseCode.Location = new System.Drawing.Point(128, 46);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(230, 24);
            this.txtCourseCode.TabIndex = 0;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseCode.Location = new System.Drawing.Point(126, 26);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(95, 15);
            this.lblCourseCode.TabIndex = 2;
            this.lblCourseCode.Text = "Mã khóa học (*):";
            // 
            // txtCourseId
            // 
            this.txtCourseId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtCourseId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCourseId.Location = new System.Drawing.Point(16, 46);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(98, 24);
            this.txtCourseId.TabIndex = 20;
            this.txtCourseId.Text = "Tự động";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCourseId.Location = new System.Drawing.Point(14, 26);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(42, 15);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "Mã số:";
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabCategories.Controls.Add(this.pnlCategoryList);
            this.tabCategories.Controls.Add(this.grpCategoryForm);
            this.tabCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabCategories.Location = new System.Drawing.Point(4, 38);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(10);
            this.tabCategories.Size = new System.Drawing.Size(1312, 678);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "Quản lý danh mục";
            // 
            // pnlCategoryList
            // 
            this.pnlCategoryList.Controls.Add(this.dgvCategories);
            this.pnlCategoryList.Controls.Add(this.pnlCatFilter);
            this.pnlCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryList.Location = new System.Drawing.Point(375, 10);
            this.pnlCategoryList.Name = "pnlCategoryList";
            this.pnlCategoryList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlCategoryList.Size = new System.Drawing.Size(927, 658);
            this.pnlCategoryList.TabIndex = 1;
                        // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(Course_Registration.Category);
// 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategories.ColumnHeadersHeight = 36;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.DataSource = this.categoriesBindingSource;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.EnableHeadersVisualStyles = false;
                        this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCat_CategoryID,

                this.colCat_CategoryName,

                this.colCat_Description,

                this.colCat_TotalCourses
            });

            this.dgvCategories.Location = new System.Drawing.Point(10, 54);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 32;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(917, 604);
            this.dgvCategories.TabIndex = 1;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // colCat_CategoryID
            // 
            this.colCat_CategoryID.DataPropertyName = "CategoryID";
            this.colCat_CategoryID.HeaderText = "Mã danh mục";
            this.colCat_CategoryID.Name = "colCat_CategoryID";
            this.colCat_CategoryID.ReadOnly = true;
            this.colCat_CategoryID.FillWeight = 65F;
            // 
            // colCat_CategoryName
            // 
            this.colCat_CategoryName.DataPropertyName = "CategoryName";
            this.colCat_CategoryName.HeaderText = "Tên danh mục";
            this.colCat_CategoryName.Name = "colCat_CategoryName";
            this.colCat_CategoryName.ReadOnly = true;
            this.colCat_CategoryName.FillWeight = 160F;
            // 
            // colCat_Description
            // 
            this.colCat_Description.DataPropertyName = "Description";
            this.colCat_Description.HeaderText = "Mô tả";
            this.colCat_Description.Name = "colCat_Description";
            this.colCat_Description.ReadOnly = true;
            this.colCat_Description.FillWeight = 230F;
            // 
            // colCat_TotalCourses
            // 
            this.colCat_TotalCourses.DataPropertyName = "TotalCourses";
            this.colCat_TotalCourses.HeaderText = "Số lượng khóa học";
            this.colCat_TotalCourses.Name = "colCat_TotalCourses";
            this.colCat_TotalCourses.ReadOnly = true;
            this.colCat_TotalCourses.FillWeight = 85F;

// 
            // pnlCatFilter
            // 
            this.pnlCatFilter.BackColor = System.Drawing.Color.White;
            this.pnlCatFilter.Controls.Add(this.btnResetCatFilter);
            this.pnlCatFilter.Controls.Add(this.txtSearchCategory);
            this.pnlCatFilter.Controls.Add(this.lblSearchCat);
            this.pnlCatFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCatFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlCatFilter.Name = "pnlCatFilter";
            this.pnlCatFilter.Size = new System.Drawing.Size(917, 54);
            this.pnlCatFilter.TabIndex = 0;
            // 
            // btnResetCatFilter
            // 
            this.btnResetCatFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnResetCatFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCatFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetCatFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCatFilter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnResetCatFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetCatFilter.Location = new System.Drawing.Point(420, 12);
            this.btnResetCatFilter.Name = "btnResetCatFilter";
            this.btnResetCatFilter.Size = new System.Drawing.Size(100, 29);
            this.btnResetCatFilter.TabIndex = 2;
            this.btnResetCatFilter.Text = "Đặt lại";
            this.btnResetCatFilter.UseVisualStyleBackColor = false;
            this.btnResetCatFilter.Click += new System.EventHandler(this.btnResetCatFilter_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchCategory.Location = new System.Drawing.Point(110, 14);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(296, 24);
            this.txtSearchCategory.TabIndex = 1;
            this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
            // 
            // lblSearchCat
            // 
            this.lblSearchCat.AutoSize = true;
            this.lblSearchCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchCat.Location = new System.Drawing.Point(12, 17);
            this.lblSearchCat.Name = "lblSearchCat";
            this.lblSearchCat.Size = new System.Drawing.Size(88, 15);
            this.lblSearchCat.TabIndex = 0;
            this.lblSearchCat.Text = "Tìm kiếm:";
            // 
            // grpCategoryForm
            // 
            this.grpCategoryForm.BackColor = System.Drawing.Color.White;
            this.grpCategoryForm.Controls.Add(this.btnCatClear);
            this.grpCategoryForm.Controls.Add(this.btnCatDelete);
            this.grpCategoryForm.Controls.Add(this.btnCatUpdate);
            this.grpCategoryForm.Controls.Add(this.btnCatAdd);
            this.grpCategoryForm.Controls.Add(this.txtCategoryDesc);
            this.grpCategoryForm.Controls.Add(this.lblCatDesc);
            this.grpCategoryForm.Controls.Add(this.txtCategoryName);
            this.grpCategoryForm.Controls.Add(this.lblCatName);
            this.grpCategoryForm.Controls.Add(this.txtCategoryId);
            this.grpCategoryForm.Controls.Add(this.lblCatId);
            this.grpCategoryForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCategoryForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCategoryForm.Location = new System.Drawing.Point(10, 10);
            this.grpCategoryForm.Name = "grpCategoryForm";
            this.grpCategoryForm.Size = new System.Drawing.Size(365, 658);
            this.grpCategoryForm.TabIndex = 0;
            this.grpCategoryForm.TabStop = false;
            this.grpCategoryForm.Text = "Thông tin danh mục";
            // 
            // btnCatClear
            // 
            this.btnCatClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnCatClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCatClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCatClear.Location = new System.Drawing.Point(188, 358);
            this.btnCatClear.Name = "btnCatClear";
            this.btnCatClear.Size = new System.Drawing.Size(160, 38);
            this.btnCatClear.TabIndex = 6;
            this.btnCatClear.Text = "Làm mới";
            this.btnCatClear.UseVisualStyleBackColor = false;
            this.btnCatClear.Click += new System.EventHandler(this.btnCatClear_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCatDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCatDelete.Location = new System.Drawing.Point(16, 358);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(160, 38);
            this.btnCatDelete.TabIndex = 5;
            this.btnCatDelete.Text = "Xóa";
            this.btnCatDelete.UseVisualStyleBackColor = false;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // btnCatUpdate
            // 
            this.btnCatUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCatUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCatUpdate.Location = new System.Drawing.Point(188, 310);
            this.btnCatUpdate.Name = "btnCatUpdate";
            this.btnCatUpdate.Size = new System.Drawing.Size(160, 38);
            this.btnCatUpdate.TabIndex = 4;
            this.btnCatUpdate.Text = "Cập nhật";
            this.btnCatUpdate.UseVisualStyleBackColor = false;
            this.btnCatUpdate.Click += new System.EventHandler(this.btnCatUpdate_Click);
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnCatAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatAdd.FlatAppearance.BorderSize = 0;
            this.btnCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatAdd.ForeColor = System.Drawing.Color.White;
            this.btnCatAdd.Location = new System.Drawing.Point(16, 310);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(160, 38);
            this.btnCatAdd.TabIndex = 3;
            this.btnCatAdd.Text = "Thêm mới";
            this.btnCatAdd.UseVisualStyleBackColor = false;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCategoryDesc.Location = new System.Drawing.Point(16, 176);
            this.txtCategoryDesc.Multiline = true;
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategoryDesc.Size = new System.Drawing.Size(332, 114);
            this.txtCategoryDesc.TabIndex = 2;
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCatDesc.Location = new System.Drawing.Point(14, 154);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(98, 15);
            this.lblCatDesc.TabIndex = 4;
            this.lblCatDesc.Text = "Mô tả danh mục:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCategoryName.Location = new System.Drawing.Point(16, 112);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(332, 24);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCatName.Location = new System.Drawing.Point(14, 90);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(102, 15);
            this.lblCatName.TabIndex = 2;
            this.lblCatName.Text = "Tên danh mục (*):";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtCategoryId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCategoryId.Location = new System.Drawing.Point(16, 52);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(140, 24);
            this.txtCategoryId.TabIndex = 0;
            this.txtCategoryId.Text = "Tự động";
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblCatId.Location = new System.Drawing.Point(14, 30);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(84, 15);
            this.lblCatId.TabIndex = 0;
            this.lblCatId.Text = "Mã danh mục:";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabUsers.Controls.Add(this.pnlUserList);
            this.tabUsers.Controls.Add(this.grpUserForm);
            this.tabUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabUsers.Location = new System.Drawing.Point(4, 38);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(10);
            this.tabUsers.Size = new System.Drawing.Size(1312, 678);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "Quản lý tài khoản";
            // 
            // pnlUserList
            // 
            this.pnlUserList.Controls.Add(this.dgvUsers);
            this.pnlUserList.Controls.Add(this.pnlUserFilter);
            this.pnlUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserList.Location = new System.Drawing.Point(385, 10);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlUserList.Size = new System.Drawing.Size(917, 658);
            this.pnlUserList.TabIndex = 1;
                        // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Course_Registration.User);
// 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsers.ColumnHeadersHeight = 36;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
                        this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUser_UserID,

                this.colUser_Username,

                this.colUser_FullName,

                this.colUser_RoleDisplay,

                this.colUser_Email,

                this.colUser_Phone,

                this.colUser_Balance,

                this.colUser_BoughtCount,

                this.colUser_StatusText
            });

            this.dgvUsers.Location = new System.Drawing.Point(10, 54);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(907, 604);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // colUser_UserID
            // 
            this.colUser_UserID.DataPropertyName = "UserID";
            this.colUser_UserID.HeaderText = "Mã số";
            this.colUser_UserID.Name = "colUser_UserID";
            this.colUser_UserID.ReadOnly = true;
            this.colUser_UserID.FillWeight = 45F;
            // 
            // colUser_Username
            // 
            this.colUser_Username.DataPropertyName = "Username";
            this.colUser_Username.HeaderText = "Tên đăng nhập";
            this.colUser_Username.Name = "colUser_Username";
            this.colUser_Username.ReadOnly = true;
            this.colUser_Username.FillWeight = 90F;
            // 
            // colUser_FullName
            // 
            this.colUser_FullName.DataPropertyName = "FullName";
            this.colUser_FullName.HeaderText = "Họ và tên";
            this.colUser_FullName.Name = "colUser_FullName";
            this.colUser_FullName.ReadOnly = true;
            this.colUser_FullName.FillWeight = 135F;
            // 
            // colUser_RoleDisplay
            // 
            this.colUser_RoleDisplay.DataPropertyName = "RoleDisplay";
            this.colUser_RoleDisplay.HeaderText = "Vai trò";
            this.colUser_RoleDisplay.Name = "colUser_RoleDisplay";
            this.colUser_RoleDisplay.ReadOnly = true;
            this.colUser_RoleDisplay.FillWeight = 95F;
            // 
            // colUser_Email
            // 
            this.colUser_Email.DataPropertyName = "Email";
            this.colUser_Email.HeaderText = "Email";
            this.colUser_Email.Name = "colUser_Email";
            this.colUser_Email.ReadOnly = true;
            this.colUser_Email.FillWeight = 125F;
            // 
            // colUser_Phone
            // 
            this.colUser_Phone.DataPropertyName = "Phone";
            this.colUser_Phone.HeaderText = "Số điện thoại";
            this.colUser_Phone.Name = "colUser_Phone";
            this.colUser_Phone.ReadOnly = true;
            this.colUser_Phone.FillWeight = 88F;
            // 
            // colUser_Balance
            // 
            this.colUser_Balance.DataPropertyName = "Balance";
            this.colUser_Balance.HeaderText = "Số dư (VNĐ)";
            this.colUser_Balance.Name = "colUser_Balance";
            this.colUser_Balance.ReadOnly = true;
            this.colUser_Balance.DefaultCellStyle.Format = "N0";
            this.colUser_Balance.FillWeight = 90F;
            // 
            // colUser_BoughtCount
            // 
            this.colUser_BoughtCount.DataPropertyName = "BoughtCount";
            this.colUser_BoughtCount.HeaderText = "Khóa đã đăng ký";
            this.colUser_BoughtCount.Name = "colUser_BoughtCount";
            this.colUser_BoughtCount.ReadOnly = true;
            this.colUser_BoughtCount.FillWeight = 80F;
            // 
            // colUser_StatusText
            // 
            this.colUser_StatusText.DataPropertyName = "StatusText";
            this.colUser_StatusText.HeaderText = "Trạng thái";
            this.colUser_StatusText.Name = "colUser_StatusText";
            this.colUser_StatusText.ReadOnly = true;
            this.colUser_StatusText.FillWeight = 85F;

// 
            // pnlUserFilter
            // 
            this.pnlUserFilter.BackColor = System.Drawing.Color.White;
            this.pnlUserFilter.Controls.Add(this.btnResetUserFilter);
            this.pnlUserFilter.Controls.Add(this.cboFilterUserRole);
            this.pnlUserFilter.Controls.Add(this.lblFilterRole);
            this.pnlUserFilter.Controls.Add(this.txtSearchUser);
            this.pnlUserFilter.Controls.Add(this.lblSearchUser);
            this.pnlUserFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlUserFilter.Name = "pnlUserFilter";
            this.pnlUserFilter.Size = new System.Drawing.Size(907, 54);
            this.pnlUserFilter.TabIndex = 0;
            // 
            // btnResetUserFilter
            // 
            this.btnResetUserFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnResetUserFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetUserFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetUserFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetUserFilter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnResetUserFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetUserFilter.Location = new System.Drawing.Point(564, 12);
            this.btnResetUserFilter.Name = "btnResetUserFilter";
            this.btnResetUserFilter.Size = new System.Drawing.Size(96, 29);
            this.btnResetUserFilter.TabIndex = 4;
            this.btnResetUserFilter.Text = "Đặt lại";
            this.btnResetUserFilter.UseVisualStyleBackColor = false;
            this.btnResetUserFilter.Click += new System.EventHandler(this.btnResetUserFilter_Click);
            // 
            // cboFilterUserRole
            // 
            this.cboFilterUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterUserRole.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterUserRole.Items.AddRange(new object[] {
            "Tất cả vai trò",
            "Quản trị viên",
            "Học viên"});
            this.cboFilterUserRole.Location = new System.Drawing.Point(382, 14);
            this.cboFilterUserRole.Name = "cboFilterUserRole";
            this.cboFilterUserRole.Size = new System.Drawing.Size(168, 23);
            this.cboFilterUserRole.TabIndex = 3;
            this.cboFilterUserRole.SelectedIndexChanged += new System.EventHandler(this.UserFilter_Changed);
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterRole.Location = new System.Drawing.Point(324, 17);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(46, 15);
            this.lblFilterRole.TabIndex = 2;
            this.lblFilterRole.Text = "Vai trò:";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchUser.Location = new System.Drawing.Point(82, 14);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(228, 24);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.UserFilter_Changed);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchUser.Location = new System.Drawing.Point(12, 17);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(62, 15);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Tìm kiếm:";
            // 
            // grpUserForm
            // 
            this.grpUserForm.BackColor = System.Drawing.Color.White;
            this.grpUserForm.Controls.Add(this.btnUserClear);
            this.grpUserForm.Controls.Add(this.btnUserDelete);
            this.grpUserForm.Controls.Add(this.btnUserUpdate);
            this.grpUserForm.Controls.Add(this.btnUserAdd);
            this.grpUserForm.Controls.Add(this.chkUserActive);
            this.grpUserForm.Controls.Add(this.nudUserBalance);
            this.grpUserForm.Controls.Add(this.lblUserBalance);
            this.grpUserForm.Controls.Add(this.txtUserPhone);
            this.grpUserForm.Controls.Add(this.lblUserPhone);
            this.grpUserForm.Controls.Add(this.txtUserEmail);
            this.grpUserForm.Controls.Add(this.lblUserEmail);
            this.grpUserForm.Controls.Add(this.txtUserFullName);
            this.grpUserForm.Controls.Add(this.lblUserFullName);
            this.grpUserForm.Controls.Add(this.txtUserPassword);
            this.grpUserForm.Controls.Add(this.lblUserPassword);
            this.grpUserForm.Controls.Add(this.txtUserUsername);
            this.grpUserForm.Controls.Add(this.lblUserUsername);
            this.grpUserForm.Controls.Add(this.cboUserRole);
            this.grpUserForm.Controls.Add(this.lblUserRole);
            this.grpUserForm.Controls.Add(this.txtUserId);
            this.grpUserForm.Controls.Add(this.lblUserId);
            this.grpUserForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpUserForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpUserForm.Location = new System.Drawing.Point(10, 10);
            this.grpUserForm.Name = "grpUserForm";
            this.grpUserForm.Size = new System.Drawing.Size(375, 658);
            this.grpUserForm.TabIndex = 0;
            this.grpUserForm.TabStop = false;
            this.grpUserForm.Text = "Thông tin tài khoản";
            // 
            // btnUserClear
            // 
            this.btnUserClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnUserClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnUserClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnUserClear.Location = new System.Drawing.Point(194, 384);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(164, 38);
            this.btnUserClear.TabIndex = 11;
            this.btnUserClear.Text = "Làm mới";
            this.btnUserClear.UseVisualStyleBackColor = false;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnUserDelete.Location = new System.Drawing.Point(16, 384);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(166, 38);
            this.btnUserDelete.TabIndex = 10;
            this.btnUserDelete.Text = "Xóa";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnUserUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnUserUpdate.Location = new System.Drawing.Point(194, 336);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(164, 38);
            this.btnUserUpdate.TabIndex = 9;
            this.btnUserUpdate.Text = "Cập nhật";
            this.btnUserUpdate.UseVisualStyleBackColor = false;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Location = new System.Drawing.Point(16, 336);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(166, 38);
            this.btnUserAdd.TabIndex = 8;
            this.btnUserAdd.Text = "Thêm mới";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // chkUserActive
            // 
            this.chkUserActive.AutoSize = true;
            this.chkUserActive.Checked = true;
            this.chkUserActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkUserActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.chkUserActive.Location = new System.Drawing.Point(16, 294);
            this.chkUserActive.Name = "chkUserActive";
            this.chkUserActive.Size = new System.Drawing.Size(165, 19);
            this.chkUserActive.TabIndex = 7;
            this.chkUserActive.Text = "Tài khoản đang hoạt động";
            this.chkUserActive.UseVisualStyleBackColor = true;
            // 
            // nudUserBalance
            // 
            this.nudUserBalance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudUserBalance.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUserBalance.Location = new System.Drawing.Point(16, 256);
            this.nudUserBalance.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.nudUserBalance.Name = "nudUserBalance";
            this.nudUserBalance.Size = new System.Drawing.Size(342, 24);
            this.nudUserBalance.TabIndex = 6;
            this.nudUserBalance.ThousandsSeparator = true;
            // 
            // lblUserBalance
            // 
            this.lblUserBalance.AutoSize = true;
            this.lblUserBalance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserBalance.Location = new System.Drawing.Point(14, 236);
            this.lblUserBalance.Name = "lblUserBalance";
            this.lblUserBalance.Size = new System.Drawing.Size(127, 15);
            this.lblUserBalance.TabIndex = 13;
            this.lblUserBalance.Text = "Số dư tài khoản (VNĐ):";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserPhone.Location = new System.Drawing.Point(202, 202);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(156, 24);
            this.txtUserPhone.TabIndex = 5;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserPhone.Location = new System.Drawing.Point(200, 182);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(79, 15);
            this.lblUserPhone.TabIndex = 11;
            this.lblUserPhone.Text = "Số điện thoại:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserEmail.Location = new System.Drawing.Point(16, 202);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(174, 24);
            this.txtUserEmail.TabIndex = 4;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserEmail.Location = new System.Drawing.Point(14, 182);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(39, 15);
            this.lblUserEmail.TabIndex = 9;
            this.lblUserEmail.Text = "Email:";
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserFullName.Location = new System.Drawing.Point(16, 150);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(342, 24);
            this.txtUserFullName.TabIndex = 3;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserFullName.Location = new System.Drawing.Point(14, 130);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(77, 15);
            this.lblUserFullName.TabIndex = 7;
            this.lblUserFullName.Text = "Họ và tên (*):";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserPassword.Location = new System.Drawing.Point(194, 98);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(164, 24);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserPassword.Location = new System.Drawing.Point(192, 78);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(76, 15);
            this.lblUserPassword.TabIndex = 5;
            this.lblUserPassword.Text = "Mật khẩu (*):";
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserUsername.Location = new System.Drawing.Point(16, 98);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(166, 24);
            this.txtUserUsername.TabIndex = 1;
            // 
            // lblUserUsername
            // 
            this.lblUserUsername.AutoSize = true;
            this.lblUserUsername.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserUsername.Location = new System.Drawing.Point(14, 78);
            this.lblUserUsername.Name = "lblUserUsername";
            this.lblUserUsername.Size = new System.Drawing.Size(105, 15);
            this.lblUserUsername.TabIndex = 3;
            this.lblUserUsername.Text = "Tên đăng nhập (*):";
            // 
            // cboUserRole
            // 
            this.cboUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboUserRole.Items.AddRange(new object[] {
            "Học viên",
            "Quản trị viên"});
            this.cboUserRole.Location = new System.Drawing.Point(138, 46);
            this.cboUserRole.Name = "cboUserRole";
            this.cboUserRole.Size = new System.Drawing.Size(220, 25);
            this.cboUserRole.TabIndex = 0;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserRole.Location = new System.Drawing.Point(136, 26);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(111, 15);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Vai trò tài khoản (*):";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUserId.Location = new System.Drawing.Point(16, 46);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(108, 24);
            this.txtUserId.TabIndex = 15;
            this.txtUserId.Text = "Tự động";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblUserId.Location = new System.Drawing.Point(14, 26);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(42, 15);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Mã số:";
            // 
            // tabEnrollments
            // 
            this.tabEnrollments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabEnrollments.Controls.Add(this.pnlEnrollList);
            this.tabEnrollments.Controls.Add(this.grpEnrollForm);
            this.tabEnrollments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabEnrollments.Location = new System.Drawing.Point(4, 38);
            this.tabEnrollments.Name = "tabEnrollments";
            this.tabEnrollments.Padding = new System.Windows.Forms.Padding(10);
            this.tabEnrollments.Size = new System.Drawing.Size(1312, 678);
            this.tabEnrollments.TabIndex = 3;
            this.tabEnrollments.Text = "Quản lý đăng ký";
            // 
            // pnlEnrollList
            // 
            this.pnlEnrollList.Controls.Add(this.dgvEnrollments);
            this.pnlEnrollList.Controls.Add(this.pnlEnrollFilter);
            this.pnlEnrollList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnrollList.Location = new System.Drawing.Point(385, 10);
            this.pnlEnrollList.Name = "pnlEnrollList";
            this.pnlEnrollList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlEnrollList.Size = new System.Drawing.Size(917, 658);
            this.pnlEnrollList.TabIndex = 1;
                        // 
            // enrollmentsBindingSource
            // 
            this.enrollmentsBindingSource.DataSource = typeof(Course_Registration.Enrollment);
// 
            // dgvEnrollments
            // 
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvEnrollments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEnrollments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvEnrollments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEnrollments.ColumnHeadersHeight = 36;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEnrollments.AutoGenerateColumns = false;
            this.dgvEnrollments.DataSource = this.enrollmentsBindingSource;
            this.dgvEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollments.EnableHeadersVisualStyles = false;
                        this.dgvEnrollments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colEnroll_EnrollmentID,

                this.colEnroll_StudentName,

                this.colEnroll_Username,

                this.colEnroll_CourseCode,

                this.colEnroll_CourseName,

                this.colEnroll_EnrollDate,

                this.colEnroll_OriginalPrice,

                this.colEnroll_DiscountAmount,

                this.colEnroll_VoucherDisplay,

                this.colEnroll_PaidAmount,

                this.colEnroll_StatusDisplay,

                this.colEnroll_Note
            });

            this.dgvEnrollments.Location = new System.Drawing.Point(10, 54);
            this.dgvEnrollments.MultiSelect = false;
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.RowHeadersVisible = false;
            this.dgvEnrollments.RowTemplate.Height = 30;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(907, 604);
            this.dgvEnrollments.TabIndex = 1;
            this.dgvEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellClick);
            // 
            // colEnroll_EnrollmentID
            // 
            this.colEnroll_EnrollmentID.DataPropertyName = "EnrollmentID";
            this.colEnroll_EnrollmentID.HeaderText = "Mã ĐK";
            this.colEnroll_EnrollmentID.Name = "colEnroll_EnrollmentID";
            this.colEnroll_EnrollmentID.ReadOnly = true;
            this.colEnroll_EnrollmentID.FillWeight = 50F;
            // 
            // colEnroll_StudentName
            // 
            this.colEnroll_StudentName.DataPropertyName = "StudentName";
            this.colEnroll_StudentName.HeaderText = "Học viên";
            this.colEnroll_StudentName.Name = "colEnroll_StudentName";
            this.colEnroll_StudentName.ReadOnly = true;
            this.colEnroll_StudentName.FillWeight = 110F;
            // 
            // colEnroll_Username
            // 
            this.colEnroll_Username.DataPropertyName = "Username";
            this.colEnroll_Username.HeaderText = "Tài khoản";
            this.colEnroll_Username.Name = "colEnroll_Username";
            this.colEnroll_Username.ReadOnly = true;
            this.colEnroll_Username.FillWeight = 80F;
            // 
            // colEnroll_CourseCode
            // 
            this.colEnroll_CourseCode.DataPropertyName = "CourseCode";
            this.colEnroll_CourseCode.HeaderText = "Mã khóa học";
            this.colEnroll_CourseCode.Name = "colEnroll_CourseCode";
            this.colEnroll_CourseCode.ReadOnly = true;
            this.colEnroll_CourseCode.FillWeight = 60F;
            // 
            // colEnroll_CourseName
            // 
            this.colEnroll_CourseName.DataPropertyName = "CourseName";
            this.colEnroll_CourseName.HeaderText = "Tên khóa học";
            this.colEnroll_CourseName.Name = "colEnroll_CourseName";
            this.colEnroll_CourseName.ReadOnly = true;
            this.colEnroll_CourseName.FillWeight = 140F;
            // 
            // colEnroll_EnrollDate
            // 
            this.colEnroll_EnrollDate.DataPropertyName = "EnrollDate";
            this.colEnroll_EnrollDate.HeaderText = "Ngày đăng ký";
            this.colEnroll_EnrollDate.Name = "colEnroll_EnrollDate";
            this.colEnroll_EnrollDate.ReadOnly = true;
            this.colEnroll_EnrollDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colEnroll_EnrollDate.FillWeight = 75F;
            // 
            // colEnroll_OriginalPrice
            // 
            this.colEnroll_OriginalPrice.DataPropertyName = "OriginalPrice";
            this.colEnroll_OriginalPrice.HeaderText = "Học phí gốc (VNĐ)";
            this.colEnroll_OriginalPrice.Name = "colEnroll_OriginalPrice";
            this.colEnroll_OriginalPrice.ReadOnly = true;
            this.colEnroll_OriginalPrice.DefaultCellStyle.Format = "N0";
            this.colEnroll_OriginalPrice.FillWeight = 75F;
            // 
            // colEnroll_DiscountAmount
            // 
            this.colEnroll_DiscountAmount.DataPropertyName = "DiscountAmount";
            this.colEnroll_DiscountAmount.HeaderText = "Miễn giảm (VNĐ)";
            this.colEnroll_DiscountAmount.Name = "colEnroll_DiscountAmount";
            this.colEnroll_DiscountAmount.ReadOnly = true;
            this.colEnroll_DiscountAmount.DefaultCellStyle.Format = "N0";
            this.colEnroll_DiscountAmount.FillWeight = 75F;
            // 
            // colEnroll_VoucherDisplay
            // 
            this.colEnroll_VoucherDisplay.DataPropertyName = "VoucherDisplay";
            this.colEnroll_VoucherDisplay.HeaderText = "Mã học bổng";
            this.colEnroll_VoucherDisplay.Name = "colEnroll_VoucherDisplay";
            this.colEnroll_VoucherDisplay.ReadOnly = true;
            this.colEnroll_VoucherDisplay.FillWeight = 85F;
            // 
            // colEnroll_PaidAmount
            // 
            this.colEnroll_PaidAmount.DataPropertyName = "PaidAmount";
            this.colEnroll_PaidAmount.HeaderText = "Thực đóng (VNĐ)";
            this.colEnroll_PaidAmount.Name = "colEnroll_PaidAmount";
            this.colEnroll_PaidAmount.ReadOnly = true;
            this.colEnroll_PaidAmount.DefaultCellStyle.Format = "N0";
            this.colEnroll_PaidAmount.FillWeight = 80F;
            // 
            // colEnroll_StatusDisplay
            // 
            this.colEnroll_StatusDisplay.DataPropertyName = "StatusDisplay";
            this.colEnroll_StatusDisplay.HeaderText = "Trạng thái";
            this.colEnroll_StatusDisplay.Name = "colEnroll_StatusDisplay";
            this.colEnroll_StatusDisplay.ReadOnly = true;
            this.colEnroll_StatusDisplay.FillWeight = 85F;
            // 
            // colEnroll_Note
            // 
            this.colEnroll_Note.DataPropertyName = "Note";
            this.colEnroll_Note.HeaderText = "Ghi chú";
            this.colEnroll_Note.Name = "colEnroll_Note";
            this.colEnroll_Note.ReadOnly = true;
            this.colEnroll_Note.FillWeight = 110F;

// 
            // pnlEnrollFilter
            // 
            this.pnlEnrollFilter.BackColor = System.Drawing.Color.White;
            this.pnlEnrollFilter.Controls.Add(this.btnRdlcEnrollmentReport);
            this.pnlEnrollFilter.Controls.Add(this.btnExportEnrollments);
            this.pnlEnrollFilter.Controls.Add(this.btnResetEnrollFilter);
            this.pnlEnrollFilter.Controls.Add(this.cboFilterEnrollStatus);
            this.pnlEnrollFilter.Controls.Add(this.lblFilterEnrollStatus);
            this.pnlEnrollFilter.Controls.Add(this.txtSearchEnroll);
            this.pnlEnrollFilter.Controls.Add(this.lblSearchEnroll);
            this.pnlEnrollFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnrollFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlEnrollFilter.Name = "pnlEnrollFilter";
            this.pnlEnrollFilter.Size = new System.Drawing.Size(907, 54);
            this.pnlEnrollFilter.TabIndex = 0;
            // 
            // btnRdlcEnrollmentReport
            // 
            this.btnRdlcEnrollmentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRdlcEnrollmentReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRdlcEnrollmentReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRdlcEnrollmentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdlcEnrollmentReport.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnRdlcEnrollmentReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnRdlcEnrollmentReport.Location = new System.Drawing.Point(796, 12);
            this.btnRdlcEnrollmentReport.Name = "btnRdlcEnrollmentReport";
            this.btnRdlcEnrollmentReport.Size = new System.Drawing.Size(165, 29);
            this.btnRdlcEnrollmentReport.TabIndex = 6;
            this.btnRdlcEnrollmentReport.Text = "🖨️ In danh sách";
            this.btnRdlcEnrollmentReport.UseVisualStyleBackColor = false;
            this.btnRdlcEnrollmentReport.Click += new System.EventHandler(this.btnRdlcEnrollmentReport_Click);
            // 
            // btnExportEnrollments
            // 
            this.btnExportEnrollments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportEnrollments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportEnrollments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportEnrollments.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportEnrollments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportEnrollments.Location = new System.Drawing.Point(684, 12);
            this.btnExportEnrollments.Name = "btnExportEnrollments";
            this.btnExportEnrollments.Size = new System.Drawing.Size(104, 29);
            this.btnExportEnrollments.TabIndex = 5;
            this.btnExportEnrollments.Text = "Xuất Excel";
            this.btnExportEnrollments.UseVisualStyleBackColor = false;
            this.btnExportEnrollments.Click += new System.EventHandler(this.btnExportEnrollments_Click);
            // 
            // btnResetEnrollFilter
            // 
            this.btnResetEnrollFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnResetEnrollFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEnrollFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetEnrollFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEnrollFilter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnResetEnrollFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetEnrollFilter.Location = new System.Drawing.Point(578, 12);
            this.btnResetEnrollFilter.Name = "btnResetEnrollFilter";
            this.btnResetEnrollFilter.Size = new System.Drawing.Size(96, 29);
            this.btnResetEnrollFilter.TabIndex = 4;
            this.btnResetEnrollFilter.Text = "Đặt lại";
            this.btnResetEnrollFilter.UseVisualStyleBackColor = false;
            this.btnResetEnrollFilter.Click += new System.EventHandler(this.btnResetEnrollFilter_Click);
            // 
            // cboFilterEnrollStatus
            // 
            this.cboFilterEnrollStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterEnrollStatus.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterEnrollStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đã đăng ký",
            "Đã hủy"});
            this.cboFilterEnrollStatus.Location = new System.Drawing.Point(404, 14);
            this.cboFilterEnrollStatus.Name = "cboFilterEnrollStatus";
            this.cboFilterEnrollStatus.Size = new System.Drawing.Size(160, 23);
            this.cboFilterEnrollStatus.TabIndex = 3;
            this.cboFilterEnrollStatus.SelectedIndexChanged += new System.EventHandler(this.EnrollFilter_Changed);
            // 
            // lblFilterEnrollStatus
            // 
            this.lblFilterEnrollStatus.AutoSize = true;
            this.lblFilterEnrollStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterEnrollStatus.Location = new System.Drawing.Point(332, 17);
            this.lblFilterEnrollStatus.Name = "lblFilterEnrollStatus";
            this.lblFilterEnrollStatus.Size = new System.Drawing.Size(65, 15);
            this.lblFilterEnrollStatus.TabIndex = 2;
            this.lblFilterEnrollStatus.Text = "Trạng thái:";
            // 
            // txtSearchEnroll
            // 
            this.txtSearchEnroll.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchEnroll.Location = new System.Drawing.Point(82, 14);
            this.txtSearchEnroll.Name = "txtSearchEnroll";
            this.txtSearchEnroll.Size = new System.Drawing.Size(236, 24);
            this.txtSearchEnroll.TabIndex = 1;
            this.txtSearchEnroll.TextChanged += new System.EventHandler(this.EnrollFilter_Changed);
            // 
            // lblSearchEnroll
            // 
            this.lblSearchEnroll.AutoSize = true;
            this.lblSearchEnroll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchEnroll.Location = new System.Drawing.Point(12, 17);
            this.lblSearchEnroll.Name = "lblSearchEnroll";
            this.lblSearchEnroll.Size = new System.Drawing.Size(62, 15);
            this.lblSearchEnroll.TabIndex = 0;
            this.lblSearchEnroll.Text = "Tìm kiếm:";
            // 
            // grpEnrollForm
            // 
            this.grpEnrollForm.BackColor = System.Drawing.Color.White;
            this.grpEnrollForm.Controls.Add(this.btnPrintAdminReceipt);
            this.grpEnrollForm.Controls.Add(this.btnEnrollClear);
            this.grpEnrollForm.Controls.Add(this.btnEnrollDelete);
            this.grpEnrollForm.Controls.Add(this.btnEnrollRefundCancel);
            this.grpEnrollForm.Controls.Add(this.btnEnrollUpdate);
            this.grpEnrollForm.Controls.Add(this.btnEnrollAdd);
            this.grpEnrollForm.Controls.Add(this.txtEnrollNote);
            this.grpEnrollForm.Controls.Add(this.lblEnrollNote);
            this.grpEnrollForm.Controls.Add(this.chkDeductWalletOnAdminCreate);
            this.grpEnrollForm.Controls.Add(this.nudEnrollPaid);
            this.grpEnrollForm.Controls.Add(this.lblEnrollPaid);
            this.grpEnrollForm.Controls.Add(this.cboEnrollCourse);
            this.grpEnrollForm.Controls.Add(this.lblEnrollCourse);
            this.grpEnrollForm.Controls.Add(this.cboEnrollStudent);
            this.grpEnrollForm.Controls.Add(this.lblEnrollStudent);
            this.grpEnrollForm.Controls.Add(this.cboEnrollStatus);
            this.grpEnrollForm.Controls.Add(this.lblEnrollStatus);
            this.grpEnrollForm.Controls.Add(this.txtEnrollmentId);
            this.grpEnrollForm.Controls.Add(this.lblEnrollId);
            this.grpEnrollForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpEnrollForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEnrollForm.Location = new System.Drawing.Point(10, 10);
            this.grpEnrollForm.Name = "grpEnrollForm";
            this.grpEnrollForm.Size = new System.Drawing.Size(375, 658);
            this.grpEnrollForm.TabIndex = 0;
            this.grpEnrollForm.TabStop = false;
            this.grpEnrollForm.Text = "Thông tin đăng ký khóa học";
            // 
            // btnPrintAdminReceipt
            // 
            this.btnPrintAdminReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnPrintAdminReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAdminReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnPrintAdminReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAdminReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintAdminReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPrintAdminReceipt.Location = new System.Drawing.Point(16, 514);
            this.btnPrintAdminReceipt.Name = "btnPrintAdminReceipt";
            this.btnPrintAdminReceipt.Size = new System.Drawing.Size(342, 36);
            this.btnPrintAdminReceipt.TabIndex = 11;
            this.btnPrintAdminReceipt.Text = "Xem & In biên lai xác nhận học phí";
            this.btnPrintAdminReceipt.UseVisualStyleBackColor = false;
            this.btnPrintAdminReceipt.Click += new System.EventHandler(this.btnPrintAdminReceipt_Click);
            // 
            // btnEnrollClear
            // 
            this.btnEnrollClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnEnrollClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnEnrollClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnEnrollClear.Location = new System.Drawing.Point(16, 470);
            this.btnEnrollClear.Name = "btnEnrollClear";
            this.btnEnrollClear.Size = new System.Drawing.Size(342, 34);
            this.btnEnrollClear.TabIndex = 10;
            this.btnEnrollClear.Text = "Làm mới";
            this.btnEnrollClear.UseVisualStyleBackColor = false;
            this.btnEnrollClear.Click += new System.EventHandler(this.btnEnrollClear_Click);
            // 
            // btnEnrollDelete
            // 
            this.btnEnrollDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEnrollDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnEnrollDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEnrollDelete.Location = new System.Drawing.Point(194, 422);
            this.btnEnrollDelete.Name = "btnEnrollDelete";
            this.btnEnrollDelete.Size = new System.Drawing.Size(164, 38);
            this.btnEnrollDelete.TabIndex = 9;
            this.btnEnrollDelete.Text = "Xóa";
            this.btnEnrollDelete.UseVisualStyleBackColor = false;
            this.btnEnrollDelete.Click += new System.EventHandler(this.btnEnrollDelete_Click);
            // 
            // btnEnrollRefundCancel
            // 
            this.btnEnrollRefundCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.btnEnrollRefundCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollRefundCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnEnrollRefundCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollRefundCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnEnrollRefundCancel.Location = new System.Drawing.Point(16, 422);
            this.btnEnrollRefundCancel.Name = "btnEnrollRefundCancel";
            this.btnEnrollRefundCancel.Size = new System.Drawing.Size(166, 38);
            this.btnEnrollRefundCancel.TabIndex = 8;
            this.btnEnrollRefundCancel.Text = "Hủy và hoàn phí";
            this.btnEnrollRefundCancel.UseVisualStyleBackColor = false;
            this.btnEnrollRefundCancel.Click += new System.EventHandler(this.btnEnrollRefundCancel_Click);
            // 
            // btnEnrollUpdate
            // 
            this.btnEnrollUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnEnrollUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnEnrollUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnEnrollUpdate.Location = new System.Drawing.Point(194, 376);
            this.btnEnrollUpdate.Name = "btnEnrollUpdate";
            this.btnEnrollUpdate.Size = new System.Drawing.Size(164, 38);
            this.btnEnrollUpdate.TabIndex = 7;
            this.btnEnrollUpdate.Text = "Cập nhật";
            this.btnEnrollUpdate.UseVisualStyleBackColor = false;
            this.btnEnrollUpdate.Click += new System.EventHandler(this.btnEnrollUpdate_Click);
            // 
            // btnEnrollAdd
            // 
            this.btnEnrollAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnEnrollAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollAdd.FlatAppearance.BorderSize = 0;
            this.btnEnrollAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollAdd.ForeColor = System.Drawing.Color.White;
            this.btnEnrollAdd.Location = new System.Drawing.Point(16, 376);
            this.btnEnrollAdd.Name = "btnEnrollAdd";
            this.btnEnrollAdd.Size = new System.Drawing.Size(166, 38);
            this.btnEnrollAdd.TabIndex = 6;
            this.btnEnrollAdd.Text = "Thêm đăng ký";
            this.btnEnrollAdd.UseVisualStyleBackColor = false;
            this.btnEnrollAdd.Click += new System.EventHandler(this.btnEnrollAdd_Click);
            // 
            // txtEnrollNote
            // 
            this.txtEnrollNote.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtEnrollNote.Location = new System.Drawing.Point(16, 288);
            this.txtEnrollNote.Multiline = true;
            this.txtEnrollNote.Name = "txtEnrollNote";
            this.txtEnrollNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnrollNote.Size = new System.Drawing.Size(342, 74);
            this.txtEnrollNote.TabIndex = 5;
            // 
            // lblEnrollNote
            // 
            this.lblEnrollNote.AutoSize = true;
            this.lblEnrollNote.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollNote.Location = new System.Drawing.Point(14, 268);
            this.lblEnrollNote.Name = "lblEnrollNote";
            this.lblEnrollNote.Size = new System.Drawing.Size(51, 15);
            this.lblEnrollNote.TabIndex = 11;
            this.lblEnrollNote.Text = "Ghi chú:";
            // 
            // chkDeductWalletOnAdminCreate
            // 
            this.chkDeductWalletOnAdminCreate.AutoSize = true;
            this.chkDeductWalletOnAdminCreate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.chkDeductWalletOnAdminCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.chkDeductWalletOnAdminCreate.Location = new System.Drawing.Point(16, 238);
            this.chkDeductWalletOnAdminCreate.Name = "chkDeductWalletOnAdminCreate";
            this.chkDeductWalletOnAdminCreate.Size = new System.Drawing.Size(222, 19);
            this.chkDeductWalletOnAdminCreate.TabIndex = 4;
            this.chkDeductWalletOnAdminCreate.Text = "Trừ trực tiếp số dư tài khoản học viên";
            this.chkDeductWalletOnAdminCreate.UseVisualStyleBackColor = true;
            // 
            // nudEnrollPaid
            // 
            this.nudEnrollPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudEnrollPaid.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudEnrollPaid.Location = new System.Drawing.Point(16, 202);
            this.nudEnrollPaid.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.nudEnrollPaid.Name = "nudEnrollPaid";
            this.nudEnrollPaid.Size = new System.Drawing.Size(342, 24);
            this.nudEnrollPaid.TabIndex = 3;
            this.nudEnrollPaid.ThousandsSeparator = true;
            // 
            // lblEnrollPaid
            // 
            this.lblEnrollPaid.AutoSize = true;
            this.lblEnrollPaid.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollPaid.Location = new System.Drawing.Point(14, 182);
            this.lblEnrollPaid.Name = "lblEnrollPaid";
            this.lblEnrollPaid.Size = new System.Drawing.Size(148, 15);
            this.lblEnrollPaid.TabIndex = 7;
            this.lblEnrollPaid.Text = "Học phí thanh toán (VNĐ):";
            // 
            // cboEnrollCourse
            // 
            this.cboEnrollCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnrollCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboEnrollCourse.Location = new System.Drawing.Point(16, 150);
            this.cboEnrollCourse.Name = "cboEnrollCourse";
            this.cboEnrollCourse.Size = new System.Drawing.Size(342, 23);
            this.cboEnrollCourse.TabIndex = 2;
            this.cboEnrollCourse.SelectedIndexChanged += new System.EventHandler(this.cboEnrollCourse_SelectedIndexChanged);
            // 
            // lblEnrollCourse
            // 
            this.lblEnrollCourse.AutoSize = true;
            this.lblEnrollCourse.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollCourse.Location = new System.Drawing.Point(14, 130);
            this.lblEnrollCourse.Name = "lblEnrollCourse";
            this.lblEnrollCourse.Size = new System.Drawing.Size(76, 15);
            this.lblEnrollCourse.TabIndex = 5;
            this.lblEnrollCourse.Text = "Khóa học (*):";
            // 
            // cboEnrollStudent
            // 
            this.cboEnrollStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnrollStudent.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboEnrollStudent.Location = new System.Drawing.Point(16, 98);
            this.cboEnrollStudent.Name = "cboEnrollStudent";
            this.cboEnrollStudent.Size = new System.Drawing.Size(342, 23);
            this.cboEnrollStudent.TabIndex = 1;
            // 
            // lblEnrollStudent
            // 
            this.lblEnrollStudent.AutoSize = true;
            this.lblEnrollStudent.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollStudent.Location = new System.Drawing.Point(14, 78);
            this.lblEnrollStudent.Name = "lblEnrollStudent";
            this.lblEnrollStudent.Size = new System.Drawing.Size(73, 15);
            this.lblEnrollStudent.TabIndex = 3;
            this.lblEnrollStudent.Text = "Học viên (*):";
            // 
            // cboEnrollStatus
            // 
            this.cboEnrollStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnrollStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboEnrollStatus.Items.AddRange(new object[] {
            "Đã đăng ký",
            "Đã hủy"});
            this.cboEnrollStatus.Location = new System.Drawing.Point(148, 46);
            this.cboEnrollStatus.Name = "cboEnrollStatus";
            this.cboEnrollStatus.Size = new System.Drawing.Size(210, 25);
            this.cboEnrollStatus.TabIndex = 0;
            // 
            // lblEnrollStatus
            // 
            this.lblEnrollStatus.AutoSize = true;
            this.lblEnrollStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollStatus.Location = new System.Drawing.Point(146, 26);
            this.lblEnrollStatus.Name = "lblEnrollStatus";
            this.lblEnrollStatus.Size = new System.Drawing.Size(63, 15);
            this.lblEnrollStatus.TabIndex = 2;
            this.lblEnrollStatus.Text = "Trạng thái:";
            // 
            // txtEnrollmentId
            // 
            this.txtEnrollmentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtEnrollmentId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEnrollmentId.Location = new System.Drawing.Point(16, 46);
            this.txtEnrollmentId.Name = "txtEnrollmentId";
            this.txtEnrollmentId.ReadOnly = true;
            this.txtEnrollmentId.Size = new System.Drawing.Size(118, 24);
            this.txtEnrollmentId.TabIndex = 12;
            this.txtEnrollmentId.Text = "Tự động";
            // 
            // lblEnrollId
            // 
            this.lblEnrollId.AutoSize = true;
            this.lblEnrollId.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblEnrollId.Location = new System.Drawing.Point(14, 26);
            this.lblEnrollId.Name = "lblEnrollId";
            this.lblEnrollId.Size = new System.Drawing.Size(72, 15);
            this.lblEnrollId.TabIndex = 0;
            this.lblEnrollId.Text = "Mã đăng ký:";
            // 
            // tabVouchers
            // 
            this.tabVouchers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabVouchers.Controls.Add(this.pnlVoucherMain);
            this.tabVouchers.Controls.Add(this.grpVoucherForm);
            this.tabVouchers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabVouchers.Location = new System.Drawing.Point(4, 38);
            this.tabVouchers.Name = "tabVouchers";
            this.tabVouchers.Padding = new System.Windows.Forms.Padding(10);
            this.tabVouchers.Size = new System.Drawing.Size(1312, 678);
            this.tabVouchers.TabIndex = 4;
            this.tabVouchers.Text = "Học bổng & Ưu đãi";
            // 
            // pnlVoucherMain
            // 
            this.pnlVoucherMain.Controls.Add(this.dgvVouchers);
            this.pnlVoucherMain.Controls.Add(this.pnlVoucherFilter);
            this.pnlVoucherMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVoucherMain.Location = new System.Drawing.Point(385, 10);
            this.pnlVoucherMain.Name = "pnlVoucherMain";
            this.pnlVoucherMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlVoucherMain.Size = new System.Drawing.Size(917, 658);
            this.pnlVoucherMain.TabIndex = 1;
                        // 
            // vouchersBindingSource
            // 
            this.vouchersBindingSource.DataSource = typeof(Course_Registration.Voucher);
// 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvVouchers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVouchers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgvVouchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVouchers.ColumnHeadersHeight = 36;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVouchers.AutoGenerateColumns = false;
            this.dgvVouchers.DataSource = this.vouchersBindingSource;
            this.dgvVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVouchers.EnableHeadersVisualStyles = false;
                        this.dgvVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colVoucher_VoucherID,

                this.colVoucher_VoucherCode,

                this.colVoucher_Description,

                this.colVoucher_ValueDisplay,

                this.colVoucher_MinOrderAmount,

                this.colVoucher_QuotaDisplay,

                this.colVoucher_ExpiryDate,

                this.colVoucher_StatusText
            });

            this.dgvVouchers.Location = new System.Drawing.Point(10, 54);
            this.dgvVouchers.MultiSelect = false;
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersVisible = false;
            this.dgvVouchers.RowTemplate.Height = 32;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(907, 604);
            this.dgvVouchers.TabIndex = 1;
            this.dgvVouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVouchers_CellClick);
            // 
            // colVoucher_VoucherID
            // 
            this.colVoucher_VoucherID.DataPropertyName = "VoucherID";
            this.colVoucher_VoucherID.HeaderText = "Mã số";
            this.colVoucher_VoucherID.Name = "colVoucher_VoucherID";
            this.colVoucher_VoucherID.ReadOnly = true;
            this.colVoucher_VoucherID.FillWeight = 45F;
            // 
            // colVoucher_VoucherCode
            // 
            this.colVoucher_VoucherCode.DataPropertyName = "VoucherCode";
            this.colVoucher_VoucherCode.HeaderText = "Mã ưu đãi";
            this.colVoucher_VoucherCode.Name = "colVoucher_VoucherCode";
            this.colVoucher_VoucherCode.ReadOnly = true;
            this.colVoucher_VoucherCode.FillWeight = 90F;
            // 
            // colVoucher_Description
            // 
            this.colVoucher_Description.DataPropertyName = "Description";
            this.colVoucher_Description.HeaderText = "Mô tả chương trình";
            this.colVoucher_Description.Name = "colVoucher_Description";
            this.colVoucher_Description.ReadOnly = true;
            this.colVoucher_Description.FillWeight = 180F;
            // 
            // colVoucher_ValueDisplay
            // 
            this.colVoucher_ValueDisplay.DataPropertyName = "ValueDisplay";
            this.colVoucher_ValueDisplay.HeaderText = "Mức giảm";
            this.colVoucher_ValueDisplay.Name = "colVoucher_ValueDisplay";
            this.colVoucher_ValueDisplay.ReadOnly = true;
            this.colVoucher_ValueDisplay.FillWeight = 95F;
            // 
            // colVoucher_MinOrderAmount
            // 
            this.colVoucher_MinOrderAmount.DataPropertyName = "MinOrderAmount";
            this.colVoucher_MinOrderAmount.HeaderText = "Đơn tối thiểu";
            this.colVoucher_MinOrderAmount.Name = "colVoucher_MinOrderAmount";
            this.colVoucher_MinOrderAmount.ReadOnly = true;
            this.colVoucher_MinOrderAmount.DefaultCellStyle.Format = "N0";
            this.colVoucher_MinOrderAmount.FillWeight = 85F;
            // 
            // colVoucher_QuotaDisplay
            // 
            this.colVoucher_QuotaDisplay.DataPropertyName = "QuotaDisplay";
            this.colVoucher_QuotaDisplay.HeaderText = "Lượt dùng";
            this.colVoucher_QuotaDisplay.Name = "colVoucher_QuotaDisplay";
            this.colVoucher_QuotaDisplay.ReadOnly = true;
            this.colVoucher_QuotaDisplay.FillWeight = 80F;
            // 
            // colVoucher_ExpiryDate
            // 
            this.colVoucher_ExpiryDate.DataPropertyName = "ExpiryDate";
            this.colVoucher_ExpiryDate.HeaderText = "Hạn dùng";
            this.colVoucher_ExpiryDate.Name = "colVoucher_ExpiryDate";
            this.colVoucher_ExpiryDate.ReadOnly = true;
            this.colVoucher_ExpiryDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colVoucher_ExpiryDate.FillWeight = 75F;
            // 
            // colVoucher_StatusText
            // 
            this.colVoucher_StatusText.DataPropertyName = "StatusText";
            this.colVoucher_StatusText.HeaderText = "Trạng thái";
            this.colVoucher_StatusText.Name = "colVoucher_StatusText";
            this.colVoucher_StatusText.ReadOnly = true;
            this.colVoucher_StatusText.FillWeight = 80F;

// 
            // pnlVoucherFilter
            // 
            this.pnlVoucherFilter.BackColor = System.Drawing.Color.White;
            this.pnlVoucherFilter.Controls.Add(this.btnResetVoucherFilter);
            this.pnlVoucherFilter.Controls.Add(this.cboFilterVoucherStatus);
            this.pnlVoucherFilter.Controls.Add(this.txtSearchVoucher);
            this.pnlVoucherFilter.Controls.Add(this.lblSearchVoucher);
            this.pnlVoucherFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVoucherFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlVoucherFilter.Name = "pnlVoucherFilter";
            this.pnlVoucherFilter.Size = new System.Drawing.Size(907, 54);
            this.pnlVoucherFilter.TabIndex = 0;
            // 
            // btnResetVoucherFilter
            // 
            this.btnResetVoucherFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnResetVoucherFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetVoucherFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetVoucherFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetVoucherFilter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnResetVoucherFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetVoucherFilter.Location = new System.Drawing.Point(542, 12);
            this.btnResetVoucherFilter.Name = "btnResetVoucherFilter";
            this.btnResetVoucherFilter.Size = new System.Drawing.Size(96, 29);
            this.btnResetVoucherFilter.TabIndex = 3;
            this.btnResetVoucherFilter.Text = "Đặt lại";
            this.btnResetVoucherFilter.UseVisualStyleBackColor = false;
            this.btnResetVoucherFilter.Click += new System.EventHandler(this.btnResetVoucherFilter_Click);
            // 
            // cboFilterVoucherStatus
            // 
            this.cboFilterVoucherStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterVoucherStatus.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboFilterVoucherStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang có hiệu lực",
            "Hết hạn / Tạm ngưng"});
            this.cboFilterVoucherStatus.Location = new System.Drawing.Point(344, 14);
            this.cboFilterVoucherStatus.Name = "cboFilterVoucherStatus";
            this.cboFilterVoucherStatus.Size = new System.Drawing.Size(184, 23);
            this.cboFilterVoucherStatus.TabIndex = 2;
            this.cboFilterVoucherStatus.SelectedIndexChanged += new System.EventHandler(this.VoucherFilter_Changed);
            // 
            // txtSearchVoucher
            // 
            this.txtSearchVoucher.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchVoucher.Location = new System.Drawing.Point(82, 14);
            this.txtSearchVoucher.Name = "txtSearchVoucher";
            this.txtSearchVoucher.Size = new System.Drawing.Size(246, 24);
            this.txtSearchVoucher.TabIndex = 1;
            this.txtSearchVoucher.TextChanged += new System.EventHandler(this.VoucherFilter_Changed);
            // 
            // lblSearchVoucher
            // 
            this.lblSearchVoucher.AutoSize = true;
            this.lblSearchVoucher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchVoucher.Location = new System.Drawing.Point(12, 17);
            this.lblSearchVoucher.Name = "lblSearchVoucher";
            this.lblSearchVoucher.Size = new System.Drawing.Size(62, 15);
            this.lblSearchVoucher.TabIndex = 0;
            this.lblSearchVoucher.Text = "Tìm kiếm:";
            // 
            // grpVoucherForm
            // 
            this.grpVoucherForm.BackColor = System.Drawing.Color.White;
            this.grpVoucherForm.Controls.Add(this.btnVoucherClear);
            this.grpVoucherForm.Controls.Add(this.btnVoucherDelete);
            this.grpVoucherForm.Controls.Add(this.btnVoucherUpdate);
            this.grpVoucherForm.Controls.Add(this.btnVoucherAdd);
            this.grpVoucherForm.Controls.Add(this.dtpVoucherExpiry);
            this.grpVoucherForm.Controls.Add(this.lblVoucherExpiry);
            this.grpVoucherForm.Controls.Add(this.txtVoucherUsedCount);
            this.grpVoucherForm.Controls.Add(this.lblVoucherUsed);
            this.grpVoucherForm.Controls.Add(this.nudVoucherUsageLimit);
            this.grpVoucherForm.Controls.Add(this.lblVoucherLimit);
            this.grpVoucherForm.Controls.Add(this.nudVoucherMinOrder);
            this.grpVoucherForm.Controls.Add(this.lblVoucherMinOrder);
            this.grpVoucherForm.Controls.Add(this.nudVoucherMaxDiscount);
            this.grpVoucherForm.Controls.Add(this.lblVoucherMax);
            this.grpVoucherForm.Controls.Add(this.nudVoucherAmount);
            this.grpVoucherForm.Controls.Add(this.lblVoucherAmount);
            this.grpVoucherForm.Controls.Add(this.nudVoucherPercent);
            this.grpVoucherForm.Controls.Add(this.lblVoucherPercent);
            this.grpVoucherForm.Controls.Add(this.txtVoucherDesc);
            this.grpVoucherForm.Controls.Add(this.lblVoucherDesc);
            this.grpVoucherForm.Controls.Add(this.txtVoucherCodeAdmin);
            this.grpVoucherForm.Controls.Add(this.lblVoucherCodeAdmin);
            this.grpVoucherForm.Controls.Add(this.chkVoucherActive);
            this.grpVoucherForm.Controls.Add(this.txtVoucherId);
            this.grpVoucherForm.Controls.Add(this.lblVoucherId);
            this.grpVoucherForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpVoucherForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpVoucherForm.Location = new System.Drawing.Point(10, 10);
            this.grpVoucherForm.Name = "grpVoucherForm";
            this.grpVoucherForm.Size = new System.Drawing.Size(375, 658);
            this.grpVoucherForm.TabIndex = 0;
            this.grpVoucherForm.TabStop = false;
            this.grpVoucherForm.Text = "Thông tin mã học bổng / miễn giảm";
            // 
            // btnVoucherClear
            // 
            this.btnVoucherClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnVoucherClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucherClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnVoucherClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnVoucherClear.Location = new System.Drawing.Point(194, 504);
            this.btnVoucherClear.Name = "btnVoucherClear";
            this.btnVoucherClear.Size = new System.Drawing.Size(164, 38);
            this.btnVoucherClear.TabIndex = 24;
            this.btnVoucherClear.Text = "Làm mới";
            this.btnVoucherClear.UseVisualStyleBackColor = false;
            this.btnVoucherClear.Click += new System.EventHandler(this.btnVoucherClear_Click);
            // 
            // btnVoucherDelete
            // 
            this.btnVoucherDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVoucherDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucherDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnVoucherDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVoucherDelete.Location = new System.Drawing.Point(16, 504);
            this.btnVoucherDelete.Name = "btnVoucherDelete";
            this.btnVoucherDelete.Size = new System.Drawing.Size(166, 38);
            this.btnVoucherDelete.TabIndex = 23;
            this.btnVoucherDelete.Text = "Xóa";
            this.btnVoucherDelete.UseVisualStyleBackColor = false;
            this.btnVoucherDelete.Click += new System.EventHandler(this.btnVoucherDelete_Click);
            // 
            // btnVoucherUpdate
            // 
            this.btnVoucherUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnVoucherUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucherUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnVoucherUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnVoucherUpdate.Location = new System.Drawing.Point(194, 456);
            this.btnVoucherUpdate.Name = "btnVoucherUpdate";
            this.btnVoucherUpdate.Size = new System.Drawing.Size(164, 38);
            this.btnVoucherUpdate.TabIndex = 22;
            this.btnVoucherUpdate.Text = "Cập nhật";
            this.btnVoucherUpdate.UseVisualStyleBackColor = false;
            this.btnVoucherUpdate.Click += new System.EventHandler(this.btnVoucherUpdate_Click);
            // 
            // btnVoucherAdd
            // 
            this.btnVoucherAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnVoucherAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucherAdd.FlatAppearance.BorderSize = 0;
            this.btnVoucherAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherAdd.ForeColor = System.Drawing.Color.White;
            this.btnVoucherAdd.Location = new System.Drawing.Point(16, 456);
            this.btnVoucherAdd.Name = "btnVoucherAdd";
            this.btnVoucherAdd.Size = new System.Drawing.Size(166, 38);
            this.btnVoucherAdd.TabIndex = 21;
            this.btnVoucherAdd.Text = "Thêm mới";
            this.btnVoucherAdd.UseVisualStyleBackColor = false;
            this.btnVoucherAdd.Click += new System.EventHandler(this.btnVoucherAdd_Click);
            // 
            // dtpVoucherExpiry
            // 
            this.dtpVoucherExpiry.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.dtpVoucherExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVoucherExpiry.Location = new System.Drawing.Point(16, 408);
            this.dtpVoucherExpiry.Name = "dtpVoucherExpiry";
            this.dtpVoucherExpiry.Size = new System.Drawing.Size(342, 24);
            this.dtpVoucherExpiry.TabIndex = 20;
            // 
            // lblVoucherExpiry
            // 
            this.lblVoucherExpiry.AutoSize = true;
            this.lblVoucherExpiry.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherExpiry.Location = new System.Drawing.Point(14, 388);
            this.lblVoucherExpiry.Name = "lblVoucherExpiry";
            this.lblVoucherExpiry.Size = new System.Drawing.Size(131, 15);
            this.lblVoucherExpiry.TabIndex = 19;
            this.lblVoucherExpiry.Text = "Hạn áp dụng đến ngày:";
            // 
            // txtVoucherUsedCount
            // 
            this.txtVoucherUsedCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtVoucherUsedCount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtVoucherUsedCount.Location = new System.Drawing.Point(196, 352);
            this.txtVoucherUsedCount.Name = "txtVoucherUsedCount";
            this.txtVoucherUsedCount.ReadOnly = true;
            this.txtVoucherUsedCount.Size = new System.Drawing.Size(162, 24);
            this.txtVoucherUsedCount.TabIndex = 18;
            this.txtVoucherUsedCount.Text = "0";
            // 
            // lblVoucherUsed
            // 
            this.lblVoucherUsed.AutoSize = true;
            this.lblVoucherUsed.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherUsed.Location = new System.Drawing.Point(194, 332);
            this.lblVoucherUsed.Name = "lblVoucherUsed";
            this.lblVoucherUsed.Size = new System.Drawing.Size(110, 15);
            this.lblVoucherUsed.TabIndex = 17;
            this.lblVoucherUsed.Text = "Số suất đã sử dụng:";
            // 
            // nudVoucherUsageLimit
            // 
            this.nudVoucherUsageLimit.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudVoucherUsageLimit.Location = new System.Drawing.Point(16, 352);
            this.nudVoucherUsageLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudVoucherUsageLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVoucherUsageLimit.Name = "nudVoucherUsageLimit";
            this.nudVoucherUsageLimit.Size = new System.Drawing.Size(162, 24);
            this.nudVoucherUsageLimit.TabIndex = 16;
            this.nudVoucherUsageLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblVoucherLimit
            // 
            this.lblVoucherLimit.AutoSize = true;
            this.lblVoucherLimit.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherLimit.Location = new System.Drawing.Point(14, 332);
            this.lblVoucherLimit.Name = "lblVoucherLimit";
            this.lblVoucherLimit.Size = new System.Drawing.Size(127, 15);
            this.lblVoucherLimit.TabIndex = 15;
            this.lblVoucherLimit.Text = "Tổng số suất cấp phát:";
            // 
            // nudVoucherMinOrder
            // 
            this.nudVoucherMinOrder.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudVoucherMinOrder.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVoucherMinOrder.Location = new System.Drawing.Point(196, 296);
            this.nudVoucherMinOrder.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nudVoucherMinOrder.Name = "nudVoucherMinOrder";
            this.nudVoucherMinOrder.Size = new System.Drawing.Size(162, 24);
            this.nudVoucherMinOrder.TabIndex = 14;
            this.nudVoucherMinOrder.ThousandsSeparator = true;
            // 
            // lblVoucherMinOrder
            // 
            this.lblVoucherMinOrder.AutoSize = true;
            this.lblVoucherMinOrder.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherMinOrder.Location = new System.Drawing.Point(194, 276);
            this.lblVoucherMinOrder.Name = "lblVoucherMinOrder";
            this.lblVoucherMinOrder.Size = new System.Drawing.Size(134, 15);
            this.lblVoucherMinOrder.TabIndex = 13;
            this.lblVoucherMinOrder.Text = "Học phí tối thiểu (VNĐ):";
            // 
            // nudVoucherMaxDiscount
            // 
            this.nudVoucherMaxDiscount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudVoucherMaxDiscount.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudVoucherMaxDiscount.Location = new System.Drawing.Point(16, 296);
            this.nudVoucherMaxDiscount.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nudVoucherMaxDiscount.Name = "nudVoucherMaxDiscount";
            this.nudVoucherMaxDiscount.Size = new System.Drawing.Size(162, 24);
            this.nudVoucherMaxDiscount.TabIndex = 12;
            this.nudVoucherMaxDiscount.ThousandsSeparator = true;
            // 
            // lblVoucherMax
            // 
            this.lblVoucherMax.AutoSize = true;
            this.lblVoucherMax.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherMax.Location = new System.Drawing.Point(14, 276);
            this.lblVoucherMax.Name = "lblVoucherMax";
            this.lblVoucherMax.Size = new System.Drawing.Size(149, 15);
            this.lblVoucherMax.TabIndex = 11;
            this.lblVoucherMax.Text = "Giảm tối đa (VNĐ, 0=KGH):";
            // 
            // nudVoucherAmount
            // 
            this.nudVoucherAmount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudVoucherAmount.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudVoucherAmount.Location = new System.Drawing.Point(196, 240);
            this.nudVoucherAmount.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nudVoucherAmount.Name = "nudVoucherAmount";
            this.nudVoucherAmount.Size = new System.Drawing.Size(162, 24);
            this.nudVoucherAmount.TabIndex = 10;
            this.nudVoucherAmount.ThousandsSeparator = true;
            // 
            // lblVoucherAmount
            // 
            this.lblVoucherAmount.AutoSize = true;
            this.lblVoucherAmount.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherAmount.Location = new System.Drawing.Point(194, 220);
            this.lblVoucherAmount.Name = "lblVoucherAmount";
            this.lblVoucherAmount.Size = new System.Drawing.Size(146, 15);
            this.lblVoucherAmount.TabIndex = 9;
            this.lblVoucherAmount.Text = "Hoặc giảm cố định (VNĐ):";
            // 
            // nudVoucherPercent
            // 
            this.nudVoucherPercent.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nudVoucherPercent.Location = new System.Drawing.Point(16, 240);
            this.nudVoucherPercent.Name = "nudVoucherPercent";
            this.nudVoucherPercent.Size = new System.Drawing.Size(162, 24);
            this.nudVoucherPercent.TabIndex = 8;
            // 
            // lblVoucherPercent
            // 
            this.lblVoucherPercent.AutoSize = true;
            this.lblVoucherPercent.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherPercent.Location = new System.Drawing.Point(14, 220);
            this.lblVoucherPercent.Name = "lblVoucherPercent";
            this.lblVoucherPercent.Size = new System.Drawing.Size(112, 15);
            this.lblVoucherPercent.TabIndex = 7;
            this.lblVoucherPercent.Text = "Mức giảm theo (%):";
            // 
            // txtVoucherDesc
            // 
            this.txtVoucherDesc.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtVoucherDesc.Location = new System.Drawing.Point(16, 156);
            this.txtVoucherDesc.MaxLength = 200;
            this.txtVoucherDesc.Multiline = true;
            this.txtVoucherDesc.Name = "txtVoucherDesc";
            this.txtVoucherDesc.Size = new System.Drawing.Size(342, 52);
            this.txtVoucherDesc.TabIndex = 6;
            // 
            // lblVoucherDesc
            // 
            this.lblVoucherDesc.AutoSize = true;
            this.lblVoucherDesc.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherDesc.Location = new System.Drawing.Point(14, 136);
            this.lblVoucherDesc.Name = "lblVoucherDesc";
            this.lblVoucherDesc.Size = new System.Drawing.Size(148, 15);
            this.lblVoucherDesc.TabIndex = 5;
            this.lblVoucherDesc.Text = "Nội dung chương trình (*):";
            // 
            // txtVoucherCodeAdmin
            // 
            this.txtVoucherCodeAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVoucherCodeAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtVoucherCodeAdmin.Location = new System.Drawing.Point(16, 102);
            this.txtVoucherCodeAdmin.MaxLength = 30;
            this.txtVoucherCodeAdmin.Name = "txtVoucherCodeAdmin";
            this.txtVoucherCodeAdmin.Size = new System.Drawing.Size(342, 24);
            this.txtVoucherCodeAdmin.TabIndex = 4;
            // 
            // lblVoucherCodeAdmin
            // 
            this.lblVoucherCodeAdmin.AutoSize = true;
            this.lblVoucherCodeAdmin.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherCodeAdmin.Location = new System.Drawing.Point(14, 82);
            this.lblVoucherCodeAdmin.Name = "lblVoucherCodeAdmin";
            this.lblVoucherCodeAdmin.Size = new System.Drawing.Size(142, 15);
            this.lblVoucherCodeAdmin.TabIndex = 3;
            this.lblVoucherCodeAdmin.Text = "Mã học bổng / Ưu đãi (*):";
            // 
            // chkVoucherActive
            // 
            this.chkVoucherActive.AutoSize = true;
            this.chkVoucherActive.Checked = true;
            this.chkVoucherActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVoucherActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkVoucherActive.Location = new System.Drawing.Point(156, 51);
            this.chkVoucherActive.Name = "chkVoucherActive";
            this.chkVoucherActive.Size = new System.Drawing.Size(125, 19);
            this.chkVoucherActive.TabIndex = 2;
            this.chkVoucherActive.Text = "Cho phép áp dụng";
            this.chkVoucherActive.UseVisualStyleBackColor = true;
            // 
            // txtVoucherId
            // 
            this.txtVoucherId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtVoucherId.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtVoucherId.Location = new System.Drawing.Point(16, 48);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.ReadOnly = true;
            this.txtVoucherId.Size = new System.Drawing.Size(118, 24);
            this.txtVoucherId.TabIndex = 1;
            this.txtVoucherId.Text = "Tự động";
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.AutoSize = true;
            this.lblVoucherId.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblVoucherId.Location = new System.Drawing.Point(14, 28);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(42, 15);
            this.lblVoucherId.TabIndex = 0;
            this.lblVoucherId.Text = "Mã số:";
            // 
            // tabAdminReviews
            // 
            this.tabAdminReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabAdminReviews.Controls.Add(this.dgvAdminReviews);
            this.tabAdminReviews.Controls.Add(this.pnlAdminReviewFilter);
            this.tabAdminReviews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabAdminReviews.Location = new System.Drawing.Point(4, 38);
            this.tabAdminReviews.Name = "tabAdminReviews";
            this.tabAdminReviews.Padding = new System.Windows.Forms.Padding(10);
            this.tabAdminReviews.Size = new System.Drawing.Size(1312, 678);
            this.tabAdminReviews.TabIndex = 5;
            this.tabAdminReviews.Text = "Đánh giá học viên";
                        // 
            // adminReviewsBindingSource
            // 
            this.adminReviewsBindingSource.DataSource = typeof(Course_Registration.CourseReview);
// 
            // dgvAdminReviews
            // 
            this.dgvAdminReviews.AllowUserToAddRows = false;
            this.dgvAdminReviews.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvAdminReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAdminReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminReviews.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.dgvAdminReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAdminReviews.ColumnHeadersHeight = 36;
            this.dgvAdminReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdminReviews.AutoGenerateColumns = false;
            this.dgvAdminReviews.DataSource = this.adminReviewsBindingSource;
            this.dgvAdminReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminReviews.EnableHeadersVisualStyles = false;
                        this.dgvAdminReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRev_ReviewID,

                this.colRev_CourseCode,

                this.colRev_CourseName,

                this.colRev_StudentName,

                this.colRev_Username,

                this.colRev_StarsDisplay,

                this.colRev_Comment,

                this.colRev_CreatedAt
            });

            this.dgvAdminReviews.Location = new System.Drawing.Point(10, 66);
            this.dgvAdminReviews.MultiSelect = false;
            this.dgvAdminReviews.Name = "dgvAdminReviews";
            this.dgvAdminReviews.ReadOnly = true;
            this.dgvAdminReviews.RowHeadersVisible = false;
            this.dgvAdminReviews.RowTemplate.Height = 34;
            this.dgvAdminReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminReviews.Size = new System.Drawing.Size(1292, 602);
            this.dgvAdminReviews.TabIndex = 1;
            // 
            // colRev_ReviewID
            // 
            this.colRev_ReviewID.DataPropertyName = "ReviewID";
            this.colRev_ReviewID.HeaderText = "Mã ID";
            this.colRev_ReviewID.Name = "colRev_ReviewID";
            this.colRev_ReviewID.ReadOnly = true;
            this.colRev_ReviewID.FillWeight = 50F;
            // 
            // colRev_CourseCode
            // 
            this.colRev_CourseCode.DataPropertyName = "CourseCode";
            this.colRev_CourseCode.HeaderText = "Mã khóa học";
            this.colRev_CourseCode.Name = "colRev_CourseCode";
            this.colRev_CourseCode.ReadOnly = true;
            this.colRev_CourseCode.FillWeight = 62F;
            // 
            // colRev_CourseName
            // 
            this.colRev_CourseName.DataPropertyName = "CourseName";
            this.colRev_CourseName.HeaderText = "Tên khóa học";
            this.colRev_CourseName.Name = "colRev_CourseName";
            this.colRev_CourseName.ReadOnly = true;
            this.colRev_CourseName.FillWeight = 155F;
            // 
            // colRev_StudentName
            // 
            this.colRev_StudentName.DataPropertyName = "StudentName";
            this.colRev_StudentName.HeaderText = "Họ tên học viên";
            this.colRev_StudentName.Name = "colRev_StudentName";
            this.colRev_StudentName.ReadOnly = true;
            this.colRev_StudentName.FillWeight = 115F;
            // 
            // colRev_Username
            // 
            this.colRev_Username.DataPropertyName = "Username";
            this.colRev_Username.HeaderText = "Tài khoản";
            this.colRev_Username.Name = "colRev_Username";
            this.colRev_Username.ReadOnly = true;
            this.colRev_Username.FillWeight = 82F;
            // 
            // colRev_StarsDisplay
            // 
            this.colRev_StarsDisplay.DataPropertyName = "StarsDisplay";
            this.colRev_StarsDisplay.HeaderText = "Đánh giá sao";
            this.colRev_StarsDisplay.Name = "colRev_StarsDisplay";
            this.colRev_StarsDisplay.ReadOnly = true;
            this.colRev_StarsDisplay.FillWeight = 65F;
            // 
            // colRev_Comment
            // 
            this.colRev_Comment.DataPropertyName = "Comment";
            this.colRev_Comment.HeaderText = "Nội dung phản hồi";
            this.colRev_Comment.Name = "colRev_Comment";
            this.colRev_Comment.ReadOnly = true;
            this.colRev_Comment.FillWeight = 225F;
            // 
            // colRev_CreatedAt
            // 
            this.colRev_CreatedAt.DataPropertyName = "CreatedAt";
            this.colRev_CreatedAt.HeaderText = "Ngày gửi";
            this.colRev_CreatedAt.Name = "colRev_CreatedAt";
            this.colRev_CreatedAt.ReadOnly = true;
            this.colRev_CreatedAt.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colRev_CreatedAt.FillWeight = 95F;

// 
            // pnlAdminReviewFilter
            // 
            this.pnlAdminReviewFilter.BackColor = System.Drawing.Color.White;
            this.pnlAdminReviewFilter.Controls.Add(this.btnAdminDeleteReview);
            this.pnlAdminReviewFilter.Controls.Add(this.btnExportReviews);
            this.pnlAdminReviewFilter.Controls.Add(this.lblAdminReviewStats);
            this.pnlAdminReviewFilter.Controls.Add(this.cboAdminReviewStars);
            this.pnlAdminReviewFilter.Controls.Add(this.cboAdminReviewCourse);
            this.pnlAdminReviewFilter.Controls.Add(this.lblAdminRevFilter);
            this.pnlAdminReviewFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminReviewFilter.Location = new System.Drawing.Point(10, 10);
            this.pnlAdminReviewFilter.Name = "pnlAdminReviewFilter";
            this.pnlAdminReviewFilter.Size = new System.Drawing.Size(1292, 56);
            this.pnlAdminReviewFilter.TabIndex = 0;
            // 
            // btnAdminDeleteReview
            // 
            this.btnAdminDeleteReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminDeleteReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminDeleteReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminDeleteReview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnAdminDeleteReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDeleteReview.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnAdminDeleteReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAdminDeleteReview.Location = new System.Drawing.Point(1100, 12);
            this.btnAdminDeleteReview.Name = "btnAdminDeleteReview";
            this.btnAdminDeleteReview.Size = new System.Drawing.Size(178, 32);
            this.btnAdminDeleteReview.TabIndex = 5;
            this.btnAdminDeleteReview.Text = "Xóa đánh giá đã chọn";
            this.btnAdminDeleteReview.UseVisualStyleBackColor = false;
            this.btnAdminDeleteReview.Click += new System.EventHandler(this.btnAdminDeleteReview_Click);
            // 
            // btnExportReviews
            // 
            this.btnExportReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportReviews.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReviews.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportReviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportReviews.Location = new System.Drawing.Point(978, 12);
            this.btnExportReviews.Name = "btnExportReviews";
            this.btnExportReviews.Size = new System.Drawing.Size(112, 32);
            this.btnExportReviews.TabIndex = 4;
            this.btnExportReviews.Text = "Xuất Excel";
            this.btnExportReviews.UseVisualStyleBackColor = false;
            this.btnExportReviews.Click += new System.EventHandler(this.btnExportReviews_Click);
            // 
            // lblAdminReviewStats
            // 
            this.lblAdminReviewStats.AutoSize = true;
            this.lblAdminReviewStats.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblAdminReviewStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblAdminReviewStats.Location = new System.Drawing.Point(618, 19);
            this.lblAdminReviewStats.Name = "lblAdminReviewStats";
            this.lblAdminReviewStats.Size = new System.Drawing.Size(134, 17);
            this.lblAdminReviewStats.TabIndex = 3;
            this.lblAdminReviewStats.Text = "Điểm trung bình: ---";
            // 
            // cboAdminReviewStars
            // 
            this.cboAdminReviewStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdminReviewStars.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboAdminReviewStars.Items.AddRange(new object[] {
            "Tất cả mức sao",
            "5 sao",
            "4 sao",
            "3 sao",
            "2 sao",
            "1 sao"});
            this.cboAdminReviewStars.Location = new System.Drawing.Point(454, 16);
            this.cboAdminReviewStars.Name = "cboAdminReviewStars";
            this.cboAdminReviewStars.Size = new System.Drawing.Size(148, 23);
            this.cboAdminReviewStars.TabIndex = 2;
            this.cboAdminReviewStars.SelectedIndexChanged += new System.EventHandler(this.AdminReviewFilter_Changed);
            // 
            // cboAdminReviewCourse
            // 
            this.cboAdminReviewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdminReviewCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cboAdminReviewCourse.Location = new System.Drawing.Point(132, 16);
            this.cboAdminReviewCourse.Name = "cboAdminReviewCourse";
            this.cboAdminReviewCourse.Size = new System.Drawing.Size(310, 23);
            this.cboAdminReviewCourse.TabIndex = 1;
            this.cboAdminReviewCourse.SelectedIndexChanged += new System.EventHandler(this.AdminReviewFilter_Changed);
            // 
            // lblAdminRevFilter
            // 
            this.lblAdminRevFilter.AutoSize = true;
            this.lblAdminRevFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdminRevFilter.Location = new System.Drawing.Point(14, 19);
            this.lblAdminRevFilter.Name = "lblAdminRevFilter";
            this.lblAdminRevFilter.Size = new System.Drawing.Size(111, 15);
            this.lblAdminRevFilter.TabIndex = 0;
            this.lblAdminRevFilter.Text = "Lọc theo khóa học:";
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabReports.Controls.Add(this.splitReports);
            this.tabReports.Controls.Add(this.splitCharts);
            this.tabReports.Controls.Add(this.pnlReportFilter);
            this.tabReports.Controls.Add(this.pnlKpiCards);
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabReports.Location = new System.Drawing.Point(4, 38);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(10);
            this.tabReports.Size = new System.Drawing.Size(1312, 678);
            this.tabReports.TabIndex = 6;
            this.tabReports.Text = "Thống kê & Biểu đồ";
            // 
            // splitReports
            // 
            this.splitReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitReports.Location = new System.Drawing.Point(10, 384);
            this.splitReports.Name = "splitReports";
            // 
            // splitReports.Panel1
            // 
            this.splitReports.Panel1.Controls.Add(this.grpRevenueByCourse);
            // 
            // splitReports.Panel2
            // 
            this.splitReports.Panel2.Controls.Add(this.grpAllTransactions);
            this.splitReports.Size = new System.Drawing.Size(1292, 284);
            this.splitReports.SplitterDistance = 665;
            this.splitReports.TabIndex = 3;
            // 
            // grpRevenueByCourse
            // 
            this.grpRevenueByCourse.BackColor = System.Drawing.Color.White;
            this.grpRevenueByCourse.Controls.Add(this.dgvCourseRevenue);
            this.grpRevenueByCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRevenueByCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpRevenueByCourse.Location = new System.Drawing.Point(0, 0);
            this.grpRevenueByCourse.Name = "grpRevenueByCourse";
            this.grpRevenueByCourse.Padding = new System.Windows.Forms.Padding(8);
            this.grpRevenueByCourse.Size = new System.Drawing.Size(665, 284);
            this.grpRevenueByCourse.TabIndex = 0;
            this.grpRevenueByCourse.TabStop = false;
            this.grpRevenueByCourse.Text = "Doanh thu và sĩ số theo từng khóa học";
                        // 
            // courseRevenueBindingSource
            // 
            this.courseRevenueBindingSource.DataSource = typeof(Course_Registration.CourseRevenueReportData);
// 
            // dgvCourseRevenue
            // 
            this.dgvCourseRevenue.AllowUserToAddRows = false;
            this.dgvCourseRevenue.AllowUserToDeleteRows = false;
            this.dgvCourseRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseRevenue.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.dgvCourseRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCourseRevenue.ColumnHeadersHeight = 34;
            this.dgvCourseRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourseRevenue.AutoGenerateColumns = false;
            this.dgvCourseRevenue.DataSource = this.courseRevenueBindingSource;
            this.dgvCourseRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourseRevenue.EnableHeadersVisualStyles = false;
            this.dgvCourseRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
                        this.dgvCourseRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStatRev_CourseCode,

                this.colStatRev_CourseName,

                this.colStatRev_CategoryName,

                this.colStatRev_Price,

                this.colStatRev_SoldSlots,

                this.colStatRev_FillPercent,

                this.colStatRev_Revenue
            });

            this.dgvCourseRevenue.Location = new System.Drawing.Point(8, 24);
            this.dgvCourseRevenue.MultiSelect = false;
            this.dgvCourseRevenue.Name = "dgvCourseRevenue";
            this.dgvCourseRevenue.ReadOnly = true;
            this.dgvCourseRevenue.RowHeadersVisible = false;
            this.dgvCourseRevenue.RowTemplate.Height = 28;
            this.dgvCourseRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseRevenue.Size = new System.Drawing.Size(649, 252);
            this.dgvCourseRevenue.TabIndex = 0;
            // 
            // colStatRev_CourseCode
            // 
            this.colStatRev_CourseCode.DataPropertyName = "CourseCode";
            this.colStatRev_CourseCode.HeaderText = "Mã khóa học";
            this.colStatRev_CourseCode.Name = "colStatRev_CourseCode";
            this.colStatRev_CourseCode.ReadOnly = true;
            this.colStatRev_CourseCode.FillWeight = 62F;
            // 
            // colStatRev_CourseName
            // 
            this.colStatRev_CourseName.DataPropertyName = "CourseName";
            this.colStatRev_CourseName.HeaderText = "Tên khóa học";
            this.colStatRev_CourseName.Name = "colStatRev_CourseName";
            this.colStatRev_CourseName.ReadOnly = true;
            this.colStatRev_CourseName.FillWeight = 165F;
            // 
            // colStatRev_CategoryName
            // 
            this.colStatRev_CategoryName.DataPropertyName = "CategoryName";
            this.colStatRev_CategoryName.HeaderText = "Danh mục";
            this.colStatRev_CategoryName.Name = "colStatRev_CategoryName";
            this.colStatRev_CategoryName.ReadOnly = true;
            this.colStatRev_CategoryName.FillWeight = 110F;
            // 
            // colStatRev_Price
            // 
            this.colStatRev_Price.DataPropertyName = "Price";
            this.colStatRev_Price.HeaderText = "Học phí gốc (VNĐ)";
            this.colStatRev_Price.Name = "colStatRev_Price";
            this.colStatRev_Price.ReadOnly = true;
            this.colStatRev_Price.DefaultCellStyle.Format = "N0";
            this.colStatRev_Price.FillWeight = 82F;
            // 
            // colStatRev_SoldSlots
            // 
            this.colStatRev_SoldSlots.DataPropertyName = "SoldSlots";
            this.colStatRev_SoldSlots.HeaderText = "Đã đăng ký";
            this.colStatRev_SoldSlots.Name = "colStatRev_SoldSlots";
            this.colStatRev_SoldSlots.ReadOnly = true;
            this.colStatRev_SoldSlots.FillWeight = 65F;
            // 
            // colStatRev_FillPercent
            // 
            this.colStatRev_FillPercent.DataPropertyName = "FillPercent";
            this.colStatRev_FillPercent.HeaderText = "Tỷ lệ lấp đầy (%)";
            this.colStatRev_FillPercent.Name = "colStatRev_FillPercent";
            this.colStatRev_FillPercent.ReadOnly = true;
            this.colStatRev_FillPercent.FillWeight = 65F;
            // 
            // colStatRev_Revenue
            // 
            this.colStatRev_Revenue.DataPropertyName = "Revenue";
            this.colStatRev_Revenue.HeaderText = "Thực thu (VNĐ)";
            this.colStatRev_Revenue.Name = "colStatRev_Revenue";
            this.colStatRev_Revenue.ReadOnly = true;
            this.colStatRev_Revenue.DefaultCellStyle.Format = "N0";
            this.colStatRev_Revenue.FillWeight = 100F;

// 
            // grpAllTransactions
            // 
            this.grpAllTransactions.BackColor = System.Drawing.Color.White;
            this.grpAllTransactions.Controls.Add(this.dgvSystemTransactions);
            this.grpAllTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllTransactions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAllTransactions.Location = new System.Drawing.Point(0, 0);
            this.grpAllTransactions.Name = "grpAllTransactions";
            this.grpAllTransactions.Padding = new System.Windows.Forms.Padding(8);
            this.grpAllTransactions.Size = new System.Drawing.Size(623, 284);
            this.grpAllTransactions.TabIndex = 0;
            this.grpAllTransactions.TabStop = false;
            this.grpAllTransactions.Text = "Lịch sử giao dịch toàn hệ thống";
                        // 
            // systemTransactionsBindingSource
            // 
            this.systemTransactionsBindingSource.DataSource = typeof(Course_Registration.WalletTransaction);
// 
            // dgvSystemTransactions
            // 
            this.dgvSystemTransactions.AllowUserToAddRows = false;
            this.dgvSystemTransactions.AllowUserToDeleteRows = false;
            this.dgvSystemTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystemTransactions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.dgvSystemTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSystemTransactions.ColumnHeadersHeight = 34;
            this.dgvSystemTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSystemTransactions.AutoGenerateColumns = false;
            this.dgvSystemTransactions.DataSource = this.systemTransactionsBindingSource;
            this.dgvSystemTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSystemTransactions.EnableHeadersVisualStyles = false;
            this.dgvSystemTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
                        this.dgvSystemTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTx_TransactionID,

                this.colTx_FullName,

                this.colTx_Username,

                this.colTx_TypeDisplay,

                this.colTx_Amount,

                this.colTx_Description,

                this.colTx_CreatedAt
            });

            this.dgvSystemTransactions.Location = new System.Drawing.Point(8, 24);
            this.dgvSystemTransactions.MultiSelect = false;
            this.dgvSystemTransactions.Name = "dgvSystemTransactions";
            this.dgvSystemTransactions.ReadOnly = true;
            this.dgvSystemTransactions.RowHeadersVisible = false;
            this.dgvSystemTransactions.RowTemplate.Height = 28;
            this.dgvSystemTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemTransactions.Size = new System.Drawing.Size(607, 252);
            this.dgvSystemTransactions.TabIndex = 0;
            // 
            // colTx_TransactionID
            // 
            this.colTx_TransactionID.DataPropertyName = "TransactionID";
            this.colTx_TransactionID.HeaderText = "Mã giao dịch";
            this.colTx_TransactionID.Name = "colTx_TransactionID";
            this.colTx_TransactionID.ReadOnly = true;
            this.colTx_TransactionID.FillWeight = 62F;
            // 
            // colTx_FullName
            // 
            this.colTx_FullName.DataPropertyName = "FullName";
            this.colTx_FullName.HeaderText = "Họ và tên";
            this.colTx_FullName.Name = "colTx_FullName";
            this.colTx_FullName.ReadOnly = true;
            this.colTx_FullName.FillWeight = 115F;
            // 
            // colTx_Username
            // 
            this.colTx_Username.DataPropertyName = "Username";
            this.colTx_Username.HeaderText = "Tên đăng nhập";
            this.colTx_Username.Name = "colTx_Username";
            this.colTx_Username.ReadOnly = true;
            this.colTx_Username.FillWeight = 85F;
            // 
            // colTx_TypeDisplay
            // 
            this.colTx_TypeDisplay.DataPropertyName = "TypeDisplay";
            this.colTx_TypeDisplay.HeaderText = "Loại giao dịch";
            this.colTx_TypeDisplay.Name = "colTx_TypeDisplay";
            this.colTx_TypeDisplay.ReadOnly = true;
            this.colTx_TypeDisplay.FillWeight = 95F;
            // 
            // colTx_Amount
            // 
            this.colTx_Amount.DataPropertyName = "Amount";
            this.colTx_Amount.HeaderText = "Số tiền (VNĐ)";
            this.colTx_Amount.Name = "colTx_Amount";
            this.colTx_Amount.ReadOnly = true;
            this.colTx_Amount.DefaultCellStyle.Format = "+#,##0;-#,##0;0";
            this.colTx_Amount.FillWeight = 95F;
            // 
            // colTx_Description
            // 
            this.colTx_Description.DataPropertyName = "Description";
            this.colTx_Description.HeaderText = "Nội dung giao dịch";
            this.colTx_Description.Name = "colTx_Description";
            this.colTx_Description.ReadOnly = true;
            this.colTx_Description.FillWeight = 215F;
            // 
            // colTx_CreatedAt
            // 
            this.colTx_CreatedAt.DataPropertyName = "CreatedAt";
            this.colTx_CreatedAt.HeaderText = "Thời gian";
            this.colTx_CreatedAt.Name = "colTx_CreatedAt";
            this.colTx_CreatedAt.ReadOnly = true;
            this.colTx_CreatedAt.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colTx_CreatedAt.FillWeight = 100F;

// 
            // splitCharts
            // 
            this.splitCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitCharts.Location = new System.Drawing.Point(10, 160);
            this.splitCharts.Name = "splitCharts";
            // 
            // splitCharts.Panel1
            // 
            this.splitCharts.Panel1.Controls.Add(this.grpChartRevenue);
            // 
            // splitCharts.Panel2
            // 
            this.splitCharts.Panel2.Controls.Add(this.grpChartCategory);
            this.splitCharts.Size = new System.Drawing.Size(1292, 224);
            this.splitCharts.SplitterDistance = 740;
            this.splitCharts.TabIndex = 2;
            // 
            // grpChartRevenue
            // 
            this.grpChartRevenue.BackColor = System.Drawing.Color.White;
            this.grpChartRevenue.Controls.Add(this.chartCourseRevenue);
            this.grpChartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChartRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpChartRevenue.Location = new System.Drawing.Point(0, 0);
            this.grpChartRevenue.Name = "grpChartRevenue";
            this.grpChartRevenue.Padding = new System.Windows.Forms.Padding(6);
            this.grpChartRevenue.Size = new System.Drawing.Size(740, 224);
            this.grpChartRevenue.TabIndex = 0;
            this.grpChartRevenue.TabStop = false;
            this.grpChartRevenue.Text = "Biểu đồ doanh thu thực thu theo từng khóa học (VNĐ)";
            // 
            // chartCourseRevenue
            // 
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "MainArea";
            this.chartCourseRevenue.ChartAreas.Add(chartArea1);
            this.chartCourseRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "MainLegend";
            this.chartCourseRevenue.Legends.Add(legend1);
            this.chartCourseRevenue.Location = new System.Drawing.Point(6, 22);
            this.chartCourseRevenue.Name = "chartCourseRevenue";
            series1.ChartArea = "MainArea";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            series1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "N0";
            series1.Legend = "MainLegend";
            series1.Name = "DoanhThu";
            this.chartCourseRevenue.Series.Add(series1);
            this.chartCourseRevenue.Size = new System.Drawing.Size(728, 196);
            this.chartCourseRevenue.TabIndex = 0;
            // 
            // grpChartCategory
            // 
            this.grpChartCategory.BackColor = System.Drawing.Color.White;
            this.grpChartCategory.Controls.Add(this.chartCategoryShare);
            this.grpChartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChartCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpChartCategory.Location = new System.Drawing.Point(0, 0);
            this.grpChartCategory.Name = "grpChartCategory";
            this.grpChartCategory.Padding = new System.Windows.Forms.Padding(6);
            this.grpChartCategory.Size = new System.Drawing.Size(548, 224);
            this.grpChartCategory.TabIndex = 0;
            this.grpChartCategory.TabStop = false;
            this.grpChartCategory.Text = "Cơ cấu doanh thu theo danh mục đào tạo";
            // 
            // chartCategoryShare
            // 
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "PieArea";
            this.chartCategoryShare.ChartAreas.Add(chartArea2);
            this.chartCategoryShare.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "PieLegend";
            this.chartCategoryShare.Legends.Add(legend2);
            this.chartCategoryShare.Location = new System.Drawing.Point(6, 22);
            this.chartCategoryShare.Name = "chartCategoryShare";
            series2.ChartArea = "PieArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            series2.Legend = "PieLegend";
            series2.Name = "TyTrong";
            this.chartCategoryShare.Series.Add(series2);
            this.chartCategoryShare.Size = new System.Drawing.Size(536, 196);
            this.chartCategoryShare.TabIndex = 0;
            // 
            // pnlReportFilter
            // 
            this.pnlReportFilter.BackColor = System.Drawing.Color.White;
            this.pnlReportFilter.Controls.Add(this.btnExportTransactions);
            this.pnlReportFilter.Controls.Add(this.btnRdlcRevenueReport);
            this.pnlReportFilter.Controls.Add(this.btnExportRevenue);
            this.pnlReportFilter.Controls.Add(this.btnRefreshAllReport);
            this.pnlReportFilter.Controls.Add(this.btnRunReport);
            this.pnlReportFilter.Controls.Add(this.dtpReportTo);
            this.pnlReportFilter.Controls.Add(this.lblReportTo);
            this.pnlReportFilter.Controls.Add(this.dtpReportFrom);
            this.pnlReportFilter.Controls.Add(this.chkFilterByDate);
            this.pnlReportFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportFilter.Location = new System.Drawing.Point(10, 108);
            this.pnlReportFilter.Name = "pnlReportFilter";
            this.pnlReportFilter.Size = new System.Drawing.Size(1292, 52);
            this.pnlReportFilter.TabIndex = 1;
            // 
            // btnExportTransactions
            // 
            this.btnExportTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTransactions.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportTransactions.Location = new System.Drawing.Point(1140, 11);
            this.btnExportTransactions.Name = "btnExportTransactions";
            this.btnExportTransactions.Size = new System.Drawing.Size(145, 30);
            this.btnExportTransactions.TabIndex = 7;
            this.btnExportTransactions.Text = "Xuất lịch sử GD (Excel)";
            this.btnExportTransactions.UseVisualStyleBackColor = false;
            this.btnExportTransactions.Click += new System.EventHandler(this.btnExportTransactions_Click);
            // 
            // btnRdlcRevenueReport
            // 
            this.btnRdlcRevenueReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRdlcRevenueReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRdlcRevenueReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRdlcRevenueReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRdlcRevenueReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdlcRevenueReport.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnRdlcRevenueReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnRdlcRevenueReport.Location = new System.Drawing.Point(810, 11);
            this.btnRdlcRevenueReport.Name = "btnRdlcRevenueReport";
            this.btnRdlcRevenueReport.Size = new System.Drawing.Size(155, 30);
            this.btnRdlcRevenueReport.TabIndex = 8;
            this.btnRdlcRevenueReport.Text = "📊 In báo cáo (RDLC)";
            this.btnRdlcRevenueReport.UseVisualStyleBackColor = false;
            this.btnRdlcRevenueReport.Click += new System.EventHandler(this.btnRdlcRevenueReport_Click);
            // 
            // btnExportRevenue
            // 
            this.btnExportRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExportRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportRevenue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExportRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportRevenue.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnExportRevenue.Location = new System.Drawing.Point(975, 11);
            this.btnExportRevenue.Name = "btnExportRevenue";
            this.btnExportRevenue.Size = new System.Drawing.Size(155, 30);
            this.btnExportRevenue.TabIndex = 6;
            this.btnExportRevenue.Text = "Xuất doanh thu (Excel)";
            this.btnExportRevenue.UseVisualStyleBackColor = false;
            this.btnExportRevenue.Click += new System.EventHandler(this.btnExportRevenue_Click);
            // 
            // btnRefreshAllReport
            // 
            this.btnRefreshAllReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnRefreshAllReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshAllReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRefreshAllReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAllReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshAllReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnRefreshAllReport.Location = new System.Drawing.Point(704, 11);
            this.btnRefreshAllReport.Name = "btnRefreshAllReport";
            this.btnRefreshAllReport.Size = new System.Drawing.Size(95, 30);
            this.btnRefreshAllReport.TabIndex = 5;
            this.btnRefreshAllReport.Text = "Đặt lại";
            this.btnRefreshAllReport.UseVisualStyleBackColor = false;
            this.btnRefreshAllReport.Click += new System.EventHandler(this.btnRefreshAllReport_Click);
            // 
            // btnRunReport
            // 
            this.btnRunReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnRunReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunReport.FlatAppearance.BorderSize = 0;
            this.btnRunReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRunReport.ForeColor = System.Drawing.Color.White;
            this.btnRunReport.Location = new System.Drawing.Point(564, 11);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(134, 30);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "Áp dụng lọc";
            this.btnRunReport.UseVisualStyleBackColor = false;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // dtpReportTo
            // 
            this.dtpReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportTo.Location = new System.Drawing.Point(416, 14);
            this.dtpReportTo.Name = "dtpReportTo";
            this.dtpReportTo.Size = new System.Drawing.Size(132, 23);
            this.dtpReportTo.TabIndex = 3;
            // 
            // lblReportTo
            // 
            this.lblReportTo.AutoSize = true;
            this.lblReportTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportTo.Location = new System.Drawing.Point(344, 17);
            this.lblReportTo.Name = "lblReportTo";
            this.lblReportTo.Size = new System.Drawing.Size(62, 15);
            this.lblReportTo.TabIndex = 2;
            this.lblReportTo.Text = "Đến ngày:";
            // 
            // dtpReportFrom
            // 
            this.dtpReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportFrom.Location = new System.Drawing.Point(202, 14);
            this.dtpReportFrom.Name = "dtpReportFrom";
            this.dtpReportFrom.Size = new System.Drawing.Size(132, 23);
            this.dtpReportFrom.TabIndex = 1;
            // 
            // chkFilterByDate
            // 
            this.chkFilterByDate.AutoSize = true;
            this.chkFilterByDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkFilterByDate.Location = new System.Drawing.Point(14, 16);
            this.chkFilterByDate.Name = "chkFilterByDate";
            this.chkFilterByDate.Size = new System.Drawing.Size(169, 19);
            this.chkFilterByDate.TabIndex = 0;
            this.chkFilterByDate.Text = "Lọc theo ngày đăng ký từ:";
            this.chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // pnlKpiCards
            // 
            this.pnlKpiCards.Controls.Add(this.pnlCardEnrollments);
            this.pnlKpiCards.Controls.Add(this.pnlCardStudents);
            this.pnlKpiCards.Controls.Add(this.pnlCardActiveCourses);
            this.pnlKpiCards.Controls.Add(this.pnlCardRevenue);
            this.pnlKpiCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiCards.Location = new System.Drawing.Point(10, 10);
            this.pnlKpiCards.Name = "pnlKpiCards";
            this.pnlKpiCards.Size = new System.Drawing.Size(1292, 98);
            this.pnlKpiCards.TabIndex = 0;
            // 
            // pnlCardEnrollments
            // 
            this.pnlCardEnrollments.BackColor = System.Drawing.Color.White;
            this.pnlCardEnrollments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardEnrollments.Controls.Add(this.lblCardEnrollValue);
            this.pnlCardEnrollments.Controls.Add(this.lblCardEnrollTitle);
            this.pnlCardEnrollments.Location = new System.Drawing.Point(912, 4);
            this.pnlCardEnrollments.Name = "pnlCardEnrollments";
            this.pnlCardEnrollments.Size = new System.Drawing.Size(296, 86);
            this.pnlCardEnrollments.TabIndex = 3;
            // 
            // lblCardEnrollValue
            // 
            this.lblCardEnrollValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardEnrollValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardEnrollValue.Location = new System.Drawing.Point(14, 38);
            this.lblCardEnrollValue.Name = "lblCardEnrollValue";
            this.lblCardEnrollValue.Size = new System.Drawing.Size(268, 34);
            this.lblCardEnrollValue.TabIndex = 1;
            this.lblCardEnrollValue.Text = "0 lượt";
            // 
            // lblCardEnrollTitle
            // 
            this.lblCardEnrollTitle.AutoSize = true;
            this.lblCardEnrollTitle.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCardEnrollTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardEnrollTitle.Location = new System.Drawing.Point(14, 12);
            this.lblCardEnrollTitle.Name = "lblCardEnrollTitle";
            this.lblCardEnrollTitle.Size = new System.Drawing.Size(119, 15);
            this.lblCardEnrollTitle.TabIndex = 0;
            this.lblCardEnrollTitle.Text = "Lượt đăng ký hợp lệ";
            // 
            // pnlCardStudents
            // 
            this.pnlCardStudents.BackColor = System.Drawing.Color.White;
            this.pnlCardStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardStudents.Controls.Add(this.lblCardStudentsValue);
            this.pnlCardStudents.Controls.Add(this.lblCardStudentsTitle);
            this.pnlCardStudents.Location = new System.Drawing.Point(608, 4);
            this.pnlCardStudents.Name = "pnlCardStudents";
            this.pnlCardStudents.Size = new System.Drawing.Size(292, 86);
            this.pnlCardStudents.TabIndex = 2;
            // 
            // lblCardStudentsValue
            // 
            this.lblCardStudentsValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardStudentsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardStudentsValue.Location = new System.Drawing.Point(14, 38);
            this.lblCardStudentsValue.Name = "lblCardStudentsValue";
            this.lblCardStudentsValue.Size = new System.Drawing.Size(264, 34);
            this.lblCardStudentsValue.TabIndex = 1;
            this.lblCardStudentsValue.Text = "0 học viên";
            // 
            // lblCardStudentsTitle
            // 
            this.lblCardStudentsTitle.AutoSize = true;
            this.lblCardStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCardStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardStudentsTitle.Location = new System.Drawing.Point(14, 12);
            this.lblCardStudentsTitle.Name = "lblCardStudentsTitle";
            this.lblCardStudentsTitle.Size = new System.Drawing.Size(100, 15);
            this.lblCardStudentsTitle.TabIndex = 0;
            this.lblCardStudentsTitle.Text = "Tổng số học viên";
            // 
            // pnlCardActiveCourses
            // 
            this.pnlCardActiveCourses.BackColor = System.Drawing.Color.White;
            this.pnlCardActiveCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardActiveCourses.Controls.Add(this.lblCardCoursesValue);
            this.pnlCardActiveCourses.Controls.Add(this.lblCardCoursesTitle);
            this.pnlCardActiveCourses.Location = new System.Drawing.Point(304, 4);
            this.pnlCardActiveCourses.Name = "pnlCardActiveCourses";
            this.pnlCardActiveCourses.Size = new System.Drawing.Size(292, 86);
            this.pnlCardActiveCourses.TabIndex = 1;
            // 
            // lblCardCoursesValue
            // 
            this.lblCardCoursesValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardCoursesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardCoursesValue.Location = new System.Drawing.Point(14, 38);
            this.lblCardCoursesValue.Name = "lblCardCoursesValue";
            this.lblCardCoursesValue.Size = new System.Drawing.Size(264, 34);
            this.lblCardCoursesValue.TabIndex = 1;
            this.lblCardCoursesValue.Text = "0 khóa học";
            // 
            // lblCardCoursesTitle
            // 
            this.lblCardCoursesTitle.AutoSize = true;
            this.lblCardCoursesTitle.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCardCoursesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardCoursesTitle.Location = new System.Drawing.Point(14, 12);
            this.lblCardCoursesTitle.Name = "lblCardCoursesTitle";
            this.lblCardCoursesTitle.Size = new System.Drawing.Size(158, 15);
            this.lblCardCoursesTitle.TabIndex = 0;
            this.lblCardCoursesTitle.Text = "Khóa học đang mở đăng ký";
            // 
            // pnlCardRevenue
            // 
            this.pnlCardRevenue.BackColor = System.Drawing.Color.White;
            this.pnlCardRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardRevenue.Controls.Add(this.lblCardRevenueValue);
            this.pnlCardRevenue.Controls.Add(this.lblCardRevenueTitle);
            this.pnlCardRevenue.Location = new System.Drawing.Point(0, 4);
            this.pnlCardRevenue.Name = "pnlCardRevenue";
            this.pnlCardRevenue.Size = new System.Drawing.Size(292, 86);
            this.pnlCardRevenue.TabIndex = 0;
            // 
            // lblCardRevenueValue
            // 
            this.lblCardRevenueValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblCardRevenueValue.Location = new System.Drawing.Point(14, 38);
            this.lblCardRevenueValue.Name = "lblCardRevenueValue";
            this.lblCardRevenueValue.Size = new System.Drawing.Size(264, 34);
            this.lblCardRevenueValue.TabIndex = 1;
            this.lblCardRevenueValue.Text = "0 VNĐ";
            // 
            // lblCardRevenueTitle
            // 
            this.lblCardRevenueTitle.AutoSize = true;
            this.lblCardRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCardRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardRevenueTitle.Location = new System.Drawing.Point(14, 12);
            this.lblCardRevenueTitle.Name = "lblCardRevenueTitle";
            this.lblCardRevenueTitle.Size = new System.Drawing.Size(145, 15);
            this.lblCardRevenueTitle.TabIndex = 0;
            this.lblCardRevenueTitle.Text = "Tổng doanh thu thực thu";
            // 
            // printDocAdminReceipt
            // 
            this.printDocAdminReceipt.DocumentName = "BienLaiDangKyKhoaHoc";
            this.printDocAdminReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocAdminReceipt_PrintPage);
            // 
            // printPreviewAdminReceipt
            // 
            this.printPreviewAdminReceipt.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewAdminReceipt.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewAdminReceipt.ClientSize = new System.Drawing.Size(960, 700);
            this.printPreviewAdminReceipt.Document = this.printDocAdminReceipt;
            this.printPreviewAdminReceipt.Enabled = true;
            this.printPreviewAdminReceipt.Name = "printPreviewAdminReceipt";
            this.printPreviewAdminReceipt.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.printPreviewAdminReceipt.Text = "Xem trước biên lai xác nhận đăng ký khóa học";
            this.printPreviewAdminReceipt.Visible = false;
            // 
            // saveFileAdminExcel
            // 
            this.saveFileAdminExcel.DefaultExt = "xls";
            this.saveFileAdminExcel.Filter = "Tệp Excel (*.xlsx)|*.xlsx|Tệp Excel cũ (*.xls)|*.xls|Tệp CSV UTF-8 (*.csv)|*.csv";
            this.saveFileAdminExcel.Title = "Xuất báo cáo quản trị ra Excel";
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 780);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "FrmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị đào tạo - Hệ thống Quản lý Đào tạo";
            this.Load += new System.EventHandler(this.FrmAdminMain_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            this.pnlCourseList.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.vouchersBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.adminReviewsBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.courseRevenueBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.systemTransactionsBindingSource)).EndInit();

((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.pnlCourseFilter.ResumeLayout(false);
            this.pnlCourseFilter.PerformLayout();
            this.grpCourseForm.ResumeLayout(false);
            this.grpCourseForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursePrice)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.pnlCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.pnlCatFilter.ResumeLayout(false);
            this.pnlCatFilter.PerformLayout();
            this.grpCategoryForm.ResumeLayout(false);
            this.grpCategoryForm.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.pnlUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUserFilter.ResumeLayout(false);
            this.pnlUserFilter.PerformLayout();
            this.grpUserForm.ResumeLayout(false);
            this.grpUserForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserBalance)).EndInit();
            this.tabEnrollments.ResumeLayout(false);
            this.pnlEnrollList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.pnlEnrollFilter.ResumeLayout(false);
            this.pnlEnrollFilter.PerformLayout();
            this.grpEnrollForm.ResumeLayout(false);
            this.grpEnrollForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnrollPaid)).EndInit();
            this.tabVouchers.ResumeLayout(false);
            this.pnlVoucherMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.pnlVoucherFilter.ResumeLayout(false);
            this.pnlVoucherFilter.PerformLayout();
            this.grpVoucherForm.ResumeLayout(false);
            this.grpVoucherForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherUsageLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherMinOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherMaxDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoucherPercent)).EndInit();
            this.tabAdminReviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReviews)).EndInit();
            this.pnlAdminReviewFilter.ResumeLayout(false);
            this.pnlAdminReviewFilter.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.splitReports.Panel1.ResumeLayout(false);
            this.splitReports.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitReports)).EndInit();
            this.splitReports.ResumeLayout(false);
            this.grpRevenueByCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRevenue)).EndInit();
            this.grpAllTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemTransactions)).EndInit();
            this.splitCharts.Panel1.ResumeLayout(false);
            this.splitCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).EndInit();
            this.splitCharts.ResumeLayout(false);
            this.grpChartRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCourseRevenue)).EndInit();
            this.grpChartCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryShare)).EndInit();
            this.pnlReportFilter.ResumeLayout(false);
            this.pnlReportFilter.PerformLayout();
            this.pnlKpiCards.ResumeLayout(false);
            this.pnlCardEnrollments.ResumeLayout(false);
            this.pnlCardEnrollments.PerformLayout();
            this.pnlCardStudents.ResumeLayout(false);
            this.pnlCardStudents.PerformLayout();
            this.pnlCardActiveCourses.ResumeLayout(false);
            this.pnlCardActiveCourses.PerformLayout();
            this.pnlCardRevenue.ResumeLayout(false);
            this.pnlCardRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnAdminAbout;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Label lblAdminWelcome;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.Panel pnlCourseList;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Panel pnlCourseFilter;
        private System.Windows.Forms.Button btnResetCourseFilter;
        private System.Windows.Forms.ComboBox cboFilterCourseStatus;
        private System.Windows.Forms.ComboBox cboFilterCourseCategory;
        private System.Windows.Forms.Label lblFilterCat;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private System.Windows.Forms.Label lblSearchCourse;
        private System.Windows.Forms.GroupBox grpCourseForm;
        private System.Windows.Forms.Button btnCourseClear;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Button btnCourseUpdate;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.TextBox txtCourseDesc;
        private System.Windows.Forms.Label lblCourseDesc;
        private System.Windows.Forms.CheckBox chkCourseActive;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.NumericUpDown nudMaxStudents;
        private System.Windows.Forms.Label lblMaxStudents;
        private System.Windows.Forms.NumericUpDown nudDurationHours;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nudCoursePrice;
        private System.Windows.Forms.Label lblCoursePrice;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.ComboBox cboCourseCategory;
        private System.Windows.Forms.Label lblCourseCategory;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.Panel pnlCategoryList;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel pnlCatFilter;
        private System.Windows.Forms.Button btnResetCatFilter;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label lblSearchCat;
        private System.Windows.Forms.GroupBox grpCategoryForm;
        private System.Windows.Forms.Button btnCatClear;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatUpdate;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.Label lblCatDesc;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCatId;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel pnlUserList;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlUserFilter;
        private System.Windows.Forms.Button btnResetUserFilter;
        private System.Windows.Forms.ComboBox cboFilterUserRole;
        private System.Windows.Forms.Label lblFilterRole;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.GroupBox grpUserForm;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.CheckBox chkUserActive;
        private System.Windows.Forms.NumericUpDown nudUserBalance;
        private System.Windows.Forms.Label lblUserBalance;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txtUserFullName;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserUsername;
        private System.Windows.Forms.Label lblUserUsername;
        private System.Windows.Forms.ComboBox cboUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TabPage tabEnrollments;
        private System.Windows.Forms.Panel pnlEnrollList;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.Panel pnlEnrollFilter;
        private System.Windows.Forms.Button btnResetEnrollFilter;
        private System.Windows.Forms.ComboBox cboFilterEnrollStatus;
        private System.Windows.Forms.Label lblFilterEnrollStatus;
        private System.Windows.Forms.TextBox txtSearchEnroll;
        private System.Windows.Forms.Label lblSearchEnroll;
        private System.Windows.Forms.GroupBox grpEnrollForm;
        private System.Windows.Forms.Button btnEnrollClear;
        private System.Windows.Forms.Button btnEnrollDelete;
        private System.Windows.Forms.Button btnEnrollRefundCancel;
        private System.Windows.Forms.Button btnEnrollUpdate;
        private System.Windows.Forms.Button btnEnrollAdd;
        private System.Windows.Forms.TextBox txtEnrollNote;
        private System.Windows.Forms.Label lblEnrollNote;
        private System.Windows.Forms.CheckBox chkDeductWalletOnAdminCreate;
        private System.Windows.Forms.NumericUpDown nudEnrollPaid;
        private System.Windows.Forms.Label lblEnrollPaid;
        private System.Windows.Forms.ComboBox cboEnrollCourse;
        private System.Windows.Forms.Label lblEnrollCourse;
        private System.Windows.Forms.ComboBox cboEnrollStudent;
        private System.Windows.Forms.Label lblEnrollStudent;
        private System.Windows.Forms.ComboBox cboEnrollStatus;
        private System.Windows.Forms.Label lblEnrollStatus;
        private System.Windows.Forms.TextBox txtEnrollmentId;
        private System.Windows.Forms.Label lblEnrollId;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.SplitContainer splitReports;
        private System.Windows.Forms.GroupBox grpRevenueByCourse;
        private System.Windows.Forms.DataGridView dgvCourseRevenue;
        private System.Windows.Forms.GroupBox grpAllTransactions;
        private System.Windows.Forms.DataGridView dgvSystemTransactions;
        private System.Windows.Forms.Panel pnlReportFilter;
        private System.Windows.Forms.Button btnRefreshAllReport;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.DateTimePicker dtpReportTo;
        private System.Windows.Forms.Label lblReportTo;
        private System.Windows.Forms.DateTimePicker dtpReportFrom;
        private System.Windows.Forms.CheckBox chkFilterByDate;
        private System.Windows.Forms.Panel pnlKpiCards;
        private System.Windows.Forms.Panel pnlCardEnrollments;
        private System.Windows.Forms.Label lblCardEnrollValue;
        private System.Windows.Forms.Label lblCardEnrollTitle;
        private System.Windows.Forms.Panel pnlCardStudents;
        private System.Windows.Forms.Label lblCardStudentsValue;
        private System.Windows.Forms.Label lblCardStudentsTitle;
        private System.Windows.Forms.Panel pnlCardActiveCourses;
        private System.Windows.Forms.Label lblCardCoursesValue;
        private System.Windows.Forms.Label lblCardCoursesTitle;
        private System.Windows.Forms.Panel pnlCardRevenue;
        private System.Windows.Forms.Label lblCardRevenueValue;
        private System.Windows.Forms.Label lblCardRevenueTitle;
        private System.Windows.Forms.Button btnExportCourses;
        private System.Windows.Forms.TextBox txtCourseRoom;
        private System.Windows.Forms.Label lblCourseRoom;
        private System.Windows.Forms.ComboBox cboCourseShift;
        private System.Windows.Forms.Label lblCourseShift;
        private System.Windows.Forms.ComboBox cboCourseDays;
        private System.Windows.Forms.Label lblCourseDays;
        private System.Windows.Forms.Button btnExportEnrollments;
        private System.Windows.Forms.Button btnRdlcEnrollmentReport;
        private System.Windows.Forms.Button btnPrintAdminReceipt;
        private System.Windows.Forms.TabPage tabVouchers;
        private System.Windows.Forms.Panel pnlVoucherMain;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Panel pnlVoucherFilter;
        private System.Windows.Forms.Button btnResetVoucherFilter;
        private System.Windows.Forms.ComboBox cboFilterVoucherStatus;
        private System.Windows.Forms.TextBox txtSearchVoucher;
        private System.Windows.Forms.Label lblSearchVoucher;
        private System.Windows.Forms.GroupBox grpVoucherForm;
        private System.Windows.Forms.Button btnVoucherClear;
        private System.Windows.Forms.Button btnVoucherDelete;
        private System.Windows.Forms.Button btnVoucherUpdate;
        private System.Windows.Forms.Button btnVoucherAdd;
        private System.Windows.Forms.DateTimePicker dtpVoucherExpiry;
        private System.Windows.Forms.Label lblVoucherExpiry;
        private System.Windows.Forms.TextBox txtVoucherUsedCount;
        private System.Windows.Forms.Label lblVoucherUsed;
        private System.Windows.Forms.NumericUpDown nudVoucherUsageLimit;
        private System.Windows.Forms.Label lblVoucherLimit;
        private System.Windows.Forms.NumericUpDown nudVoucherMinOrder;
        private System.Windows.Forms.Label lblVoucherMinOrder;
        private System.Windows.Forms.NumericUpDown nudVoucherMaxDiscount;
        private System.Windows.Forms.Label lblVoucherMax;
        private System.Windows.Forms.NumericUpDown nudVoucherAmount;
        private System.Windows.Forms.Label lblVoucherAmount;
        private System.Windows.Forms.NumericUpDown nudVoucherPercent;
        private System.Windows.Forms.Label lblVoucherPercent;
        private System.Windows.Forms.TextBox txtVoucherDesc;
        private System.Windows.Forms.Label lblVoucherDesc;
        private System.Windows.Forms.TextBox txtVoucherCodeAdmin;
        private System.Windows.Forms.Label lblVoucherCodeAdmin;
        private System.Windows.Forms.CheckBox chkVoucherActive;
        private System.Windows.Forms.TextBox txtVoucherId;
        private System.Windows.Forms.Label lblVoucherId;
        private System.Windows.Forms.TabPage tabAdminReviews;
        private System.Windows.Forms.DataGridView dgvAdminReviews;
        private System.Windows.Forms.Panel pnlAdminReviewFilter;
        private System.Windows.Forms.Button btnAdminDeleteReview;
        private System.Windows.Forms.Button btnExportReviews;
        private System.Windows.Forms.Label lblAdminReviewStats;
        private System.Windows.Forms.ComboBox cboAdminReviewStars;
        private System.Windows.Forms.ComboBox cboAdminReviewCourse;
        private System.Windows.Forms.Label lblAdminRevFilter;
        private System.Windows.Forms.SplitContainer splitCharts;
        private System.Windows.Forms.GroupBox grpChartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCourseRevenue;
        private System.Windows.Forms.GroupBox grpChartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryShare;
        private System.Windows.Forms.Button btnExportTransactions;
        private System.Windows.Forms.Button btnExportRevenue;
        private System.Windows.Forms.Button btnRdlcRevenueReport;
        private System.Drawing.Printing.PrintDocument printDocAdminReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewAdminReceipt;
        private System.Windows.Forms.SaveFileDialog saveFileAdminExcel;



        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_ScheduleShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_EnrolledSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_RatingText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse_StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat_TotalCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_RoleDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_BoughtCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_EnrollmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_EnrollDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_VoucherDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_StatusDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnroll_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_VoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_VoucherCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_ValueDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_MinOrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_QuotaDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucher_StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_ReviewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_StarsDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRev_CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_SoldSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_FillPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatRev_Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_TypeDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTx_CreatedAt;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource enrollmentsBindingSource;
        private System.Windows.Forms.BindingSource vouchersBindingSource;
        private System.Windows.Forms.BindingSource adminReviewsBindingSource;
        private System.Windows.Forms.BindingSource courseRevenueBindingSource;
        private System.Windows.Forms.BindingSource systemTransactionsBindingSource;
    }
}