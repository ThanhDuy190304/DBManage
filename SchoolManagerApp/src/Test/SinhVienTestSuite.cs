using Dapper;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using System;
using System.Data;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Test
{
    public class SinhVienTestSuite
    {
        private readonly SinhVienController _controller;

        public SinhVienTestSuite(string username, string password)
        {
            var dbService = DatabaseService.GetInstance(username, password); // tạo kết nối mới theo user
            _controller = new SinhVienController(dbService); // truyền vào đây
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " +  " =====\n");

            await TestSelectAll();
            await TestUpdateDiaChi();
            await TestInsertSinhVien();
            await TestDeleteSinhVien();
            await TestUpdateTinhTrang();

            Console.WriteLine("===== KẾT THÚC TEST =====\n");
        }

        private async Task TestSelectAll()
        {
            try
            {
                var result = await _controller.GetAll();
                Console.WriteLine("[PASS] SELECT danh sách SV: " + result.AsList().Count + " dong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sách SV: " + ex.Message + "\n");
            }
        }

        private async Task TestUpdateDiaChi()
        {
            try
            {
                var ok = await _controller.UpdateSinhVien(new SinhVien
                {
                    MASV = "sv1",
                    DCHI = "Dia chi moi",
                    DT = "0911222333"
                });
                Console.WriteLine(ok ? "[PASS] UPDATE DCHI, DT\n" : "[FAIL] UPDATE DCHI, DT không thành công\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE DCHI, DT: " + ex.Message + "\n");
            }
        }

       

        private async Task TestInsertSinhVien()
        {
            try
            {
                var ok = await _controller.Insert(new SinhVien
                {
                    MASV = "SV_TEST",
                    HOTEN = "Sinh Vien Test",
                    DCHI = "Test DC",
                    DT = "0909090909",
                    MAKHOA = "KH01",
                    TINHTRANG = null
                });
                Console.WriteLine(ok ? "[PASS] INSERT sinh viên\n" : "[FAIL] INSERT sinh viên không thành công\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] INSERT sinh viên: " + ex.Message + "\n");
            }
        }

        private async Task TestDeleteSinhVien()
        {
            try
            {
                var ok = await _controller.Delete("SV_TEST");
                Console.WriteLine(ok ? "[PASS] DELETE sinh viên\n" : "[FAIL] DELETE sinh viên không thành công\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] DELETE sinh viên: " + ex.Message + "\n");
            }
        }

        private async Task TestUpdateTinhTrang()
        {
            try
            {
                var ok = await _controller.UpdateTinhTrang("sv1", "Dang hoc");
                Console.WriteLine(ok ? "[PASS] UPDATE TINHTRANG\n" : "[FAIL] UPDATE TINHTRANG không thành công\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE TINHTRANG: " + ex.Message + "\n");
            }
        }
    }
}