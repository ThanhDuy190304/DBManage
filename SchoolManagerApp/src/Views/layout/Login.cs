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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            if (username == "admin" && password == "123456")
            {
                ErrorNotiticationLabel.Visible = false;
                this.Hide();
                new Main().Show();
            }
            else
            {
                ErrorNotiticationLabel.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                ErrorNotiticationLabel.Visible = true;
            }
        }

     
    }
}
