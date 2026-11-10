-- ============================================================================
-- HỌC PHẦN: CƠ SỞ DỮ LIỆU / LẬP TRÌNH TRÊN MÔI TRƯỜNG WINDOWS
-- ĐỀ TÀI: HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC (ACADEMIC ERP)
-- SINH VIÊN PHỤ TRÁCH THIẾT KẾ CSDL & SQL: TRẦN NGỌC HÀ
-- Hệ quản trị CSDL: Microsoft SQL Server | Công nghệ ánh xạ: LINQ to SQL
-- Kiến trúc chuẩn hóa: ANSI-SPARC 3 Mức | Mô hình: Quan hệ (Relational Model)
-- ============================================================================

USE master;
GO

IF DB_ID(N'CourseRegistrationDB') IS NOT NULL
BEGIN
    ALTER DATABASE CourseRegistrationDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CourseRegistrationDB;
END
GO

CREATE DATABASE CourseRegistrationDB;
GO

USE CourseRegistrationDB;
GO

-- ============================================================================
-- PHẦN I: NGÔN NGỮ ĐỊNH NGHĨA DỮ LIỆU (DDL - DATA DEFINITION LANGUAGE)
-- ĐẶC TẢ LƯỢC ĐỒ QUAN HỆ & CÁC RÀNG BUỘC TOÀN VẸN (RBTV)
-- Gồm: RBTV Thực thể (PK), RBTV Tham chiếu (FK), RBTV Miền (Domain/CHECK/DEFAULT)
-- ============================================================================

-- ----------------------------------------------------------------------------
-- 1. Quan hệ Danh mục khóa học (Categories)
-- Lược đồ: Categories(CategoryID: INT, CategoryName: NVARCHAR, Description: NVARCHAR)
-- Khóa chính: CategoryID (RBTV Thực thể)
-- ----------------------------------------------------------------------------
CREATE TABLE Categories (
    -- RBTV Thực thể: Khóa chính tự tăng (Identity), NOT NULL, xác định duy nhất mỗi danh mục
    CategoryID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Miền giá trị: Bắt buộc nhập tên danh mục đào tạo
    CategoryName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(300) NULL,

    CONSTRAINT PK_Categories PRIMARY KEY (CategoryID)
);
GO

-- ----------------------------------------------------------------------------
-- 2. Quan hệ Người dùng hệ thống (Users)
-- Lược đồ: Users(UserID, Username, Password, FullName, Email, Phone, Role, Balance, IsActive, CreatedAt)
-- Khóa chính: UserID (RBTV Thực thể)
-- Ràng buộc liên bộ: Username UNIQUE
-- ----------------------------------------------------------------------------
CREATE TABLE Users (
    -- RBTV Thực thể: Khóa chính tự tăng
    UserID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Liên bộ: Tên tài khoản là duy nhất trong toàn hệ thống
    Username VARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NULL,
    Phone VARCHAR(20) NULL,
    
    -- RBTV Miền giá trị: Vai trò người dùng chỉ nhận 1 trong 2 giá trị xác định ('Admin', 'Student')
    Role VARCHAR(20) NOT NULL,
    
    -- RBTV Miền giá trị: Số dư học phí mặc định là 0, không được âm
    Balance DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Users_Balance DEFAULT 0,
    
    -- RBTV Miền giá trị: Cờ trạng thái hoạt động (1: Hoạt động, 0: Tạm khóa)
    IsActive BIT NOT NULL CONSTRAINT DF_Users_IsActive DEFAULT 1,
    CreatedAt DATETIME NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT GETDATE(),

    CONSTRAINT PK_Users PRIMARY KEY (UserID),
    CONSTRAINT UQ_Users_Username UNIQUE (Username),
    CONSTRAINT CK_Users_Role CHECK (Role IN ('Admin', 'Student')),
    CONSTRAINT CK_Users_Balance CHECK (Balance >= 0)
);
GO

