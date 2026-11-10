using System;

using System.Collections.Generic;

using System.Data;

using System.Drawing;

using System.Drawing.Printing;

using System.Linq;

using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;



namespace Course_Registration

{

    public partial class FrmAdminMain : Form

    {

        private readonly int _currentAdminId;

        private bool _isLoadingCombos = false;

        private EnrollmentReceiptData _adminReceiptData = null;



        private class ComboItem

        {

            public int Id { get; set; }

            public string Text { get; set; }

            public decimal ExtraPrice { get; set; }



            public override string ToString()

            {

                return Text;

            }

        }



        public FrmAdminMain() : this(1)

        {

        }



        public FrmAdminMain(int adminUserId)
        {
            _currentAdminId = adminUserId;
            InitializeComponent();
            ConfigureGrids();
        }

        private void ConfigureGrids()
        {
            dgvCourses.AutoGenerateColumns = false;
            dgvCategories.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvEnrollments.AutoGenerateColumns = false;
            dgvVouchers.AutoGenerateColumns = false;
            dgvAdminReviews.AutoGenerateColumns = false;
            dgvCourseRevenue.AutoGenerateColumns = false;
            dgvSystemTransactions.AutoGenerateColumns = false;
        }



        private void FrmAdminMain_Load(object sender, EventArgs e)

        {

            if (DesignMode)
            {
                return;
            }

            dgvCourses.AutoGenerateColumns = false;
            dgvCategories.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvEnrollments.AutoGenerateColumns = false;
            dgvVouchers.AutoGenerateColumns = false;
            dgvAdminReviews.AutoGenerateColumns = false;
            dgvCourseRevenue.AutoGenerateColumns = false;
            dgvSystemTransactions.AutoGenerateColumns = false;



            dtpStartDate.Value = DateTime.Today.AddDays(7);

            dtpVoucherExpiry.Value = DateTime.Today.AddMonths(3);

            dtpReportFrom.Value = DateTime.Today.AddMonths(-1);

            dtpReportTo.Value = DateTime.Today;



            cboCourseDays.SelectedIndex = 0;

            cboCourseShift.SelectedIndex = 2;

            cboFilterCourseStatus.SelectedIndex = 0;

            cboUserRole.SelectedIndex = 0;

            cboFilterUserRole.SelectedIndex = 0;

            cboEnrollStatus.SelectedIndex = 0;

            cboFilterEnrollStatus.SelectedIndex = 0;

            cboFilterVoucherStatus.SelectedIndex = 0;

            cboAdminReviewStars.SelectedIndex = 0;



            LoadAdminHeader();

            LoadCategoryLookups();

            LoadCourses();

            LoadCategories();

            LoadUsers();

            LoadEnrollmentLookups();

            LoadEnrollments();

            LoadVouchers();

            LoadAdminReviewLookups();

            LoadAdminReviews();

            LoadReports();

        }



        private void LoadAdminHeader()

        {

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User admin = db.Users.FirstOrDefault(u => u.UserID == _currentAdminId);

                if (admin != null)

                {

                    string sessionTime = UserSession.IsLoggedIn
                        ? string.Format(" | Phiên: {0:HH:mm}", UserSession.CurrentUser.LoginTime)
                        : string.Empty;
                    lblAdminWelcome.Text = string.Format("Quản trị viên: {0} ({1}){2}", admin.FullName, admin.Username, sessionTime);

                }

            }

        }



        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (DesignMode)
            {
                return;
            }

            dgvCourses.AutoGenerateColumns = false;
            dgvCategories.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvEnrollments.AutoGenerateColumns = false;
            dgvVouchers.AutoGenerateColumns = false;
            dgvAdminReviews.AutoGenerateColumns = false;
            dgvCourseRevenue.AutoGenerateColumns = false;
            dgvSystemTransactions.AutoGenerateColumns = false;



            if (tabAdmin.SelectedTab == tabCourses)

            {

                LoadCategoryLookups();

                LoadCourses();

            }

            else if (tabAdmin.SelectedTab == tabCategories)

            {

                LoadCategories();

            }

            else if (tabAdmin.SelectedTab == tabUsers)

            {

                LoadUsers();

            }

            else if (tabAdmin.SelectedTab == tabEnrollments)

            {

                LoadEnrollmentLookups();

                LoadEnrollments();

            }

            else if (tabAdmin.SelectedTab == tabVouchers)

            {

                LoadVouchers();

            }

            else if (tabAdmin.SelectedTab == tabAdminReviews)

            {

                LoadAdminReviewLookups();

                LoadAdminReviews();

            }

            else if (tabAdmin.SelectedTab == tabReports)

