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
                throw; // Ném lại lỗi custom
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
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}
