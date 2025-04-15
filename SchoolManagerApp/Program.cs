// Program.cs
// Program.cs
//#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

using System;
using System.Windows.Forms;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.layout;

namespace SchoolManagerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
#if CONSOLE_TEST
            // Console mode để test backend
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var controller = new AuthController();

            if (controller.Login(username, password))
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");

            Console.ReadLine();

#else
            // GUI mode (WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
#endif
        }
    }
}

