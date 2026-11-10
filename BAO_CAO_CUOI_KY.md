# BÁO CÁO TIỂU LUẬN HỌC THUẬT

## HỌC PHẦN: LẬP TRÌNH TRÊN MÔI TRƯỜNG WINDOWS / CƠ SỞ DỮ LIỆU

---

# ĐỀ TÀI: XÂY DỰNG HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC
## (ACADEMIC COURSE REGISTRATION SYSTEM)

- Đơn vị đào tạo: Trường Đại học Sư phạm Thành phố Hồ Chí Minh – Khoa Công nghệ Thông tin
- Nền tảng kỹ thuật: Microsoft .NET Framework 4.8 (C# Windows Forms), Visual Studio Designer (*.Designer.cs)
- Công nghệ cơ sở dữ liệu: Microsoft SQL Server, Ánh xạ O/R qua LINQ to SQL (CourseRegistration.dbml)
- Sinh viên thực hiện:
  1. Trần Ngọc Hà – MSSV: 51.01.104.020
  2. Hồ Minh Nhật – MSSV: 51.01.104.065 (Trưởng nhóm)
  3. Đào Khánh Trúc – MSSV: 51.01.104.109
  4. Phan Thị Trang – MSSV: 51.01.104.102
- Giảng viên hướng dẫn: Bộ môn Công nghệ Phần mềm

---

## LỜI CAM ĐOAN VÀ BẢNG PHÂN CÔNG NHIỆM VỤ (WBS)

Nhóm sinh viên cam đoan toàn bộ mã nguồn, cơ sở dữ liệu và tài liệu này là kết quả thực hiện độc lập, trung thực của nhóm dưới sự hướng dẫn của Giảng viên.

### Bảng 1.1. Bảng phân công công việc theo cấu trúc WBS và Tiến trình nội dung đề tài

| Giai đoạn | Sinh viên phụ trách | MSSV | Vai trò kỹ thuật trong đồ án | Nội dung soạn thảo tiểu luận | Tỷ lệ đóng góp | Mức độ hoàn thành | Đánh giá |
| :-: | :--- | :-: | :--- | :--- | :-: | :-: | :-: |
| **Giai đoạn 1** | **Trần Ngọc Hà** | 51.01.104.020 | Khảo sát đề tài, CSDL 7 bảng, LINQ to SQL, Form Login/Register, Cấu hình App.config | **Phần 1:** Tổng quan đề tài, CSDL 7 bảng chuẩn 3NF/BCNF, 4 nhóm RBTV, Form Đăng nhập & Đăng ký, Cấu hình App.config | **28%** | **100%** | **A (Tốt)** |
| **Giai đoạn 2** | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | Kiến trúc 3 tầng, Quản trị viên, Thuật toán trùng lịch, Bảo mật PBKDF2/AES, Giao dịch ACID | **Phần 2:** Kiến trúc 3 tầng, Cổng Quản trị FrmAdminMain, Bảo mật PBKDF2/RBAC, Thuật toán ScheduleHelper, ACID, Đóng gói setup, Xuất Excel XML | **32%** | **100%** | **A+ (Xuất sắc)** |
| **Giai đoạn 3** | **Đào Khánh Trúc** | 51.01.104.109 | Cổng Học viên 6 Tab, TKB ma trận, Trọn bộ 3 Báo cáo RDLC, In Barcode, Biểu đồ MS Chart | **Phần 3:** Cổng Học viên 15 Forms, Bố cục Responsive, Thời khóa biểu ma trận, 3 Báo cáo RDLC, In Barcode GDI+, Biểu đồ MS Chart, Modern UI | **28%** | **100%** | **A (Tốt)** |
| **Giai đoạn 4** | **Phan Thị Trang** | 51.01.104.102 | Hỗ trợ chạy thử nghiệm trên giao diện & Ghi nhận kết quả kiểm thử | **Phần 4:** Hỗ trợ chạy thử nghiệm hộp đen trên giao diện và ghi nhận số liệu Bảng 10 Test Cases | **12%** | **85%** | **B (Đạt cơ bản)** |

---

## MỤC LỤC TỔNG QUAN

1. [Phần I: Lời cam đoan và Bảng phân công nhiệm vụ (WBS)](#lời-cam-đoan-và-bảng-phân-công-nhiệm-vụ-wbs)
2. [Danh mục bảng biểu và sơ đồ](#danh-mục-bảng-biểu-và-sơ-đồ)
3. [Phần 1: Tổng quan đề tài, Cơ sở dữ liệu và Cấu hình App.config (Phụ trách: Trần Ngọc Hà)](#phần-1-tổng-quan-đề-tài-cơ-sở-dữ-liệu-và-cấu-hình-appconfig)
4. [Phần 2: Kiến trúc hệ thống, Quản trị viên và Thuật toán lõi (Phụ trách: Hồ Minh Nhật)](#phần-2-kiến-trúc-hệ-thống-quản-trị-viên-và-thuật-toán-lõi)
5. [Phần 3: Cổng Học viên, Thời khóa biểu, Trọn bộ Báo cáo in ấn và Biểu đồ (Phụ trách: Đào Khánh Trúc)](#phần-3-cổng-học-viên-thời-khóa-biểu-trọn-bộ-báo-cáo-in-ấn-và-biểu-đồ)
6. [Phần 4: Kết quả Thực thi Kiểm thử Hệ thống (Phụ trách: Phan Thị Trang)](#phần-4-kết-quả-thực-thi-kiểm-thử-hệ-thống)
7. [Phần Kết luận, Tài liệu tham khảo (Chuẩn IEEE) và Phụ lục](#phần-kết-luận-và-phụ-lục)

---

## DANH MỤC BẢNG BIỂU VÀ SƠ ĐỒ

- Bảng 1.1: Bảng phân công công việc theo cấu trúc WBS và Tiến trình nội dung đề tài
- Bảng 1.2: Danh mục 7 bảng thực thể trong cơ sở dữ liệu CourseRegistrationDB
- Bảng 1.3: Đặc tả 4 nhóm Ràng buộc toàn vẹn chuẩn mực trong CSDL
- Bảng 3.1: Danh mục đối ứng 15 Form / Màn hình chức năng trong hệ thống
- Bảng 4.1: Bảng kết quả thực thi 10 Ca kiểm thử hệ thống (TC01 đến TC10)
- Bảng 5.1: Danh mục tài khoản đăng nhập kiểm thử hệ thống

---

## PHẦN 1: TỔNG QUAN ĐỀ TÀI, CƠ SỞ DỮ LIỆU VÀ CẤU HÌNH APP.CONFIG
> **Phụ trách chính:** **Trần Ngọc Hà** (MSSV: `51.01.104.020`)

### 1.1. Bối cảnh thực tế và Mục tiêu hệ thống
- Phân tích vấn nạn quản lý đào tạo thủ công và tính cấp thiết của đề tài.
- Xác định mục tiêu kỹ thuật: 100% Visual Studio Designer, CSDL quan hệ chuẩn hóa và LINQ to SQL.

### 1.2. Thiết kế Cơ sở dữ liệu 7 bảng quan hệ (`CourseRegistrationDB`)
- Đặc tả danh mục 7 bảng: `Users`, `Categories`, `Courses`, `Enrollments`, `Vouchers`, `CourseReviews`, `WalletTransactions`.

#### Bảng 1.2. Danh mục 7 bảng thực thể trong cơ sở dữ liệu CourseRegistrationDB

| STT | Tên bảng CSDL | Ý nghĩa thực thể | Khóa chính (PK) | Khóa ngoại (FK) | Ràng buộc duy nhất (Unique) |
| :-: | :--- | :--- | :--- | :--- | :--- |
| **1** | `Users` | Tài khoản người dùng | `UserID` (INT IDENTITY) | Không | `Username` |
| **2** | `Categories` | Danh mục chuyên ngành | `CategoryID` (INT IDENTITY) | Không | `CategoryCode` |
| **3** | `Courses` | Thông tin lớp học | `CourseID` (INT IDENTITY) | `CategoryID` | `CourseCode` |
| **4** | `Enrollments` | Đơn đăng ký môn học | `EnrollmentID` (INT IDENTITY)| `UserID`, `CourseID`, `VoucherID` | Không |
| **5** | `Vouchers` | Mã ưu đãi học bổng | `VoucherID` (INT IDENTITY) | Không | `VoucherCode` |
| **6** | `CourseReviews`| Đánh giá chất lượng | `ReviewID` (INT IDENTITY) | `UserID`, `CourseID` | Không |
| **7** | `WalletTransactions`| Lịch sử giao dịch ví | `TransactionID` (INT IDENTITY)| `UserID` | Không |

### 1.3. Đặc tả 4 nhóm Ràng buộc toàn vẹn (RBTV) chuẩn mực

#### Bảng 1.3. Đặc tả 4 nhóm Ràng buộc toàn vẹn chuẩn mực trong CSDL

| Nhóm RBTV | Tên ràng buộc trong CSDL | Ý nghĩa học thuật | Biểu thức cài đặt SQL Server DDL |
| :--- | :--- | :--- | :--- |
| **Miền giá trị (Domain)** | `CK_Courses_Price`<br>`CK_Reviews_Rating`<br>`CK_Vouchers_Percent` | Bảo đảm thuộc tính nằm trong khoảng logic: Học phí không âm (`Price >= 0`), điểm sao đánh giá từ 1 đến 5 sao, % giảm giá từ 1 đến 100%. | `ALTER TABLE Courses ADD CONSTRAINT CK_Courses_Price CHECK (Price >= 0);`<br>`ALTER TABLE CourseReviews ADD CONSTRAINT CK_Reviews_Rating CHECK (Rating BETWEEN 1 AND 5);`<br>`ALTER TABLE Vouchers ADD CONSTRAINT CK_Vouchers_Percent CHECK (DiscountPercent BETWEEN 1 AND 100);` |
| **Thực thể (Entity)** | Khóa chính trên 7 bảng: `PK_Users`, `PK_Courses`, `PK_Categories`, `PK_Enrollments`, `PK_Vouchers`, `PK_Reviews`, `PK_Wallet` | Mỗi bản ghi đại diện cho một đối tượng duy nhất, khóa chính kiểu `INT IDENTITY(1,1)` không mang giá trị NULL, tự động tăng. | `CourseID INT IDENTITY(1,1) PRIMARY KEY`,<br>`UserID INT IDENTITY(1,1) PRIMARY KEY` |
| **Tham chiếu (Referential)** | `FK_Courses_Categories`<br>`FK_Enrollments_Users`<br>`FK_Enrollments_Courses`<br>`FK_Wallet_Users` | Bảo đảm tính toàn vẹn liên kết cha - con. Không thể thêm môn học vào danh mục không tồn tại; không thể xóa tài khoản đã có lịch sử đăng ký học phần. | `ALTER TABLE Courses ADD CONSTRAINT FK_Courses_Categories FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID);`<br>`ALTER TABLE Enrollments ADD CONSTRAINT FK_Enrollments_Users FOREIGN KEY (UserID) REFERENCES Users(UserID);` |
| **Nghiệp vụ (Business Rules)** | `UQ_Users_Username`<br>`UQ_Courses_CourseCode`<br>`UQ_Vouchers_Code`<br>`CK_Users_Balance` | Tên đăng nhập và Mã khóa học là duy nhất toàn trường; số dư tài khoản ví của học viên không bao giờ được phép âm (`Balance >= 0`). | `ALTER TABLE Users ADD CONSTRAINT UQ_Users_Username UNIQUE (Username);`<br>`ALTER TABLE Courses ADD CONSTRAINT UQ_Courses_Code UNIQUE (CourseCode);`<br>`ALTER TABLE Users ADD CONSTRAINT CK_Users_Balance CHECK (Balance >= 0);` |

### 1.4. Chứng minh Dạng chuẩn 3NF / BCNF & Ánh xạ LINQ to SQL
- Dùng phụ thuộc hàm (PTH) chứng minh bảng `Courses` đạt chuẩn BCNF và `Enrollments` đạt chuẩn 3NF.
- Sơ đồ quan hệ ERD bản số `(min, max)` và ánh xạ O/R qua `CourseRegistration.dbml`.

### 1.5. Cửa ngõ xác thực người dùng (Form Đăng nhập & Đăng ký)
- Thiết kế `FrmLogin` và `FrmRegister` trên WinForms Designer; kiểm tra tính hợp lệ dữ liệu nhập (Validation).

### 1.6. Quản lý cấu hình kết nối App.config
- Lưu chuỗi kết nối trong `App.config`, không hard-code mã nguồn; cơ chế tự động dò tìm máy chủ SQL Server của `DbHelper.cs`.

---

## PHẦN 2: KIẾN TRÚC HỆ THỐNG, QUẢN TRỊ VIÊN VÀ THUẬT TOÁN LÕI
> **Phụ trách chính:** **Hồ Minh Nhật** (MSSV: `51.01.104.065` – Trưởng nhóm)

### 2.1. Kiến trúc 3 tầng (3-Tier Architecture)
- Phân tích ranh giới nhiệm vụ giữa Presentation Layer, Business Logic Layer & Helpers, Data Access Layer.

### 2.2. Cơ chế Mã hóa mật khẩu PBKDF2 & Phân quyền người dùng (RBAC)
- Thuật toán băm một chiều an toàn **PBKDF2 (RFC 2898)** kết hợp HMAC-SHA256, Salt 16 bytes và 10.000 vòng lặp (không lưu Plain Text).
- Quản lý phiên làm việc tĩnh `UserSession` và phân quyền RBAC (Admin / Student); tự động ẩn/hiện (`Visible`) và khóa/mở (`Enabled`) menu.
- **Cơ chế 4 lớp bảo vệ tài khoản Quản trị:** Khóa nút xóa trên UI, chặn tự xóa tại code, cấm xóa Admin duy nhất, tự phục hồi khẩn cấp.

### 2.3. Màn hình Quản trị trung tâm (`FrmAdminMain`)
- Quản lý Khóa học, Danh mục chuyên ngành, Tài khoản và Voucher bằng LINQ to SQL.

### 2.4. Thuật toán phát hiện xung đột lịch học đa chiều (`ScheduleHelper.cs`)
- Giải thuật so sánh Ca học (`Shift`) và giao tập hợp Thứ học (`StudyDays`) để chặn trùng lịch học viên, giảng viên và phòng học.
- Trích đoạn mã nguồn C# hàm `HasScheduleConflict`.

### 2.5. Bảo đảm tính toàn vẹn giao dịch (ACID)
- Đồng bộ giao dịch trong `DataContext.SubmitChanges()` (Commit / Rollback toàn phần).

### 2.6. Đóng gói cài đặt & Tự động phục hồi CSDL
- Tệp chạy sẵn `Course Registration.exe` và kịch bản `Database.sql` tự động tạo bảng và nạp dữ liệu mẫu ban đầu.

### 2.7. Xuất bảng tính Excel XML độc lập
- Lớp `ExcelExporter.cs` kết xuất định dạng XML Spreadsheet 2003 chuẩn của Microsoft, mở mượt mà trên Excel và Google Sheets mà không cần cài bộ Office.

---

## PHẦN 3: CỔNG HỌC VIÊN, THỜI KHÓA BIỂU, TRỌN BỘ BÁO CÁO IN ẤN VÀ BIỂU ĐỒ
> **Phụ trách chính:** **Đào Khánh Trúc** (MSSV: `51.01.104.109`)

### 3.1. Hệ thống 15 Màn hình / Forms chức năng
- Nguyên tắc thiết kế 100% Visual Studio Designer (*.Designer.cs), không tạo control động ở runtime; bố cục thích ứng (Responsive Layout: Dock, Anchor, AutoSizeColumnsMode).

#### Bảng 3.1. Danh mục đối ứng 15 Form / Màn hình chức năng trong hệ thống

| STT | Tên Form trong hệ thống | Loại Form / Vai trò chức năng | Phụ trách kỹ thuật | Mô tả chức năng và Kỹ thuật LINQ áp dụng |
| :-: | :--- | :--- | :---: | :--- |
| **1** | `FrmLogin` | Đăng nhập hệ thống (frmLogin) | Trần Ngọc Hà | Xác thực tài khoản, kiểm tra mật khẩu qua PBKDF2, nạp nhanh tài khoản kiểm thử. |
| **2** | `FrmRegister` | Tạo tài khoản học viên | Trần Ngọc Hà | Đăng ký tài khoản học viên mới, kiểm tra trùng lặp tài khoản. |
| **3** | `FrmAdminMain` | Giao diện Quản trị (frmMain) | Hồ Minh Nhật | Bảng điều khiển quản trị trung tâm, điều hướng và kiểm soát phân quyền hệ thống. |
| **4** | `FrmStudentMain` | Cổng Học viên (frmMain) | Đào Khánh Trúc | Màn hình chính học viên: tra cứu khóa học, hiển thị số dư ví và điều hướng chức năng. |
| **5** | Module `TabProfile` | Đổi mật khẩu (frmChangePassword) | Đào Khánh Trúc | Đổi mật khẩu học viên, xác thực mật khẩu cũ qua mã băm và cập nhật mật khẩu mới. |
| **6** | Module `TabUserManagement` | Quản lý người dùng (frmUserManagement) | Hồ Minh Nhật | Quản lý danh sách người dùng, kích hoạt / khóa tài khoản, cấp lại mật khẩu. |
| **7** | Module `TabRoleManagement` | Quản lý phân quyền (frmRoleManagement) | Hồ Minh Nhật | Phân quyền vai trò (Admin / Student), cài đặt 4 lớp bảo vệ tài khoản Quản trị duy nhất. |
| **8** | Module `TabCourseManagement` | Quản lý Khóa học (CRUD) | Hồ Minh Nhật | Thêm, sửa, xóa khóa học; kiểm tra xung đột phòng học và giảng viên. |
| **9** | Module `TabCategoryManagement` | Quản lý Danh mục (CRUD) | Hồ Minh Nhật | Quản lý danh mục chuyên ngành đào tạo (Lập trình, Thiết kế, Ngoại ngữ, Dữ liệu). |
| **10** | Module `TabVoucherManagement` | Quản lý Ưu đãi (CRUD) | Hồ Minh Nhật | Quản lý mã giảm giá học phí (Hạn dùng, số lượt, mức giảm tối đa, học phí tối thiểu). |
| **11** | Module `TabCourseCatalog` | Tra cứu & Đăng ký môn | Đào Khánh Trúc | Lọc khóa học theo danh mục, tìm kiếm theo từ khóa qua LINQ Lambda. |
| **12** | Module `TabTimetableMatrix` | Thời khóa biểu ma trận | Đào Khánh Trúc | Hiển thị lịch học tuần dạng ma trận 3 ca x 7 ngày tự động theo các môn đã đăng ký. |
| **13** | Module `TabWallet` | Giao dịch / Ví học phí | Đào Khánh Trúc | Nạp tiền vào ví, kiểm tra số dư và trừ học phí tự động theo thời gian thực. |
| **14** | Module `TabCourseReview` | Đánh giá môn học | Đào Khánh Trúc | Học viên gửi đánh giá sao (1-5 sao) và nhận xét phản hồi chất lượng đào tạo. |
| **15** | `FrmReportViewer` | Báo cáo & In ấn (frmReportViewer) | Đào Khánh Trúc | Trình xem và in ấn báo cáo chuyên nghiệp: RptReceipt, RptCourseRevenue, RptStudentClassList. |

### 3.2. Cổng Học viên (`FrmStudentMain` 6 Tab) & Ma trận Thời khóa biểu tuần
- Thiết kế 6 Tab chức năng; thuật toán ánh xạ lịch học lên lưới ma trận 8 cột (Ca học + Thứ 2 đến CN) và 3 ca cố định.

### 3.3. Thiết kế trọn bộ 3 Mẫu Báo cáo in ấn Microsoft RDLC
- `RptReceipt.rdlc`: Biên lai thu học phí khổ đứng A4 Portrait.
- `RptCourseRevenue.rdlc`: Báo cáo doanh thu khóa học kèm dòng tổng kết hệ thống (`=Sum(...)`).
- `RptStudentClassList.rdlc`: Báo cáo danh sách lớp học khổ ngang A4 Landscape.
- Phân tích kỹ thuật truyền tham số `ReportParameter` và nguồn bảng `ReportDataSource`.

### 3.4. Đồ họa in ấn biên lai GDI+ & Vẽ mã vạch Barcode Code39
- Lớp `ReceiptPrinter.cs` sử dụng `PrintDocument` vẽ trực tiếp biên lai bằng GDI+ kèm mã vạch Code39.

### 3.5. Biểu đồ Thống kê đồ họa (MS Chart)
- Thư viện `System.Windows.Forms.DataVisualization.Charting`: Biểu đồ cột doanh thu theo môn học và Biểu đồ tròn cơ cấu danh mục; LINQ `GroupBy` và `Sum`.

### 3.6. Giao diện Modern UI
- Bảng màu phẳng, Card View (`FrmAbout.cs`), DataGridView định dạng sọc xen kẽ (Zebra).

---

## PHẦN 4: KẾT QUẢ THỰC THI KIỂM THỬ HỆ THỐNG
> **Phụ trách chính:** **Phan Thị Trang** (MSSV: `51.01.104.102`)

### 4.1. Hỗ trợ chạy thử nghiệm hộp đen trên giao diện
- Khái niệm kiểm thử hộp đen (Black-Box Testing), phân tích giá trị biên (BVA) và phân vùng tương đương.
- Trình bày kết quả thực thi kiểm thử các chức năng chính trên giao diện phần mềm.

### 4.2. Bảng kết quả thực thi 10 Ca kiểm thử hệ thống (TC01 đến TC10)

#### Bảng 4.1. Bảng kết quả thực thi 10 Ca kiểm thử hệ thống (TC01 đến TC10)

| Mã TC | Nội dung kiểm thử | Thao tác và Dữ liệu đầu vào | Kết quả mong đợi | Kết quả thực tế | Trạng thái |
| :-: | :--- | :--- | :--- | :--- | :-: |
| **TC01** | Đăng nhập thất bại | Nhập username "admin", password sai "000000" | Hiển thị cảnh báo lỗi, không chuyển màn hình | Báo lỗi chính xác, xóa ô mật khẩu | Đạt |
| **TC02** | Đăng nhập thành công | Nhập đúng "admin" / "123456" | Mở màn hình Quản trị FrmAdminMain, lưu UserSession | Mở đúng FrmAdminMain, nạp quyền Admin | Đạt |
| **TC03** | Đăng ký trùng username | Đăng ký tài khoản mới với username "hocvien1" | Báo lỗi tài khoản đã tồn tại, từ chối lưu CSDL | Bật cảnh báo trùng lặp, từ chối thêm mới | Đạt |
| **TC04** | Kiểm tra trùng lịch học | Học viên đã học Ca Tối 2-4-6, đăng ký thêm môn khác cũng học Ca Tối 2-4-6 | Báo lỗi trùng khung giờ, chặn giao dịch | ScheduleHelper phát hiện xung đột, chặn lưu | Đạt |
| **TC05** | Số dư ví không đủ | Học phí môn là 1.500.000 VNĐ, số dư ví chỉ có 500.000 VNĐ | Báo lỗi thiếu số dư, yêu cầu nạp thêm ví | Hiển thị cảnh báo số dư không đủ | Đạt |
| **TC06** | Phân tích biên Voucher (BVA) | Voucher yêu cầu tối thiểu 500k. Thử môn 499k (dưới biên) và môn 500k (ngay biên) | Môn 499k: Từ chối áp dụng. Môn 500k: Chấp nhận giảm giá | Từ chối môn 499k, áp dụng đúng cho môn 500k | Đạt |
| **TC07** | Đăng ký thành công & ACID | Học viên đủ tiền, không trùng lịch, nhấn Đăng ký | Đơn tạo thành công, ví trừ tiền, môn hiện trên TKB | Tiền ví trừ đúng, môn nạp ngay lên TKB tuần | Đạt |
| **TC08** | In biên lai học phí GDI+ | Nhấn nút In biên lai tại môn học đã đăng ký | PrintPreviewDialog mở lên, có thông tin và Barcode Code39 | Mẫu in hiển thị sắc nét, barcode căn giữa | Đạt |
| **TC09** | Quản trị xem báo cáo RDLC | Admin chọn báo cáo "Danh sách học viên theo lớp" | Mở FrmReportViewer, nạp đúng tham số và bảng | Báo cáo hiển thị chuẩn xác, cho phép xuất PDF/Excel | Đạt |
| **TC10** | Bảo vệ Admin duy nhất | Admin cố gắng xóa chính mình hoặc xóa Admin duy nhất | Nút xóa bị khóa xám hoặc bị hệ thống từ chối | Nút xóa vô hiệu hóa (Enabled = false), bảo vệ an toàn | Đạt |

---

## PHẦN KẾT LUẬN VÀ PHỤ LỤC

### 5.1. Kết luận và Hướng phát triển
- Đánh giá các mục tiêu hoàn thành, hạn chế (chưa tích hợp VietQR online) và hướng phát triển (Web API, Mobile App).

### 5.2. Tài liệu tham khảo (Chuẩn IEEE)
[1] Microsoft Corporation, ".NET Framework Documentation and Windows Forms Architecture," Microsoft Learn, 2023. [Online]. Available: https://learn.microsoft.com/dotnet/desktop/winforms/  
[2] Microsoft Corporation, "LINQ to SQL: .NET Language-Integrated Query for Relational Data," Microsoft Learn, 2022. [Online]. Available: https://learn.microsoft.com/dotnet/framework/data/adonet/sql/linq/  
[3] R. Elmasri and S. B. Navathe, Fundamentals of Database Systems, 7th ed. Boston, MA, USA: Pearson, 2016.  
[4] C. J. Date, An Introduction to Database Systems, 8th ed. Boston, MA, USA: Addison-Wesley, 2004.  
[5] B. Kaliski, "PKCS #5: Password-Based Cryptography Specification Version 2.0," RFC 2898, RSA Laboratories, Sep. 2000.  
[6] National Institute of Standards and Technology (NIST), "Advanced Encryption Standard (AES)," FIPS PUB 197, Nov. 2001.  
[7] G. J. Myers, C. Sandler, and T. Badgett, The Art of Software Testing, 3rd ed. Hoboken, NJ, USA: John Wiley & Sons, 2011.  
[8] Microsoft Corporation, "Microsoft Reporting Services and RDLC Report Designer Documentation," Microsoft Learn, 2023.

### 5.3. Phụ lục

#### Bảng 5.1. Danh mục tài khoản đăng nhập kiểm thử hệ thống

| Loại tài khoản | Tên đăng nhập | Mật khẩu | Quyền hạn và Chức năng kiểm thử chính |
| :--- | :--- | :--- | :--- |
| **Quản trị viên** | `admin` | `123456` | Toàn quyền Quản trị: Quản lý khóa học, danh mục, tài khoản người dùng, duyệt đăng ký, xem thống kê doanh thu, in 3 mẫu báo cáo RDLC. |
| **Học viên 1** | `hocvien1` | `123456` | Tài khoản học viên (có sẵn ví 5.000.000 VNĐ): Tra cứu môn học, đăng ký môn, xem Thời khóa biểu ma trận tuần, in biên lai học phí GDI+ Barcode, đánh giá sao. |
| **Học viên 2** | `hocvien2` | `123456` | Tài khoản học viên thử nghiệm: Thử nghiệm đăng ký nhiều tài khoản song song, kiểm tra xung đột trùng lịch và kiểm tra số dư ví. |

- Liên kết kho mã nguồn dự án (GitHub): `https://github.com/CourseRegistration-Group/CourseRegistration-WinForms`
- Liên kết video demo vận hành hệ thống (YouTube / Google Drive): `https://drive.google.com/drive/folders/CourseRegistration-Demo-Video`
