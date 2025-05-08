using Dapper;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("===== TEST CHO USER: " + " =====\n");

            await TestSelectAll();
            await TestUpdateDiaChi();
            await TestUpdateTinhTrang();
            await TestUpdateInfoOfOtherStudent();
            await TestInsertSinhVien();
            await TestDeleteSinhVien();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        // Kiểm tra Select tất cả sinh viên
        private async Task TestSelectAll()
        {
            try
            {
                var result = await _controller.GetAll();
                Console.WriteLine("[PASS] SELECT danh sach SV: " + result.AsList().Count + " dong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach SV: " + ex.Message + "\n");
            }
        }

        // Kiểm tra Cập nhật địa chỉ cho sinh viên
        private async Task TestUpdateDiaChi()
        {
            try
            {
                var ok = await _controller.UpdateSinhVien(new SinhVien
                {
                    MASV = "SV1",
                    DCHI = "Dia chi moi",
                    DT = "0911222333"
                }, new List<string> { "DCHI", "DT" });

                Console.WriteLine(ok ? "[PASS] UPDATE DCHI, DT\n" : "[FAIL] UPDATE DCHI, DT khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE DCHI, DT: " + ex.Message + "\n");
            }
        }

        // Kiểm tra cập nhật thông tin sinh viên khác
        private async Task TestUpdateInfoOfOtherStudent()
        {
            try
            {
                var ok = await _controller.UpdateSinhVien(new SinhVien
                {
                    MASV = "SV2",
                    DCHI = "Dia chi moi",
                    DT = "0911222333"
                }, new List<string> { "DCHI", "DT" });

                Console.WriteLine(ok ? "[FAIL] Cap nhat thong tin sinh vien khac thanh cong (khong dung)" : "[PASS] Cap nhat thong tin sinh vien khac bi tu choi\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[PASS] Cap nhat thong tin sinh vien khac bi tu choi: " + ex.Message + "\n");
            }
        }

        private async Task TestUpdateHoten()
        {
            try
            {
                var ok = await _controller.UpdateSinhVien(new SinhVien
                {
                    MASV = "SV1",
                    HOTEN = "Nguyen Thi Mai"
                }, new List<string> { "HOTEN" });

                Console.WriteLine(ok ? "[PASS] UPDATE HOTEN\n" : "[FAIL] UPDATE HOTEN khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE HOTEN: " + ex.Message + "\n");
            }
        }

        private async Task TestUpdateTinhTrang()
        {
            try
            {
                var ok = await _controller.UpdateSinhVien(new SinhVien
                {
                    MASV = "SV1",
                    TINHTRANG = "Dang hoc"
                }, new List<string> { "TINHTRANG" });

                Console.WriteLine(ok ? "[PASS] UPDATE TINHTRANG cho sv1 thanh cong\n" : "[FAIL] UPDATE TINHTRANG cho sv1 khong thanh cong\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE TINHTRANG cho sv1: " + ex.Message + "\n");
            }
        }


        // Kiểm tra Insert sinh viên
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
                Console.WriteLine(ok ? "[PASS] INSERT sinh vien\n" : "[FAIL] INSERT sinh vien khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] INSERT sinh vien: " + ex.Message + "\n");
            }
        }

        // Kiểm tra Delete sinh viên
        private async Task TestDeleteSinhVien()
        {
            try
            {
                var ok = await _controller.Delete("SV_TEST");
                Console.WriteLine(ok ? "[PASS] DELETE sinh vien\n" : "[FAIL] DELETE sinh vien khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] DELETE sinh vien: " + ex.Message + "\n");
            }
        }
    }
}
