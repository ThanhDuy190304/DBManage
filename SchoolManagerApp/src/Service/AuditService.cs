﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;

/*
SYNOPSIS: Module AuditService cung cấp các dịch vụ truy vấn dữ liệu audit từ Oracle Database.
FUNCTIONS:
- GetStandardAuditDataAsync(): Lấy dữ liệu audit tiêu chuẩn từ bảng DBA_AUDIT_TRAIL.
- GetStandardAuditSessions(): Truy vấn thông tin audit phiên từ bảng DBA_AUDIT_SESSION.
- GetFGAAuditDataAsync(): Lấy dữ liệu Fine-Grained Audit với tùy chọn lọc theo policy name.
GLOBAL VARIABLES:
- Kế thừa _dbService từ BaseService để thao tác với database.
- Sử dụng ErrorMapper để xử lý lỗi Oracle.
*/
namespace SchoolManagerApp.src.Service
{
    internal class AuditService : BaseService
    {
        public async Task<IEnumerable<StandardAuditRecord>> GetStandardAuditDataAsync()
        {
            try
            {
                string query = @"
                SELECT 
                    OS_USERNAME,
                    USERNAME,
                    USERHOST,
                    TIMESTAMP,
                    OWNER AS ObjectOwner,  -- Alias để map vào ObjectOwner
                    OBJ_NAME AS ObjectName,
                    ACTION_NAME,
                    SQL_TEXT
                FROM DBA_AUDIT_TRAIL
                ORDER BY TIMESTAMP DESC";

                return await _dbService.Connection.QueryAsync<StandardAuditRecord>(query);
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

        public async Task<IEnumerable<DBA_AUDIT_SESSION>> GetStandardAuditSessions()
        {
            try
            {
                string query = "Select * from DBA_AUDIT_SESSION";
                return await _dbService.Connection.QueryAsync<DBA_AUDIT_SESSION>(query);
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

        public async Task<IEnumerable<FGAAuditRecord>> GetFGAAuditDataAsync(string policyName = null)
        {
            string baseQuery = @"
            SELECT 
                DB_USER,
                TIMESTAMP,
                OBJECT_SCHEMA,
                OBJECT_NAME,
                POLICY_NAME,
                SQL_TEXT,
                SCN,
                STATEMENT_TYPE
            FROM DBA_FGA_AUDIT_TRAIL
            WHERE 1=1";
            DynamicParameters parameters = new DynamicParameters();
            if (!string.IsNullOrEmpty(policyName))
            {
                baseQuery += " AND POLICY_NAME = :PolicyName";
                parameters.Add("PolicyName", policyName);
            }
            baseQuery += " ORDER BY TIMESTAMP DESC";
            try
            {
                return await _dbService.Connection.QueryAsync<FGAAuditRecord>(baseQuery, parameters);
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
