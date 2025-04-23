using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    internal class UserService : BaseService<UserPrivs>
    {
        private DBA_PrivilegeService _privilegeService;
        public UserService()
        {
            _privilegeService = new DBA_PrivilegeService(_dbService);
        }
        override
        public async Task<IEnumerable<UserPrivs>> GetAll()
        {
            try
            {
                string query = @"
            SELECT 
            u.USERNAME, 
            u.ACCOUNT_STATUS, 
            u.CREATED AS ACCOUNT_CREATED,
            sys_privs.PRIVILEGE AS SYSTEM_PRIVILEGES,
            tab_privs.PRIVILEGE AS OBJECT_PRIVILEGES,
            r.GRANTED_ROLE AS ROLES
        FROM DBA_USERS u
        LEFT JOIN DBA_SYS_PRIVS sys_privs ON u.USERNAME = sys_privs.GRANTEE
        LEFT JOIN DBA_TAB_PRIVS tab_privs ON u.USERNAME = tab_privs.GRANTEE
        LEFT JOIN DBA_ROLE_PRIVS r ON u.USERNAME = r.GRANTEE
        WHERE ORACLE_MAINTAINED = 'N'
        ORDER BY u.USERNAME";

                var userPrivsList = await _dbService.Connection.QueryAsync<UserPrivs>(query);

                return userPrivsList;
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
        public async Task<UserPrivs> GetByUsername(string username)
        {
            try
            {
                string query = @"
        SELECT 
            u.USERNAME, 
            u.ACCOUNT_STATUS, 
            u.CREATED AS ACCOUNT_CREATED,
            sys_privs.PRIVILEGE AS SYSTEM_PRIVILEGES,
            tab_privs.PRIVILEGE AS OBJECT_PRIVILEGES,
            r.GRANTED_ROLE AS ROLES
        FROM DBA_USERS u
        LEFT JOIN DBA_SYS_PRIVS sys_privs ON u.USERNAME = sys_privs.GRANTEE
        LEFT JOIN DBA_TAB_PRIVS tab_privs ON u.USERNAME = tab_privs.GRANTEE
        LEFT JOIN DBA_ROLE_PRIVS r ON u.USERNAME = r.GRANTEE
        WHERE u.USERNAME = :username
        ORDER BY u.USERNAME";

                var userPrivs = await _dbService.Connection.QueryFirstOrDefaultAsync<UserPrivs>(query, new { username });

                return userPrivs;
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

        override
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
    }


}

