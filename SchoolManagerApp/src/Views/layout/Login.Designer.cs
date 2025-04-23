namespace SchoolManagerApp.src.Views.layout
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.userNameTextBox = new SchoolManagerApp.src.Views.controls.CTTextBoxIcon();
            this.LoginButton = new SchoolManagerApp.Controls.CTButton();
            this.passwordTextBox = new SchoolManagerApp.src.Views.controls.CTTextBoxIcon();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.Location = new System.Drawing.Point(109, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý nội bộ";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ExitButton.IconColor = System.Drawing.Color.DimGray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 20;
            this.ExitButton.Location = new System.Drawing.Point(333, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.userNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.userNameTextBox.BorderRadius = 20;
            this.userNameTextBox.BorderSize = 2;
            this.userNameTextBox.FocusBorderColor = System.Drawing.Color.MediumPurple;
            this.userNameTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userNameTextBox.IconColor = System.Drawing.Color.Gray;
            this.userNameTextBox.IconSize = 24;
            this.userNameTextBox.Location = new System.Drawing.Point(47, 90);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Padding = new System.Windows.Forms.Padding(95, 15, 95, 15);
            this.userNameTextBox.Size = new System.Drawing.Size(291, 40);
            this.userNameTextBox.TabIndex = 6;
            this.userNameTextBox.TextBackColor = System.Drawing.Color.Azure;
            this.userNameTextBox.TextForeColor = System.Drawing.Color.Gray;
            this.userNameTextBox.TextValue = "";
            this.userNameTextBox.UseSystemPasswordChar = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginButton.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.LoginButton.BorderColor = System.Drawing.Color.MediumPurple;
            this.LoginButton.BorderRadius = 20;
            this.LoginButton.BorderSize = 2;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.HoverIconColor = System.Drawing.Color.Blue;
            this.LoginButton.HoverTextColor = System.Drawing.Color.Black;
            this.LoginButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LoginButton.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginButton.IconSize = 24;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(114, 216);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 40);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Azure;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextBox.BorderRadius = 20;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.FocusBorderColor = System.Drawing.Color.MediumPurple;
            this.passwordTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordTextBox.IconColor = System.Drawing.Color.Gray;
            this.passwordTextBox.IconSize = 24;
            this.passwordTextBox.Location = new System.Drawing.Point(47, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(95, 15, 95, 15);
            this.passwordTextBox.Size = new System.Drawing.Size(291, 40);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextBackColor = System.Drawing.Color.Azure;
            this.passwordTextBox.TextForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.TextValue = "";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private controls.CTTextBoxIcon passwordTextBox;
        private Controls.CTButton LoginButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private controls.CTTextBoxIcon userNameTextBox;
    }
}