# ĐỒ ÁN LẬP TRÌNH WINDOWS: HỆ THỐNG QUẢN LÝ ĐÀO TẠO VÀ ĐĂNG KÝ KHÓA HỌC
> **Học phần:** Lập trình trên môi trường Windows / Cơ sở dữ liệu  
> **Nền tảng phát triển:** C# .NET Framework 4.8 • Windows Forms • LINQ to SQL • Microsoft SQL Server  
> **Kiến trúc:** 100% Visual Studio Designer (*.Designer.cs), O/R Mapping qua CourseRegistration.dbml

---

## 1. THÀNH VIÊN NHÓM VÀ BẢNG PHÂN CÔNG NHIỆM VỤ (WBS)

Toàn bộ khối lượng công việc được phân bổ đồng đều ở mức 25% cho mỗi thành viên (tổng 100%), tương ứng 2.5 điểm cốt lõi và 1.25 điểm mở rộng.

Danh sách thành viên thực hiện:

| Giai đoạn | Sinh viên thực hiện | MSSV | Vai trò chuyên trách | Hạng mục công việc kỹ thuật & Báo cáo | Tệp bàn giao chính | Tỷ lệ đóng góp | Tỷ lệ hoàn thành |
| :-: | :--- | :--- | :--- | :--- | :--- | :-: | :-: |
| **Giai đoạn 1** | **Trần Ngọc Hà** | 51.01.104.020 | CSDL 7 bảng & Form Đăng nhập, Đăng ký | • Khảo sát bài toán; Thiết kế CSDL 7 bảng trên SQL Server (Database.sql); Ánh xạ LINQ to SQL.<br>• Thiết kế Form Đăng nhập & Đăng ký.<br>• **Chủ trì soạn thảo phần CSDL SQL Server:** 7 bảng thực thể, 4 nhóm RBTV, dạng chuẩn 3NF/BCNF. | FrmLogin.Designer.cs<br>FrmRegister.Designer.cs<br>CourseRegistration.dbml<br>Database.sql<br>FrmLogin.cs<br>FrmRegister.cs | 25% | 100% |
| **Giai đoạn 2** | **Hồ Minh Nhật** *(Trưởng nhóm)* | 51.01.104.065 | Trưởng nhóm – Quản trị viên, Thuật toán & Bảo mật | • Phân công và điều phối tiến độ nhóm, kiểm soát phân quyền hệ thống Admin / Học viên.<br>• Lập trình Form Quản trị (FrmAdminMain.cs 7 Tab): Khóa học, Danh mục, Tài khoản, Mã ưu đãi.<br>• Xây dựng thuật toán kiểm tra xung đột lịch học đa chiều (ScheduleHelper.cs).<br>• Cài đặt mã hóa mật khẩu PBKDF2, mã hóa lưu phiên AES-256 (SecurityHelper.cs) & Quản lý phiên (UserSession.cs).<br>• Thiết lập 4 lớp bảo vệ tài khoản Quản trị, tự phục hồi CSDL (DbHelper.cs) & Xuất Excel XML (ExcelExporter.cs). | FrmAdminMain.cs<br>ScheduleHelper.cs<br>SecurityHelper.cs<br>UserSession.cs<br>DbHelper.cs<br>ExcelExporter.cs | 25% | 100% |
| **Giai đoạn 3** | **Phan Thị Trang** | 51.01.104.102 | Kiểm thử Hệ thống, Đảm bảo chất lượng & Biểu đồ | • Xây dựng bộ kịch bản kiểm thử hộp đen (Bộ 10 Test Cases chi tiết) & Phân tích giá trị biên (BVA).<br>• Thiết kế biểu đồ cột doanh thu & biểu đồ tròn cơ cấu đào tạo (MS Chart).<br>• **Chủ trì soạn thảo tài liệu (Phần 1):** Cơ chế bảo mật PBKDF2 & RBAC, 10 Test Cases kiểm thử, Cấu hình App.config, Biểu đồ MS Chart, Đóng gói cài đặt. | 10 Test Cases (TC01-TC10)<br>Báo cáo kiểm thử hộp đen<br>Mã nguồn biểu đồ MS Chart | 25% | 100% |
| **Giai đoạn 4** | **Đào Khánh Trúc** | 51.01.104.109 | Thiết kế Cổng Học viên, Thời khóa biểu & Báo cáo RDLC | • Thiết kế Cổng Học viên (FrmStudentMain.Designer.cs 6 Tab) và Giới thiệu (FrmAbout.Designer.cs).<br>• Thiết kế ma trận hiển thị Thời khóa biểu tuần & Bộ 3 mẫu báo cáo in ấn Microsoft RDLC.<br>• **Chủ trì soạn thảo tài liệu (Phần 2):** Hệ thống 15 Forms, Bố cục Responsive, Nghiệp vụ ACID, Bộ 3 báo cáo RDLC, Excel & Barcode, Kết luận. | FrmStudentMain.Designer.cs<br>FrmAbout.Designer.cs<br>Thư mục Reports\ (.rdlc)<br>FrmReportViewer.Designer.cs<br>ReceiptPrinter.cs | 25% | 100% |

