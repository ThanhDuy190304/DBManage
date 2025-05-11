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
using FontAwesome.Sharp;

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
                    { "USER_ID", 100 },
                    { "CREATED", 150 },
                    { "EXPIRY_DAY", 150 },
                    { "LAST_LOGIN", 150 },
                    { "PASSWORD_CHANGE_DATE", 170 },
                    { "AUTHENTICATION_TYPE", 170 },
                    { "ACCOUNT_STATUS", 150 },
                };

                var data = users.Select(u => new string[]
                {
                u.USERNAME,
                u.USER_ID,
                u.CREATED,
                u.EXPIRY_DAY.ToString("yyyy-MM-dd HH:mm:ss"),
                u.LAST_LOGIN.ToString("yyyy-MM-dd HH:mm:ss"),
                u.PASSWORD_CHANGE_DATE.ToString("yyyy-MM-dd HH:mm:ss"),
                u.AUTHENTICATION_TYPE,
                u.ACCOUNT_STATUS
                }).ToList();


                var table = new CTTable(columnDefinitions, data, row =>
                {
                    var toggle = new IconButton()
                    {
                        IconChar = row[7] == "OPEN" ? IconChar.ToggleOn : IconChar.ToggleOff,
                        IconColor = row[7] == "OPEN" ? Color.Green : Color.Gray,
                        IconSize = 24,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Hand,
                        Size = new Size(30, 24)
                    };
                    toggle.FlatAppearance.BorderSize = 0;

                    toggle.Click += async (s, e) =>
                    {
                        bool isLocked = row[7] != "OPEN";
                        toggle.IconChar = isLocked ? IconChar.ToggleOn : IconChar.ToggleOff;
                        toggle.IconColor = isLocked ? Color.Green : Color.Gray;

                        if (isLocked)
                            await _userController.UnLockAccount(row[0]);
                        else
                            await _userController.LockAccount(row[0]);

                        row[7] = isLocked ? "OPEN" : "LOCKED";
                    };

                    var panel = new FlowLayoutPanel()
                    {
                        Width = 80,
                        Height = 30,
                        Margin = new Padding(0),
                        FlowDirection = FlowDirection.LeftToRight
                    };
                    panel.Controls.Add(toggle);
                    return panel;
                });


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
            var alterPasswordForm = new AlterPasswordForm(userName, null, UpdatePassword);
            alterPasswordForm.ShowDialog();
        }
        private void ShowPrivilegeManageForm(string userName)
        {
            var userPrivilegeManageForm = new UserPrivilegeManageForm(userName);
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
            CreateForm createARoleForm = new CreateForm("Tạo 1 user", HandleCreateRole);
            createARoleForm.ShowDialog();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            tablePanel.Controls.Clear();
            InitializeCustomTable();
        }

       
    }
}