-- ----------------------------------------------------------------------------
-- 3. Quan hệ Khóa học / Lớp học phần (Courses)
-- Lược đồ: Courses(CourseID, CourseCode, CourseName, CategoryID, Instructor, Price, DurationHours, MaxStudents, StartDate, StudyDays, StudyShift, Room, Description, IsActive)
-- Khóa chính: CourseID (RBTV Thực thể)
-- Khóa ngoại: CategoryID -> Categories(CategoryID) (RBTV Tham chiếu)
-- ----------------------------------------------------------------------------
CREATE TABLE Courses (
    -- RBTV Thực thể: Khóa chính tự tăng
    CourseID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Liên bộ: Mã khóa học duy nhất (VD: NET101, WEB105)
    CourseCode VARCHAR(20) NOT NULL,
    CourseName NVARCHAR(150) NOT NULL,
    
    -- Khóa ngoại tham chiếu đến bảng Categories
    CategoryID INT NOT NULL,
    Instructor NVARCHAR(100) NOT NULL,
    
    -- RBTV Miền giá trị: Học phí, thời lượng và sĩ số phải thỏa mãn điều kiện logic
    Price DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Courses_Price DEFAULT 0,
    DurationHours INT NOT NULL CONSTRAINT DF_Courses_DurationHours DEFAULT 30,
    MaxStudents INT NOT NULL CONSTRAINT DF_Courses_MaxStudents DEFAULT 50,
    StartDate DATE NOT NULL,
    StudyDays VARCHAR(30) NOT NULL CONSTRAINT DF_Courses_StudyDays DEFAULT '2,4,6',
    StudyShift NVARCHAR(50) NOT NULL CONSTRAINT DF_Courses_StudyShift DEFAULT N'Ca tối (18:00 - 20:30)',
    Room NVARCHAR(50) NOT NULL CONSTRAINT DF_Courses_Room DEFAULT N'Phòng A101',
    Description NVARCHAR(500) NULL,
    IsActive BIT NOT NULL CONSTRAINT DF_Courses_IsActive DEFAULT 1,

    CONSTRAINT PK_Courses PRIMARY KEY (CourseID),
    CONSTRAINT UQ_Courses_CourseCode UNIQUE (CourseCode),
    CONSTRAINT FK_Courses_Categories FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    CONSTRAINT CK_Courses_Price CHECK (Price >= 0),
    CONSTRAINT CK_Courses_DurationHours CHECK (DurationHours > 0),
    CONSTRAINT CK_Courses_MaxStudents CHECK (MaxStudents > 0)
);
GO

-- ----------------------------------------------------------------------------
-- 4. Quan hệ Học bổng & Mã miễn giảm học phí (Vouchers)
-- Lược đồ: Vouchers(VoucherID, VoucherCode, Description, DiscountPercent, DiscountAmount, MaxDiscountAmount, MinOrderAmount, UsageLimit, UsedCount, ExpiryDate, IsActive)
-- Khóa chính: VoucherID (RBTV Thực thể)
-- ----------------------------------------------------------------------------
CREATE TABLE Vouchers (
    -- RBTV Thực thể: Khóa chính tự tăng
    VoucherID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Liên bộ: Mã học bổng duy nhất
    VoucherCode VARCHAR(30) NOT NULL,
    Description NVARCHAR(200) NOT NULL,
    
    -- RBTV Miền giá trị: Phần trăm miễn giảm từ 0 đến 100%
    DiscountPercent INT NOT NULL CONSTRAINT DF_Vouchers_DiscountPercent DEFAULT 0,
    DiscountAmount DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Vouchers_DiscountAmount DEFAULT 0,
    MaxDiscountAmount DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Vouchers_MaxDiscountAmount DEFAULT 0,
    MinOrderAmount DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Vouchers_MinOrderAmount DEFAULT 0,
    UsageLimit INT NOT NULL CONSTRAINT DF_Vouchers_UsageLimit DEFAULT 50,
    UsedCount INT NOT NULL CONSTRAINT DF_Vouchers_UsedCount DEFAULT 0,
    ExpiryDate DATE NOT NULL,
    IsActive BIT NOT NULL CONSTRAINT DF_Vouchers_IsActive DEFAULT 1,

    CONSTRAINT PK_Vouchers PRIMARY KEY (VoucherID),
    CONSTRAINT UQ_Vouchers_VoucherCode UNIQUE (VoucherCode),
    CONSTRAINT CK_Vouchers_DiscountPercent CHECK (DiscountPercent BETWEEN 0 AND 100),
    CONSTRAINT CK_Vouchers_DiscountAmount CHECK (DiscountAmount >= 0),
    CONSTRAINT CK_Vouchers_MaxDiscountAmount CHECK (MaxDiscountAmount >= 0),
    CONSTRAINT CK_Vouchers_MinOrderAmount CHECK (MinOrderAmount >= 0),
    CONSTRAINT CK_Vouchers_UsageLimit CHECK (UsageLimit >= 0),
    CONSTRAINT CK_Vouchers_UsedCount CHECK (UsedCount >= 0)
);
GO