---

## 2. CÁC TÍNH NĂNG VÀ CƠ CHẾ KỸ THUẬT CỐT LÕI

Hệ thống được thiết kế theo mô hình 3 tầng chuẩn mực, phân định rõ ràng giữa Thiết kế Giao diện (WinForms & RDLC Designer), Xử lý nghiệp vụ logic (LINQ to SQL & Algorithms) và Cơ sở dữ liệu (Microsoft SQL Server):

### 1. Nền tảng CSDL & Cổng Đăng nhập, Đăng ký (Trần Ngọc Hà - 51.01.104.020)
- Thiết kế Form Đăng nhập & Đăng ký trực quan: Bố cục chia 2 cột cân đối, thiết kế các trường nhập liệu thân thiện (Placeholder, nút ẩn/hiện mật khẩu, checkbox Lưu thông tin đăng nhập).
- Thiết kế Sơ đồ CSDL trên LINQ to SQL Designer (CourseRegistration.dbml): Ánh xạ 7 bảng thực thể quan hệ, trực quan hóa mối liên kết khóa chính - khóa ngoại giữa các bảng.
- Kiểm tra tính hợp lệ dữ liệu nhập (Validation): Kiểm tra định dạng email, số điện thoại hợp lệ và mật khẩu xác nhận trùng khớp trước khi gửi dữ liệu xử lý.

### 2. Quản trị viên, Thuật toán Lịch học & Bảo mật (Hồ Minh Nhật - 51.01.104.065)
- Quản lý dữ liệu (CRUD): Lập trình logic quản trị khóa học, danh mục đào tạo, tài khoản và phê duyệt hồ sơ bằng LINQ to SQL.
- Thuật toán kiểm tra trùng lịch học (ScheduleHelper.cs): Tự động phát hiện và ngăn chặn việc xếp trùng ca dạy của Giảng viên hoặc trùng Phòng học trong cùng khung giờ.
- Bảo mật mật khẩu PBKDF2 & Quản lý phiên (SecurityHelper.cs, UserSession.cs): Băm một chiều RFC 2898 kết hợp Salt 16 bytes và 10,000 vòng lặp; quản lý vòng đời phiên người dùng (SessionToken) và mã hóa AES-256 an toàn khi ghi nhớ đăng nhập.
- 4 lớp bảo vệ Quản trị viên: Vô hiệu hóa nút xóa trên UI khi Admin xem chính mình, chặn tự xóa tại code xử lý, cấm xóa hoặc hạ quyền Admin duy nhất, và tự động khôi phục Admin khẩn cấp nếu CSDL trống.
- Bảo đảm toàn vẹn giao dịch (ACID): Đồng bộ hóa các thao tác ghi nhận khóa học, trừ tiền số dư ví và cập nhật lượt voucher trong cùng một lượt gọi SubmitChanges().
- Xuất bảng tính Excel XML độc lập (ExcelExporter.cs): Kết xuất trực tiếp định dạng XML Spreadsheet 2003 chuẩn của Microsoft, mở thuận tiện trên Excel/Sheets mà không cần máy cài bộ Microsoft Office.

