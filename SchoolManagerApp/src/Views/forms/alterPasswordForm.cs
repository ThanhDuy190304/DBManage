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
    public partial class alterPasswordForm : Form
    {
        private readonly Func<string, Task<bool>> onTurnOffAuthCallback;
        private readonly Func<string, string, Task<bool>> alterPasswordCallback;
        private string name;

        public alterPasswordForm(string name, Func<string, Task<bool>> onTurnOffAuth, Func<string, string, Task<bool>> alterPassword)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.onTurnOffAuthCallback = onTurnOffAuth;
            this.alterPasswordCallback = alterPassword;
            this.name = name;
        }

        private async void TurnOffAuthenticationByPass_Click(object sender, EventArgs e)
        {
            await this.onTurnOffAuthCallback(this.name);
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            string password = this.textPasswordBox.Texts;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await this.alterPasswordCallback(this.name, password);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ExitButton_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
