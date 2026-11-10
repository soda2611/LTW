using System;
using System.IO;
using System.Windows.Forms;

namespace Course_Registration
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng Quản lý Bán & Đăng ký Khóa học.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) =>
            {
                try
                {
                    File.WriteAllText("crash.log", e.Exception.ToString());
                }
                catch { }

                MessageBox.Show("Đã xảy ra sự cố trong ứng dụng:\n\n" + e.Exception.Message + 
                    "\n\nChi tiết kỹ thuật đã được ghi lại trong file crash.log.",
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Nạp thư viện native cho Microsoft ReportViewer (RDLC)
            try
            {
                SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            }
            catch { }

            DbHelper.EnsureDatabaseReady();

            Application.Run(new FrmLogin());
        }
    }
}