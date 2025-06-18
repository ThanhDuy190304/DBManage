using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Models;
/*
SYNOPSIS: Module OLSService cung cấp các dịch vụ liên quan đến hệ thống OLS (Online Learning System).
FUNCTIONS:
- GetNotify(): Lấy danh sách thông báo từ hệ thống.
GLOBAL VARIABLES:
- Kế thừa _dbService từ BaseService để thao tác với database.
*/
namespace SchoolManagerApp.src.Service
{
    internal class OLSService : BaseService
    {
        // Lấy thông báo
        public async Task<IEnumerable<ThongBao>> GetNotify()
        {
            try
            {
                string query = "SELECT * FROM OLS_ADMIN.THONGBAO";
                return await _dbService.Connection.QueryAsync<ThongBao>(query);
            }
            catch (OracleException ex)
            {
                throw new Exception("Khong the lay thong bao cua user: " + ex.Message);
            }
        }
    }
}

