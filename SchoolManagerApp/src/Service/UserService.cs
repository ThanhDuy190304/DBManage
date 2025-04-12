using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service.Interfaces;

namespace SchoolManagerApp.src.Service
{
    public class UserService : IUserService
    {
        // Danh sách users này là chi tiết triển khai, nên giữ private
        private List<User> _users;

        // Constructor của public class nên là public
        public UserService()
        {
            // Sử dụng MockUsers để khởi tạo dữ liệu
            _users = MockUser.GetMockUsers().ToList();
        }

        // Các phương thức triển khai interface phải là public
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            await Task.Delay(100); // Giả lập async
            // Trả về bản sao để tránh sửa đổi list gốc từ bên ngoài (tuỳ yêu cầu)
            // return _users.ToList();
            return _users; // Hoặc trả về tham chiếu trực tiếp nếu hiệu năng là ưu tiên
        }

        public async Task<User> CreateAsync(User user)
        {
            await Task.Delay(100); // Giả lập async

            // Thêm kiểm tra null cho user đầu vào
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Kiểm tra trùng lặp Username trước khi thêm (QUAN TRỌNG)
            if (_users.Any(u => u.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Username '{user.Username}' already exists.");
            }

            // Gán ID mới an toàn hơn khi list có thể rỗng
            user.Id = (_users.Any() ? _users.Max(u => u.Id) : 0) + 1;
            // Nên hash password ở đây trước khi lưu nếu có trường PasswordHash

            _users.Add(user);
            return user; // Trả về user đã được thêm với ID
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(100); // Giả lập async
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return false; // Không tìm thấy user để xóa
            }

            _users.Remove(user);
            return true; // Xóa thành công

        }
    }
}