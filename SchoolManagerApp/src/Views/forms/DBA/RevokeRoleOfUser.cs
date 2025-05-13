using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolManagerApp.src.Views.forms
{
    public partial class RevokeRoleOfUser : Form
    {
        private string _userName;
        public delegate void RevokeRoleActionHandler(string username, string rolename);
        public event RevokeRoleActionHandler OnRevokeRoleClicked;
        public RevokeRoleOfUser(string username)
        {
            this._userName = username;
            InitializeComponent();
            this.confirmButton.Click += (s, e) =>
               OnRevokeRoleClicked?.Invoke(this._userName, this.RoleTextBox.Texts);
        }

      
    }
}