### 3. Kiểm thử Hệ thống, Phân tích Giá trị Biên & Biểu đồ MS Chart (Phan Thị Trang - 51.01.104.102)
- Kiểm thử hộp đen toàn diện (Black-Box Testing): Biên soạn và thực thi bộ 10 ca kiểm thử (Test Cases) chi tiết bao quát toàn bộ quy trình nghiệp vụ: Đăng nhập, Đăng ký, Nạp ví, Chọn môn, Kiểm tra trùng lịch và Hủy môn.
- Phân tích giá trị biên (BVA) & Phân vùng tương đương: Kiểm chứng chặt chẽ các giới hạn dữ liệu đầu vào (ví dụ kiểm thử mã giảm giá tối thiểu 500k, giảm tối đa 250k tại ca kiểm thử TC06).
- Trực quan hóa số liệu với MS Chart: Thiết kế biểu đồ cột doanh thu theo khóa học và biểu đồ tròn cơ cấu doanh thu theo danh mục đào tạo trên màn hình Quản trị.
- Kiểm chứng toàn vẹn dữ liệu & Nghiệm thu: Đảm bảo hệ thống vận hành ổn định, không phát sinh lỗi ngoại lệ (zero runtime exceptions).

### 4. Thiết kế Cổng Học viên, Thời khóa biểu & Báo cáo RDLC (Đào Khánh Trúc - 51.01.104.109)
- 100% WinForms Designer & Bố cục thích ứng: Thiết kế Cổng Học viên trực quan (FrmStudentMain 6 Tab), tận dụng Dock, Anchor và TableLayoutPanel giúp giao diện co giãn mượt mà.
- Thiết kế ma trận Thời khóa biểu tuần: Bố cục dạng bảng ma trận 3 ca (Sáng - Chiều - Tối) × 7 ngày (Thứ 2 đến Chủ nhật) trực quan, tự động hiển thị theo các môn học đã đăng ký.
- Thiết kế trọn bộ 3 Mẫu Báo cáo chuẩn trên RDLC Report Designer:
  - RptReceipt.rdlc: Biên lai xác nhận đóng học phí & đăng ký môn học (khổ đứng A4 Portrait, căn chỉnh lề thước đo, kẻ khung viền, chữ ký 2 bên).
  - RptCourseRevenue.rdlc: Báo cáo tổng hợp doanh thu theo khóa học kèm dòng tổng kết.
  - RptStudentClassList.rdlc: Báo cáo danh sách học viên đăng ký theo lớp (khổ ngang A4 Landscape chuẩn học vụ).
- Trình xem báo cáo & In biên lai GDI+: Thiết kế màn hình FrmReportViewer xuất file PDF/Word/Excel và mẫu in Biên lai học phí đồ họa GDI+ (ReceiptPrinter.cs) kèm mã vạch Code39.

---

## 3. TÀI KHOẢN ĐĂNG NHẬP KIỂM THỬ HỆ THỐNG

| Loại tài khoản | Tên đăng nhập | Mật khẩu | Quyền hạn & Chức năng kiểm thử |
| :--- | :--- | :--- | :--- |
| **Quản trị viên** | admin | 123456 | Toàn quyền Quản trị: Quản lý khóa học, danh mục, tài khoản, duyệt đăng ký, thống kê doanh thu, in báo cáo RDLC. |
| **Học viên 1** | hocvien1 | 123456 | Có sẵn số dư học phí: Tra cứu khóa học, đăng ký, xem thời khóa biểu, in biên lai, đánh giá sao. |
| **Học viên 2** | hocvien2 | 123456 | Tài khoản học viên để thử nghiệm nhiều người dùng cùng đăng ký và nộp học phí. |

*(Tại màn hình Đăng nhập FrmLogin, hệ thống tích hợp sẵn 2 nút "Điền mẫu Quản trị" và "Điền mẫu Học viên" để nạp nhanh tài khoản trong 1 cú click).*

---

## 4. HƯỚNG DẪN CÀI ĐẶT & CHẠY ỨNG DỤNG

### Cách 1: Chạy trực tiếp trong Visual Studio (Khuyên dùng)
1. Mở tệp giải pháp `Course Registration.sln` bằng Visual Studio 2019/2022.
2. Bấm phím `F5` (hoặc nút `Start`).
3. Cơ chế CSDL tự động (DbHelper.cs): Ứng dụng tích hợp bộ nạp tự động, tự động dò tìm máy chủ SQL Server (`.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`). Nếu CSDL chưa có, hệ thống sẽ tự động khởi tạo và sinh đầy đủ dữ liệu mẫu mà không cần thao tác tay.

### Cách 2: Chạy file thực thi .exe đã biên dịch
- Đường dẫn file chạy sẵn:  
  `bin\Debug\Course Registration.exe`

