using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Test
{
    internal class TestNhanVienController
    {
        private readonly NhanVienController _controller;
        private readonly string _username;
        private readonly NhanVienService _nhanVienService;

        public TestNhanVienController(string username, string password)
        {
            _username = username;
            var dbService = DatabaseService.GetInstance(username, password);
            _controller = new NhanVienController(dbService);
            _nhanVienService = new NhanVienService(dbService);
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + _username + " =====\n");

            await TestSelectByRole();
            await TestSelectNhanVienTrongDonVi(); 
            await TestSelectTatCaNhanVien(); 
            await TestUpdateSoDienThoai(); 
            await TestInsertUpdateDeleteNhanVien();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        private async Task TestSelectByRole()
        {
            try
            {
                var vaiTros = await _nhanVienService.CheckRole(_username);

                if (vaiTros.Contains("ROLE_NVCB") || vaiTros.Contains("ROLE_TRGDV") || vaiTros.Contains("ROLE_NV_TCHC"))
                {
                    var result = await _controller.GetThongTinCaNhan(_username);
                    Console.WriteLine("[PASS] SELECT THONG TIN CA NHAN: " + (result != null ? result.HOTEN : "Khong tim thay") + "\n");
                }
                else
                {
                    throw new InvalidDataError("Vai trò không hợp lệ hoặc không được hỗ trợ.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT theo vai tro: " + ex.Message + "\n");
            }
        }

        // Hàm kiểm tra quyền bổ sung cho ROLE_TRGDV
        private async Task TestSelectNhanVienTrongDonVi()
        {
            try
            {
                var vaiTros = await _nhanVienService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_TRGDV"))
                {
                    var result = await _controller.GetNhanVienTrongDonVi(_username);
                    Console.WriteLine("[PASS] SELECT NHANVIEN TRONG DON VI: " + (result.Any() ? result.First().HOTEN : "Khong tim thay") + "\n");
                }
                else
                {
                    Console.WriteLine("[PASS] Khong co quyen xem NHANVIEN trong don vi (khong phai ROLE_TRGDV)\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT NHANVIEN TRONG DON VI: " + ex.Message + "\n");
            }
        }

        // Hàm kiểm tra quyền bổ sung cho ROLE_NV_TCHC
        private async Task TestSelectTatCaNhanVien()
        {
            try
            {
                var vaiTros = await _nhanVienService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_NV_TCHC"))
                {
                    var result = await _controller.GetAllNhanVien(_username);
                    Console.WriteLine("[PASS] SELECT TAT CA NHANVIEN: " + (result.Any() ? result.First().HOTEN : "Khong tim thay") + "\n");
                }
                else
                {
                    Console.WriteLine("[PASS] Khong co quyen xem TAT CA NHANVIEN (khong phai ROLE_NV_TCHC)\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT TAT CA NHANVIEN: " + ex.Message + "\n");
            }
        }

        // Hàm kiểm tra quyền cập nhật số điện thoại (tất cả vai trò đều có quyền này)
        private async Task TestUpdateSoDienThoai()
        {
            try
            {
                var vaiTros = await _nhanVienService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_NVCB") || vaiTros.Contains("ROLE_TRGDV") || vaiTros.Contains("ROLE_NV_TCHC"))
                {
                    var ok = await _controller.UpdateSoDienThoai(_username, "0911111111");
                    Console.WriteLine(ok ? "[PASS] UPDATE SO DIEN THOAI\n" : "[FAIL] UPDATE SO DIEN THOAI khong thanh cong\n");
                }
                else
                {
                    Console.WriteLine("[PASS] Khong co quyen cap nhat SO DIEN THOAI (khong phai ROLE_NVCB, ROLE_TRGDV, ROLE_NV_TCHC)\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE SO DIEN THOAI: " + ex.Message + "\n");
            }
        }

        // Hàm kiểm tra quyền thêm, cập nhật, xóa nhân viên (chỉ ROLE_NV_TCHC)
        private async Task TestInsertUpdateDeleteNhanVien()
        {
            try
            {
                var vaiTros = await _nhanVienService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_NV_TCHC"))
                {
                    var nhanVien = new NHANVIEN { MANV = "NV0016", HOTEN = "Pham Van D", PHAI = "M", NGSINH = DateTime.Parse("1990-04-04"), LUONG = 5500, PHUCAP = 1100, DT = "0933333333", VAITRO = "NVCB", MADV = "CNTT" };
                    var ok = await _controller.InsertNhanVien(_username, nhanVien);
                    Console.WriteLine(ok ? "[PASS] INSERT NHANVIEN\n" : "[FAIL] INSERT NHANVIEN khong thanh cong\n");

                    nhanVien.LUONG = 6000;
                    ok = await _controller.UpdateNhanVien(_username, nhanVien);
                    Console.WriteLine(ok ? "[PASS] UPDATE NHANVIEN\n" : "[FAIL] UPDATE NHANVIEN khong thanh cong\n");

                    ok = await _controller.DeleteNhanVien(_username, "NV0016");
                    Console.WriteLine(ok ? "[PASS] DELETE NHANVIEN\n" : "[FAIL] DELETE NHANVIEN khong thanh cong\n");
                }
                else
                {
                    Console.WriteLine("[PASS] Khong co quyen Insert/Update/Delete NHANVIEN (khong phai ROLE_NV_TCHC)\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] Insert/Update/Delete NHANVIEN: " + ex.Message + "\n");
            }
        }
    }
}