            {

                LoadReports();

            }

        }



        private void btnAdminAbout_Click(object sender, EventArgs e)
        {
            using (var f = new FrmAbout())
            {
                f.ShowDialog(this);
            }
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống quản trị?",

                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                this.Close();

            }

        }



        #region 1. QUẢN LÝ KHÓA HỌC (CRUD + LINQ)



        private void LoadCategoryLookups()

        {

            _isLoadingCombos = true;

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    List<Category> cats = (from c in db.Categories

                                           orderby c.CategoryName

                                           select c).ToList();



                    int prevSelectedFormCat = GetSelectedComboId(cboCourseCategory);

                    int prevFilterCat = GetSelectedComboId(cboFilterCourseCategory);



                    cboCourseCategory.Items.Clear();

                    foreach (Category c in cats)

                    {

                        cboCourseCategory.Items.Add(new ComboItem { Id = c.CategoryID, Text = c.CategoryName });

                    }

                    SelectComboById(cboCourseCategory, prevSelectedFormCat);

                    if (cboCourseCategory.SelectedIndex < 0 && cboCourseCategory.Items.Count > 0)

                    {

                        cboCourseCategory.SelectedIndex = 0;

                    }



                    cboFilterCourseCategory.Items.Clear();

                    cboFilterCourseCategory.Items.Add(new ComboItem { Id = 0, Text = "Tất cả danh mục" });

                    foreach (Category c in cats)

                    {

                        cboFilterCourseCategory.Items.Add(new ComboItem { Id = c.CategoryID, Text = c.CategoryName });

                    }

                    SelectComboById(cboFilterCourseCategory, prevFilterCat);

                    if (cboFilterCourseCategory.SelectedIndex < 0)

                    {

                        cboFilterCourseCategory.SelectedIndex = 0;

                    }

                }

            }

            finally

            {

                _isLoadingCombos = false;

            }

        }



        private void LoadCourses()

        {

            if (_isLoadingCombos)

            {

                return;

            }



            string keyword = txtSearchCourse.Text.Trim().ToLower();

            int filterCatId = GetSelectedComboId(cboFilterCourseCategory);

            int statusIndex = cboFilterCourseStatus.SelectedIndex;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Course> query = db.Courses;



                if (!string.IsNullOrEmpty(keyword))

                {

                    query = query.Where(c =>

                        c.CourseCode.ToLower().Contains(keyword) ||

                        c.CourseName.ToLower().Contains(keyword) ||

                        c.Instructor.ToLower().Contains(keyword) ||

                        c.Room.ToLower().Contains(keyword));

                }



                if (filterCatId > 0)

                {

                    query = query.Where(c => c.CategoryID == filterCatId);

                }



                if (statusIndex == 1)

                {

                    query = query.Where(c => c.IsActive);

                }

                else if (statusIndex == 2)

                {

                    query = query.Where(c => !c.IsActive);

                }



                var raw = (from c in query

                           orderby c.CourseID descending

                           select new

                           {

                               c.CourseID,

                               c.CourseCode,

                               c.CourseName,

                               CategoryName = c.Category != null ? c.Category.CategoryName : "Khác",

                               c.Instructor,

                               c.StudyDays,

                               c.StudyShift,

                               c.Room,

                               c.Price,

                               EnrolledCount = c.Enrollments.Count(e => e.Status == "Active"),

                               c.MaxStudents,

                               ReviewCount = c.CourseReviews.Count(),

                               AvgStars = c.CourseReviews.Any() ? c.CourseReviews.Average(r => (double)r.Rating) : 0.0,

                               c.StartDate,

                               c.IsActive

                           }).ToList();



                var list = raw.Select(c => new

                {

                    c.CourseID,

                    c.CourseCode,

                    c.CourseName,

                    c.CategoryName,

                    c.Instructor,

                    ScheduleShort = ScheduleHelper.FormatShortSchedule(c.StudyDays, c.StudyShift),

                    c.Room,

                    c.Price,

                    EnrolledSlot = c.EnrolledCount + "/" + c.MaxStudents,

                    RatingText = ScheduleHelper.FormatStars(c.AvgStars, c.ReviewCount),

                    c.StartDate,

                    StatusText = c.IsActive ? "Đang mở" : "Ngừng ĐK"

                }).ToList();



                coursesBindingSource.DataSource = list;

                FormatCoursesGrid();

            }

        }



        private void FormatCoursesGrid()

        {

            if (dgvCourses.Columns.Count == 0)

            {

                return;

            }



            dgvCourses.Columns["colCourse_CourseID"].HeaderText = "ID";

            dgvCourses.Columns["colCourse_CourseID"].FillWeight = 38;

            dgvCourses.Columns["colCourse_CourseCode"].HeaderText = "Mã khóa học";

            dgvCourses.Columns["colCourse_CourseCode"].FillWeight = 62;

            dgvCourses.Columns["colCourse_CourseName"].HeaderText = "Tên khóa học";

            dgvCourses.Columns["colCourse_CourseName"].FillWeight = 155;

            dgvCourses.Columns["colCourse_CategoryName"].HeaderText = "Danh mục";

            dgvCourses.Columns["colCourse_CategoryName"].FillWeight = 100;

            dgvCourses.Columns["colCourse_Instructor"].HeaderText = "Giảng viên";

            dgvCourses.Columns["colCourse_Instructor"].FillWeight = 100;

            dgvCourses.Columns["colCourse_ScheduleShort"].HeaderText = "Lịch học";

            dgvCourses.Columns["colCourse_ScheduleShort"].FillWeight = 105;

            dgvCourses.Columns["colCourse_Room"].HeaderText = "Phòng";

            dgvCourses.Columns["colCourse_Room"].FillWeight = 78;

            dgvCourses.Columns["colCourse_Price"].HeaderText = "Học phí";

            dgvCourses.Columns["colCourse_Price"].DefaultCellStyle.Format = "N0";

            dgvCourses.Columns["colCourse_Price"].FillWeight = 78;

            dgvCourses.Columns["colCourse_EnrolledSlot"].HeaderText = "Sĩ số";

            dgvCourses.Columns["colCourse_EnrolledSlot"].FillWeight = 55;

            dgvCourses.Columns["colCourse_RatingText"].HeaderText = "Đánh giá";

            dgvCourses.Columns["colCourse_RatingText"].FillWeight = 78;

            dgvCourses.Columns["colCourse_StartDate"].HeaderText = "Khai giảng";

            dgvCourses.Columns["colCourse_StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvCourses.Columns["colCourse_StartDate"].FillWeight = 78;

            dgvCourses.Columns["colCourse_StatusText"].HeaderText = "Trạng thái";

            dgvCourses.Columns["colCourse_StatusText"].FillWeight = 72;

        }



        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvCourses.CurrentRow == null)

            {

                return;

            }



            int courseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["colCourse_CourseID"].Value);

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Course c = db.Courses.FirstOrDefault(x => x.CourseID == courseId);

                if (c != null)

                {

                    txtCourseId.Text = c.CourseID.ToString();

                    txtCourseCode.Text = c.CourseCode;

                    txtCourseName.Text = c.CourseName;

                    SelectComboById(cboCourseCategory, c.CategoryID);

                    txtInstructor.Text = c.Instructor;

                    nudCoursePrice.Value = ClampDecimal(c.Price, nudCoursePrice.Minimum, nudCoursePrice.Maximum);

                    nudDurationHours.Value = ClampDecimal(c.DurationHours, nudDurationHours.Minimum, nudDurationHours.Maximum);

                    nudMaxStudents.Value = ClampDecimal(c.MaxStudents, nudMaxStudents.Minimum, nudMaxStudents.Maximum);

                    dtpStartDate.Value = c.StartDate;

                    SelectComboString(cboCourseDays, c.StudyDays);

                    SelectComboString(cboCourseShift, c.StudyShift);

                    txtCourseRoom.Text = c.Room ?? string.Empty;

                    chkCourseActive.Checked = c.IsActive;

                    txtCourseDesc.Text = c.Description ?? string.Empty;

                }

            }

        }



        private bool ValidateCourseScheduleConflict(

            CourseRegistrationDataContext db,

            int excludeCourseId,

            string instructor,

            string studyDays,

            string studyShift,

            string room,

            bool isActive)

        {

            if (!isActive)

            {

                return true;

            }



            List<Course> otherActiveCourses = db.Courses

                .Where(x => x.IsActive && x.CourseID != excludeCourseId)

                .ToList();



            string normRoom = (room ?? string.Empty).Trim().ToLowerInvariant();

            bool isOnlineRoom = normRoom.Contains("trực tuyến") || normRoom.Contains("online");



            foreach (Course other in otherActiveCourses)

            {

                string overlap;

                if (!ScheduleHelper.HasScheduleConflict(studyDays, studyShift, other.StudyDays, other.StudyShift, out overlap))

                {

                    continue;

                }



                if (string.Equals(other.Instructor.Trim(), instructor.Trim(), StringComparison.OrdinalIgnoreCase))

                {

                    MessageBox.Show(

                        string.Format("Giảng viên \"{0}\" đã có lịch giảng dạy khóa học [{1}] {2} vào {3} ({4}).\nVui lòng chọn ca học hoặc thứ học khác.",

                            instructor, other.CourseCode, other.CourseName, overlap, studyShift),

                        "Trùng lịch giảng dạy của giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;

                }



                if (!isOnlineRoom && string.Equals(other.Room.Trim(), room.Trim(), StringComparison.OrdinalIgnoreCase))

                {

                    MessageBox.Show(

                        string.Format("Phòng học \"{0}\" đã được bố trí cho khóa học [{1}] {2} vào {3} ({4}).\nVui lòng chọn phòng học hoặc ca học khác.",

                            room, other.CourseCode, other.CourseName, overlap, studyShift),

                        "Trùng phòng học", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;

                }

            }



            return true;

        }



        private void btnCourseAdd_Click(object sender, EventArgs e)

        {

            string code = txtCourseCode.Text.Trim().ToUpper();

            string name = txtCourseName.Text.Trim();

            string instructor = txtInstructor.Text.Trim();

            string room = txtCourseRoom.Text.Trim();

            string studyDays = cboCourseDays.SelectedItem != null ? cboCourseDays.SelectedItem.ToString() : "2,4,6";

            string studyShift = cboCourseShift.SelectedItem != null ? cboCourseShift.SelectedItem.ToString() : "Ca tối (18:00 - 20:30)";

            int categoryId = GetSelectedComboId(cboCourseCategory);



            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(instructor) || string.IsNullOrEmpty(room) || categoryId <= 0)

            {

                MessageBox.Show("Vui lòng nhập đầy đủ mã khóa học, tên khóa học, danh mục, giảng viên và phòng học.",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                if (db.Courses.Any(x => x.CourseCode.ToLower() == code.ToLower()))

                {

                    MessageBox.Show("Mã khóa học \"" + code + "\" đã tồn tại. Vui lòng nhập mã khác.",

                        "Trùng mã khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtCourseCode.Focus();

                    return;

                }



                if (!ValidateCourseScheduleConflict(db, 0, instructor, studyDays, studyShift, room, chkCourseActive.Checked))

                {

                    return;

                }



                Course newCourse = new Course

                {

                    CourseCode = code,

                    CourseName = name,

                    CategoryID = categoryId,

                    Instructor = instructor,

                    Price = nudCoursePrice.Value,

                    DurationHours = (int)nudDurationHours.Value,

                    MaxStudents = (int)nudMaxStudents.Value,

                    StartDate = dtpStartDate.Value.Date,

                    StudyDays = studyDays,

                    StudyShift = studyShift,

                    Room = room,

                    Description = txtCourseDesc.Text.Trim(),

                    IsActive = chkCourseActive.Checked

                };



                db.Courses.InsertOnSubmit(newCourse);

                db.SubmitChanges();



                MessageBox.Show("Thêm mới khóa học thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearCourseForm();

                LoadCourses();

                LoadEnrollmentLookups();

                LoadAdminReviewLookups();

            }

        }



        private void btnCourseUpdate_Click(object sender, EventArgs e)

        {

            int courseId;

            if (!int.TryParse(txtCourseId.Text, out courseId))

            {

                MessageBox.Show("Vui lòng chọn một khóa học trong danh sách trước khi cập nhật.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            string code = txtCourseCode.Text.Trim().ToUpper();

            string name = txtCourseName.Text.Trim();

            string instructor = txtInstructor.Text.Trim();

            string room = txtCourseRoom.Text.Trim();

            string studyDays = cboCourseDays.SelectedItem != null ? cboCourseDays.SelectedItem.ToString() : "2,4,6";

            string studyShift = cboCourseShift.SelectedItem != null ? cboCourseShift.SelectedItem.ToString() : "Ca tối (18:00 - 20:30)";

            int categoryId = GetSelectedComboId(cboCourseCategory);



            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(instructor) || string.IsNullOrEmpty(room) || categoryId <= 0)

            {

                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc (*).",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Course existing = db.Courses.FirstOrDefault(x => x.CourseID == courseId);

                if (existing == null)

                {

                    MessageBox.Show("Không tìm thấy khóa học cần cập nhật.", "Lỗi dữ liệu",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }



                if (db.Courses.Any(x => x.CourseID != courseId && x.CourseCode.ToLower() == code.ToLower()))

                {

                    MessageBox.Show("Mã khóa học \"" + code + "\" đã được sử dụng cho khóa học khác.",

                        "Trùng mã khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                if (!ValidateCourseScheduleConflict(db, courseId, instructor, studyDays, studyShift, room, chkCourseActive.Checked))

                {

                    return;

                }



                existing.CourseCode = code;

                existing.CourseName = name;

                existing.CategoryID = categoryId;

                existing.Instructor = instructor;

                existing.Price = nudCoursePrice.Value;

                existing.DurationHours = (int)nudDurationHours.Value;

                existing.MaxStudents = (int)nudMaxStudents.Value;

                existing.StartDate = dtpStartDate.Value.Date;

                existing.StudyDays = studyDays;

                existing.StudyShift = studyShift;

                existing.Room = room;

                existing.Description = txtCourseDesc.Text.Trim();

                existing.IsActive = chkCourseActive.Checked;



                db.SubmitChanges();



                MessageBox.Show("Cập nhật thông tin khóa học thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCourses();

                LoadEnrollmentLookups();

                LoadAdminReviewLookups();

            }

        }



        private void btnCourseDelete_Click(object sender, EventArgs e)

        {

            int courseId;

            if (!int.TryParse(txtCourseId.Text, out courseId))

            {

                MessageBox.Show("Vui lòng chọn một khóa học trong danh sách để xóa.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Course target = db.Courses.FirstOrDefault(x => x.CourseID == courseId);

                if (target == null)

                {

                    return;

                }



                int enrollCount = db.Enrollments.Count(en => en.CourseID == courseId);

                if (enrollCount > 0)

                {

                    DialogResult dr = MessageBox.Show(

                        string.Format("Khóa học \"{0}\" hiện có {1} lượt đăng ký trong hệ thống.\n\n" +

                                      "• Chọn [Yes] để xóa vĩnh viễn khóa học và toàn bộ lịch sử đăng ký liên quan.\n" +

                                      "• Chọn [No] để chỉ chuyển sang trạng thái \"Ngừng đăng ký\" (giữ lại lịch sử).\n" +

                                      "• Chọn [Cancel] để hủy thao tác.",

                            target.CourseName, enrollCount),

                        "Xác nhận xóa khóa học",

                        MessageBoxButtons.YesNoCancel,

                        MessageBoxIcon.Warning);



                    if (dr == DialogResult.Cancel)

                    {

                        return;

                    }



                    if (dr == DialogResult.No)

                    {

                        target.IsActive = false;

                        db.SubmitChanges();

                        chkCourseActive.Checked = false;

                        MessageBox.Show("Đã chuyển khóa học sang trạng thái ngừng đăng ký.", "Thông báo",

                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadCourses();

                        return;

                    }



                    List<Enrollment> relatedEnrollments = db.Enrollments.Where(en => en.CourseID == courseId).ToList();

                    db.Enrollments.DeleteAllOnSubmit(relatedEnrollments);

                }

                else

                {

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học \"" + target.CourseName + "\"?",

                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)

                    {

                        return;

                    }

                }



                db.CourseReviews.DeleteAllOnSubmit(db.CourseReviews.Where(r => r.CourseID == courseId));

                db.Courses.DeleteOnSubmit(target);

                db.SubmitChanges();



                MessageBox.Show("Xóa khóa học thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearCourseForm();

                LoadCourses();

                LoadEnrollmentLookups();

                LoadAdminReviewLookups();

            }

        }



        private void btnExportCourses_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvCourses,

                saveFileAdminExcel,

                "DANH SÁCH KHÓA HỌC & LỊCH GIẢNG DẠY",

                "DanhSachKhoaHoc");

        }



        private void btnCourseClear_Click(object sender, EventArgs e)

        {

            ClearCourseForm();

        }



        private void ClearCourseForm()

        {

            txtCourseId.Text = "Tự động";

            txtCourseCode.Clear();

            txtCourseName.Clear();

            if (cboCourseCategory.Items.Count > 0)

            {

                cboCourseCategory.SelectedIndex = 0;

            }

            txtInstructor.Clear();

            nudCoursePrice.Value = 750000;

            nudDurationHours.Value = 45;

            nudMaxStudents.Value = 35;

            dtpStartDate.Value = DateTime.Today.AddDays(7);

            if (cboCourseDays.Items.Count > 0) cboCourseDays.SelectedIndex = 0;

            if (cboCourseShift.Items.Count > 2) cboCourseShift.SelectedIndex = 2;

            txtCourseRoom.Text = "Phòng Lab A201";

            chkCourseActive.Checked = true;

            txtCourseDesc.Clear();

            txtCourseCode.Focus();

        }



        private void CourseFilter_Changed(object sender, EventArgs e)

        {

            LoadCourses();

        }



        private void btnResetCourseFilter_Click(object sender, EventArgs e)

        {

            _isLoadingCombos = true;

            txtSearchCourse.Clear();

            if (cboFilterCourseCategory.Items.Count > 0)

            {

                cboFilterCourseCategory.SelectedIndex = 0;

            }

            cboFilterCourseStatus.SelectedIndex = 0;

            _isLoadingCombos = false;

            LoadCourses();

        }



        #endregion



        #region 2. QUẢN LÝ DANH MỤC KHÓA HỌC (CRUD + LINQ)



        private void LoadCategories()

        {

            string kw = txtSearchCategory.Text.Trim().ToLower();



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                var query = from cat in db.Categories

                            where kw == "" || cat.CategoryName.ToLower().Contains(kw) ||

                                  (cat.Description != null && cat.Description.ToLower().Contains(kw))

                            orderby cat.CategoryID

                            select new

                            {

                                cat.CategoryID,

                                cat.CategoryName,

                                cat.Description,

                                TotalCourses = cat.Courses.Count()

                            };



                categoriesBindingSource.DataSource = query.ToList();



                if (dgvCategories.Columns.Count > 0)

                {

                    dgvCategories.Columns["colCat_CategoryID"].HeaderText = "Mã danh mục";

                    dgvCategories.Columns["colCat_CategoryID"].FillWeight = 65;

                    dgvCategories.Columns["colCat_CategoryName"].HeaderText = "Tên danh mục";

                    dgvCategories.Columns["colCat_CategoryName"].FillWeight = 160;

                    dgvCategories.Columns["colCat_Description"].HeaderText = "Mô tả";

                    dgvCategories.Columns["colCat_Description"].FillWeight = 230;

                    dgvCategories.Columns["colCat_TotalCourses"].HeaderText = "Số lượng khóa học";

                    dgvCategories.Columns["colCat_TotalCourses"].FillWeight = 85;

                }

            }

        }



        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvCategories.CurrentRow == null)

            {

                return;

            }



            txtCategoryId.Text = dgvCategories.CurrentRow.Cells["colCat_CategoryID"].Value.ToString();

            txtCategoryName.Text = Convert.ToString(dgvCategories.CurrentRow.Cells["colCat_CategoryName"].Value);

            txtCategoryDesc.Text = Convert.ToString(dgvCategories.CurrentRow.Cells["colCat_Description"].Value);

        }



        private void btnCatAdd_Click(object sender, EventArgs e)

        {

            string name = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(name))

            {

                MessageBox.Show("Vui lòng nhập tên danh mục khóa học.", "Thiếu thông tin",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCategoryName.Focus();

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                if (db.Categories.Any(c => c.CategoryName.ToLower() == name.ToLower()))

                {

                    MessageBox.Show("Tên danh mục này đã tồn tại trong hệ thống.", "Trùng danh mục",

                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                Category cat = new Category

                {

                    CategoryName = name,

                    Description = txtCategoryDesc.Text.Trim()

                };



                db.Categories.InsertOnSubmit(cat);

                db.SubmitChanges();



                MessageBox.Show("Thêm mới danh mục thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearCategoryForm();

                LoadCategories();

                LoadCategoryLookups();

            }

        }



        private void btnCatUpdate_Click(object sender, EventArgs e)

        {

            int catId;

            if (!int.TryParse(txtCategoryId.Text, out catId))

            {

                MessageBox.Show("Vui lòng chọn một danh mục trong danh sách trước khi cập nhật.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            string name = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(name))

            {

                MessageBox.Show("Tên danh mục không được để trống.", "Thiếu thông tin",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == catId);

                if (cat == null)

                {

                    return;

                }



                cat.CategoryName = name;

                cat.Description = txtCategoryDesc.Text.Trim();

                db.SubmitChanges();



                MessageBox.Show("Cập nhật danh mục thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCategories();

                LoadCategoryLookups();

            }

        }



        private void btnCatDelete_Click(object sender, EventArgs e)

        {

            int catId;

            if (!int.TryParse(txtCategoryId.Text, out catId))

            {

                MessageBox.Show("Vui lòng chọn một danh mục trong danh sách để xóa.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == catId);

                if (cat == null)

                {

                    return;

                }



                int countCourses = db.Courses.Count(c => c.CategoryID == catId);

                if (countCourses > 0)

                {

                    MessageBox.Show(

                        string.Format("Danh mục \"{0}\" đang có {1} khóa học trực thuộc.\nVui lòng chuyển hoặc xóa các khóa học thuộc danh mục này trước.",

                            cat.CategoryName, countCourses),

                        "Không thể xóa danh mục", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục \"" + cat.CategoryName + "\"?",

                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    db.Categories.DeleteOnSubmit(cat);

                    db.SubmitChanges();

                    ClearCategoryForm();

                    LoadCategories();

                    LoadCategoryLookups();

                }

            }

        }



        private void btnCatClear_Click(object sender, EventArgs e)

        {

            ClearCategoryForm();

        }



        private void ClearCategoryForm()

        {

            txtCategoryId.Text = "Tự động";

            txtCategoryName.Clear();

            txtCategoryDesc.Clear();

            txtCategoryName.Focus();

        }



        private void txtSearchCategory_TextChanged(object sender, EventArgs e)

        {

            LoadCategories();

        }



        private void btnResetCatFilter_Click(object sender, EventArgs e)

        {

            txtSearchCategory.Clear();

            LoadCategories();

        }



        #endregion



        #region 3. QUẢN LÝ TÀI KHOẢN & PHÂN QUYỀN (CRUD + LINQ)



        private void LoadUsers()

        {

            string kw = txtSearchUser.Text.Trim().ToLower();

            string roleFilter = string.Empty;

            if (cboFilterUserRole.SelectedIndex == 1)

            {

                roleFilter = "Admin";

            }

            else if (cboFilterUserRole.SelectedIndex == 2)

            {

                roleFilter = "Student";

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<User> query = db.Users;



                if (!string.IsNullOrEmpty(kw))

                {

                    query = query.Where(u =>

                        u.Username.ToLower().Contains(kw) ||

                        u.FullName.ToLower().Contains(kw) ||

                        (u.Email != null && u.Email.ToLower().Contains(kw)) ||

                        (u.Phone != null && u.Phone.Contains(kw)));

                }



                if (!string.IsNullOrEmpty(roleFilter))

                {

                    query = query.Where(u => u.Role == roleFilter);

                }



                var list = (from u in query

                            orderby u.Role, u.UserID descending

                            select new

                            {

                                u.UserID,

                                u.Username,

                                u.FullName,

                                RoleDisplay = u.Role == "Admin" ? "Quản trị viên" : "Học viên",

                                u.Email,

                                u.Phone,

                                u.Balance,

                                BoughtCount = u.Enrollments.Count(en => en.Status == "Active"),

                                StatusText = u.IsActive ? "Đang hoạt động" : "Đã khóa",

                                u.CreatedAt

                            }).ToList();



                usersBindingSource.DataSource = list;



                if (dgvUsers.Columns.Count > 0)

                {

                    dgvUsers.Columns["colUser_UserID"].HeaderText = "Mã số";

                    dgvUsers.Columns["colUser_UserID"].FillWeight = 45;

                    dgvUsers.Columns["colUser_Username"].HeaderText = "Tên đăng nhập";

                    dgvUsers.Columns["colUser_Username"].FillWeight = 90;

                    dgvUsers.Columns["colUser_FullName"].HeaderText = "Họ và tên";

                    dgvUsers.Columns["colUser_FullName"].FillWeight = 135;

                    dgvUsers.Columns["colUser_RoleDisplay"].HeaderText = "Vai trò";

                    dgvUsers.Columns["colUser_RoleDisplay"].FillWeight = 95;

                    dgvUsers.Columns["colUser_Email"].HeaderText = "Email";

                    dgvUsers.Columns["colUser_Email"].FillWeight = 125;

                    dgvUsers.Columns["colUser_Phone"].HeaderText = "Số điện thoại";

                    dgvUsers.Columns["colUser_Phone"].FillWeight = 88;

                    dgvUsers.Columns["colUser_Balance"].HeaderText = "Số dư (VNĐ)";

                    dgvUsers.Columns["colUser_Balance"].DefaultCellStyle.Format = "N0";

                    dgvUsers.Columns["colUser_Balance"].FillWeight = 90;

                    dgvUsers.Columns["colUser_BoughtCount"].HeaderText = "Khóa đã đăng ký";

                    dgvUsers.Columns["colUser_BoughtCount"].FillWeight = 80;

                    dgvUsers.Columns["colUser_StatusText"].HeaderText = "Trạng thái";

                    dgvUsers.Columns["colUser_StatusText"].FillWeight = 85;

                    if (dgvUsers.Columns["colUser_CreatedAt"] != null)

                    {

                        dgvUsers.Columns["colUser_CreatedAt"].HeaderText = "Ngày tạo";

                        dgvUsers.Columns["colUser_CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

                        dgvUsers.Columns["colUser_CreatedAt"].FillWeight = 80;

                    }

                }

            }

        }



        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvUsers.CurrentRow == null)

            {

                return;

            }



            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colUser_UserID"].Value);

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == userId);

                if (u != null)

                {

                    txtUserId.Text = u.UserID.ToString();

                    cboUserRole.SelectedIndex = u.Role == "Admin" ? 1 : 0;

                    txtUserUsername.Text = u.Username;

                    txtUserPassword.Text = "••••••••"; // Giữ bảo mật tuyệt đối, không hiển thị mật khẩu của học viên

                    txtUserFullName.Text = u.FullName;

                    txtUserEmail.Text = u.Email ?? string.Empty;

                    txtUserPhone.Text = u.Phone ?? string.Empty;

                    nudUserBalance.Value = ClampDecimal(u.Balance, nudUserBalance.Minimum, nudUserBalance.Maximum);

                    chkUserActive.Checked = u.IsActive;

                    // Bảo vệ tài khoản: Không cho phép tự xóa, tự hạ vai trò hoặc tự khóa chính mình
                    bool isSelf = (u.UserID == _currentAdminId);
                    btnUserDelete.Enabled = !isSelf;
                    cboUserRole.Enabled = !isSelf;
                    chkUserActive.Enabled = !isSelf;

                }

            }

        }



        private void btnUserAdd_Click(object sender, EventArgs e)

        {

            string username = txtUserUsername.Text.Trim();

            string password = txtUserPassword.Text;

            string fullName = txtUserFullName.Text.Trim();

            string role = cboUserRole.SelectedIndex == 1 ? "Admin" : "Student";



            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || password == "••••••••" || string.IsNullOrEmpty(fullName))

            {

                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập, mật khẩu và họ tên.",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                if (db.Users.Any(x => x.Username.ToLower() == username.ToLower()))

                {

                    MessageBox.Show("Tên đăng nhập \"" + username + "\" đã tồn tại.",

                        "Trùng tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                User u = new User

                {

                    Username = username,

                    Password = SecurityHelper.HashPassword(password),

                    FullName = fullName,

                    Email = string.IsNullOrWhiteSpace(txtUserEmail.Text) ? null : txtUserEmail.Text.Trim(),

                    Phone = string.IsNullOrWhiteSpace(txtUserPhone.Text) ? null : txtUserPhone.Text.Trim(),

                    Role = role,

                    Balance = nudUserBalance.Value,

                    IsActive = chkUserActive.Checked,

                    CreatedAt = DateTime.Now

                };



                db.Users.InsertOnSubmit(u);

                db.SubmitChanges();



                if (u.Balance > 0)

                {

                    db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                    {

                        UserID = u.UserID,

                        Amount = u.Balance,

                        TransactionType = "Deposit",

                        Description = "Quản trị viên cấp số dư ban đầu khi mở tài khoản",

                        CreatedAt = DateTime.Now

                    });

                    db.SubmitChanges();

                }



                MessageBox.Show("Thêm mới tài khoản thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUserForm();

                LoadUsers();

                LoadEnrollmentLookups();

            }

        }



        private void btnUserUpdate_Click(object sender, EventArgs e)

        {

            int userId;

            if (!int.TryParse(txtUserId.Text, out userId))

            {

                MessageBox.Show("Vui lòng chọn một tài khoản trong danh sách trước khi cập nhật.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            string username = txtUserUsername.Text.Trim();

            string password = txtUserPassword.Text;

            string fullName = txtUserFullName.Text.Trim();

            string role = cboUserRole.SelectedIndex == 1 ? "Admin" : "Student";



            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName))

            {

                MessageBox.Show("Tên đăng nhập, mật khẩu và họ tên không được để trống.",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (userId == _currentAdminId && (role != "Admin" || !chkUserActive.Checked))

            {

                MessageBox.Show("Không thể hạ vai trò hoặc khóa chính tài khoản quản trị viên đang đăng nhập.",

                    "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == userId);

                if (u == null)

                {

                    return;

                }

                // Bảo vệ Quản trị viên cuối cùng: Không cho phép hạ vai trò hoặc khóa tài khoản Admin duy nhất
                if (u.Role == "Admin" && (role != "Admin" || !chkUserActive.Checked))
                {
                    int otherActiveAdmins = db.Users.Count(x => x.Role == "Admin" && x.IsActive && x.UserID != u.UserID);
                    if (otherActiveAdmins < 1)
                    {
                        MessageBox.Show("Đây là tài khoản Quản trị viên duy nhất đang hoạt động trong hệ thống.\n\n" +
                            "Hệ thống bắt buộc phải duy trì tối thiểu 01 Quản trị viên kích hoạt để tránh mất quyền quản trị vĩnh viễn.",
                            "Bảo vệ an toàn hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }





                if (db.Users.Any(x => x.UserID != userId && x.Username.ToLower() == username.ToLower()))

                {

                    MessageBox.Show("Tên đăng nhập này đã được sử dụng bởi tài khoản khác.",

                        "Trùng tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                decimal diff = nudUserBalance.Value - u.Balance;



                u.Username = username;

                if (!string.IsNullOrEmpty(password) && password != "••••••••" && password != u.Password)
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Dữ liệu không hợp lệ",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserPassword.Focus();
                        return;
                    }
                    u.Password = SecurityHelper.HashPassword(password);
                }

                u.FullName = fullName;

                u.Email = string.IsNullOrWhiteSpace(txtUserEmail.Text) ? null : txtUserEmail.Text.Trim();

                u.Phone = string.IsNullOrWhiteSpace(txtUserPhone.Text) ? null : txtUserPhone.Text.Trim();

                u.Role = role;

                u.Balance = nudUserBalance.Value;

                u.IsActive = chkUserActive.Checked;



                if (diff != 0)

                {

                    db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                    {

                        UserID = u.UserID,

                        Amount = diff,

                        TransactionType = diff > 0 ? "Deposit" : "Adjustment",

                        Description = string.Format("Quản trị viên điều chỉnh số dư ({0:+#,##0;-#,##0} VNĐ)", diff),

                        CreatedAt = DateTime.Now

                    });

                }



                db.SubmitChanges();

                LoadAdminHeader();



                MessageBox.Show("Cập nhật thông tin tài khoản thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();

                LoadEnrollmentLookups();

            }

        }



        private void btnUserDelete_Click(object sender, EventArgs e)

        {

            int userId;

            if (!int.TryParse(txtUserId.Text, out userId))

            {

                MessageBox.Show("Vui lòng chọn một tài khoản trong danh sách để xóa.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (userId == _currentAdminId)

            {

                MessageBox.Show("Không thể xóa tài khoản quản trị viên đang đăng nhập.\n\n" +
                    "Bạn không thể tự xóa chính tài khoản quản trị của mình.",

                    "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User u = db.Users.FirstOrDefault(x => x.UserID == userId);

                if (u == null)

                {

                    return;

                }

                // Bảo vệ Quản trị viên duy nhất: Tuyệt đối không cho xóa nếu chỉ còn duy nhất 01 Quản trị viên
                if (u.Role == "Admin")
                {
                    int activeAdminCount = db.Users.Count(x => x.Role == "Admin" && x.IsActive);
                    if (activeAdminCount <= 1)
                    {
                        MessageBox.Show("Đây là tài khoản Quản trị viên duy nhất đang hoạt động trong hệ thống.\n\n" +
                            "Hệ thống bắt buộc phải duy trì tối thiểu 01 Quản trị viên để tránh việc mất quyền quản trị vĩnh viễn.",
                            "Bảo vệ an toàn hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }





                if (MessageBox.Show(

                    string.Format("Bạn có chắc chắn muốn xóa tài khoản \"{0} - {1}\" cùng toàn bộ lịch sử liên quan?",

                        u.Username, u.FullName),

                    "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)

                {

                    return;

                }



                db.CourseReviews.DeleteAllOnSubmit(db.CourseReviews.Where(r => r.UserID == userId));

                db.Enrollments.DeleteAllOnSubmit(db.Enrollments.Where(en => en.UserID == userId));

                db.WalletTransactions.DeleteAllOnSubmit(db.WalletTransactions.Where(tx => tx.UserID == userId));

                db.Users.DeleteOnSubmit(u);

                db.SubmitChanges();



                MessageBox.Show("Xóa tài khoản thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUserForm();

                LoadUsers();

                LoadEnrollmentLookups();

            }

        }



        private void btnUserClear_Click(object sender, EventArgs e)

        {

            ClearUserForm();

        }



        private void ClearUserForm()

        {

            txtUserId.Text = "Tự động";

            cboUserRole.SelectedIndex = 0;

            txtUserUsername.Clear();

            txtUserPassword.Clear();

            txtUserFullName.Clear();

            txtUserEmail.Clear();

            txtUserPhone.Clear();

            nudUserBalance.Value = 0;

            chkUserActive.Checked = true;

            btnUserDelete.Enabled = true;
            cboUserRole.Enabled = true;
            chkUserActive.Enabled = true;

            txtUserUsername.Focus();

        }



        private void UserFilter_Changed(object sender, EventArgs e)

        {

            LoadUsers();

        }



        private void btnResetUserFilter_Click(object sender, EventArgs e)

        {

            txtSearchUser.Clear();

            cboFilterUserRole.SelectedIndex = 0;

            LoadUsers();

        }



        #endregion



        #region 4. QUẢN LÝ ĐĂNG KÝ KHÓA HỌC (CRUD + LINQ)



        private void LoadEnrollmentLookups()

        {

            _isLoadingCombos = true;

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    int prevStudent = GetSelectedComboId(cboEnrollStudent);

                    int prevCourse = GetSelectedComboId(cboEnrollCourse);



                    List<User> students = (from u in db.Users

                                           where u.Role == "Student" && u.IsActive

                                           orderby u.FullName

                                           select u).ToList();



                    cboEnrollStudent.Items.Clear();

                    foreach (User s in students)

                    {

                        cboEnrollStudent.Items.Add(new ComboItem

                        {

                            Id = s.UserID,

                            Text = string.Format("{0} ({1}) - Số dư: {2:N0} VNĐ", s.FullName, s.Username, s.Balance)

                        });

                    }

                    SelectComboById(cboEnrollStudent, prevStudent);

                    if (cboEnrollStudent.SelectedIndex < 0 && cboEnrollStudent.Items.Count > 0)

                    {

                        cboEnrollStudent.SelectedIndex = 0;

                    }



                    List<Course> courses = (from c in db.Courses

                                            orderby c.CourseName

                                            select c).ToList();



                    cboEnrollCourse.Items.Clear();

                    foreach (Course c in courses)

                    {

                        cboEnrollCourse.Items.Add(new ComboItem

                        {

                            Id = c.CourseID,

                            Text = string.Format("[{0}] {1} ({2:N0} VNĐ)", c.CourseCode, c.CourseName, c.Price),

                            ExtraPrice = c.Price

                        });

                    }

                    SelectComboById(cboEnrollCourse, prevCourse);

                    if (cboEnrollCourse.SelectedIndex < 0 && cboEnrollCourse.Items.Count > 0)

                    {

                        cboEnrollCourse.SelectedIndex = 0;

                        ComboItem firstCourse = cboEnrollCourse.SelectedItem as ComboItem;

                        if (firstCourse != null && txtEnrollmentId.Text == "Tự động")

                        {

                            nudEnrollPaid.Value = ClampDecimal(firstCourse.ExtraPrice, nudEnrollPaid.Minimum, nudEnrollPaid.Maximum);

                        }

                    }

                }

            }

            finally

            {

                _isLoadingCombos = false;

            }

        }



        private void cboEnrollCourse_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (_isLoadingCombos)

            {

                return;

            }



            if (txtEnrollmentId.Text == "Tự động")

            {

                ComboItem item = cboEnrollCourse.SelectedItem as ComboItem;

                if (item != null)

                {

                    nudEnrollPaid.Value = ClampDecimal(item.ExtraPrice, nudEnrollPaid.Minimum, nudEnrollPaid.Maximum);

                }

            }

        }



        private void LoadEnrollments()

        {

            string kw = txtSearchEnroll.Text.Trim().ToLower();

            string statusFilter = string.Empty;

            if (cboFilterEnrollStatus.SelectedIndex == 1)

            {

                statusFilter = "Active";

            }

            else if (cboFilterEnrollStatus.SelectedIndex == 2)

            {

                statusFilter = "Cancelled";

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Enrollment> query = db.Enrollments;



                if (!string.IsNullOrEmpty(kw))

                {

                    query = query.Where(en =>

                        en.User.FullName.ToLower().Contains(kw) ||

                        en.User.Username.ToLower().Contains(kw) ||

                        en.Course.CourseCode.ToLower().Contains(kw) ||

                        en.Course.CourseName.ToLower().Contains(kw));

                }



                if (!string.IsNullOrEmpty(statusFilter))

                {

                    query = query.Where(en => en.Status == statusFilter);

                }



                var list = (from en in query

                            orderby en.EnrollmentID descending

                            select new

                            {

                                en.EnrollmentID,

                                StudentName = en.User.FullName,

                                en.User.Username,

                                en.Course.CourseCode,

                                en.Course.CourseName,

                                en.EnrollDate,

                                en.OriginalPrice,

                                en.DiscountAmount,

                                VoucherDisplay = en.VoucherCode ?? "---",

                                en.PaidAmount,

                                StatusDisplay = en.Status == "Active" ? "Đã đăng ký" : "Đã hủy",

                                en.Note

                            }).ToList();



                enrollmentsBindingSource.DataSource = list;



                if (dgvEnrollments.Columns.Count > 0)

                {

                    dgvEnrollments.Columns["colEnroll_EnrollmentID"].HeaderText = "Mã ĐK";

                    dgvEnrollments.Columns["colEnroll_EnrollmentID"].FillWeight = 50;

                    dgvEnrollments.Columns["colEnroll_StudentName"].HeaderText = "Họ tên học viên";

                    dgvEnrollments.Columns["colEnroll_StudentName"].FillWeight = 112;

                    dgvEnrollments.Columns["colEnroll_Username"].HeaderText = "Tài khoản";

                    dgvEnrollments.Columns["colEnroll_Username"].FillWeight = 76;

                    dgvEnrollments.Columns["colEnroll_CourseCode"].HeaderText = "Mã khóa học";

                    dgvEnrollments.Columns["colEnroll_CourseCode"].FillWeight = 62;

                    dgvEnrollments.Columns["colEnroll_CourseName"].HeaderText = "Tên khóa học";

                    dgvEnrollments.Columns["colEnroll_CourseName"].FillWeight = 148;

                    dgvEnrollments.Columns["colEnroll_EnrollDate"].HeaderText = "Ngày ĐK";

                    dgvEnrollments.Columns["colEnroll_EnrollDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvEnrollments.Columns["colEnroll_EnrollDate"].FillWeight = 78;

                    dgvEnrollments.Columns["colEnroll_OriginalPrice"].HeaderText = "Học phí gốc";

                    dgvEnrollments.Columns["colEnroll_OriginalPrice"].DefaultCellStyle.Format = "N0";

                    dgvEnrollments.Columns["colEnroll_OriginalPrice"].FillWeight = 80;

                    dgvEnrollments.Columns["colEnroll_DiscountAmount"].HeaderText = "Miễn giảm";

                    dgvEnrollments.Columns["colEnroll_DiscountAmount"].DefaultCellStyle.Format = "N0";

                    dgvEnrollments.Columns["colEnroll_DiscountAmount"].FillWeight = 75;

                    dgvEnrollments.Columns["colEnroll_VoucherDisplay"].HeaderText = "Mã HB";

                    dgvEnrollments.Columns["colEnroll_VoucherDisplay"].FillWeight = 68;

                    dgvEnrollments.Columns["colEnroll_PaidAmount"].HeaderText = "Thực thu";

                    dgvEnrollments.Columns["colEnroll_PaidAmount"].DefaultCellStyle.Format = "N0";

                    dgvEnrollments.Columns["colEnroll_PaidAmount"].FillWeight = 82;

                    dgvEnrollments.Columns["colEnroll_StatusDisplay"].HeaderText = "Trạng thái";

                    dgvEnrollments.Columns["colEnroll_StatusDisplay"].FillWeight = 78;

                    dgvEnrollments.Columns["colEnroll_Note"].HeaderText = "Ghi chú";

                    dgvEnrollments.Columns["colEnroll_Note"].FillWeight = 95;

                }

            }

        }



        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvEnrollments.CurrentRow == null)

            {

                return;

            }



            int enrollId = Convert.ToInt32(dgvEnrollments.CurrentRow.Cells["colEnroll_EnrollmentID"].Value);

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId);

                if (en != null)

                {

                    _isLoadingCombos = true;

                    txtEnrollmentId.Text = en.EnrollmentID.ToString();

                    cboEnrollStatus.SelectedIndex = en.Status == "Cancelled" ? 1 : 0;

                    SelectComboById(cboEnrollStudent, en.UserID);

                    SelectComboById(cboEnrollCourse, en.CourseID);

                    nudEnrollPaid.Value = ClampDecimal(en.PaidAmount, nudEnrollPaid.Minimum, nudEnrollPaid.Maximum);

                    txtEnrollNote.Text = en.Note ?? string.Empty;

                    _isLoadingCombos = false;

                }

            }

        }



        private void btnEnrollAdd_Click(object sender, EventArgs e)

        {

            int studentId = GetSelectedComboId(cboEnrollStudent);

            int courseId = GetSelectedComboId(cboEnrollCourse);



            if (studentId <= 0 || courseId <= 0)

            {

                MessageBox.Show("Vui lòng chọn đầy đủ học viên và khóa học.", "Thiếu thông tin",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                User student = db.Users.FirstOrDefault(u => u.UserID == studentId);

                Course course = db.Courses.FirstOrDefault(c => c.CourseID == courseId);

                if (student == null || course == null)

                {

                    return;

                }



                bool alreadyActive = db.Enrollments.Any(en =>

                    en.UserID == studentId && en.CourseID == courseId && en.Status == "Active");

                if (alreadyActive)

                {

                    MessageBox.Show("Học viên này đã đăng ký khóa học \"" + course.CourseName + "\".",

                        "Trùng đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                int currentActiveCount = db.Enrollments.Count(en => en.CourseID == courseId && en.Status == "Active");

                if (currentActiveCount >= course.MaxStudents)

                {

                    MessageBox.Show("Khóa học này đã đủ sĩ số tối đa (" + course.MaxStudents + " học viên).",

                        "Đã đủ sĩ số", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                string newStatus = cboEnrollStatus.SelectedIndex == 1 ? "Cancelled" : "Active";

                if (newStatus == "Active")

                {

                    var activeStudentCourses = (from en in db.Enrollments

                                                where en.UserID == studentId && en.Status == "Active"

                                                select en.Course).ToList();

                    foreach (Course activeCourse in activeStudentCourses)

                    {

                        string overlap;

                        if (ScheduleHelper.HasScheduleConflict(course.StudyDays, course.StudyShift, activeCourse.StudyDays, activeCourse.StudyShift, out overlap))

                        {

                            MessageBox.Show(

                                string.Format("Học viên \"{0}\" đang theo học [{1}] {2} trùng lịch vào {3} ({4}).",

                                    student.FullName, activeCourse.CourseCode, activeCourse.CourseName, overlap, course.StudyShift),

                                "Trùng thời khóa biểu học viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;

                        }

                    }

                }



                decimal paid = nudEnrollPaid.Value;

                if (chkDeductWalletOnAdminCreate.Checked)

                {

                    if (student.Balance < paid)

                    {

                        MessageBox.Show(

                            string.Format("Số dư tài khoản học viên ({0:N0} VNĐ) không đủ để thanh toán {1:N0} VNĐ.",

                                student.Balance, paid),

                            "Số dư không đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }



                    student.Balance -= paid;

                    db.WalletTransactions.InsertOnSubmit(new WalletTransaction

                    {

                        UserID = student.UserID,

                        Amount = -paid,

                        TransactionType = "Purchase",

                        Description = string.Format("Quản trị viên đăng ký khóa học [{0}] {1}", course.CourseCode, course.CourseName),

                        CreatedAt = DateTime.Now

                    });

                }



                Enrollment newEnroll = new Enrollment

                {

                    UserID = studentId,

                    CourseID = courseId,

                    EnrollDate = DateTime.Now,

                    OriginalPrice = course.Price,

                    DiscountAmount = Math.Max(0m, course.Price - paid),

                    VoucherCode = null,

                    PaidAmount = paid,

                    Status = newStatus,

                    Note = string.IsNullOrWhiteSpace(txtEnrollNote.Text) ? "Đăng ký trực tiếp tại phòng đào tạo" : txtEnrollNote.Text.Trim()

                };



                db.Enrollments.InsertOnSubmit(newEnroll);

                db.SubmitChanges();



                MessageBox.Show("Thêm đăng ký khóa học thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearEnrollForm();

                LoadEnrollmentLookups();

                LoadEnrollments();

            }

        }



        private void btnEnrollUpdate_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtEnrollmentId.Text, out enrollId))

            {

                MessageBox.Show("Vui lòng chọn một bản ghi đăng ký trong danh sách trước khi cập nhật.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId);

                if (en == null)

                {

                    return;

                }



                en.PaidAmount = nudEnrollPaid.Value;

                en.Status = cboEnrollStatus.SelectedIndex == 1 ? "Cancelled" : "Active";

                en.Note = txtEnrollNote.Text.Trim();



                db.SubmitChanges();



                MessageBox.Show("Cập nhật thông tin đăng ký thành công.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEnrollments();

            }

        }



        private void btnEnrollRefundCancel_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtEnrollmentId.Text, out enrollId))

            {

                MessageBox.Show("Vui lòng chọn một lượt đăng ký để thực hiện hủy và hoàn tiền.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId);

                if (en == null)

                {

                    return;

                }



                if (en.Status == "Cancelled")

                {

                    MessageBox.Show("Lượt đăng ký này đã được hủy trước đó.",

                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }



                if (MessageBox.Show(

                    string.Format("Xác nhận hủy khóa học \"{0}\" của học viên \"{1}\" và hoàn trả {2:N0} VNĐ vào số dư tài khoản?",

                        en.Course.CourseName, en.User.FullName, en.PaidAmount),

                    "Xác nhận hủy và hoàn tiền", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)

                {

                    return;

                }



                en.Status = "Cancelled";

                en.Note = (string.IsNullOrEmpty(en.Note) ? "" : en.Note + " | ") + "Đã hủy và hoàn tiền bởi quản trị viên";

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

                    UserID = en.UserID,

                    Amount = en.PaidAmount,

                    TransactionType = "Refund",

                    Description = string.Format("Hoàn tiền hủy khóa học [{0}] {1}", en.Course.CourseCode, en.Course.CourseName),

                    CreatedAt = DateTime.Now

                });



                db.SubmitChanges();



                MessageBox.Show("Đã hủy đăng ký và hoàn tiền về tài khoản học viên thành công.",

                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEnrollmentLookups();

                LoadEnrollments();

            }

        }



        private void btnEnrollDelete_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtEnrollmentId.Text, out enrollId))

            {

                MessageBox.Show("Vui lòng chọn một bản ghi đăng ký trong danh sách để xóa.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn bản ghi đăng ký mã số " + enrollId + "?",

                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId);

                if (en != null)

                {

                    db.Enrollments.DeleteOnSubmit(en);

                    db.SubmitChanges();

                    ClearEnrollForm();

                    LoadEnrollments();

                }

            }

        }



        private void btnEnrollClear_Click(object sender, EventArgs e)

        {

            ClearEnrollForm();

        }



        private void ClearEnrollForm()

        {

            txtEnrollmentId.Text = "Tự động";

            cboEnrollStatus.SelectedIndex = 0;

            if (cboEnrollStudent.Items.Count > 0)

            {

                cboEnrollStudent.SelectedIndex = 0;

            }

            if (cboEnrollCourse.Items.Count > 0)

            {

                cboEnrollCourse.SelectedIndex = 0;

                ComboItem ci = cboEnrollCourse.SelectedItem as ComboItem;

                if (ci != null)

                {

                    nudEnrollPaid.Value = ClampDecimal(ci.ExtraPrice, nudEnrollPaid.Minimum, nudEnrollPaid.Maximum);

                }

            }

            chkDeductWalletOnAdminCreate.Checked = false;

            txtEnrollNote.Clear();

        }



        private void EnrollFilter_Changed(object sender, EventArgs e)

        {

            LoadEnrollments();

        }



        private void btnResetEnrollFilter_Click(object sender, EventArgs e)

        {

            txtSearchEnroll.Clear();

            cboFilterEnrollStatus.SelectedIndex = 0;

            LoadEnrollments();

        }



        private void btnPrintAdminReceipt_Click(object sender, EventArgs e)

        {

            int enrollId;

            if (!int.TryParse(txtEnrollmentId.Text, out enrollId))

            {

                MessageBox.Show("Vui lòng chọn một bản ghi đăng ký trong bảng để xem và in biên lai.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    Enrollment en = db.Enrollments.FirstOrDefault(x => x.EnrollmentID == enrollId);

                    if (en == null)

                    {

                        MessageBox.Show("Không tìm thấy thông tin đăng ký khóa học với mã #" + enrollId,

                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }



                    _adminReceiptData = new EnrollmentReceiptData

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

                    frmRpt.ShowReceipt(_adminReceiptData);

                    frmRpt.ShowDialog(this);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi hiển thị biên lai:\n" + ex.Message, "Thông báo lỗi",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void printDocAdminReceipt_PrintPage(object sender, PrintPageEventArgs e)

        {

            ReceiptPrinter.DrawReceipt(e.Graphics, e.PageBounds, _adminReceiptData);

            e.HasMorePages = false;

        }



        private void btnExportEnrollments_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvEnrollments,

                saveFileAdminExcel,

                "DANH SÁCH ĐĂNG KÝ KHÓA HỌC & THU HỌC PHÍ",

                "DanhSachDangKyHocPhan");

        }



        private void btnRdlcEnrollmentReport_Click(object sender, EventArgs e)

        {

            try

            {

                string kw = txtSearchEnroll.Text.Trim().ToLower();

                string statusFilter = string.Empty;

                string filterDesc = "Tất cả học viên";



                if (cboFilterEnrollStatus.SelectedIndex == 1)

                {

                    statusFilter = "Active";

                    filterDesc = "Học viên đang theo học (Đã đăng ký)";

                }

                else if (cboFilterEnrollStatus.SelectedIndex == 2)

                {

                    statusFilter = "Cancelled";

                    filterDesc = "Hồ sơ đã hủy môn / hoàn phí";

                }



                if (!string.IsNullOrEmpty(kw))

                {

                    filterDesc += string.Format(" | Tìm kiếm: '{0}'", kw);

                }



                List<StudentEnrollmentReportData> reportList;

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    IQueryable<Enrollment> query = db.Enrollments;

                    if (!string.IsNullOrEmpty(kw))

                    {

                        query = query.Where(en =>

                            en.User.FullName.ToLower().Contains(kw) ||

                            en.User.Username.ToLower().Contains(kw) ||

                            en.Course.CourseCode.ToLower().Contains(kw) ||

                            en.Course.CourseName.ToLower().Contains(kw));

                    }



                    if (!string.IsNullOrEmpty(statusFilter))

                    {

                        query = query.Where(en => en.Status == statusFilter);

                    }



                    reportList = (from en in query

                                  orderby en.Course.CourseCode, en.EnrollDate descending

                                  select new StudentEnrollmentReportData

                                  {

                                      EnrollmentId = en.EnrollmentID,

                                      StudentId = en.UserID,

                                      StudentFullName = en.User.FullName,

                                      StudentUsername = en.User.Username,

                                      StudentEmail = en.User.Email,

                                      StudentPhone = en.User.Phone,

                                      CourseCode = en.Course.CourseCode,

                                      CourseName = en.Course.CourseName,

                                      CategoryName = en.Course.Category.CategoryName,

                                      Instructor = en.Course.Instructor,

                                      ScheduleText = en.Course.StudyDays + " (" + en.Course.StudyShift + ")",

                                      Room = en.Course.Room,

                                      EnrollDate = en.EnrollDate,

                                      OriginalPrice = en.OriginalPrice,

                                      DiscountAmount = en.DiscountAmount,

                                      PaidAmount = en.PaidAmount,

                                      StatusText = en.Status,

                                      Note = en.Note

                                  }).ToList();

                }



                if (reportList.Count == 0)

                {

                    MessageBox.Show("Không có dữ liệu đăng ký nào phù hợp với bộ lọc để in báo cáo.",

                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }



                using (FrmReportViewer frmRpt = new FrmReportViewer())

                {

                    frmRpt.ShowStudentEnrollmentList(reportList, filterDesc);

                    frmRpt.ShowDialog(this);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi lập báo cáo danh sách học viên:\n" + ex.Message, "Lỗi",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        #endregion



        #region 5. QUẢN LÝ HỌC BỔNG & ƯU ĐÃI HỌC PHÍ (CRUD + LINQ)



        private void LoadVouchers()

        {

            string kw = txtSearchVoucher.Text.Trim().ToLower();

            int statusIdx = cboFilterVoucherStatus.SelectedIndex;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Voucher> query = db.Vouchers;



                if (!string.IsNullOrEmpty(kw))

                {

                    query = query.Where(v =>

                        v.VoucherCode.ToLower().Contains(kw) ||

                        v.Description.ToLower().Contains(kw));

                }



                if (statusIdx == 1)

                {

                    query = query.Where(v => v.IsActive && v.ExpiryDate >= DateTime.Today && v.UsedCount < v.UsageLimit);

                }

                else if (statusIdx == 2)

                {

                    query = query.Where(v => !v.IsActive || v.ExpiryDate < DateTime.Today || v.UsedCount >= v.UsageLimit);

                }



                var raw = (from v in query

                           orderby v.VoucherID descending

                           select v).ToList();



                var list = raw.Select(v => new

                {

                    v.VoucherID,

                    v.VoucherCode,

                    v.Description,

                    ValueDisplay = v.DiscountPercent > 0

                        ? (v.MaxDiscountAmount > 0

                            ? string.Format("{0}% (Tối đa {1:N0})", v.DiscountPercent, v.MaxDiscountAmount)

                            : v.DiscountPercent + "%")

                        : string.Format("{0:N0} VNĐ", v.DiscountAmount),

                    v.MinOrderAmount,

                    QuotaDisplay = v.UsedCount + "/" + v.UsageLimit,

                    v.ExpiryDate,

                    StatusText = !v.IsActive

                        ? "Tạm ngưng"

                        : (v.ExpiryDate.Date < DateTime.Today

                            ? "Đã hết hạn"

                            : (v.UsedCount >= v.UsageLimit ? "Hết suất" : "Đang áp dụng"))

                }).ToList();



                vouchersBindingSource.DataSource = list;



                if (dgvVouchers.Columns.Count > 0)

                {

                    dgvVouchers.Columns["colVoucher_VoucherID"].HeaderText = "ID";

                    dgvVouchers.Columns["colVoucher_VoucherID"].FillWeight = 42;

                    dgvVouchers.Columns["colVoucher_VoucherCode"].HeaderText = "Mã học bổng";

                    dgvVouchers.Columns["colVoucher_VoucherCode"].FillWeight = 85;

                    dgvVouchers.Columns["colVoucher_Description"].HeaderText = "Nội dung chương trình";

                    dgvVouchers.Columns["colVoucher_Description"].FillWeight = 195;

                    dgvVouchers.Columns["colVoucher_ValueDisplay"].HeaderText = "Mức miễn giảm";

                    dgvVouchers.Columns["colVoucher_ValueDisplay"].FillWeight = 105;

                    dgvVouchers.Columns["colVoucher_MinOrderAmount"].HeaderText = "Học phí tối thiểu";

                    dgvVouchers.Columns["colVoucher_MinOrderAmount"].DefaultCellStyle.Format = "N0";

                    dgvVouchers.Columns["colVoucher_MinOrderAmount"].FillWeight = 90;

                    dgvVouchers.Columns["colVoucher_QuotaDisplay"].HeaderText = "Đã dùng / Tổng";

                    dgvVouchers.Columns["colVoucher_QuotaDisplay"].FillWeight = 75;

                    dgvVouchers.Columns["colVoucher_ExpiryDate"].HeaderText = "Hạn áp dụng";

                    dgvVouchers.Columns["colVoucher_ExpiryDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvVouchers.Columns["colVoucher_ExpiryDate"].FillWeight = 80;

                    dgvVouchers.Columns["colVoucher_StatusText"].HeaderText = "Trạng thái";

                    dgvVouchers.Columns["colVoucher_StatusText"].FillWeight = 82;

                }

            }

        }



        private void dgvVouchers_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvVouchers.CurrentRow == null)

            {

                return;

            }



            int id = Convert.ToInt32(dgvVouchers.CurrentRow.Cells["colVoucher_VoucherID"].Value);

            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Voucher v = db.Vouchers.FirstOrDefault(x => x.VoucherID == id);

                if (v != null)

                {

                    txtVoucherId.Text = v.VoucherID.ToString();

                    chkVoucherActive.Checked = v.IsActive;

                    txtVoucherCodeAdmin.Text = v.VoucherCode;

                    txtVoucherDesc.Text = v.Description;

                    nudVoucherPercent.Value = ClampDecimal(v.DiscountPercent, nudVoucherPercent.Minimum, nudVoucherPercent.Maximum);

                    nudVoucherAmount.Value = ClampDecimal(v.DiscountAmount, nudVoucherAmount.Minimum, nudVoucherAmount.Maximum);

                    nudVoucherMaxDiscount.Value = ClampDecimal(v.MaxDiscountAmount, nudVoucherMaxDiscount.Minimum, nudVoucherMaxDiscount.Maximum);

                    nudVoucherMinOrder.Value = ClampDecimal(v.MinOrderAmount, nudVoucherMinOrder.Minimum, nudVoucherMinOrder.Maximum);

                    nudVoucherUsageLimit.Value = ClampDecimal(v.UsageLimit, nudVoucherUsageLimit.Minimum, nudVoucherUsageLimit.Maximum);

                    txtVoucherUsedCount.Text = v.UsedCount.ToString();

                    dtpVoucherExpiry.Value = v.ExpiryDate;

                }

            }

        }



        private void btnVoucherAdd_Click(object sender, EventArgs e)

        {

            string code = txtVoucherCodeAdmin.Text.Trim().ToUpperInvariant();

            string desc = txtVoucherDesc.Text.Trim();

            int pct = (int)nudVoucherPercent.Value;

            decimal amt = nudVoucherAmount.Value;



            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(desc))

            {

                MessageBox.Show("Vui lòng nhập đầy đủ mã học bổng và nội dung chương trình.",

                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            if (pct <= 0 && amt <= 0)

            {

                MessageBox.Show("Vui lòng nhập mức giảm theo phần trăm (%) hoặc số tiền giảm cố định lớn hơn 0.",

                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                if (db.Vouchers.Any(x => x.VoucherCode.ToUpper() == code))

                {

                    MessageBox.Show("Mã học bổng \"" + code + "\" đã tồn tại trong hệ thống.",

                        "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                db.Vouchers.InsertOnSubmit(new Voucher

                {

                    VoucherCode = code,

                    Description = desc,

                    DiscountPercent = pct,

                    DiscountAmount = pct > 0 ? 0m : amt,

                    MaxDiscountAmount = nudVoucherMaxDiscount.Value,

                    MinOrderAmount = nudVoucherMinOrder.Value,

                    UsageLimit = (int)nudVoucherUsageLimit.Value,

                    UsedCount = 0,

                    ExpiryDate = dtpVoucherExpiry.Value.Date,

                    IsActive = chkVoucherActive.Checked

                });



                db.SubmitChanges();

            }



            MessageBox.Show("Thêm mới mã học bổng thành công.", "Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearVoucherForm();

            LoadVouchers();

        }



        private void btnVoucherUpdate_Click(object sender, EventArgs e)

        {

            int id;

            if (!int.TryParse(txtVoucherId.Text, out id))

            {

                MessageBox.Show("Vui lòng chọn một mã học bổng trong bảng để cập nhật.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            string code = txtVoucherCodeAdmin.Text.Trim().ToUpperInvariant();

            string desc = txtVoucherDesc.Text.Trim();

            int pct = (int)nudVoucherPercent.Value;

            decimal amt = nudVoucherAmount.Value;



            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(desc) || (pct <= 0 && amt <= 0))

            {

                MessageBox.Show("Vui lòng nhập đầy đủ mã, mô tả và mức miễn giảm hợp lệ.",

                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Voucher v = db.Vouchers.FirstOrDefault(x => x.VoucherID == id);

                if (v == null)

                {

                    return;

                }



                if (db.Vouchers.Any(x => x.VoucherID != id && x.VoucherCode.ToUpper() == code))

                {

                    MessageBox.Show("Mã học bổng \"" + code + "\" đã thuộc chương trình khác.",

                        "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                v.VoucherCode = code;

                v.Description = desc;

                v.DiscountPercent = pct;

                v.DiscountAmount = pct > 0 ? 0m : amt;

                v.MaxDiscountAmount = nudVoucherMaxDiscount.Value;

                v.MinOrderAmount = nudVoucherMinOrder.Value;

                v.UsageLimit = (int)nudVoucherUsageLimit.Value;

                v.ExpiryDate = dtpVoucherExpiry.Value.Date;

                v.IsActive = chkVoucherActive.Checked;



                db.SubmitChanges();

            }



            MessageBox.Show("Cập nhật mã học bổng thành công.", "Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadVouchers();

        }



        private void btnVoucherDelete_Click(object sender, EventArgs e)

        {

            int id;

            if (!int.TryParse(txtVoucherId.Text, out id))

            {

                MessageBox.Show("Vui lòng chọn một mã học bổng trong bảng để xóa.",

                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                Voucher v = db.Vouchers.FirstOrDefault(x => x.VoucherID == id);

                if (v == null)

                {

                    return;

                }



                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chương trình học bổng \"" + v.VoucherCode + "\"?",

                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    db.Vouchers.DeleteOnSubmit(v);

                    db.SubmitChanges();

                    ClearVoucherForm();

                    LoadVouchers();

                }

            }

        }



        private void btnVoucherClear_Click(object sender, EventArgs e)

        {

            ClearVoucherForm();

        }



        private void ClearVoucherForm()

        {

            txtVoucherId.Text = "Tự động";

            chkVoucherActive.Checked = true;

            txtVoucherCodeAdmin.Clear();

            txtVoucherDesc.Clear();

            nudVoucherPercent.Value = 15;

            nudVoucherAmount.Value = 0;

            nudVoucherMaxDiscount.Value = 200000;

            nudVoucherMinOrder.Value = 500000;

            nudVoucherUsageLimit.Value = 50;

            txtVoucherUsedCount.Text = "0";

            dtpVoucherExpiry.Value = DateTime.Today.AddMonths(3);

            txtVoucherCodeAdmin.Focus();

        }



        private void VoucherFilter_Changed(object sender, EventArgs e)

        {

            LoadVouchers();

        }



        private void btnResetVoucherFilter_Click(object sender, EventArgs e)

        {

            txtSearchVoucher.Clear();

            cboFilterVoucherStatus.SelectedIndex = 0;

            LoadVouchers();

        }



        #endregion



        #region 6. QUẢN LÝ PHẢN HỒI & ĐÁNH GIÁ CỦA HỌC VIÊN (LINQ)



        private void LoadAdminReviewLookups()

        {

            _isLoadingCombos = true;

            try

            {

                using (CourseRegistrationDataContext db = DbHelper.CreateContext())

                {

                    int prevCourseId = GetSelectedComboId(cboAdminReviewCourse);

                    List<Course> courses = db.Courses.OrderBy(c => c.CourseCode).ToList();



                    cboAdminReviewCourse.Items.Clear();

                    cboAdminReviewCourse.Items.Add(new ComboItem { Id = 0, Text = "Tất cả khóa học" });

                    foreach (Course c in courses)

                    {

                        cboAdminReviewCourse.Items.Add(new ComboItem

                        {

                            Id = c.CourseID,

                            Text = string.Format("[{0}] {1}", c.CourseCode, c.CourseName)

                        });

                    }



                    SelectComboById(cboAdminReviewCourse, prevCourseId);

                    if (cboAdminReviewCourse.SelectedIndex < 0)

                    {

                        cboAdminReviewCourse.SelectedIndex = 0;

                    }

                }

            }

            finally

            {

                _isLoadingCombos = false;

            }

        }



        private void LoadAdminReviews()

        {

            if (_isLoadingCombos)

            {

                return;

            }



            int courseId = GetSelectedComboId(cboAdminReviewCourse);

            int starIdx = cboAdminReviewStars.SelectedIndex;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<CourseReview> query = db.CourseReviews;

                if (courseId > 0)

                {

                    query = query.Where(r => r.CourseID == courseId);

                }



                if (starIdx >= 1 && starIdx <= 5)

                {

                    int targetStar = 6 - starIdx;

                    query = query.Where(r => r.Rating == targetStar);

                }



                int count = query.Count();

                double avg = count > 0 ? query.Average(r => (double)r.Rating) : 0.0;

                lblAdminReviewStats.Text = count > 0

                    ? string.Format("Điểm trung bình: {0:0.0}/5 ★ ({1} đánh giá)", avg, count)

                    : "Chưa có đánh giá phù hợp";



                var raw = (from r in query

                           orderby r.CreatedAt descending

                           select new

                           {

                               r.ReviewID,

                               r.Course.CourseCode,

                               r.Course.CourseName,

                               StudentName = r.User.FullName,

                               r.User.Username,

                               r.Rating,

                               r.Comment,

                               r.CreatedAt

                           }).ToList();



                var list = raw.Select(r => new

                {

                    r.ReviewID,

                    r.CourseCode,

                    r.CourseName,

                    r.StudentName,

                    r.Username,

                    StarsDisplay = r.Rating + "/5 ★",

                    r.Comment,

                    r.CreatedAt

                }).ToList();



                adminReviewsBindingSource.DataSource = list;



                if (dgvAdminReviews.Columns.Count > 0)

                {

                    dgvAdminReviews.Columns["colRev_ReviewID"].HeaderText = "ID";

                    dgvAdminReviews.Columns["colRev_ReviewID"].FillWeight = 42;

                    dgvAdminReviews.Columns["colRev_CourseCode"].HeaderText = "Mã khóa học";

                    dgvAdminReviews.Columns["colRev_CourseCode"].FillWeight = 62;

                    dgvAdminReviews.Columns["colRev_CourseName"].HeaderText = "Tên khóa học";

                    dgvAdminReviews.Columns["colRev_CourseName"].FillWeight = 155;

                    dgvAdminReviews.Columns["colRev_StudentName"].HeaderText = "Họ tên học viên";

                    dgvAdminReviews.Columns["colRev_StudentName"].FillWeight = 115;

                    dgvAdminReviews.Columns["colRev_Username"].HeaderText = "Tài khoản";

                    dgvAdminReviews.Columns["colRev_Username"].FillWeight = 82;

                    dgvAdminReviews.Columns["colRev_StarsDisplay"].HeaderText = "Điểm";

                    dgvAdminReviews.Columns["colRev_StarsDisplay"].FillWeight = 65;

                    dgvAdminReviews.Columns["colRev_Comment"].HeaderText = "Nội dung phản hồi";

                    dgvAdminReviews.Columns["colRev_Comment"].FillWeight = 225;

                    dgvAdminReviews.Columns["colRev_CreatedAt"].HeaderText = "Ngày gửi";

                    dgvAdminReviews.Columns["colRev_CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvAdminReviews.Columns["colRev_CreatedAt"].FillWeight = 95;

                }

            }

        }



        private void AdminReviewFilter_Changed(object sender, EventArgs e)

        {

            LoadAdminReviews();

        }



        private void btnAdminDeleteReview_Click(object sender, EventArgs e)

        {

            if (dgvAdminReviews.CurrentRow == null)

            {

                MessageBox.Show("Vui lòng chọn một đánh giá trong danh sách để xóa.", "Thông báo",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            int reviewId = Convert.ToInt32(dgvAdminReviews.CurrentRow.Cells["colRev_ReviewID"].Value);

            if (MessageBox.Show("Xác nhận xóa đánh giá mã số " + reviewId + " khỏi hệ thống?",

                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)

            {

                return;

            }



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                CourseReview target = db.CourseReviews.FirstOrDefault(r => r.ReviewID == reviewId);

                if (target != null)

                {

                    db.CourseReviews.DeleteOnSubmit(target);

                    db.SubmitChanges();

                }

            }



            LoadAdminReviews();

            LoadCourses();

        }



        private void btnExportReviews_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvAdminReviews,

                saveFileAdminExcel,

                "BÁO CÁO ĐÁNH GIÁ CHẤT LƯỢNG KHÓA HỌC",

                "BaoCaoDanhGiaHocPhan");

        }



        #endregion



        #region 5. THỐNG KÊ DOANH THU & BÁO CÁO (LINQ AGGREGATION / GROUPBY)



        private void LoadReports()

        {

            DateTime fromDate = dtpReportFrom.Value.Date;

            DateTime toDateExclusive = dtpReportTo.Value.Date.AddDays(1);

            bool useDateFilter = chkFilterByDate.Checked;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Enrollment> activeEnrollments = db.Enrollments.Where(e => e.Status == "Active");

                if (useDateFilter)

                {

                    activeEnrollments = activeEnrollments.Where(e =>

                        e.EnrollDate >= fromDate && e.EnrollDate < toDateExclusive);

                }



                decimal totalRevenue = activeEnrollments.Any()

                    ? activeEnrollments.Sum(e => e.PaidAmount)

                    : 0m;

                int totalActiveCourses = db.Courses.Count(c => c.IsActive);

                int totalStudents = db.Users.Count(u => u.Role == "Student");

                int totalActiveEnrollCount = activeEnrollments.Count();



                lblCardRevenueValue.Text = string.Format("{0:N0} VNĐ", totalRevenue);

                lblCardCoursesValue.Text = string.Format("{0} khóa học", totalActiveCourses);

                lblCardStudentsValue.Text = string.Format("{0} học viên", totalStudents);

                lblCardEnrollValue.Text = string.Format("{0} lượt", totalActiveEnrollCount);



                List<Enrollment> filteredActiveList = activeEnrollments.ToList();

                List<Course> allCourses = db.Courses.ToList();

                List<Category> allCats = db.Categories.ToList();



                var revenueByCourse = (from c in allCourses

                                       join cat in allCats on c.CategoryID equals cat.CategoryID

                                       let courseEnrolls = filteredActiveList.Where(en => en.CourseID == c.CourseID).ToList()

                                       let soldCount = courseEnrolls.Count

                                       let rev = courseEnrolls.Sum(en => en.PaidAmount)

                                       orderby rev descending, soldCount descending

                                       select new

                                       {

                                           c.CourseCode,

                                           c.CourseName,

                                           cat.CategoryName,

                                           c.Instructor,

                                           c.Price,

                                           SoldSlots = soldCount + "/" + c.MaxStudents,

                                           FillPercent = c.MaxStudents > 0

                                               ? Math.Round((double)soldCount * 100.0 / c.MaxStudents, 1) + "%"

                                               : "0%",

                                           Revenue = rev

                                       }).ToList();



                courseRevenueBindingSource.DataSource = revenueByCourse;

                if (dgvCourseRevenue.Columns.Count > 0)

                {

                    dgvCourseRevenue.Columns["colStatRev_CourseCode"].HeaderText = "Mã khóa học";

                    dgvCourseRevenue.Columns["colStatRev_CourseCode"].FillWeight = 62;

                    dgvCourseRevenue.Columns["colStatRev_CourseName"].HeaderText = "Tên khóa học";

                    dgvCourseRevenue.Columns["colStatRev_CourseName"].FillWeight = 165;

                    dgvCourseRevenue.Columns["colStatRev_CategoryName"].HeaderText = "Danh mục";

                    dgvCourseRevenue.Columns["colStatRev_CategoryName"].FillWeight = 110;

                    if (dgvCourseRevenue.Columns["colStatRev_Instructor"] != null) dgvCourseRevenue.Columns["colStatRev_Instructor"].Visible = false;

                    dgvCourseRevenue.Columns["colStatRev_Price"].HeaderText = "Học phí gốc";

                    dgvCourseRevenue.Columns["colStatRev_Price"].DefaultCellStyle.Format = "N0";

                    dgvCourseRevenue.Columns["colStatRev_Price"].FillWeight = 82;

                    dgvCourseRevenue.Columns["colStatRev_SoldSlots"].HeaderText = "Sĩ số";

                    dgvCourseRevenue.Columns["colStatRev_SoldSlots"].FillWeight = 65;

                    dgvCourseRevenue.Columns["colStatRev_FillPercent"].HeaderText = "Lấp đầy";

                    dgvCourseRevenue.Columns["colStatRev_FillPercent"].FillWeight = 65;

                    dgvCourseRevenue.Columns["colStatRev_Revenue"].HeaderText = "Thực thu (VNĐ)";

                    dgvCourseRevenue.Columns["colStatRev_Revenue"].DefaultCellStyle.Format = "N0";

                    dgvCourseRevenue.Columns["colStatRev_Revenue"].FillWeight = 100;

                }



                // 1. Vẽ biểu đồ cột doanh thu theo học phần bằng LINQ

                Series colSeries = chartCourseRevenue.Series["DoanhThu"];

                colSeries.Points.Clear();

                Color[] barPalette = new Color[]

                {

                    Color.FromArgb(30, 64, 175),

                    Color.FromArgb(37, 99, 235),

                    Color.FromArgb(51, 65, 85),

                    Color.FromArgb(15, 118, 110),

                    Color.FromArgb(71, 85, 105),

                    Color.FromArgb(29, 78, 216)

                };



                var topCourses = revenueByCourse.Take(6).ToList();

                for (int i = 0; i < topCourses.Count; i++)

                {

                    int ptIdx = colSeries.Points.AddXY(topCourses[i].CourseCode, (double)topCourses[i].Revenue);

                    colSeries.Points[ptIdx].Color = barPalette[i % barPalette.Length];

                    colSeries.Points[ptIdx].ToolTip = string.Format("{0}: {1:N0} VNĐ ({2})",

                        topCourses[i].CourseName, topCourses[i].Revenue, topCourses[i].SoldSlots);

                }



                // 2. Vẽ biểu đồ Doughnut cơ cấu doanh thu theo danh mục bằng LINQ GroupBy

                Series pieSeries = chartCategoryShare.Series["TyTrong"];

                pieSeries.Points.Clear();

                Color[] piePalette = new Color[]

                {

                    Color.FromArgb(30, 64, 175),

                    Color.FromArgb(15, 118, 110),

                    Color.FromArgb(71, 85, 105),

                    Color.FromArgb(180, 83, 9),

                    Color.FromArgb(109, 40, 217)

                };



                var revenueByCategory = (from item in revenueByCourse

                                         group item by item.CategoryName into g

                                         let catRev = g.Sum(x => x.Revenue)

                                         where catRev > 0

                                         orderby catRev descending

                                         select new

                                         {

                                             CategoryName = g.Key,

                                             CategoryRevenue = catRev

                                         }).ToList();



                if (revenueByCategory.Count > 0)

                {

                    for (int i = 0; i < revenueByCategory.Count; i++)

                    {

                        int pIdx = pieSeries.Points.AddXY(revenueByCategory[i].CategoryName, (double)revenueByCategory[i].CategoryRevenue);

                        pieSeries.Points[pIdx].Color = piePalette[i % piePalette.Length];

                        pieSeries.Points[pIdx].LegendText = string.Format("{0} ({1:N0})",

                            revenueByCategory[i].CategoryName, revenueByCategory[i].CategoryRevenue);

                        pieSeries.Points[pIdx].Label = "#PERCENT{P0}";

                        pieSeries.Points[pIdx].LabelForeColor = Color.White;

                    }

                }

                else

                {

                    int pIdx = pieSeries.Points.AddXY("Chưa phát sinh", 1.0);

                    pieSeries.Points[pIdx].Color = Color.FromArgb(203, 213, 225);

                    pieSeries.Points[pIdx].LegendText = "Chưa có doanh thu trong kỳ";

                    pieSeries.Points[pIdx].Label = "0%";

                }



                IQueryable<WalletTransaction> txQuery = db.WalletTransactions;

                if (useDateFilter)

                {

                    txQuery = txQuery.Where(t => t.CreatedAt >= fromDate && t.CreatedAt < toDateExclusive);

                }



                var rawTxList = (from t in txQuery

                                 orderby t.TransactionID descending

                                 select new

                                 {

                                     t.TransactionID,

                                     FullName = t.User.FullName,

                                     t.User.Username,

                                     t.TransactionType,

                                     t.Amount,

                                     t.Description,

                                     t.CreatedAt

                                 }).ToList();



                var txList = rawTxList.Select(t => new

                {

                    t.TransactionID,

                    t.FullName,

                    t.Username,

                    TypeDisplay = FormatTransactionType(t.TransactionType),

                    t.Amount,

                    t.Description,

                    t.CreatedAt

                }).ToList();



                systemTransactionsBindingSource.DataSource = txList;

                if (dgvSystemTransactions.Columns.Count > 0)

                {

                    dgvSystemTransactions.Columns["colTx_TransactionID"].HeaderText = "Mã giao dịch";

                    dgvSystemTransactions.Columns["colTx_TransactionID"].FillWeight = 62;

                    dgvSystemTransactions.Columns["colTx_FullName"].HeaderText = "Họ và tên";

                    dgvSystemTransactions.Columns["colTx_FullName"].FillWeight = 115;

                    dgvSystemTransactions.Columns["colTx_Username"].HeaderText = "Tên đăng nhập";

                    dgvSystemTransactions.Columns["colTx_Username"].FillWeight = 85;

                    dgvSystemTransactions.Columns["colTx_TypeDisplay"].HeaderText = "Loại giao dịch";

                    dgvSystemTransactions.Columns["colTx_TypeDisplay"].FillWeight = 95;

                    dgvSystemTransactions.Columns["colTx_Amount"].HeaderText = "Số tiền (VNĐ)";

                    dgvSystemTransactions.Columns["colTx_Amount"].DefaultCellStyle.Format = "+#,##0;-#,##0;0";

                    dgvSystemTransactions.Columns["colTx_Amount"].FillWeight = 95;

                    dgvSystemTransactions.Columns["colTx_Description"].HeaderText = "Nội dung giao dịch";

                    dgvSystemTransactions.Columns["colTx_Description"].FillWeight = 215;

                    dgvSystemTransactions.Columns["colTx_CreatedAt"].HeaderText = "Thời gian";

                    dgvSystemTransactions.Columns["colTx_CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvSystemTransactions.Columns["colTx_CreatedAt"].FillWeight = 100;

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



        private void btnRunReport_Click(object sender, EventArgs e)

        {

            LoadReports();

        }



        private void btnRefreshAllReport_Click(object sender, EventArgs e)

        {

            chkFilterByDate.Checked = false;

            LoadReports();

        }



        private void btnRdlcRevenueReport_Click(object sender, EventArgs e)

        {

            DateTime fromDate = dtpReportFrom.Value.Date;

            DateTime toDateExclusive = dtpReportTo.Value.Date.AddDays(1);

            bool useDateFilter = chkFilterByDate.Checked;



            using (CourseRegistrationDataContext db = DbHelper.CreateContext())

            {

                IQueryable<Enrollment> activeEnrollments = db.Enrollments.Where(x => x.Status == "Active");

                if (useDateFilter)

                {

                    activeEnrollments = activeEnrollments.Where(x => x.EnrollDate >= fromDate && x.EnrollDate < toDateExclusive);

                }



                List<Enrollment> filteredList = activeEnrollments.ToList();

                List<Course> allCourses = db.Courses.ToList();



                List<CourseRevenueReportData> reportList = allCourses.Select(c =>

                {

                    List<Enrollment> enrolls = filteredList.Where(en => en.CourseID == c.CourseID).ToList();

                    decimal rev = enrolls.Sum(en => en.PaidAmount);

                    return new CourseRevenueReportData

                    {

                        CourseId = c.CourseID,

                        CourseCode = c.CourseCode,

                        CourseName = c.CourseName,

                        CategoryName = c.Category != null ? c.Category.CategoryName : "Khác",

                        Instructor = c.Instructor,

                        Price = c.Price,

                        TotalEnrollments = enrolls.Count,

                        TotalRevenue = rev,

                        StatusText = c.IsActive ? "Đang mở" : "Tạm đóng"

                    };

                }).OrderByDescending(x => x.TotalRevenue).ToList();



                string filterText = useDateFilter

                    ? string.Format("Từ ngày {0:dd/MM/yyyy} đến ngày {1:dd/MM/yyyy}", fromDate, dtpReportTo.Value.Date)

                    : "Toàn bộ thời gian đào tạo";



                using (FrmReportViewer frmRpt = new FrmReportViewer())

                {

                    frmRpt.ShowCourseRevenue(reportList, filterText);

                    frmRpt.ShowDialog(this);

                }

            }

        }



        private void btnExportRevenue_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvCourseRevenue,

                saveFileAdminExcel,

                "BÁO CÁO DOANH THU VÀ TỶ LỆ LẤP ĐẦY THEO KHÓA HỌC",

                "BaoCaoDoanhThuKhoaHoc");

        }



        private void btnExportTransactions_Click(object sender, EventArgs e)

        {

            ExcelExporter.ExportDataGridView(

                dgvSystemTransactions,

                saveFileAdminExcel,

                "NHẬT KÝ GIAO DỊCH HỌC PHÍ TOÀN HỆ THỐNG",

                "NhatKyGiaoDichHeThong");

        }



        #endregion



        #region Helpers



        private static void SelectComboString(ComboBox cbo, string value)

        {

            if (string.IsNullOrEmpty(value))

            {

                return;

            }



            for (int i = 0; i < cbo.Items.Count; i++)

            {

                if (string.Equals(cbo.Items[i].ToString(), value, StringComparison.OrdinalIgnoreCase))

                {

                    cbo.SelectedIndex = i;

                    return;

                }

            }

        }



        private static int GetSelectedComboId(ComboBox cbo)

        {

            ComboItem item = cbo.SelectedItem as ComboItem;

            return item != null ? item.Id : 0;

        }



        private static void SelectComboById(ComboBox cbo, int id)

        {

            for (int i = 0; i < cbo.Items.Count; i++)

            {

                ComboItem item = cbo.Items[i] as ComboItem;

                if (item != null && item.Id == id)

                {

                    cbo.SelectedIndex = i;

                    return;

                }

            }

        }



        private static decimal ClampDecimal(decimal val, decimal min, decimal max)

        {

            if (val < min) return min;

            if (val > max) return max;

            return val;

        }



        #endregion

    }

}

