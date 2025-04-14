using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.partials
{
    public partial class createARoleForm : Form
    {
        public createARoleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void createARole_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void iconExitButtot_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                iconExitButtot_Click(null, null); // Gọi hàm đóng
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
