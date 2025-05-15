using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Dapper;
using System.Dynamic;

public class SinhVienTestSuite
{
    private readonly SinhVienController _controller;
    private readonly string _username;

    public SinhVienTestSuite(string username, string password)
    {
        _username = username;
        _controller = new SinhVienController();
    }

    public async Task RunAllTests()
    {
        Console.WriteLine("===== TEST CHO USER: " + _username + " =====\n");

        await TestSelectAll();
        await TestUpdateDiaChi();
        await TestUpdateTinhTrang();
        await TestUpdateInfoOfOtherStudent();
        await TestInsertSinhVien();
        await TestDeleteSinhVien();

        Console.WriteLine("===== KET THUC TEST =====\n");
    }

    private async Task TestSelectAll()//Full sin
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

    private async Task TestUpdateDiaChi()
    {
        try
        {
            dynamic fields = new ExpandoObject();
            fields.DCHI = "Dia chi moi dynamic";
            fields.DT = "0911222333";

            var ok = await _controller.UpdateSinhVien("SV001", fields);
            Console.WriteLine(ok ? "[PASS] UPDATE dynamic DCHI, DT\n" : "[FAIL] UPDATE dynamic DCHI, DT khong thanh cong\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[FAIL] UPDATE dynamic DCHI, DT: " + ex.Message + "\n");
        }
    }

    private async Task TestUpdateInfoOfOtherStudent()
    {
        {
            try
            {
                dynamic fields = new ExpandoObject();
                fields.DCHI = "Dia chi moi";
                fields.DT = "0911222333";

                var ok = await _controller.UpdateSinhVien("SV004", fields);
                Console.WriteLine(ok ? "[FAIL] Cap nhat SV khac thanh cong (sai)\n" : "[PASS] SV khong duoc sua SV khac\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[PASS] SV khong duoc sua SV khac: " + ex.Message + "\n");
            }
        }
    }

    private async Task TestUpdateTinhTrang()
    {
        try
        {
            dynamic fields = new ExpandoObject();
            fields.TINHTRANG = "Dang hoc";

            var ok = await _controller.UpdateSinhVien("SV001", fields);
            Console.WriteLine(ok ? "[PASS] UPDATE TINHTRANG thanh cong\n" : "[FAIL] UPDATE TINHTRANG khong thanh cong\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[FAIL] UPDATE TINHTRANG: " + ex.Message + "\n");
        }
    }

    private async Task TestInsertSinhVien()
    {
        try
        {
            var sv = new SINHVIEN
            {
                MASV = "SV_TEST",
                HOTEN = "Sinh Vien Test",
                DCHI = "Test DC",
                DT = "0909090909",
                KHOA = "HOA",
                TINHTRANG = null
            };

            var ok = await _controller.Insert(sv);

            Console.WriteLine(ok ? "[PASS] INSERT sinh vien\n" : "[FAIL] INSERT sinh vien khong thanh cong\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[FAIL] INSERT sinh vien: " + ex.Message + "\n");
        }
    }


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
