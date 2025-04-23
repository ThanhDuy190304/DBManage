using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.partials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views
{
    public partial class UsersPage : UserControl
    {

        private UserController _userController = new UserController();
        public UsersPage()
        {
            InitializeComponent();
        }

        private async Task<bool> UpdatePassword(string userName, string password)
        {
            bool result = false;
            try
            {
                result = await _userController.UpdateUserPassword(userName, password);
                if (result)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật mật khẩu: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            async Task<bool> HandleCreateRole(string userName, string password)
            {
                try
                {
                    bool result = await _userController.CreateUser(userName, password);
                    if (result)
                    {
                        MessageBox.Show("User đã được tạo thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo user.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo user: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            createForm createARoleForm = new createForm("Tạo 1 user", HandleCreateRole);
            createARoleForm.ShowDialog();
        }

      
    }
}
