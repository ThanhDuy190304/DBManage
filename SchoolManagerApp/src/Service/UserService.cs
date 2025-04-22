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
    internal class UserService : BaseService<UserRolePrivs>
    {
        override
        public async Task<IEnumerable<UserRolePrivs>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM DBA_USERS"; 

                return await _dbService.Connection.QueryAsync<UserRolePrivs>(query);
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
            string query = $"DROP USER {username} CASCADE"; 
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
        public async Task<bool> GrantRoleToUser(string roleName, string username, bool withAdminOption = false)
        {

            string grantRoleQuery = $"GRANT {roleName} TO {username}";


            if (withAdminOption)
            {
                grantRoleQuery += " WITH ADMIN OPTION";
            }

            try
            {
                // Thực thi câu lệnh GRANT
                await _dbService.Connection.ExecuteAsync(grantRoleQuery);
                return true; 
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); 
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể gán role cho user: " + ex.Message); 
            }
        }

        public async Task<bool> GrantSystemPrivilegesToUser(string username, List<string> systemPrivileges, bool withAdminOption = false)
        {
            if (systemPrivileges == null || systemPrivileges.Count == 0)
                throw new ArgumentException("Danh sách quyền hệ thống không được rỗng.", nameof(systemPrivileges));


            string privilegesString = string.Join(", ", systemPrivileges);


            string adminOptionClause = withAdminOption ? " WITH ADMIN OPTION" : "";


            string grantQuery = $"GRANT {privilegesString} TO {username}{adminOptionClause}";

            try
            {
                await _dbService.Connection.ExecuteAsync(grantQuery);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Không thể cấp quyền hệ thống: {ex.Message}");
            }
        }
        public async Task<List<string>> GetUserPrivileges(string username)
        {
            try
            {

                string sysPrivilegesQuery = $@"
        SELECT PRIVILEGE || CASE WHEN ADMIN_OPTION = 'YES' THEN ' WITH ADMIN OPTION' ELSE '' END
        FROM DBA_SYS_PRIVS
        WHERE GRANTEE = '{username}'";


                string tabPrivilegesQuery = $@"
        SELECT PRIVILEGE || ' ON ' || TABLE_NAME
        FROM DBA_TAB_PRIVS
        WHERE GRANTEE = '{username}'";


                var sysPrivileges = await _dbService.Connection.QueryAsync<string>(sysPrivilegesQuery);
                var tabPrivileges = await _dbService.Connection.QueryAsync<string>(tabPrivilegesQuery);

                var allPrivileges = sysPrivileges.Concat(tabPrivileges).ToList();

                return allPrivileges;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); 
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy quyền của user: " + ex.Message); 
            }
        }
        public async Task<bool> RevokeRoleFromUser(string roleName, string username)
        {
            string revokeRoleQuery = $"REVOKE {roleName} FROM {username}";
            try
            {
                await _dbService.Connection.ExecuteAsync(revokeRoleQuery);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); 
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể thu hồi role từ user: " + ex.Message);
            }
        }
        public async Task<bool> RevokePrivilegesFromUser(List<string> privileges, string username, string privilegeType)
        {
            string revokeQuery = string.Empty;


            if (privilegeType == "SYSTEM")
            {

                foreach (var privilege in privileges)
                {
                    revokeQuery = $"REVOKE {privilege} FROM {username}";
                    try
                    {
                        await _dbService.Connection.ExecuteAsync(revokeQuery);
                    }
                    catch (OracleException ex)
                    {
                        throw ErrorMapper.MapOracleException(ex);
                    }
                    catch (Exception ex)
                    {
                        throw new ServerError("Không thể thu hồi quyền hệ thống từ user: " + ex.Message); 
                    }
                }
            }
            else if (privilegeType == "OBJECT")
            {
                foreach (var privilege in privileges)
                {
                    revokeQuery = $"REVOKE {privilege} ON {username}.* FROM {username}";
                    try
                    {
                        await _dbService.Connection.ExecuteAsync(revokeQuery);
                    }
                    catch (OracleException ex)
                    {
                        throw ErrorMapper.MapOracleException(ex); 
                    }
                    catch (Exception ex)
                    {
                        throw new ServerError("Không thể thu hồi quyền đối tượng từ user: " + ex.Message); 
                    }
                }
            }
            else
            {
                throw new ArgumentException("Loại quyền không hợp lệ.");
            }

            return true; 
        }
    }


}

