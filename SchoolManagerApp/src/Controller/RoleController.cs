using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<UserRolePrivs>> GetAll()
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
        public async Task<bool> CreateRole(string roleName)
        {
            try
            {
                return await _roleService.CreateRole(roleName);
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
        public async Task<bool> GrantPermission(string roleName, string objectType, string objectName, string privilege)
        {
            try
            {
                return await _roleService.GrantPermission(roleName, objectType, objectName, privilege);
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
