# ĐỒ ÁN LẬP TRÌNH WINDOWS: HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC
> **Đơn vị:** BỘ GIÁO DỤC VÀ ĐÀO TẠO • TRƯỜNG ĐẠI HỌC SƯ PHẠM TP.HCM • KHOA CÔNG NGHỆ THÔNG TIN  
> **Học phần:** Lập trình trên môi trường Windows / Cơ sở dữ liệu  
> **Ngành / Khóa:** Khóa 51 – Ngành Sư phạm & Công nghệ Thông tin  
> **Nền tảng phát triển:** C# .NET Framework 4.8 • Windows Forms • LINQ to SQL • Microsoft SQL Server  
> **Kiến trúc:** 100% Visual Studio Designer (*.Designer.cs), O/R Mapping qua CourseRegistration.dbml

---

## 1. THÀNH VIÊN NHÓM VÀ BẢNG PHÂN CÔNG NHIỆM VỤ KỸ THUẬT (WBS)

| STT | Sinh viên phụ trách | MSSV | Vai trò kỹ thuật trong đồ án | Nội dung soạn thảo tiểu luận | Tỷ lệ đóng góp | Mức độ hoàn thành | Đánh giá |
| :-: | :--- | :-: | :--- | :--- | :-: | :-: | :-: |
| **1** | **Trần Ngọc Hà** | 51.01.104.020 | Khảo sát đề tài, CSDL 7 bảng, LINQ to SQL, Form Login/Register, Cấu hình App.config | **Phần 1:** Tổng quan đề tài, CSDL 7 bảng chuẩn 3NF/BCNF, 4 nhóm RBTV, Form Đăng nhập & Đăng ký, Cấu hình App.config | **28%** | **100%** | **A (Tốt)** |
| **2** | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | Kiến trúc 3 tầng, Quản trị viên, Thuật toán trùng lịch, Bảo mật PBKDF2/AES, Giao dịch ACID | **Phần 2:** Kiến trúc 3 tầng, Cổng Quản trị FrmAdminMain, Bảo mật PBKDF2/RBAC, Thuật toán ScheduleHelper, ACID, Đóng gói setup, Xuất Excel XML | **32%** | **100%** | **A+ (Xuất sắc)** |
| **3** | **Phan Thị Trang** | 51.01.104.102 | Hỗ trợ chạy thử nghiệm trên giao diện & Ghi nhận kết quả kiểm thử | **Phần 3:** Hỗ trợ chạy thử nghiệm hộp đen trên giao diện và ghi nhận số liệu Bảng 10 Test Cases | **12%** | **85%** | **B (Đạt cơ bản)** |
| **4** | **Đào Khánh Trúc** | 51.01.104.109 | Cổng Học viên 6 Tab, TKB ma trận, Trọn bộ 3 Báo cáo RDLC, In Barcode, Biểu đồ MS Chart | **Phần 4:** Cổng Học viên 15 Forms, Bố cục Responsive, Thời khóa biểu ma trận, 3 Báo cáo RDLC, In Barcode GDI+, Biểu đồ MS Chart, Modern UI | **28%** | **100%** | **A (Tốt)** |

---

## 2. CÁC ĐẶC TÍNH VÀ CƠ CHẾ KỸ THUẬT CỐT LÕI

Hệ thống được thiết kế theo mô hình 3 tầng chuẩn mực, phân định rõ ràng giữa Thiết kế Giao diện (WinForms & RDLC Designer), Xử lý nghiệp vụ logic (LINQ to SQL & Algorithms) và Cơ sở dữ liệu (Microsoft SQL Server):

### 1. Nền tảng CSDL & Cổng Đăng nhập, Đăng ký (Trần Ngọc Hà - 51.01.104.020)
- Thiết kế Form Đăng nhập & Đăng ký trực quan: Bố cục chia 2 cột cân đối, các trường nhập liệu thân thiện (Placeholder, nút ẩn/hiện mật khẩu, checkbox Lưu thông tin đăng nhập).
- Thiết kế Sơ đồ CSDL trên LINQ to SQL Designer (`CourseRegistration.dbml`): Ánh xạ 7 bảng thực thể quan hệ, trực quan hóa mối liên kết khóa chính - khóa ngoại giữa các bảng.
- Kiểm tra tính hợp lệ dữ liệu nhập (Validation): Kiểm tra định dạng email, số điện thoại hợp lệ và mật khẩu xác nhận trùng khớp trước khi gửi dữ liệu xử lý.

### 2. Quản trị viên, Thuật toán Lịch học & Bảo mật (Hồ Minh Nhật - 51.01.104.065)
- Quản lý dữ liệu (CRUD): Lập trình logic quản trị khóa học, danh mục đào tạo, tài khoản và phê duyệt hồ sơ bằng LINQ to SQL.
- Thuật toán kiểm tra trùng lịch học (`ScheduleHelper.cs`): Tự động phát hiện và ngăn chặn việc xếp trùng ca dạy của Giảng viên hoặc trùng Phòng học trong cùng khung giờ.
- Bảo mật mật khẩu PBKDF2 & Quản lý phiên (`SecurityHelper.cs`, `UserSession.cs`): Băm một chiều RFC 2898 kết hợp Salt 16 bytes và 10.000 vòng lặp; quản lý vòng đời phiên người dùng (`SessionToken`) và mã hóa AES-256 an toàn khi ghi nhớ đăng nhập.
- 4 lớp bảo vệ Quản trị viên: Vô hiệu hóa nút xóa trên UI khi Admin xem chính mình, chặn tự xóa tại code xử lý, cấm xóa hoặc hạ quyền Admin duy nhất, và tự động khôi phục Admin khẩn cấp nếu CSDL trống.
- Bảo đảm toàn vẹn giao dịch (ACID): Đồng bộ hóa các thao tác ghi nhận khóa học, trừ tiền số dư ví và cập nhật lượt voucher trong cùng một phiên giao dịch.
- Xuất bảng tính Excel XML độc lập (`ExcelExporter.cs`): Kết xuất trực tiếp định dạng XML Spreadsheet 2003 chuẩn của Microsoft, mở thuận tiện trên Excel/Sheets mà không cần cài đặt bộ Microsoft Office.

