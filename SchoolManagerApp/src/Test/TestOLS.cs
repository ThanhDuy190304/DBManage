using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.src.Test
{
    public class TestOLS
    {
        private readonly OLSController _controller;
        public TestOLS(string username, string password)
        {
            var dbService = DatabaseService.GetInstance(username, password); // tạo kết nối mới theo user
            _controller = new OLSController(); // truyền vào đây
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== TEST CHO USER: " + " =====\n");
            //SV001 123
            await TestGetNotification();

            Console.WriteLine("===== KET THUC TEST =====\n");
        }

        // Kiểm tra Select tất cả điểm sinh viên
        private async Task TestGetNotification()
        {
            try
            {
                var result = await _controller.GetNotify();
                foreach (var item in result)
                {
                    Console.WriteLine($"THONGBAO: {item.NOIDUNG} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FAIL] SELECT danh sach thong bao: " + ex.Message + "\n");
            }
        }
    }
}
