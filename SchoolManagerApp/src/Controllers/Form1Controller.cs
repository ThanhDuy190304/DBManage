using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Service;
using System.Data;
using System.Windows.Forms;


namespace SchoolManagerApp.src.Controllers
{
    public class Form1Controller
    {
        private readonly DatabaseService _db;

        public Form1Controller(string username, string password)
        {
            _db = new DatabaseService(username, password);
        }

        public bool Login() => _db.TestConnection();
    }
}
