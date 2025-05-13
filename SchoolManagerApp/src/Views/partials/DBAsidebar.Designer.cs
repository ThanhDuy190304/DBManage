namespace SchoolManagerApp.src.Views.partials
{
    partial class DBAsidebar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftArrow = new FontAwesome.Sharp.IconButton();
            this.rightArrow = new FontAwesome.Sharp.IconButton();
            this.UsersPage = new SchoolManagerApp.Controls.CTButton();
            this.RolesPage = new SchoolManagerApp.Controls.CTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ctButton1 = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
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
            this.leftArrow.IconColor = System.Drawing.Color.Gray;
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
            this.rightArrow.IconColor = System.Drawing.Color.Gray;
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
            this.UsersPage.Font = new System.Drawing.Font("Calibri", 12F);
            this.UsersPage.ForeColor = System.Drawing.Color.Black;
            this.UsersPage.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.UsersPage.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.UsersPage.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.UsersPage.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UsersPage.IconColor = System.Drawing.Color.Black;
            this.UsersPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsersPage.IconSize = 24;
            this.UsersPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersPage.Location = new System.Drawing.Point(21, 130);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Size = new System.Drawing.Size(201, 41);
            this.UsersPage.TabIndex = 3;
            this.UsersPage.Text = "Quản lý users";
            this.UsersPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsersPage.TextColor = System.Drawing.Color.Black;
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
            this.RolesPage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolesPage.ForeColor = System.Drawing.Color.Black;
            this.RolesPage.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RolesPage.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.RolesPage.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.RolesPage.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.RolesPage.IconColor = System.Drawing.Color.Black;
            this.RolesPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RolesPage.IconSize = 24;
            this.RolesPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RolesPage.Location = new System.Drawing.Point(21, 83);
            this.RolesPage.Name = "RolesPage";
            this.RolesPage.Size = new System.Drawing.Size(201, 41);
            this.RolesPage.TabIndex = 2;
            this.RolesPage.Text = "Quản lý roles";
            this.RolesPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RolesPage.TextColor = System.Drawing.Color.Black;
            this.RolesPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RolesPage.UseVisualStyleBackColor = false;
            this.RolesPage.Click += new System.EventHandler(this.RolesPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F);
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "DBA";
            // 
            // ctButton1
            // 
            this.ctButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ctButton1.BackColor = System.Drawing.Color.Transparent;
            this.ctButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.ctButton1.BorderColor = System.Drawing.Color.Gray;
            this.ctButton1.BorderRadius = 20;
            this.ctButton1.BorderSize = 2;
            this.ctButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctButton1.FlatAppearance.BorderSize = 0;
            this.ctButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctButton1.Font = new System.Drawing.Font("Calibri", 12F);
            this.ctButton1.ForeColor = System.Drawing.Color.Black;
            this.ctButton1.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ctButton1.HoverIconColor = System.Drawing.Color.Blue;
            this.ctButton1.HoverTextColor = System.Drawing.Color.Blue;
            this.ctButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ctButton1.IconColor = System.Drawing.Color.Black;
            this.ctButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ctButton1.IconSize = 20;
            this.ctButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctButton1.Location = new System.Drawing.Point(55, 325);
            this.ctButton1.Name = "ctButton1";
            this.ctButton1.Padding = new System.Windows.Forms.Padding(6);
            this.ctButton1.Size = new System.Drawing.Size(118, 41);
            this.ctButton1.TabIndex = 7;
            this.ctButton1.Text = "Đăng xuất";
            this.ctButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctButton1.TextColor = System.Drawing.Color.Black;
            this.ctButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ctButton1.UseVisualStyleBackColor = false;
            this.ctButton1.Click += new System.EventHandler(this.Logout_Click);
            // 
            // sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ctButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.UsersPage);
            this.Controls.Add(this.RolesPage);
            this.Controls.Add(this.panel1);
            this.Name = "sidebar";
            this.Size = new System.Drawing.Size(243, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Controls.CTButton RolesPage;
        private Controls.CTButton UsersPage;
        private FontAwesome.Sharp.IconButton leftArrow;
        private FontAwesome.Sharp.IconButton rightArrow;
        private System.Windows.Forms.Label label1;
        private Controls.CTButton ctButton1;
    }
}
