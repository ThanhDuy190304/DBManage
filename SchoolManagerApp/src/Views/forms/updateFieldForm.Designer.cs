namespace SchoolManagerApp.src.Views.forms
{
    partial class updateFieldForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textNameBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPasswordBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.textNameBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 44);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.nameLabel.Location = new System.Drawing.Point(7, 10);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Field";
            // 
            // textNameBox
            // 
            this.textNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.textNameBox.BorderColor = System.Drawing.Color.Gray;
            this.textNameBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textNameBox.BorderSize = 2;
            this.textNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.textNameBox.Location = new System.Drawing.Point(61, 8);
            this.textNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.textNameBox.Multiline = false;
            this.textNameBox.Name = "textNameBox";
            this.textNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.textNameBox.PasswordChar = false;
            this.textNameBox.Size = new System.Drawing.Size(157, 31);
            this.textNameBox.TabIndex = 0;
            this.textNameBox.Texts = "";
            this.textNameBox.UnderlinedStyle = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelPassword);
            this.flowLayoutPanel5.Controls.Add(this.textPasswordBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(39, 125);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(255, 52);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 13F);
            this.labelPassword.Location = new System.Drawing.Point(7, 10);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 22);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Value";
            // 
            // textPasswordBox
            // 
            this.textPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.textPasswordBox.BorderColor = System.Drawing.Color.Gray;
            this.textPasswordBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textPasswordBox.BorderSize = 2;
            this.textPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.textPasswordBox.Location = new System.Drawing.Point(61, 8);
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
            this.iconButton1.Location = new System.Drawing.Point(280, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // updateFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateFieldForm";
            this.Text = "updateFieldForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private controls.CTTextBox textNameBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelPassword;
        private controls.CTTextBox textPasswordBox;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}