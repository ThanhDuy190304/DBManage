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
        private readonly DangKyService _dkService;

        // Khởi tạo controller với service
        public DangKyController()
        {
            _dkService = new DangKyService();
        }

        public async Task<IEnumerable<DANGKY>> GetPoint()
        {
            try
            {
                return await _dkService.GetPoint();
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
                return await _dkService.InsertHocPhan(maSV,maMM);
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
                return await _dkService.DeleteHocPhan(maSV, maMM);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        // update diem của NV PKT
        public async Task<int> UpdateHocPhan(string maSV, string maMM, double? diemTH, double? diemQT, double? diemCK, double? diemTK)
        {
            try
            {
                return await _dkService.UpdateHocPhan(maSV, maMM, diemTH, diemQT, diemCK, diemTK);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        // Danh sách sinh viên giáo viên phụ trách
        public async Task<IEnumerable<DANGKY>> GetListStudentOfGV(string mamm)
        {
            try
            {
                return await _dkService.GetListStudentOfGV(mamm);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy danh sách sinh viên của giáo viên phụ trách: " + ex.Message);
            }
        }

        // NV PDT update sinh viên
        public async Task<int> UpdateSV(string maSV, string maMM, string newMAMM)
        {
            try
            {
                return await _dkService.UpdateSV(maSV, maMM, newMAMM);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }
    }
}
