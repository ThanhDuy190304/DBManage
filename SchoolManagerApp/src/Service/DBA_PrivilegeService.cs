using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    public class DBA_PrivilegeService
    {
        private readonly DatabaseService _dbService;

        public DBA_PrivilegeService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<DBA_TAB_PRIVS>> GetPrivilegeOnTableByName(string grantee)
        {
            try
            {
                string query = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{grantee}'";
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

        public async Task<IEnumerable<DBA_COL_PRIVS>> GetPrivilegeOnColByName(string grantee)
        {
            try
            {
                string query = $"SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '{grantee}'";
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

        public async Task<bool> GrantPermission(
           string name,
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
                    query = $"GRANT {privilegeClause} ON {formattedObject} TO {name}";
                }
                else if ((objectType.ToUpper() == "PROCEDURE" || objectType.ToUpper() == "FUNCTION")
                         && privilege.ToUpper() == "EXECUTE")
                {
                    query = $"GRANT EXECUTE ON {formattedObject} TO {name}";
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

        public async Task<bool> RevokeTablePrivilege(string name, string objectName, string privilege)
        {
            try
            {
                string query = $"REVOKE {privilege} ON {objectName} FROM {name}";
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
