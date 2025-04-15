﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManagerApp.Controls;

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
                { "USERNAME", 150 },
                { "CREATED DATA", 120 },
                { "UPDATED DATA", 120 }
            };

            // Mock dữ liệu
            var data = new List<string[]>()
            {
                new string[] { "thanhduy", "2023-01-01", "2024-01-01" },
                new string[] { "admin01", "2022-05-03", "2025-02-28" },
                new string[] { "studentX", "2024-07-15", "2025-04-09" }
            };

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
            this.createButtonPanel.Size = new System.Drawing.Size(1199, 70);
            this.createButtonPanel.TabIndex = 1;
            // 
            // tablePanel
            // 
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 70);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1199, 402);
            this.tablePanel.TabIndex = 0;
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
            this.CreateRoleButton.Location = new System.Drawing.Point(0, 27);
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
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.createButtonPanel);
            this.Name = "RolesPage";
            this.Size = new System.Drawing.Size(1199, 472);
            this.createButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CreateRoleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
