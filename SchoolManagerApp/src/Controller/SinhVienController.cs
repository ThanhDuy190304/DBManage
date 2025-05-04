using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Controller
{
    public class SinhVienController
    {
        private readonly SinhVienService _svService;

        public SinhVienController(DatabaseService dbService)
        {
            _svService = new SinhVienService(dbService);
        }

        public async Task<IEnumerable<SinhVien>> GetAll()
        {
            try
            {
                return await _svService.GetAll();
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể lấy danh sách sinh viên: " + ex.Message);
            }
        }

        public async Task<bool> UpdateSinhVien(SinhVien sv)
        {
            return await _svService.UpdateSinhVien(sv);
        }

        public async Task<bool> UpdateTinhTrang(string masv, string tinhtrang)
        {
            return await _svService.UpdateTinhTrang(masv, tinhtrang);
        }

        public async Task<bool> Insert(SinhVien sv)
        {
            return await _svService.Insert(sv);
        }

        public async Task<bool> Delete(string masv)
        {
            return await _svService.Delete(masv);
        }
    }
}
