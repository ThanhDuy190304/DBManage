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
    public partial class NVCB_sidebar : UserControl
    {
        private int expandedWidth = 250;
        private int collapsedWidth = 40;
        public event Action OnLogout;
        public Action<UserControl> OnPageChange;
        public event Action<bool> OnSidebarCollapsedChanged;

        public NVCB_sidebar()
        {
            InitializeComponent();
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

        private void ProfilePage_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.NVCB.ProfilePage());
        }
        private void EmpsButton_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.NVCB.EmpsPage());

        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.NVCB.CoursesPage());
        }
        private void StudentsButton_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.NVCB.StudentsPage());

        }
        private void RegistrationsButton_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new pages.NVCB.RegistrationsPage());

        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
        }

      
    }
}
