using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.layout
{
    public class BaseMain : Form
    {
        protected AuthController _authController;
        public string CurrentUserRole { get; private set; } = "";

        public void SetAuthController(AuthController controller)
        {
            _authController = controller;
        }

        protected void LogOut()
        {
            _authController.Logout();
            this.Hide();
        }
    }
}
