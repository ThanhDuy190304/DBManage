using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    public class DangKyService
    {
        private readonly DatabaseService _dbService;

        public DangKyService(DatabaseService dbService)
        {
            _dbService = dbService;
        }
        public async Task<IEnumerable<DangKy>> GetPoint()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.DANGKY";
                return await _dbService.Connection.QueryAsync<DangKy>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<int> InsertHocPhan(string maSV, string maMM)
        {
            try
            {
                string query = @"
            INSERT INTO ADMIN.DANGKY (MASV, MAMM)
            VALUES (:MASV, :MAMM)";

                var parameters = new
                {
                    MASV = maSV,
                    MAMM = maMM
                };

                return await _dbService.Connection.ExecuteAsync(query, parameters);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }


        public async Task<int> DeleteHocPhan(string maSV, string maMM)
        {
            try
            {
                string query = @"
            DELETE FROM ADMIN.DANGKY
            WHERE MASV = :MASV AND MAMM = :MAMM";

                var parameters = new
                {
                    MASV = maSV,
                    MAMM = maMM
                };

                return await _dbService.Connection.ExecuteAsync(query, parameters);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }


        public async Task<int> UpdateHocPhan(string maSV, string maMM, double diemTH, double diemQT, double diemCK, double diemTK)
        {
            try
            {
                string query = @"
            UPDATE ADMIN.DANGKY
            SET DIEMTH = :DIEMTH,
                DIEMQT = :DIEMQT,
                DIEMCK = :DIEMCK,
                DIEMTK = :DIEMTK
            WHERE MASV = :MASV AND MAMM = :MAMM";

                var parameters = new
                {
                    MASV = maSV,
                    MAMM = maMM,
                    DIEMTH = diemTH,
                    DIEMQT = diemQT,
                    DIEMCK = diemCK,
                    DIEMTK = diemTK
                };

                return await _dbService.Connection.ExecuteAsync(query, parameters);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }




        // Danh sách lớp giáo viên phụ trách
        public async Task<IEnumerable<MoMon>> GetListClass()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.MoMon";
                return await _dbService.Connection.QueryAsync<MoMon>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

    }
}
