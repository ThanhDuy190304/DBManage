using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp
{
    public class RoleController
    {
        private readonly RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        public async Task<IEnumerable<DBA_ROLES>> GetAll()
        {
            try
            {
                var roles = await _roleService.GetAll();
                return roles;
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

        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetPrivilegeOnTableByName(string roleName)
        {
            try
            {
                var privileges = await _roleService.GetPrivilegeOnTableByName(roleName);
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

        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string roleName)
        {
            try
            {
                var privileges = await _roleService.GetPrivilegeOnColByName(roleName);
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


        public async Task<bool> UpdatePassword(string roleName, string password)
        {
            try
            {
                return await _roleService.UpdatePassword(roleName, password);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cập nhật mật khẩu: " + ex.Message);
            }
        }

        public async Task<bool> RemoveAuthentication(string roleName)
        {
            try
            {
                return await _roleService.RemoveAuthentication(roleName);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cập nhật mật khẩu: " + ex.Message);
            }
        }

        public async Task<bool> Delete(string roleName)
        {
            try
            {
                return await _roleService.Delete(roleName);

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
        public async Task<bool> Create(string roleName, string password)
        {
            try
            {
                return await _roleService.Create(roleName, password);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi tạo role: " + ex.Message);
            }
        }
        public async Task<bool> GrantPermission(
            string roleName,
            string objectType,
            string objectName,
            string privilege,
            string[] columns = null,
            bool withGrantOption = false)
        {
            try
            {
                return await _roleService.GrantPermission(roleName, objectType, objectName, privilege, columns, withGrantOption);
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

        public async Task<bool> RevokeTablePrivilege(string roleName, string tableName, string privilege) 
        {
            try
            {
                return await _roleService.RevokeTablePrivilege(roleName, tableName, privilege);
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
        
    }
}
