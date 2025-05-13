using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;

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

        // 1. Lấy danh sách sinh viên
        public async Task<IEnumerable<SinhVien>> GetAll()
        {
            try
            {
                return await _svService.GetAllSinhVien();
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy danh sách sinh viên: " + ex.Message);
            }
        }

        // 2. Thêm sinh viên
        public async Task<int> Insert(SinhVien sv)
        {
            try
            {
                return await _svService.InsertSinhVien(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể thêm sinh viên: " + ex.Message);
            }
        }

        // 3. Cập nhật sinh viên
        public async Task<int> Update(SinhVien sv)
        {
            try
            {
                return await _svService.UpdateSinhVien(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể cập nhật sinh viên: " + ex.Message);
            }
        }

        // 4. Xoá sinh viên
        public async Task<int> Delete(string maSV)
        {
            try
            {
                return await _svService.DeleteSinhVien(maSV);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể xóa sinh viên: " + ex.Message);
            }
        }
    }
}
