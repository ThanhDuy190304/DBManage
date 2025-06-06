﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using Dapper;

namespace SchoolManagerApp.src.Test
{
    public class TestCau4
    {
        private readonly DangKyController _controller;
        private readonly SinhVienController _controllerSV;

     
        public TestCau4(string username, string password)
        {
            _controller = new DangKyController(); // truyền vào đây
            _controllerSV = new SinhVienController();
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + " =====\n");
            // SV001 123
            //await TestSelectPoint();

            // NV001 123
            //await TestGetClass();

            // NV002 123
            //await TestUpdatePoint();

            // NV001 123
            //await TestGetListStudentOfGV();

            // NVPDT: NV012 123
            await TestUpdateSV();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        // Kiểm tra Select tất cả điểm sinh viên
        private async Task TestSelectPoint()
        {
            try
            {
                var result = await _controller.GetPoint();
                foreach (var item in result)
                {
                    Console.WriteLine($"MASV: {item.MASV}, MAMM: {item.MAMM}, DIEMTH: {item.DIEMTH}, DIEMQT: {item.DIEMQT}, DIEMCK: {item.DIEMCK}, DIEMTK: {item.DIEMTK} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach SV: " + ex.Message + "\n");
            }
        }

        // NVPKT update điểm của sinh viên

        private async Task TestUpdatePoint()
        {
            try
            {
                var result = await _controller.UpdateHocPhan("SV001", "MM001", 9.0, null, null, null);
                Console.WriteLine("[SUCCESS] UPDATE diem thanh cong: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE diem: " + ex.Message + "\n");
            }
        }

        // Xem danh sách sinh viên
        private async Task TestGetSinhVIen()
        {
            try
            {
                var result = await _controllerSV.GetAll();
                foreach (var item in result)
                {
                    Console.WriteLine($"MASV: {item.MASV}, HOTEN: {item.HOTEN}, DCHI: {item.DCHI}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach SV: " + ex.Message + "\n");
            }
        }

        // Danh sách sinh viên giáo viên phụ trách
        private async Task TestGetListStudentOfGV()
        {
            try
            {
                var result = await _controller.GetListStudentOfGV("MM001");
                foreach (var item in result)
                {
                    Console.WriteLine($"MASV: {item.MASV}, MAMM: {item.MAMM}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach SV cua Gv phu trach: " + ex.Message + "\n");
            }
        }

        // Test update thông tin đăng kí của sinh viên
        private async Task TestUpdateSV()
        {
            try
            {
                var result = await _controller.UpdateSV("SV005", "MM002", "MM003");
                Console.WriteLine("[SUCCESS] UPDATE du lieu thanh cong: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] UPDATE du lieu: " + ex.Message + "\n");
            }
        }
    }
}
