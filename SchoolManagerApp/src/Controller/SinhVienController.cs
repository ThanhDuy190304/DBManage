using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagerApp.src.Controller
{
    public class SinhVienController
    {
        private readonly SinhVienService _svService;
        public SinhVienController()
        {
            _svService = new SinhVienService();
        }

        public async Task<IEnumerable<SINHVIEN>> GetAll()
        {
            try
            {
                return await _svService.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy danh sách sinh viên: " + ex.Message);
            }
        }

        public async Task<SINHVIEN> GetAStuInf()
        {
            try
            {
                return await _svService.GetAStuInf();
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy sinh viên: " + ex.Message);
            }
        }

        // Cập nhật thông tin sinh viên (theo các cột lựa chọn)
        public async Task<bool> UpdateSinhVien(string masv, dynamic fieldsToUpdate)
        {
            try
            {
                return await _svService.UpdateSinhVien(masv, fieldsToUpdate);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể cập nhật sinh viên: " + ex.Message);
            }
        }

        public async Task<bool> Insert(SINHVIEN sv)
        {
            try
            {
                return await _svService.Insert(sv);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi thêm sinh viên
                throw new Exception("Không thể thêm sinh viên: " + ex.Message);
            }
        }

        // Xóa sinh viên
        public async Task<bool> Delete(string masv)
        {
            try
            {
                return await _svService.Delete(masv);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi xóa sinh viên
                throw new Exception("Không thể xóa sinh viên: " + ex.Message);
            }
        }
    }
}
