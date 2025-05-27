using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Controller
{
    public class PolicyController
    {
        private readonly PolicyService _policyService;

        public PolicyController()
        {
            _policyService = new PolicyService();
        }
        public async Task<IEnumerable<DBA_POLICIES>> GetVPDPoliciesByObjectName(string objectName)
        {
            try
            {
                var policies = await _policyService.GetVPDPoliciesByObjectName(objectName);
                return policies;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy VPD policies: " + ex.Message);
            }
        }
        public async Task SetVPDPolicyState(string objectSchema, string objectName, string policyName, bool enable)
        {
            try
            {
                await _policyService.SetVPDPolicyState(objectSchema, objectName, policyName, enable);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                string action = enable ? "kích hoạt" : "vô hiệu hóa";
                throw new ServerError($"Lỗi không xác định khi {action} VPD policy: " + ex.Message);
            }
        }

        public async Task<IEnumerable<DBA_AUDIT_POLICIES>> GetAuditPolicies()
        {
            try
            {
                var policies = await _policyService.GetAuditPolicies();
                return policies;
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy audit policies: " + ex.Message);
            }
        }

        public async Task DisableAuditPolicy(string objectSchema, string objectName, string policyName)
        {
            try
            {
                await _policyService.DisableAuditPolicy(objectSchema, objectName, policyName);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi vô hiệu hóa audit policy: " + ex.Message);
            }
        }

        public async Task EnableAuditPolicy(string objectSchema, string objectName, string policyName)
        {
            try
            {
                await _policyService.EnableAuditPolicy(objectSchema, objectName, policyName);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi kích hoạt audit policy: " + ex.Message);
            }
        }


    }
}