### 3. Kế hoạch và Kết quả Kiểm thử Hệ thống (Phan Thị Trang - 51.01.104.102)
- Kiểm thử hộp đen (Black-Box Testing): Thực thi bộ 10 ca kiểm thử (Test Cases) chi tiết bao quát toàn bộ quy trình nghiệp vụ: Đăng nhập, Đăng ký, Nạp ví, Chọn môn, Kiểm tra trùng lịch và Hủy môn.
- Phân tích giá trị biên (BVA) & Phân vùng tương đương: Kiểm chứng chặt chẽ các giới hạn dữ liệu đầu vào (ví dụ kiểm thử mã giảm giá tối thiểu 500k, giảm tối đa 250k tại ca kiểm thử TC06).
- Ghi nhận số liệu kiểm thử: Bảng 10 Test Cases đạt 100% kết quả mong đợi, hệ thống vận hành ổn định không phát sinh ngoại lệ runtime.

### 4. Cổng Học viên, Thời khóa biểu & Báo cáo RDLC (Đào Khánh Trúc - 51.01.104.109)
- 100% WinForms Designer & Bố cục thích ứng: Thiết kế Cổng Học viên trực quan (`FrmStudentMain` 6 Tab), tận dụng `Dock`, `Anchor` và `TableLayoutPanel` giúp giao diện co giãn mượt mà.
- Thiết kế ma trận Thời khóa biểu tuần: Bố cục dạng bảng ma trận 3 ca (Sáng - Chiều - Tối) × 7 ngày (Thứ 2 đến Chủ nhật) trực quan, tự động hiển thị theo các môn học đã đăng ký.
- Thiết kế trọn bộ 3 Mẫu Báo cáo chuẩn trên RDLC Report Designer:
  - `RptReceipt.rdlc`: Biên lai xác nhận đóng học phí & đăng ký môn học (khổ đứng A4 Portrait, căn chỉnh lề thước đo, kẻ khung viền, chữ ký 2 bên).
  - `RptCourseRevenue.rdlc`: Báo cáo tổng hợp doanh thu theo khóa học kèm dòng tổng kết `=Sum(...)`.
  - `RptStudentClassList.rdlc`: Báo cáo danh sách học viên đăng ký theo lớp (khổ ngang A4 Landscape chuẩn học vụ).
- Trình xem báo cáo & In biên lai GDI+: Thiết kế màn hình `FrmReportViewer` xuất file PDF/Word/Excel và mẫu in Biên lai học phí đồ họa GDI+ (`ReceiptPrinter.cs`) kèm mã vạch Code39.
- Trực quan hóa số liệu với MS Chart: Biểu đồ cột doanh thu theo môn học và biểu đồ tròn cơ cấu danh mục đào tạo.

---

## 3. TÀI KHOẢN ĐĂNG NHẬP KIỂM THỬ HỆ THỐNG

| Loại tài khoản | Tên đăng nhập | Mật khẩu | Quyền hạn & Chức năng kiểm thử |
| :--- | :--- | :--- | :--- |
| **Quản trị viên** | `admin` | `123456` | Toàn quyền Quản trị: Quản lý khóa học, danh mục, tài khoản, duyệt đăng ký, thống kê doanh thu, in báo cáo RDLC. |
| **Học viên 1** | `hocvien1` | `123456` | Có sẵn số dư học phí: Tra cứu khóa học, đăng ký, xem thời khóa biểu, in biên lai, đánh giá sao. |
| **Học viên 2** | `hocvien2` | `123456` | Tài khoản học viên để thử nghiệm nhiều người dùng cùng đăng ký và nộp học phí. |

---

## 4. HƯỚNG DẪN CÀI ĐẶT & CHẠY ỨNG DỤNG

### Cách 1: Chạy trực tiếp trong Visual Studio
1. Mở tệp giải pháp `Course Registration.sln` bằng Visual Studio 2019/2022.
2. Bấm phím `F5` (hoặc nút `Start`).
3. Cơ chế CSDL tự động (`DbHelper.cs`): Ứng dụng tự động dò tìm máy chủ SQL Server (`localhost`, `.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`). Nếu CSDL chưa có, hệ thống sẽ tự động khởi tạo và sinh đầy đủ dữ liệu mẫu mà không cần thao tác tay.

### Cách 2: Chạy file thực thi .exe đã biên dịch
- Đường dẫn file chạy sẵn:  
  `bin\Debug\Course Registration.exe`

### Cách 3: Nạp thủ công cơ sở dữ liệu qua SQL Server Management Studio
1. Mở SSMS, kết nối vào SQL Server.
2. Mở file script `Database.sql` và bấm `Execute` (`F5`).
3. Chuỗi kết nối mặc định lưu tại `App.config`.
