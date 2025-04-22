using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.Tests
{
    public class TestUserService
    {
        public static async Task Main(string[] args)
        {
            // Tạo đối tượng UserService
            var userService = new UserService();

            // Gọi phương thức GetAll() để lấy danh sách người dùng và quyền của họ
            var users = await userService.GetAll();

            // Kiểm tra và in kết quả
            if (users != null && users.Any())
            {
                Console.WriteLine("Danh sách người dùng và quyền:");
                foreach (var user in users)
                {
                    // In ra thông tin người dùng một lần
                    Console.WriteLine($"Tên người dùng: {user.USERNAME}");
                    Console.WriteLine($"Ngày tạo tài khoản: {user.ACCOUNT_CREATED}");
                    Console.WriteLine($"Trạng thái tài khoản: {user.ACCOUNT_STATUS}");

                    // Nhóm quyền hệ thống và quyền đối tượng lại và in ra một lần
                    Console.WriteLine($"Quyền hệ thống: {user.SYSTEM_PRIVILEGES}");
                    Console.WriteLine($"Quyền đối tượng: {user.OBJECT_PRIVILEGES}");
                    Console.WriteLine($"ROLE: { user.ROLE}");
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu người dùng.");
            }

            // Đợi để người dùng có thể xem kết quả trước khi thoát
            Console.ReadLine();
        }

    }
}
