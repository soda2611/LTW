using System;

using System.Collections.Generic;

using System.Data;

using System.Drawing;

using System.Drawing.Printing;

using System.Linq;

using System.Windows.Forms;



namespace Course_Registration

{

    public partial class FrmStudentMain : Form

    {

        private readonly int _studentId;

        private int _selectedCatalogCourseId = 0;

        private string _appliedVoucherCode = null;

        private decimal _appliedDiscountAmount = 0m;

        private bool _isLoadingCombos = false;

        private bool _isBindingCatalog = false;

        private EnrollmentReceiptData _currentReceiptData = null;



        private class LookupItem

        {

            public int Id { get; set; }

            public string Name { get; set; }



            public override string ToString()

            {

                return Name;

            }

        }



        private class ActiveScheduleItem

        {

            public int CourseID { get; set; }

            public string CourseCode { get; set; }

            public string CourseName { get; set; }

            public string StudyDays { get; set; }

            public string StudyShift { get; set; }

            public string Room { get; set; }

        }



        public FrmStudentMain() : this(2)

        {

        }



        public FrmStudentMain(int studentId)
        {
            _studentId = studentId;
            InitializeComponent();
            ConfigureGrids();
        }

        private void ConfigureGrids()
        {
            dgvCatalog.AutoGenerateColumns = false;
            dgvMyCourses.AutoGenerateColumns = false;
            dgvTimetable.AutoGenerateColumns = false;
            dgvStudentReviews.AutoGenerateColumns = false;
            dgvMyTransactions.AutoGenerateColumns = false;
        }



        private void FrmStudentMain_Load(object sender, EventArgs e)

        {

            if (DesignMode)
            {
                return;
            }

            dgvCatalog.AutoGenerateColumns = false;
            dgvMyCourses.AutoGenerateColumns = false;
            dgvTimetable.AutoGenerateColumns = false;
            dgvStudentReviews.AutoGenerateColumns = false;
            dgvMyTransactions.AutoGenerateColumns = false;



            cboCatalogSort.SelectedIndex = 0;

            cboMyCourseStatus.SelectedIndex = 0;

            cboReviewRating.SelectedIndex = 0;

            cboPaymentMethod.SelectedIndex = 0;

            cboFilterTxType.SelectedIndex = 0;



            RefreshStudentHeaderAndBalance();

            LoadCatalogCategories();

            LoadCatalogCourses();

            LoadMyCourses();

            LoadTimetable();

            LoadReviewLookups();

            LoadStudentReviews();

            LoadWalletTransactions();

            LoadProfile();

        }



        private void RefreshStudentHeaderAndBalance()

        {

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User student = db.Users.FirstOrDefault(u => u.UserID == _studentId);

                if (student != null)

                {

                    string sessionTime = UserSession.IsLoggedIn
                        ? string.Format(" | Phiên: {0:HH:mm}", UserSession.CurrentUser.LoginTime)
                        : string.Empty;
                    lblStudentName.Text = string.Format("Học viên: {0} ({1}){2}", student.FullName, student.Username, sessionTime);

                    lblHeaderBalance.Text = string.Format("Số dư học phí: {0:N0} VNĐ", student.Balance);

                    lblWalletBigBalance.Text = string.Format("{0:N0} VNĐ", student.Balance);

                }

            }

        }



        private void tabStudent_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (DesignMode)
            {
                return;
            }

            dgvCatalog.AutoGenerateColumns = false;
            dgvMyCourses.AutoGenerateColumns = false;
            dgvTimetable.AutoGenerateColumns = false;
            dgvStudentReviews.AutoGenerateColumns = false;
            dgvMyTransactions.AutoGenerateColumns = false;



            RefreshStudentHeaderAndBalance();



            if (tabStudent.SelectedTab == tabCatalog)

            {

                LoadCatalogCourses();

            }

            else if (tabStudent.SelectedTab == tabMyCourses)

            {

                LoadMyCourses();

            }

            else if (tabStudent.SelectedTab == tabTimetable)

            {

                LoadTimetable();

            }

            else if (tabStudent.SelectedTab == tabReviews)

            {

                LoadReviewLookups();

                LoadStudentReviews();

            }

            else if (tabStudent.SelectedTab == tabWallet)

            {

                LoadWalletTransactions();

            }

            else if (tabStudent.SelectedTab == tabProfile)

