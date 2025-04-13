using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagerApp.src.Service;
using System.Data;
using System.Windows.Forms;


namespace SchoolManagerApp.src.Controllers
{
    public class Form1Controller
    {
        private DatabaseService _databaseService;

        public Form1Controller()
        {
            _databaseService = new DatabaseService();
        }

        public void LoadData(DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM DONVI";
                DataTable dataTable = _databaseService.ExecuteQuery(query);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInner Exception: " + ex.InnerException?.Message);
            }
        }
    }
}
