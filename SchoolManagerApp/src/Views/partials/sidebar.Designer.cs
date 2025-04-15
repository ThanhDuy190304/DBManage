namespace SchoolManagerApp.src.Views.partials
{
    partial class sidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DBA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftArrow = new FontAwesome.Sharp.IconButton();
            this.rightArrow = new FontAwesome.Sharp.IconButton();
            this.UsersPage = new SchoolManagerApp.Controls.CTButton();
            this.RolesPage = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
            // 
            // DBA
            // 
            this.DBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DBA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBA.ForeColor = System.Drawing.SystemColors.Window;
            this.DBA.Location = new System.Drawing.Point(62, 33);
            this.DBA.Name = "DBA";
            this.DBA.Size = new System.Drawing.Size(109, 13);
            this.DBA.TabIndex = 0;
            this.DBA.Text = "DBA";
            this.DBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DBA.TextChanged += new System.EventHandler(this.DBA_Text);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(22, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 1;
            // 
            // leftArrow
            // 
            this.leftArrow.AutoSize = true;
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftArrow.FlatAppearance.BorderSize = 0;
            this.leftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrow.ForeColor = System.Drawing.Color.Transparent;
            this.leftArrow.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.leftArrow.IconColor = System.Drawing.Color.LightSteelBlue;
            this.leftArrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leftArrow.IconSize = 20;
            this.leftArrow.Location = new System.Drawing.Point(200, 26);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(31, 26);
            this.leftArrow.TabIndex = 4;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.AutoSize = true;
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightArrow.FlatAppearance.BorderSize = 0;
            this.rightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightArrow.ForeColor = System.Drawing.Color.Transparent;
            this.rightArrow.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.rightArrow.IconColor = System.Drawing.Color.Blue;
            this.rightArrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rightArrow.IconSize = 20;
            this.rightArrow.Location = new System.Drawing.Point(3, 26);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(31, 26);
            this.rightArrow.TabIndex = 5;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Visible = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // UsersPage
            // 
            this.UsersPage.BackColor = System.Drawing.Color.Transparent;
            this.UsersPage.BackgroundColor = System.Drawing.Color.Transparent;
            this.UsersPage.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsersPage.BorderRadius = 0;
            this.UsersPage.BorderSize = 0;
            this.UsersPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersPage.FlatAppearance.BorderSize = 0;
            this.UsersPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersPage.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.UsersPage.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.UsersPage.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.UsersPage.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.UsersPage.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UsersPage.IconColor = System.Drawing.Color.LightSteelBlue;
            this.UsersPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsersPage.IconSize = 24;
            this.UsersPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersPage.Location = new System.Drawing.Point(21, 130);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Size = new System.Drawing.Size(201, 41);
            this.UsersPage.TabIndex = 3;
            this.UsersPage.Text = "Quản lý users";
            this.UsersPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsersPage.TextColor = System.Drawing.Color.LightSteelBlue;
            this.UsersPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsersPage.UseVisualStyleBackColor = false;
            this.UsersPage.Click += new System.EventHandler(this.UsersPage_Click);
            // 
            // RolesPage
            // 
            this.RolesPage.BackColor = System.Drawing.Color.Transparent;
            this.RolesPage.BackgroundColor = System.Drawing.Color.Transparent;
            this.RolesPage.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RolesPage.BorderRadius = 0;
            this.RolesPage.BorderSize = 0;
            this.RolesPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RolesPage.FlatAppearance.BorderSize = 0;
            this.RolesPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RolesPage.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RolesPage.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RolesPage.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.RolesPage.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.RolesPage.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.RolesPage.IconColor = System.Drawing.Color.LightSteelBlue;
            this.RolesPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RolesPage.IconSize = 24;
            this.RolesPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RolesPage.Location = new System.Drawing.Point(21, 83);
            this.RolesPage.Name = "RolesPage";
            this.RolesPage.Size = new System.Drawing.Size(201, 41);
            this.RolesPage.TabIndex = 2;
            this.RolesPage.Text = "Quản lý roles";
            this.RolesPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RolesPage.TextColor = System.Drawing.Color.LightSteelBlue;
            this.RolesPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RolesPage.UseVisualStyleBackColor = false;
            this.RolesPage.Click += new System.EventHandler(this.RolesPage_Click);
            // 
            // sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.UsersPage);
            this.Controls.Add(this.RolesPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DBA);
            this.Name = "sidebar";
            this.Size = new System.Drawing.Size(245, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DBA;
        private System.Windows.Forms.Panel panel1;
        private Controls.CTButton RolesPage;
        private Controls.CTButton UsersPage;
        private FontAwesome.Sharp.IconButton leftArrow;
        private FontAwesome.Sharp.IconButton rightArrow;
    }
}
