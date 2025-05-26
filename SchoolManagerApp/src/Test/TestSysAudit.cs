using System;
using System.Threading.Tasks;
using SchoolManagerApp.src.Controller;

namespace SchoolManagerApp.src.Test
{
    internal class TestSysAudit
    {
        private readonly SysController _sysController;

        public TestSysAudit(string sysUsername, string sysPassword)
        {
            _sysController = new SysController(sysUsername, sysPassword);
        }

        public async Task RunAllTests()
        {
            Console.WriteLine("===== SYSTEM AUDIT TEST =====");

            //await TestEnableAudit();
            await TestDisableAudit();

            Console.WriteLine("===== TEST COMPLETED =====");
        }

        private async Task TestEnableAudit()
        {
            try
            {
                var success = await _sysController.EnableAuditAsync();
                Console.WriteLine(success
                    ? "[PASS] Audit enabled successfully"
                    : "[FAIL] Failed to enable audit");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Enable Audit: {ex.Message}");
            }
        }

        private async Task TestDisableAudit()
        {
            try
            {
                var success = await _sysController.DisableAuditAsync();
                Console.WriteLine(success
                    ? "[PASS] Audit disabled successfully"
                    : "[FAIL] Failed to disable audit");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Disable Audit: {ex.Message}");
            }
        }
    }
}