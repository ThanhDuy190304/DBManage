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

        public MomonController(DatabaseService dbService)
        {
            _momonService = new MomonService(dbService);
        }

        // Chức năng cho role_gv
        public async Task<IEnumerable<MOMON>> GETPersonalTeachingAssignmentsForLecturer(string username)
        {
            try
            {
                return await _momonService.GETPersonalTeachingAssignmentsForLecturer(username);
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
        public async Task<IEnumerable<MOMON>> GETCurrentTeachingAssignments(string username)
        {
            try
            {
                return await _momonService.GETCurrentTeachingAssignments(username);
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

        public async Task<bool> InsertNewTeachingAssignment(string username, MOMON momon)
        {
            try
            {
                return await _momonService.InsertNewTeachingAssignment(username, momon);
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

        public async Task<bool> UpdateTeachingAssignmentDetails(string username, string maMm, dynamic fieldsToUpdate)
        {
            try
            {
                return await _momonService.UpdateTeachingAssignmentDetails(username, maMm, fieldsToUpdate);
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

        public async Task<bool> DeleteTeachingAssignment(string username, string maMm)
        {
            try
            {
                return await _momonService.DeleteTeachingAssignment(username, maMm);
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
        public async Task<IEnumerable<MOMON>> GETTeachingAssignmentsInManagedUnit(string username)
        {
            try
            {
                return await _momonService.GETTeachingAssignmentsInManagedUnit(username);
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
        public async Task<IEnumerable<MOMON>> GETTeachingAssignmentsForDepartment(string username)
        {
            try
            {
                return await _momonService.GETTeachingAssignmentsForDepartment(username);
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