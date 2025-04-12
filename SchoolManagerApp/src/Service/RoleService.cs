using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using static SchoolManagerApp.src.Service.BaseService;

namespace SchoolManagerApp.src.Service
{
    public class RoleService : IBaseService<Role>
    {
        private readonly List<Role> _roleStore;

        public RoleService()
        {
        
            _roleStore = new List<Role>
            {
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" },
                new Role { Id = 3, Name = "Manager" },
                new Role { Id = 4, Name = "Editor" }
            };
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await Task.FromResult(_roleStore);
        }

        public async Task<Role> CreateAsync(Role entity)
        {
            _roleStore.Add(entity);  
            return await Task.FromResult(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var role = _roleStore.FirstOrDefault(r => r.Id == id);
            if (role != null)
            {
                _roleStore.Remove(role);  
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
