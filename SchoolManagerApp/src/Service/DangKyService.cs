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
    internal class DangKyService : BaseService
    {
        public async Task<IEnumerable<DANGKY>> GetPoint()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.DANGKY";
                return await _dbService.Connection.QueryAsync<DANGKY>(query);
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

        // Danh sách sinh viên giáo viên phụ trách
        public async Task<IEnumerable<DANGKY>> GetListStudentOfGV(string mamm)
        {
            try
            {
                string query = @"SELECT m.magv, d.mamm, d.masv, m.HK, m.NAM 
                         FROM ADMIN.DANGKY d 
                         JOIN ADMIN.MOMON m ON m.mamm = d.mamm 
                         WHERE d.mamm = :mamm";

                var parameters = new { mamm };
                return await _dbService.Connection.QueryAsync<DANGKY>(query, parameters);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }


        // update du lieu dang ky cua sinh vien cua NV PDT
        public async Task<int> UpdateSV(string maSV, string maMM, string newMAMM)
        {
            try
            {
                string query = @"
            UPDATE ADMIN.DANGKY
            SET MAMM = :newMAMM
            WHERE MASV = :MASV AND MAMM = :MAMM";
                var parameters = new
                {
                    newMAMM,
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

    }
}
