using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            _controller = new NhanVienController();
            _nhanVienService = new NhanVienService();
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + _username + " =====\n");
            //NVCB -- NV008
            await TestSelectByRole();
            //TRGDV -- NV001
            await TestSelectNhanVienTrongDonVi();
            //NV TCHC -- NV011
            await TestSelectTatCaNhanVien(); 
            await TestInsertUpdateDeleteNhanVien();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        private async Task TestSelectByRole()
        {
            try
            {
                var result = await _controller.GETPersonalInformationForNVCB();
                Console.WriteLine("[PASS] SELECT THONG TIN CA NHAN CUA NHANVIEN: " + (result != null ? result.HOTEN : "Khong tim thay") + "\n");
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
                 var result = await _controller.GETEmployeesInManagedUnitTRGDV();
                if (result.Any())
                {
                    Console.WriteLine("[PASS] SELECT NHANVIEN TRONG DON VI:");
                    foreach (var nhanVien in result)
                    {
                        Console.WriteLine($"MANV: {nhanVien.MANV}, HOTEN: {nhanVien.HOTEN}, PHAI: {nhanVien.PHAI}, NGSINH: {nhanVien.NGSINH:yyyy-MM-dd}, LUONG: {nhanVien.LUONG}, PHUCAP: {nhanVien.PHUCAP}, DT: {nhanVien.DT}, VAITRO: {nhanVien.VAITRO}, MADV: {nhanVien.MADV}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT NHANVIEN TRONG DON VI: Khong tim thay\n");
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
                var result = await _controller.GETAllEmployees();
                Console.WriteLine("[PASS] SELECT TAT CA NHANVIEN: " + (result.Any() ? result.First().HOTEN : "Khong tim thay") + "\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT TAT CA NHANVIEN: " + ex.Message + "\n");
            }
        }
        

        // Hàm kiểm tra quyền thêm, cập nhật, xóa nhân viên (chỉ ROLE_NV_TCHC)
        private async Task TestInsertUpdateDeleteNhanVien()
        {
            try
            {
                var nhanVien = new NHANVIEN { MANV = "NV0016", HOTEN = "Pham Van D", PHAI = "M", NGSINH = DateTime.Parse("1990-04-04"), LUONG = 5500, PHUCAP = 1100, DT = "0933333333", VAITRO = "NVCB", MADV = "CNTT" };
                var ok = await _controller.InsertNewEmployee( nhanVien);
                Console.WriteLine(ok ? "[PASS] INSERT NHANVIEN\n" : "[FAIL] INSERT NHANVIEN khong thanh cong\n");

                // Cập nhật 1 trường (HOTEN) với ExpandoObject
                dynamic updateFields1 = new ExpandoObject();
                updateFields1.HOTEN = "Pham Van E";
                ok = await _controller.UpdateEmployeeDetails( "NV0016", updateFields1);
                Console.WriteLine(ok ? "[PASS] UPDATE NHANVIEN (HOTEN)\n" : "[FAIL] UPDATE NHANVIEN (HOTEN) khong thanh cong\n");

                // Cập nhật 2 trường (HOTEN và DT) với ExpandoObject
                dynamic updateFields2 = new ExpandoObject();
                updateFields2.HOTEN = "Pham Van F";
                updateFields2.DT = "0944444444";
                ok = await _controller.UpdateEmployeeDetails( "NV0016", updateFields2);
                Console.WriteLine(ok ? "[PASS] UPDATE NHANVIEN (HOTEN, DT)\n" : "[FAIL] UPDATE NHANVIEN (HOTEN, DT) khong thanh cong\n");

                // Cập nhật 2 trường khác (LUONG và PHAI) với ExpandoObject
                dynamic updateFields3 = new ExpandoObject();
                updateFields3.LUONG = 6000;
                updateFields3.PHAI = "F";
                ok = await _controller.UpdateEmployeeDetails( "NV0016", updateFields3);
                Console.WriteLine(ok ? "[PASS] UPDATE NHANVIEN (LUONG, PHAI)\n" : "[FAIL] UPDATE NHANVIEN (LUONG, PHAI) khong thanh cong\n");

                ok = await _controller.DeleteEmployee( "NV0016");
                Console.WriteLine(ok ? "[PASS] DELETE NHANVIEN\n" : "[FAIL] DELETE NHANVIEN khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] Insert/Update/Delete NHANVIEN: " + ex.Message + "\n");
            }
        }
    }
}