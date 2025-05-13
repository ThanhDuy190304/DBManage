using SchoolManagerApp.src.Views.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.pages.NVCB
{
    public partial class ProfilePage : UserControl
    {
        public ProfilePage()
        {
            InitializeComponent();
            this.flowButtomLayoutPanel.Controls.Add(this.SaveAndCancelButtonLayoutPanel);
        }

        private void SetTextBoxToInput(CTTextBox textBox)
        {
            textBox.ReadOnly = false;
            textBox.BackColor = Color.White;
            textBox.BorderColor = Color.MediumSlateBlue;
            textBox.BorderFocusColor = Color.HotPink;
        }

        private void SetTextBoxToRead(CTTextBox textBox)
        {
            textBox.ReadOnly = true;
            textBox.BackColor = Color.FromArgb(240, 240, 240);
            textBox.BorderColor = Color.FromArgb(240, 240, 240);
            textBox.BorderFocusColor = Color.FromArgb(240, 240, 240);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.EditButton.Visible = false; 
            this.SaveAndCancelButtonLayoutPanel.Visible = true;
            SetTextBoxToInput(this.EmpCodeTextBox);
            SetTextBoxToInput(this.GenderTextBox);
            SetTextBoxToInput(this.PhoneTextBox);
            SetTextBoxToInput(this.RoleTextBox);
            SetTextBoxToInput(this.FullNameTextBox);
            SetTextBoxToInput(this.SalaryTextBox);
            SetTextBoxToInput(this.AllowanceTextBox);
            SetTextBoxToInput(this.DepartmentTextBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.SaveAndCancelButtonLayoutPanel.Visible = false;
            this.EditButton.Visible = true; 
            SetTextBoxToRead(this.EmpCodeTextBox);
            SetTextBoxToRead(this.GenderTextBox);
            SetTextBoxToRead(this.PhoneTextBox);
            SetTextBoxToRead(this.RoleTextBox);
            SetTextBoxToRead(this.FullNameTextBox);
            SetTextBoxToRead(this.SalaryTextBox);
            SetTextBoxToRead(this.AllowanceTextBox);
            SetTextBoxToRead(this.DepartmentTextBox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.SaveAndCancelButtonLayoutPanel.Visible = false;
            this.EditButton.Visible = true;
            SetTextBoxToRead(this.EmpCodeTextBox);
            SetTextBoxToRead(this.GenderTextBox);
            SetTextBoxToRead(this.PhoneTextBox);
            SetTextBoxToRead(this.RoleTextBox);
            SetTextBoxToRead(this.FullNameTextBox);
            SetTextBoxToRead(this.SalaryTextBox);
            SetTextBoxToRead(this.AllowanceTextBox);
            SetTextBoxToRead(this.DepartmentTextBox);
        }

    
    }
}
