using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Test
{
    public class TestRoleController
    {
        private readonly RoleController _roleController;
        public TestRoleController()
        {
            _roleController = new RoleController();
        }

        public async Task Test_UpdatePassword()
        {
            // Test cập nhật mật khẩu cho role
            string roleName = "GIAOVIEN";
            string newPassword = "newPassword123";
            try
            {
                bool result = await _roleController.UpdatePassword(roleName, newPassword);

                if (result)
                {
                    Console.WriteLine("Cập nhật mật khẩu thành công!");
                }
                else
                {
                    Console.WriteLine("Cập nhật mật khẩu thất bại!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật mật khẩu: {ex.Message}");
            }
        }
        public async Task Test_RemoveAuthentication()
        {
            string roleName = "GIAOVIEN";
            try
            {
                bool result = await _roleController.RemoveAuthentication(roleName);
                Console.WriteLine("Xóa xác thực thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa xác thực: {ex.Message}");
            }
        }
        public async Task Test_RevokeTablePrivilege()
        {
            // Test revoke quyền cho role
            string roleName = "GIAOVIEN";
            string objectName = "MOMON";
            string privilege = "UPDATE";

            try
            {
                bool result = await _roleController.RevokeTablePrivilege(roleName, objectName, privilege);

                if (result)
                {
                    Console.WriteLine("Revoke quyền thành công!");
                }
                else
                {
                    Console.WriteLine("Revoke quyền thất bại!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi revoke quyền: {ex.Message}");
            }
        }

        public async Task Test_GrantPermission()
        {
            // Test cấp quyền cho role
            string roleName = "GIAOVIEN";
            string objectType = "TABLE";
            string objectName = "MOMON";
            string privilege = "UPDATE";
            string[] columns = { };
            bool withGrantOption = false;

            try
            {
                bool result = await _roleController.GrantPermission(roleName, objectType, objectName, privilege, columns, withGrantOption);

                if (result)
                {
                    Console.WriteLine("Cấp quyền thành công!");
                }
                else
                {
                    Console.WriteLine("Cấp quyền thất bại!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cấp quyền: {ex.Message}");
            }
        }

        public static async Task Main(string[] args)
        {
            var testRoleController = new TestRoleController();
            try
            {
                await testRoleController.Test_GrantPermission();
                Console.WriteLine("Test hoàn tất! Vui lòng kiểm tra cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thực hiện test: {ex.Message}");
            }
        }

    }
}
