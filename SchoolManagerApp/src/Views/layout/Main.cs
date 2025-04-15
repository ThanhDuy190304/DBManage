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

namespace SchoolManagerApp.src.Views.layout
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadPage(new RolesPage());
        }

        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void sidebar_Load(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