-- ----------------------------------------------------------------------------
-- 5. Quan hệ Đăng ký học phần (Enrollments)
-- Quan hệ biểu diễn mối liên kết N-M giữa Users và Courses
-- Lược đồ: Enrollments(EnrollmentID, UserID, CourseID, EnrollDate, OriginalPrice, DiscountAmount, VoucherCode, PaidAmount, Status, Note)
-- Khóa chính: EnrollmentID (RBTV Thực thể)
-- Khóa ngoại: UserID -> Users(UserID), CourseID -> Courses(CourseID) (RBTV Tham chiếu)
-- ----------------------------------------------------------------------------
CREATE TABLE Enrollments (
    -- RBTV Thực thể: Khóa chính tự tăng
    EnrollmentID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Tham chiếu: Khóa ngoại liên kết người dùng và khóa học
    UserID INT NOT NULL,
    CourseID INT NOT NULL,
    EnrollDate DATETIME NOT NULL CONSTRAINT DF_Enrollments_EnrollDate DEFAULT GETDATE(),
    OriginalPrice DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Enrollments_OriginalPrice DEFAULT 0,
    DiscountAmount DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Enrollments_DiscountAmount DEFAULT 0,
    VoucherCode VARCHAR(30) NULL,
    PaidAmount DECIMAL(18, 2) NOT NULL CONSTRAINT DF_Enrollments_PaidAmount DEFAULT 0,
    
    -- RBTV Miền giá trị: Trạng thái chỉ nhận 'Active' (Đang học) hoặc 'Cancelled' (Đã hủy)
    Status NVARCHAR(30) NOT NULL CONSTRAINT DF_Enrollments_Status DEFAULT N'Active',
    Note NVARCHAR(250) NULL,

    CONSTRAINT PK_Enrollments PRIMARY KEY (EnrollmentID),
    CONSTRAINT FK_Enrollments_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT CK_Enrollments_OriginalPrice CHECK (OriginalPrice >= 0),
    CONSTRAINT CK_Enrollments_DiscountAmount CHECK (DiscountAmount >= 0),
    CONSTRAINT CK_Enrollments_PaidAmount CHECK (PaidAmount >= 0),
    CONSTRAINT CK_Enrollments_Status CHECK (Status IN (N'Active', N'Cancelled'))
);
GO

-- ----------------------------------------------------------------------------
-- 6. Quan hệ Đánh giá chất lượng khóa học (CourseReviews)
-- Lược đồ: CourseReviews(ReviewID, CourseID, UserID, Rating, Comment, CreatedAt)
-- Khóa chính: ReviewID (RBTV Thực thể)
-- Khóa ngoại: CourseID -> Courses(CourseID), UserID -> Users(UserID) (RBTV Tham chiếu)
-- ----------------------------------------------------------------------------
CREATE TABLE CourseReviews (
    -- RBTV Thực thể: Khóa chính tự tăng
    ReviewID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Tham chiếu: Khóa ngoại trỏ về khóa học và học viên thực hiện đánh giá
    CourseID INT NOT NULL,
    UserID INT NOT NULL,
    
    -- RBTV Miền giá trị: Điểm xếp hạng từ 1 đến 5 sao
    Rating INT NOT NULL,
    Comment NVARCHAR(500) NOT NULL,
    CreatedAt DATETIME NOT NULL CONSTRAINT DF_CourseReviews_CreatedAt DEFAULT GETDATE(),

    CONSTRAINT PK_CourseReviews PRIMARY KEY (ReviewID),
    CONSTRAINT FK_CourseReviews_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT FK_CourseReviews_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT CK_CourseReviews_Rating CHECK (Rating BETWEEN 1 AND 5)
);
GO

