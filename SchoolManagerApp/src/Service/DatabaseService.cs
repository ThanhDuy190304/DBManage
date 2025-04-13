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
        private string _connectionString = "User Id=admin;Password=Admin123;Data Source=localhost:1521/QL_NoiBo";

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    OracleCommand cmd = new OracleCommand(query, connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query: " + ex.Message);
            }
        }
    }
}
