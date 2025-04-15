using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Views.partials;

namespace SchoolManagerApp.src.Views
{
    public partial class RolesPage : UserControl
    {
        private Panel createButtonPanel;
        private CTButton CreateRoleButton;
        private Panel tablePanel;

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
                    { "GRANTED_ROLE", 150 },
                    { "USERNAME", 150 },
                    { "ADMIN_OPTION", 100 },
                    { "DELEGATE_OPTION", 110 },
                    { "DEFAULT_ROLE", 100 },
                    { "OS_GRANTED", 100 },
                    { "COMMON", 100 },
                    { "INHERITED", 100 },
                };

                var data = roles.Select(r => new string[]
                {
                    r.GRANTED_ROLE,
                    r.USERNAME,
                    r.ADMIN_OPTION?.ToString() ?? "",
                    r.DELEGATE_OPTION?.ToString() ?? "",
                    r.DEFAULT_ROLE?.ToString() ?? "",
                    r.OS_GRANTED?.ToString() ?? "",
                    r.COMMON?.ToString() ?? "",
                    r.INHERITED?.ToString() ?? ""
                }).ToList();

                var table = new CTTable(columnDefinitions, data);
                table.OnDeleteClicked += roleName =>
                {
                    DeleteARole(roleName);
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
        private async void DeleteARole(string roleName)
        {
            try
            {
                await roleController.DeleteRole(roleName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa role: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeComponent()
        {
            this.createButtonPanel = new System.Windows.Forms.Panel();
            this.CreateRoleButton = new SchoolManagerApp.Controls.CTButton();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.createButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButtonPanel
            // 
            this.createButtonPanel.Controls.Add(this.CreateRoleButton);
            this.createButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.createButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.createButtonPanel.Name = "createButtonPanel";
            this.createButtonPanel.Size = new System.Drawing.Size(1042, 70);
            this.createButtonPanel.TabIndex = 1;
            // 
            // CreateRoleButton
            // 
            this.CreateRoleButton.BackColor = System.Drawing.Color.White;
            this.CreateRoleButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateRoleButton.BorderColor = System.Drawing.Color.Green;
            this.CreateRoleButton.BorderRadius = 8;
            this.CreateRoleButton.BorderSize = 2;
            this.CreateRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateRoleButton.FlatAppearance.BorderSize = 0;
            this.CreateRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRoleButton.ForeColor = System.Drawing.Color.Green;
            this.CreateRoleButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateRoleButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateRoleButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateRoleButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.CreateRoleButton.IconColor = System.Drawing.Color.Green;
            this.CreateRoleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateRoleButton.IconSize = 24;
            this.CreateRoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateRoleButton.Location = new System.Drawing.Point(890, 27);
            this.CreateRoleButton.Name = "CreateRoleButton";
            this.CreateRoleButton.Size = new System.Drawing.Size(119, 40);
            this.CreateRoleButton.TabIndex = 0;
            this.CreateRoleButton.Text = "Tạo 1 role mới";
            this.CreateRoleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateRoleButton.TextColor = System.Drawing.Color.Green;
            this.CreateRoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateRoleButton.UseVisualStyleBackColor = false;
            this.CreateRoleButton.Click += new System.EventHandler(this.CreateRoleButton_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel.Location = new System.Drawing.Point(54, 113);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(955, 317);
            this.tablePanel.TabIndex = 0;
            this.tablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel_Paint);
            // 
            // RolesPage
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.createButtonPanel);
            this.Name = "RolesPage";
            this.Size = new System.Drawing.Size(1042, 472);
            this.createButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CreateRoleButton_Click(object sender, EventArgs e)
        {
            createARoleForm createARoleForm = new createARoleForm();
            createARoleForm.ShowDialog();
        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
