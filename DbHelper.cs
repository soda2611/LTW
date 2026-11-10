using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Course_Registration
{
    /// <summary>
    /// Lớp hỗ trợ khởi tạo CourseRegistrationDataContext (LINQ to SQL),
    /// tự động dò tìm máy chủ SQL Server qua danh sách các Instance phổ biến:
    /// localhost, .\SQLEXPRESS, (localdb)\MSSQLLocalDB, SERVER-NAME.
    /// Nếu CSDL CourseRegistrationDB chưa tồn tại, tự động đọc Database.sql, thực thi tuần tự
    /// các lô lệnh (GO Batches) hoặc fallback tự khởi tạo CSDL và nạp dữ liệu mẫu bằng LINQ.
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

        /// <summary>
        /// Tự động dò tìm SQL Server instance đang hoạt động và chuẩn bị CSDL CourseRegistrationDB
        /// theo cơ chế Plug and Play (cắm và chạy).
        /// </summary>
        public static void EnsureDatabaseReady()
        {
            string defaultConn = Properties.Settings.Default.CourseRegistrationDBConnectionString;

            // Danh sách các Instance phổ biến: localhost, .\SQLEXPRESS, (localdb)\MSSQLLocalDB, SERVER-NAME
            List<string> candidateInstances = new List<string>();

            try
            {
                if (!string.IsNullOrEmpty(defaultConn))
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(defaultConn);
                    if (!string.IsNullOrEmpty(builder.DataSource))
                    {
                        candidateInstances.Add(builder.DataSource);
                    }
                }
            }
            catch { }

            string[] standardInstances = new string[]
            {
                "localhost",
                ".\\SQLEXPRESS",
                "(localdb)\\MSSQLLocalDB",
                Environment.MachineName
            };

            foreach (string inst in standardInstances)
            {
                if (!candidateInstances.Any(i => string.Equals(i, inst, StringComparison.OrdinalIgnoreCase)))
                {
                    candidateInstances.Add(inst);
                }
            }

            foreach (string inst in candidateInstances)
            {
                string masterConnStr = string.Format("Data Source={0};Initial Catalog=master;Integrated Security=True;Connect Timeout=3;Encrypt=False", inst);
                string appDbConnStr = string.Format("Data Source={0};Initial Catalog=CourseRegistrationDB;Integrated Security=True;Connect Timeout=5;Encrypt=False", inst);

                try
                {
                    // Bước 1: Kiểm tra xem máy chủ SQL Server instance này có phản hồi hay không qua master
                    using (SqlConnection masterConn = new SqlConnection(masterConnStr))
                    {
                        masterConn.Open();

                        // Kiểm tra CSDL CourseRegistrationDB đã tồn tại trên máy chủ này chưa
                        bool dbExists = false;
                        using (SqlCommand checkCmd = new SqlCommand("SELECT DB_ID('CourseRegistrationDB')", masterConn))
                        {
                            object result = checkCmd.ExecuteScalar();
                            dbExists = (result != null && result != DBNull.Value);
                        }

                        // Nếu máy chủ đang chạy nhưng CSDL chưa tồn tại, tự động đọc Database.sql và thực thi GO Batches
                        if (!dbExists)
                        {
                            bool scriptExecuted = TryExecuteDatabaseScript(masterConn);
                            if (scriptExecuted)
                            {
                                dbExists = true;
                            }
                            else
                            {
                                // Fallback bằng LINQ to SQL CreateDatabase nếu chạy script sql không thành công
                                try
                                {
                                    using (CourseRegistrationDataContext dbLinq = new CourseRegistrationDataContext(appDbConnStr))
                                    {
                                        if (!dbLinq.DatabaseExists())
                                        {
                                            dbLinq.CreateDatabase();
                                        }
                                        SeedInitialData(dbLinq);
                                        dbExists = true;
                                    }
                                }
                                catch { }
                            }
                        }

                        if (dbExists)
                        {
                            using (CourseRegistrationDataContext db = new CourseRegistrationDataContext(appDbConnStr))
                            {
                                if (!db.Users.Any())
                                {
                                    SeedInitialData(db);
                                }
                                else
                                {
                                    EnsureAdminExists(db);
                                }

                                // Kiểm tra truy vấn hợp lệ để xác nhận kết nối thành công
                                int testCount = db.Users.Count();
                                _resolvedConnectionString = appDbConnStr;
                                return;
                            }
                        }
                    }
                }
                catch
                {
                    // Bước 2: Thử kết nối trực tiếp appDbConnStr (phòng trường hợp người dùng không có quyền vào master)
                    try
                    {
                        using (CourseRegistrationDataContext db = new CourseRegistrationDataContext(appDbConnStr))
                        {
                            if (db.DatabaseExists())
                            {
                                if (!db.Users.Any())
                                {
                                    SeedInitialData(db);
                                }
                                else
                                {
                                    EnsureAdminExists(db);
                                }

                                _resolvedConnectionString = appDbConnStr;
                                return;
                            }
                        }
                    }
                    catch
                    {
                        // Instance này không phản hồi, tiếp tục thử instance tiếp theo trong danh sách
                    }
                }
            }

            // Nếu tất cả candidate instances đều không phản hồi, giữ kết nối mặc định từ App.config
            _resolvedConnectionString = defaultConn;
        }

        /// <summary>
        /// Tìm tệp kịch bản Database.sql hoặc InitDatabase.sql trong các thư mục triển khai và thư mục gốc của dự án.
        /// </summary>
        private static string FindDatabaseSqlScript()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] probeFiles = new string[] { "Database.sql", "InitDatabase.sql" };
            string[] probeDirs = new string[]
            {
                baseDir,
                Path.Combine(baseDir, "..", ".."),
                Path.Combine(baseDir, "..", "..", ".."),
                Environment.CurrentDirectory
            };

            foreach (string dir in probeDirs)
            {
                foreach (string file in probeFiles)
                {
                    try
                    {
                        string fullPath = Path.GetFullPath(Path.Combine(dir, file));
                        if (File.Exists(fullPath))
                        {
                            return fullPath;
                        }
                    }
                    catch { }
                }
            }
            return null;
        }

        /// <summary>
        /// Đọc tệp kịch bản Database.sql, phân tích cú pháp theo các lô lệnh GO (GO Batches)
        /// và thực thi tuần tự trên kết nối SQL Server đang mở.
        /// </summary>
        private static bool TryExecuteDatabaseScript(SqlConnection openMasterConnection)
        {
            try
            {
                string scriptPath = FindDatabaseSqlScript();
                if (string.IsNullOrEmpty(scriptPath) || !File.Exists(scriptPath))
                {
                    return false;
                }

                string fullScript = File.ReadAllText(scriptPath);
                // Phân tách các lô lệnh theo từ khóa GO (đứng riêng một dòng, không phân biệt hoa thường)
                string[] batches = Regex.Split(fullScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                foreach (string batch in batches)
                {
                    string trimmed = batch.Trim();
                    if (string.IsNullOrEmpty(trimmed))
                    {
                        continue;
                    }

                    using (SqlCommand cmd = new SqlCommand(trimmed, openMasterConnection))
                    {
                        cmd.CommandTimeout = 120; // 120 giây cho các thao tác khởi tạo và nạp dữ liệu
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cơ chế an toàn cứu hộ: Nếu vì bất kỳ lý do gì hệ thống không còn tài khoản Quản trị viên
        /// đang hoạt động nào, tự động khôi phục tài khoản admin mặc định (admin / 123456)
        /// để tránh mất quyền quản trị.
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

        /// <summary>
        /// Tự động nạp bộ dữ liệu mẫu (Seed Mockup Data) đầy đủ bằng LINQ to SQL
        /// khi cơ sở dữ liệu trống hoặc khi chạy fallback không dùng script.
        /// </summary>
        public static void SeedInitialData(CourseRegistrationDataContext db)
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
                new User { Username = "hocvien2", Password = SecurityHelper.HashPassword("123456"), FullName = "Trần Thu Hà", Email = "thuha.tran@gmail.com", Phone = "0987654321", Role = "Student", Balance = 1800000m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-15) },
                new User { Username = "hocvien3", Password = SecurityHelper.HashPassword("123456"), FullName = "Lê Hoàng Nam", Email = "hoangnam.le@gmail.com", Phone = "0933445566", Role = "Student", Balance = 1200000m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-10) },
                new User { Username = "hocvien4", Password = SecurityHelper.HashPassword("123456"), FullName = "Phạm Khánh Linh", Email = "khanhlinh@gmail.com", Phone = "0977889900", Role = "Student", Balance = 3200000m, IsActive = true, CreatedAt = DateTime.Now.AddDays(-5) }
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
                    CourseCode = "NET202",
                    CourseName = "Phát triển Web API với ASP.NET Core",
                    CategoryID = categories[0].CategoryID,
                    Instructor = "ThS. Nguyễn Văn An",
                    Price = 1200000m,
                    DurationHours = 60,
                    MaxStudents = 30,
                    StartDate = DateTime.Today.AddDays(14),
                    StudyDays = "3,5,7",
                    StudyShift = "Ca tối (18:00 - 20:30)",
                    Room = "Phòng Lab A202",
                    Description = "Xây dựng dịch vụ RESTful API, phân quyền truy cập và kết nối cơ sở dữ liệu SQL Server.",
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
                    CourseCode = "WEB210",
                    CourseName = "Lập trình ứng dụng Web với Node.js và CSDL",
                    CategoryID = categories[1].CategoryID,
                    Instructor = "KS. Trần Quốc Bảo",
                    Price = 1150000m,
                    DurationHours = 54,
                    MaxStudents = 30,
                    StartDate = DateTime.Today.AddDays(21),
                    StudyDays = "3,5,7",
                    StudyShift = "Ca chiều (14:00 - 16:30)",
                    Room = "Phòng Lab B104",
                    Description = "Phát triển phía máy chủ với Node.js, Express và thiết kế cơ sở dữ liệu quan hệ.",
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
                    CourseCode = "DAI301",
                    CourseName = "Nhập môn Học máy và ứng dụng",
                    CategoryID = categories[2].CategoryID,
                    Instructor = "TS. Lê Minh Châu",
                    Price = 1500000m,
                    DurationHours = 60,
                    MaxStudents = 25,
                    StartDate = DateTime.Today.AddDays(25),
                    StudyDays = "7,CN",
                    StudyShift = "Ca sáng (08:00 - 10:30)",
                    Room = "Phòng Lab C201",
                    Description = "Các thuật toán học có giám sát, đánh giá mô hình và ứng dụng trong bài toán phân loại, dự báo.",
                    IsActive = true
                },
                new Course
                {
                    CourseCode = "MOB102",
                    CourseName = "Phát triển ứng dụng di động với Flutter",
                    CategoryID = categories[3].CategoryID,
                    Instructor = "ThS. Đặng Quốc Huy",
                    Price = 1100000m,
                    DurationHours = 50,
                    MaxStudents = 30,
                    StartDate = DateTime.Today.AddDays(12),
                    StudyDays = "2,4,6",
                    StudyShift = "Ca chiều (14:00 - 16:30)",
                    Room = "Phòng Lab B203",
                    Description = "Lập trình ngôn ngữ Dart, thiết kế giao diện đa nền tảng và kết nối REST API trên thiết bị di động.",
                    IsActive = true
                },
                new Course
                {
                    CourseCode = "ENG100",
                    CourseName = "Tiếng Anh chuyên ngành Công nghệ thông tin",
                    CategoryID = categories[4].CategoryID,
                    Instructor = "ThS. Vũ Thanh Mai",
                    Price = 650000m,
                    DurationHours = 36,
                    MaxStudents = 50,
                    StartDate = DateTime.Today.AddDays(3),
                    StudyDays = "7,CN",
                    StudyShift = "Ca chiều (14:00 - 16:30)",
                    Room = "Phòng A105",
                    Description = "Thuật ngữ chuyên ngành phần mềm, đọc hiểu tài liệu kỹ thuật và viết báo cáo công việc.",
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
                    Description = "Học bổng hỗ trợ 15% học phí cho sinh viên CNTT (tối đa 250.000 VNĐ)",
                    DiscountPercent = 15,
                    DiscountAmount = 0m,
                    MaxDiscountAmount = 250000m,
                    MinOrderAmount = 500000m,
                    UsageLimit = 100,
                    UsedCount = 2,
                    ExpiryDate = DateTime.Today.AddMonths(3),
                    IsActive = true
                },
                new Voucher
                {
                    VoucherCode = "NHAPHOC100",
                    Description = "Hỗ trợ trực tiếp 100.000 VNĐ học phí đợt khai giảng kỳ mới",
                    DiscountPercent = 0,
                    DiscountAmount = 100000m,
                    MaxDiscountAmount = 0m,
                    MinOrderAmount = 600000m,
                    UsageLimit = 50,
                    UsedCount = 1,
                    ExpiryDate = DateTime.Today.AddMonths(2),
                    IsActive = true
                },
                new Voucher
                {
                    VoucherCode = "HOCBONG25",
                    Description = "Học bổng khuyến khích học tập giảm 25% (tối đa 400.000 VNĐ)",
                    DiscountPercent = 25,
                    DiscountAmount = 0m,
                    MaxDiscountAmount = 400000m,
                    MinOrderAmount = 1000000m,
                    UsageLimit = 20,
                    UsedCount = 0,
                    ExpiryDate = DateTime.Today.AddMonths(4),
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
