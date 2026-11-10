using System;

namespace Course_Registration
{
    /// <summary>
    /// DTO mô hình dữ liệu báo cáo thống kê doanh thu theo khóa học cho RDLC.
    /// </summary>
    public class CourseRevenueReportData
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
        public string Instructor { get; set; }
        public decimal Price { get; set; }
        public int TotalEnrollments { get; set; }
        public decimal TotalRevenue { get; set; }
        public string StatusText { get; set; }
    }

    /// <summary>
    /// DTO mô hình dữ liệu báo cáo danh sách học viên đăng ký theo khóa học cho RDLC.
    /// </summary>
    public class StudentEnrollmentReportData
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
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
        public DateTime EnrollDate { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string StatusText { get; set; }
        public string Note { get; set; }
    }
}

