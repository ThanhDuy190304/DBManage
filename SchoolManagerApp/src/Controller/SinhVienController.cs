using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Controller
{
    public class SinhVienController
    {
        private readonly SinhVienService _svService;

        // Khởi tạo controller với service
        public SinhVienController(DatabaseService dbService)
        {
            _svService = new SinhVienService(dbService);
        }

        // Lấy tất cả sinh viên
        public async Task<IEnumerable<SinhVien>> GetAll()
        {
            try
            {
                return await _svService.GetAll();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi lấy dữ liệu
                throw new Exception("Không thể lấy danh sách sinh viên: " + ex.Message);
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


        // Thêm sinh viên mới
        public async Task<bool> Insert(SinhVien sv)
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
