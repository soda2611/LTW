using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Course_Registration
{
    public partial class FrmReportViewer : Form
    {
        public FrmReportViewer()
        {
            InitializeComponent();
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            // ReportViewer sẽ được cấu hình khi gọi ShowReceipt hoặc ShowCourseRevenue
        }

        /// <summary>
        /// Nạp và hiển thị Biên lai thu học phí & xác nhận đăng ký học phần dạng RDLC.
        /// </summary>
        public void ShowReceipt(EnrollmentReceiptData data)
        {
            if (data == null)
            {
                MessageBox.Show("Không có dữ liệu biên lai để hiển thị báo cáo.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Text = string.Format("Biên lai thu học phí #REC-{0} - {1} (Microsoft Report Viewer)",
                    data.EnrollmentId, data.StudentFullName);

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "RptReceipt.rdlc");
                if (!File.Exists(reportPath))
                {
                    // Thử tìm trong thư mục project
                    reportPath = Path.Combine(Application.StartupPath, "..", "..", "Reports", "RptReceipt.rdlc");
                }

                if (File.Exists(reportPath))
                {
                    reportViewer1.LocalReport.ReportPath = Path.GetFullPath(reportPath);
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Course_Registration.Reports.RptReceipt.rdlc";
                }

                List<EnrollmentReceiptData> list = new List<EnrollmentReceiptData> { data };
                ReportDataSource rds = new ReportDataSource("ReceiptDataSet", list);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Nạp các tham số hiển thị vào báo cáo RDLC (ReportParameters)
                string cashier = (UserSession.CurrentUser != null && UserSession.CurrentUser.IsAdmin && !string.IsNullOrEmpty(UserSession.CurrentUser.FullName))
                    ? UserSession.CurrentUser.FullName
                    : "Ban Quản lý Đào tạo";
                List<ReportParameter> rptParams = new List<ReportParameter>
                {
                    new ReportParameter("CashierName", cashier),
                    new ReportParameter("CenterName", "TRUNG TÂM ĐÀO TẠO CÔNG NGHỆ THÔNG TIN & LẬP TRÌNH VIÊN")
                };
                reportViewer1.LocalReport.SetParameters(rptParams);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo RDLC:\n" + ex.Message, "Lỗi báo cáo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nạp và hiển thị Báo cáo thống kê doanh thu & lượt đăng ký theo khóa học dạng RDLC.
        /// </summary>
        public void ShowCourseRevenue(List<CourseRevenueReportData> list, string filterDescription = "")
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê để lập báo cáo.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Text = "Báo cáo thống kê doanh thu khóa học (Microsoft Report Viewer RDLC)";

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "RptCourseRevenue.rdlc");
                if (!File.Exists(reportPath))
                {
                    reportPath = Path.Combine(Application.StartupPath, "..", "..", "Reports", "RptCourseRevenue.rdlc");
                }

                if (File.Exists(reportPath))
                {
                    reportViewer1.LocalReport.ReportPath = Path.GetFullPath(reportPath);
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Course_Registration.Reports.RptCourseRevenue.rdlc";
                }

                ReportDataSource rds = new ReportDataSource("RevenueDataSet", list);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Nạp các tham số hiển thị vào báo cáo RDLC (ReportParameters)
                string creator = (UserSession.CurrentUser != null && !string.IsNullOrEmpty(UserSession.CurrentUser.FullName))
                    ? UserSession.CurrentUser.FullName
                    : "Quản trị viên Hệ thống";
                string filter = string.IsNullOrEmpty(filterDescription) ? "Toàn bộ thời gian đào tạo" : filterDescription;
                List<ReportParameter> rptParams = new List<ReportParameter>
                {
                    new ReportParameter("ReportFilter", filter),
                    new ReportParameter("ReportCreatedBy", creator),
                    new ReportParameter("CenterName", "TRUNG TÂM ĐÀO TẠO CÔNG NGHỆ THÔNG TIN & LẬP TRÌNH VIÊN")
                };
                reportViewer1.LocalReport.SetParameters(rptParams);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo RDLC:\n" + ex.Message, "Lỗi báo cáo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nạp và hiển thị Báo cáo danh sách học viên đăng ký theo khóa học dạng RDLC.
        /// </summary>
        public void ShowStudentEnrollmentList(List<StudentEnrollmentReportData> list, string filterDescription = "")
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu học viên để lập báo cáo.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Text = "Báo cáo danh sách học viên đăng ký (Microsoft Report Viewer RDLC)";

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "RptStudentClassList.rdlc");
                if (!File.Exists(reportPath))
                {
                    reportPath = Path.Combine(Application.StartupPath, "..", "..", "Reports", "RptStudentClassList.rdlc");
                }

                if (File.Exists(reportPath))
                {
                    reportViewer1.LocalReport.ReportPath = Path.GetFullPath(reportPath);
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Course_Registration.Reports.RptStudentClassList.rdlc";
                }

                ReportDataSource rds = new ReportDataSource("StudentEnrollmentDataSet", list);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Nạp các tham số hiển thị vào báo cáo RDLC (ReportParameters)
                string creator = (UserSession.CurrentUser != null && !string.IsNullOrEmpty(UserSession.CurrentUser.FullName))
                    ? UserSession.CurrentUser.FullName
                    : "Quản trị viên Hệ thống";
                string filter = string.IsNullOrEmpty(filterDescription) ? "Tất cả học viên" : filterDescription;
                List<ReportParameter> rptParams = new List<ReportParameter>
                {
                    new ReportParameter("ReportFilter", filter),
                    new ReportParameter("ReportCreatedBy", creator),
                    new ReportParameter("CenterName", "TRUNG TÂM ĐÀO TẠO CÔNG NGHỆ THÔNG TIN & LẬP TRÌNH VIÊN")
                };
                reportViewer1.LocalReport.SetParameters(rptParams);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo RDLC:\n" + ex.Message, "Lỗi báo cáo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

