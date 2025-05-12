namespace SchoolManagerApp.src.Views.layout
{
    partial class NVCBMain
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
            this.ctTextBox11 = new SchoolManagerApp.src.Views.controls.CTTextBoxIcon();
            this.SuspendLayout();
            // 
            // ctTextBox11
            // 
            this.ctTextBox11.BorderColor = System.Drawing.Color.DimGray;
            this.ctTextBox11.BorderRadius = 20;
            this.ctTextBox11.BorderSize = 4;
            this.ctTextBox11.FocusBorderColor = System.Drawing.Color.Blue;
            this.ctTextBox11.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ctTextBox11.IconColor = System.Drawing.Color.LightGray;
            this.ctTextBox11.IconSize = 20;
            this.ctTextBox11.Location = new System.Drawing.Point(276, 98);
            this.ctTextBox11.Name = "ctTextBox11";
            this.ctTextBox11.Size = new System.Drawing.Size(315, 36);
            this.ctTextBox11.TabIndex = 0;
            this.ctTextBox11.Text = "ctTextBox11";
            this.ctTextBox11.TextBackColor = System.Drawing.Color.White;
            this.ctTextBox11.TextForeColor = System.Drawing.Color.Black;
            this.ctTextBox11.TextValue = "";
            this.ctTextBox11.UseSystemPasswordChar = false;
            // 
            // NVCBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctTextBox11);
            this.Name = "NVCBMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private controls.CTTextBoxIcon ctTextBox11;
    }
}