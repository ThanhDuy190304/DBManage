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
        private readonly RoleController roleController;
        public createARoleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            roleController = new RoleController();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string roleName = ctTextBox1.Texts;  

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên role", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool result = await roleController.CreateRole(roleName);
                if (result)
                {
                    MessageBox.Show("Role đã được tạo thành công.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể tạo role.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo role: {ex.Message}", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconExitButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                iconExitButton_Click(null, null); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
