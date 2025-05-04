using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    public class SinhVienService
    {
        private readonly DatabaseService _dbService;

        public SinhVienService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<SinhVien>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.SINHVIEN";
                return await _dbService.Connection.QueryAsync<SinhVien>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<bool> UpdateSinhVien(SinhVien sv)
        {
            string query = "UPDATE ADMIN.SINHVIEN SET DCHI = :DCHI, DT = :DT WHERE MASV = :MASV";

            try
            {
                var rowsAffected = await _dbService.Connection.ExecuteAsync(query, sv);
                Console.WriteLine($"Số dòng được cập nhật: {rowsAffected}");

                if (rowsAffected == 0)
                {
                    Console.WriteLine("Cảnh báo: Không có bản ghi nào được cập nhật. Kiểm tra lại MASV");
                    return false;
                }

                await _dbService.Connection.ExecuteAsync("COMMIT");
                return true;
            }
            catch (OracleException ex)
            {
                await _dbService.Connection.ExecuteAsync("ROLLBACK");
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<bool> UpdateTinhTrang(string masv, string tinhtrang)
        {
            string query = "UPDATE ADMIN.SINHVIEN SET TINHTRANG = :TINHTRANG WHERE MASV = :MASV";
            try
            {
                await _dbService.Connection.ExecuteAsync(query, new { MASV = masv, TINHTRANG = tinhtrang });
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<bool> Insert(SinhVien sv)
        {
            string query = @"INSERT INTO ADMIN.SINHVIEN (MASV, HOTEN, DCHI, DT, MAKHOA, TINHTRANG) 
                             VALUES (:MASV, :HOTEN, :DCHI, :DT, :MAKHOA, :TINHTRANG)";
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
    }
}
