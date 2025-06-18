using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
/*
SYNOPSIS: Module PolicyService cung cấp các dịch vụ quản lý chính sách bảo mật (VPD và Audit) trong Oracle Database.
FUNCTIONS:
- GetVPDPoliciesByObjectName(): Lấy danh sách chính sách VPD theo tên bảng.
- SetVPDPolicyState(): Bật/tắt chính sách VPD.
- GetAuditPolicies(): Lấy tất cả chính sách audit.
- DisableAuditPolicy(): Tắt chính sách audit.
- EnableAuditPolicy(): Bật chính sách audit.
GLOBAL VARIABLES:
- _dbService: Kế thừa từ BaseService để thao tác với database.
- _privilegeService: Service quản lý quyền (DBA_PrivilegeService).
*/
namespace SchoolManagerApp.src.Service
{
    internal class PolicyService : BaseService
    {
        private readonly DBA_PrivilegeService _privilegeService;

        public PolicyService()
        {
            _privilegeService = new DBA_PrivilegeService(_dbService);
        }

        public async Task<IEnumerable<DBA_POLICIES>> GetVPDPoliciesByObjectName(string objectName)
        {
            try
            {
                string query = @"SELECT * FROM DBA_POLICIES WHERE OBJECT_NAME = :ObjectName";
                return await _dbService.Connection.QueryAsync<DBA_POLICIES>(query, new { ObjectName = objectName });
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
        public async Task SetVPDPolicyState(string objectSchema, string objectName, string policyName, bool enable)
        {
            try
            {
                string plsql = @"
                BEGIN
                    DBMS_RLS.ENABLE_POLICY (
                        object_schema => :ObjectSchema,
                        object_name   => :ObjectName,
                        policy_name   => :PolicyName,
                        enable        => :Enable
                    );
                END;";
                await _dbService.Connection.ExecuteAsync(plsql, new
                {
                    ObjectSchema = objectSchema,
                    ObjectName = objectName,
                    PolicyName = policyName,
                    Enable = enable,
                });
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

        public async Task<IEnumerable<DBA_AUDIT_POLICIES>> GetAuditPolicies()
        {
            try
            {
                string query = @"
                SELECT p.object_schema, p.object_name, p.policy_owner, p.policy_name,
                       (
                           SELECT LISTAGG(c.policy_column, ',') WITHIN GROUP (ORDER BY c.policy_column)
                           FROM dba_audit_policy_columns c
                           WHERE c.policy_name = p.policy_name
                             AND c.object_schema = p.object_schema
                             AND c.object_name = p.object_name
                       ) AS policy_columns,
                       p.policy_text, p.policy_column_options, p.pf_schema, p.pf_package, p.pf_function,
                       p.enabled, p.sel, p.ins, p.upd, p.del, p.audit_trail, p.common, p.inherited
                FROM dba_audit_policies p";
                return await _dbService.Connection.QueryAsync<DBA_AUDIT_POLICIES>(query);
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

        public async Task DisableAuditPolicy(string objectSchema, string objectName, string policyName)
        {
            try
            {
                string plsql = @"
                BEGIN
                    DBMS_FGA.DISABLE_POLICY (
                        object_schema => :ObjectSchema,
                        object_name   => :ObjectName,
                        policy_name   => :PolicyName
                    );
                END;";
                await _dbService.Connection.ExecuteAsync(plsql, new
                {
                    ObjectSchema = objectSchema,
                    ObjectName = objectName,
                    PolicyName = policyName
                });
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

        public async Task EnableAuditPolicy(string objectSchema, string objectName, string policyName)
        {
            try
            {
                string plsql = @"
                BEGIN
                    DBMS_FGA.ENABLE_POLICY (
                        object_schema => :ObjectSchema,
                        object_name   => :ObjectName,
                        policy_name   => :PolicyName
                    );
                END;";
                await _dbService.Connection.ExecuteAsync(plsql, new
                {
                    ObjectSchema = objectSchema,
                    ObjectName = objectName,
                    PolicyName = policyName
                });
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