-- ----------------------------------------------------------------------------
-- 7. Quan hệ Giao dịch học phí (WalletTransactions)
-- Lược đồ: WalletTransactions(TransactionID, UserID, Amount, TransactionType, Description, CreatedAt)
-- Khóa chính: TransactionID (RBTV Thực thể)
-- Khóa ngoại: UserID -> Users(UserID) (RBTV Tham chiếu)
-- ----------------------------------------------------------------------------
CREATE TABLE WalletTransactions (
    -- RBTV Thực thể: Khóa chính tự tăng
    TransactionID INT IDENTITY(1,1) NOT NULL,
    
    -- RBTV Tham chiếu: Khóa ngoại liên kết tài khoản phát sinh giao dịch
    UserID INT NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    
    -- RBTV Miền giá trị: Loại biến động số dư xác định
    TransactionType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(250) NOT NULL,
    CreatedAt DATETIME NOT NULL CONSTRAINT DF_WalletTransactions_CreatedAt DEFAULT GETDATE(),

    CONSTRAINT PK_WalletTransactions PRIMARY KEY (TransactionID),
    CONSTRAINT FK_WalletTransactions_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT CK_WalletTransactions_TransactionType CHECK (TransactionType IN (N'Deposit', N'Purchase', N'Refund'))
);
GO

-- ============================================================================
-- PHẦN II: NGÔN NGỮ THAO TÁC DỮ LIỆU (DML - DATA MANIPULATION LANGUAGE)
-- KHỞI TẠO CÁC BỘ DỮ LIỆU MẪU (SEED TUPLES)
-- ============================================================================

-- 1. Thêm bộ dữ liệu cho Quan hệ Categories
INSERT INTO Categories (CategoryName, Description) VALUES
(N'Lập trình .NET & Desktop', N'Phát triển ứng dụng Windows Forms, WPF, LINQ và ASP.NET Core'),
(N'Lập trình Web', N'HTML/CSS, JavaScript, React, Node.js và kiến trúc ứng dụng Web'),
(N'Khoa học dữ liệu & AI', N'Phân tích dữ liệu với SQL, Python và nhập môn Học máy'),
(N'Lập trình di động', N'Phát triển ứng dụng di động đa nền tảng với Flutter và Android'),
(N'Ngoại ngữ chuyên ngành', N'Tiếng Anh đọc hiểu tài liệu kỹ thuật và giao tiếp chuyên ngành CNTT');
GO

-- 2. Thêm bộ dữ liệu cho Quan hệ Users
INSERT INTO Users (Username, Password, FullName, Email, Phone, Role, Balance, IsActive, CreatedAt) VALUES
('admin', '123456', N'Quản trị viên hệ thống', 'admin@daotao.edu.vn', '0901234567', 'Admin', 0, 1, DATEADD(DAY, -30, GETDATE())),
('hocvien1', '123456', N'Nguyễn Minh Tuấn', 'minhtuan@gmail.com', '0912345678', 'Student', 2500000, 1, DATEADD(DAY, -20, GETDATE())),
('hocvien2', '123456', N'Trần Thu Hà', 'thuha.tran@gmail.com', '0987654321', 'Student', 1800000, 1, DATEADD(DAY, -15, GETDATE())),
('hocvien3', '123456', N'Lê Hoàng Nam', 'hoangnam.le@gmail.com', '0933445566', 'Student', 1200000, 1, DATEADD(DAY, -10, GETDATE())),
('hocvien4', '123456', N'Phạm Khánh Linh', 'khanhlinh@gmail.com', '0977889900', 'Student', 3200000, 1, DATEADD(DAY, -5, GETDATE()));
GO

