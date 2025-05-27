// Program.cs
//#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.Test;
using SchoolManagerApp.src.Views.layout;


namespace SchoolManagerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
#if CONSOLE_TEST
            //// Login
            //Console.Write("Enter username: ");
            //string username = "sys"; //Console.ReadLine();

            //Console.Write("Enter password: ");
            //string password = "admin"; // Console.ReadLine();

            //var test = new TestSysAudit(username, password); // user, password
            //test.RunAllTests().GetAwaiter().GetResult();



            // Login
            Console.Write("Enter username: ");
            string username2 = "admin"; //Console.ReadLine();

            Console.Write("Enter password: ");
            string password2 = "Admin123"; // Console.ReadLine();

            var controllerAuth = new AuthController();

            if (controllerAuth.Login(username2, password2))
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");
            var test2 = new TestAudit(username2, password2); // user, password
            test2.RunAllAuditTests().GetAwaiter().GetResult();

#else
            // GUI mode (WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthController authController = new AuthController();
            while (true)
            {
                var loginForm = new Login();
                loginForm.SetAuthController(authController);
                if (loginForm.ShowDialog() != DialogResult.OK)
                    break;

                BaseMain mainForm = null;

                if (authController.GetCurrentBasicRole().Equals("DBA", StringComparison.OrdinalIgnoreCase))
                {
                    mainForm = new DBAMain();
                }
                else if (authController.GetCurrentBasicRole().Equals("ROLE_NVCB", StringComparison.OrdinalIgnoreCase))
                {
                    mainForm = new NVCBMain(authController.GetUserName(), authController.GetExtended_NVCB_Role());
                }
                else if (authController.GetCurrentBasicRole().Equals("ROLE_SV", StringComparison.OrdinalIgnoreCase))
                {
                    mainForm = new SVMain(authController.GetUserName());
                }

                if (mainForm == null)
                {
                    MessageBox.Show("Không xác định được vai trò người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                mainForm.SetAuthController(authController);
                loginForm.Hide(); // Ẩn login
                mainForm.ShowDialog(); // Khi mainForm đóng thì quay lại login
            }

#endif
        }
    }
}
