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

        public string GetCurrentBasicRole()
        {
            if (_dbService.IsUserDBA())
            {
                return "DBA";
            }

            else if (_dbService.IsUserSinhVien())
            {
                return "ROLE_SV";
            }
            else if (_dbService.IsUserNVCB())
            {
                return "ROLE_NVCB";
            }            
            return null;            
        }

        public string GetExtended_NVCB_Role()
        {
            return _dbService.GetExtended_NVCB_Role();
        }

        public string GetUserName()
        {
            return _dbService.GetUserName();
        }

        public void Logout()
        {
            _dbService?.CloseConnection();
            _dbService = null;
        }
    }
}