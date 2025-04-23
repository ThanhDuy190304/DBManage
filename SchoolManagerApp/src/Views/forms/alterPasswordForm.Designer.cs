namespace SchoolManagerApp.src.Views.forms
{
    partial class alterPasswordForm
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
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPasswordBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.ctButton1 = new SchoolManagerApp.Controls.CTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelPassword);
            this.flowLayoutPanel5.Controls.Add(this.textPasswordBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(64, 96);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(298, 52);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPassword.Location = new System.Drawing.Point(7, 10);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "New password";
            // 
            // textPasswordBox
            // 
            this.textPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.textPasswordBox.BorderColor = System.Drawing.Color.Gray;
            this.textPasswordBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textPasswordBox.BorderSize = 2;
            this.textPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.textPasswordBox.Location = new System.Drawing.Point(115, 8);
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
            this.iconButton1.Location = new System.Drawing.Point(404, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.confirmButton.Location = new System.Drawing.Point(281, 176);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ctButton1
            // 
            this.ctButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.ctButton1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ctButton1.BorderColor = System.Drawing.Color.Crimson;
            this.ctButton1.BorderRadius = 20;
            this.ctButton1.BorderSize = 2;
            this.ctButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctButton1.FlatAppearance.BorderSize = 0;
            this.ctButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctButton1.Font = new System.Drawing.Font("Calibri", 12F);
            this.ctButton1.ForeColor = System.Drawing.Color.Black;
            this.ctButton1.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ctButton1.HoverIconColor = System.Drawing.Color.BlueViolet;
            this.ctButton1.HoverTextColor = System.Drawing.Color.Black;
            this.ctButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ctButton1.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.ctButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ctButton1.IconSize = 24;
            this.ctButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctButton1.Location = new System.Drawing.Point(29, 176);
            this.ctButton1.Name = "ctButton1";
            this.ctButton1.Size = new System.Drawing.Size(235, 40);
            this.ctButton1.TabIndex = 12;
            this.ctButton1.Text = "Tắt xác thực bằng mật khẩu";
            this.ctButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctButton1.TextColor = System.Drawing.Color.Black;
            this.ctButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ctButton1.UseVisualStyleBackColor = false;
            this.ctButton1.Click += new System.EventHandler(this.TurnOffAuthenticationByPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.Location = new System.Drawing.Point(106, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tạo xác thực bằng mật khẩu";
            // 
            // alterPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(457, 249);
            this.Controls.Add(this.ctButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alterPasswordForm";
            this.Text = "updateFieldForm";
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelPassword;
        private controls.CTTextBox textPasswordBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Controls.CTButton confirmButton;
        private Controls.CTButton ctButton1;
        private System.Windows.Forms.Label label1;
    }
}