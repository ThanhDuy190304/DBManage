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
    internal class SinhVienService : BaseService
    {

        public async Task<IEnumerable<SINHVIEN>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.SINHVIEN";
                return await _dbService.Connection.QueryAsync<SINHVIEN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<SINHVIEN> GetAStuInf()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.SINHVIEN";
                var students = await _dbService.Connection.QueryAsync<SINHVIEN>(query);
                var firstStudent = students.FirstOrDefault();

                return firstStudent;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<bool> UpdateSinhVien(string masv, dynamic fieldsToUpdate)
        {
            try
            {
                var expandoDict = (IDictionary<string, object>)fieldsToUpdate;
                var setClauses = new List<string>();
                var parameters = new DynamicParameters();

                parameters.Add("MASV", masv);

                foreach (var field in expandoDict)
                {
                    string columnName = field.Key.ToUpper();
                    if (!IsValidSinhVienColumn(columnName))
                    {
                        throw new ArgumentException($"Trường {columnName} không hợp lệ.");
                    }

                    setClauses.Add($"{columnName} = :{columnName}");
                    parameters.Add(columnName, field.Value);
                }

                string query = $@"
            UPDATE ADMIN.SINHVIEN
            SET {string.Join(", ", setClauses)}
            WHERE MASV = :MASV";

                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, parameters);
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }
        public async Task<bool> Insert(SINHVIEN sv)
        {
            string query = @"INSERT INTO ADMIN.SINHVIEN (MASV, HOTEN, DCHI, DT, KHOA, TINHTRANG) 
                             VALUES (:MASV, :HOTEN, :DCHI, :DT, :KHOA, :TINHTRANG)";
            try
            {
                await _dbService.Connection.ExecuteAsync(query, sv);

                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }
        public async Task<bool> Delete(string masv)
        {

            string query = "DELETE FROM ADMIN.SINHVIEN WHERE MASV = :MASV";
            try
            {
                await _dbService.Connection.ExecuteAsync(query, new { MASV = masv });
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }
    private bool IsValidSinhVienColumn(string columnName)
    {
        var validColumns = new HashSet<string>
        {
            "HOTEN", "PHAI", "NGSINH", "DCHI", "DT", "KHOA", "TINHTRANG"
        };
        return validColumns.Contains(columnName);
    }
    }
}
