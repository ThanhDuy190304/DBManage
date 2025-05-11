using SchoolManagerApp.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms
{
    public partial class RolePrivilegeManageForm : Form
    {
        private string roleName;
        private RoleController roleController = new RoleController();
        public RolePrivilegeManageForm(string name)
        {
            InitializeComponent();
            this.roleName = name;
        
            // Khởi tạo dữ liệu
            InitializeTablePrivilegeManager(this.roleName);
            InitializeColPrivilegeManager(this.roleName);
        }
        private async void InitializeTablePrivilegeManager(string roleName)
        {
            try
            {
                var privileges = await roleController.GetPrivilegeOnTableByName(roleName);
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "GRANTEE", 100 },
                    { "OWNER", 100 },
                    { "TABLE_NAME", 200 },
                    { "GRANTOR", 150 },
                    { "PRIVILEGE", 100 },
                    { "GRANTABLE", 100 },
                    { "COMMON", 100 },
                    { "INHERITED", 100 }
                };

                var data = privileges.Select(p => new string[]
                {
                    p.GRANTEE,
                    p.OWNER,
                    p.TABLE_NAME,
                    p.GRANTOR,
                    p.PRIVILEGE,
                    p.GRANTABLE,
                    p.COMMON,
                    p.INHERITED
                }).ToList();

                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                this.TablePrivilegeManagePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void InitializeColPrivilegeManager(string roleName)
        {
            try
            {
                var privileges = await roleController.GetPrivilegeOnColByName(roleName);
                var columnDefinitions = new Dictionary<string, int>()
            {
                { "GRANTEE", 100 },
                { "OWNER", 100 },
                { "TABLE_NAME", 200 },
                { "COLUMN_NAME", 150 },
                { "PRIVILEGE", 100 },
                { "GRANTABLE", 100 },
                { "COMMON", 100 },
                { "INHERITED", 100 }
            };

                var data = privileges.Select(p => new string[]
                {
                p.GRANTEE,
                p.OWNER,
                p.TABLE_NAME,
                p.COLUMN_NAME,
                p.PRIVILEGE,
                p.GRANTABLE,
                p.COMMON,
                p.INHERITED
                }).ToList();
                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                
                this.ColPrivilegeManagePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TablePrivilegeManagePanel.Controls.Clear();
            this.ColPrivilegeManagePanel.Controls.Clear();

            InitializeTablePrivilegeManager(this.roleName);
            InitializeColPrivilegeManager(this.roleName);
        }

        private async void RevokeHandle(string name, string objectName, string privilege)
        {
            try
            {
                await roleController.RevokeTablePrivilege(name, objectName, privilege);
                MessageBox.Show("Quyền đã thu hồi thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thu hồi quyền: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {
            var revokeForm = new RevokePrivilgeForm(this.roleName);
            revokeForm.OnRevokeClicked += (name, objectName, privilege) =>
            {
                RevokeHandle(name, objectName, privilege);
            };
            revokeForm.ShowDialog();
        }

        private async void GrantHandle(
            string name,
            string objectType,
            string objectName,
            string privilege,
            string[] columns,
            bool withGrantOption)
        {
            try
            {
                await roleController.GrantPermission(name, objectType, objectName, privilege, columns, withGrantOption);
                MessageBox.Show("Quyền được cấp thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cấp quyền: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GrantPrivilegeButton_Click(object sender, EventArgs e)
        {

            var grantForm = new GrantPrivilegeForm(this.roleName);
            grantForm.OnGrantClicked += (name, objectType, objectName, privilege, columns, withGrantOption) =>
            {
                GrantHandle(name, objectType, objectName, privilege, columns, withGrantOption);
            };
            grantForm.ShowDialog();
        }

    }
}
