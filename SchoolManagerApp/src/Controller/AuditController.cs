using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

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
            try
            {
                return await _auditService.GetStandardAuditDataAsync();
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<IEnumerable<FGAAuditRecord>> GetFGAAuditDataAsync(string policyName = null)
        {
            try
            {
                return await _auditService.GetFGAAuditDataAsync(policyName);
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<IEnumerable<DBA_AUDIT_SESSION>> GetStandardAuditSessions()
        {
            try
            {
                return await _auditService.GetStandardAuditSessions();
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}
