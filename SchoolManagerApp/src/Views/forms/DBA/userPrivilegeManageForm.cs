using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolManagerApp.src.Views.forms
{
    public class UserPrivilegeManageForm : Form
    {
        private string _userName;
        private CTButton RevokePrivilgeButton;
        private Panel ColPrivilegeManagePanel;
        private Panel TablePrivilegeManagePanel;
        private Panel GrantedRolePanel;
        private CTButton RevokeRoleButton;
        private TabControl tabUserPriviligesControl;
        private TabPage tabTablePriviliges;
        private TabPage tabColPriviliges;
        private TabPage tabRolePriviliges;
        private CTButton GrantRoleButton;
        private CTButton GrantPrivilegeButton;
        private CTButton ReloadButton;
        private UserController _userController = new UserController();

        public UserPrivilegeManageForm(string name)
        {
            InitializeComponent();
            this._userName = name;

            // Khởi tạo dữ liệu
            InitializeGrantedRoleManager(this._userName);
            InitializeTablePrivilegeManager(this._userName);
            InitializeColPrivilegeManager(this._userName);
        }

        private async void InitializeGrantedRoleManager(string userName)
        {
            try
            {
                var grantedRole = await _userController.GetRoleByName(userName);
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "GRANTEE", 150 },
                    { "GRANTED_ROLE", 150 },
                    { "ADMIN_OPTION", 120 },
                    { "DEFAULT_OPTION", 150 },
                    { "DEFAULT_ROLE", 150 },
                    { "COMMON", 100 },
                    { "INHERITED", 100 }
                };

                var data = grantedRole.Select(r => new string[]
                {
                r.GRANTEE,
                r.GRANTED_ROLE,
                r.ADMIN_OPTION,
                r.DEFAULT_OPTION,
                r.DEFAULT_ROLE,
                r.COMMON,
                r.INHERITED
                }).ToList();

                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                this.GrantedRolePanel.Controls.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void InitializeTablePrivilegeManager(string userName)
        {
            try
            {
                var privileges = await _userController.GetPrivilegeOnTableByName(userName);
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "GRANTEE", 100 },
                    { "OWNER", 100 },
                    { "TABLE_NAME", 150 },
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
                this.ColPrivilegeManagePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void InitializeColPrivilegeManager(string userName)
        {
            try
            {
                var privileges = await _userController.GetPrivilegeOnColByName(userName);
                var columnDefinitions = new Dictionary<string, int>()
            {
                { "GRANTEE", 100 },
                { "OWNER", 100 },
                { "TABLE_NAME", 150 },
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

                this.TablePrivilegeManagePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InitializeComponent()
        {
            this.ColPrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.TablePrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.GrantedRolePanel = new System.Windows.Forms.Panel();
            this.tabUserPriviligesControl = new System.Windows.Forms.TabControl();
            this.tabTablePriviliges = new System.Windows.Forms.TabPage();
            this.tabColPriviliges = new System.Windows.Forms.TabPage();
            this.tabRolePriviliges = new System.Windows.Forms.TabPage();
            this.GrantRoleButton = new SchoolManagerApp.Controls.CTButton();
            this.RevokeRoleButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.GrantPrivilegeButton = new SchoolManagerApp.Controls.CTButton();
            this.RevokePrivilgeButton = new SchoolManagerApp.Controls.CTButton();
            this.tabUserPriviligesControl.SuspendLayout();
            this.tabTablePriviliges.SuspendLayout();
            this.tabColPriviliges.SuspendLayout();
            this.tabRolePriviliges.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColPrivilegeManagePanel
            // 
            this.ColPrivilegeManagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColPrivilegeManagePanel.Location = new System.Drawing.Point(68, 56);
            this.ColPrivilegeManagePanel.Name = "ColPrivilegeManagePanel";
            this.ColPrivilegeManagePanel.Size = new System.Drawing.Size(717, 215);
            this.ColPrivilegeManagePanel.TabIndex = 4;
            // 
            // TablePrivilegeManagePanel
            // 
            this.TablePrivilegeManagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePrivilegeManagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablePrivilegeManagePanel.Location = new System.Drawing.Point(42, 40);
            this.TablePrivilegeManagePanel.Name = "TablePrivilegeManagePanel";
            this.TablePrivilegeManagePanel.Size = new System.Drawing.Size(758, 250);
            this.TablePrivilegeManagePanel.TabIndex = 3;
            // 
            // GrantedRolePanel
            // 
            this.GrantedRolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrantedRolePanel.Location = new System.Drawing.Point(44, 81);
            this.GrantedRolePanel.Name = "GrantedRolePanel";
            this.GrantedRolePanel.Padding = new System.Windows.Forms.Padding(2);
            this.GrantedRolePanel.Size = new System.Drawing.Size(760, 215);
            this.GrantedRolePanel.TabIndex = 5;
            // 
            // tabUserPriviligesControl
            // 
            this.tabUserPriviligesControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabUserPriviligesControl.Controls.Add(this.tabTablePriviliges);
            this.tabUserPriviligesControl.Controls.Add(this.tabColPriviliges);
            this.tabUserPriviligesControl.Controls.Add(this.tabRolePriviliges);
            this.tabUserPriviligesControl.Font = new System.Drawing.Font("Calibri", 13F);
            this.tabUserPriviligesControl.Location = new System.Drawing.Point(121, 71);
            this.tabUserPriviligesControl.Name = "tabUserPriviligesControl";
            this.tabUserPriviligesControl.SelectedIndex = 0;
            this.tabUserPriviligesControl.Size = new System.Drawing.Size(854, 366);
            this.tabUserPriviligesControl.TabIndex = 8;
            // 
            // tabTablePriviliges
            // 
            this.tabTablePriviliges.AutoScroll = true;
            this.tabTablePriviliges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTablePriviliges.Controls.Add(this.TablePrivilegeManagePanel);
            this.tabTablePriviliges.Location = new System.Drawing.Point(4, 30);
            this.tabTablePriviliges.Name = "tabTablePriviliges";
            this.tabTablePriviliges.Padding = new System.Windows.Forms.Padding(3);
            this.tabTablePriviliges.Size = new System.Drawing.Size(846, 332);
            this.tabTablePriviliges.TabIndex = 0;
            this.tabTablePriviliges.Text = "Quyền trên bảng";
            this.tabTablePriviliges.UseVisualStyleBackColor = true;
            // 
            // tabColPriviliges
            // 
            this.tabColPriviliges.AutoScroll = true;
            this.tabColPriviliges.Controls.Add(this.ColPrivilegeManagePanel);
            this.tabColPriviliges.Location = new System.Drawing.Point(4, 30);
            this.tabColPriviliges.Name = "tabColPriviliges";
            this.tabColPriviliges.Padding = new System.Windows.Forms.Padding(3);
            this.tabColPriviliges.Size = new System.Drawing.Size(846, 332);
            this.tabColPriviliges.TabIndex = 1;
            this.tabColPriviliges.Text = "Quyền trên cột";
            this.tabColPriviliges.UseVisualStyleBackColor = true;
            // 
            // tabRolePriviliges
            // 
            this.tabRolePriviliges.AutoScroll = true;
            this.tabRolePriviliges.Controls.Add(this.GrantedRolePanel);
            this.tabRolePriviliges.Controls.Add(this.GrantRoleButton);
            this.tabRolePriviliges.Controls.Add(this.RevokeRoleButton);
            this.tabRolePriviliges.Location = new System.Drawing.Point(4, 30);
            this.tabRolePriviliges.Name = "tabRolePriviliges";
            this.tabRolePriviliges.Size = new System.Drawing.Size(846, 332);
            this.tabRolePriviliges.TabIndex = 2;
            this.tabRolePriviliges.Text = "Vai trò";
            this.tabRolePriviliges.UseVisualStyleBackColor = true;
            // 
            // GrantRoleButton
            // 
            this.GrantRoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrantRoleButton.BackColor = System.Drawing.Color.White;
            this.GrantRoleButton.BackgroundColor = System.Drawing.Color.White;
            this.GrantRoleButton.BorderColor = System.Drawing.Color.Green;
            this.GrantRoleButton.BorderRadius = 8;
            this.GrantRoleButton.BorderSize = 2;
            this.GrantRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantRoleButton.FlatAppearance.BorderSize = 0;
            this.GrantRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantRoleButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.GrantRoleButton.ForeColor = System.Drawing.Color.Green;
            this.GrantRoleButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GrantRoleButton.HoverIconColor = System.Drawing.Color.Green;
            this.GrantRoleButton.HoverTextColor = System.Drawing.Color.Green;
            this.GrantRoleButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.GrantRoleButton.IconColor = System.Drawing.Color.Green;
            this.GrantRoleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GrantRoleButton.IconSize = 24;
            this.GrantRoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GrantRoleButton.Location = new System.Drawing.Point(538, 22);
            this.GrantRoleButton.Name = "GrantRoleButton";
            this.GrantRoleButton.Size = new System.Drawing.Size(150, 40);
            this.GrantRoleButton.TabIndex = 3;
            this.GrantRoleButton.Text = "Cấp role mới";
            this.GrantRoleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GrantRoleButton.TextColor = System.Drawing.Color.Green;
            this.GrantRoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GrantRoleButton.UseVisualStyleBackColor = false;
            this.GrantRoleButton.Click += new System.EventHandler(this.GrantRoleButton_Click);
            // 
            // RevokeRoleButton
            // 
            this.RevokeRoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RevokeRoleButton.BackColor = System.Drawing.Color.White;
            this.RevokeRoleButton.BackgroundColor = System.Drawing.Color.White;
            this.RevokeRoleButton.BorderColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.BorderRadius = 8;
            this.RevokeRoleButton.BorderSize = 2;
            this.RevokeRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevokeRoleButton.FlatAppearance.BorderSize = 0;
            this.RevokeRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokeRoleButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.RevokeRoleButton.ForeColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RevokeRoleButton.HoverIconColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.HoverTextColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.RevokeRoleButton.IconColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevokeRoleButton.IconSize = 24;
            this.RevokeRoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevokeRoleButton.Location = new System.Drawing.Point(694, 22);
            this.RevokeRoleButton.Name = "RevokeRoleButton";
            this.RevokeRoleButton.Size = new System.Drawing.Size(113, 40);
            this.RevokeRoleButton.TabIndex = 4;
            this.RevokeRoleButton.Text = "Xóa role";
            this.RevokeRoleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RevokeRoleButton.TextColor = System.Drawing.Color.Red;
            this.RevokeRoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RevokeRoleButton.UseVisualStyleBackColor = false;
            this.RevokeRoleButton.Click += new System.EventHandler(this.RevokeRoleButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(997, 397);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(99, 40);
            this.ReloadButton.TabIndex = 10;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // GrantPrivilegeButton
            // 
            this.GrantPrivilegeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrantPrivilegeButton.BackColor = System.Drawing.Color.White;
            this.GrantPrivilegeButton.BackgroundColor = System.Drawing.Color.White;
            this.GrantPrivilegeButton.BorderColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.BorderRadius = 8;
            this.GrantPrivilegeButton.BorderSize = 2;
            this.GrantPrivilegeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantPrivilegeButton.FlatAppearance.BorderSize = 0;
            this.GrantPrivilegeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantPrivilegeButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.GrantPrivilegeButton.ForeColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GrantPrivilegeButton.HoverIconColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.HoverTextColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.GrantPrivilegeButton.IconColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GrantPrivilegeButton.IconSize = 24;
            this.GrantPrivilegeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GrantPrivilegeButton.Location = new System.Drawing.Point(694, 25);
            this.GrantPrivilegeButton.Name = "GrantPrivilegeButton";
            this.GrantPrivilegeButton.Size = new System.Drawing.Size(150, 40);
            this.GrantPrivilegeButton.TabIndex = 9;
            this.GrantPrivilegeButton.Text = "Cấp quyền mới";
            this.GrantPrivilegeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GrantPrivilegeButton.TextColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GrantPrivilegeButton.UseVisualStyleBackColor = false;
            this.GrantPrivilegeButton.Click += new System.EventHandler(this.GrantPrivilegeButton_Click);
            // 
            // RevokePrivilgeButton
            // 
            this.RevokePrivilgeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RevokePrivilgeButton.BackColor = System.Drawing.Color.White;
            this.RevokePrivilgeButton.BackgroundColor = System.Drawing.Color.White;
            this.RevokePrivilgeButton.BorderColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.BorderRadius = 8;
            this.RevokePrivilgeButton.BorderSize = 2;
            this.RevokePrivilgeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevokePrivilgeButton.FlatAppearance.BorderSize = 0;
            this.RevokePrivilgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokePrivilgeButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.RevokePrivilgeButton.ForeColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RevokePrivilgeButton.HoverIconColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.HoverTextColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.RevokePrivilgeButton.IconColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevokePrivilgeButton.IconSize = 24;
            this.RevokePrivilgeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevokePrivilgeButton.Location = new System.Drawing.Point(862, 25);
            this.RevokePrivilgeButton.Name = "RevokePrivilgeButton";
            this.RevokePrivilgeButton.Size = new System.Drawing.Size(113, 40);
            this.RevokePrivilgeButton.TabIndex = 2;
            this.RevokePrivilgeButton.Text = "Xóa quyền";
            this.RevokePrivilgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RevokePrivilgeButton.TextColor = System.Drawing.Color.Red;
            this.RevokePrivilgeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RevokePrivilgeButton.UseVisualStyleBackColor = false;
            this.RevokePrivilgeButton.Click += new System.EventHandler(this.RevokePrivilgeButton_Click);
            // 
            // UserPrivilegeManageForm
            // 
            this.ClientSize = new System.Drawing.Size(1108, 484);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.GrantPrivilegeButton);
            this.Controls.Add(this.tabUserPriviligesControl);
            this.Controls.Add(this.RevokePrivilgeButton);
            this.Name = "UserPrivilegeManageForm";
            this.Text = "Quản lý quyền user";
            this.tabUserPriviligesControl.ResumeLayout(false);
            this.tabTablePriviliges.ResumeLayout(false);
            this.tabColPriviliges.ResumeLayout(false);
            this.tabRolePriviliges.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TablePrivilegeManagePanel.Controls.Clear();
            this.ColPrivilegeManagePanel.Controls.Clear();
            this.GrantedRolePanel.Controls.Clear();
            InitializeTablePrivilegeManager(this._userName);
            InitializeColPrivilegeManager(this._userName);
            InitializeGrantedRoleManager(this._userName);
        }

        private async void GrantPrivilegeHandle(
           string name,
           string objectType,
           string objectName,
           string privilege,
           string[] columns,
           bool withGrantOption)
        {
            try
            {
                await _userController.GrantPermission(name, objectType, objectName, privilege, columns, withGrantOption);
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

            var grantForm = new GrantPrivilegeForm(this._userName);
            grantForm.OnGrantClicked += (name, objectType, objectName, privilege, columns, withGrantOption) =>
            {
                GrantPrivilegeHandle(name, objectType, objectName, privilege, columns, withGrantOption);
            };
            grantForm.ShowDialog();
        }

        private async void GrantRoleHandle(string userName, string roleName, bool withGrantOption)
        {
            try
            {
                await _userController.GrantRole(userName, roleName, withGrantOption);
                MessageBox.Show("Role được cấp thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cấp role: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrantRoleButton_Click(object sender, EventArgs e)
        {
            var grantForm = new GrantRoleForm(this._userName);
            grantForm.OnGrantRoleClicked += (userName, roleName, withGrantOption) =>
            {
                GrantRoleHandle(userName, roleName, withGrantOption);
            };
            grantForm.ShowDialog();
        }


        private async void RevokePrivilegeHandle(string name, string objectName, string privilege)
        {
            try
            {
                await _userController.RevokeTablePrivilege(name, objectName, privilege);
                MessageBox.Show("Quyền đã thu hồi thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thu hồi quyền: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RevokePrivilgeButton_Click(object sender, EventArgs e)
        {
            var revokeForm = new RevokePrivilgeForm(this._userName);
            revokeForm.OnRevokeClicked += (name, objectName, privilege) =>
            {
                RevokePrivilegeHandle(name, objectName, privilege);
            };
            revokeForm.ShowDialog();
        }

        private async void RevokeRoleHandle(string userName, string roleName)
        {
            try
            {
                await _userController.RevokeRole(userName, roleName);
                MessageBox.Show("Role đã thu hồi thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thu hồi role: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RevokeRoleButton_Click(object sender, EventArgs e)
        {
            var revokeForm = new RevokeRoleOfUser(this._userName);
            revokeForm.OnRevokeRoleClicked += (userName, roleName) =>
            {
                RevokeRoleHandle(userName, roleName);
            };
            revokeForm.ShowDialog();
        }

       
    }
}
