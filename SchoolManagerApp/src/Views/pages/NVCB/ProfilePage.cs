using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.pages.NVCB
{
    public partial class ProfilePage : UserControl
    {
        private NhanVienController _nvController;

        private NHANVIEN _emp;
        public ProfilePage()
        {
            InitializeComponent();
            _nvController = new NhanVienController();
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
            SetTextBoxToInput(this.EmpCodeTextBox);
            SetTextBoxToInput(this.GenderTextBox);
            SetTextBoxToInput(this.PhoneTextBox);
            SetTextBoxToInput(this.RoleTextBox);
            SetTextBoxToInput(this.BirthTextBox);
            SetTextBoxToInput(this.FullNameTextBox);
            SetTextBoxToInput(this.SalaryTextBox);
            SetTextBoxToInput(this.AllowanceTextBox);
            SetTextBoxToInput(this.DepartmentTextBox);
        }
        private async Task<bool> updateEmp()
        {
            dynamic updateData = new ExpandoObject();
            var dataDict = (IDictionary<string, object>)updateData;

            if (_emp.MANV != this.EmpCodeTextBox.Texts.Trim())
                dataDict["MANV"] = this.EmpCodeTextBox.Texts.Trim();

            if (_emp.HOTEN != this.FullNameTextBox.Texts.Trim())
                dataDict["HOTEN"] = this.FullNameTextBox.Texts.Trim();

            if (_emp.PHAI != this.GenderTextBox.Texts.Trim())
                dataDict["PHAI"] = this.GenderTextBox.Texts.Trim();

            if (_emp.DT != this.PhoneTextBox.Texts.Trim())
                dataDict["DT"] = this.PhoneTextBox.Texts.Trim();

            if (_emp.VAITRO != this.RoleTextBox.Texts.Trim())
                dataDict["VAITRO"] = this.RoleTextBox.Texts.Trim();

            if (_emp.MADV != this.DepartmentTextBox.Texts.Trim())
                dataDict["MADV"] = this.DepartmentTextBox.Texts.Trim();

            if (_emp.NGSINH.ToString("dd/MM/yyyy") != this.BirthTextBox.Texts.Trim())
            {
                if (DateTime.TryParseExact(this.BirthTextBox.Texts.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngsinh))
                    dataDict["NGSINH"] = ngsinh;
            }

            if (_emp.LUONG.ToString() != this.SalaryTextBox.Texts.Trim())
            {
                if (decimal.TryParse(this.SalaryTextBox.Texts.Trim(), out decimal luong))
                    dataDict["LUONG"] = luong;
            }

            if (_emp.PHUCAP.ToString() != this.AllowanceTextBox.Texts.Trim())
            {
                if (decimal.TryParse(this.AllowanceTextBox.Texts.Trim(), out decimal phucap))
                    dataDict["PHUCAP"] = phucap;
            }

            try
            {
                if (dataDict.Count > 0)
                {
                    var changedFields = string.Join("\n", dataDict.Select(kv => $"{kv.Key}: {kv.Value}"));
                    MessageBox.Show($"Cập nhật thành công các trường:\n{changedFields}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return await _nvController.UpdateEmployeeDetails(_emp.MANV, updateData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SetTextBoxToRead(this.EmpCodeTextBox);
                SetTextBoxToRead(this.GenderTextBox);
                SetTextBoxToRead(this.PhoneTextBox);
                SetTextBoxToRead(this.RoleTextBox);
                SetTextBoxToRead(this.BirthTextBox);
                SetTextBoxToRead(this.FullNameTextBox);
                SetTextBoxToRead(this.SalaryTextBox);
                SetTextBoxToRead(this.AllowanceTextBox);
                SetTextBoxToRead(this.DepartmentTextBox);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.SaveAndCancelButtonLayoutPanel.Visible = false;
            this.EditButton.Visible = true;
            SetTextBoxToRead(this.EmpCodeTextBox);
            SetTextBoxToRead(this.GenderTextBox);
            SetTextBoxToRead(this.PhoneTextBox);
            SetTextBoxToRead(this.RoleTextBox);
            SetTextBoxToRead(this.BirthTextBox);
            SetTextBoxToRead(this.FullNameTextBox);
            SetTextBoxToRead(this.SalaryTextBox);
            SetTextBoxToRead(this.AllowanceTextBox);
            SetTextBoxToRead(this.DepartmentTextBox);
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
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi lấy thông tin cá nhân",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
