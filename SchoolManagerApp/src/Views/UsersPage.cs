using SchoolManagerApp.Controls;
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
using SchoolManagerApp.src.Views.forms;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views
{
    public partial class UsersPage : UserControl
    {

        private UserController _userController = new UserController();
        public UsersPage()
        {
            InitializeComponent();
            InitializeCustomTable();
            this.Padding = new Padding(12);
        }
        private async void InitializeCustomTable()
        {
            try
            {
                var users = await _userController.GetAll();

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "USERNAME", 150 },
                    { "ACCOUNT_STATUS", 150 },
                    { "ACCOUNT_CREATED", 180 },
                    { "SYSTEM_PRIVILEGES", 200 },
                    { "OBJECT_PRIVILEGES", 200 },
                    { "ROLES", 200 }
                };

                var data = users.Select(u => new string[]
                {
                    u.USERNAME,
                    u.ACCOUNT_STATUS,
                    u.ACCOUNT_CREATED.ToString("yyyy-MM-dd HH:mm:ss"),
                    u.SYSTEM_PRIVILEGES ?? "",
                    u.OBJECT_PRIVILEGES ?? "",
                    u.ROLES ?? ""
                }).ToList();

                var table = new CTTable(columnDefinitions, data);
                table.OnDeleteClicked += userName =>
                {
                    DeleteAUser(userName);
                };
                table.OnShieldClicked += userName =>
                {
                    ShowAlterPasswordForm(userName);
                };
                table.OnClipBoardCheckClicked += userName =>
                {
                    ShowPrivilegeManageForm(userName);
                };
                table.Dock = DockStyle.Fill;
                this.tablePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowAlterPasswordForm(string userName)
        {
            var alterPasswordForm = new alterPasswordForm(userName, null, UpdatePassword);
            alterPasswordForm.ShowDialog();
        }
        private void ShowPrivilegeManageForm(string userName)
        {
            var userPrivilegeManageForm = new userPrivilegeManageForm(userName);
            userPrivilegeManageForm.ShowDialog();
        }

        private async void DeleteAUser(string roleName)
        {
            try
            {
                bool result = await _userController.Delete(roleName);
                if (result)
                {
                    MessageBox.Show("User đã được xóa thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa role.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa user: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            tablePanel.Controls.Clear();
            InitializeCustomTable();
        }

       
    }
}
