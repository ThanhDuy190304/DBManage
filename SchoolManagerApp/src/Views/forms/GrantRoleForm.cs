using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms
{
    public partial class GrantRoleForm : Form
    {

        public delegate void GrantRoleActionHandler(
            string username,
            string rolename,
            bool withGrantOption
            );
        public event GrantRoleActionHandler OnGrantRoleClicked;
        private string _username;

        public GrantRoleForm(string userName)
        {
            this._username = userName;
            InitializeComponent();
            this.confirmButton.Click += (s, e) =>
            {
                OnGrantRoleClicked.Invoke(this._username, this.RoleTextBox.Texts, this.WithGrantOptioncheckBox.Checked);
            };
        }

        
    }
}
