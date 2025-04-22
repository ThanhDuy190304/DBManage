using System;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.Tests
{
    class TestUserController
    {
        public static async Task Main(string[] args)
        {
            var userController = new UserController();

            // Test: Tạo người dùng mới
            Console.WriteLine("Nhap ten user de tao moi: ");
            string username = Console.ReadLine();
            Console.WriteLine("Nhap mat khau cho user: ");
            string password = Console.ReadLine();

            bool createSuccess = await userController.CreateUser(username, password);
            Console.WriteLine(createSuccess ? $"Da tao user {username} thanh cong!" : "Khong the tao user!");

            // Test: Cập nhật mật khẩu người dùng
            Console.WriteLine("Nhap mat khau moi cho user: ");
            string newPassword = Console.ReadLine();
            bool updatePasswordSuccess = await userController.UpdateUserPassword(username, newPassword);
            Console.WriteLine(updatePasswordSuccess ? $"Da cap nhat mat khau cho {username} thanh cong!" : "Khong the cap nhat mat khau!");

            // Test: Cấp quyền role cho user
            Console.WriteLine("Nhap ten role de cap quyen cho user: ");
            string roleName = Console.ReadLine();
            Console.WriteLine("Co muon cap quyen voi ADMIN OPTION khong? (co/khong): ");
            string withOption = Console.ReadLine();
            bool withAdminOption = withOption.ToLower() == "co";

            bool grantRoleSuccess = await userController.GrantRoleToUser(roleName, username);
            Console.WriteLine(grantRoleSuccess ? $"Da cap role {roleName} cho {username} thanh cong!" : "Khong the cap role!");

            // Test: Cấp quyền hệ thống cho user
            Console.WriteLine("Nhap cac quyen he thong (cach nhau bang dau phay, vi du: CREATE SESSION, CREATE TABLE): ");
            string privilegesInput = Console.ReadLine();

            // Sửa lỗi: kiểm tra và chuyển đổi chuỗi quyền thành danh sách
            var privileges = privilegesInput.Split(',').Select(p => p.Trim()).ToList();

            // Sửa lỗi: chuyển đổi danh sách thành chuỗi
            string privilegesString = string.Join(", ", privileges);

            Console.WriteLine("Co muon cap quyen voi ADMIN OPTION khong? (co/khong): ");
            withOption = Console.ReadLine();
            withAdminOption = withOption.ToLower() == "co";
            bool grantPrivilegesSuccess = await userController.GrantSystemPrivileges(username, privilegesString, withAdminOption);
            Console.WriteLine(grantPrivilegesSuccess ? $"Da cap quyen he thong cho {username} thanh cong!" : "Khong the cap quyen he thong!");

            // Test: Thu hồi quyền từ user
            Console.WriteLine("Nhap loai quyen can thu hoi (SYSTEM hoac OBJECT): ");
            string privilegeType = Console.ReadLine();
            Console.WriteLine("Nhap cac quyen can thu hoi (cach nhau bang dau phay): ");
            string revokePrivilegesInput = Console.ReadLine();
            var revokePrivileges = revokePrivilegesInput.Split(',').Select(p => p.Trim()).ToList();
            bool revokeSuccess = await userController.RevokePrivileges(privilegeType, username, revokePrivileges);
            Console.WriteLine(revokeSuccess ? $"Da thu hoi quyen {string.Join(", ", revokePrivileges)} tu {username} thanh cong!" : "Khong the thu hoi quyen!");

            // Kiểm tra lại quyền của user sau khi thu hồi
            Console.WriteLine($"\nDanh sach quyen hien tai cua user '{username}' sau khi thu hoi:");

            var updatedPrivileges = await userController.GetUserPrivileges(username);

            if (updatedPrivileges.Any())
            {
                foreach (var privilege in updatedPrivileges)
                {
                    Console.WriteLine($"- {privilege}");
                }
            }
            else
            {
                Console.WriteLine("User khong con quyen nao.");
            }

            Console.WriteLine("Ban co muon xoa user nay khong? (co/khong): ");
            string deleteUserResponse = Console.ReadLine();
            if (deleteUserResponse.ToLower() == "co")
            {
                bool deleteSuccess = await userController.Delete(username);
                Console.WriteLine(deleteSuccess ? $"Da xoa user {username} thanh cong!" : "Khong the xoa user!");
            }

            Console.WriteLine("Test ket thuc.");
        }
    }
}
