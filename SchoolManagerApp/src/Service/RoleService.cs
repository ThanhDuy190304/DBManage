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
    internal class RoleService : BaseService<UserRolePrivs>
    {
        override
        public async Task<IEnumerable<UserRolePrivs>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM user_role_privs";
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
                throw new ServerError("Không thể khởi tạo kết nối: " + ex.Message);
            }

        }
        public async Task<bool> CreateRole(string roleName)
        {
            string query = $"CREATE ROLE {roleName}";
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
                throw new ServerError("Không thể tạo role: " + ex.Message);
            }
        }
        public async Task<bool> GrantPermission(string roleName, string objectType, string objectName, string privilege)
        {
            string query = "";

            if (objectType.ToUpper() == "TABLE" || objectType.ToUpper() == "VIEW")
            {
                
                query = $"GRANT {privilege} ON {objectName} TO {roleName}";
            }
            else
            {
                throw new ServerError("Object type must be either 'TABLE' or 'VIEW'");
            }

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
                throw new ServerError("Không thể cấp quyền: " + ex.Message);
            }
        }

    }
}
