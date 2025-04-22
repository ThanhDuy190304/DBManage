using SchoolManagerApp.src.Views.partials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using SchoolManagerApp.src.Views;
using SchoolManagerApp.src.Controller;

namespace SchoolManagerApp.src.Views.layout
{
    public partial class Main : Form
    {
        private AuthController _authController;

        public Main()
        {
            InitializeComponent();
            sidebar.OnLogout += HandleLogOut;
            LoadPage(new RolesPage());
        }

        public void SetAuthController(AuthController authController)
        {
            _authController = authController;
        }

        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void HandleLogOut()
        {
            this.Hide();
            _authController.Logout();
            var loginForm = new Login();
            loginForm.SetAuthController(_authController);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var newMain = new Main();
                newMain.SetAuthController(_authController);
                newMain.Show();
            }
        }



    }
}
