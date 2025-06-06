﻿using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.pages;
using SchoolManagerApp.src.Views.pages.DBA;
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
    public partial class DBAsidebar : UserControl
    {
        private int expandedWidth = 250;
        private int collapsedWidth = 40;
        public event Action OnLogout;
        public Action<UserControl> OnPageChange;
        public event Action<bool> OnSidebarCollapsedChanged;

        public DBAsidebar()
        {
            InitializeComponent();
        }


        private void DBA_Text(object sender, EventArgs e)
        {

        }

        private void RolesPage_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new RolesPage());
        }

        private void UsersPage_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new UsersPage());
        }
        private void PolicyPage_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new PolicyPage());

        }
        private void AuditPage_Click(object sender, EventArgs e)
        {
            OnPageChange?.Invoke(new AuditPage());
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


        private void Logout_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
        }

       
    }
}
