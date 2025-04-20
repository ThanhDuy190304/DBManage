using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.partials
{
    public partial class createARoleForm : Form

    {
        private readonly RoleController _roleController;
        public createARoleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _roleController = new RoleController();
        }

        private async  void createARole_Load(object sender, EventArgs e)
        {
            var roles = await _roleController.GetAll();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string roleName = ctTextBox1.Texts;  

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên role!");
                return;
            }

            try
            {
                bool result = await _roleController.CreateRole(roleName);

                if (result)
                {
                    MessageBox.Show("Role đã được tạo thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể tạo role.");

                }
                this.FindForm()?.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo role: " + ex.Message);
            }

        }

        private void iconExitButtot_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                iconExitButtot_Click(null, null); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
