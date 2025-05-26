using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    internal class SysDatabaseService
    {
        private static SysDatabaseService _instance;
        private static readonly object _lock = new object();
        private OracleConnection _connection;

        private SysDatabaseService(string username, string password)
        {
            string connectSQL = $"User Id={username};Password={password};Data Source=ORCL;TNS_ADMIN=C:\\app\\ASUS\\product\\21c\\homes\\OraDB21Home1\\network\\admin;DBA Privilege=SYSDBA";
            _connection = new OracleConnection(connectSQL);
        }

        public static SysDatabaseService GetInstance(string username, string password)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        var tempInstance = new SysDatabaseService(username, password);
                        tempInstance.OpenConnection();
                        _instance = tempInstance;
                    }
                }
            }
            return _instance;
        }

        private void OpenConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();

                    // Chuyển sang CDB$ROOT
                    using (var cmd = new OracleCommand(
                        "ALTER SESSION SET CONTAINER = CDB$ROOT",
                        _connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public OracleConnection Connection => _connection;
    }
}
