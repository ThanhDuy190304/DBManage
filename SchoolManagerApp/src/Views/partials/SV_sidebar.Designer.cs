namespace SchoolManagerApp.src.Views.partials
{
    partial class SV_sidebar
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
            this.StudentCode_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightArrow = new FontAwesome.Sharp.IconButton();
            this.leftArrow = new FontAwesome.Sharp.IconButton();
            this.RegistrationsTab = new SchoolManagerApp.Controls.CTButton();
            this.CoursesTab = new SchoolManagerApp.Controls.CTButton();
            this.ProfileTab = new SchoolManagerApp.Controls.CTButton();
            this.LogoutButton = new SchoolManagerApp.Controls.CTButton();
            this.NotificationTab = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
            // 
            // StudentCode_Label
            // 
            this.StudentCode_Label.AutoSize = true;
            this.StudentCode_Label.Font = new System.Drawing.Font("Calibri", 12F);
            this.StudentCode_Label.Location = new System.Drawing.Point(12, 63);
            this.StudentCode_Label.Name = "StudentCode_Label";
            this.StudentCode_Label.Size = new System.Drawing.Size(43, 19);
            this.StudentCode_Label.TabIndex = 24;
            this.StudentCode_Label.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sinh viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 22;
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
            this.rightArrow.Location = new System.Drawing.Point(7, 27);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(31, 26);
            this.rightArrow.TabIndex = 20;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Visible = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
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
            this.leftArrow.Location = new System.Drawing.Point(216, 27);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(31, 26);
            this.leftArrow.TabIndex = 19;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // RegistrationsTab
            // 
            this.RegistrationsTab.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationsTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.RegistrationsTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrationsTab.BorderRadius = 0;
            this.RegistrationsTab.BorderSize = 0;
            this.RegistrationsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationsTab.FlatAppearance.BorderSize = 0;
            this.RegistrationsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationsTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationsTab.ForeColor = System.Drawing.Color.Black;
            this.RegistrationsTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrationsTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.RegistrationsTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.RegistrationsTab.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.RegistrationsTab.IconColor = System.Drawing.Color.Black;
            this.RegistrationsTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrationsTab.IconSize = 24;
            this.RegistrationsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationsTab.Location = new System.Drawing.Point(16, 202);
            this.RegistrationsTab.Name = "RegistrationsTab";
            this.RegistrationsTab.Size = new System.Drawing.Size(201, 41);
            this.RegistrationsTab.TabIndex = 27;
            this.RegistrationsTab.Text = "Danh sách đăng ký môn";
            this.RegistrationsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrationsTab.TextColor = System.Drawing.Color.Black;
            this.RegistrationsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrationsTab.UseVisualStyleBackColor = false;
            this.RegistrationsTab.Click += new System.EventHandler(this.RegistrationsTab_Click);
            // 
            // CoursesTab
            // 
            this.CoursesTab.BackColor = System.Drawing.Color.Transparent;
            this.CoursesTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.CoursesTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoursesTab.BorderRadius = 0;
            this.CoursesTab.BorderSize = 0;
            this.CoursesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoursesTab.FlatAppearance.BorderSize = 0;
            this.CoursesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoursesTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesTab.ForeColor = System.Drawing.Color.Black;
            this.CoursesTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CoursesTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.CoursesTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.CoursesTab.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.CoursesTab.IconColor = System.Drawing.Color.Black;
            this.CoursesTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CoursesTab.IconSize = 24;
            this.CoursesTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoursesTab.Location = new System.Drawing.Point(16, 155);
            this.CoursesTab.Name = "CoursesTab";
            this.CoursesTab.Size = new System.Drawing.Size(201, 41);
            this.CoursesTab.TabIndex = 26;
            this.CoursesTab.Text = "Mở môn";
            this.CoursesTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CoursesTab.TextColor = System.Drawing.Color.Black;
            this.CoursesTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CoursesTab.UseVisualStyleBackColor = false;
            this.CoursesTab.Click += new System.EventHandler(this.CoursesTab_Click);
            // 
            // ProfileTab
            // 
            this.ProfileTab.BackColor = System.Drawing.Color.Transparent;
            this.ProfileTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.ProfileTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileTab.BorderRadius = 0;
            this.ProfileTab.BorderSize = 0;
            this.ProfileTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileTab.FlatAppearance.BorderSize = 0;
            this.ProfileTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileTab.ForeColor = System.Drawing.Color.Black;
            this.ProfileTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ProfileTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.ProfileTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.ProfileTab.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ProfileTab.IconColor = System.Drawing.Color.Black;
            this.ProfileTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfileTab.IconSize = 24;
            this.ProfileTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileTab.Location = new System.Drawing.Point(16, 108);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(201, 41);
            this.ProfileTab.TabIndex = 25;
            this.ProfileTab.Text = "Thông tin cá nhân";
            this.ProfileTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileTab.TextColor = System.Drawing.Color.Black;
            this.ProfileTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileTab.UseVisualStyleBackColor = false;
            this.ProfileTab.Click += new System.EventHandler(this.ProfileTab_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BorderColor = System.Drawing.Color.Gray;
            this.LogoutButton.BorderRadius = 20;
            this.LogoutButton.BorderSize = 2;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutButton.HoverIconColor = System.Drawing.Color.Blue;
            this.LogoutButton.HoverTextColor = System.Drawing.Color.Blue;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.LogoutButton.IconColor = System.Drawing.Color.Black;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 20;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(70, 396);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(6);
            this.LogoutButton.Size = new System.Drawing.Size(118, 41);
            this.LogoutButton.TabIndex = 21;
            this.LogoutButton.Text = "Đăng xuất";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextColor = System.Drawing.Color.Black;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // NotificationTab
            // 
            this.NotificationTab.BackColor = System.Drawing.Color.Transparent;
            this.NotificationTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.NotificationTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NotificationTab.BorderRadius = 0;
            this.NotificationTab.BorderSize = 0;
            this.NotificationTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotificationTab.FlatAppearance.BorderSize = 0;
            this.NotificationTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTab.ForeColor = System.Drawing.Color.Black;
            this.NotificationTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.NotificationTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.NotificationTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.NotificationTab.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.NotificationTab.IconColor = System.Drawing.Color.Black;
            this.NotificationTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NotificationTab.IconSize = 24;
            this.NotificationTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationTab.Location = new System.Drawing.Point(16, 249);
            this.NotificationTab.Name = "NotificationTab";
            this.NotificationTab.Size = new System.Drawing.Size(201, 41);
            this.NotificationTab.TabIndex = 28;
            this.NotificationTab.Text = "Thông báo";
            this.NotificationTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NotificationTab.TextColor = System.Drawing.Color.Black;
            this.NotificationTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotificationTab.UseVisualStyleBackColor = false;
            // 
            // SV_sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotificationTab);
            this.Controls.Add(this.RegistrationsTab);
            this.Controls.Add(this.CoursesTab);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.StudentCode_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Name = "SV_sidebar";
            this.Size = new System.Drawing.Size(255, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentCode_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controls.CTButton LogoutButton;
        private FontAwesome.Sharp.IconButton rightArrow;
        private FontAwesome.Sharp.IconButton leftArrow;
        private Controls.CTButton ProfileTab;
        private Controls.CTButton CoursesTab;
        private Controls.CTButton RegistrationsTab;
        private Controls.CTButton NotificationTab;
    }
}
