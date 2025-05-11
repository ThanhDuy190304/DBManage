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
    public class MomonService
    {
        private readonly DatabaseService _dbService;

        public MomonService(DatabaseService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }

        // Kiểm tra vai trò của người dùng
        public async Task<IEnumerable<string>> CheckRole(string username)
        {
            try
            {
                string query = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = :username";
                return await _dbService.Connection.QueryAsync<string>(query, new { username = username.ToUpper() });
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi khi kiểm tra vai trò: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_GV (Giảng viên) ---------------------------
        public async Task<IEnumerable<MOMON>> GetPhanCongCaNhan(string username)
        {
            var vaiTros = await CheckRole(username);
            

            try
            {
                string query = "SELECT * FROM ADMIN.V_PHANCONG_CUAMINH_MOMON";
                return await _dbService.Connection.QueryAsync<MOMON>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công cá nhân cho {username}: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_NVPDT (Nhân viên phòng đào tạo) ---------------------------
        public async Task<IEnumerable<MOMON>> GetPhanCongHienTai(string username)
        {
            var vaiTros = await CheckRole(username);
          

            try
            {
                string query = "SELECT * FROM ADMIN.V_HocKi_NamHoc_HienTai_MOMON";
                return await _dbService.Connection.QueryAsync<MOMON>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy danh sách phân công hiện tại cho {username}: " + ex.Message);
            }
        }

        public async Task<bool> InsertPhanCong(string username, MOMON momon)
        {
            var vaiTros = await CheckRole(username);
      

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

        public async Task<bool> UpdatePhanCong(string username, MOMON momon)
        {
            var vaiTros = await CheckRole(username);
     

            try
            {
                string query = @"
                    UPDATE ADMIN.V_HocKi_NamHoc_HienTai_MOMON 
                    SET MAHP = :MAHP, MAGV = :MAGV, HK = :HK, NAM = :NAM
                    WHERE MAMM = :MAMM";
                await _dbService.Connection.ExecuteAsync(query, momon);
                return true;
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

        public async Task<bool> DeletePhanCong(string username, string maMm)
        {
            var vaiTros = await CheckRole(username);
           

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
        public async Task<IEnumerable<MOMON>> GetPhanCongDonVi(string username)
        {
            var vaiTros = await CheckRole(username);
        

            try
            {
                string query = "SELECT * FROM ADMIN.v_phancong_trong_donvi_momon";
                return await _dbService.Connection.QueryAsync<MOMON>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công trong đơn vị cho {username}: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_SV (Sinh viên) ---------------------------
        public async Task<IEnumerable<MOMON>> GetPhanCongKhoa(string username)
        {
            var vaiTros = await CheckRole(username);
      

            try
            {
                string query = "SELECT * FROM ADMIN.v_momon_lienquan_hocphan_thuoc_donvi_momon";
                return await _dbService.Connection.QueryAsync<MOMON>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy phân công liên quan đến khoa cho {username}: " + ex.Message);
            }
        }
    }
}