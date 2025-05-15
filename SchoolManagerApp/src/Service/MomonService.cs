using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    internal class MomonService : BaseService
    {
      
        // --------------------------- Chức năng cho ROLE_GV (Giảng viên) ---------------------------
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETPersonalTeachingAssignmentsForLecturer()
        {

            try
            {
                string query = "SELECT * FROM ADMIN.V_PHANCONG_CUAMINH_MOMON";
                return await _dbService.Connection.QueryAsync<MOMON_HOCPHAN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công cá nhân cho : " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_NVPDT (Nhân viên phòng đào tạo) ---------------------------
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETCurrentTeachingAssignments()
        {

            try
            {
                string query = "SELECT * FROM ADMIN.V_HocKi_NamHoc_HienTai_MOMON";
                return await _dbService.Connection.QueryAsync<MOMON_HOCPHAN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy danh sách phân công hiện tại cho : " + ex.Message);
            }
        }

        public async Task<bool> InsertNewTeachingAssignment( MOMON momon)
        {
            try
            {
                string query = @"
                    INSERT INTO ADMIN.V_HocKi_NamHoc_HienTai_MOMON (MAMM, MAHP, MAGV, HK, NAM)
                    VALUES (:MAMM, :MAHP, :MAGV, :HK, :NAM)";
                await _dbService.Connection.ExecuteAsync(query, momon);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi khi thêm phân công: " + ex.Message);
            }
        }

        public async Task<bool> UpdateTeachingAssignmentDetails( string maMm, dynamic fieldsToUpdate)
        {
            try
            {
                var expandoDict = (IDictionary<string, object>)fieldsToUpdate;
                var setClauses = new List<string>();
                var parameters = new DynamicParameters();
                parameters.Add("MAMM", maMm);

                foreach (var field in expandoDict)
                {
                    string columnName = field.Key.ToUpper();
                    if (!IsValidColumn(columnName))
                    {
                        throw new ArgumentException($"Trường {columnName} không hợp lệ.");
                    }
                    setClauses.Add($"{columnName} = :{columnName}");
                    parameters.Add(columnName, field.Value);
                }

                string query = @"
                    UPDATE ADMIN.V_HocKi_NamHoc_HienTai_MOMON 
                    SET " + string.Join(", ", setClauses) + @"
                    WHERE MAMM = :MAMM";

                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, parameters);
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi khi cập nhật phân công: " + ex.Message);
            }
        }
        private bool IsValidColumn(string columnName)
        {
            var validColumns = new HashSet<string> { "MAMM", "MAHP", "MAGV", "HK", "NAM" };
            return validColumns.Contains(columnName);
        }

        public async Task<bool> DeleteTeachingAssignment( string maMm)
        {
            try
            {
                string query = "DELETE FROM ADMIN.V_HocKi_NamHoc_HienTai_MOMON WHERE MAMM = :MaMm";
                await _dbService.Connection.ExecuteAsync(query, new { MaMm = maMm });
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi khi xóa phân công: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_TRGDV (Trưởng đơn vị) ---------------------------
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETTeachingAssignmentsInManagedUnit()
        {
            try
            {
                string query = "SELECT * FROM ADMIN.v_phancong_trong_donvi_momon";
                return await _dbService.Connection.QueryAsync<MOMON_HOCPHAN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công trong đơn vị cho : " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_SV (Sinh viên) ---------------------------
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETTeachingAssignmentsForDepartment()
        {

            try
            {
                string query = "SELECT * FROM ADMIN.v_momon_lienquan_hocphan_thuoc_donvi_momon";
                return await _dbService.Connection.QueryAsync<MOMON_HOCPHAN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công liên quan đến khoa cho : " + ex.Message);
            }
        }
    }
}