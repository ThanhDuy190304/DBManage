// Program.cs
// Program.cs
#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagerApp.src.Controller;
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
            string username = "NV003"; //Console.ReadLine();

            Console.Write("Enter password: ");
            string password = "nv003"; // Console.ReadLine();

            var controllerAuth = new AuthController();

            if (controllerAuth.Login(username, password))
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");
            var test = new TestCau4(username, password); // user, password
            test.RunAllTests().GetAwaiter().GetResult();
            // NV PDT = NV003
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