            {

                LoadProfile();

            }

        }



        private void btnQuickTopUp_Click(object sender, EventArgs e)

        {

            tabStudent.SelectedTab = tabWallet;

            nudTopUpAmount.Focus();

        }



        private void btnStudentAbout_Click(object sender, EventArgs e)
        {
            using (var f = new FrmAbout())
            {
                f.ShowDialog(this);
            }
        }

        private void btnStudentLogout_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi cổng thông tin học viên?",

                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                this.Close();

            }

        }



        #region 1. DANH SÁCH KHÓA HỌC, KIỂM TRA TRÙNG LỊCH & MÃ HỌC BỔNG (LINQ)



        private void LoadCatalogCategories()

        {

            _isLoadingCombos = true;

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    List<Category> cats = (from c in db.Categories

                                           orderby c.CategoryName

                                           select c).ToList();



                    cboCatalogCategory.Items.Clear();

                    cboCatalogCategory.Items.Add(new LookupItem { Id = 0, Name = "Tất cả danh mục" });

                    foreach (Category c in cats)

                    {

                        cboCatalogCategory.Items.Add(new LookupItem { Id = c.CategoryID, Name = c.CategoryName });

                    }

                    cboCatalogCategory.SelectedIndex = 0;



                    List<string> activeCodes = (from v in db.Vouchers

                                                where v.IsActive && v.ExpiryDate >= DateTime.Today && v.UsedCount < v.UsageLimit

                                                orderby v.VoucherCode

                                                select v.VoucherCode).Take(3).ToList();

                    if (activeCodes.Count > 0 && string.IsNullOrEmpty(_appliedVoucherCode))

                    {

                        lblVoucherStatus.Text = "Mã học bổng đang mở: " + string.Join(", ", activeCodes);

                    }

                }

            }

            finally

            {

                _isLoadingCombos = false;

            }

        }



        private List<ActiveScheduleItem> GetStudentActiveSchedules(CourseRegistrationDataContext db)

        {

            return (from en in db.Enrollments

                    where en.UserID == _studentId && en.Status == "Active"

                    select new ActiveScheduleItem

                    {

                        CourseID = en.CourseID,

                        CourseCode = en.Course.CourseCode,

                        CourseName = en.Course.CourseName,

                        StudyDays = en.Course.StudyDays,

                        StudyShift = en.Course.StudyShift,

                        Room = en.Course.Room

                    }).ToList();

        }



        private void LoadCatalogCourses()

        {

            if (_isLoadingCombos)

            {

                return;

            }



            string kw = txtCatalogSearch.Text.Trim().ToLower();

            LookupItem catItem = cboCatalogCategory.SelectedItem as LookupItem;

            int catId = catItem != null ? catItem.Id : 0;

            int sortIndex = cboCatalogSort.SelectedIndex;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Course> query = db.Courses.Where(c => c.IsActive);



                if (!string.IsNullOrEmpty(kw))

                {

                    query = query.Where(c =>

                        c.CourseCode.ToLower().Contains(kw) ||

                        c.CourseName.ToLower().Contains(kw) ||

                        c.Instructor.ToLower().Contains(kw) ||

                        c.Room.ToLower().Contains(kw));

                }



                if (catId > 0)

                {

                    query = query.Where(c => c.CategoryID == catId);

                }



                List<ActiveScheduleItem> mySchedules = GetStudentActiveSchedules(db);

                List<int> myActiveCourseIds = mySchedules.Select(s => s.CourseID).ToList();



                var rawCourses = (from c in query

                                  select new

                                  {

                                      c.CourseID,

                                      c.CourseCode,

                                      c.CourseName,

                                      CategoryName = c.Category != null ? c.Category.CategoryName : "Khác",

                                      c.Instructor,

                                      c.Price,

                                      c.DurationHours,

                                      c.StartDate,

                                      c.StudyDays,

                                      c.StudyShift,

                                      c.Room,

                                      c.MaxStudents,

                                      ActiveCount = c.Enrollments.Count(en => en.Status == "Active"),

                                      ReviewCount = c.CourseReviews.Count(),

                                      AvgRating = c.CourseReviews.Any()

                                          ? c.CourseReviews.Average(r => (double)r.Rating)

                                          : 0.0

                                  }).ToList();



                switch (sortIndex)

                {

                    case 1:

                        rawCourses = rawCourses.OrderBy(c => c.Price).ToList();

                        break;

                    case 2:

                        rawCourses = rawCourses.OrderByDescending(c => c.Price).ToList();

                        break;

                    case 3:

                        rawCourses = rawCourses.OrderBy(c => c.StartDate).ToList();

                        break;

                    case 4:

                        rawCourses = rawCourses.OrderByDescending(c => c.AvgRating).ThenByDescending(c => c.ReviewCount).ToList();

                        break;

                    default:

                        rawCourses = rawCourses.OrderByDescending(c => c.CourseID).ToList();

                        break;

                }



                var displayList = rawCourses.Select(c =>

                {

                    bool isEnrolled = myActiveCourseIds.Contains(c.CourseID);

                    bool isFull = c.ActiveCount >= c.MaxStudents;

                    bool hasConflict = false;

                    if (!isEnrolled)

                    {

                        foreach (ActiveScheduleItem myItem in mySchedules)

                        {

                            string overlap;

                            if (ScheduleHelper.HasScheduleConflict(c.StudyDays, c.StudyShift, myItem.StudyDays, myItem.StudyShift, out overlap))

                            {

                                hasConflict = true;

                                break;

                            }

                        }

                    }



                    string stateText;

                    if (isEnrolled) stateText = "Đã đăng ký";

                    else if (hasConflict) stateText = "Trùng lịch học";

                    else if (isFull) stateText = "Đã đủ sĩ số";

                    else stateText = "Còn chỗ";



                    return new

                    {

                        c.CourseID,

                        c.CourseCode,

                        c.CourseName,

                        c.Instructor,

                        ScheduleShort = ScheduleHelper.FormatShortSchedule(c.StudyDays, c.StudyShift),

                        c.Room,

                        RatingDisplay = ScheduleHelper.FormatStars(c.AvgRating, c.ReviewCount),

                        c.Price,

                        Remaining = Math.Max(0, c.MaxStudents - c.ActiveCount) + "/" + c.MaxStudents,

                        MyState = stateText

                    };

                }).ToList();



                _isBindingCatalog = true;

                try

                {

                    if (dgvCatalog.DataSource == null) dgvCatalog.Rows.Clear();

                catalogBindingSource.DataSource = displayList;

                }

                finally

                {

                    _isBindingCatalog = false;

                }



                if (dgvCatalog.Columns.Count > 0)

                {

                    dgvCatalog.Columns["colCat_CourseID"].Visible = false;

                    dgvCatalog.Columns["colCat_CourseCode"].HeaderText = "Mã khóa học";

                    dgvCatalog.Columns["colCat_CourseCode"].FillWeight = 62;

                    dgvCatalog.Columns["colCat_CourseName"].HeaderText = "Tên khóa học";

                    dgvCatalog.Columns["colCat_CourseName"].FillWeight = 165;

                    dgvCatalog.Columns["colCat_Instructor"].HeaderText = "Giảng viên";

                    dgvCatalog.Columns["colCat_Instructor"].FillWeight = 105;

                    dgvCatalog.Columns["colCat_ScheduleShort"].HeaderText = "Lịch học";

                    dgvCatalog.Columns["colCat_ScheduleShort"].FillWeight = 108;

                    dgvCatalog.Columns["colCat_Room"].HeaderText = "Phòng";

                    dgvCatalog.Columns["colCat_Room"].FillWeight = 82;

                    dgvCatalog.Columns["colCat_RatingDisplay"].HeaderText = "Đánh giá";

                    dgvCatalog.Columns["colCat_RatingDisplay"].FillWeight = 82;

                    dgvCatalog.Columns["colCat_Price"].HeaderText = "Học phí (VNĐ)";

                    dgvCatalog.Columns["colCat_Price"].DefaultCellStyle.Format = "N0";

                    dgvCatalog.Columns["colCat_Price"].FillWeight = 88;

                    dgvCatalog.Columns["colCat_Remaining"].HeaderText = "Còn trống";

                    dgvCatalog.Columns["colCat_Remaining"].FillWeight = 64;

                    dgvCatalog.Columns["colCat_MyState"].HeaderText = "Trạng thái";

                    dgvCatalog.Columns["colCat_MyState"].FillWeight = 88;

                }



                if (displayList.Count > 0)

                {

                    int targetId = _selectedCatalogCourseId;

                    bool found = false;

                    for (int i = 0; i < dgvCatalog.Rows.Count; i++)

                    {

                        if (Convert.ToInt32(dgvCatalog.Rows[i].Cells["colCat_CourseID"].Value) == targetId)

                        {

                            dgvCatalog.CurrentCell = dgvCatalog.Rows[i].Cells["colCat_CourseCode"];

                            ShowSelectedCatalogCourse(targetId);

                            found = true;

                            break;

                        }

                    }



                    if (!found)

                    {

                        ShowSelectedCatalogCourse(displayList[0].CourseID);

                    }

                }

                else

                {

                    ClearCatalogSelection();

                }

            }

        }



        private void dgvCatalog_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)

        {

            if (e.RowIndex < 0 || e.Value == null)

            {

                return;

            }



            if (dgvCatalog.Columns[e.ColumnIndex].Name == "colCat_MyState")

            {

                string val = e.Value.ToString();

                if (val == "Trùng lịch học")

                {

                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);

                    e.CellStyle.Font = new Font("Segoe UI", 8.75f, FontStyle.Bold);

                }

                else if (val == "Đã đăng ký")

                {

                    e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);

                    e.CellStyle.Font = new Font("Segoe UI", 8.75f, FontStyle.Bold);

                }

                else if (val == "Còn chỗ")

                {

                    e.CellStyle.ForeColor = Color.FromArgb(21, 128, 61);

                    e.CellStyle.Font = new Font("Segoe UI", 8.75f, FontStyle.Bold);

                }

            }

        }



        private void dgvCatalog_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvCatalog.CurrentRow == null)

            {

                return;

            }



            int courseId = Convert.ToInt32(dgvCatalog.CurrentRow.Cells["colCat_CourseID"].Value);

            ShowSelectedCatalogCourse(courseId);

        }



        private void dgvCatalog_SelectionChanged(object sender, EventArgs e)

        {

            if (_isBindingCatalog || _isLoadingCombos || !dgvCatalog.Columns.Contains("colCat_CourseID"))

            {

                return;

            }



            DataGridViewRow row = dgvCatalog.SelectedRows.Count > 0

                ? dgvCatalog.SelectedRows[0]

                : dgvCatalog.CurrentRow;

            if (row == null)

            {

                return;

            }



            object val = row.Cells["colCat_CourseID"].Value;

            if (val == null)

            {

                return;

            }



            int courseId = Convert.ToInt32(val);

            if (courseId != _selectedCatalogCourseId)

            {

                ShowSelectedCatalogCourse(courseId);

            }

        }



        private void ShowSelectedCatalogCourse(int courseId)

        {

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Course c = db.Courses.FirstOrDefault(x => x.CourseID == courseId);

                if (c == null)

                {

                    ClearCatalogSelection();

                    return;

                }



                _selectedCatalogCourseId = c.CourseID;

                int activeCount = c.Enrollments.Count(en => en.Status == "Active");

                int slotsLeft = Math.Max(0, c.MaxStudents - activeCount);

                bool owned = db.Enrollments.Any(en =>

                    en.UserID == _studentId && en.CourseID == c.CourseID && en.Status == "Active");



                int revCount = c.CourseReviews.Count();

                double avgStars = revCount > 0 ? c.CourseReviews.Average(r => (double)r.Rating) : 0.0;



                lblSelCode.Text = "Mã khóa học: " + c.CourseCode;

                lblSelRating.Text = "Đánh giá: " + ScheduleHelper.FormatStars(avgStars, revCount);

                lblSelName.Text = c.CourseName;

                lblSelCategory.Text = "Danh mục: " + (c.Category != null ? c.Category.CategoryName : "Khác");

                lblSelInstructor.Text = "Giảng viên: " + c.Instructor;

                lblSelSchedule.Text = string.Format("Thời lượng: {0} giờ  |  Khai giảng: {1:dd/MM/yyyy}",

                    c.DurationHours, c.StartDate);

                lblSelClassTime.Text = string.Format("{0} ({1}) - {2}",

                    ScheduleHelper.FormatDaysText(c.StudyDays), c.StudyShift, c.Room);

                lblSelSlots.Text = string.Format("Sĩ số còn trống: {0}/{1} học viên", slotsLeft, c.MaxStudents);

                txtSelDescription.Text = string.IsNullOrEmpty(c.Description)

                    ? "Chưa có mô tả chi tiết cho khóa học này."

                    : c.Description;



                // Kiểm tra trùng lịch bằng LINQ

                ActiveScheduleItem conflictItem = null;

                string overlapDays = string.Empty;

                if (!owned)

                {

                    List<ActiveScheduleItem> mySchedules = GetStudentActiveSchedules(db);

                    foreach (ActiveScheduleItem item in mySchedules)

                    {

                        string ov;

                        if (ScheduleHelper.HasScheduleConflict(c.StudyDays, c.StudyShift, item.StudyDays, item.StudyShift, out ov))

                        {

                            conflictItem = item;

                            overlapDays = ov;

                            break;

                        }

                    }

                }



                if (conflictItem != null)

                {

                    lblConflictWarning.Visible = true;

                    lblConflictWarning.Text = string.Format(

                        "Trùng lịch với [{0}] {1}\r\n({2} - {3})",

                        conflictItem.CourseCode, conflictItem.CourseName, overlapDays, c.StudyShift);

                }

                else

                {

                    lblConflictWarning.Visible = false;

                }



                // Tính lại mã học bổng nếu học viên đang nhập sẵn mã

                RecalculateSelectedCourseVoucher(db, c, false);



                if (owned)

                {

                    btnBuyCourse.Text = "Đã đăng ký khóa học này";

                    btnBuyCourse.BackColor = Color.FromArgb(148, 163, 184);

                    btnBuyCourse.Enabled = false;

                }

                else if (conflictItem != null)

                {

                    btnBuyCourse.Text = "Không thể đăng ký (Trùng lịch học)";

                    btnBuyCourse.BackColor = Color.FromArgb(185, 28, 28);

                    btnBuyCourse.Enabled = false;

                }

                else if (slotsLeft <= 0)

                {

                    btnBuyCourse.Text = "Lớp đã đủ sĩ số";

                    btnBuyCourse.BackColor = Color.FromArgb(148, 163, 184);

                    btnBuyCourse.Enabled = false;

                }

                else

                {

                    btnBuyCourse.Text = "Đăng ký khóa học";

                    btnBuyCourse.BackColor = Color.FromArgb(30, 64, 175);

                    btnBuyCourse.Enabled = true;

                }

            }

        }



        private void RecalculateSelectedCourseVoucher(CourseRegistrationDataContext db, Course c, bool showPopupOnError)

        {

            string inputCode = txtVoucherCode.Text.Trim().ToUpperInvariant();

            if (string.IsNullOrEmpty(inputCode))

            {

                _appliedVoucherCode = null;

                _appliedDiscountAmount = 0m;

                lblSelPrice.Text = string.Format("Học phí thanh toán: {0:N0} VNĐ", c.Price);



                List<string> sampleCodes = (from v in db.Vouchers

                                            where v.IsActive && v.ExpiryDate >= DateTime.Today && v.UsedCount < v.UsageLimit

                                            orderby v.VoucherCode

                                            select v.VoucherCode).Take(3).ToList();

                lblVoucherStatus.ForeColor = Color.FromArgb(100, 116, 139);

                lblVoucherStatus.Text = sampleCodes.Count > 0

                    ? "Mã học bổng đang áp dụng: " + string.Join(", ", sampleCodes)

                    : "Nhập mã học bổng / miễn giảm học phí nếu có.";

                return;

            }



            Voucher voucher = db.Vouchers.FirstOrDefault(v => v.VoucherCode.ToUpper() == inputCode);

            string err;

            decimal discount = ScheduleHelper.CalculateVoucherDiscount(voucher, c.Price, out err);



            if (!string.IsNullOrEmpty(err))

            {

                _appliedVoucherCode = null;

                _appliedDiscountAmount = 0m;

                lblVoucherStatus.ForeColor = Color.FromArgb(185, 28, 28);

                lblVoucherStatus.Text = err;

                lblSelPrice.Text = string.Format("Học phí thanh toán: {0:N0} VNĐ", c.Price);

                if (showPopupOnError)

                {

                    MessageBox.Show(err, "Không thể áp dụng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            else

            {

                _appliedVoucherCode = voucher.VoucherCode;

                _appliedDiscountAmount = discount;

                decimal payable = Math.Max(0m, c.Price - discount);

                lblVoucherStatus.ForeColor = Color.FromArgb(21, 128, 61);

                lblVoucherStatus.Text = string.Format("Đã áp dụng mã {0}: Miễn giảm -{1:N0} VNĐ", voucher.VoucherCode, discount);

                lblSelPrice.Text = string.Format("Thanh toán: {0:N0} VNĐ (Gốc: {1:N0})", payable, c.Price);

            }

        }



        private void btnApplyVoucher_Click(object sender, EventArgs e)

        {

            if (_selectedCatalogCourseId <= 0)

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Course c = db.Courses.FirstOrDefault(x => x.CourseID == _selectedCatalogCourseId);

                if (c != null)

                {

                    RecalculateSelectedCourseVoucher(db, c, true);

                }

            }

        }



        private void ClearCatalogSelection()

        {

            _selectedCatalogCourseId = 0;

            _appliedVoucherCode = null;

            _appliedDiscountAmount = 0m;

            lblSelCode.Text = "Mã khóa học: ---";

            lblSelRating.Text = "Đánh giá: ---";

            lblSelName.Text = "Không tìm thấy khóa học phù hợp";

            lblSelCategory.Text = "Danh mục: ---";

            lblSelInstructor.Text = "Giảng viên: ---";

            lblSelSchedule.Text = "Thời lượng: --- | Khai giảng: ---";

            lblSelClassTime.Text = "Lịch học: --- | Phòng: ---";

            lblSelSlots.Text = "Sĩ số còn trống: ---";

            lblConflictWarning.Visible = false;

            lblSelPrice.Text = "Học phí thanh toán: 0 VNĐ";

            txtSelDescription.Clear();

            btnBuyCourse.Enabled = false;

        }



        private void btnBuyCourse_Click(object sender, EventArgs e)

        {

            if (_selectedCatalogCourseId <= 0)

            {

                MessageBox.Show("Vui lòng chọn một khóa học trong danh sách để đăng ký.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            int createdEnrollmentId = 0;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User student = db.Users.FirstOrDefault(u => u.UserID == _studentId);

                Course course = db.Courses.FirstOrDefault(c => c.CourseID == _selectedCatalogCourseId && c.IsActive);



                if (student == null || course == null)

                {

                    MessageBox.Show("Khóa học hiện không còn mở đăng ký.", "Thông báo",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadCatalogCourses();

                    return;

                }



                if (db.Enrollments.Any(en => en.UserID == _studentId && en.CourseID == course.CourseID && en.Status == "Active"))

                {

                    MessageBox.Show("Bạn đã đăng ký khóa học này trước đó.", "Thông báo",

                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }



                // Kiểm tra trùng lịch lần cuối bằng LINQ

                List<ActiveScheduleItem> mySchedules = GetStudentActiveSchedules(db);

                foreach (ActiveScheduleItem item in mySchedules)

                {

                    string overlap;

                    if (ScheduleHelper.HasScheduleConflict(course.StudyDays, course.StudyShift, item.StudyDays, item.StudyShift, out overlap))

                    {

                        MessageBox.Show(

                            string.Format("Không thể đăng ký do trùng lịch học với khóa học [{0}] {1} ({2} - {3}).",

                                item.CourseCode, item.CourseName, overlap, course.StudyShift),

                            "Trùng thời khóa biểu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }

                }



                int activeCount = db.Enrollments.Count(en => en.CourseID == course.CourseID && en.Status == "Active");

                if (activeCount >= course.MaxStudents)

                {

                    MessageBox.Show("Khóa học này đã đủ sĩ số tối đa.", "Thông báo",

                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadCatalogCourses();

                    return;

                }



                // Xác thực lại mã học bổng nếu học viên có nhập

                Voucher appliedVoucher = null;

                decimal discount = 0m;

                string typedVoucher = txtVoucherCode.Text.Trim().ToUpperInvariant();

                if (!string.IsNullOrEmpty(typedVoucher))

                {

                    appliedVoucher = db.Vouchers.FirstOrDefault(v => v.VoucherCode.ToUpper() == typedVoucher);

                    string voucherErr;

                    discount = ScheduleHelper.CalculateVoucherDiscount(appliedVoucher, course.Price, out voucherErr);

                    if (!string.IsNullOrEmpty(voucherErr))

                    {

                        MessageBox.Show(voucherErr, "Mã học bổng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }

                }



                decimal finalPayable = Math.Max(0m, course.Price - discount);



                if (student.Balance < finalPayable)

                {

                    decimal missing = finalPayable - student.Balance;

                    DialogResult needTopUp = MessageBox.Show(

                        string.Format("Số dư học phí hiện tại ({0:N0} VNĐ) chưa đủ để thanh toán ({1:N0} VNĐ).\n" +

                                      "Số tiền còn thiếu: {2:N0} VNĐ.\n\n" +

                                      "Bạn có muốn chuyển đến mục \"Tài khoản học phí\" để nộp bổ sung không?",

                            student.Balance, finalPayable, missing),

                        "Số dư không đủ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (needTopUp == DialogResult.Yes)

                    {

                        decimal suggested = Math.Max(nudTopUpAmount.Minimum, Math.Ceiling(missing / 50000m) * 50000m);

                        if (suggested <= nudTopUpAmount.Maximum)

                        {

                            nudTopUpAmount.Value = suggested;

                        }

                        tabStudent.SelectedTab = tabWallet;

                    }

                    return;

                }



                string voucherLine = appliedVoucher != null

                    ? string.Format("• Miễn giảm ({0}): -{1:N0} VNĐ\n", appliedVoucher.VoucherCode, discount)

                    : string.Empty;



                DialogResult confirm = MessageBox.Show(

                    string.Format("Xác nhận đăng ký và thanh toán học phí:\n\n" +

                                  "• Khóa học: [{0}] {1}\n" +

                                  "• Lịch học: {2} ({3}) - {4}\n" +

                                  "• Học phí niêm yết: {5:N0} VNĐ\n" +

                                  "{6}" +

                                  "• Học phí thực thu: {7:N0} VNĐ\n" +

                                  "• Số dư còn lại: {8:N0} VNĐ",

                        course.CourseCode, course.CourseName,

                        ScheduleHelper.FormatDaysText(course.StudyDays), course.StudyShift, course.Room,

                        course.Price, voucherLine, finalPayable, student.Balance - finalPayable),

                    "Xác nhận đăng ký khóa học",

                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                if (confirm != DialogResult.Yes)

                {

                    return;

                }



                student.Balance -= finalPayable;

                if (appliedVoucher != null)

                {

                    appliedVoucher.UsedCount += 1;

                }



                Enrollment enrollment = new Enrollment

                {

                    UserID = student.UserID,

                    CourseID = course.CourseID,

                    EnrollDate = DateTime.Now,

                    OriginalPrice = course.Price,

                    DiscountAmount = discount,

                    VoucherCode = appliedVoucher != null ? appliedVoucher.VoucherCode : null,

                    PaidAmount = finalPayable,

                    Status = "Active",

                    Note = string.IsNullOrWhiteSpace(txtBuyNote.Text)

                        ? "Đăng ký trực tuyến trên cổng học viên"

                        : txtBuyNote.Text.Trim()

                };

                db.Enrollments.InsertOnSubmit(enrollment);



                string txDesc = appliedVoucher != null

                    ? string.Format("Thanh toán khóa học [{0}] {1} (Mã học bổng: {2})", course.CourseCode, course.CourseName, appliedVoucher.VoucherCode)

                    : string.Format("Thanh toán khóa học [{0}] {1}", course.CourseCode, course.CourseName);



                db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                {

                    UserID = student.UserID,

                    Amount = -finalPayable,

                    TransactionType = "Purchase",

                    Description = txDesc,

                    CreatedAt = DateTime.Now

                });



                db.SubmitChanges();

                createdEnrollmentId = enrollment.EnrollmentID;

            }



            txtBuyNote.Clear();

            txtVoucherCode.Clear();

            _appliedVoucherCode = null;

            _appliedDiscountAmount = 0m;



            RefreshStudentHeaderAndBalance();

            LoadCatalogCourses();

            LoadMyCourses();

            LoadTimetable();

            LoadReviewLookups();



            DialogResult viewReceipt = MessageBox.Show(

                "Đăng ký khóa học thành công!\nLịch học đã được cập nhật vào mục \"Thời khóa biểu\".\n\n" +

                "Bạn có muốn xem và in Biên lai xác nhận đăng ký ngay bây giờ không?",

                "Đăng ký thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information);



            if (viewReceipt == DialogResult.Yes && createdEnrollmentId > 0)

            {

                PreviewReceiptByEnrollmentId(createdEnrollmentId);

            }

        }



        private void CatalogFilter_Changed(object sender, EventArgs e)

        {

            LoadCatalogCourses();

        }



        private void btnCatalogReset_Click(object sender, EventArgs e)

        {

            _isLoadingCombos = true;

            txtCatalogSearch.Clear();

            if (cboCatalogCategory.Items.Count > 0)

            {

                cboCatalogCategory.SelectedIndex = 0;

            }

            cboCatalogSort.SelectedIndex = 0;

            _isLoadingCombos = false;

            LoadCatalogCourses();

        }



        #endregion



        #region 2. KHÓA HỌC ĐÃ ĐĂNG KÝ, IN BIÊN LAI & HỦY HOÀN PHÍ (LINQ)



        private void LoadMyCourses()

        {

            string kw = txtSearchMyCourse.Text.Trim().ToLower();

            string statusFilter = string.Empty;

            if (cboMyCourseStatus.SelectedIndex == 1)

            {

                statusFilter = "Active";

            }

            else if (cboMyCourseStatus.SelectedIndex == 2)

            {

                statusFilter = "Cancelled";

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Enrollment> baseMyQuery = db.Enrollments.Where(en => en.UserID == _studentId);



                int activeTotal = baseMyQuery.Count(en => en.Status == "Active");

                decimal investedTotal = baseMyQuery.Any(en => en.Status == "Active")

                    ? baseMyQuery.Where(en => en.Status == "Active").Sum(en => en.PaidAmount)

                    : 0m;

                lblMySummary.Text = string.Format("Đang theo học: {0} khóa học  |  Tổng học phí: {1:N0} VNĐ",

                    activeTotal, investedTotal);



                IQueryable<Enrollment> filtered = baseMyQuery;

                if (!string.IsNullOrEmpty(kw))

                {

                    filtered = filtered.Where(en =>

                        en.Course.CourseCode.ToLower().Contains(kw) ||

                        en.Course.CourseName.ToLower().Contains(kw) ||

                        en.Course.Instructor.ToLower().Contains(kw));

                }



                if (!string.IsNullOrEmpty(statusFilter))

                {

                    filtered = filtered.Where(en => en.Status == statusFilter);

                }



                var raw = (from en in filtered

                           orderby en.EnrollmentID descending

                           select new

                           {

                               en.EnrollmentID,

                               en.Course.CourseCode,

                               en.Course.CourseName,

                               en.Course.StudyDays,

                               en.Course.StudyShift,

                               en.Course.Room,

                               en.OriginalPrice,

                               en.DiscountAmount,

                               en.PaidAmount,

                               en.EnrollDate,

                               en.Status

                           }).ToList();



                var list = raw.Select(en => new

                {

                    en.EnrollmentID,

                    en.CourseCode,

                    en.CourseName,

                    ScheduleText = ScheduleHelper.FormatShortSchedule(en.StudyDays, en.StudyShift),

                    en.Room,

                    en.OriginalPrice,

                    en.DiscountAmount,

                    en.PaidAmount,

                    en.EnrollDate,

                    StatusDisplay = en.Status == "Active" ? "Đang theo học" : "Đã hủy"

                }).ToList();



                if (dgvMyCourses.DataSource == null) dgvMyCourses.Rows.Clear();

                myCoursesBindingSource.DataSource = list;



                if (dgvMyCourses.Columns.Count > 0)

                {

                    dgvMyCourses.Columns["colMy_EnrollmentID"].HeaderText = "Mã ĐK";

                    dgvMyCourses.Columns["colMy_EnrollmentID"].FillWeight = 52;

                    dgvMyCourses.Columns["colMy_CourseCode"].HeaderText = "Mã khóa học";

                    dgvMyCourses.Columns["colMy_CourseCode"].FillWeight = 62;

                    dgvMyCourses.Columns["colMy_CourseName"].HeaderText = "Tên khóa học";

                    dgvMyCourses.Columns["colMy_CourseName"].FillWeight = 165;

                    dgvMyCourses.Columns["colMy_ScheduleText"].HeaderText = "Lịch học";

                    dgvMyCourses.Columns["colMy_ScheduleText"].FillWeight = 105;

                    dgvMyCourses.Columns["colMy_Room"].HeaderText = "Phòng";

                    dgvMyCourses.Columns["colMy_Room"].FillWeight = 82;

                    dgvMyCourses.Columns["colMy_OriginalPrice"].HeaderText = "Học phí gốc";

                    dgvMyCourses.Columns["colMy_OriginalPrice"].DefaultCellStyle.Format = "N0";

                    dgvMyCourses.Columns["colMy_OriginalPrice"].FillWeight = 82;

                    dgvMyCourses.Columns["colMy_DiscountAmount"].HeaderText = "Miễn giảm";

                    dgvMyCourses.Columns["colMy_DiscountAmount"].DefaultCellStyle.Format = "N0";

                    dgvMyCourses.Columns["colMy_DiscountAmount"].FillWeight = 76;

                    dgvMyCourses.Columns["colMy_PaidAmount"].HeaderText = "Thực đóng";

                    dgvMyCourses.Columns["colMy_PaidAmount"].DefaultCellStyle.Format = "N0";

                    dgvMyCourses.Columns["colMy_PaidAmount"].FillWeight = 84;

                    dgvMyCourses.Columns["colMy_EnrollDate"].HeaderText = "Ngày đăng ký";

                    dgvMyCourses.Columns["colMy_EnrollDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvMyCourses.Columns["colMy_EnrollDate"].FillWeight = 80;

                    dgvMyCourses.Columns["colMy_StatusDisplay"].HeaderText = "Trạng thái";

                    dgvMyCourses.Columns["colMy_StatusDisplay"].FillWeight = 82;

                }



                if (list.Count > 0)

                {

                    PopulateMyCourseDetail(list[0].EnrollmentID);

                }

                else

                {

                    txtMyEnrollmentId.Text = "---";

                    txtMyCourseTitle.Clear();

                    lblMyEnrollInfo.Text = "Chưa có dữ liệu đăng ký khóa học phù hợp với bộ lọc hiện tại.";

                    txtMyEnrollNote.Clear();

                    btnSaveMyNote.Enabled = false;

                    btnPrintStudentReceipt.Enabled = false;

                    btnCancelMyCourse.Enabled = false;

                }

            }

        }



        private void dgvMyCourses_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvMyCourses.CurrentRow == null)

            {

                return;

            }



            int enrollId = Convert.ToInt32(dgvMyCourses.CurrentRow.Cells["colMy_EnrollmentID"].Value);

            PopulateMyCourseDetail(enrollId);

        }



        private void PopulateMyCourseDetail(int enrollId)

        {

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId && x.UserID == _studentId);

                if (en == null)

                {

                    return;

                }



                txtMyEnrollmentId.Text = en.EnrollmentID.ToString();

                txtMyCourseTitle.Text = string.Format("[{0}] {1}", en.Course.CourseCode, en.Course.CourseName);



                string voucherInfo = string.IsNullOrEmpty(en.VoucherCode)

                    ? "Không áp dụng"

                    : string.Format("{0} (-{1:N0} VNĐ)", en.VoucherCode, en.DiscountAmount);



                lblMyEnrollInfo.Text = string.Format(

                    "• Giảng viên: {0}\r\n" +

                    "• Lịch học: {1} ({2})\r\n" +

                    "• Phòng học: {3} | Khai giảng: {4:dd/MM/yyyy}\r\n" +

                    "• Học phí niêm yết: {5:N0} VNĐ\r\n" +

                    "• Học bổng / Ưu đãi: {6}\r\n" +

                    "• Học phí thực đóng: {7:N0} VNĐ\r\n" +

                    "• Trạng thái: {8}",

                    en.Course.Instructor,

                    ScheduleHelper.FormatDaysText(en.Course.StudyDays),

                    en.Course.StudyShift,

                    en.Course.Room,

                    en.Course.StartDate,

                    en.OriginalPrice,

                    voucherInfo,

                    en.PaidAmount,

                    en.Status == "Active" ? "Đang theo học" : "Đã hủy và hoàn học phí");

                txtMyEnrollNote.Text = en.Note ?? string.Empty;



                btnSaveMyNote.Enabled = true;

                btnPrintStudentReceipt.Enabled = true;

                btnCancelMyCourse.Enabled = en.Status == "Active";

            }

        }



        private void btnSaveMyNote_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtMyEnrollmentId.Text, out enrollId))

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId && x.UserID == _studentId);

                if (en != null)

                {

                    en.Note = txtMyEnrollNote.Text.Trim();

                    db.SubmitChanges();

                    MessageBox.Show("Đã lưu ghi chú học tập.", "Thông báo",

                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadMyCourses();

                }

            }

        }



        private void btnPrintStudentReceipt_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtMyEnrollmentId.Text, out enrollId))

            {

                return;

            }



            PreviewReceiptByEnrollmentId(enrollId);

        }



        private void PreviewReceiptByEnrollmentId(int enrollId)

        {

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId && x.UserID == _studentId);

                    if (en == null)

                    {

                        MessageBox.Show("Không tìm thấy thông tin đăng ký khóa học với mã #" + enrollId,

                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }



                    _currentReceiptData = new EnrollmentReceiptData

                    {

                        EnrollmentId = en.EnrollmentID,

                        EnrollDate = en.EnrollDate,

                        StudentFullName = en.User != null ? en.User.FullName : "Không xác định",

                        StudentUsername = en.User != null ? en.User.Username : string.Empty,

                        StudentEmail = en.User != null ? en.User.Email : string.Empty,

                        StudentPhone = en.User != null ? en.User.Phone : string.Empty,

                        CourseCode = en.Course != null ? en.Course.CourseCode : string.Empty,

                        CourseName = en.Course != null ? en.Course.CourseName : "Khóa học",

                        CategoryName = (en.Course != null && en.Course.Category != null) ? en.Course.Category.CategoryName : "Khác",

                        Instructor = en.Course != null ? en.Course.Instructor : "Đang cập nhật",

                        ScheduleText = en.Course != null ? (ScheduleHelper.FormatDaysText(en.Course.StudyDays) + " - " + (en.Course.StudyShift ?? string.Empty)) : "Chưa xếp lịch",

                        Room = en.Course != null ? (en.Course.Room ?? string.Empty) : string.Empty,

                        StartDate = en.Course != null ? en.Course.StartDate : DateTime.Today,

                        OriginalPrice = en.OriginalPrice,

                        DiscountAmount = en.DiscountAmount,

                        VoucherCode = en.VoucherCode ?? string.Empty,

                        PaidAmount = en.PaidAmount,

                        StatusText = en.Status == "Active" ? "Đã xác nhận đăng ký" : "Đã hủy đăng ký",

                        Note = en.Note ?? string.Empty

                    };

                }



                using (FrmReportViewer frmRpt = new FrmReportViewer())

                {

                    frmRpt.ShowReceipt(_currentReceiptData);

                    frmRpt.ShowDialog(this);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi hiển thị biên lai:\n" + ex.Message, "Thông báo lỗi",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void printDocReceipt_PrintPage(object sender, PrintPageEventArgs e)

        {

            ReceiptPrinter.DrawReceipt(e.Graphics, e.PageBounds, _currentReceiptData);

            e.HasMorePages = false;

        }



        private void btnExportMyCourses_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvMyCourses,

                saveFileStudentExcel,

                "DANH SÁCH KHÓA HỌC ĐÃ ĐĂNG KÝ",

                "KhoaHocDaDangKy");

        }



        private void btnCancelMyCourse_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtMyEnrollmentId.Text, out enrollId))

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId && x.UserID == _studentId);

                if (en == null || en.Status != "Active")

                {

                    return;

                }



                if (MessageBox.Show(

                    string.Format("Bạn có chắc chắn muốn hủy đăng ký khóa học:\n[{0}] {1}?\n\n" +

                                  "Hệ thống sẽ hoàn trả học phí thực đóng ({2:N0} VNĐ) về số dư tài khoản của bạn.",

                        en.Course.CourseCode, en.Course.CourseName, en.PaidAmount),

                    "Xác nhận hủy đăng ký",

                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)

                {

                    return;

                }



                en.Status = "Cancelled";

                en.Note = (string.IsNullOrEmpty(en.Note) ? "" : en.Note + " | ") + "Học viên hủy đăng ký";

                en.User.Balance += en.PaidAmount;



                if (!string.IsNullOrEmpty(en.VoucherCode))

                {

                    Voucher v = db.Vouchers.FirstOrDefault(x => x.VoucherCode == en.VoucherCode);

                    if (v != null && v.UsedCount > 0)

                    {

                        v.UsedCount -= 1;

                    }

                }



                db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                {

                    UserID = _studentId,

                    Amount = en.PaidAmount,

                    TransactionType = "Refund",

                    Description = string.Format("Hoàn học phí hủy khóa học [{0}] {1}", en.Course.CourseCode, en.Course.CourseName),

                    CreatedAt = DateTime.Now

                });



                db.SubmitChanges();



                RefreshStudentHeaderAndBalance();

                LoadMyCourses();

                LoadCatalogCourses();

                LoadTimetable();



                MessageBox.Show(

                    string.Format("Đã hủy đăng ký khóa học và hoàn {0:N0} VNĐ về tài khoản học phí.", en.PaidAmount),

                    "Hoàn học phí thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        private void MyCoursesFilter_Changed(object sender, EventArgs e)

        {

            LoadMyCourses();

        }



        #endregion



        #region 3. THỜI KHÓA BIỂU CÁ NHÂN THEO TUẦN (LINQ MATRIX)



        private void LoadTimetable()

        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Shift", typeof(string));

            dt.Columns.Add("D2", typeof(string));

            dt.Columns.Add("D3", typeof(string));

            dt.Columns.Add("D4", typeof(string));

            dt.Columns.Add("D5", typeof(string));

            dt.Columns.Add("D6", typeof(string));

            dt.Columns.Add("D7", typeof(string));

            dt.Columns.Add("DCN", typeof(string));



            string[] shiftLabels = ScheduleHelper.StudyShiftOptions;

            for (int i = 0; i < shiftLabels.Length; i++)

            {

                DataRow r = dt.NewRow();

                r["Shift"] = shiftLabels[i];

                for (int c = 1; c < dt.Columns.Count; c++)

                {

                    r[c] = string.Empty;

                }

                dt.Rows.Add(r);

            }



            int activeCourseCount = 0;

            int weeklySessions = 0;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                var myCourses = (from en in db.Enrollments

                                 where en.UserID == _studentId && en.Status == "Active"

                                 orderby en.Course.StartDate

                                 select new

                                 {

                                     en.Course.CourseCode,

                                     en.Course.CourseName,

                                     en.Course.Instructor,

                                     en.Course.StudyDays,

                                     en.Course.StudyShift,

                                     en.Course.Room,

                                     en.Course.StartDate

                                 }).ToList();



                activeCourseCount = myCourses.Count;



                foreach (var item in myCourses)

                {

                    int rowIndex = 2;

                    string shiftKey = ScheduleHelper.NormalizeShiftKey(item.StudyShift);

                    if (shiftKey == "SANG") rowIndex = 0;

                    else if (shiftKey == "CHIEU") rowIndex = 1;



                    List<string> days = ScheduleHelper.ParseDays(item.StudyDays);

                    foreach (string d in days)

                    {

                        string colName = "D" + d;

                        if (!dt.Columns.Contains(colName))

                        {

                            continue;

                        }



                        weeklySessions++;

                        string block = string.Format("[{0}] {1}\r\n• Phòng: {2}\r\n• GV: {3}\r\n• KG: {4:dd/MM/yyyy}",

                            item.CourseCode, item.CourseName, item.Room, item.Instructor, item.StartDate);



                        string existing = Convert.ToString(dt.Rows[rowIndex][colName]);

                        dt.Rows[rowIndex][colName] = string.IsNullOrEmpty(existing)

                            ? block

                            : existing + "\r\n---\r\n" + block;

                    }

                }

            }



            lblTimetableSummary.Text = string.Format(

                "Đang theo học: {0} khóa học  |  Tổng thời lượng trên lớp: {1} buổi/tuần",

                activeCourseCount, weeklySessions);



            if (dgvTimetable.DataSource == null) dgvTimetable.Rows.Clear();

                timetableBindingSource.DataSource = dt;



            if (dgvTimetable.Columns.Count > 0)

            {

                dgvTimetable.Columns["colTT_Shift"].HeaderText = "Ca học / Thứ";

                dgvTimetable.Columns["colTT_Shift"].FillWeight = 115;

                dgvTimetable.Columns["colTT_D2"].HeaderText = "Thứ Hai";

                dgvTimetable.Columns["colTT_D2"].FillWeight = 100;

                dgvTimetable.Columns["colTT_D3"].HeaderText = "Thứ Ba";

                dgvTimetable.Columns["colTT_D3"].FillWeight = 100;

                dgvTimetable.Columns["colTT_D4"].HeaderText = "Thứ Tư";

                dgvTimetable.Columns["colTT_D4"].FillWeight = 100;

                dgvTimetable.Columns["colTT_D5"].HeaderText = "Thứ Năm";

                dgvTimetable.Columns["colTT_D5"].FillWeight = 100;

                dgvTimetable.Columns["colTT_D6"].HeaderText = "Thứ Sáu";

                dgvTimetable.Columns["colTT_D6"].FillWeight = 100;

                dgvTimetable.Columns["colTT_D7"].HeaderText = "Thứ Bảy";

                dgvTimetable.Columns["colTT_D7"].FillWeight = 100;

                dgvTimetable.Columns["colTT_DCN"].HeaderText = "Chủ Nhật";

                dgvTimetable.Columns["colTT_DCN"].FillWeight = 100;



                foreach (DataGridViewColumn col in dgvTimetable.Columns)

                {

                    col.SortMode = DataGridViewColumnSortMode.NotSortable;

                }

            }

        }



        private void dgvTimetable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)

        {

            if (e.RowIndex < 0)

            {

                return;

            }



            if (e.ColumnIndex == 0)

            {

                e.CellStyle.BackColor = Color.FromArgb(241, 245, 249);

                e.CellStyle.ForeColor = Color.FromArgb(15, 23, 42);

                e.CellStyle.Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);

                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                return;

            }



            string text = Convert.ToString(e.Value ?? string.Empty);

            if (!string.IsNullOrWhiteSpace(text))

            {

                e.CellStyle.BackColor = Color.FromArgb(239, 246, 255);

                e.CellStyle.ForeColor = Color.FromArgb(30, 58, 138);

                e.CellStyle.Font = new Font("Segoe UI", 8.75f, FontStyle.Bold);

            }

            else

            {

                e.CellStyle.BackColor = Color.White;

            }

        }



        private void btnExportTimetable_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvTimetable,

                saveFileStudentExcel,

                "THỜI KHÓA BIỂU CÁ NHÂN HÀNG TUẦN",

                "ThoiKhoaBieuCaNhan");

        }



        #endregion



        #region 4. ĐÁNH GIÁ & PHẢN HỒI KHÓA HỌC (LINQ CRUD + AVERAGE)



        private void LoadReviewLookups()

        {

            _isLoadingCombos = true;

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    int prevWriteId = GetLookupId(cboReviewCourse);

                    int prevFilterId = GetLookupId(cboFilterReviewCourse);



                    // Các khóa học mà học viên đã từng đăng ký (Active)

                    var enrolledCourses = (from en in db.Enrollments

                                           where en.UserID == _studentId && en.Status == "Active"

                                           select en.Course)

                                          .Distinct()

                                          .OrderBy(c => c.CourseCode)

                                          .ToList();



                    cboReviewCourse.Items.Clear();

                    foreach (Course c in enrolledCourses)

                    {

                        cboReviewCourse.Items.Add(new LookupItem

                        {

                            Id = c.CourseID,

                            Name = string.Format("[{0}] {1}", c.CourseCode, c.CourseName)

                        });

                    }



                    SelectLookupById(cboReviewCourse, prevWriteId);

                    if (cboReviewCourse.SelectedIndex < 0 && cboReviewCourse.Items.Count > 0)

                    {

                        cboReviewCourse.SelectedIndex = 0;

                    }



                    bool canReview = cboReviewCourse.Items.Count > 0;

                    cboReviewCourse.Enabled = canReview;

                    cboReviewRating.Enabled = canReview;

                    txtReviewComment.Enabled = canReview;

                    btnSaveReview.Enabled = canReview;



                    // Bộ lọc tất cả khóa học bên phải

                    List<Course> allCourses = db.Courses.OrderBy(c => c.CourseCode).ToList();

                    cboFilterReviewCourse.Items.Clear();

                    cboFilterReviewCourse.Items.Add(new LookupItem { Id = 0, Name = "Tất cả khóa học" });

                    foreach (Course c in allCourses)

                    {

                        cboFilterReviewCourse.Items.Add(new LookupItem

                        {

                            Id = c.CourseID,

                            Name = string.Format("[{0}] {1}", c.CourseCode, c.CourseName)

                        });

                    }

                    SelectLookupById(cboFilterReviewCourse, prevFilterId);

                    if (cboFilterReviewCourse.SelectedIndex < 0)

                    {

                        cboFilterReviewCourse.SelectedIndex = 0;

                    }

                }

            }

            finally

            {

                _isLoadingCombos = false;

            }



            LoadMyExistingReviewForSelectedCourse();

        }



        private void cboReviewCourse_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (_isLoadingCombos)

            {

                return;

            }

            LoadMyExistingReviewForSelectedCourse();

        }



        private void LoadMyExistingReviewForSelectedCourse()

        {

            int courseId = GetLookupId(cboReviewCourse);

            if (courseId <= 0)

            {

                txtReviewComment.Clear();

                btnDeleteMyReview.Enabled = false;

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                CourseReview myRev = db.CourseReviews.FirstOrDefault(r =>

                    r.CourseID == courseId && r.UserID == _studentId);



                if (myRev != null)

                {

                    int idx = 5 - myRev.Rating;

                    if (idx < 0) idx = 0;

                    if (idx > 4) idx = 4;

                    cboReviewRating.SelectedIndex = idx;

                    txtReviewComment.Text = myRev.Comment;

                    btnDeleteMyReview.Enabled = true;

                }

                else

                {

                    cboReviewRating.SelectedIndex = 0;

                    txtReviewComment.Clear();

                    btnDeleteMyReview.Enabled = false;

                }

            }

        }



        private void LoadStudentReviews()

        {

            if (_isLoadingCombos)

            {

                return;

            }



            int filterCourseId = GetLookupId(cboFilterReviewCourse);



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<CourseReview> query = db.CourseReviews;

                if (filterCourseId > 0)

                {

                    query = query.Where(r => r.CourseID == filterCourseId);

                }



                int totalReviews = query.Count();

                double avg = totalReviews > 0 ? query.Average(r => (double)r.Rating) : 0.0;

                lblCourseAvgSummary.Text = totalReviews > 0

                    ? string.Format("Điểm trung bình: {0:0.0}/5 ★ ({1} lượt đánh giá)", avg, totalReviews)

                    : "Chưa có lượt đánh giá nào";



                var raw = (from r in query

                           orderby r.CreatedAt descending

                           select new

                           {

                               r.Course.CourseCode,

                               r.Course.CourseName,

                               StudentName = r.User.FullName,

                               r.Rating,

                               r.Comment,

                               r.CreatedAt

                           }).ToList();



                var list = raw.Select(r => new

                {

                    r.CourseCode,

                    r.CourseName,

                    r.StudentName,

                    Stars = r.Rating + "/5 ★",

                    r.Comment,

                    r.CreatedAt

                }).ToList();



                if (dgvStudentReviews.DataSource == null) dgvStudentReviews.Rows.Clear();

                studentReviewsBindingSource.DataSource = list;



                if (dgvStudentReviews.Columns.Count > 0)

                {

                    dgvStudentReviews.Columns["colStuRev_CourseCode"].HeaderText = "Mã khóa học";

                    dgvStudentReviews.Columns["colStuRev_CourseCode"].FillWeight = 62;

                    dgvStudentReviews.Columns["colStuRev_CourseName"].HeaderText = "Tên khóa học";

                    dgvStudentReviews.Columns["colStuRev_CourseName"].FillWeight = 155;

                    dgvStudentReviews.Columns["colStuRev_StudentName"].HeaderText = "Học viên";

                    dgvStudentReviews.Columns["colStuRev_StudentName"].FillWeight = 115;

                    dgvStudentReviews.Columns["colStuRev_Stars"].HeaderText = "Mức điểm";

                    dgvStudentReviews.Columns["colStuRev_Stars"].FillWeight = 72;

                    dgvStudentReviews.Columns["colStuRev_Comment"].HeaderText = "Nhận xét của học viên";

                    dgvStudentReviews.Columns["colStuRev_Comment"].FillWeight = 230;

                    dgvStudentReviews.Columns["colStuRev_CreatedAt"].HeaderText = "Ngày gửi";

                    dgvStudentReviews.Columns["colStuRev_CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvStudentReviews.Columns["colStuRev_CreatedAt"].FillWeight = 95;

                }

            }

        }



        private void cboFilterReviewCourse_SelectedIndexChanged(object sender, EventArgs e)

        {

            LoadStudentReviews();

        }



        private void btnSaveReview_Click(object sender, EventArgs e)

        {

            int courseId = GetLookupId(cboReviewCourse);

            if (courseId <= 0)

            {

                MessageBox.Show("Bạn cần đăng ký ít nhất một khóa học để gửi đánh giá.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }



            string comment = txtReviewComment.Text.Trim();

            if (string.IsNullOrEmpty(comment))

            {

                MessageBox.Show("Vui lòng nhập nội dung nhận xét cho khóa học.", "Thiếu thông tin",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtReviewComment.Focus();

                return;

            }



            int rating = 5 - Math.Max(0, cboReviewRating.SelectedIndex);



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                CourseReview existing = db.CourseReviews.FirstOrDefault(r =>

                    r.CourseID == courseId && r.UserID == _studentId);



                if (existing != null)

                {

                    existing.Rating = rating;

                    existing.Comment = comment;

                    existing.CreatedAt = DateTime.Now;

                }

                else

                {

                    db.CourseReviews.InsertOnSubmit(new CourseReview

                    {

                        CourseID = courseId,

                        UserID = _studentId,

                        Rating = rating,

                        Comment = comment,

                        CreatedAt = DateTime.Now

                    });

                }



                db.SubmitChanges();

            }



            LoadMyExistingReviewForSelectedCourse();

            LoadStudentReviews();

            LoadCatalogCourses();



            MessageBox.Show("Đã ghi nhận đánh giá khóa học của bạn.", "Cảm ơn phản hồi",

                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void btnDeleteMyReview_Click(object sender, EventArgs e)

        {

            int courseId = GetLookupId(cboReviewCourse);

            if (courseId <= 0)

            {

                return;

            }



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đánh giá của mình đối với khóa học này?",

                "Xác nhận xóa đánh giá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                CourseReview existing = db.CourseReviews.FirstOrDefault(r =>

                    r.CourseID == courseId && r.UserID == _studentId);

                if (existing != null)

                {

                    db.CourseReviews.DeleteOnSubmit(existing);

                    db.SubmitChanges();

                }

            }



            LoadMyExistingReviewForSelectedCourse();

            LoadStudentReviews();

            LoadCatalogCourses();

        }



        #endregion



        #region 5. TÀI KHOẢN HỌC PHÍ & LỊCH SỬ GIAO DỊCH (LINQ)



        private void btnTop200k_Click(object sender, EventArgs e)

        {

            nudTopUpAmount.Value = 200000;

        }



        private void btnTop500k_Click(object sender, EventArgs e)

        {

            nudTopUpAmount.Value = 500000;

        }



        private void btnTop1M_Click(object sender, EventArgs e)

        {

            nudTopUpAmount.Value = 1000000;

        }



        private void btnTop2M_Click(object sender, EventArgs e)

        {

            nudTopUpAmount.Value = 2000000;

        }



        private void btnConfirmTopUp_Click(object sender, EventArgs e)

        {

            decimal amount = nudTopUpAmount.Value;

            string method = cboPaymentMethod.SelectedItem != null

                ? cboPaymentMethod.SelectedItem.ToString()

                : "Chuyển khoản ngân hàng";

            string customNote = txtTopUpNote.Text.Trim();



            if (MessageBox.Show(

                string.Format("Xác nhận nộp {0:N0} VNĐ vào tài khoản học phí ({1})?", amount, method),

                "Xác nhận nộp học phí", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User student = db.Users.FirstOrDefault(u => u.UserID == _studentId);

                if (student == null)

                {

                    return;

                }



                student.Balance += amount;



                string desc = "Nộp học phí (" + method + ")";

                if (!string.IsNullOrEmpty(customNote))

                {

                    desc += " - " + customNote;

                }



                db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                {

                    UserID = _studentId,

                    Amount = amount,

                    TransactionType = "Deposit",

                    Description = desc,

                    CreatedAt = DateTime.Now

                });



                db.SubmitChanges();

            }



            txtTopUpNote.Clear();

            RefreshStudentHeaderAndBalance();

            LoadWalletTransactions();



            MessageBox.Show(string.Format("Đã ghi nhận nộp {0:N0} VNĐ vào tài khoản học phí.", amount),

                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void LoadWalletTransactions()

        {

            string typeFilter = string.Empty;

            if (cboFilterTxType.SelectedIndex == 1)

            {

                typeFilter = "Deposit";

            }

            else if (cboFilterTxType.SelectedIndex == 2)

            {

                typeFilter = "Purchase";

            }

            else if (cboFilterTxType.SelectedIndex == 3)

            {

                typeFilter = "Refund";

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<WalletTransaction> myAllTx = db.WalletTransactions.Where(t => t.UserID == _studentId);



                decimal totalDeposited = myAllTx.Any(t => t.Amount > 0)

                    ? myAllTx.Where(t => t.Amount > 0).Sum(t => t.Amount)

                    : 0m;

                decimal totalSpent = myAllTx.Any(t => t.Amount < 0)

                    ? myAllTx.Where(t => t.Amount < 0).Sum(t => -t.Amount)

                    : 0m;



                lblWalletStats.Text = string.Format("Tổng nộp/hoàn: +{0:N0} VNĐ  |  Đã thanh toán: -{1:N0} VNĐ",

                    totalDeposited, totalSpent);



                IQueryable<WalletTransaction> filtered = myAllTx;

                if (!string.IsNullOrEmpty(typeFilter))

                {

                    filtered = filtered.Where(t => t.TransactionType == typeFilter);

                }



                var rawList = (from t in filtered

                               orderby t.TransactionID descending

                               select new

                               {

                                   t.TransactionID,

                                   t.TransactionType,

                                   t.Amount,

                                   t.Description,

                                   t.CreatedAt

                               }).ToList();



                var list = rawList.Select(t => new

                {

                    t.TransactionID,

                    TypeLabel = FormatTransactionType(t.TransactionType),

                    t.Amount,

                    t.Description,

                    t.CreatedAt

                }).ToList();



                if (dgvMyTransactions.DataSource == null) dgvMyTransactions.Rows.Clear();

                myTransactionsBindingSource.DataSource = list;



                if (dgvMyTransactions.Columns.Count > 0)

                {

                    dgvMyTransactions.Columns["colMyTx_TransactionID"].HeaderText = "Mã GD";

                    dgvMyTransactions.Columns["colMyTx_TransactionID"].FillWeight = 60;

                    dgvMyTransactions.Columns["colMyTx_TypeLabel"].HeaderText = "Loại giao dịch";

                    dgvMyTransactions.Columns["colMyTx_TypeLabel"].FillWeight = 100;

                    dgvMyTransactions.Columns["colMyTx_Amount"].HeaderText = "Số tiền (VNĐ)";

                    dgvMyTransactions.Columns["colMyTx_Amount"].DefaultCellStyle.Format = "+#,##0;-#,##0;0";

                    dgvMyTransactions.Columns["colMyTx_Amount"].FillWeight = 95;

                    dgvMyTransactions.Columns["colMyTx_Description"].HeaderText = "Nội dung giao dịch";

                    dgvMyTransactions.Columns["colMyTx_Description"].FillWeight = 230;

                    dgvMyTransactions.Columns["colMyTx_CreatedAt"].HeaderText = "Thời gian";

                    dgvMyTransactions.Columns["colMyTx_CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvMyTransactions.Columns["colMyTx_CreatedAt"].FillWeight = 100;

                }

            }

        }



        private static string FormatTransactionType(string type)

        {

            if (type == "Deposit") return "Nộp học phí";

            if (type == "Purchase") return "Thanh toán khóa học";

            if (type == "Refund") return "Hoàn học phí";

            if (type == "Adjustment") return "Điều chỉnh số dư";

            return type;

        }



        private void cboFilterTxType_SelectedIndexChanged(object sender, EventArgs e)

        {

            LoadWalletTransactions();

        }



        private void btnExportMyTx_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvMyTransactions,

                saveFileStudentExcel,

                "LỊCH SỬ GIAO DỊCH TÀI KHOẢN HỌC PHÍ",

                "LichSuGiaoDichHocPhi");

        }



        #endregion



        #region 6. THÔNG TIN CÁ NHÂN & ĐỔI MẬT KHẨU (LINQ)



        private void LoadProfile()

        {

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == _studentId);

                if (u != null)

                {

                    txtProfileUsername.Text = u.Username;

                    txtProfileRole.Text = "Học viên";

                    txtProfileFullName.Text = u.FullName;

                    txtProfileEmail.Text = u.Email ?? string.Empty;

                    txtProfilePhone.Text = u.Phone ?? string.Empty;

                }

            }

        }



        private void btnSaveProfile_Click(object sender, EventArgs e)

        {

            string fullName = txtProfileFullName.Text.Trim();

            if (string.IsNullOrEmpty(fullName))

            {

                MessageBox.Show("Họ và tên không được để trống.", "Thiếu thông tin",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtProfileFullName.Focus();

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == _studentId);

                if (u != null)

                {

                    u.FullName = fullName;

                    u.Email = string.IsNullOrWhiteSpace(txtProfileEmail.Text) ? null : txtProfileEmail.Text.Trim();

                    u.Phone = string.IsNullOrWhiteSpace(txtProfilePhone.Text) ? null : txtProfilePhone.Text.Trim();

                    db.SubmitChanges();



                    RefreshStudentHeaderAndBalance();

                    MessageBox.Show("Cập nhật thông tin cá nhân thành công.", "Thông báo",

                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }



        private void chkProfileShowPass_CheckedChanged(object sender, EventArgs e)

        {

            bool hide = !chkProfileShowPass.Checked;

            txtOldPassword.UseSystemPasswordChar = hide;

            txtNewPassword.UseSystemPasswordChar = hide;

            txtConfirmNewPassword.UseSystemPasswordChar = hide;

        }



        private void btnChangePassword_Click(object sender, EventArgs e)

        {

            string oldPass = txtOldPassword.Text;

            string newPass = txtNewPassword.Text;

            string confirmPass = txtConfirmNewPassword.Text;



            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))

            {

                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu hiện tại và mật khẩu mới.",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (newPass.Length < 6)

            {

                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.",

                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (newPass != confirmPass)

            {

                MessageBox.Show("Mật khẩu xác nhận không trùng khớp.",

                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == _studentId);

                if (u == null)

                {

                    return;

                }



                if (!SecurityHelper.VerifyPassword(oldPass, u.Password))

                {

                    MessageBox.Show("Mật khẩu hiện tại không chính xác.",

                        "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtOldPassword.Focus();

                    return;

                }



                u.Password = SecurityHelper.HashPassword(newPass);

                db.SubmitChanges();



                txtOldPassword.Clear();

                txtNewPassword.Clear();

                txtConfirmNewPassword.Clear();



                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        #endregion



        #region Helpers



        private static int GetLookupId(ComboBox cbo)

        {

            LookupItem item = cbo.SelectedItem as LookupItem;

            return item != null ? item.Id : 0;

        }



        private static void SelectLookupById(ComboBox cbo, int id)

        {

            for (int i = 0; i < cbo.Items.Count; i++)

            {

                LookupItem item = cbo.Items[i] as LookupItem;

                if (item != null && item.Id == id)

                {

                    cbo.SelectedIndex = i;

                    return;

                }

            }

        }



        #endregion

    }

}

