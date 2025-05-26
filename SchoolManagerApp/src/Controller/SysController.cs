using System.Threading.Tasks;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.src.Controller
{
    public class SysController
    {
        private readonly SysService _sysService;

        public SysController(string sysUsername, string sysPassword)
        {
            _sysService = new SysService(sysUsername, sysPassword);
        }

        public async Task<bool> EnableAuditAsync()
        {
            return await _sysService.EnableAuditAsync();
        }

        public async Task<bool> DisableAuditAsync()
        {
            return await _sysService.DisableAuditAsync();
        }
    }
}