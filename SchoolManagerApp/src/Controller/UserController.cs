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

        public UserController()
        {
            _userService = new UserService();
        }

        public async Task<IEnumerable<UserPrivs>> GetAll()
        {
            try
            {

                var users = await _userService.GetAll();
                return users;
            }
            catch (BaseError)
            {
                throw; 
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<UserPrivs> GetByUsername(string username)
        {
            try
            {
                var user = await _userService.GetByUsername(username);

                // Kiểm tra nếu không tìm thấy người dùng
                if (user == null)
                {
                    throw new NotFoundError("Người dùng không tồn tại.");
                }

                // Trả về dữ liệu người dùng nếu tìm thấy
                return user;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy dữ liệu người dùng: " + ex.Message);
            }
        }


        public async Task<bool> CreateUser(string username, string password)
        {
            try
            {

                return await _userService.CreateUser(username, password);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }


        public async Task<bool> UpdateUserPassword(string username, string newPassword)
        {
            try
            {

                return await _userService.UpdateUserPassword(username, newPassword);
            }
            catch (BaseError)
            {
                throw; 
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }


        public async Task<bool> Delete(string username)
        {
            try
            {
                
                return await _userService.Delete(username);
            }
            catch (BaseError)
            {
                throw;
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
 
                return await _userService.GrantRoleToUser(roleName, username);
            }
            catch (BaseError)
            {
                throw;
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
                
                var privileges = privilegesInput
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim().ToUpper())
                    .ToList();

                
                return await _userService.GrantSystemPrivilegesToUser(username, privileges, withAdminOption);
            }
            catch (BaseError)
            {
                throw;
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
    
                return await _userService.RevokeRoleFromUser(roleName, username);
            }
            catch (BaseError)
            {
                throw; 
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
   
                var privileges = await _userService.GetUserPrivileges(username);
                return privileges;
            }
            catch (Exception ex)
            {
                return new List<string>(); 
            }
        }
        public async Task<bool> RevokePrivileges(string privilegeType, string username, List<string> privileges)
        {
            try
            {

                return await _userService.RevokePrivilegesFromUser(privileges, username, privilegeType);
            }
            catch (BaseError)
            {
                throw; 
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

    }
}
