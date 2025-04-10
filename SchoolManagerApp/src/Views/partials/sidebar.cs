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
    public partial class sidebar : UserControl
    {
        private int expandedWidth = 250;
        private int collapsedWidth = 40;
        public sidebar()
        {
            InitializeComponent();
        }


        private void DBA_Text(object sender, EventArgs e)
        {

        }

        private void RolesPage_Click(object sender, EventArgs e)
        {

        }

        private void UsersPage_Click(object sender, EventArgs e)
        {

        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control != rightArrow)
                {
                    control.Visible = false;
                }
            }
            this.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.Width = collapsedWidth;
            rightArrow.BringToFront();
            rightArrow.Visible = true;
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
            this.BackColor = Color.Black;
            this.Width = expandedWidth;
            rightArrow.Visible = false;
        }
    }
}
