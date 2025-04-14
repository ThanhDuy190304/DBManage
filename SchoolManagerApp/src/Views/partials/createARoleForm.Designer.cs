namespace SchoolManagerApp.src.Views.partials
{
    partial class createARoleForm
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
            this.ctTextBox1 = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.createARoleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new SchoolManagerApp.Controls.CTButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ctTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ctTextBox1.BorderSize = 2;
            this.ctTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ctTextBox1.Location = new System.Drawing.Point(87, 8);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.Size = new System.Drawing.Size(151, 31);
            this.ctTextBox1.TabIndex = 0;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlinedStyle = false;
            // 
            // createARoleLabel
            // 
            this.createARoleLabel.AutoSize = true;
            this.createARoleLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.createARoleLabel.Location = new System.Drawing.Point(122, 31);
            this.createARoleLabel.Name = "createARoleLabel";
            this.createARoleLabel.Size = new System.Drawing.Size(85, 23);
            this.createARoleLabel.TabIndex = 1;
            this.createARoleLabel.Text = "Tạo 1 role";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.roleNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.ctTextBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 48);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleNameLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.roleNameLabel.Location = new System.Drawing.Point(7, 10);
            this.roleNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(73, 22);
            this.roleNameLabel.TabIndex = 1;
            this.roleNameLabel.Text = "Tên role:";
            this.roleNameLabel.Click += new System.EventHandler(this.label1_Click);
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
            this.LoginButton.Location = new System.Drawing.Point(102, 147);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(121, 40);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Xác nhận";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.CausesValidation = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(308, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconExitButtot_Click);
            // 
            // createARoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 208);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.createARoleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createARoleForm";
            this.Load += new System.EventHandler(this.createARole_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.CTTextBox ctTextBox1;
        private System.Windows.Forms.Label createARoleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label roleNameLabel;
        private Controls.CTButton LoginButton;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
