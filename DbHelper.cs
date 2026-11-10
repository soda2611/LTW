using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_Registration
{
    /// <summary>
    /// Lớp hỗ trợ khởi tạo CourseRegistrationDataContext (LINQ to SQL)
    /// và tự động khởi tạo dữ liệu mẫu bằng LINQ nếu chạy trên máy chưa import SQL.
    /// </summary>
    public static class DbHelper
    {
        private static string _resolvedConnectionString;

        public static CourseRegistrationDataContext CreateContext()
        {
            if (!string.IsNullOrEmpty(_resolvedConnectionString))
            {
                return new CourseRegistrationDataContext(_resolvedConnectionString);
            }

            // Mặc định dùng chuỗi kết nối từ App.config / Settings (chuẩn O/R Designer)
            return new CourseRegistrationDataContext();
        }

        public static void EnsureDatabaseReady()
        {
            string defaultConn = Properties.Settings.Default.CourseRegistrationDBConnectionString;
            string[] candidates = new string[]
            {
                defaultConn,
                "Data Source=.\\SQLEXPRESS;Initial Catalog=CourseRegistrationDB;Integrated Security=True;Encrypt=False",
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CourseRegistrationDB;Integrated Security=True"
            };

            foreach (string conn in candidates)
            {
                try
                {
                    using (CourseRegistrationDataContext db = new CourseRegistrationDataContext(conn))
                    {
                        if (!db.DatabaseExists())
                        {
                            db.CreateDatabase();
                            SeedInitialData(db);
                        }
                        else if (!db.Users.Any())
                        {
                            SeedInitialData(db);
                        }
                        else
                        {
                            // Đảm bảo luôn có ít nhất 01 Quản trị viên kích hoạt để tránh mất quyền quản trị
                            EnsureAdminExists(db);
                            int checkCount = db.Vouchers.Count() + db.CourseReviews.Count();
                        }

                        _resolvedConnectionString = conn;
                        return;
                    }
                }
                catch
                {
                    // Thử instance SQL Server tiếp theo nếu máy hiện tại dùng tên instance khác
                }
            }

            // Giữ kết nối mặc định để ném thông báo lỗi rõ ràng nếu SQL Server đang tắt
            _resolvedConnectionString = defaultConn;
        }

        /// <summary>
        /// Cơ chế an toàn cứu hộ: Nếu vì bất kỳ lý do gì (thao tác nhầm hoặc dữ liệu lỗi)
        /// hệ thống không còn tài khoản Quản trị viên đang hoạt động nào, tự động khôi phục
        /// tài khoản admin mặc định để tránh mất quyền quản trị vĩnh viễn.
        /// </summary>
        public static void EnsureAdminExists(CourseRegistrationDataContext db)
        {
            try
            {
                if (!db.Users.Any(u => u.Role == "Admin" && u.IsActive))
                {
                    User existingAdmin = db.Users.FirstOrDefault(u => u.Username.ToLower() == "admin");
                    if (existingAdmin != null)
                    {
                        existingAdmin.Role = "Admin";
                        existingAdmin.IsActive = true;
                        if (!SecurityHelper.VerifyPassword("123456", existingAdmin.Password))
                        {
                            existingAdmin.Password = SecurityHelper.HashPassword("123456");
                        }
                    }
                    else
                    {
                        db.Users.InsertOnSubmit(new User
                        {
                            Username = "admin",
                            Password = SecurityHelper.HashPassword("123456"),
                            FullName = "Quản trị viên hệ thống",
                            Email = "admin@daotao.edu.vn",
                            Phone = "0901234567",
                            Role = "Admin",
                            Balance = 0m,
                            IsActive = true,
                            CreatedAt = DateTime.Now
                        });
                    }
                    db.SubmitChanges();
                }
            }
            catch
            {
                // Bỏ qua lỗi phụ nếu bảng chưa hoàn tất kết nối
            }
        }

        private static void SeedInitialData(CourseRegistrationDataContext db)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryName = "Lập trình .NET & Desktop", Description = "Phát triển ứng dụng Windows Forms, WPF, LINQ và ASP.NET Core" },
                new Category { CategoryName = "Lập trình Web", Description = "HTML/CSS, JavaScript, React, Node.js và kiến trúc ứng dụng Web" },
                new Category { CategoryName = "Khoa học dữ liệu & AI", Description = "Phân tích dữ liệu với SQL, Python và nhập môn Học máy" },
                new Category { CategoryName = "Lập trình di động", Description = "Phát triển ứng dụng di động đa nền tảng với Flutter và Android" },
                new Category { CategoryName = "Ngoại ngữ chuyên ngành", Description = "Tiếng Anh đọc hiểu tài liệu kỹ thuật và giao tiếp chuyên ngành CNTT" }
            };
            db.Categories.InsertAllOnSubmit(categories);
            db.SubmitChanges();

            List<User> users = new List<User>
            {
                new User { Username = "admin", Password = SecurityHelper.HashPassword("123456"), FullName = "Quản trị viên hệ thống", Email = "admin@daotao.edu.vn", Phone = "0901234567", Role = "Admin", Balance = 0m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-30) },
                new User { Username = "hocvien1", Password = SecurityHelper.HashPassword("123456"), FullName = "Nguyễn Minh Tuấn", Email = "minhtuan@gmail.com", Phone = "0912345678", Role = "Student", Balance = 2500000m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-20) },
                new User { Username = "hocvien2", Password = SecurityHelper.HashPassword("123456"), FullName = "Trần Thu Hà", Email = "thuha.tran@gmail.com", Phone = "0987654321", Role = "Student", Balance = 1800000m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-15) }
            };
            db.Users.InsertAllOnSubmit(users);
            db.SubmitChanges();

            List<Course> courses = new List<Course>
            {
                new Course
                {
                    CourseCode = "NET101",
                    CourseName = "Lập trình Windows Forms với C# và LINQ",
                    CategoryID = categories[0].CategoryID,
                    Instructor = "ThS. Nguyễn Văn An",
                    Price = 800000m,
                    DurationHours = 45,
                    MaxStudents = 35,
                    StartDate = DateTime.Today.AddDays(7),
                    StudyDays = "2,4,6",
                    StudyShift = "Ca tối (18:00 - 20:30)",
                    Room = "Phòng Lab A201",
                    Description = "Thiết kế giao diện Windows Forms, truy vấn cơ sở dữ liệu với LINQ to SQL trên .NET Framework.",
                    IsActive = true
                },
                new Course
                {
                    CourseCode = "WEB105",
                    CourseName = "Phát triển giao diện Web với React và TypeScript",
                    CategoryID = categories[1].CategoryID,
                    Instructor = "KS. Trần Quốc Bảo",
                    Price = 950000m,
                    DurationHours = 48,
                    MaxStudents = 40,
                    StartDate = DateTime.Today.AddDays(10),
                    StudyDays = "2,4,6",
                    StudyShift = "Ca tối (18:00 - 20:30)",
                    Room = "Phòng Lab B104",
                    Description = "Xây dựng giao diện người dùng dạng Single Page Application với React Hooks và TypeScript.",
                    IsActive = true
                },
                new Course
                {
                    CourseCode = "DAI101",
                    CourseName = "Phân tích dữ liệu với SQL và Python",
                    CategoryID = categories[2].CategoryID,
                    Instructor = "TS. Lê Minh Châu",
                    Price = 900000m,
                    DurationHours = 42,
                    MaxStudents = 45,
                    StartDate = DateTime.Today.AddDays(5),
                    StudyDays = "3,5,7",
                    StudyShift = "Ca tối (18:00 - 20:30)",
                    Room = "Phòng Lab C302",
                    Description = "Truy vấn tổng hợp dữ liệu, xử lý bảng biểu với Pandas và trực quan hóa báo cáo cơ bản.",
                    IsActive = true
                },
                new Course
                {
                    CourseCode = "ENG101",
                    CourseName = "Tiếng Anh chuyên ngành Công nghệ thông tin",
                    CategoryID = categories[4].CategoryID,
                    Instructor = "ThS. Đặng Thu Trang",
                    Price = 600000m,
                    DurationHours = 36,
                    MaxStudents = 30,
                    StartDate = DateTime.Today.AddDays(12),
                    StudyDays = "7,CN",
                    StudyShift = "Ca sáng (08:00 - 10:30)",
                    Room = "Phòng học D105",
                    Description = "Đọc hiểu tài liệu kỹ thuật phần mềm, viết email công việc và thảo luận chuyên môn bằng tiếng Anh.",
                    IsActive = true
                }
            };
            db.Courses.InsertAllOnSubmit(courses);
            db.SubmitChanges();

            List<Voucher> vouchers = new List<Voucher>
            {
                new Voucher
                {
                    VoucherCode = "SVCNTT15",
                    Description = "Học bổng hỗ trợ 15% học phí cho sinh viên CNTT (tối đa 200.000 VNĐ)",
                    DiscountPercent = 15,
                    DiscountAmount = 0m,
                    MaxDiscountAmount = 200000m,
                    MinOrderAmount = 500000m,
                    UsageLimit = 50,
                    UsedCount = 1,
                    ExpiryDate = DateTime.Today.AddMonths(3),
                    IsActive = true
                },
                new Voucher
                {
                    VoucherCode = "NHAPHOC100",
                    Description = "Miễn giảm trực tiếp 100.000 VNĐ học phí kỳ nhập học mới",
                    DiscountPercent = 0,
                    DiscountAmount = 100000m,
                    MaxDiscountAmount = 0m,
                    MinOrderAmount = 600000m,
                    UsageLimit = 100,
                    UsedCount = 0,
                    ExpiryDate = DateTime.Today.AddMonths(2),
                    IsActive = true
                }
            };
            db.Vouchers.InsertAllOnSubmit(vouchers);
            db.SubmitChanges();

            Enrollment sampleEnroll = new Enrollment
            {
                UserID = users[1].UserID,
                CourseID = courses[0].CourseID,
                EnrollDate = DateTime.Now.AddDays(-5),
                OriginalPrice = 800000m,
                DiscountAmount = 120000m,
                VoucherCode = "SVCNTT15",
                PaidAmount = 680000m,
                Status = "Active",
                Note = "Đăng ký khóa học kỳ hiện tại"
            };
            db.Enrollments.InsertOnSubmit(sampleEnroll);

            CourseReview sampleReview = new CourseReview
            {
                CourseID = courses[0].CourseID,
                UserID = users[1].UserID,
                Rating = 5,
                Comment = "Nội dung bám sát thực tế, giảng viên hướng dẫn thiết kế giao diện và truy vấn LINQ rất dễ hiểu.",
                CreatedAt = DateTime.Now.AddDays(-2)
            };
            db.CourseReviews.InsertOnSubmit(sampleReview);

            db.WalletTransactions.InsertOnSubmit(new WalletTransaction
            {
                UserID = users[1].UserID,
                Amount = 3180000m,
                TransactionType = "Deposit",
                Description = "Nộp học phí đầu kỳ qua chuyển khoản ngân hàng",
                CreatedAt = DateTime.Now.AddDays(-6)
            });
            db.WalletTransactions.InsertOnSubmit(new WalletTransaction
            {
                UserID = users[1].UserID,
                Amount = -680000m,
                TransactionType = "Purchase",
                Description = "Thanh toán khóa học [NET101] Lập trình Windows Forms với C# và LINQ (Mã ưu đãi: SVCNTT15)",
                CreatedAt = DateTime.Now.AddDays(-5)
            });

            db.SubmitChanges();
        }
    }
}
