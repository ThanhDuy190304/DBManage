using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SchoolManagerApp.src.Service
{
    public class DatabaseService
    {
        private string _connectionString;

        public DatabaseService(string username, string password)
        {
            _connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/QL_NoiBo";
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = new OracleConnection(_connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
