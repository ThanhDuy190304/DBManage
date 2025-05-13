using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;

namespace SchoolManagerApp.src.Service
{
    public class SinhVienService
    {
        private readonly DatabaseService _dbService;

        public SinhVienService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        // Lấy danh sách sinh viên
        public async Task<IEnumerable<SinhVien>> GetAllSinhVien()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.SINHVIEN";
                return await _dbService.Connection.QueryAsync<SinhVien>(query);
            }
            catch (OracleException ex)
            {
                throw new Exception("Không thể lấy danh sách sinh viên: " + ex.Message);
            }
        }


        // Thêm sinh viên
        public async Task<int> InsertSinhVien(SinhVien sv)
        {
            try
            {
                string query = @"
                    INSERT INTO ADMIN.SINHVIEN (MASV, HOTEN, DCHI, DT, MAKHOA, TINHTRANG)
                    VALUES (:MASV, :HOTEN, :DCHI, :DT, :MAKHOA, :TINHTRANG)";

                return await _dbService.Connection.ExecuteAsync(query, sv);
            }
            catch (OracleException ex)
            {
                throw new Exception("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        // Xóa sinh viên
        public async Task<int> DeleteSinhVien(string maSV)
        {
            try
            {
                string query = "DELETE FROM ADMIN.SINHVIEN WHERE MASV = :MASV";

                return await _dbService.Connection.ExecuteAsync(query, new { MASV = maSV });
            }
            catch (OracleException ex)
            {
                throw new Exception("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        // Cập nhật sinh viên
        public async Task<int> UpdateSinhVien(SinhVien sv)
        {
            try
            {
                string query = @"
                    UPDATE ADMIN.SINHVIEN
                    SET HOTEN = :HOTEN,
                        DCHI = :DCHI,
                        DT = :DT,
                        MAKHOA = :MAKHOA,
                        TINHTRANG = :TINHTRANG
                    WHERE MASV = :MASV";

                return await _dbService.Connection.ExecuteAsync(query, sv);
            }
            catch (OracleException ex)
            {
                throw new Exception("Lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }
    }
}
