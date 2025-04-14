// Program.cs
// Program.cs
#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

using System;
using System.Windows.Forms;
using SchoolManagerApp.src.Controller;

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

            var controller = new LoginController(username, password);

            if (controller.Login())
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");

            Console.ReadLine();

#else
            // GUI mode (WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new src.Views.layout.Login()); // hoặc Form chính
#endif
        }
    }
}

