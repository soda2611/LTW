# HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC
### (Academic Course Registration System)

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C# Windows Forms](https://img.shields.io/badge/C%23-Windows%20Forms-239120?logo=c-sharp)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC292B?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![LINQ to SQL](https://img.shields.io/badge/ORM-LINQ%20to%20SQL-0078D4)](https://learn.microsoft.com/dotnet/framework/data/adonet/sql/linq/)
[![Build Status](https://img.shields.io/badge/Build-Passing%20(0%20errors)-brightgreen)]()

> **Đơn vị đào tạo:** TRƯỜNG ĐẠI HỌC SƯ PHẠM THÀNH PHỐ HỒ CHÍ MINH – KHOA CÔNG NGHỆ THÔNG TIN  
> **Học phần:** Lập trình trên môi trường Windows / Cơ sở dữ liệu  
> **Khóa học / Ngành:** Khóa 51 – Ngành Sư phạm & Công nghệ Thông tin  
> **Giảng viên hướng dẫn:** Bộ môn Công nghệ Phần mềm  

---

## 1. THÀNH VIÊN NHÓM VÀ BẢNG PHÂN CÔNG NHIỆM VỤ (WBS)

| STT | Sinh viên thực hiện | MSSV | Vai trò kỹ thuật | Nhiệm vụ chính trong dự án | Tỷ lệ đóng góp | Mức độ hoàn thành | Đánh giá |
| :-: | :--- | :-: | :--- | :--- | :-: | :-: | :-: |
| **1** | **Trần Ngọc Hà** | 51.01.104.020 | Kỹ sư CSDL & Cửa ngõ xác thực | Thiết kế lược đồ CSDL 7 bảng chuẩn 3NF/BCNF; Thiết lập 4 nhóm RBTV; Xây dựng `FrmLogin`, `FrmRegister`; Quản lý cấu hình kết nối `App.config`. | **28%** | **100%** | **A (Tốt)** |
| **2** | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | Kiến trúc sư hệ thống & Quản trị viên | Thiết kế kiến trúc 3 tầng (3-Tier); Phát triển Cổng Quản trị `FrmAdminMain` 7 Tab; Thuật toán phát hiện xung đột lịch `ScheduleHelper`; Bảo mật PBKDF2/RBAC; Giao dịch ACID; Xuất Excel XML. | **32%** | **100%** | **A+ (Xuất sắc)** |
| **3** | **Phan Thị Trang** | 51.01.104.102 | Kiểm thử viên hệ thống (QA/QC) | Thực thi kiểm thử hộp đen (Black-Box Testing) trên toàn bộ giao diện; Phân tích giá trị biên (BVA); Thực thi và ghi nhận dữ liệu cho 10 Ca kiểm thử hệ thống (TC01 đến TC10). | **12%** | **85%** | **B (Đạt cơ bản)** |
| **4** | **Đào Khánh Trúc** | 51.01.104.109 | Kỹ sư Giao diện & Báo cáo in ấn | Xây dựng Cổng Học viên `FrmStudentMain` 6 Tab; Ma trận Thời khóa biểu tuần 3 ca x 7 ngày; Trọn bộ 3 Mẫu báo cáo Microsoft RDLC; In biên lai GDI+ kèm Barcode Code39; Biểu đồ thống kê MS Chart. | **28%** | **100%** | **A (Tốt)** |

---

## 2. KIẾN TRÚC VÀ ĐẶC TẢ KỸ THUẬT CỐT LÕI

Hệ thống được tổ chức theo mô hình **Kiến trúc 3 tầng (3-Tier Architecture)** phân định rõ ràng giữa tầng Hiển thị, tầng Nghiệp vụ và tầng Dữ liệu:

```
[Presentation Layer]
  ├── FrmLogin, FrmRegister (Xác thực & Tạo tài khoản)
  ├── FrmAdminMain (Bảng điều khiển Quản trị viên 7 Tab)
  ├── FrmStudentMain (Cổng Học viên 6 Tab & Ma trận TKB tuần)
  ├── FrmReportViewer (Trình xem & In 3 báo cáo Microsoft RDLC)
  └── FrmAbout (Thông tin dự án Card View Modern UI)
        │
[Business Logic & Helpers Layer]
  ├── ScheduleHelper.cs (Giải thuật phát hiện xung đột lịch học đa chiều)
  ├── SecurityHelper.cs (Mã hóa mật khẩu PBKDF2 RFC 2898 & AES-256)
  ├── UserSession.cs (Quản lý phiên làm việc tĩnh & Phân quyền RBAC)
  ├── DbHelper.cs (Tự động nhận diện Instance SQL Server & Khởi tạo CSDL)
  ├── ExcelExporter.cs (Kết xuất bảng tính XML Spreadsheet độc lập)
  └── ReceiptPrinter.cs (Đồ họa in ấn GDI+ & Giải thuật vẽ Barcode Code39)
        │
[Data Access Layer]
  ├── CourseRegistrationDataContext (LINQ to SQL O/R Mapping qua CourseRegistration.dbml)
  └── Microsoft SQL Server (Lược đồ CourseRegistrationDB 7 bảng quan hệ chuẩn 3NF/BCNF)
```

### Điểm sáng kỹ thuật nổi bật
1. **100% Visual Studio Designer:** Toàn bộ form và control được định nghĩa trong file `*.Designer.cs`, không tạo control động ở runtime. Sử dụng `Dock`, `Anchor`, `TableLayoutPanel` và `AutoSizeColumnsMode` giúp giao diện co giãn mượt mà theo mọi độ phân giải.
2. **Bảo mật mật khẩu PBKDF2 (RFC 2898):** Mật khẩu người dùng được băm một chiều với thuật toán HMAC-SHA256, muối ngẫu nhiên (Salt) 16 bytes và 10.000 vòng lặp, loại bỏ hoàn toàn việc lưu Plain Text.
3. **Phát hiện xung đột lịch học đa chiều (`ScheduleHelper.cs`):** Giải thuật so sánh giao tập hợp Thứ trong tuần kết hợp đối soát khoảng thời gian Ca học, ngăn chặn tức thì việc trùng ca học của sinh viên, trùng phòng học và trùng giờ giảng dạy của giảng viên.
4. **Bảo đảm toàn vẹn giao dịch (ACID):** Thao tác đăng ký học phần, trừ tiền ví điện tử và khấu trừ lượt voucher được bao gói trong một phiên giao dịch nguyên tử thông qua `DataContext.SubmitChanges()`.
5. **Cơ chế 4 lớp bảo vệ tài khoản Quản trị:** Vô hiệu hóa nút xóa trên UI khi Admin xem chính mình, chặn xóa tại code xử lý, cấm xóa hoặc hạ quyền Admin duy nhất, và tự động khôi phục tài khoản quản trị khẩn cấp nếu CSDL trống.
6. **In ấn & Kết xuất báo cáo độc lập:**
   - Trọn bộ 3 mẫu báo cáo Microsoft RDLC (`RptReceipt.rdlc`, `RptCourseRevenue.rdlc`, `RptStudentClassList.rdlc`).
   - Đồ họa in ấn GDI+ kèm giải thuật sinh mã vạch chuẩn 1D Code39 từ chuỗi ký tự.
   - Xuất dữ liệu Excel XML Spreadsheet 2003 không phụ thuộc vào Microsoft Office Interop.
7. **Trực quan hóa dữ liệu (MS Chart):** Biểu đồ cột doanh thu theo môn học và biểu đồ tròn tỷ trọng khóa học theo danh mục tích hợp LINQ `GroupBy` và `Sum`.

---

## 3. THIẾT KẾ CƠ SỞ DỮ LIỆU (CourseRegistrationDB)

Lược đồ cơ sở dữ liệu gồm 7 bảng thực thể quan hệ:
- **`Users`**: Lưu tài khoản, mật khẩu đã mã hóa băm PBKDF2, họ tên, vai trò (`Admin`/`Student`) và số dư ví tiền (`Balance`).
- **`Categories`**: Danh mục chuyên ngành đào tạo (Lập trình, Thiết kế, Dữ liệu, Ngoại ngữ).
- **`Courses`**: Thông tin lớp học phần (Mã môn, tên môn, giảng viên, phòng học, ca học, thứ trong tuần, học phí, sĩ số).
- **`Enrollments`**: Bản ghi đăng ký học phần, trạng thái thanh toán, mã voucher áp dụng, số tiền thực nộp.
- **`Vouchers`**: Kho mã giảm giá học phí (phần trăm giảm 1% - 100%, ngày hiệu lực, hạn dùng, số lượt tối đa).
- **`CourseReviews`**: Đánh giá chất lượng đào tạo (1 đến 5 sao) và nhận xét của sinh viên.
- **`WalletTransactions`**: Sổ cái ghi nhận lịch sử biến động số dư ví (Nạp tiền, Đóng học phí, Hoàn phí).

### 4 nhóm Ràng buộc toàn vẹn (RBTV)
- **Domain Integrity:** Ràng buộc `CHECK` học phí không âm (`Price >= 0`), điểm sao từ 1 đến 5, phần trăm voucher từ 1 đến 100%.
- **Entity Integrity:** Khóa chính `INT IDENTITY(1,1)` tự tăng không `NULL` trên cả 7 bảng.
- **Referential Integrity:** Khóa ngoại liên kết chặt chẽ `Courses` $\rightarrow$ `Categories`, `Enrollments` $\rightarrow$ `Users`, `Courses`, `Vouchers`.
- **Business Rules:** Ràng buộc duy nhất `UNIQUE` cho `Username`, `CourseCode`, `VoucherCode`; số dư ví không được âm (`Balance >= 0`).

---

## 4. TÀI KHOẢN ĐĂNG NHẬP KIỂM THỬ HỆ THỐNG

Hệ thống cung cấp sẵn các tài khoản kiểm thử mặc định:

| Loại tài khoản | Tên đăng nhập | Mật khẩu | Quyền hạn & Chức năng kiểm thử chính |
| :--- | :--- | :--- | :--- |
| **Quản trị viên** | `admin` | `123456` | Toàn quyền Quản trị: Quản lý khóa học, danh mục, tài khoản, duyệt đăng ký, thống kê doanh thu, in 3 mẫu báo cáo RDLC. |
| **Học viên 1** | `hocvien1` | `123456` | Tài khoản học viên chính: Tra cứu môn học, đăng ký môn, xem Thời khóa biểu ma trận tuần, in biên lai học phí GDI+ Barcode, đánh giá sao. |
| **Học viên 2** | `hocvien2` | `123456` | Tài khoản học viên thử nghiệm (Số dư: 1.800.000 VNĐ): Kiểm thử đăng ký khóa học, kiểm tra xung đột trùng lịch và thanh toán ví. |
| **Học viên 3** | `hocvien3` | `123456` | Tài khoản học viên thử nghiệm (Số dư: 1.200.000 VNĐ): Đã đăng ký môn học và thực hiện giao dịch học phí. |
| **Học viên 4** | `hocvien4` | `123456` | Tài khoản học viên thử nghiệm (Số dư: 3.200.000 VNĐ): Kiểm thử số dư lớn và nạp tiền ví. |

> *(Tại màn hình Đăng nhập `FrmLogin`, có sẵn 2 nút tiện ích **"Điền mẫu Quản trị"** và **"Điền mẫu Học viên"** để hỗ trợ chấm thi và kiểm thử nhanh chỉ trong 1 thao tác).*

---

## 5. HƯỚNG DẪN CÀI ĐẶT VÀ VẬN HÀNH

### Yêu cầu hệ thống
- Hệ điều hành: Microsoft Windows 10 / 11 (x86 hoặc x64).
- Nền tảng: Microsoft .NET Framework 4.8.
- Hệ quản trị CSDL: Microsoft SQL Server (bất kỳ phiên bản nào: Express, Developer, Standard hoặc LocalDB).
- Công cụ phát triển (nếu cần xem mã nguồn): Visual Studio 2019 / 2022 (khuyến nghị cài đặt workload *.NET desktop development*).

### Cách 1: Chạy trực tiếp từ Visual Studio (Khuyến nghị)
1. Mở tệp giải pháp `Course Registration.sln`.
2. Nhấn phím `F5` (hoặc nút `Start`).
3. **Cơ chế CSDL tự động "Cắm và Chạy" (`DbHelper.cs`):** Ứng dụng tự động dò tìm máy chủ SQL Server qua danh sách các Instance phổ biến: `localhost`, `.\SQLEXPRESS`, `(localdb)\MSSQLLocalDB`, `SERVER-NAME` (Environment.MachineName). Nếu tìm thấy máy chủ SQL Server đang hoạt động nhưng cơ sở dữ liệu `CourseRegistrationDB` chưa tồn tại, `DbHelper` sẽ tự động đọc tệp kịch bản `Database.sql`, thực thi tuần tự các lô lệnh (`GO` Batches) để tự động khởi tạo cơ sở dữ liệu và nạp toàn bộ dữ liệu mẫu ban đầu. Trong trường hợp tệp kịch bản không khả dụng, hệ thống tự động kích hoạt tầng cứu hộ nạp dữ liệu mẫu bằng LINQ to SQL (Mockup Fallback) và luôn bảo đảm tài khoản quản trị `admin` được kích hoạt.

### Cách 2: Khởi chạy tệp thực thi (.exe) đã biên dịch
- Đường dẫn file chạy sẵn (đã được cấu hình tự động sao chép `Database.sql` đi kèm):
  ```
  bin\Debug\Course Registration.exe
  ```

### Cách 3: Nạp cơ sở dữ liệu thủ công qua SQL Server Management Studio (SSMS)
1. Khởi động SSMS và kết nối đến máy chủ SQL Server.
2. Mở file kịch bản [`Database.sql`](Database.sql) và nhấn `Execute` (`F5`).
3. Chuỗi kết nối mặc định được quản lý tại tệp [`App.config`](App.config).

---

## 6. CẤU TRÚC THƯ MỤC DỰ ÁN

```
Course Registration/
├── Course Registration.sln           # Tệp giải pháp Visual Studio
├── Course Registration.csproj        # Tệp cấu hình dự án C# WinForms
├── App.config                        # Tệp cấu hình chuỗi kết nối CSDL
├── packages.config                   # Cấu hình NuGet packages
├── Database.sql                      # Script tạo 7 bảng CSDL & dữ liệu mẫu
├── CourseRegistration.dbml           # Sơ đồ quan hệ ánh xạ LINQ to SQL
├── Program.cs                        # Điểm khởi chạy ứng dụng
│
├── Forms/                            # Tầng hiển thị (Windows Forms Designer)
│   ├── FrmLogin.cs                   # Màn hình Đăng nhập & Xác thực
│   ├── FrmRegister.cs                # Màn hình Đăng ký tài khoản học viên
│   ├── FrmAdminMain.cs               # Bảng điều khiển Quản trị viên (7 Tab)
│   ├── FrmStudentMain.cs             # Cổng Học viên (6 Tab & Ma trận TKB)
│   ├── FrmReportViewer.cs            # Trình xem & In báo cáo RDLC
│   └── FrmAbout.cs                   # Màn hình thông tin dự án & thành viên
│
├── Helpers/                          # Tầng nghiệp vụ & Giải thuật lõi
│   ├── ScheduleHelper.cs             # Thuật toán phát hiện trùng lịch đa chiều
│   ├── SecurityHelper.cs             # Mã hóa PBKDF2 & AES-256
│   ├── UserSession.cs                # Quản lý phiên làm việc & Phân quyền RBAC
│   ├── DbHelper.cs                   # Tự động nhận diện kết nối & Khôi phục CSDL
│   ├── ExcelExporter.cs              # Xuất bảng tính Excel XML độc lập
│   └── ReceiptPrinter.cs             # Đồ họa GDI+ & Sinh mã vạch Code39
│
└── Reports/                          # Trọn bộ 3 mẫu báo cáo Microsoft RDLC
    ├── RptReceipt.rdlc               # Biên lai thu học phí khổ đứng A4
    ├── RptCourseRevenue.rdlc         # Báo cáo doanh thu khóa học
    └── RptStudentClassList.rdlc      # Báo cáo danh sách lớp học khổ ngang A4
```

---

## 7. GIẤY PHÉP VÀ BẢN QUYỀN

Đồ án được thực hiện phục vụ mục đích học tập và nghiên cứu trong khuôn khổ Học phần Lập trình trên môi trường Windows / Cơ sở dữ liệu tại Trường Đại học Sư phạm TP.HCM.
