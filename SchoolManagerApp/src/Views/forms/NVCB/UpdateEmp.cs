using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class UpdateEmp : Form
    {
        private NhanVienController _nvController;
        private NHANVIEN _emp;
        public UpdateEmp(NHANVIEN emp)
        {
            InitializeComponent();
            this.AcceptButton = this.SaveButton;
            this._nvController = new NhanVienController();
            this._emp = emp;
            InitializeEmp();
        }

        private void InitializeEmp()
        {
            this.EmpCodeTextBox.Texts = this._emp.MANV;
            this.FullNameTextBox.Texts = this._emp.HOTEN;
            this.GenderComboBox.Texts = this._emp.PHAI;
            this.BirthTextBox.Texts = this._emp.NGSINH.ToString("dd/MM/yyyy");
            this.RoleComboBox.Texts = this._emp.VAITRO;
            this.SalaryTextBox.Texts = this._emp.LUONG.ToString();
            this.AllowanceTextBox.Texts = this._emp.PHUCAP.ToString();
            this.PhoneTextBox.Texts = this._emp.DT;
            this.DepComboBox.Texts = this._emp.MADV;
        }


        private async void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic updateData = new ExpandoObject();
            var dict = (IDictionary<string, object>)updateData;

            if (!string.IsNullOrWhiteSpace(this.EmpCodeTextBox.Texts) &&
                this.EmpCodeTextBox.Texts.Trim() != _emp.MANV)
            {
                dict["MANV"] = this.EmpCodeTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.FullNameTextBox.Texts) &&
                this.FullNameTextBox.Texts.Trim() != _emp.HOTEN)
            {
                dict["HOTEN"] = this.FullNameTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.GenderComboBox.Texts) &&
                this.GenderComboBox.Texts.Trim() != _emp.PHAI)
            {
                dict["PHAI"] = this.GenderComboBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.BirthTextBox.Texts))
            {
                if (DateTime.TryParseExact(this.BirthTextBox.Texts.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var newDate))
                {
                    if (newDate != _emp.NGSINH.Date)
                    {
                        dict["NGSINH"] = newDate;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(this.RoleComboBox.Texts) &&
                this.RoleComboBox.Texts.Trim() != _emp.VAITRO)
            {
                dict["VAITRO"] = this.RoleComboBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.SalaryTextBox.Texts) &&
                decimal.TryParse(this.SalaryTextBox.Texts.Trim(), out var newSalary) &&
                newSalary != _emp.LUONG)
            {
                dict["LUONG"] = newSalary;
            }

            if (!string.IsNullOrWhiteSpace(this.AllowanceTextBox.Texts) &&
                decimal.TryParse(this.AllowanceTextBox.Texts.Trim(), out var newAllowance) &&
                newAllowance != _emp.PHUCAP)
            {
                dict["PHUCAP"] = newAllowance;
            }

            if (!string.IsNullOrWhiteSpace(this.PhoneTextBox.Texts) &&
                this.PhoneTextBox.Texts.Trim() != _emp.DT)
            {
                dict["DT"] = this.PhoneTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.DepComboBox.Texts) &&
                this.DepComboBox.Texts.Trim() != _emp.MADV)
            {
                dict["MADV"] = this.DepComboBox.Texts.Trim();
            }

            if (dict.Count > 0)
            {
                try
                {
                    await _nvController.UpdateEmployeeDetails(_emp.MANV, updateData);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            InitializeEmp();
        }

       
    }
}
