namespace SchoolManagerApp.src.Views.forms.NVCB
{
    partial class CreateRegistration
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
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.StuCodeTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ctTextBox1 = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.EmpCodeLabel = new System.Windows.Forms.Label();
            this.CourseCodeTextBox = new SchoolManagerApp.src.Views.controls.CTTextBox();
            this.flowButtomLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new SchoolManagerApp.Controls.CTButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowButtomLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F);
            this.label5.Location = new System.Drawing.Point(121, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đăng ký môn";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowButtomLayoutPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 74);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 182);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.iconButton1);
            this.flowLayoutPanel4.Controls.Add(this.GenderLabel);
            this.flowLayoutPanel4.Controls.Add(this.StuCodeTextBox);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(351, 44);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(5, 8);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 27);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TabStop = false;
            this.iconButton1.Text = "\r\n\r\n";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.GenderLabel.Location = new System.Drawing.Point(50, 8);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(109, 22);
            this.GenderLabel.TabIndex = 1;
            this.GenderLabel.Text = "Mã sinh viên  ";
            // 
            // StuCodeTextBox
            // 
            this.StuCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StuCodeTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.StuCodeTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.StuCodeTextBox.BorderSize = 0;
            this.StuCodeTextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.StuCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.StuCodeTextBox.Location = new System.Drawing.Point(167, 6);
            this.StuCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StuCodeTextBox.Multiline = false;
            this.StuCodeTextBox.Name = "StuCodeTextBox";
            this.StuCodeTextBox.Padding = new System.Windows.Forms.Padding(4);
            this.StuCodeTextBox.PasswordChar = false;
            this.StuCodeTextBox.ReadOnly = false;
            this.StuCodeTextBox.Size = new System.Drawing.Size(173, 31);
            this.StuCodeTextBox.TabIndex = 0;
            this.StuCodeTextBox.Texts = "";
            this.StuCodeTextBox.UnderlinedStyle = false;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.iconButton8);
            this.flowLayoutPanel10.Controls.Add(this.label3);
            this.flowLayoutPanel10.Controls.Add(this.ctTextBox1);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(8, 47);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(351, 44);
            this.flowLayoutPanel10.TabIndex = 3;
            // 
            // iconButton8
            // 
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.VenusMars;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 20;
            this.iconButton8.Location = new System.Drawing.Point(5, 8);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(38, 27);
            this.iconButton8.TabIndex = 0;
            this.iconButton8.TabStop = false;
            this.iconButton8.Text = "\r\n\r\n";
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F);
            this.label3.Location = new System.Drawing.Point(50, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới tính         ";
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ctTextBox1.BorderColor = System.Drawing.SystemColors.Control;
            this.ctTextBox1.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.ctTextBox1.BorderSize = 0;
            this.ctTextBox1.Font = new System.Drawing.Font("Calibri", 13F);
            this.ctTextBox1.ForeColor = System.Drawing.Color.Black;
            this.ctTextBox1.Location = new System.Drawing.Point(165, 6);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.ReadOnly = true;
            this.ctTextBox1.Size = new System.Drawing.Size(173, 31);
            this.ctTextBox1.TabIndex = 10;
            this.ctTextBox1.Texts = "Null";
            this.ctTextBox1.UnderlinedStyle = false;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.iconButton10);
            this.flowLayoutPanel12.Controls.Add(this.label2);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(8, 103);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel12.Size = new System.Drawing.Size(351, 44);
            this.flowLayoutPanel12.TabIndex = 11;
            // 
            // iconButton10
            // 
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconButton10.IconColor = System.Drawing.Color.Black;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 20;
            this.iconButton10.Location = new System.Drawing.Point(5, 8);
            this.iconButton10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(38, 27);
            this.iconButton10.TabIndex = 0;
            this.iconButton10.TabStop = false;
            this.iconButton10.Text = "\r\n\r\n";
            this.iconButton10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F);
            this.label2.Location = new System.Drawing.Point(50, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.iconButton5);
            this.flowLayoutPanel3.Controls.Add(this.EmpCodeLabel);
            this.flowLayoutPanel3.Controls.Add(this.CourseCodeTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 66);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(351, 44);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // iconButton5
            // 
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 20;
            this.iconButton5.Location = new System.Drawing.Point(5, 8);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 27);
            this.iconButton5.TabIndex = 0;
            this.iconButton5.TabStop = false;
            this.iconButton5.Text = "\r\n\r\n";
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // EmpCodeLabel
            // 
            this.EmpCodeLabel.AutoSize = true;
            this.EmpCodeLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.EmpCodeLabel.Location = new System.Drawing.Point(50, 8);
            this.EmpCodeLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.EmpCodeLabel.Name = "EmpCodeLabel";
            this.EmpCodeLabel.Size = new System.Drawing.Size(111, 22);
            this.EmpCodeLabel.TabIndex = 1;
            this.EmpCodeLabel.Text = "Mã môn          ";
            // 
            // CourseCodeTextBox
            // 
            this.CourseCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CourseCodeTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CourseCodeTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CourseCodeTextBox.BorderSize = 0;
            this.CourseCodeTextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.CourseCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CourseCodeTextBox.Location = new System.Drawing.Point(169, 6);
            this.CourseCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CourseCodeTextBox.Multiline = false;
            this.CourseCodeTextBox.Name = "CourseCodeTextBox";
            this.CourseCodeTextBox.Padding = new System.Windows.Forms.Padding(4);
            this.CourseCodeTextBox.PasswordChar = false;
            this.CourseCodeTextBox.ReadOnly = false;
            this.CourseCodeTextBox.Size = new System.Drawing.Size(173, 31);
            this.CourseCodeTextBox.TabIndex = 1;
            this.CourseCodeTextBox.Texts = "";
            this.CourseCodeTextBox.UnderlinedStyle = false;
            // 
            // flowButtomLayoutPanel
            // 
            this.flowButtomLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowButtomLayoutPanel.Controls.Add(this.SaveButton);
            this.flowButtomLayoutPanel.Location = new System.Drawing.Point(10, 122);
            this.flowButtomLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.flowButtomLayoutPanel.Name = "flowButtomLayoutPanel";
            this.flowButtomLayoutPanel.Padding = new System.Windows.Forms.Padding(80, 2, 290, 2);
            this.flowButtomLayoutPanel.Size = new System.Drawing.Size(351, 49);
            this.flowButtomLayoutPanel.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderColor = System.Drawing.Color.Blue;
            this.SaveButton.BorderRadius = 3;
            this.SaveButton.BorderSize = 2;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.HoverIconColor = System.Drawing.Color.Blue;
            this.SaveButton.HoverTextColor = System.Drawing.Color.Blue;
            this.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.SaveButton.IconColor = System.Drawing.Color.Black;
            this.SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveButton.IconSize = 24;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(83, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(176, 40);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Xác nhận";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextColor = System.Drawing.Color.Black;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 265);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Name = "CreateRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRegistration";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowButtomLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label EmpCodeLabel;
        private controls.CTTextBox CourseCodeTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label GenderLabel;
        private controls.CTTextBox StuCodeTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Label label3;
        private controls.CTTextBox ctTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private FontAwesome.Sharp.IconButton iconButton10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowButtomLayoutPanel;
        private Controls.CTButton SaveButton;
    }
}