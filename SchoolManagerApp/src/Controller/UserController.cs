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

        public async Task<IEnumerable<DBA_USERS>> GetAll()
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

        public async Task<DBA_USERS> GetByUsername(string username)
        {
            try
            {
                var user = await _userService.GetByUsername(username);

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

        public async Task<IEnumerable<DBA_ROLE_PRIVS>> GetRoleByName(string grantee)
        {

            try
            {
                var roles = await _userService.GetRoleByName(grantee);
                return roles;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy vai trò: " + ex.Message);
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

        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetPrivilegeOnTableByName(string userName)
        {
            try
            {
                var privileges = await _userService.GetPrivilegeOnTableByName(userName);
                return privileges;
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

        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string userName)
        {
            try
            {
                var privileges = await _userService.GetPrivilegeOnColByName(userName);
                return privileges;
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

        public async Task<bool> GrantPermission(
            string userName,
            string objectType,
            string objectName,
            string privilege,
            string[] columns = null,
            bool withGrantOption = false)
        {
            try
            {
                return await _userService.GrantPermission(userName, objectType, objectName, privilege, columns, withGrantOption);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cấp quyền: " + ex.Message);
            }
        }

        public async Task<bool> RevokeTablePrivilege(string userName, string objectName, string privilege)
        {
            try
            {
                return await _userService.RevokeTablePrivilege(userName, objectName, privilege);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cấp quyền: " + ex.Message);
            }
        }

        public async Task<bool> RevokeRole(string userName, string roleName)
        {
            try
            {
                var result = await _userService.RevokeRole(userName, roleName);
                return result;
                         }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }

        public async Task<bool> GrantRole(string userName, string roleName, bool withGrantOption)
        {
            try
            {
                var result = await _userService.GrantRole(userName, roleName, withGrantOption);
                return result;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }
        
        public async Task <bool> LockAccount (string userName)
        {
            try
            {
                var result = await _userService.LockAccount(userName);
                return result;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }

        public async Task<bool> UnLockAccount(string userName)
        {
            try
            {
                var result = await _userService.UnLockAccount(userName);
                return result;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }
    
    }
}
