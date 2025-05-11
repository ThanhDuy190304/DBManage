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
    public class NhanVienService
    {
        private readonly DatabaseService _dbService;

        public NhanVienService(DatabaseService dbService)
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

        // --------------------------- Chức năng cho ROLE_NVCB (Nhân viên cơ bản) ---------------------------
        public async Task<NHANVIEN> GetThongTinCaNhan(string username)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

            try
            {
                string query = "SELECT * FROM ADMIN.V_THONGTINCANHAN_NHANVIEN";
                return (await _dbService.Connection.QueryAsync<NHANVIEN>(query)).FirstOrDefault();
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy thông tin cá nhân cho {username}: " + ex.Message);
            }
        }

        public async Task<bool> UpdateSoDienThoai(string username, string newDT)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

            try
            {
                string query = "UPDATE ADMIN.V_THONGTINCANHAN_NHANVIEN SET DT = :newDT";
                Console.WriteLine($"Executing query: {query} with newDT: {newDT}, username: {username}");
                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, new { newDT });
                Console.WriteLine($"Rows affected: {rowsAffected}");
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi cập nhật số điện thoại cho {username}: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_TRGDV (Trưởng đơn vị) ---------------------------
        public async Task<NHANVIEN> GetThongTinCaNhanTrgDv(string username)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

           

            try
            {
                string query = "SELECT * FROM ADMIN.V_THONGTINCANHAN_NHANVIEN";
                return (await _dbService.Connection.QueryAsync<NHANVIEN>(query)).FirstOrDefault();
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy thông tin cá nhân cho {username}: " + ex.Message);
            }
        }

        public async Task<IEnumerable<NHANVIEN>> GetNhanVienTrongDonVi(string username)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

            

            try
            {
                string query = "SELECT * FROM ADMIN.V_NHANVIEN_TRONG_DONVI_TRU_LUONG_PHUCAP_NHANVIEN";
                return await _dbService.Connection.QueryAsync<NHANVIEN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy danh sách nhân viên trong đơn vị cho {username}: " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_NV_TCHC (Nhân viên tổ chức hành chính) ---------------------------
        public async Task<IEnumerable<NHANVIEN>> GetAllNhanVien(string username)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

   

            try
            {
                string query = "SELECT * FROM ADMIN.NHANVIEN";
                return await _dbService.Connection.QueryAsync<NHANVIEN>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi lấy danh sách tất cả nhân viên cho {username}: " + ex.Message);
            }
        }

        public async Task<bool> InsertNhanVien(string username, NHANVIEN nhanVien)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

            if (!vaiTros.Contains("ROLE_NV_TCHC"))
            {
                throw new InvalidDataError("Chỉ nhân viên tổ chức hành chính (ROLE_NV_TCHC) mới có quyền thêm nhân viên.");
            }

            try
            {
                string query = @"
                    INSERT INTO ADMIN.NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV)
                    VALUES (:MANV, :HOTEN, :PHAI, :NGSINH, :LUONG, :PHUCAP, :DT, :VAITRO, :MADV)";
                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, nhanVien);
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi thêm nhân viên cho {username}: " + ex.Message);
            }
        }

        public async Task<bool> UpdateNhanVien(string username, NHANVIEN nhanVien)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

            

            try
            {
                string query = @"
                    UPDATE ADMIN.NHANVIEN 
                    SET HOTEN = :HOTEN, PHAI = :PHAI, NGSINH = :NGSINH, LUONG = :LUONG, PHUCAP = :PHUCAP, 
                        DT = :DT, VAITRO = :VAITRO, MADV = :MADV
                    WHERE MANV = :MANV";
                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, nhanVien);
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi cập nhật nhân viên cho {username}: " + ex.Message);
            }
        }

        public async Task<bool> DeleteNhanVien(string username, string maNv)
        {
            var vaiTros = await CheckRole(username);
            Console.WriteLine($"Vai tro cua {username}: {string.Join(", ", vaiTros ?? new List<string>())}");

          

            try
            {
                string query = "DELETE FROM ADMIN.NHANVIEN WHERE MANV = :MaNv";
                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, new { MaNv = maNv });
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi xóa nhân viên cho {username}: " + ex.Message);
            }
        }
    }
}