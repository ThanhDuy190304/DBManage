using System;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagerApp.src.Test
{
    internal class TestAudit
    {
        private readonly AuditController _controller;
        public TestAudit(string username, string password)
        {
            var dbService = DatabaseService.GetInstance(username, password); 
            _controller = new AuditController(); 
        }

        public async Task RunAllAuditTests()
        {
            Console.WriteLine("===== BAT DAU TEST AUDIT =====");
            //admin
            await TestStandardAudit();
            await TestFGAAuditWithPolicy();
            await TestFGAAuditWithoutPolicy();

            Console.WriteLine("===== KET THUC TEST AUDIT =====");
        }
        // Test Standard Audit
        private async Task TestStandardAudit()
        {
            try
            {
                var result = await _controller.GetStandardAuditDataAsync();

                Console.WriteLine("[TEST] Standard Audit Records:");
                Console.WriteLine($"So luong ban ghi: {result?.Count() ?? 0}");

                if (result != null && result.Any())
                {
                    foreach (var record in result.Take(3)) // Hiển thị 3 bản ghi đầu
                    {
                        Console.WriteLine($"[{record.TIMESTAMP}] {record.USERNAME} - {record.ACTION_NAME} - {record.SQL_TEXT?.Substring(0, Math.Min(50, (record.SQL_TEXT ?? "").Length))}...");
                    }
                }
                Console.WriteLine("[PASS] Test Standard Audit\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Test Standard Audit: {ex.Message}\n");
            }
        }

        // Test FGA Audit với policy cụ thể
        private async Task TestFGAAuditWithPolicy()
        {
            try
            {
                // Thay thế bằng policy name thực tế của bạn
                const string testPolicy = "AUDIT_LUONG_PHUCAP_NON_TCHC";

                var result = await _controller.GetFGAAuditDataAsync(testPolicy);

                Console.WriteLine($"[TEST] FGA Audit (Policy: {testPolicy}):");
                Console.WriteLine($"So luong ban ghi: {result?.Count() ?? 0}");

                if (result != null && result.Any())
                {
                    foreach (var record in result.Take(10))
                    {
                        Console.WriteLine($"[{record.TIMESTAMP}] {record.DB_USER} - {record.POLICY_NAME} - {(record.SQL_TEXT ?? "").Substring(0, Math.Min(50, (record.SQL_TEXT ?? "").Length))}");
                    }
                }
                Console.WriteLine("[PASS] Test FGA Audit With Policy\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Test FGA Audit With Policy: {ex.Message}\n");
            }
        }

        // Test FGA Audit không chỉ định policy
        private async Task TestFGAAuditWithoutPolicy()
        {
            try
            {
                var result = await _controller.GetFGAAuditDataAsync();

                Console.WriteLine("[TEST] FGA Audit (All Policies):");
                Console.WriteLine($"So luong ban ghi: {result?.Count() ?? 0}");

                if (result != null && result.Any())
                {
                    foreach (var record in result.Take(10))
                    {
                        Console.WriteLine($"[{record.TIMESTAMP}] {record.DB_USER} - {record.POLICY_NAME} - {(record.SQL_TEXT ?? "").Substring(0, Math.Min(50, (record.SQL_TEXT ?? "").Length))}");
                    }
                }
                Console.WriteLine("[PASS] Test FGA Audit Without Policy\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Test FGA Audit Without Policy: {ex.Message}\n");
            }
        }
    }
}