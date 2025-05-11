using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class MomonController
    {
        private readonly MomonService _momonService;

        public MomonController(DatabaseService dbService)
        {
            _momonService = new MomonService(dbService);
        }

        // Chức năng cho role_gv
        public async Task<IEnumerable<MOMON>> GetPhanCongCaNhan(string username)
        {
            try
            {
                return await _momonService.GetPhanCongCaNhan(username);
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

        // Chức năng cho role_nvpdt
        public async Task<IEnumerable<MOMON>> GetPhanCongHienTai(string username)
        {
            try
            {
                return await _momonService.GetPhanCongHienTai(username);
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

        public async Task<bool> InsertPhanCong(string username, MOMON momon)
        {
            try
            {
                return await _momonService.InsertPhanCong(username, momon);
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

        public async Task<bool> UpdatePhanCong(string username, MOMON momon)
        {
            try
            {
                return await _momonService.UpdatePhanCong(username, momon);
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

        public async Task<bool> DeletePhanCong(string username, string maMm)
        {
            try
            {
                return await _momonService.DeletePhanCong(username, maMm);
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

        // Chức năng cho role_trgdv
        public async Task<IEnumerable<MOMON>> GetPhanCongDonVi(string username)
        {
            try
            {
                return await _momonService.GetPhanCongDonVi(username);
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

        // Chức năng cho role_sv
        public async Task<IEnumerable<MOMON>> GetPhanCongKhoa(string username)
        {
            try
            {
                return await _momonService.GetPhanCongKhoa(username);
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