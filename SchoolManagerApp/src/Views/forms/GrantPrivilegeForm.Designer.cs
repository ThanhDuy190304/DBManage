namespace SchoolManagerApp.src.Views.forms
{
    partial class GrantPrivilegeForm
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
            this.ColNameLabel = new System.Windows.Forms.Label();
            this.ObjectTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WithGrantOptioncheckBox = new System.Windows.Forms.CheckBox();
            this.ObjectTypeComboBox = new SchoolManagerApp.src.Views.controls.CTComboBox();
            this.ObjectNameTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.confirmButton = new SchoolManagerApp.Controls.CTButton();
            this.ColsNameTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.PirivilegeComboBox = new SchoolManagerApp.src.Views.controls.CTComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.titleLabel.Location = new System.Drawing.Point(216, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(86, 22);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Cấp quyền";
            // 
            // ChoosePrivilegeLabel
            // 
            this.ChoosePrivilegeLabel.AutoSize = true;
            this.ChoosePrivilegeLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ChoosePrivilegeLabel.Location = new System.Drawing.Point(58, 197);
            this.ChoosePrivilegeLabel.Name = "ChoosePrivilegeLabel";
            this.ChoosePrivilegeLabel.Size = new System.Drawing.Size(93, 19);
            this.ChoosePrivilegeLabel.TabIndex = 5;
            this.ChoosePrivilegeLabel.Text = "Chọn quyền: ";
            // 
            // ColNameLabel
            // 
            this.ColNameLabel.AutoSize = true;
            this.ColNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ColNameLabel.Location = new System.Drawing.Point(58, 270);
            this.ColNameLabel.Name = "ColNameLabel";
            this.ColNameLabel.Size = new System.Drawing.Size(386, 19);
            this.ColNameLabel.TabIndex = 6;
            this.ColNameLabel.Text = "Nhập tên các cột cách nhau bởi dấu , (VD: MaNV, HoTen): ";
            // 
            // ObjectTypeLabel
            // 
            this.ObjectTypeLabel.AutoSize = true;
            this.ObjectTypeLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ObjectTypeLabel.Location = new System.Drawing.Point(58, 60);
            this.ObjectTypeLabel.Name = "ObjectTypeLabel";
            this.ObjectTypeLabel.Size = new System.Drawing.Size(143, 19);
            this.ObjectTypeLabel.TabIndex = 10;
            this.ObjectTypeLabel.Text = "Chọn loại đối tượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(58, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập tên đối tượng:";
            // 
            // WithGrantOptioncheckBox
            // 
            this.WithGrantOptioncheckBox.AutoSize = true;
            this.WithGrantOptioncheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithGrantOptioncheckBox.Location = new System.Drawing.Point(62, 350);
            this.WithGrantOptioncheckBox.Name = "WithGrantOptioncheckBox";
            this.WithGrantOptioncheckBox.Size = new System.Drawing.Size(425, 23);
            this.WithGrantOptioncheckBox.TabIndex = 13;
            this.WithGrantOptioncheckBox.Text = "With grant option (Lưu ý: với role lựa chọn này không hợp lệ)";
            this.WithGrantOptioncheckBox.UseVisualStyleBackColor = true;
            // 
            // ObjectTypeComboBox
            // 
            this.ObjectTypeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ObjectTypeComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectTypeComboBox.BorderSize = 2;
            this.ObjectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ObjectTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ObjectTypeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.ObjectTypeComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectTypeComboBox.Items.AddRange(new object[] {
            "TABLE",
            "VIEW"});
            this.ObjectTypeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ObjectTypeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.ObjectTypeComboBox.Location = new System.Drawing.Point(62, 82);
            this.ObjectTypeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ObjectTypeComboBox.Name = "ObjectTypeComboBox";
            this.ObjectTypeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.ObjectTypeComboBox.Size = new System.Drawing.Size(200, 30);
            this.ObjectTypeComboBox.TabIndex = 11;
            this.ObjectTypeComboBox.Texts = "";
            // 
            // ObjectNameTextBox
            // 
            this.ObjectNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ObjectNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectNameTextBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ObjectNameTextBox.BorderSize = 2;
            this.ObjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ObjectNameTextBox.Location = new System.Drawing.Point(62, 153);
            this.ObjectNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectNameTextBox.Multiline = false;
            this.ObjectNameTextBox.Name = "ObjectNameTextBox";
            this.ObjectNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ObjectNameTextBox.PasswordChar = false;
            this.ObjectNameTextBox.Size = new System.Drawing.Size(200, 31);
            this.ObjectNameTextBox.TabIndex = 9;
            this.ObjectNameTextBox.Texts = "";
            this.ObjectNameTextBox.UnderlinedStyle = false;
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
            this.confirmButton.Location = new System.Drawing.Point(194, 386);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 40);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // ColsNameTextBox
            // 
            this.ColsNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ColsNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ColsNameTextBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ColsNameTextBox.BorderSize = 2;
            this.ColsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColsNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ColsNameTextBox.Location = new System.Drawing.Point(62, 303);
            this.ColsNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColsNameTextBox.Multiline = false;
            this.ColsNameTextBox.Name = "ColsNameTextBox";
            this.ColsNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ColsNameTextBox.PasswordChar = false;
            this.ColsNameTextBox.Size = new System.Drawing.Size(200, 31);
            this.ColsNameTextBox.TabIndex = 7;
            this.ColsNameTextBox.Texts = "";
            this.ColsNameTextBox.UnderlinedStyle = false;
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
            this.PirivilegeComboBox.Location = new System.Drawing.Point(62, 219);
            this.PirivilegeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.PirivilegeComboBox.Name = "PirivilegeComboBox";
            this.PirivilegeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.PirivilegeComboBox.Size = new System.Drawing.Size(200, 30);
            this.PirivilegeComboBox.TabIndex = 4;
            this.PirivilegeComboBox.Texts = "";
            // 
            // GrantPrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 446);
            this.Controls.Add(this.WithGrantOptioncheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjectTypeComboBox);
            this.Controls.Add(this.ObjectTypeLabel);
            this.Controls.Add(this.ObjectNameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ColsNameTextBox);
            this.Controls.Add(this.ColNameLabel);
            this.Controls.Add(this.ChoosePrivilegeLabel);
            this.Controls.Add(this.PirivilegeComboBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "GrantPrivilegeForm";
            this.Text = "GrantPrivilegeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ChoosePrivilegeLabel;
        private controls.CTComboBox PirivilegeComboBox;
        private System.Windows.Forms.Label ColNameLabel;
        private controls.CTTextBox ColsNameTextBox;
        private Controls.CTButton confirmButton;
        private controls.CTTextBox ObjectNameTextBox;
        private System.Windows.Forms.Label ObjectTypeLabel;
        private controls.CTComboBox ObjectTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WithGrantOptioncheckBox;
    }
}