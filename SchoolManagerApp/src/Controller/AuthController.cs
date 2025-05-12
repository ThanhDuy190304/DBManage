using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagerApp.src.Controller
{
    public class AuthController
    {
        private DatabaseService _dbService;

        public bool Login(string username, string password)
        {
            try
            {
                _dbService = DatabaseService.GetInstance(username, password);
                //_dbService.OpenConnection();
                _dbService.ExecuteSetUserRole();
                return true;
            }
            catch (BaseError)
            {
                throw; // Ném lại lỗi custom
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định: " + ex.Message);
            }
        }


        public bool IsCurrentUserDba()
        {
            if (_dbService == null)
            {
                throw new ServerError("Chưa đăng nhập.");
            }

            return _dbService.IsUserDBA();
        }


        public void Logout()
        {
            _dbService?.CloseConnection();
            _dbService = null;
        }
    }
}