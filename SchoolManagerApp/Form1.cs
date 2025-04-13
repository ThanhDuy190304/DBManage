using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.Controllers;

namespace SchoolManagerApp
{
    public partial class Form1 : Form
    {
        private Form1Controller _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new Form1Controller();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            _controller.LoadData(dataGridView1);
        }
    }
}
