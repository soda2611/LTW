# HỆ THỐNG QUẢN LÝ ĐÀO TẠO
> **Đồ án kết thúc học phần:** Lập trình Windows  
> **Trường Đại học Sư phạm TP.HCM** – Khoa Công nghệ Thông tin  
> **Giảng viên hướng dẫn:** ThS. Lương Trần Ngọc Khiết

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C# Windows Forms](https://img.shields.io/badge/C%23-WinForms-239120?logo=c-sharp)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC292B?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![LINQ to SQL](https://img.shields.io/badge/ORM-LINQ%20to%20SQL-0078D4)](https://learn.microsoft.com/dotnet/framework/data/adonet/sql/linq/)
[![Build Status](https://img.shields.io/badge/Build-Passing%20(0%20errors)-brightgreen)]()

---

## 1. THÀNH VIÊN NHÓM

| STT | Họ và tên | MSSV | Vai trò và nhiệm vụ chính |
| :-: | :--- | :-: | :--- |
| 1 | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | Kiến trúc 3 tầng, Cổng Quản trị, Thuật toán trùng lịch, Bảo mật PBKDF2 |
| 2 | **Trần Ngọc Hà** | 51.01.104.020 | Thiết kế CSDL (3NF), Xác thực & Đăng ký, Cấu hình kết nối CSDL |
| 3 | **Đào Khánh Trúc** | 51.01.104.109 | Cổng Học viên, Ma trận TKB tuần, Báo cáo RDLC & In ấn GDI+ Code39 |
| 4 | **Phan Thị Trang** | 51.01.104.102 | Kiểm thử hệ thống (QA/QC), Phân tích biên (BVA), Kịch bản test TC01-TC10 |

---

## 2. TÍNH NĂNG VÀ ĐIỂM NỔI BẬT

* **Kiến trúc 3 tầng (3-Tier):** Phân tách độc lập Tầng Giao diện (Presentation) – Tầng Nghiệp vụ (Helpers/BLL) – Tầng Dữ liệu (LINQ to SQL/DAL).
* **Bảo mật chuẩn công nghiệp:** Băm mật khẩu một chiều **PBKDF2** (HMAC-SHA256, Salt 16 bytes, 10.000 vòng lặp) loại bỏ hoàn toàn mật khẩu văn bản thô.
* **Xử lý trùng lịch học thông minh (`ScheduleHelper`):** Tự động phát hiện và ngăn chặn trùng ca học, trùng thứ trong tuần cho sinh viên, giảng viên và phòng học.
* **Toàn vẹn giao dịch (ACID):** Đăng ký học phần, trừ tiền ví điện tử và khấu trừ voucher được đóng gói trong một transaction duy nhất.
* **Báo cáo & In ấn chuyên nghiệp:**
  * 03 mẫu báo cáo **Microsoft RDLC** (Biên lai A4 đứng, Báo cáo doanh thu, Danh sách lớp A4 ngang).
  * In ấn trực tiếp qua đồ họa **GDI+** kèm thuật toán sinh mã vạch **Code39**.
  * Xuất bảng tính **Excel XML Spreadsheet** độc lập, không cần cài Microsoft Office.
* **Trực quan hóa số liệu:** Tích hợp biểu đồ **MS Chart** thống kê doanh thu và tỷ trọng danh mục đào tạo.

---

## 3. TÀI KHOẢN TRẢI NGHIỆM

Tại màn hình đăng nhập, có sẵn 2 nút **"Điền mẫu Quản trị"** và **"Điền mẫu Học viên"** để đăng nhập nhanh:

| Vai trò | Tài khoản | Mật khẩu | Chức năng kiểm thử chính |
| :--- | :--- | :--- | :--- |
| **Quản trị viên** | `admin` | `123456` | Quản lý khóa học, danh mục, tài khoản, duyệt đăng ký, xem thống kê & in 3 báo cáo RDLC. |
| **Học viên** | `hocvien1` | `123456` | Tra cứu & đăng ký môn, xem TKB tuần dạng ma trận, in biên lai học phí (GDI+ & Barcode), nạp tiền ví, đánh giá sao. |
| *Học viên mẫu khác* | `hocvien2` / `hocvien3` | `123456` | Đã có sẵn số dư ví và dữ liệu mẫu để thử nghiệm giao dịch & voucher. |

---

## 4. HƯỚNG DẪN CÀI ĐẶT & KHỞI CHẠY

### Yêu cầu môi trường
* Hệ điều hành: Windows 10 / 11.
* Nền tảng: .NET Framework 4.8.
* CSDL: Microsoft SQL Server (LocalDB / Express / Standard).

### Cách khởi chạy nhanh nhất
1. Mở file giải pháp **`Course Registration.sln`** bằng Visual Studio 2019/2022.
2. Nhấn **`F5`** (hoặc `Start`):
   * Hệ thống tích hợp cơ chế tự động dò tìm máy chủ SQL Server (`localhost`, `.\SQLEXPRESS`, `(localdb)\MSSQLLocalDB`,...).
   * Tự động khởi tạo CSDL `CourseRegistrationDB` và nạp dữ liệu mẫu ban đầu từ file `Database.sql`.
3. Hoặc chạy trực tiếp file đã biên dịch:
   ```text
   bin\Debug\Course Registration.exe
   ```

---

## 5. CẤU TRÚC THƯ MỤC DỰ ÁN (THỰC TẾ)

```text
Phép thuật Winx/
├── 📁 Properties/                      # Cấu hình Assembly, Resources & Settings
│   ├── AssemblyInfo.cs                # Thông tin phiên bản & bản quyền hệ thống
│   ├── Resources.resx                 # Tài nguyên hình ảnh, chuỗi ứng dụng
│   └── Settings.settings              # Cấu hình chuỗi kết nối CSDL mặc định
├── 📁 Reports/                         # Mẫu báo cáo Microsoft RDLC & Dữ liệu
│   ├── ReportModels.cs                # Định nghĩa lớp đối tượng truyền dữ liệu báo cáo
│   ├── RptCourseRevenue.rdlc          # Mẫu báo cáo tổng hợp doanh thu khóa học
│   ├── RptReceipt.rdlc                # Mẫu biên lai học phí kèm Barcode (A4 đứng)
│   └── RptStudentClassList.rdlc       # Mẫu danh sách học viên theo lớp (A4 ngang)
├── 📁 SqlServerTypes/                  # Thư viện native hỗ trợ Microsoft ReportViewer
├── 📄 App.config                       # Tệp cấu hình ứng dụng & chuỗi kết nối
├── 📄 app_icon.ico                     # Biểu tượng ứng dụng (Mũ cử nhân & Sách)
├── 📄 Course Registration.sln          # Tệp giải pháp Visual Studio
├── 📄 Course Registration.csproj       # Tệp cấu hình dự án WinForms (.NET 4.8)
├── 📄 CourseRegistration.dbml          # Lược đồ ánh xạ ORM LINQ to SQL
├── 📄 Database.sql                     # Kịch bản khởi tạo CSDL 7 bảng & dữ liệu mẫu
├── 📄 InitDatabase.sql                 # Kịch bản tạo CSDL dự phòng
├── 📄 packages.config                  # Quản lý các gói phụ thuộc NuGet
├── 📄 Program.cs                       # Điểm khởi chạy ứng dụng (Main Entry Point)
├── 📄 FrmLogin.cs                      # Giao diện Đăng nhập & Xác thực
├── 📄 FrmRegister.cs                   # Giao diện Đăng ký tài khoản học viên mới
├── 📄 FrmAdminMain.cs                  # Giao diện Cổng Quản trị viên (7 Tab quản lý)
├── 📄 FrmStudentMain.cs                # Giao diện Cổng Học viên (6 Tab & Ma trận TKB)
├── 📄 FrmReportViewer.cs               # Giao diện Trình xem & In báo cáo RDLC
├── 📄 FrmAbout.cs                      # Giao diện Thông tin tác giả & Phiên bản
├── 📄 DbHelper.cs                      # Tự động nhận diện Instance & Khởi tạo CSDL
├── 📄 ScheduleHelper.cs                # Thuật toán phát hiện xung đột lịch học đa chiều
├── 📄 SecurityHelper.cs                # Mã hóa bảo mật mật khẩu PBKDF2 & AES-256
├── 📄 UserSession.cs                   # Quản lý phiên làm việc & Phân quyền RBAC
├── 📄 ExcelExporter.cs                 # Kết xuất bảng tính Excel định dạng XML
├── 📄 ReceiptPrinter.cs                # In ấn đồ họa GDI+ & Sinh mã vạch Code39
└── 📄 README.md                        # Hướng dẫn chi tiết về dự án
```
