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

        public NhanVienController( )
        {
            _nhanVienService = new NhanVienService();
        }

        // Chức năng cho RL_NVCB
        public async Task<NHANVIEN> GETPersonalInformationForNVCB()
        {
            try
            {
                return await _nhanVienService.GETPersonalInformationForNVCB();
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

        public async Task<bool> UpdatePhoneNumberForNVCB( string newDT)
        {
            try
            {
                return await _nhanVienService.UpdatePhoneNumberForNVCB( newDT);
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
       

        public async Task<IEnumerable<NHANVIEN>> GETEmployeesInManagedUnitTRGDV()
        {
            try
            {
                return await _nhanVienService.GETEmployeesInManagedUnitTRGDV();
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
        public async Task<IEnumerable<NHANVIEN>> GETAllEmployees()
        {
            try
            {
                return await _nhanVienService.GETAllEmployees();
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

        public async Task<bool> InsertNewEmployee( NHANVIEN nhanVien)
        {
            try
            {
                return await _nhanVienService.InsertNewEmployee( nhanVien);
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

        public async Task<bool> UpdateEmployeeDetails( string manv, dynamic fieldsToUpdate)
        {
            try
            {
                return await _nhanVienService.UpdateEmployeeDetails( manv, fieldsToUpdate);
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

        public async Task<bool> DeleteEmployee( string maNv)
        {
            try
            {
                return await _nhanVienService.DeleteEmployee( maNv);
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