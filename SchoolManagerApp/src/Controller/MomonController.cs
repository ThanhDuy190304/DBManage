using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Controller
{
    public class MomonController
    {
        private readonly MomonService _momonService;

        public MomonController()
        {
            _momonService = new MomonService();
        }

        // Chức năng cho role_gv
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETPersonalTeachingAssignmentsForLecturer( )
        {
            try
            {
                return await _momonService.GETPersonalTeachingAssignmentsForLecturer();
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

        // Chức năng cho role_nvpdt
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETCurrentTeachingAssignments( )
        {
            try
            {
                return await _momonService.GETCurrentTeachingAssignments();
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

        public async Task<bool> InsertNewTeachingAssignment(  MOMON momon)
        {
            try
            {
                return await _momonService.InsertNewTeachingAssignment( momon);
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

        public async Task<bool> UpdateTeachingAssignmentDetails( string maMm, dynamic fieldsToUpdate)
        {
            try
            {
                return await _momonService.UpdateTeachingAssignmentDetails( maMm, fieldsToUpdate);
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

        public async Task<bool> DeleteTeachingAssignment(  string maMm)
        {
            try
            {
                return await _momonService.DeleteTeachingAssignment( maMm);
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

        // Chức năng cho role_trgdv
        public async Task<IEnumerable<MOMON_HOCPHAN>> GETTeachingAssignmentsInManagedUnit( )
        {
            try
            {
                return await _momonService.GETTeachingAssignmentsInManagedUnit();
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

        // Chức năng cho role_sv
        public async Task<IEnumerable<MOMON>> GETTeachingAssignmentsForDepartment( )
        {
            try
            {
                return await _momonService.GETTeachingAssignmentsForDepartment();
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