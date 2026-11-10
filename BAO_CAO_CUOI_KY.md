# TRƯỜNG ĐẠI HỌC SƯ PHẠM THÀNH PHỐ HỒ CHÍ MINH
## KHOA CÔNG NGHỆ THÔNG TIN
### BỘ MÔN CÔNG NGHỆ PHẦN MỀM

---

# BÁO CÁO TIỂU LUẬN HỌC THUẬT
## HỌC PHẦN: LẬP TRÌNH TRÊN MÔI TRƯỜNG WINDOWS / CƠ SỞ DỮ LIỆU

### ĐỀ TÀI:
# XÂY DỰNG HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC
## (ACADEMIC COURSE REGISTRATION SYSTEM)

- Đơn vị đào tạo: Trường Đại học Sư phạm Thành phố Hồ Chí Minh – Khoa Công nghệ Thông tin
- Nền tảng kỹ thuật: Microsoft .NET Framework 4.8 (C# Windows Forms – 100% Visual Studio Designer)
- Hệ quản trị cơ sở dữ liệu: Microsoft SQL Server, Ánh xạ O/R qua LINQ to SQL (CourseRegistration.dbml)
- Sinh viên thực hiện:
  1. Trần Ngọc Hà – MSSV: 51.01.104.020
  2. Hồ Minh Nhật – MSSV: 51.01.104.065 (Trưởng nhóm)
  3. Đào Khánh Trúc – MSSV: 51.01.104.109
  4. Phan Thị Trang – MSSV: 51.01.104.102
- Giảng viên hướng dẫn: Bộ môn Công nghệ Phần mềm

---

## LỜI CAM ĐOAN

Nhóm sinh viên chúng em xin cam đoan:
1. Toàn bộ mã nguồn chương trình, cơ sở dữ liệu CourseRegistrationDB và tài liệu tiểu luận này là kết quả nghiên cứu, thiết kế và hiện thực độc lập, nghiêm túc của nhóm dưới sự định hướng của Giảng viên bộ môn.
2. Tất cả số liệu, mô hình thực thể quan hệ, bảng dữ liệu kiểm thử và kết quả thực thi trong báo cáo đều được kiểm chứng trực tiếp trên hệ thống phần mềm thực tế, không sao chép trái phép bất kỳ sản phẩm nào có sẵn.
3. Các tài liệu tham khảo, thư viện mã nguồn mở và nền tảng hỗ trợ đều được trích dẫn nguồn gốc rõ ràng, minh bạch theo đúng chuẩn mực học thuật quốc tế (IEEE).

Đại diện nhóm sinh viên: Hồ Minh Nhật (Trưởng nhóm)

---

## BẢNG PHÂN CÔNG NHIỆM VỤ KỸ THUẬT (WBS)

### Bảng 1.1. Bảng phân công nhiệm vụ kỹ thuật theo tiến trình nội dung đề tài

| STT | Họ và tên sinh viên | MSSV | Phần phụ trách | Nhiệm vụ kỹ thuật và Nội dung báo cáo | Tỷ lệ đóng góp | Mức độ hoàn thành | Đánh giá |
| :-: | :--- | :-: | :---: | :--- | :-: | :-: | :-: |
| **1** | **Trần Ngọc Hà** | 51.01.104.020 | **Phần 1** | Khảo sát nghiệp vụ; Thiết kế CSDL 7 bảng chuẩn hóa 3NF/BCNF; Thiết lập 4 nhóm RBTV; Xây dựng màn hình Đăng nhập & Đăng ký; Quản lý cấu hình App.config. | **28%** | **100%** | **A (Tốt)** |
| **2** | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | **Phần 2** | Thiết kế kiến trúc 3 tầng (3-Tier); Phát triển Cổng Quản trị FrmAdminMain; Xây dựng thuật toán kiểm tra xung đột lịch ScheduleHelper; Quản lý giao dịch ACID; Cơ chế mã hóa PBKDF2; Xuất báo cáo Excel XML. | **32%** | **100%** | **A+ (Xuất sắc)** |
| **3** | **Đào Khánh Trúc** | 51.01.104.109 | **Phần 3** | Hiện thực hệ thống 15 Màn hình chức năng; Xây dựng Cổng Học viên FrmStudentMain 6 Tab; Ma trận Thời khóa biểu tuần; Trọn bộ 3 Mẫu báo cáo Microsoft RDLC; Đồ họa GDI+ in biên lai & Barcode; Biểu đồ thống kê MS Chart. | **28%** | **100%** | **A (Tốt)** |
| **4** | **Phan Thị Trang** | 51.01.104.102 | **Phần 4** | Hỗ trợ chạy thử nghiệm trên giao diện; Thực thi kiểm thử hộp đen; Ghi nhận số liệu thực tế cho bảng 10 Ca kiểm thử hệ thống (TC01 – TC10). | **12%** | **85%** | **B (Đạt cơ bản)** |

---

## MỤC LỤC TỔNG QUAN

1. [Phần I: Lời cam đoan và Bảng phân công nhiệm vụ kỹ thuật (WBS)](#lời-cam-đoan)
2. [Danh mục bảng biểu và sơ đồ](#danh-mục-bảng-biểu-và-sơ-đồ)
3. [Phần 1: Tổng quan đề tài, Cơ sở dữ liệu và Cấu hình App.config (Phụ trách: Trần Ngọc Hà)](#phần-1-tổng-quan-đề-tài-cơ-sở-dữ-liệu-và-cấu-hình-appconfig)
4. [Phần 2: Kiến trúc hệ thống, Phân hệ Quản trị và Giải thuật lõi (Phụ trách: Hồ Minh Nhật)](#phần-2-kiến-trúc-hệ-thống-phân-hệ-quản-trị-và-giải-thuật-lõi)
5. [Phần 3: Phân hệ Học viên, Thời khóa biểu, Trọn bộ Báo cáo in ấn và Biểu đồ (Phụ trách: Đào Khánh Trúc)](#phần-3-phân-hệ-học-viên-thời-khóa-biểu-trọn-bộ-báo-cáo-in-ấn-và-biểu-đồ)
6. [Phần 4: Kết quả Thực thi Kiểm thử Hệ thống (Phụ trách: Phan Thị Trang)](#phần-4-kết-quả-thực-thi-kiểm-thử-hệ-thống)
7. [Phần Kết luận, Tài liệu tham khảo (Chuẩn IEEE) và Phụ lục](#phần-kết-luận-và-phụ-lục)

---

## DANH MỤC BẢNG BIỂU VÀ SƠ ĐỒ

- Bảng 1.1: Bảng phân công nhiệm vụ kỹ thuật theo tiến trình nội dung đề tài
- Bảng 1.2: Danh mục 7 bảng thực thể trong cơ sở dữ liệu CourseRegistrationDB
- Bảng 1.3: Đặc tả 4 nhóm Ràng buộc toàn vẹn chuẩn mực trong CSDL
- Bảng 3.1: Danh mục đối ứng 15 Form / Màn hình chức năng trong hệ thống
- Bảng 4.1: Bảng kết quả thực thi 10 Ca kiểm thử hệ thống (TC01 đến TC10)
- Bảng 5.1: Danh mục tài khoản đăng nhập kiểm thử hệ thống

---

## PHẦN 1: TỔNG QUAN ĐỀ TÀI, CƠ SỞ DỮ LIỆU VÀ CẤU HÌNH APP.CONFIG
> **Sinh viên phụ trách chính:** **Trần Ngọc Hà** (MSSV: `51.01.104.020`)

### 1.1. Bối cảnh thực tế và Mục tiêu kỹ thuật hệ thống
Quy trình quản lý đào tạo và đăng ký học phần tại các cơ sở giáo dục là nghiệp vụ có tính quy chuẩn cao, đòi hỏi sự chính xác tuyệt đối về thời gian, phòng học và số dư tài chính. Mục tiêu kỹ thuật của hệ thống:
- Thiết kế 100% giao diện bằng Visual Studio Designer (*.Designer.cs), bảo đảm tính tương thích cao và cấu trúc phân cấp thuộc tính rõ ràng.
- Xây dựng cơ sở dữ liệu quan hệ đạt chuẩn 3NF và BCNF, bảo toàn 4 nhóm ràng buộc toàn vẹn (RBTV).
- Ứng dụng công nghệ ánh xạ O/R thông qua LINQ to SQL nhằm bảo đảm an toàn về kiểu dữ liệu (Type-safety) và tối ưu hóa hiệu năng truy vấn.

### 1.2. Thiết kế Cơ sở dữ liệu 7 bảng quan hệ (`CourseRegistrationDB`)
Lược đồ cơ sở dữ liệu gồm 7 bảng thực thể có mối quan hệ chặt chẽ:

#### Bảng 1.2. Danh mục 7 bảng thực thể trong cơ sở dữ liệu CourseRegistrationDB

| STT | Tên bảng CSDL | Ý nghĩa thực thể | Khóa chính (PK) | Khóa ngoại (FK) | Ràng buộc duy nhất (Unique) |
| :-: | :--- | :--- | :--- | :--- | :--- |
| **1** | `Users` | Tài khoản người dùng (Admin/Student), thông tin cá nhân và số dư ví tiền. | `UserID` (INT IDENTITY) | Không | `Username` |
| **2** | `Categories` | Danh mục chuyên ngành đào tạo (Lập trình, Thiết kế, Dữ liệu, Ngoại ngữ). | `CategoryID` (INT IDENTITY) | Không | `CategoryCode` |
| **3** | `Courses` | Thông tin lớp học: Giảng viên, phòng học, lịch học tuần, ca học, học phí, sĩ số. | `CourseID` (INT IDENTITY) | `CategoryID` | `CourseCode` |
| **4** | `Enrollments` | Bản ghi ghi danh môn học, trạng thái thanh toán, mã voucher và học phí thực nộp. | `EnrollmentID` (INT IDENTITY) | `UserID`, `CourseID`, `VoucherID` | Không |
| **5** | `Vouchers` | Kho mã ưu đãi học bổng, tỷ lệ chiết khấu (1% – 100%), hạn dùng, số lượt sử dụng. | `VoucherID` (INT IDENTITY) | Không | `VoucherCode` |
| **6** | `CourseReviews`| Phản hồi, điểm đánh giá sao (1 – 5 sao) và nhận xét chất lượng giảng dạy. | `ReviewID` (INT IDENTITY) | `UserID`, `CourseID` | Không |
| **7** | `WalletTransactions`| Sổ cái ghi nhận lịch sử biến động số dư ví (Nạp tiền, Đóng học phí, Hoàn phí). | `TransactionID` (INT IDENTITY) | `UserID` | Không |

### 1.3. Đặc tả 4 nhóm Ràng buộc Toàn vẹn (RBTV) chuẩn mực

#### Bảng 1.3. Đặc tả 4 nhóm Ràng buộc toàn vẹn chuẩn mực trong CSDL

| Nhóm RBTV | Tên ràng buộc trong CSDL | Ý nghĩa kỹ thuật | Biểu thức cài đặt SQL Server DDL |
| :--- | :--- | :--- | :--- |
| **Miền giá trị (Domain)** | `CK_Courses_Price`<br>`CK_Reviews_Rating`<br>`CK_Vouchers_Percent` | Bảo đảm thuộc tính nằm trong khoảng hợp lệ: Học phí không âm (`Price >= 0`), điểm sao đánh giá từ 1 đến 5 sao, % giảm giá từ 1 đến 100%. | `ALTER TABLE Courses ADD CONSTRAINT CK_Courses_Price CHECK (Price >= 0);`<br>`ALTER TABLE CourseReviews ADD CONSTRAINT CK_Reviews_Rating CHECK (Rating BETWEEN 1 AND 5);`<br>`ALTER TABLE Vouchers ADD CONSTRAINT CK_Vouchers_Percent CHECK (DiscountPercent BETWEEN 1 AND 100);` |
| **Thực thể (Entity)** | Khóa chính trên 7 bảng: `PK_Users`, `PK_Courses`, `PK_Categories`, `PK_Enrollments`, `PK_Vouchers`, `PK_Reviews`, `PK_Wallet` | Mỗi bản ghi đại diện cho một đối tượng duy nhất, khóa chính kiểu `INT IDENTITY(1,1)` không mang giá trị NULL, tự động tăng. | `CourseID INT IDENTITY(1,1) PRIMARY KEY,`<br>`UserID INT IDENTITY(1,1) PRIMARY KEY` |
| **Tham chiếu (Referential)** | `FK_Courses_Categories`<br>`FK_Enrollments_Users`<br>`FK_Enrollments_Courses`<br>`FK_Wallet_Users` | Bảo đảm tính toàn vẹn liên kết cha - con. Không thể thêm môn học vào danh mục không tồn tại; không thể xóa tài khoản đã có lịch sử đăng ký học phần. | `ALTER TABLE Courses ADD CONSTRAINT FK_Courses_Categories FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID);`<br>`ALTER TABLE Enrollments ADD CONSTRAINT FK_Enrollments_Users FOREIGN KEY (UserID) REFERENCES Users(UserID);` |
| **Nghiệp vụ (Business Rules)** | `UQ_Users_Username`<br>`UQ_Courses_CourseCode`<br>`UQ_Vouchers_Code`<br>`CK_Users_Balance` | Tên đăng nhập và Mã khóa học là duy nhất toàn trường; số dư tài khoản ví của học viên không bao giờ được phép âm (`Balance >= 0`). | `ALTER TABLE Users ADD CONSTRAINT UQ_Users_Username UNIQUE (Username);`<br>`ALTER TABLE Courses ADD CONSTRAINT UQ_Courses_Code UNIQUE (CourseCode);`<br>`ALTER TABLE Users ADD CONSTRAINT CK_Users_Balance CHECK (Balance >= 0);` |

### 1.4. Chứng minh Dạng chuẩn 3NF / BCNF & Ánh xạ LINQ to SQL
- Dùng phụ thuộc hàm (PTH) chứng minh bảng `Courses` đạt chuẩn BCNF do mọi vế trái của phụ thuộc hàm không tầm thường đều là siêu khóa (`CourseID`, `CourseCode`).
- Bảng `Enrollments` đạt chuẩn 3NF do các thuộc tính không khóa phụ thuộc trực tiếp vào khóa chính, không có phụ thuộc bắc cầu.
- Sơ đồ thực thể liên kết ERD được mô hình hóa tự động qua `CourseRegistration.dbml`, kết xuất các lớp thực thể C# tương ứng.

### 1.5. Cửa ngõ xác thực người dùng (Form Đăng nhập & Đăng ký)
- Thiết kế `FrmLogin` và `FrmRegister` trên WinForms Designer.
- Kiểm tra tính hợp lệ dữ liệu nhập (Form Validation): Tên đăng nhập chuẩn quy tắc ký tự, mật khẩu tối thiểu 6 ký tự, số điện thoại đúng 10 chữ số, email hợp chuẩn RFC trước khi gửi dữ liệu xử lý.

### 1.6. Quản lý cấu hình kết nối App.config
- Chuỗi kết nối được quản lý tập trung tại thẻ `connectionStrings` trong tệp `App.config`, tách biệt hoàn toàn với mã thực thi.
- Lớp `DbHelper.cs` hỗ trợ thuật toán tự động nhận diện chuỗi kết nối cục bộ hoặc SQL Server Express, nâng cao tính khả chuyển khi triển khai hệ thống trên các máy trạm khác nhau.

---

## PHẦN 2: KIẾN TRÚC HỆ THỐNG, PHÂN HỆ QUẢN TRỊ VÀ GIẢI THUẬT LÕI
> **Sinh viên phụ trách chính:** **Hồ Minh Nhật** (MSSV: `51.01.104.065` – Trưởng nhóm)

### 2.1. Kiến trúc 3 tầng (3-Tier Architecture)
Hệ thống tuân thủ mô hình 3 tầng độc lập:
1. **Presentation Layer (Tầng hiển thị):** 100% Windows Forms và trình xem báo cáo Microsoft RDLC.
2. **Business Logic Layer & Helpers (Tầng nghiệp vụ & Hỗ trợ):** Điều phối luồng dữ liệu, thuật toán xung đột lịch `ScheduleHelper.cs`, bảo mật mật khẩu `SecurityHelper.cs`, quản lý phiên `UserSession.cs` và xuất dữ liệu `ExcelExporter.cs`.
3. **Data Access Layer (Tầng truy cập dữ liệu):** Đối tượng `CourseRegistrationDataContext` thực thi các truy vấn LINQ to SQL và tương tác trực tiếp với Microsoft SQL Server.

### 2.2. Cơ chế Mã hóa mật khẩu PBKDF2 & Phân quyền người dùng (RBAC)
- Cài đặt thuật toán băm một chiều **PBKDF2 (RFC 2898)** kết hợp HMAC-SHA256, muối ngẫu nhiên (Salt) 16 bytes và 10.000 vòng lặp nhằm chống lại các cuộc tấn công Rainbow Table và Brute Force.
- Quản lý phiên làm việc tĩnh `UserSession` và phân quyền RBAC (Role-Based Access Control) cho 2 vai trò Admin và Student; tự động điều khiển thuộc tính `Visible` và `Enabled` của các chức năng giao diện tương ứng.
- **Cơ chế 4 lớp bảo vệ tài khoản Quản trị:** Khóa nút xóa trên giao diện, chặn tự xóa tại mã xử lý, cấm xóa hoặc hạ quyền Admin duy nhất, và tự động khôi phục tài khoản quản trị khẩn cấp nếu hệ thống chưa có dữ liệu.

### 2.3. Màn hình Quản trị trung tâm (`FrmAdminMain`)
Bảng điều khiển quản trị trung tâm tích hợp 7 module quản lý: Quản lý Khóa học, Quản lý Danh mục, Quản lý Người dùng, Quản lý Phân quyền, Quản lý Mã ưu đãi Voucher, Quản lý Đánh giá và Thống kê Doanh thu.

### 2.4. Thuật toán phát hiện xung đột lịch học đa chiều (`ScheduleHelper.cs`)
Giải thuật kiểm tra xung đột thời khóa biểu được thực thi dựa trên việc so sánh giao tập hợp Thứ trong tuần (`StudyDays`) và đối soát khoảng thời gian Ca học (`Shift`):
$$	ext{Conflict} \iff (Days_A \cap Days_B 
e \emptyset) \land (\max(Start_A, Start_B) < \min(End_A, End_B))$$
Thuật toán bảo đảm ngăn chặn tức thì mọi hành vi xếp trùng phòng học, trùng lịch giảng viên và trùng ca học của sinh viên.

### 2.5. Bảo đảm tính toàn vẹn giao dịch (ACID)
Quá trình ghi nhận đơn đăng ký học phần, trừ tiền tài khoản ví và cập nhật số lượt sử dụng voucher được bao gói trong một phiên giao dịch nguyên tử thông qua phương thức `DataContext.SubmitChanges()`, bảo đảm dữ liệu luôn ở trạng thái nhất quán (Commit toàn phần hoặc Rollback an toàn).

### 2.6. Đóng gói cài đặt & Tự động phục hồi CSDL
- Phần mềm được đóng gói hoàn chỉnh dưới dạng tệp thực thi độc lập `Course Registration.exe`.
- Kịch bản `Database.sql` chuẩn DDL/DML hỗ trợ khởi tạo lược đồ 7 bảng và nạp sẵn dữ liệu mẫu thực tế.

### 2.7. Xuất bảng tính Excel XML độc lập
Lớp `ExcelExporter.cs` kết xuất dữ liệu trực tiếp theo cấu trúc XML Spreadsheet 2003 của Microsoft, cho phép mở trực tiếp trên Excel hoặc Google Sheets mà không phụ thuộc vào bộ thư viện Microsoft Office Interop.

---

## PHẦN 3: PHÂN HỆ HỌC VIÊN, THỜI KHÓA BIỂU, TRỌN BỘ BÁO CÁO IN ẤN VÀ BIỂU ĐỒ
> **Sinh viên phụ trách chính:** **Đào Khánh Trúc** (MSSV: `51.01.104.109`)

### 3.1. Hệ thống 15 Màn hình / Forms chức năng
Toàn bộ giao diện được thiết kế 100% bằng Visual Studio Designer (*.Designer.cs), sử dụng bố cục thích ứng (Responsive Layout) với `Dock`, `Anchor`, `TableLayoutPanel` và `AutoSizeColumnsMode` của `DataGridView` nhằm tối ưu hiển thị trên các độ phân giải màn hình khác nhau.

#### Bảng 3.1. Danh mục đối ứng 15 Form / Màn hình chức năng trong hệ thống

| STT | Tên Form trong hệ thống | Loại Form / Vai trò chức năng | Phụ trách kỹ thuật | Mô tả chức năng và Kỹ thuật LINQ áp dụng |
| :-: | :--- | :--- | :---: | :--- |
| **1** | `FrmLogin` | Đăng nhập hệ thống | Trần Ngọc Hà | Xác thực tài khoản, kiểm tra mật khẩu qua PBKDF2, nạp nhanh tài khoản kiểm thử. |
| **2** | `FrmRegister` | Tạo tài khoản học viên | Trần Ngọc Hà | Đăng ký tài khoản học viên mới, kiểm tra trùng lặp tài khoản qua LINQ. |
| **3** | `FrmAdminMain` | Giao diện Quản trị | Hồ Minh Nhật | Bảng điều khiển quản trị trung tâm, điều hướng và kiểm soát phân quyền hệ thống. |
| **4** | `FrmStudentMain` | Cổng Học viên | Đào Khánh Trúc | Màn hình chính học viên: tra cứu khóa học, hiển thị số dư ví và điều hướng chức năng. |
| **5** | Module `TabProfile` | Đổi mật khẩu | Đào Khánh Trúc | Đổi mật khẩu học viên, xác thực mật khẩu cũ qua mã băm và cập nhật mật khẩu mới. |
| **6** | Module `TabUserManagement` | Quản lý người dùng | Hồ Minh Nhật | Quản lý danh sách người dùng, kích hoạt / khóa tài khoản, cấp lại mật khẩu. |
| **7** | Module `TabRoleManagement` | Quản lý phân quyền | Hồ Minh Nhật | Phân quyền vai trò (Admin / Student), cài đặt 4 lớp bảo vệ tài khoản Quản trị duy nhất. |
| **8** | Module `TabCourseManagement` | Quản lý Khóa học (CRUD) | Hồ Minh Nhật | Thêm, sửa, xóa khóa học; kiểm tra xung đột phòng học và giảng viên. |
| **9** | Module `TabCategoryManagement` | Quản lý Danh mục (CRUD) | Hồ Minh Nhật | Quản lý danh mục chuyên ngành đào tạo (Lập trình, Thiết kế, Ngoại ngữ, Dữ liệu). |
| **10** | Module `TabVoucherManagement` | Quản lý Ưu đãi (CRUD) | Hồ Minh Nhật | Quản lý mã giảm giá học phí (Hạn dùng, số lượt, mức giảm tối đa, học phí tối thiểu). |
| **11** | Module `TabCourseCatalog` | Tra cứu & Đăng ký môn | Đào Khánh Trúc | Lọc khóa học theo danh mục, tìm kiếm theo từ khóa qua LINQ Lambda. |
| **12** | Module `TabTimetableMatrix` | Thời khóa biểu ma trận | Đào Khánh Trúc | Hiển thị lịch học tuần dạng ma trận 3 ca x 7 ngày tự động theo các môn đã đăng ký. |
| **13** | Module `TabWallet` | Giao dịch / Ví học phí | Đào Khánh Trúc | Nạp tiền vào ví, kiểm tra số dư và trừ học phí tự động theo thời gian thực. |
| **14** | Module `TabCourseReview` | Đánh giá môn học | Đào Khánh Trúc | Học viên gửi đánh giá sao (1-5 sao) và nhận xét phản hồi chất lượng đào tạo. |
| **15** | `FrmReportViewer` | Báo cáo & In ấn | Đào Khánh Trúc | Trình xem và in ấn báo cáo chuyên nghiệp: RptReceipt, RptCourseRevenue, RptStudentClassList. |

### 3.2. Cổng Học viên (`FrmStudentMain` 6 Tab) & Ma trận Thời khóa biểu tuần
- Thiết kế 6 Tab chức năng trực quan: Tra cứu khóa học, Khóa học đã đăng ký, Thời khóa biểu tuần, Nạp & Quản lý ví, Đánh giá chất lượng đào tạo, Thông tin cá nhân.
- Thuật toán ánh xạ lịch học tự động lên lưới ma trận 8 cột (Ca học + Thứ 2 đến Chủ nhật) và 3 ca học (Sáng, Chiều, Tối).

### 3.3. Thiết kế trọn bộ 3 Mẫu Báo cáo in ấn Microsoft RDLC
- `RptReceipt.rdlc`: Biên lai xác nhận thu học phí và đăng ký môn học khổ đứng A4 Portrait, căn chỉnh thước đo chuẩn xác, kẻ khung viền chữ ký 2 bên.
- `RptCourseRevenue.rdlc`: Báo cáo tổng hợp doanh thu theo từng môn học kèm dòng tổng kết biểu thức `=Sum(...)`.
- `RptStudentClassList.rdlc`: Báo cáo danh sách học viên đăng ký theo từng lớp học phần (khổ ngang A4 Landscape chuẩn học vụ).
- Cơ chế nạp dữ liệu qua `ReportDataSource` và truyền tham số động qua `ReportParameter`.

### 3.4. Đồ họa in ấn biên lai GDI+ & Vẽ mã vạch Barcode Code39
- Lớp `ReceiptPrinter.cs` ứng dụng đối tượng đồ họa `PrintDocument` của GDI+ vẽ trực tiếp phiếu thu học phí sắc nét.
- Cài đặt giải thuật vẽ mã vạch chuẩn 1D Code39 từ chuỗi mã hóa, tự động căn giữa trang in phục vụ công tác đối soát hồ sơ học vụ.

### 3.5. Biểu đồ Thống kê đồ họa (MS Chart)
Tích hợp thư viện `System.Windows.Forms.DataVisualization.Charting` hiển thị trực quan biểu đồ cột doanh thu theo môn học và biểu đồ tròn tỷ trọng đào tạo theo chuyên ngành, kết hợp với các truy vấn LINQ `GroupBy` và `Sum`.

### 3.6. Giao diện Modern UI
Áp dụng bảng màu phẳng hiện đại, thiết kế dạng thẻ Card View (`FrmAbout.cs`) và định dạng lưới dữ liệu `DataGridView` kiểu sọc xen kẽ (Zebra Stripes).

---

## PHẦN 4: KẾT QUẢ THỰC THI KIỂM THỬ HỆ THỐNG
> **Sinh viên phụ trách chính:** **Phan Thị Trang** (MSSV: `51.01.104.102`)

### 4.1. Phương pháp Kiểm thử hộp đen và Phân tích giá trị biên (BVA)
- Áp dụng phương pháp kiểm thử hộp đen (Black-Box Testing) dựa trên tài liệu đặc tả yêu cầu phần mềm.
- Kết hợp kỹ thuật phân tích giá trị biên (Boundary Value Analysis - BVA) và phân vùng tương đương (Equivalence Partitioning) để kiểm chứng tính đúng đắn của các giới hạn nghiệp vụ (số dư ví, điều kiện kích hoạt mã giảm giá voucher, thời gian ca học).

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
- **Kết quả đạt được:** Hệ thống hoàn thành đầy đủ các tiêu chuẩn kỹ thuật đề ra, vận hành ổn định trên nền tảng .NET Framework 4.8 và SQL Server, giao diện thân thiện, bảo đảm an toàn dữ liệu và tối ưu quy trình quản lý đào tạo.
- **Hướng phát triển:** Tích hợp cổng thanh toán trực tuyến VietQR / MoMo qua API và phát triển ứng dụng di động hỗ trợ sinh viên tra cứu thời khóa biểu tức thời.

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