### Cách 3: Nạp thủ công cơ sở dữ liệu (Nếu dùng SQL Server Management Studio)
1. Mở SSMS, kết nối vào SQL Server.
2. Mở file script `Database.sql` và bấm `Execute` (`F5`).
3. Chuỗi kết nối mặc định lưu tại `App.config`:
   ```xml
   <connectionStrings>
       <add name="Course_Registration.Properties.Settings.CourseRegistrationDBConnectionString"
            connectionString="Data Source=.;Initial Catalog=CourseRegistrationDB;Integrated Security=True;Encrypt=False"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

---

## 5. DANH MỤC CÁC MÀN HÌNH & TÀI LIỆU HỌC PHẦN

1. **Màn hình Giới thiệu thành viên nhóm (FrmAbout.cs):**
   - Cách mở trong app: Bấm vào nút "Giới thiệu" xuất hiện ở góc trên bên phải của:
     - Màn hình Đăng nhập (FrmLogin)
     - Màn hình Quản trị viên (FrmAdminMain)
     - Màn hình Cổng Học viên (FrmStudentMain)
   - Hiển thị đầy đủ 4 thẻ thành viên với Họ tên, MSSV và nhiệm vụ cụ thể.
2. **Màn hình Đăng nhập & Đăng ký:** FrmLogin.cs, FrmRegister.cs.
3. **Màn hình Quản trị viên (7 Tab):** FrmAdminMain.cs (Khóa học, Danh mục, Tài khoản, Đăng ký, Mã ưu đãi, Đánh giá, Thống kê & Biểu đồ).
4. **Màn hình Cổng Học viên (6 Tab):** FrmStudentMain.cs (Tra cứu khóa học, Khóa học của tôi, Thời khóa biểu ma trận, Đánh giá khóa học, Ví học phí, Thông tin cá nhân).
5. **Màn hình Xem & In Báo cáo RDLC (3 Mẫu Báo cáo Chuẩn):** FrmReportViewer.cs
   - `RptReceipt.rdlc`: Biên lai xác nhận đóng học phí & đăng ký môn học (kèm barcode, học phí thực nộp, chữ ký).
   - `RptCourseRevenue.rdlc`: Báo cáo tổng hợp doanh thu và số lượt đăng ký theo khóa học.
   - `RptStudentClassList.rdlc`: Báo cáo danh sách học viên đăng ký theo khóa học / Bảng theo dõi lớp học.
6. **Báo cáo học thuật chính thức:**  
   - Báo cáo Word học thuật: `tennhom.docx` / `BAO_CAO_CUOI_KY.docx` (Khổ A4, lề 2.5 cm, Times New Roman 13 pt, giãn dòng 1.15 lines, thuần chữ đen, IEEE).
   - Báo cáo Markdown: `BAO_CAO_CUOI_KY.md`.

---

## 6. CÔNG NGHỆ VÀ ĐIỂM SÁNG KỸ THUẬT NỔI BẬT

- **100% WinForms Designer:** Toàn bộ giao diện được thiết kế trực quan bằng bộ công cụ Visual Studio Designer, chuẩn thuộc tính phân cấp, không tạo control động ở runtime.
- **Bảo mật mật khẩu:** Thuật toán băm một chiều PBKDF2 (RFC 2898) kết hợp Salt ngẫu nhiên 16 bytes. Admin không nhìn thấy mật khẩu thô của người dùng (mã hóa một chiều, hiển thị mặt nạ).
- **Quản lý phiên & Lưu thông tin đăng nhập (UserSession):** Quản lý vòng đời phiên người dùng (SessionToken, thời gian đăng nhập, số dư ví theo thời gian thực), tính năng "Ghi nhớ đăng nhập" mã hóa AES-256 an toàn lưu tại %LocalAppData%.
- **Bảo vệ tài khoản Quản trị:** Tự động vô hiệu hóa nút xóa khi Admin xem chính mình, cấm xóa hoặc hạ quyền Admin duy nhất, tự động khôi phục Admin khẩn cấp nếu CSDL trống.
- **Kiểm tra trùng lịch học:** Kiểm tra trùng lịch đa chiều (trùng ca học viên, trùng lịch giảng viên, trùng phòng học).
- **Xuất Excel & In ấn độc lập:** Xuất bảng tính Excel XML không cần cài đặt Microsoft Office; In biên lai thu học phí GDI+ sắc nét kèm mã vạch.
