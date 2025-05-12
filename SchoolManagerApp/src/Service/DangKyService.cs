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

        // update diem của NV PKT
        public async Task<int> UpdateHocPhan(string maSV, string maMM, double? diemTH, double? diemQT, double? diemCK, double? diemTK)
        {
            try
            {
                string query = "UPDATE ADMIN.DANGKY SET ";

                var parameters = new DynamicParameters();
                parameters.Add("MASV", maSV);
                parameters.Add("MAMM", maMM);

                bool hasUpdateClause = false;

                if (diemTH.HasValue)
                {
                    query += "DIEMTH = :DIEMTH, ";
                    parameters.Add("DIEMTH", diemTH.Value);
                    hasUpdateClause = true;
                }

                if (diemQT.HasValue)
                {
                    query += "DIEMQT = :DIEMQT, ";
                    parameters.Add("DIEMQT", diemQT.Value);
                    hasUpdateClause = true;
                }

                if (diemCK.HasValue)
                {
                    query += "DIEMCK = :DIEMCK, ";
                    parameters.Add("DIEMCK", diemCK.Value);
                    hasUpdateClause = true;
                }

                if (diemTK.HasValue)
                {
                    query += "DIEMTK = :DIEMTK, ";
                    parameters.Add("DIEMTK", diemTK.Value);
                    hasUpdateClause = true;
                }

                if (hasUpdateClause)
                {
                    query = query.Substring(0, query.Length - 2);
                }
                else
                {
                    throw new InvalidOperationException("Không có trường nào để cập nhật.");
                }

                query += " WHERE MASV = :MASV AND MAMM = :MAMM";

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

        // Danh sách sinh viên giáo viên phụ trách
        public async Task<IEnumerable<DangKy>> GetListStudentOfGV()
        {
            try
            {
                string query = "select m.magv, d.mamm, d.masv, m.HK, m.NAM From ADMIN.DANGKY d Join ADMIN.MOMON m On m.mamm = d.mamm";
                return await _dbService.Connection.QueryAsync<DangKy>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }
    }
}
