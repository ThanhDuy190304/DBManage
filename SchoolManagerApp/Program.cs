// Program.cs
// Program.cs
#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

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
            // Login
            Console.Write("Enter username: ");
            string username = "admin"; //Console.ReadLine();

            Console.Write("Enter password: ");
            string password = "Admin123"; // Console.ReadLine();

            var controllerAuth = new AuthController();

            if (controllerAuth.Login(username, password))
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");
            var testNhanVien = new TestNhanVienController("NV011", "123"); // user, password
            testNhanVien.RunAllTests().GetAwaiter().GetResult();

            
            //var testMomon = new TestMomonController("NVPDT002", "123");
            //testMomon.RunAllTests().GetAwaiter().GetResult();



#else
            // GUI mode (WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthController authController = new AuthController();
            var loginForm = new Login();
            loginForm.SetAuthController(authController);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Main main = new Main();
                main.SetAuthController(authController);
                Application.Run(main);
            }
#endif
        }
    }
}
