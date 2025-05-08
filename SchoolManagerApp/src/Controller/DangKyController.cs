using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class DangKyController
    {
        private readonly DangKyService _svService;

        // Khởi tạo controller với service
        public DangKyController(DatabaseService dbService)
        {
            _svService = new DangKyService(dbService);
        }

        public async Task<IEnumerable<DangKy>> GetPoint()
        {
            try
            {
                return await _svService.GetPoint();
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy danh sách điểm của sinh viên: " + ex.Message);
            }
        }

        public async Task<int> InsertHocPhan(string maSV, string maMM)
        {
            try
            {
                return await _svService.InsertHocPhan(maSV,maMM);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public async Task<int> DeleteHocPhan(string maSV, string maMM)
        {
            try
            {
                return await _svService.DeleteHocPhan(maSV, maMM);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }


        public async Task<int> UpdateHocPhan(string maSV, string maMM, double diemTH, double diemQT, double diemCK, double diemTK)
        {
            try
            {
                return await _svService.UpdateHocPhan(maSV, maMM, diemTH, diemQT, diemCK, diemTK);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        // Danh sách lớp giáo viên phụ trách
        public async Task<IEnumerable<MoMon>> GetListClass()
        {
            try
            {
                return await _svService.GetListClass();
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy danh sách điểm của sinh viên: " + ex.Message);
            }
        }
    }
}
