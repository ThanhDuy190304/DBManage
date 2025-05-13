using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.utils;
using System.Dynamic;

namespace SchoolManagerApp.src.Service
{
    internal class NhanVienService : BaseService
    {

        // --------------------------- Chức năng cho ROLE_NVCB (Nhân viên cơ bản) ---------------------------
        public async Task<NHANVIEN> GETPersonalInformationForNVCB()
        {
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
                throw new ServerError($"Lỗi khi lấy thông tin cá nhân cho : " + ex.Message);
            }
        }

        public async Task<bool> UpdatePhoneNumberForNVCB( string newDT)
        {

            try
            {
                string query = "UPDATE ADMIN.V_THONGTINCANHAN_NHANVIEN SET DT = :newDT";
                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, new { newDT });
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi cập nhật số điện thoại cho : " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_TRGDV (Trưởng đơn vị) ---------------------------

        public async Task<IEnumerable<NHANVIEN>> GETEmployeesInManagedUnitTRGDV()
        {
            

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
                throw new ServerError($"Lỗi khi lấy danh sách nhân viên trong đơn vị cho : " + ex.Message);
            }
        }

        // --------------------------- Chức năng cho ROLE_NV_TCHC (Nhân viên tổ chức hành chính) ---------------------------
        public async Task<IEnumerable<NHANVIEN>> GETAllEmployees()
        {
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
                throw new ServerError($"Lỗi khi lấy danh sách tất cả nhân viên cho : " + ex.Message);
            }
        }

        public async Task<bool> InsertNewEmployee( NHANVIEN nhanVien)
        {

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
                throw new ServerError($"Lỗi khi thêm nhân viên cho : " + ex.Message);
            }
        }

        public async Task<bool> UpdateEmployeeDetails( string manv, dynamic fieldsToUpdate)
        {
            try
            {
                var expandoDict = (IDictionary<string, object>)fieldsToUpdate;
                var setClauses = new List<string>();
                var parameters = new DynamicParameters();
                parameters.Add("MANV", manv);

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
                            UPDATE ADMIN.NHANVIEN 
                            SET " + string.Join(", ", setClauses) + @"
                            WHERE MANV = :MANV";

                int rowsAffected = await _dbService.Connection.ExecuteAsync(query, parameters);
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Lỗi khi cập nhật nhân viên cho : " + ex.Message);
            }
        }

        private bool IsValidColumn(string columnName)
        {
            var validColumns = new HashSet<string> { "MANV", "HOTEN", "PHAI", "NGSINH", "LUONG", "PHUCAP", "DT", "VAITRO", "MADV" };
            return validColumns.Contains(columnName);
        }

        public async Task<bool> DeleteEmployee( string maNv)
        {
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
                throw new ServerError($"Lỗi khi xóa nhân viên cho: " + ex.Message);
            }
        }
    }
}