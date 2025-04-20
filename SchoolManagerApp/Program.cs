// Program.cs
// Program.cs
#define CONSOLE_TEST // ← Đổi giữa CONSOLE_TEST và GUI

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.layout;

namespace SchoolManagerApp
{
    internal static class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {
#if CONSOLE_TEST
            // Login
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var controllerAuth = new AuthController();
            
            if (controllerAuth.Login(username, password))
                Console.WriteLine("Login thành công!");
            else
                Console.WriteLine("Login thất bại!");

            var controllerRole = new RoleController();
            var roleToGetAll = await controllerRole.GetAll();
            foreach (var role in roleToGetAll)
            {
                Console.WriteLine($"- {role.GRANTED_ROLE}");
            }
            // Create Role
            Console.Write("Enter role name to create: ");
            string roleToCreate = Console.ReadLine();
            var createResult = controllerRole.CreateRole(roleToCreate);
            Console.WriteLine("Roles after creation:");
            var roleAfterCreate = await controllerRole.GetAll();
            foreach (var role in roleAfterCreate)
            {
                Console.WriteLine($"- {role.GRANTED_ROLE}");
            }

            // Delete Role
            Console.Write("Enter role name to delete: ");
            string roleToDelete = Console.ReadLine();
            var deleteResult = controllerRole.DeleteRole(roleToDelete);
            Console.WriteLine("Roles after deleting:");
            var roleAfterDelete = await controllerRole.GetAll();
            foreach (var role in roleAfterDelete)
            {
                Console.WriteLine($"- {role.GRANTED_ROLE}");
            }

            //Grant Permission
            Console.Write("Grant Permission: \n");
            Console.Write("Enter rolename: ");
            string roleName = Console.ReadLine();

            Console.Write("Enter object type (TABLE or VIEW): ");
            string objectType = Console.ReadLine();

            Console.Write("Enter object name: ");
            string objectName = Console.ReadLine();

            Console.Write("Enter privilege (SELECT, INSERT, UPDATE, DELETE): ");
            string privilege = Console.ReadLine();


            var grantResult = await controllerRole.GrantPermission(roleName, objectType, objectName, privilege);
            if (grantResult)
            {
                Console.WriteLine($"Cap quyen {privilege} cho {roleName} tren {objectName} thanh cong.");
            }
            else
            {
                Console.WriteLine("Cap quyen that bai.");
            }



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

