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
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorNotiticationLabel = new System.Windows.Forms.Label();
            this.LoginButton = new SchoolManagerApp.Controls.CTButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(98, 9);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.UserNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserNameTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 126);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(9, 6);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 13);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Tên đăng nhập";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Mật khẩu";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(98, 61);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 20);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ErrorNotiticationLabel
            // 
            this.ErrorNotiticationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorNotiticationLabel.Location = new System.Drawing.Point(47, 193);
            this.ErrorNotiticationLabel.Name = "ErrorNotiticationLabel";
            this.ErrorNotiticationLabel.Size = new System.Drawing.Size(301, 13);
            this.ErrorNotiticationLabel.TabIndex = 3;
            this.ErrorNotiticationLabel.Text = "lỗi";
            this.ErrorNotiticationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorNotiticationLabel.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundColor = System.Drawing.Color.White;
            this.LoginButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginButton.BorderRadius = 12;
            this.LoginButton.BorderSize = 2;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.HoverIconColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginButton.HoverTextColor = System.Drawing.Color.Black;
            this.LoginButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.LoginButton.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginButton.IconSize = 20;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(145, 213);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(92, 26);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.ErrorNotiticationLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private Controls.CTButton LoginButton;
        private System.Windows.Forms.Label ErrorNotiticationLabel;
    }
}