using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.src.Controller
{
    public class AuditController
    {
        private readonly AuditService _auditService;

        public AuditController()
        {
            _auditService = new AuditService();
        }

        public async Task<IEnumerable<StandardAuditRecord>> GetStandardAuditDataAsync()
        {
            return await _auditService.GetStandardAuditDataAsync();
        }

        public async Task<IEnumerable<FGAAuditRecord>> GetFGAAuditDataAsync(string policyName = null)
        {
            return await _auditService.GetFGAAuditDataAsync(policyName);
        }
    
    }
}
