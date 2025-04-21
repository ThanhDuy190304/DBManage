using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class UserController
    {
        private readonly UserService _userService;

        // Khởi tạo đối tượng UserService
        public UserController()
        {
            _userService = new UserService();
        }

        // Lấy tất cả người dùng
        public async Task<IEnumerable<UserRolePrivs>> GetAll()
        {
            try
            {
                // Gọi phương thức GetAll trong UserService để lấy danh sách người dùng
                var users = await _userService.GetAll();
                return users;
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Tạo người dùng mới
        public async Task<bool> CreateUser(string username, string password)
        {
            try
            {
                // Gọi phương thức CreateUser trong UserService để tạo người dùng mới
                return await _userService.CreateUser(username, password);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Cập nhật mật khẩu người dùng
        public async Task<bool> UpdateUserPassword(string username, string newPassword)
        {
            try
            {
                // Gọi phương thức UpdateUserPassword trong UserService để cập nhật mật khẩu người dùng
                return await _userService.UpdateUserPassword(username, newPassword);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Xóa người dùng
        public async Task<bool> Delete(string username)
        {
            try
            {
                // Gọi phương thức Delete trong UserService để xóa người dùng
                return await _userService.Delete(username);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
        public async Task<bool> GrantRoleToUser(string roleName, string username)
        {
            try
            {
                // Gọi phương thức GrantRoleToUser trong UserService để gán role cho user
                return await _userService.GrantRoleToUser(roleName, username);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
        public async Task<bool> GrantSystemPrivileges(string username, string privilegesInput, bool withAdminOption)
        {
            try
            {
                // Chuyển chuỗi quyền thành danh sách, loại bỏ dấu cách và chuẩn hóa viết hoa
                var privileges = privilegesInput
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim().ToUpper())
                    .ToList();

                // Gọi method từ UserService để thực hiện cấp quyền hệ thống
                return await _userService.GrantSystemPrivilegesToUser(username, privileges, withAdminOption);
            }
            catch (BaseError)
            {
                throw; // Ném lại nếu là lỗi custom của bạn (kế thừa BaseError)
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cấp quyền hệ thống: " + ex.Message);
            }
        }
        public async Task<bool> RevokeRole(string roleName, string username)
        {
            try
            {
                // Gọi phương thức RevokeRoleFromUser trong UserService để thu hồi quyền role từ người dùng
                return await _userService.RevokeRoleFromUser(roleName, username);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
        public async Task<List<string>> GetUserPrivileges(string username)
        {
            try
            {
                // Gọi service để lấy cả quyền hệ thống và quyền đối tượng
                var privileges = await _userService.GetUserPrivileges(username);
                return privileges;
            }
            catch (Exception ex)
            {
                return new List<string>(); // Trả về danh sách trống nếu có lỗi
            }
        }
        public async Task<bool> RevokePrivileges(string privilegeType, string username, List<string> privileges)
        {
            try
            {
                // Gọi phương thức RevokePrivilegesFromUser trong UserService để thu hồi quyền từ người dùng
                return await _userService.RevokePrivilegesFromUser(privileges, username, privilegeType);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

    }
}
