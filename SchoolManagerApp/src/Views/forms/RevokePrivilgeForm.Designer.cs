namespace SchoolManagerApp.src.Views.forms
{
    partial class RevokePrivilgeForm
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
            this.ChoosePrivilegeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.ObjectNameTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.PirivilegeComboBox = new SchoolManagerApp.src.Views.controls.CTComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.titleLabel.Location = new System.Drawing.Point(190, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 22);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Thu hồi quyền";
            // 
            // ChoosePrivilegeLabel
            // 
            this.ChoosePrivilegeLabel.AutoSize = true;
            this.ChoosePrivilegeLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ChoosePrivilegeLabel.Location = new System.Drawing.Point(81, 84);
            this.ChoosePrivilegeLabel.Name = "ChoosePrivilegeLabel";
            this.ChoosePrivilegeLabel.Size = new System.Drawing.Size(85, 19);
            this.ChoosePrivilegeLabel.TabIndex = 3;
            this.ChoosePrivilegeLabel.Text = "Chọn quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(81, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập tên đối tượng";
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
            this.confirmButton.Location = new System.Drawing.Point(208, 161);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // ObjectNameTextBox
            // 
            this.ObjectNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ObjectNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectNameTextBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectNameTextBox.BorderSize = 2;
            this.ObjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ObjectNameTextBox.Location = new System.Drawing.Point(279, 111);
            this.ObjectNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectNameTextBox.Multiline = false;
            this.ObjectNameTextBox.Name = "ObjectNameTextBox";
            this.ObjectNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ObjectNameTextBox.PasswordChar = false;
            this.ObjectNameTextBox.Size = new System.Drawing.Size(200, 31);
            this.ObjectNameTextBox.TabIndex = 5;
            this.ObjectNameTextBox.Texts = "";
            this.ObjectNameTextBox.UnderlinedStyle = false;
            // 
            // PirivilegeComboBox
            // 
            this.PirivilegeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PirivilegeComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.PirivilegeComboBox.BorderSize = 2;
            this.PirivilegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.PirivilegeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PirivilegeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.PirivilegeComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.PirivilegeComboBox.Items.AddRange(new object[] {
            "INSERT",
            "SELECT",
            "UPDATE",
            "DELETE"});
            this.PirivilegeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.PirivilegeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.PirivilegeComboBox.Location = new System.Drawing.Point(279, 73);
            this.PirivilegeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.PirivilegeComboBox.Name = "PirivilegeComboBox";
            this.PirivilegeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.PirivilegeComboBox.Size = new System.Drawing.Size(200, 30);
            this.PirivilegeComboBox.TabIndex = 1;
            this.PirivilegeComboBox.Texts = "";
            // 
            // RevokePrivilgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 222);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ObjectNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoosePrivilegeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.PirivilegeComboBox);
            this.Name = "RevokePrivilgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevokePrivilgeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.CTComboBox PirivilegeComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ChoosePrivilegeLabel;
        private System.Windows.Forms.Label label1;
        private controls.CTTextBox ObjectNameTextBox;
        private Controls.CTButton confirmButton;
    }
}