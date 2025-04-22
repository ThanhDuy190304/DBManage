namespace SchoolManagerApp.src.Views.partials
{
    partial class createForm
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
            this.createLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.textNameBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.textPasswordBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.createLabel.Location = new System.Drawing.Point(122, 31);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(0, 23);
            this.createLabel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.textNameBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 44);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.nameLabel.Location = new System.Drawing.Point(7, 10);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Username";
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
            this.iconButton1.Location = new System.Drawing.Point(320, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconExitButton_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelPassword);
            this.flowLayoutPanel5.Controls.Add(this.textPasswordBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(51, 129);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(273, 52);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 13F);
            this.labelPassword.Location = new System.Drawing.Point(7, 10);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 6, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 22);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.AliceBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.MediumPurple;
            this.confirmButton.BorderRadius = 20;
            this.confirmButton.BorderSize = 2;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.confirmButton.HoverIconColor = System.Drawing.Color.Blue;
            this.confirmButton.HoverTextColor = System.Drawing.Color.Black;
            this.confirmButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.confirmButton.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.confirmButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmButton.IconSize = 24;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmButton.Location = new System.Drawing.Point(112, 187);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // textNameBox
            // 
            this.textNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.textNameBox.BorderColor = System.Drawing.Color.Gray;
            this.textNameBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textNameBox.BorderSize = 2;
            this.textNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.textNameBox.Location = new System.Drawing.Point(96, 8);
            this.textNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.textNameBox.Multiline = false;
            this.textNameBox.Name = "textNameBox";
            this.textNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.textNameBox.PasswordChar = false;
            this.textNameBox.Size = new System.Drawing.Size(146, 31);
            this.textNameBox.TabIndex = 0;
            this.textNameBox.Texts = "";
            this.textNameBox.UnderlinedStyle = false;
            // 
            // textPasswordBox
            // 
            this.textPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.textPasswordBox.BorderColor = System.Drawing.Color.Gray;
            this.textPasswordBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textPasswordBox.BorderSize = 2;
            this.textPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.textPasswordBox.Location = new System.Drawing.Point(97, 8);
            this.textPasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.textPasswordBox.Multiline = false;
            this.textPasswordBox.Name = "textPasswordBox";
            this.textPasswordBox.Padding = new System.Windows.Forms.Padding(7);
            this.textPasswordBox.PasswordChar = false;
            this.textPasswordBox.Size = new System.Drawing.Size(151, 31);
            this.textPasswordBox.TabIndex = 0;
            this.textPasswordBox.Texts = "";
            this.textPasswordBox.UnderlinedStyle = false;
            // 
            // createForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 239);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.flowLayoutPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.CTTextBox textNameBox;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private Controls.CTButton confirmButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelPassword;
        private controls.CTTextBox textPasswordBox;
    }
}
