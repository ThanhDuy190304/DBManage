using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class NhanVienController
    {
        private readonly NhanVienService _nhanVienService;

        public NhanVienController(DatabaseService dbService)
        {
            _nhanVienService = new NhanVienService(dbService);
        }

        // Chức năng cho RL_NVCB
        public async Task<NHANVIEN> GETPersonalInformationForNVCB(string username)
        {
            try
            {
                return await _nhanVienService.GETPersonalInformationForNVCB(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> UpdatePhoneNumberForNVCB(string username, string newDT)
        {
            try
            {
                return await _nhanVienService.UpdatePhoneNumberForNVCB(username, newDT);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Chức năng cho RL_TRGDV
       

        public async Task<IEnumerable<NHANVIEN>> GETEmployeesInManagedUnitTRGDV(string username)
        {
            try
            {
                return await _nhanVienService.GETEmployeesInManagedUnitTRGDV(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        // Chức năng cho RL_NV_TCHC
        public async Task<IEnumerable<NHANVIEN>> GETAllEmployees(string username)
        {
            try
            {
                return await _nhanVienService.GETAllEmployees(username);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> InsertNewEmployee(string username, NHANVIEN nhanVien)
        {
            try
            {
                return await _nhanVienService.InsertNewEmployee(username, nhanVien);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> UpdateEmployeeDetails(string username, string manv, dynamic fieldsToUpdate)
        {
            try
            {
                return await _nhanVienService.UpdateEmployeeDetails(username, manv, fieldsToUpdate);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }

        public async Task<bool> DeleteEmployee(string username, string maNv)
        {
            try
            {
                return await _nhanVienService.DeleteEmployee(username, maNv);
            }
            catch (BaseError)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}