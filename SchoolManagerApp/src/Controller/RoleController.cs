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

        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetByName(string roleName)
        {
            try
            {
                var role = await _roleService.GetByName(roleName);
                return role;
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

        public async Task<bool> UpdateRole(string roleName, string fieldName, string value)
        {
            try
            {
                return await _roleService.UpdateRole(roleName, fieldName, value);
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

        public async Task<bool> DeleteRole(string roleName)
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
        public async Task<bool> CreateRole(string roleName, string password)
        {
            try
            {
                return await _roleService.CreateRole(roleName, password);
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

        public async Task<bool> RevokeTablePrivilegeForRole(string roleName, string tableName, string privilege)
        {
            try
            {
                return await _roleService.RevokeTablePrivilegeForRole(roleName, tableName, privilege);
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
