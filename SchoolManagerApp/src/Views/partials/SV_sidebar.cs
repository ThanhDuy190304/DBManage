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
    public partial class SV_sidebar : UserControl
    {
        private int expandedWidth = 280;
        private int collapsedWidth = 40;
        public event Action OnLogout;
        public Action<UserControl> OnPageChange;
        public event Action<bool> OnSidebarCollapsedChanged;
        public SV_sidebar()
        {
            InitializeComponent();
        }
        public void setStuCodeLabel(string stuCode)
        {
            this.StudentCode_Label.Text = stuCode;
        }
        private void rightArrow_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
            this.BackColor = Color.WhiteSmoke;
            this.Width = expandedWidth;
            rightArrow.Visible = false;
            OnSidebarCollapsedChanged?.Invoke(false);
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
            OnSidebarCollapsedChanged?.Invoke(true);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
        }

        private void ProfileTab_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.SV.ProfilePage());
        }

        private void CoursesTab_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.SV.CoursesPage());
        }

        private void RegistrationsTab_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.SV.RegistrationsPage());
        }

        private void NotificationTab_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.SharedPage.NotificationPage());
        }
    }
}
