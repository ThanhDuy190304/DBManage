using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp
{
    public class RoleController
    {
        private readonly RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        public async Task<List<Role>> GetAllRolesAsync()
        {
            var roles = await _roleService.GetAllAsync();
            return roles.ToList();
        }

        public async Task<Role> AddRoleAsync(string roleName)
        {
            var newRole = new Role { Name = roleName };
            return await _roleService.CreateAsync(newRole);
        }

        public async Task<bool> DeleteRoleAsync(int roleId)
        {
            return await _roleService.DeleteAsync(roleId);
        }
    }
}
