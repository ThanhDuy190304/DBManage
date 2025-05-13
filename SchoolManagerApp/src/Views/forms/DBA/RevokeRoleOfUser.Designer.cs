namespace SchoolManagerApp.src.Views.forms
{
    partial class RevokeRoleOfUser
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.titleLabel.Location = new System.Drawing.Point(171, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(97, 22);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Thu hồi role";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.RoleLabel.Location = new System.Drawing.Point(96, 68);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(72, 19);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Nhập role";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RoleTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RoleTextBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.RoleTextBox.BorderSize = 2;
            this.RoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.RoleTextBox.Location = new System.Drawing.Point(213, 68);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoleTextBox.Multiline = false;
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.RoleTextBox.PasswordChar = false;
            this.RoleTextBox.Size = new System.Drawing.Size(200, 31);
            this.RoleTextBox.TabIndex = 6;
            this.RoleTextBox.Texts = "";
            this.RoleTextBox.UnderlinedStyle = false;
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
            this.confirmButton.Location = new System.Drawing.Point(160, 116);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // RevokeRoleOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 167);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "RevokeRoleOfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevokeRoleOfUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label RoleLabel;
        private controls.CTTextBox RoleTextBox;
        private Controls.CTButton confirmButton;
    }
}