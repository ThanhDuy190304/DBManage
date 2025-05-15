using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.pages.NVCB
{
    public partial class ProfilePage : UserControl
    {
        private readonly NhanVienController _nvController = new NhanVienController();

        private NHANVIEN _emp;
        public ProfilePage()
        {
            InitializeComponent();
            GetProfile();
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
            SetTextBoxToInput(this.PhoneTextBox);
        }
        private async Task<bool> updateEmp()
        {
           
            if (_emp.DT != this.PhoneTextBox.Texts.Trim())
            {
                try
                {
                    return await _nvController.UpdatePhoneNumberForNVCB(this.PhoneTextBox.Texts.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi cập nhật: {ex.Message}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            return false;
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            bool result = await this.updateEmp();
            if (result)
            {
                this.SaveAndCancelButtonLayoutPanel.Visible = false;
                this.EditButton.Visible = true;
                SetTextBoxToRead(this.PhoneTextBox);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.SaveAndCancelButtonLayoutPanel.Visible = false;
            this.EditButton.Visible = true;
            SetTextBoxToRead(this.PhoneTextBox);
        }

        private void updateUI()
        {
            this.EmpCodeTextBox.Texts = _emp.MANV;
            this.GenderTextBox.Texts = _emp.PHAI;
            this.PhoneTextBox.Texts = _emp.DT;
            this.RoleTextBox.Texts = _emp.VAITRO;
            this.FullNameTextBox.Texts = _emp.HOTEN;
            this.BirthTextBox.Texts = _emp.NGSINH.ToString("dd/MM/yyyy");
            this.SalaryTextBox.Texts = _emp.LUONG.ToString();
            this.AllowanceTextBox.Texts = _emp.PHUCAP.ToString();
            this.DepartmentTextBox.Texts = _emp.MADV;
        }
      
        private async void GetProfile()
        {
            try
            {
                _emp = await _nvController.GETPersonalInformationForNVCB();
                updateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi lấy thông tin cá nhân",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
