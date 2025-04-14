using SchoolManagerApp.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Controller
{
    internal class LoginController
    {

        private readonly DatabaseService _db;

        public LoginController(string username, string password)
        {
            _db = new DatabaseService(username, password);
        }

        public bool Login() => _db.TestConnection();
    }
}
