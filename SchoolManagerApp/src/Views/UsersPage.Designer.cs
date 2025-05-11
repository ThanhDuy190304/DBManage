namespace SchoolManagerApp.src.Views
{
    partial class UsersPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel = new System.Windows.Forms.Panel();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.CreateUserButton = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.Location = new System.Drawing.Point(38, 130);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(808, 317);
            this.tablePanel.TabIndex = 3;
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
            this.ReloadButton.Location = new System.Drawing.Point(747, 462);
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
            // CreateUserButton
            // 
            this.CreateUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateUserButton.BackColor = System.Drawing.Color.White;
            this.CreateUserButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateUserButton.BorderColor = System.Drawing.Color.Green;
            this.CreateUserButton.BorderRadius = 8;
            this.CreateUserButton.BorderSize = 2;
            this.CreateUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateUserButton.FlatAppearance.BorderSize = 0;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateUserButton.ForeColor = System.Drawing.Color.Green;
            this.CreateUserButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateUserButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateUserButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateUserButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.CreateUserButton.IconColor = System.Drawing.Color.Green;
            this.CreateUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateUserButton.IconSize = 24;
            this.CreateUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateUserButton.Location = new System.Drawing.Point(696, 64);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(150, 40);
            this.CreateUserButton.TabIndex = 0;
            this.CreateUserButton.Text = "Tạo 1 user mới";
            this.CreateUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateUserButton.TextColor = System.Drawing.Color.Green;
            this.CreateUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.ReloadButton);
            this.Name = "UsersPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tablePanel;
        private Controls.CTButton ReloadButton;
        private Controls.CTButton CreateUserButton;
    }
}