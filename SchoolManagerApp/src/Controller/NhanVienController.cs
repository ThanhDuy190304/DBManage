using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class NhanVienController
    {
        private readonly NhanVienService _nhanVienService;

        public NhanVienController(DatabaseService dbService)
        {
            _nhanVienService = new NhanVienService(dbService);
        }

        // Chức năng cho RL_NVCB
        public async Task<NHANVIEN> GetThongTinCaNhan(string username)
        {
            try
            {
                return await _nhanVienService.GetThongTinCaNhan(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> UpdateSoDienThoai(string username, string newDT)
        {
            try
            {
                return await _nhanVienService.UpdateSoDienThoai(username, newDT);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Chức năng cho RL_TRGDV
        public async Task<NHANVIEN> GetThongTinCaNhanTrgDv(string username)
        {
            try
            {
                return await _nhanVienService.GetThongTinCaNhanTrgDv(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<IEnumerable<NHANVIEN>> GetNhanVienTrongDonVi(string username)
        {
            try
            {
                return await _nhanVienService.GetNhanVienTrongDonVi(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Chức năng cho RL_NV_TCHC
        public async Task<IEnumerable<NHANVIEN>> GetAllNhanVien(string username)
        {
            try
            {
                return await _nhanVienService.GetAllNhanVien(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> InsertNhanVien(string username, NHANVIEN nhanVien)
        {
            try
            {
                return await _nhanVienService.InsertNhanVien(username, nhanVien);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> UpdateNhanVien(string username, NHANVIEN nhanVien)
        {
            try
            {
                return await _nhanVienService.UpdateNhanVien(username, nhanVien);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> DeleteNhanVien(string username, string maNv)
        {
            try
            {
                return await _nhanVienService.DeleteNhanVien(username, maNv);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}