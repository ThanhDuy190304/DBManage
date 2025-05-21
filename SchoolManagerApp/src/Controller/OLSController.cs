using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;

namespace SchoolManagerApp.src.Controller
{
    public class OLSController
    {
        private readonly OLSService _olsService;

        // Khởi tạo controller với service
        public OLSController()
        {
            _olsService = new OLSService();
        }

        // 1. Lấy danh sách sinh viên
        public async Task<IEnumerable<ThongBao>> GetNotify()
            {
                try
                {
                    return await _olsService.GetNotify();
                }
                catch (Exception ex)
                {
                    throw new Exception("Khong the lay thong bao cua user: " + ex.Message);
                }
            }
        }
}
