﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Views.forms;
using SchoolManagerApp.src.Views.partials;

namespace SchoolManagerApp.src.Views
{
    public partial class RolesPage : UserControl
    {
        private CTButton ReloadButton;

        private Panel tablePanel;
        private CTButton CreateRoleButton;
        private RoleController roleController = new RoleController();
        public RolesPage()
        {
            InitializeComponent();
            InitializeCustomTable();
            this.Padding = new Padding(12);
        }

        private async void InitializeCustomTable()
        {
            try
            {
                var roles = await roleController.GetAll();

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "ROLE", 150 },
                    { "ROLE_ID", 100 },
                    { "PASSWORD_REQUIRED", 150 },
                    { "AUTHENTICATION_TYPE", 150 },
                    { "COMMON", 100 },
                    { "ORACLE_MAINTAINED", 150 },
                    { "INHERITED", 100 },
                    { "IMPLICIT", 100 },
                };

                var data = roles.Select(r => new string[]
                {
                    r.ROLE,
                    r.ROLE_ID,
                    r.PASSWORD_REQUIRED?.ToString() ?? "",
                    r.AUTHENTICATION_TYPE?.ToString() ?? "",
                    r.COMMON?.ToString() ?? "",
                    r.ORACLE_MAINTAINED?.ToString() ?? "",
                    r.INHERITED?.ToString() ?? "",
                    r.IMPLICIT?.ToString() ?? ""
                }).ToList();

                var table = new CTTable(columnDefinitions, data);
                table.OnDeleteClicked += roleName =>
                {
                    DeleteARole(roleName);
                };
                table.OnShieldClicked += roleName =>
                {
                    ShowAlterPasswordForm(roleName);
                };
                table.OnClipBoardCheckClicked += roleName =>
                {
                    ShowPrivilegeManageForm(roleName);
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
        private async Task<bool> UpdatePassword(string roleName, string password)
        {
            bool result = false;
            try
            {
                result = await roleController.UpdatePassword(roleName, password);
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

        private async Task<bool> TurnOffAuthByPass(string roleName)
        {
            bool result = false;
            try
            {
                result = await roleController.RemoveAuthentication(roleName);
                if (result)
                {
                    MessageBox.Show("Đã tắt xác thực.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tắt xác thực: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void ShowAlterPasswordForm(string roleName)
        {
            var alterPasswordForm = new AlterPasswordForm(roleName, TurnOffAuthByPass, UpdatePassword);
            alterPasswordForm.ShowDialog();
        }

        private void ShowPrivilegeManageForm(string roleName)
        {
            var rolePrivilegeManageForm = new RolePrivilegeManageForm(roleName);
            rolePrivilegeManageForm.ShowDialog();
        }
        private async void DeleteARole(string roleName)
        {
            try
            {
                bool result = await roleController.Delete(roleName);
                if (result)
                {
                    MessageBox.Show("Role đã được xóa thành công.", "Thông báo",
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
                MessageBox.Show($"Lỗi khi xóa role: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeComponent()
        {
            this.tablePanel = new System.Windows.Forms.Panel();
            this.CreateRoleButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.Location = new System.Drawing.Point(51, 109);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(963, 343);
            this.tablePanel.TabIndex = 0;
            this.tablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel_Paint);
            // 
            // CreateRoleButton
            // 
            this.CreateRoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateRoleButton.BackColor = System.Drawing.Color.White;
            this.CreateRoleButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateRoleButton.BorderColor = System.Drawing.Color.Green;
            this.CreateRoleButton.BorderRadius = 8;
            this.CreateRoleButton.BorderSize = 2;
            this.CreateRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateRoleButton.FlatAppearance.BorderSize = 0;
            this.CreateRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRoleButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateRoleButton.ForeColor = System.Drawing.Color.Green;
            this.CreateRoleButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateRoleButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateRoleButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateRoleButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.CreateRoleButton.IconColor = System.Drawing.Color.Green;
            this.CreateRoleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateRoleButton.IconSize = 24;
            this.CreateRoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateRoleButton.Location = new System.Drawing.Point(864, 17);
            this.CreateRoleButton.Name = "CreateRoleButton";
            this.CreateRoleButton.Size = new System.Drawing.Size(150, 40);
            this.CreateRoleButton.TabIndex = 0;
            this.CreateRoleButton.Text = "Tạo 1 role mới";
            this.CreateRoleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateRoleButton.TextColor = System.Drawing.Color.Green;
            this.CreateRoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateRoleButton.UseVisualStyleBackColor = false;
            this.CreateRoleButton.Click += new System.EventHandler(this.CreateRoleButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadButton.BackColor = System.Drawing.Color.White;
            this.ReloadButton.BackgroundColor = System.Drawing.Color.White;
            this.ReloadButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.BorderRadius = 8;
            this.ReloadButton.BorderSize = 2;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.ReloadButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReloadButton.HoverIconColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.ReloadButton.IconColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadButton.IconSize = 24;
            this.ReloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReloadButton.Location = new System.Drawing.Point(915, 474);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(99, 40);
            this.ReloadButton.TabIndex = 1;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RolesPage
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.CreateRoleButton);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.ReloadButton);
            this.Name = "RolesPage";
            this.Size = new System.Drawing.Size(1054, 517);
            this.ResumeLayout(false);

        }

        private void CreateRoleButton_Click(object sender, EventArgs e)
        {
            async Task<bool> HandleCreateRole(string roleName, string password)
            {
                try
                {
                    bool result = await roleController.Create(roleName, password);
                    if (result)
                    {
                        MessageBox.Show("Role đã được tạo thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo role.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo role: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            CreateForm createARoleForm = new CreateForm("Tạo 1 role", HandleCreateRole);
            createARoleForm.ShowDialog();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            tablePanel.Controls.Clear();
            InitializeCustomTable();
        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
