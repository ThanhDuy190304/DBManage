using System;
using System.Collections.Generic;
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
    internal class TestMomonController
    {
        private readonly MomonController _controller;
        private readonly string _username;
        private readonly MomonService _momonService; // Thêm tham chiếu đến MomonService

        public TestMomonController(string username, string password)
        {
            _username = username;
            var dbService = DatabaseService.GetInstance(username, password);
            _controller = new MomonController(dbService);
            _momonService = new MomonService(dbService); // Khởi tạo MomonService
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + _username + " =====\n");

            await TestSelectAll();
            await TestSelectByRole();
            await TestUpdateOrInsertOrDelete(); // Kiểm tra tùy vai trò
            await TestUpdateOrInsertOrDeleteOther();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        // Kiểm tra Select tất cả (chỉ cho ROLE_NVPDT)
        private async Task TestSelectAll()
        {
            try
            {
                var result = await _controller.GetPhanCongHienTai(_username);
                Console.WriteLine("[PASS] SELECT danh sach MOMON: " + result.AsList().Count + " dong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach MOMON: " + ex.Message + "\n");
            }
        }

        // Kiểm tra Select theo vai trò
        private async Task TestSelectByRole()
        {
            try
            {
                var vaiTros = await _momonService.CheckRole(_username); // Lấy danh sách vai trò
                IEnumerable<MOMON> result;
                Console.WriteLine($"Vai tro cua {_username}: {string.Join(", ", vaiTros ?? new List<string>())}"); // Log debug

                if (vaiTros.Contains("ROLE_GV"))
                    result = await _controller.GetPhanCongCaNhan(_username);
                else if (vaiTros.Contains("ROLE_NVPDT"))
                    result = await _controller.GetPhanCongHienTai(_username);
                else if (vaiTros.Contains("ROLE_TRGDV"))
                    result = await _controller.GetPhanCongDonVi(_username);
                else if (vaiTros.Contains("ROLE_SV"))
                    result = await _controller.GetPhanCongKhoa(_username);
                else
                    throw new InvalidDataError("Vai trò không hợp lệ hoặc không được hỗ trợ.");


                if (result.Any())
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo vai tro:");
                    foreach (var momon in result)
                    {
                        Console.WriteLine($"MAMM: {momon.MAMM}, MAHP: {momon.MAHP}, MAGV: {momon.MAGV}, HK: {momon.HK}, NAM: {momon.NAM}");
                    }
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo vai tro: Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT MOMON theo vai tro: " + ex.Message + "\n");
            }
        }

        // Kiểm tra Update/Insert/Delete (chỉ cho ROLE_NVPDT)
        private async Task TestUpdateOrInsertOrDelete()
        {
            try
            {
                var vaiTros = await _momonService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_NVPDT"))
                {
                    var momon = new MOMON { MAMM = "MM0017", MAHP = "HP004", MAGV = "GV001", HK = "3", NAM = "2025" };
                    var ok = await _controller.InsertPhanCong(_username, momon);
                    Console.WriteLine(ok ? "[PASS] INSERT MOMON\n" : "[FAIL] INSERT MOMON khong thanh cong\n");

                    momon.MAHP = "HP003";
                    ok = await _controller.UpdatePhanCong(_username, momon);
                    Console.WriteLine(ok ? "[PASS] UPDATE MOMON\n" : "[FAIL] UPDATE MOMON khong thanh cong\n");

                    ok = await _controller.DeletePhanCong(_username, "MM0017");
                    Console.WriteLine(ok ? "[PASS] DELETE MOMON\n" : "[FAIL] DELETE MOMON khong thanh cong\n");
                }
                else
                {
                    Console.WriteLine("[FAIL] Khong co quyen Update/Insert/Delete\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] Update/Insert/Delete: " + ex.Message + "\n");
            }
        }

        // Kiểm tra Update/Insert/Delete cho dữ liệu khác (thất bại với các role khác)
        private async Task TestUpdateOrInsertOrDeleteOther()
        {
            try
            {
                var vaiTros = await _momonService.CheckRole(_username);
                if (vaiTros.Contains("ROLE_NVPDT"))
                {
                    var momon = new MOMON { MAMM = "MM004", MAHP = "HP003", MAGV = "GV001", HK = "1", NAM = "2024" };
                    var ok = await _controller.UpdatePhanCong(_username, momon);
                    Console.WriteLine(ok ? "[FAIL] Cap nhat MOMON trong hoc ky khac khong thanh cong\n" : "[PASS] Cap nhat MOMON khac bi tu choi\n");
                }
                else
                {
                    Console.WriteLine("[FAIL] Khong co quyen cap nhat MOMON khac\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[PASS] Cap nhat MOMON khac bi tu choi: " + ex.Message + "\n");
            }
        }
    }
}