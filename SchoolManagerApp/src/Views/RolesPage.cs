using System;
using System.Collections.Generic;
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

        public RolesPage()
        {
            InitializeComponent();
            InitializeCustomTable();
            this.Padding = new Padding(12);
        }

        private void InitializeCustomTable()
        {
            // Mock cột: tên cột + độ rộng
            var columnDefinitions = new Dictionary<string, int>()
            {
                { "STT", 50 },
                { "Tên role", 150 },
                { "Số lượng users", 150 },
                { "Người cấp", 120 },
                { "Ngày tạo", 120 },
                { "Ngày update", 120 }
            };

            // Mock dữ liệu
            var data = new List<string[]>();
            for (int i = 1; i <= 20; i++)
            {
                data.Add(new string[]
                {
            i.ToString(),
            "ROLE_" + (i % 5 == 0 ? "ADMIN" : "USER" + i),
            (5 + i % 3).ToString() + " users",
            "SYSTEM",
            "2024-01-01",
            "2025-04-" + (i % 30 + 1).ToString("D2")
                });
            }

            var table = new CTTable(columnDefinitions, data);
            table.Dock = DockStyle.Fill;
            this.tablePanel.Controls.Add(table);
        }

        private void InitializeComponent()
        {
            this.createButtonPanel = new System.Windows.Forms.Panel();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.CreateRoleButton = new SchoolManagerApp.Controls.CTButton();
            this.createButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButtonPanel
            // 
            this.createButtonPanel.Controls.Add(this.CreateRoleButton);
            this.createButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.createButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.createButtonPanel.Name = "createButtonPanel";
            this.createButtonPanel.Size = new System.Drawing.Size(903, 70);
            this.createButtonPanel.TabIndex = 1;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel.Location = new System.Drawing.Point(34, 113);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(831, 317);
            this.tablePanel.TabIndex = 0;
            this.tablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel_Paint);
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
            this.CreateRoleButton.Location = new System.Drawing.Point(781, 27);
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
            // RolesPage
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.createButtonPanel);
            this.Name = "RolesPage";
            this.Size = new System.Drawing.Size(903, 472);
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
