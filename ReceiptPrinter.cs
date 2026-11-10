using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Course_Registration
{
    public class EnrollmentReceiptData
    {
        public int EnrollmentId { get; set; }
        public DateTime EnrollDate { get; set; }
        public string StudentFullName { get; set; }
        public string StudentUsername { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
        public string Instructor { get; set; }
        public string ScheduleText { get; set; }
        public string Room { get; set; }
        public DateTime StartDate { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public string VoucherCode { get; set; }
        public decimal PaidAmount { get; set; }
        public string StatusText { get; set; }
        public string Note { get; set; }
    }

    /// <summary>
    /// Vẽ biên lai thu học phí và xác nhận đăng ký học phần lên PrintDocument.
    /// </summary>
    public static class ReceiptPrinter
    {
        public static void DrawReceipt(Graphics g, Rectangle pageBounds, EnrollmentReceiptData data)
        {
            if (data == null)
            {
                return;
            }

            g.SmoothingMode = SmoothingMode.AntiAlias;

            int left = pageBounds.Left + 50;
            int right = pageBounds.Right - 50;
            int width = right - left;
            int y = pageBounds.Top + 45;

            using (Font fontOrg = new Font("Segoe UI", 10.5f, FontStyle.Bold))
            using (Font fontSub = new Font("Segoe UI", 9f, FontStyle.Regular))
            using (Font fontTitle = new Font("Segoe UI", 16f, FontStyle.Bold))
            using (Font fontSection = new Font("Segoe UI", 10.5f, FontStyle.Bold))
            using (Font fontLabel = new Font("Segoe UI", 9.5f, FontStyle.Regular))
            using (Font fontValue = new Font("Segoe UI", 9.5f, FontStyle.Bold))
            using (Font fontTotal = new Font("Segoe UI", 11.5f, FontStyle.Bold))
            using (Font fontItalic = new Font("Segoe UI", 9f, FontStyle.Italic))
            using (Brush brushDark = new SolidBrush(Color.FromArgb(15, 23, 42)))
            using (Brush brushMuted = new SolidBrush(Color.FromArgb(71, 85, 105)))
            using (Brush brushNavy = new SolidBrush(Color.FromArgb(30, 64, 175)))
            using (Brush brushHeaderBg = new SolidBrush(Color.FromArgb(241, 245, 249)))
            using (Pen penBorder = new Pen(Color.FromArgb(203, 213, 225), 1f))
            using (Pen penStrong = new Pen(Color.FromArgb(51, 65, 85), 1.5f))
            {
                // 1. Tiêu đề đơn vị & Số biên lai
                g.DrawString("PHÒNG ĐÀO TẠO & QUẢN LÝ HỌC VỤ", fontOrg, brushDark, left, y);
                g.DrawString("Hệ thống quản lý đăng ký khóa học", fontSub, brushMuted, left, y + 22);

                StringFormat rightAlign = new StringFormat { Alignment = StringAlignment.Far };
                string receiptNo = string.Format("Số biên lai: BL-{0:D6}", data.EnrollmentId);
                string printTime = string.Format("Ngày in: {0:dd/MM/yyyy HH:mm}", DateTime.Now);
                g.DrawString(receiptNo, fontValue, brushNavy, right, y, rightAlign);
                g.DrawString(printTime, fontSub, brushMuted, right, y + 22, rightAlign);

                y += 54;
                g.DrawLine(penStrong, left, y, right, y);
                y += 24;

                // 2. Tên biểu mẫu
                StringFormat centerAlign = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("BIÊN LAI XÁC NHẬN ĐĂNG KÝ KHÓA HỌC", fontTitle, brushDark,
                    new RectangleF(left, y, width, 34), centerAlign);
                y += 36;
                g.DrawString(string.Format("Ngày đăng ký: {0:dd/MM/yyyy HH:mm}  |  Trạng thái: {1}", data.EnrollDate, data.StatusText),
                    fontSub, brushMuted, new RectangleF(left, y, width, 22), centerAlign);
                y += 38;

                // 3. Khung thông tin học viên
                g.DrawString("I. THÔNG TIN HỌC VIÊN", fontSection, brushNavy, left, y);
                y += 26;
                Rectangle boxStudent = new Rectangle(left, y, width, 74);
                g.FillRectangle(brushHeaderBg, boxStudent);
                g.DrawRectangle(penBorder, boxStudent);

                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Họ và tên học viên:", data.StudentFullName, left + 16, y + 12, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Tài khoản học viên:", data.StudentUsername, left + width / 2 + 10, y + 12, 130);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Email liên hệ:", string.IsNullOrEmpty(data.StudentEmail) ? "---" : data.StudentEmail, left + 16, y + 42, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Số điện thoại:", string.IsNullOrEmpty(data.StudentPhone) ? "---" : data.StudentPhone, left + width / 2 + 10, y + 42, 130);

                y += 94;

                // 4. Khung thông tin học phần
                g.DrawString("II. THÔNG TIN KHÓA HỌC", fontSection, brushNavy, left, y);
                y += 26;
                Rectangle boxCourse = new Rectangle(left, y, width, 132);
                g.DrawRectangle(penBorder, boxCourse);

                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Mã khóa học:", data.CourseCode, left + 16, y + 12, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Danh mục:", data.CategoryName, left + width / 2 + 10, y + 12, 130);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Tên khóa học:", data.CourseName, left + 16, y + 40, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Giảng viên phụ trách:", data.Instructor, left + 16, y + 68, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Ngày khai giảng:", data.StartDate.ToString("dd/MM/yyyy"), left + width / 2 + 10, y + 68, 130);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Lịch học hàng tuần:", data.ScheduleText, left + 16, y + 96, 135);
                DrawField(g, fontLabel, fontValue, brushMuted, brushDark, "Phòng học:", data.Room, left + width / 2 + 10, y + 96, 130);

                y += 154;

                // 5. Bảng chi tiết thanh toán học phí
                g.DrawString("III. CHI TIẾT HỌC PHÍ", fontSection, brushNavy, left, y);
                y += 26;

                int rowH = 34;
                DrawFeeRow(g, penBorder, brushHeaderBg, fontValue, brushDark, left, y, width, rowH, "Khoản mục", "Số tiền (VNĐ)", true);
                y += rowH;
                DrawFeeRow(g, penBorder, null, fontLabel, brushDark, left, y, width, rowH, "1. Học phí niêm yết của khóa học", string.Format("{0:N0} VNĐ", data.OriginalPrice), false);
                y += rowH;

                string discountLabel = string.IsNullOrEmpty(data.VoucherCode)
                    ? "2. Miễn giảm học phí / Học bổng"
                    : string.Format("2. Miễn giảm học phí (Mã áp dụng: {0})", data.VoucherCode);
                string discountVal = data.DiscountAmount > 0
                    ? string.Format("-{0:N0} VNĐ", data.DiscountAmount)
                    : "0 VNĐ";
                DrawFeeRow(g, penBorder, null, fontLabel, brushDark, left, y, width, rowH, discountLabel, discountVal, false);
                y += rowH;

                DrawFeeRow(g, penBorder, brushHeaderBg, fontTotal, brushNavy, left, y, width, rowH + 4,
                    "TỔNG HỌC PHÍ THỰC THU", string.Format("{0:N0} VNĐ", data.PaidAmount), false);
                y += rowH + 22;

                if (!string.IsNullOrWhiteSpace(data.Note))
                {
                    g.DrawString("Ghi chú: " + data.Note, fontItalic, brushMuted, new RectangleF(left, y, width, 36));
                    y += 38;
                }
                else
                {
                    y += 16;
                }

                // 6. Chữ ký
                int colW = width / 2;
                g.DrawString("HỌC VIÊN ĐĂNG KÝ", fontValue, brushDark, new RectangleF(left, y, colW, 22), centerAlign);
                g.DrawString("ĐẠI DIỆN PHÒNG ĐÀO TẠO", fontValue, brushDark, new RectangleF(left + colW, y, colW, 22), centerAlign);
                y += 20;
                g.DrawString("(Ký và ghi rõ họ tên)", fontItalic, brushMuted, new RectangleF(left, y, colW, 20), centerAlign);
                g.DrawString("(Xác nhận hệ thống)", fontItalic, brushMuted, new RectangleF(left + colW, y, colW, 20), centerAlign);

                y += 78;
                g.DrawString(data.StudentFullName, fontValue, brushDark, new RectangleF(left, y, colW, 22), centerAlign);
                g.DrawString("Đã xác nhận thanh toán điện tử", fontSub, brushMuted, new RectangleF(left + colW, y, colW, 22), centerAlign);
            }
        }

        private static void DrawField(
            Graphics g,
            Font fLabel,
            Font fVal,
            Brush bLabel,
            Brush bVal,
            string label,
            string value,
            int x,
            int y,
            int labelWidth)
        {
            g.DrawString(label, fLabel, bLabel, x, y);
            g.DrawString(value ?? string.Empty, fVal, bVal, x + labelWidth, y);
        }

        private static void DrawFeeRow(
            Graphics g,
            Pen border,
            Brush bg,
            Font font,
            Brush fg,
            int x,
            int y,
            int width,
            int height,
            string col1,
            string col2,
            bool isHeader)
        {
            Rectangle rect = new Rectangle(x, y, width, height);
            if (bg != null)
            {
                g.FillRectangle(bg, rect);
            }
            g.DrawRectangle(border, rect);

            int splitX = x + (int)(width * 0.68);
            g.DrawLine(border, splitX, y, splitX, y + height);

            StringFormat leftMid = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
            StringFormat rightMid = new StringFormat
            {
                Alignment = isHeader ? StringAlignment.Center : StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(col1, font, fg, new RectangleF(x + 12, y, splitX - x - 20, height), leftMid);
            g.DrawString(col2, font, fg, new RectangleF(splitX + 10, y, x + width - splitX - 22, height), rightMid);
        }
    }
}

