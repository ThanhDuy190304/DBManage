using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms
{
    public class userPrivilegeManageForm : Form
    {
        private string _userName;
        private Panel buttonPanel;
        private CTButton RevokeButton;
        private CTButton GrantPrivilegeButton;
        private CTButton ReloadButton;
        private Panel panelManage;
        private Panel ColPrivilegeManagePanel;
        private Label TablePrivilegeLabel;
        private Label ColPrivilegeLabel;
        private Panel TablePrivilegeManagePanel;
        private Panel GrantedRolePanel;
        private Label GrantedRoleLabel;
        private UserController _userController = new UserController();

        public userPrivilegeManageForm(string name)
        {
            InitializeComponent();
            this._userName = name;

            // Thiết lập panel chính
            this.panelManage.AutoScroll = true;
            this.panelManage.Dock = DockStyle.Fill;

            // Xóa tất cả controls hiện có để sắp xếp lại
            this.panelManage.Controls.Clear();
            
            //7. Panel chứa role được cấp 
            this.GrantedRolePanel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.GrantedRolePanel);

            //6. Label role được cấp
            this.GrantedRoleLabel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.GrantedRoleLabel);

            // 5. Thêm Panel chứa bảng quyền trên bảng
            this.TablePrivilegeManagePanel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.TablePrivilegeManagePanel);

            // 4. Thêm Label quyền trên cột
            this.ColPrivilegeLabel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.ColPrivilegeLabel);

            // 3. Thêm Panel chứa bảng quyền trên cột
            this.ColPrivilegeManagePanel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.ColPrivilegeManagePanel);

            // 2. Thêm Label quyền trên bảng (sẽ nằm dưới nút)
            this.TablePrivilegeLabel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.TablePrivilegeLabel);

            // 1. Thêm nút Reload (nếu có)
            this.buttonPanel.Dock = DockStyle.Top;
            this.panelManage.Controls.Add(this.buttonPanel);

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

                var table = new CTTable(columnDefinitions, data);
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

                var table = new CTTable(columnDefinitions, data);
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
                var table = new CTTable(columnDefinitions, data);
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.RevokeButton = new SchoolManagerApp.Controls.CTButton();
            this.GrantPrivilegeButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.panelManage = new System.Windows.Forms.Panel();
            this.ColPrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.TablePrivilegeLabel = new System.Windows.Forms.Label();
            this.ColPrivilegeLabel = new System.Windows.Forms.Label();
            this.TablePrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.GrantedRolePanel = new System.Windows.Forms.Panel();
            this.GrantedRoleLabel = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.panelManage.SuspendLayout();
            this.GrantedRolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.RevokeButton);
            this.buttonPanel.Controls.Add(this.GrantPrivilegeButton);
            this.buttonPanel.Controls.Add(this.ReloadButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1108, 70);
            this.buttonPanel.TabIndex = 6;
            // 
            // RevokeButton
            // 
            this.RevokeButton.BackColor = System.Drawing.Color.White;
            this.RevokeButton.BackgroundColor = System.Drawing.Color.White;
            this.RevokeButton.BorderColor = System.Drawing.Color.Red;
            this.RevokeButton.BorderRadius = 8;
            this.RevokeButton.BorderSize = 2;
            this.RevokeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevokeButton.FlatAppearance.BorderSize = 0;
            this.RevokeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokeButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.RevokeButton.ForeColor = System.Drawing.Color.Red;
            this.RevokeButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RevokeButton.HoverIconColor = System.Drawing.Color.Red;
            this.RevokeButton.HoverTextColor = System.Drawing.Color.Red;
            this.RevokeButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.RevokeButton.IconColor = System.Drawing.Color.Red;
            this.RevokeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevokeButton.IconSize = 24;
            this.RevokeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevokeButton.Location = new System.Drawing.Point(715, 27);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(113, 40);
            this.RevokeButton.TabIndex = 2;
            this.RevokeButton.Text = "Xóa quyền";
            this.RevokeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RevokeButton.TextColor = System.Drawing.Color.Red;
            this.RevokeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RevokeButton.UseVisualStyleBackColor = false;
            // 
            // GrantPrivilegeButton
            // 
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
            this.GrantPrivilegeButton.Location = new System.Drawing.Point(859, 27);
            this.GrantPrivilegeButton.Name = "GrantPrivilegeButton";
            this.GrantPrivilegeButton.Size = new System.Drawing.Size(150, 40);
            this.GrantPrivilegeButton.TabIndex = 0;
            this.GrantPrivilegeButton.Text = "Cấp quyền mới";
            this.GrantPrivilegeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GrantPrivilegeButton.TextColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GrantPrivilegeButton.UseVisualStyleBackColor = false;
            // 
            // ReloadButton
            // 
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
            this.ReloadButton.Location = new System.Drawing.Point(141, 27);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(99, 40);
            this.ReloadButton.TabIndex = 1;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            // 
            // panelManage
            // 
            this.panelManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelManage.Controls.Add(this.GrantedRolePanel);
            this.panelManage.Controls.Add(this.ColPrivilegeManagePanel);
            this.panelManage.Controls.Add(this.TablePrivilegeLabel);
            this.panelManage.Controls.Add(this.ColPrivilegeLabel);
            this.panelManage.Controls.Add(this.TablePrivilegeManagePanel);
            this.panelManage.Location = new System.Drawing.Point(153, 95);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(796, 391);
            this.panelManage.TabIndex = 7;
            // 
            // ColPrivilegeManagePanel
            // 
            this.ColPrivilegeManagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColPrivilegeManagePanel.Location = new System.Drawing.Point(18, 364);
            this.ColPrivilegeManagePanel.Name = "ColPrivilegeManagePanel";
            this.ColPrivilegeManagePanel.Size = new System.Drawing.Size(760, 215);
            this.ColPrivilegeManagePanel.TabIndex = 4;
            // 
            // TablePrivilegeLabel
            // 
            this.TablePrivilegeLabel.AutoSize = true;
            this.TablePrivilegeLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.TablePrivilegeLabel.Location = new System.Drawing.Point(14, 29);
            this.TablePrivilegeLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.TablePrivilegeLabel.Name = "TablePrivilegeLabel";
            this.TablePrivilegeLabel.Size = new System.Drawing.Size(130, 22);
            this.TablePrivilegeLabel.TabIndex = 2;
            this.TablePrivilegeLabel.Text = "Quyền trên bảng";
            // 
            // ColPrivilegeLabel
            // 
            this.ColPrivilegeLabel.AutoSize = true;
            this.ColPrivilegeLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.ColPrivilegeLabel.Location = new System.Drawing.Point(14, 328);
            this.ColPrivilegeLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ColPrivilegeLabel.Name = "ColPrivilegeLabel";
            this.ColPrivilegeLabel.Size = new System.Drawing.Size(119, 22);
            this.ColPrivilegeLabel.TabIndex = 1;
            this.ColPrivilegeLabel.Text = "Quyền trên cột";
            // 
            // TablePrivilegeManagePanel
            // 
            this.TablePrivilegeManagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TablePrivilegeManagePanel.Location = new System.Drawing.Point(18, 70);
            this.TablePrivilegeManagePanel.Name = "TablePrivilegeManagePanel";
            this.TablePrivilegeManagePanel.Size = new System.Drawing.Size(760, 215);
            this.TablePrivilegeManagePanel.TabIndex = 3;
            // 
            // GrantedRolePanel
            // 
            this.GrantedRolePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrantedRolePanel.Controls.Add(this.GrantedRoleLabel);
            this.GrantedRolePanel.Location = new System.Drawing.Point(18, 88);
            this.GrantedRolePanel.Name = "GrantedRolePanel";
            this.GrantedRolePanel.Size = new System.Drawing.Size(760, 215);
            this.GrantedRolePanel.TabIndex = 5;
            // 
            // GrantedRoleLabel
            // 
            this.GrantedRoleLabel.AutoSize = true;
            this.GrantedRoleLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.GrantedRoleLabel.Location = new System.Drawing.Point(322, 96);
            this.GrantedRoleLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.GrantedRoleLabel.Name = "GrantedRoleLabel";
            this.GrantedRoleLabel.Size = new System.Drawing.Size(116, 22);
            this.GrantedRoleLabel.TabIndex = 6;
            this.GrantedRoleLabel.Text = "Role được cấp";
            // 
            // userPrivilegeManageForm
            // 
            this.ClientSize = new System.Drawing.Size(1108, 484);
            this.Controls.Add(this.panelManage);
            this.Controls.Add(this.buttonPanel);
            this.Name = "userPrivilegeManageForm";
            this.Text = "Quản lý quyền user";
            this.buttonPanel.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            this.panelManage.PerformLayout();
            this.GrantedRolePanel.ResumeLayout(false);
            this.GrantedRolePanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
