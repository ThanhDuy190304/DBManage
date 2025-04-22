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
        public async Task<bool> CreateRole(string roleName)
        {
            try
            {
                return await _roleService.CreateRole(roleName);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi tạo role: " + ex.Message);
            }
        }
        public async Task ShowRolePermissions(string roleName)
        {
            try
            {
                var permissions = await _roleService.GetRolePermissions(roleName);

                if (permissions != null && permissions.Any())
                {
                    Console.WriteLine($"Quyền của role {roleName}:");
                    foreach (var permission in permissions)
                    {
                        Console.WriteLine($"- {permission.TABLE_NAME}: {permission.PRIVILEGE}");
                    }
                }
                else
                {
                    Console.WriteLine($"Role {roleName} không có quyền nào.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy quyền của role: " + ex.Message);
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
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi cấp quyền: " + ex.Message);
            }
        }
        public async Task<bool> RevokePermission(string roleName, string objectType, string objectName, string privilege)
        {
            try
            {
                return await _roleService.RevokePermission(roleName, objectType, objectName, privilege);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi thu hồi quyền: " + ex.Message);
            }
        }
    }
}
