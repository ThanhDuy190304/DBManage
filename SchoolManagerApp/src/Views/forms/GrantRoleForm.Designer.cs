namespace SchoolManagerApp.src.Views.forms
{
    partial class GrantRoleForm
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
            this.WithGrantOptioncheckBox = new System.Windows.Forms.CheckBox();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.titleLabel.Location = new System.Drawing.Point(214, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(71, 22);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Cấp role";
            // 
            // WithGrantOptioncheckBox
            // 
            this.WithGrantOptioncheckBox.AutoSize = true;
            this.WithGrantOptioncheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithGrantOptioncheckBox.Location = new System.Drawing.Point(123, 139);
            this.WithGrantOptioncheckBox.Name = "WithGrantOptioncheckBox";
            this.WithGrantOptioncheckBox.Size = new System.Drawing.Size(142, 23);
            this.WithGrantOptioncheckBox.TabIndex = 16;
            this.WithGrantOptioncheckBox.Text = "With grant option";
            this.WithGrantOptioncheckBox.UseVisualStyleBackColor = true;
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
            this.confirmButton.Location = new System.Drawing.Point(211, 184);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.Location = new System.Drawing.Point(233, -177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cấp quyền";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RoleTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RoleTextBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.RoleTextBox.BorderSize = 2;
            this.RoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.RoleTextBox.Location = new System.Drawing.Point(236, 88);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoleTextBox.Multiline = false;
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.RoleTextBox.PasswordChar = false;
            this.RoleTextBox.Size = new System.Drawing.Size(200, 31);
            this.RoleTextBox.TabIndex = 18;
            this.RoleTextBox.Texts = "";
            this.RoleTextBox.UnderlinedStyle = false;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.RoleLabel.Location = new System.Drawing.Point(119, 88);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(72, 19);
            this.RoleLabel.TabIndex = 17;
            this.RoleLabel.Text = "Nhập role";
            // 
            // GrantRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 231);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.WithGrantOptioncheckBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "GrantRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox WithGrantOptioncheckBox;
        private Controls.CTButton confirmButton;
        private System.Windows.Forms.Label label1;
        private controls.CTTextBox RoleTextBox;
        private System.Windows.Forms.Label RoleLabel;
    }
}