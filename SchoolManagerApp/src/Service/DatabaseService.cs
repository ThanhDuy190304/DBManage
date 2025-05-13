using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Ink;
using System.Data.Common;
using SchoolManagerApp.src.utils;
using Dapper;

namespace SchoolManagerApp.src.Service
{
    public class DatabaseService
    {

        private static DatabaseService _instance;
        private static readonly object _lock = new object();
        private OracleConnection _connection;

        private DatabaseService(string username, string password)
        {
            string connectSQL = $"User Id={username};Password={password};Data Source=localhost:1521/QL_NoiBo";
            _connection = new OracleConnection(connectSQL);
        }

        public static DatabaseService GetInstance(string username, string password)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        var tempInstance = new DatabaseService(username, password);
                        tempInstance.OpenConnection();
                        _instance = tempInstance;
                    }
                }
            }
            return _instance;
        }

        public void OpenConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    using (var command = _connection.CreateCommand())
                    {
                        command.CommandText = "BEGIN ADMIN.user_role_pkg.set_user_role; END;";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
        }

        public bool IsUserDBA()
        {
            string query = "SELECT COUNT(1) FROM SESSION_ROLES WHERE ROLE = 'DBA'";
            return _connection.ExecuteScalar<int>(query) > 0;
        }
        public bool IsUserNVCB()
        {
            string query = "SELECT COUNT(1) FROM SESSION_ROLES WHERE ROLE = 'ROLE_NVCB'";
            return _connection.ExecuteScalar<int>(query) > 0;
        }

        public bool IsUserSinhVien()
        {
            string query = "SELECT COUNT(1) FROM SESSION_ROLES WHERE ROLE = 'ROLE_SV'";
            return _connection.ExecuteScalar<int>(query) > 0;
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            _instance = null;
        }
        public void ExecuteSetUserRole()
        {
            try
            {
                OpenConnection();
                string query = "BEGIN ADMIN.user_role_pkg.set_user_role; END;";
                _connection.Execute(query);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi thủ tục: " + ex.Message);
                throw;
            }
        }
        public OracleConnection Connection => _connection;
    }
}