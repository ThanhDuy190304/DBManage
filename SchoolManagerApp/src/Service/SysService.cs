using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    public class SysService
    {
        private readonly SysDatabaseService _sysDbService;

        public SysService(string sysUsername, string sysPassword)
        {
            _sysDbService = SysDatabaseService.GetInstance(sysUsername, sysPassword);
        }

        public async Task<bool> EnableAuditAsync()
        {
            try
            {
                await ExecuteSysCommandAsync("ALTER SYSTEM SET audit_trail=DB,EXTENDED SCOPE=SPFILE");
                //await RestartDatabaseAsync();
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error enabling audit: {ex.Message} (Error Code: {ex.Number})");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error enabling audit: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DisableAuditAsync()
        {
            try
            {
                await ExecuteSysCommandAsync("ALTER SYSTEM SET audit_trail=NONE SCOPE=SPFILE");
                //await RestartDatabaseAsync();
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error disabling audit: {ex.Message} (Error Code: {ex.Number})");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error disabling audit: {ex.Message}");
                return false;
            }
        }

        private async Task ExecuteSysCommandAsync(string commandText)
        {
            using (var cmd = new OracleCommand(commandText, _sysDbService.Connection))
            {
                cmd.CommandType = CommandType.Text;
                await cmd.ExecuteNonQueryAsync();
            }
        }

        private async Task RestartDatabaseAsync()
        {
            await ExecuteSysCommandAsync("SHUTDOWN IMMEDIATE;");
            await ExecuteSysCommandAsync("STARTUP;");
        }
    }
}