-- 3. Thêm bộ dữ liệu cho Quan hệ Courses
INSERT INTO Courses (CourseCode, CourseName, CategoryID, Instructor, Price, DurationHours, MaxStudents, StartDate, StudyDays, StudyShift, Room, Description, IsActive) VALUES
('NET101', N'Lập trình Windows Forms với C# và LINQ', 1, N'ThS. Nguyễn Văn An', 800000, 45, 35, DATEADD(DAY, 7, CAST(GETDATE() AS DATE)), '2,4,6', N'Ca tối (18:00 - 20:30)', N'Phòng Lab A201', N'Thiết kế giao diện Windows Forms, truy vấn cơ sở dữ liệu với LINQ to SQL và xây dựng ứng dụng quản lý trên .NET Framework.', 1),
('NET202', N'Phát triển Web API với ASP.NET Core', 1, N'ThS. Nguyễn Văn An', 1200000, 60, 30, DATEADD(DAY, 14, CAST(GETDATE() AS DATE)), '3,5,7', N'Ca tối (18:00 - 20:30)', N'Phòng Lab A202', N'Xây dựng dịch vụ RESTful API, phân quyền truy cập và kết nối cơ sở dữ liệu SQL Server.', 1),
('WEB105', N'Phát triển giao diện Web với React và TypeScript', 2, N'KS. Trần Quốc Bảo', 950000, 48, 40, DATEADD(DAY, 10, CAST(GETDATE() AS DATE)), '2,4,6', N'Ca tối (18:00 - 20:30)', N'Phòng Lab B102', N'Xây dựng giao diện người dùng dạng Single Page Application với React Hooks và TypeScript.', 1),
('WEB210', N'Lập trình ứng dụng Web với Node.js và CSDL', 2, N'KS. Trần Quốc Bảo', 1150000, 54, 30, DATEADD(DAY, 21, CAST(GETDATE() AS DATE)), '3,5,7', N'Ca chiều (14:00 - 16:30)', N'Phòng Lab B104', N'Phát triển phía máy chủ với Node.js, Express và thiết kế cơ sở dữ liệu quan hệ.', 1),
('DAI101', N'Phân tích dữ liệu với SQL và Python', 3, N'TS. Lê Minh Châu', 900000, 42, 45, DATEADD(DAY, 5, CAST(GETDATE() AS DATE)), '3,5,7', N'Ca sáng (08:00 - 10:30)', N'Phòng A301', N'Truy vấn tổng hợp dữ liệu, xử lý bảng biểu với Pandas và trực quan hóa báo cáo cơ bản.', 1),
('DAI301', N'Nhập môn Học máy và ứng dụng', 3, N'TS. Lê Minh Châu', 1500000, 60, 25, DATEADD(DAY, 25, CAST(GETDATE() AS DATE)), '7,CN', N'Ca sáng (08:00 - 10:30)', N'Phòng Lab C201', N'Các thuật toán học có giám sát, đánh giá mô hình và ứng dụng trong bài toán phân loại, dự báo.', 1),
('MOB102', N'Phát triển ứng dụng di động với Flutter', 4, N'ThS. Đặng Quốc Huy', 1100000, 50, 30, DATEADD(DAY, 12, CAST(GETDATE() AS DATE)), '2,4,6', N'Ca chiều (14:00 - 16:30)', N'Phòng Lab B203', N'Lập trình ngôn ngữ Dart, thiết kế giao diện đa nền tảng và kết nối REST API trên thiết bị di động.', 1),
('ENG100', N'Tiếng Anh chuyên ngành Công nghệ thông tin', 5, N'ThS. Vũ Thanh Mai', 650000, 36, 50, DATEADD(DAY, 3, CAST(GETDATE() AS DATE)), '7,CN', N'Ca chiều (14:00 - 16:30)', N'Phòng A105', N'Thuật ngữ chuyên ngành phần mềm, đọc hiểu tài liệu kỹ thuật và viết báo cáo công việc.', 1);
GO

-- 4. Thêm bộ dữ liệu cho Quan hệ Vouchers
INSERT INTO Vouchers (VoucherCode, Description, DiscountPercent, DiscountAmount, MaxDiscountAmount, MinOrderAmount, UsageLimit, UsedCount, ExpiryDate, IsActive) VALUES
('SVCNTT15', N'Miễn giảm 15% học phí cho sinh viên chuyên ngành CNTT', 15, 0, 250000, 500000, 100, 2, DATEADD(MONTH, 3, CAST(GETDATE() AS DATE)), 1),
('NHAPHOC100', N'Hỗ trợ 100.000 VNĐ học phí đợt khai giảng học kỳ mới', 0, 100000, 0, 600000, 50, 1, DATEADD(MONTH, 2, CAST(GETDATE() AS DATE)), 1),
('HOCBONG25', N'Học bổng khuyến khích học tập giảm 25% (tối đa 400.000 VNĐ)', 25, 0, 400000, 1000000, 20, 0, DATEADD(MONTH, 4, CAST(GETDATE() AS DATE)), 1);
GO

