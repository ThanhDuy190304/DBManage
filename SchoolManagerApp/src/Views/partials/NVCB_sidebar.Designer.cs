namespace SchoolManagerApp.src.Views.partials
{
    partial class NVCB_sidebar
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
            this.rightArrow = new FontAwesome.Sharp.IconButton();
            this.leftArrow = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpsTab = new SchoolManagerApp.Controls.CTButton();
            this.ProfileTab = new SchoolManagerApp.Controls.CTButton();
            this.LogoutButton = new SchoolManagerApp.Controls.CTButton();
            this.CoursesTab = new SchoolManagerApp.Controls.CTButton();
            this.StudentsTab = new SchoolManagerApp.Controls.CTButton();
            this.RegistrationsTab = new SchoolManagerApp.Controls.CTButton();
            this.EmpCode_And_Role_Label = new System.Windows.Forms.Label();
            this.NotificationTab = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
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
            this.rightArrow.Location = new System.Drawing.Point(2, 27);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(31, 26);
            this.rightArrow.TabIndex = 9;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Visible = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.leftArrow.Location = new System.Drawing.Point(225, 27);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(31, 26);
            this.leftArrow.TabIndex = 8;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 2);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhân viên";
            // 
            // EmpsTab
            // 
            this.EmpsTab.BackColor = System.Drawing.Color.Transparent;
            this.EmpsTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.EmpsTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpsTab.BorderRadius = 0;
            this.EmpsTab.BorderSize = 0;
            this.EmpsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpsTab.FlatAppearance.BorderSize = 0;
            this.EmpsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpsTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpsTab.ForeColor = System.Drawing.Color.Black;
            this.EmpsTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.EmpsTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.EmpsTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.EmpsTab.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.EmpsTab.IconColor = System.Drawing.Color.Black;
            this.EmpsTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpsTab.IconSize = 24;
            this.EmpsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpsTab.Location = new System.Drawing.Point(11, 148);
            this.EmpsTab.Name = "EmpsTab";
            this.EmpsTab.Size = new System.Drawing.Size(201, 41);
            this.EmpsTab.TabIndex = 14;
            this.EmpsTab.Text = "Nhân viên ";
            this.EmpsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmpsTab.TextColor = System.Drawing.Color.Black;
            this.EmpsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmpsTab.UseVisualStyleBackColor = false;
            this.EmpsTab.Click += new System.EventHandler(this.EmpsButton_Click);
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
            this.ProfileTab.Location = new System.Drawing.Point(11, 101);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(201, 41);
            this.ProfileTab.TabIndex = 13;
            this.ProfileTab.Text = "Thông tin cá nhân";
            this.ProfileTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileTab.TextColor = System.Drawing.Color.Black;
            this.ProfileTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileTab.UseVisualStyleBackColor = false;
            this.ProfileTab.Click += new System.EventHandler(this.ProfilePage_Click);
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
            this.LogoutButton.Location = new System.Drawing.Point(72, 396);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(6);
            this.LogoutButton.Size = new System.Drawing.Size(118, 41);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Đăng xuất";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextColor = System.Drawing.Color.Black;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            this.CoursesTab.Location = new System.Drawing.Point(11, 242);
            this.CoursesTab.Name = "CoursesTab";
            this.CoursesTab.Size = new System.Drawing.Size(201, 41);
            this.CoursesTab.TabIndex = 15;
            this.CoursesTab.Text = "Mở môn";
            this.CoursesTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CoursesTab.TextColor = System.Drawing.Color.Black;
            this.CoursesTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CoursesTab.UseVisualStyleBackColor = false;
            this.CoursesTab.Click += new System.EventHandler(this.CourseButton_Click);
            // 
            // StudentsTab
            // 
            this.StudentsTab.BackColor = System.Drawing.Color.Transparent;
            this.StudentsTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.StudentsTab.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentsTab.BorderRadius = 0;
            this.StudentsTab.BorderSize = 0;
            this.StudentsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentsTab.FlatAppearance.BorderSize = 0;
            this.StudentsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsTab.ForeColor = System.Drawing.Color.Black;
            this.StudentsTab.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsTab.HoverIconColor = System.Drawing.Color.MediumBlue;
            this.StudentsTab.HoverTextColor = System.Drawing.Color.MediumBlue;
            this.StudentsTab.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.StudentsTab.IconColor = System.Drawing.Color.Black;
            this.StudentsTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StudentsTab.IconSize = 24;
            this.StudentsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsTab.Location = new System.Drawing.Point(11, 195);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Size = new System.Drawing.Size(201, 41);
            this.StudentsTab.TabIndex = 16;
            this.StudentsTab.Text = "Sinh viên";
            this.StudentsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentsTab.TextColor = System.Drawing.Color.Black;
            this.StudentsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudentsTab.UseVisualStyleBackColor = false;
            this.StudentsTab.Click += new System.EventHandler(this.StudentsButton_Click);
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
            this.RegistrationsTab.Location = new System.Drawing.Point(11, 289);
            this.RegistrationsTab.Name = "RegistrationsTab";
            this.RegistrationsTab.Size = new System.Drawing.Size(201, 41);
            this.RegistrationsTab.TabIndex = 17;
            this.RegistrationsTab.Text = "Danh sách đăng ký môn";
            this.RegistrationsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrationsTab.TextColor = System.Drawing.Color.Black;
            this.RegistrationsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrationsTab.UseVisualStyleBackColor = false;
            this.RegistrationsTab.Click += new System.EventHandler(this.RegistrationsButton_Click);
            // 
            // EmpCode_And_Role_Label
            // 
            this.EmpCode_And_Role_Label.AutoSize = true;
            this.EmpCode_And_Role_Label.Font = new System.Drawing.Font("Calibri", 12F);
            this.EmpCode_And_Role_Label.Location = new System.Drawing.Point(7, 63);
            this.EmpCode_And_Role_Label.Name = "EmpCode_And_Role_Label";
            this.EmpCode_And_Role_Label.Size = new System.Drawing.Size(43, 19);
            this.EmpCode_And_Role_Label.TabIndex = 18;
            this.EmpCode_And_Role_Label.Text = "NULL";
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
            this.NotificationTab.Location = new System.Drawing.Point(11, 336);
            this.NotificationTab.Name = "NotificationTab";
            this.NotificationTab.Size = new System.Drawing.Size(201, 41);
            this.NotificationTab.TabIndex = 29;
            this.NotificationTab.Text = "Thông báo";
            this.NotificationTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NotificationTab.TextColor = System.Drawing.Color.Black;
            this.NotificationTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotificationTab.UseVisualStyleBackColor = false;
            this.NotificationTab.Click += new System.EventHandler(this.NotificationTab_Click);
            // 
            // NVCB_sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.NotificationTab);
            this.Controls.Add(this.EmpCode_And_Role_Label);
            this.Controls.Add(this.RegistrationsTab);
            this.Controls.Add(this.StudentsTab);
            this.Controls.Add(this.CoursesTab);
            this.Controls.Add(this.EmpsTab);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Name = "NVCB_sidebar";
            this.Size = new System.Drawing.Size(269, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CTButton LogoutButton;
        private FontAwesome.Sharp.IconButton rightArrow;
        private FontAwesome.Sharp.IconButton leftArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Controls.CTButton ProfileTab;
        private Controls.CTButton EmpsTab;
        private Controls.CTButton CoursesTab;
        private Controls.CTButton StudentsTab;
        private Controls.CTButton RegistrationsTab;
        private System.Windows.Forms.Label EmpCode_And_Role_Label;
        private Controls.CTButton NotificationTab;
    }
}
