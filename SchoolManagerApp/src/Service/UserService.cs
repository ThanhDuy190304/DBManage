﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;
/*
SYNOPSIS: Module UserService cung cấp các dịch vụ quản lý user trong Oracle Database.
FUNCTIONS:
- GetAll(): Lấy danh sách tất cả user không phải của hệ thống.
- GetByUsername(): Lấy thông tin user theo username.
- GetRoleByName(): Lấy danh sách role của user.
- Delete(): Xóa user.
- CreateUser(): Tạo user mới.
- UpdateUserPassword(): Cập nhật mật khẩu user.
- GetPrivilegeOnTableByName(): Lấy quyền trên bảng của user.
- GetPrivilegeOnColByName(): Lấy quyền trên cột của user.
- GrantPermission(): Cấp quyền cho user.
- RevokeTablePrivilege(): Thu hồi quyền trên bảng của user.
- RevokeRole(): Thu hồi role từ user.
- GrantRole(): Cấp role cho user.
- LockAccount(): Khóa tài khoản user.
- UnLockAccount(): Mở khóa tài khoản user.
GLOBAL VARIABLES:
- _dbService: Kế thừa từ BaseService để thao tác với database.
- _privilegeService: Service quản lý quyền (DBA_PrivilegeService).
*/
namespace SchoolManagerApp.src.Service
{
    internal class UserService : BaseService
    {
        private DBA_PrivilegeService _privilegeService;
        public UserService()
        {
            _privilegeService = new DBA_PrivilegeService(_dbService);
        }
         public async Task<IEnumerable<DBA_USERS>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM DBA_USERS WHERE ORACLE_MAINTAINED = 'N'";
                return await _dbService.Connection.QueryAsync<DBA_USERS>(query);
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
        public async Task<DBA_USERS> GetByUsername(string username)
        {
            try
            {
                string query = "SELECT * FROM DBA_USERS WHERE ORACLE_MAINTAINED = 'N' AND USERNAME = :username";

                var user = await _dbService.Connection.QueryFirstOrDefaultAsync<DBA_USERS>(query, new { username });

                return user;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể khởi tạo kết nối: " + ex.Message);
            }
        }

        public async Task<IEnumerable<DBA_ROLE_PRIVS>> GetRoleByName(string grantee)
        {
            try
            {
                string query = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{grantee}'";
                return await _dbService.Connection.QueryAsync<DBA_ROLE_PRIVS>(query);
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

        public async Task<bool> Delete(string username)
        {
            string query = $"DROP USER {username}";
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
                throw new ServerError("Không thể xóa user: " + ex.Message);
            }
        }
        public async Task<bool> CreateUser(string username, string password)
        {
            string createUserQuery = $"CREATE USER {username} IDENTIFIED BY {password}";
            try
            {
                await _dbService.Connection.ExecuteAsync(createUserQuery);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể tạo user: " + ex.Message);
            }
        }

        public async Task<bool> UpdateUserPassword(string username, string newPassword)
        {
            string query = $"ALTER USER {username} IDENTIFIED BY {newPassword}";
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
                throw new ServerError("Không thể cập nhật mật khẩu: " + ex.Message);
            }
        }
        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetPrivilegeOnTableByName(string userName)
        {
            return await _privilegeService.GetPrivilegeOnTableByName(userName);
        }
        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string userName)
        {
            return await _privilegeService.GetPrivilegeOnColByName(userName);
        }

        public async Task<bool> GrantPermission(
           string userName,
           string objectType,
           string objectName,
           string privilege,
           string[] columns = null,
           bool withGrantOption = false)
        {
            return await _privilegeService.GrantPermission(userName, objectType, objectName, privilege, columns, withGrantOption);

        }

        public async Task<bool> RevokeTablePrivilege(string userName, string objectName, string privilege)
        {
            return await _privilegeService.RevokeTablePrivilege(userName, objectName, privilege);
        }

        public async Task<bool> RevokeRole(string userName, string roleName)
        {
            try
            {
                var query = $"REVOKE {roleName} FROM {userName}";
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
        public async Task<bool> GrantRole(string userName, string roleName, bool withGrantOption = false)
        {
            try
            {
                var grantOption = withGrantOption ? "WITH ADMIN OPTION" : string.Empty;
                var query = $"GRANT {roleName} TO {userName} {grantOption}";
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

        public async Task<bool> LockAccount(string userName)
        {
            try
            {
                var query = $"ALTER USER {userName} ACCOUNT LOCK";
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

        public async Task<bool> UnLockAccount(string userName)
        {
            try
            {
                var query = $"ALTER USER {userName} ACCOUNT UNLOCK";
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

    }


}

