using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service.Interfaces;

namespace SchoolManagerApp.src.Controllers
{
    public class UsersController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        public async Task<User> Create(User user)
        {
            // Kiểm tra đầu vào cơ bản (có thể thêm nhiều kiểm tra hơn)
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (string.IsNullOrWhiteSpace(user.Username) )
            {
                // dùng IsNullOrWhiteSpace để kiểm tra cả khoảng trắng
                throw new ArgumentException("Username cannot be empty or whitespace.");
            }
            // Có thể thêm kiểm tra định dạng độ dài Username,...

            return await _userService.CreateAsync(user);
        }

        public async Task<bool> Delete(int id)
        {
            // Có thể thêm kiểm tra id > 0 nếu cần
            return await _userService.DeleteAsync(id);
        }
    }
}