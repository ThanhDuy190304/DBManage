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
    public partial class DBAMain : BaseMain
    {
        public DBAMain()
        {
            InitializeComponent();
            sidebar.OnLogout += HandleLogOut;
            sidebar.OnPageChange = LoadPage;
            sidebar.OnSidebarCollapsedChanged += HandleSidebarResize;
            LoadPage(new RolesPage());
        }

     
        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void HandleLogOut()
        {
            LogOut();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LogOut();
        }

        private void HandleSidebarResize(bool isCollapsed)
        {
            int sidebarWidth = isCollapsed ? 40 : 250;
            contentPanel.Location = new Point(sidebarWidth, 0);
            contentPanel.Width = this.ClientSize.Width - sidebarWidth;
        }
    }
}
