using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;
/*
SYNOPSIS: Module RoleService cung cấp các dịch vụ quản lý role và quyền trong Oracle Database.
FUNCTIONS:
- GetAll(): Lấy danh sách các role không phải của hệ thống.
- GetPrivilegeOnTableByName(): Lấy quyền trên bảng của role.
- GetPrivilegeOnColByName(): Lấy quyền trên cột của role.
- UpdatePassword(): Cập nhật mật khẩu cho role.
- RemoveAuthentication(): Xóa xác thực của role.
- Delete(): Xóa role.
- Create(): Tạo role mới.
- GrantPermission(): Cấp quyền cho role.
- RevokeTablePrivilege(): Thu hồi quyền trên bảng của role.
GLOBAL VARIABLES:
- _dbService: Kế thừa từ BaseService để thao tác với database.
- _privilegeService: Service quản lý quyền (DBA_PrivilegeService).
*/
namespace SchoolManagerApp.src.Service
{
    internal class RoleService : BaseService
    {
        private readonly DBA_PrivilegeService _privilegeService;
        public RoleService()
        {
            _privilegeService = new DBA_PrivilegeService(_dbService);
        }
        public async Task<IEnumerable<DBA_ROLES>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM DBA_ROLES WHERE ORACLE_MAINTAINED = 'N'";
                return await _dbService.Connection.QueryAsync<DBA_ROLES>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }

        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetPrivilegeOnTableByName(string roleName)
        {
            return await _privilegeService.GetPrivilegeOnTableByName(roleName);
        }
        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string roleName)
        {

            return await _privilegeService.GetPrivilegeOnColByName(roleName);
        }


        public async Task<bool> UpdatePassword(string roleName, string newPassword)
        {
            try
            {
                if (string.IsNullOrEmpty(newPassword))
                {
                    throw new InvalidDataError("Mật khẩu mới không được trống.");
                }
                string query = $"ALTER ROLE {roleName} IDENTIFIED BY  {newPassword}";
                await _dbService.Connection.ExecuteAsync(query);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }
        }

        public async Task<bool> RemoveAuthentication(string roleName)
        {
            try
            {
                string query = $"ALTER ROLE {roleName} NOT IDENTIFIED";
                await _dbService.Connection.ExecuteAsync(query);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi khi bỏ xác thực cho role: " + ex.Message);
            }
        }

        
        public async Task<bool> Delete(string name)
        {
            string query = $"DROP ROLE {name}";
            try
            {
                await _dbService.Connection.ExecuteAsync(query);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
            }

        }
        public async Task<bool> Create(string roleName, string password)
        {
            string query = string.IsNullOrWhiteSpace(password)
                  ? $"CREATE ROLE {roleName}"
                  : $"CREATE ROLE {roleName} IDENTIFIED BY \"{password}\"";
            try
            {
                await _dbService.Connection.ExecuteAsync(query);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError(ex.Message);
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
            return await _privilegeService.GrantPermission(roleName, objectType, objectName, privilege, columns, withGrantOption);

        }

        public async Task<bool> RevokeTablePrivilege(string roleName, string objectName, string privilege)
        {
            return await _privilegeService.RevokeTablePrivilege(roleName, objectName, privilege);
        }
        
    }
}
