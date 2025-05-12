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
    internal class TestMomonController
    {
        private readonly MomonController _controller;
        private readonly string _username;
        private readonly MomonService _momonService; // Thêm tham chiếu đến MomonService

        public TestMomonController(string username, string password)
        {
            _username = username;
             var dbService = DatabaseService.GetInstance(username, password);
            dbService.OpenConnection();
            _controller = new MomonController(dbService);
            _momonService = new MomonService(dbService); // Khởi tạo MomonService
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + _username + " =====\n");
            //GV
            await TestSelectForGV();
            //TRGDV
            await TestSelectForTRGDV();
            //SV
            await TestSelectForSinhVien();
            //NVPDT
            await TestSelectForNVPDT();
            await TestUpdateOrInsertOrDelete();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }



        private async Task TestSelectForGV()
        {
            try
            {
                var resultCaNhan = await _controller.GETPersonalTeachingAssignmentsForLecturer(_username);
                if (resultCaNhan.Any())
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GETPersonalTeachingAssignmentsForLecturer (GV):");
                    foreach (var momon in resultCaNhan)
                    {
                        Console.WriteLine($"MAMM: {momon.MAMM}, MAHP: {momon.MAHP}, MAGV: {momon.MAGV}, HK: {momon.HK}, NAM: {momon.NAM}");
                    }
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GETPersonalTeachingAssignmentsForLecturer(GV): Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT MOMON theo vai tro (GV): " + ex.Message + "\n");
            }
        }

        private async Task TestSelectForNVPDT()
        {
            try
            {
                var resultHienTai = await _controller.GETCurrentTeachingAssignments(_username);
                if (resultHienTai.Any())
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GETCurrentTeachingAssignments(ROLE_NVPDT):");
                    foreach (var momon in resultHienTai)
                    {
                        Console.WriteLine($"MAMM: {momon.MAMM}, MAHP: {momon.MAHP}, MAGV: {momon.MAGV}, HK: {momon.HK}, NAM: {momon.NAM}");
                    }
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GETCurrentTeachingAssignments(ROLE_NVPDT): Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT MOMON theo vai tro (ROLE_NVPDT): " + ex.Message + "\n");
            }
        }

        private async Task TestSelectForTRGDV()
        {
            try
            {
                var resultDonVi = await _controller.GETTeachingAssignmentsInManagedUnit(_username);
                if (resultDonVi.Any())
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GetPhanCongDonVi (TRGDV):");
                    foreach (var momon in resultDonVi)
                    {
                        Console.WriteLine($"MAMM: {momon.MAMM}, MAHP: {momon.MAHP}, MAGV: {momon.MAGV}, HK: {momon.HK}, NAM: {momon.NAM}");
                    }
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GetPhanCongDonVi(TRGDV): Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT MOMON theo vai tro (TRGDV): " + ex.Message + "\n");
            }
        }

        private async Task TestSelectForSinhVien()
        {
            try
            {
                var resultKhoa = await _controller.GETTeachingAssignmentsForDepartment(_username);
                if (resultKhoa.Any())
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GetPhanCongKhoa(SINHVIEN):");
                    foreach (var momon in resultKhoa)
                    {
                        Console.WriteLine($"MAMM: {momon.MAMM}, MAHP: {momon.MAHP}, MAGV: {momon.MAGV}, HK: {momon.HK}, NAM: {momon.NAM}");
                    }
                }
                else
                {
                    Console.WriteLine("[PASS] SELECT MOMON theo GetPhanCongKhoa(SINHVIEN): Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT MOMON theo vai tro (SINHVIEN): " + ex.Message + "\n");
            }
        }

        private async Task TestUpdateOrInsertOrDelete()
        {
            try
            {
                var momon = new MOMON { MAMM = "MM0016", MAHP = "HP004", MAGV = "NV001", HK = "3", NAM = "2025" };
                var ok = await _controller.InsertNewTeachingAssignment(_username, momon);
                Console.WriteLine(ok ? "[PASS] INSERT MOMON\n" : "[FAIL] INSERT MOMON khong thanh cong\n");

                // Cập nhật 1 trường (MAHP)
                dynamic updateFields1 = new ExpandoObject();
                updateFields1.MAHP = "HP003";
                ok = await _controller.UpdateTeachingAssignmentDetails(_username, "MM0016", updateFields1);
                Console.WriteLine(ok ? "[PASS] UPDATE MOMON (MAHP)\n" : "[FAIL] UPDATE MOMON (MAHP) khong thanh cong\n");

                // Cập nhật 2 trường (MAGV và HK)
                dynamic updateFields2 = new ExpandoObject();
                updateFields2.MAGV = "NV002";
                updateFields2.HK = "2";
                ok = await _controller.UpdateTeachingAssignmentDetails(_username, "MM0016", updateFields2);
                Console.WriteLine(ok ? "[PASS] UPDATE MOMON (MAGV, HK)\n" : "[FAIL] UPDATE MOMON (MAGV, HK) khong thanh cong\n");

                ok = await _controller.DeleteTeachingAssignment(_username, "MM0016");
                Console.WriteLine(ok ? "[PASS] DELETE MOMON\n" : "[FAIL] DELETE MOMON khong thanh cong\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] Update/Insert/Delete: " + ex.Message + "\n");
            }
        }

        
    }
}