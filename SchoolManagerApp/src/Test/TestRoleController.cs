using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.src.Tests
{
    internal class TestRoleController
    {
        public static async Task Main(string[] args)
        {
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
            string objectType = "TABLE"; //Console.ReadLine();

            Console.Write("Enter object name: ");
            string objectName = "DONVI";//Console.ReadLine();
            Console.Write("\n");
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

            //Show role permission
            await controllerRole.ShowRolePermissions(roleName);

            //Revoke role permission

            Console.Write("Revoke Permission: \n");
            Console.Write("Enter rolename: ");
            string roleName_revoke = Console.ReadLine();

            Console.Write("Enter object type (TABLE or VIEW): ");
            string objectType_revoke = "TABLE"; //Console.ReadLine();

            Console.Write("Enter object name: ");
            string objectName_revoke = "DONVI";//Console.ReadLine();
            Console.Write("\n");
            Console.Write("Enter privilege (SELECT, INSERT, UPDATE, DELETE): ");
            string privilege_revoke = Console.ReadLine();


            var grantResult_revoke = await controllerRole.RevokePermission(roleName_revoke, objectType_revoke, objectName_revoke, privilege_revoke);
            if (grantResult_revoke)
            {
                Console.WriteLine($"Thu hoi quyen {privilege_revoke} cho {roleName_revoke} tren {objectName_revoke} thanh cong.");
            }
            else
            {
                Console.WriteLine("Thu hoi quyen that bai.");
            }

        }
    }
}
