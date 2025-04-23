using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    internal class RoleService : BaseService<DBA_ROLES>
    {
        override
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
            try
            {
                string query = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{roleName}'";
                return await _dbService.Connection.QueryAsync<DBA_TAB_PRIVS>(query);
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
        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string roleName)
        {
            try
            {
                string query = $"SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '{roleName}'";
                return await _dbService.Connection.QueryAsync<DBA_COL_PRIVS>(query);
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

        override
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
            try
            {
                string privilegeClause = privilege;

                // Chỉ SELECT & UPDATE mới hỗ trợ cấp theo cột
                if ((privilege.ToUpper() == "SELECT" || privilege.ToUpper() == "UPDATE")
                    && columns != null && columns.Length > 0)
                {
                    string columnList = string.Join(", ", columns);
                    privilegeClause = $"{privilege} ({columnList})";
                }
                string formattedObject = objectName.ToUpper();
                string query = "";

                if (objectType.ToUpper() == "TABLE" || objectType.ToUpper() == "VIEW")
                {
                    query = $"GRANT {privilegeClause} ON {formattedObject} TO {roleName}";
                }
                else if ((objectType.ToUpper() == "PROCEDURE" || objectType.ToUpper() == "FUNCTION")
                         && privilege.ToUpper() == "EXECUTE")
                {
                    query = $"GRANT EXECUTE ON {formattedObject} TO {roleName}";
                }
                if (withGrantOption)
                {
                    query += " WITH GRANT OPTION";
                }

                await _dbService.Connection.ExecuteAsync(query);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể cấp quyền: " + ex.Message);
            }
        }

        public async Task<bool> RevokeTablePrivilege(string roleName, string tableName, string privilege)
        {          
            try
            {
                string query = $"REVOKE {privilege} ON {tableName} FROM {roleName}";
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