-- 5. Thêm bộ dữ liệu cho Quan hệ WalletTransactions
INSERT INTO WalletTransactions (UserID, Amount, TransactionType, Description, CreatedAt) VALUES
(2, 3980000, N'Deposit', N'Nộp học phí (Chuyển khoản ngân hàng)', DATEADD(DAY, -19, GETDATE())),
(2, -680000, N'Purchase', N'Thanh toán khóa học [NET101] (áp dụng mã SVCNTT15)', DATEADD(DAY, -18, GETDATE())),
(2, -800000, N'Purchase', N'Thanh toán khóa học [DAI101] (áp dụng mã NHAPHOC100)', DATEADD(DAY, -16, GETDATE())),
(3, 2750000, N'Deposit', N'Nộp học phí (Nộp trực tiếp tại phòng giáo vụ)', DATEADD(DAY, -14, GETDATE())),
(3, -950000, N'Purchase', N'Thanh toán khóa học [WEB105] Phát triển giao diện Web với React và TypeScript', DATEADD(DAY, -13, GETDATE())),
(4, 2100000, N'Deposit', N'Nộp học phí (Thanh toán qua cổng học vụ)', DATEADD(DAY, -9, GETDATE())),
(4, -900000, N'Purchase', N'Thanh toán khóa học [DAI101] Phân tích dữ liệu với SQL và Python', DATEADD(DAY, -8, GETDATE())),
(5, 4392500, N'Deposit', N'Nộp học phí (Chuyển khoản ngân hàng)', DATEADD(DAY, -4, GETDATE())),
(5, -650000, N'Purchase', N'Thanh toán khóa học [ENG100] Tiếng Anh chuyên ngành Công nghệ thông tin', DATEADD(DAY, -3, GETDATE())),
(5, -935000, N'Purchase', N'Thanh toán khóa học [MOB102] (áp dụng mã SVCNTT15)', DATEADD(DAY, -2, GETDATE()));
GO

-- Cập nhật số dư cho Users sau các giao dịch
UPDATE Users SET Balance = 2500000 WHERE UserID = 2;
UPDATE Users SET Balance = 1800000 WHERE UserID = 3;
UPDATE Users SET Balance = 1200000 WHERE UserID = 4;
UPDATE Users SET Balance = 2807500 WHERE UserID = 5;
GO

-- 6. Thêm bộ dữ liệu cho Quan hệ Enrollments
INSERT INTO Enrollments (UserID, CourseID, EnrollDate, OriginalPrice, DiscountAmount, VoucherCode, PaidAmount, Status, Note) VALUES
(2, 1, DATEADD(DAY, -18, GETDATE()), 800000, 120000, 'SVCNTT15', 680000, N'Active', N'Lớp tối thứ 2 - 4 - 6'),
(2, 5, DATEADD(DAY, -16, GETDATE()), 900000, 100000, 'NHAPHOC100', 800000, N'Active', N'Đăng ký học song song sáng 3 - 5 - 7'),
(3, 3, DATEADD(DAY, -13, GETDATE()), 950000, 0, NULL, 950000, N'Active', N'Đăng ký nhận giáo trình bản in'),
(4, 5, DATEADD(DAY, -8, GETDATE()), 900000, 0, NULL, 900000, N'Active', N'Sinh viên năm 3 khoa CNTT'),
(5, 8, DATEADD(DAY, -3, GETDATE()), 650000, 0, NULL, 650000, N'Active', N'Lớp chiều cuối tuần'),
(5, 7, DATEADD(DAY, -2, GETDATE()), 1100000, 165000, 'SVCNTT15', 935000, N'Active', N'Lớp chiều 2 - 4 - 6');
GO

-- 7. Thêm bộ dữ liệu cho Quan hệ CourseReviews
INSERT INTO CourseReviews (CourseID, UserID, Rating, Comment, CreatedAt) VALUES
(1, 2, 5, N'Giáo trình rõ ràng, phần thực hành Windows Forms Designer và LINQ to SQL sát với đồ án môn học.', DATEADD(DAY, -10, GETDATE())),
(5, 2, 5, N'Bài giảng SQL và Python mạch lạc, nhiều bài tập phân tích dữ liệu thực tế.', DATEADD(DAY, -7, GETDATE())),
(3, 3, 4, N'Nội dung TypeScript kỹ, giảng viên giải đáp thắc mắc chi tiết trong giờ thực hành.', DATEADD(DAY, -6, GETDATE())),
(5, 4, 4, N'Phòng học đầy đủ máy cấu hình tốt, tài liệu tham khảo dễ hiểu.', DATEADD(DAY, -4, GETDATE())),
(8, 5, 5, N'Từ vựng chuyên ngành CNTT được hệ thống bài bản, rất hữu ích khi đọc tài liệu tiếng Anh.', DATEADD(DAY, -1, GETDATE())),
(7, 5, 5, N'Hướng dẫn cấu trúc dự án Flutter dễ hiểu, phù hợp cho người mới bắt đầu.', GETDATE());
GO
