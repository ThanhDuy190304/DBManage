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
            this._nvController = new NhanVienController();
            this._emp = emp;
            InitializeEmp();
        }

        private void InitializeEmp()
        {
            this.EmpCodeTextBox.Texts = this._emp.MANV;
            this.FullNameTextBox.Texts = this._emp.HOTEN;
            this.GenderTextBox.Texts = this._emp.PHAI;
            this.BirthTextBox.Texts = this._emp.NGSINH.ToString("dd/MM/yyyy");
            this.RoleTextBox.Texts = this._emp.VAITRO;
            this.SalaryTextBox.Texts = this._emp.LUONG.ToString();
            this.AllowanceTextBox.Texts = this._emp.PHUCAP.ToString();
            this.PhoneTextBox.Texts = this._emp.DT;
            this.DepTextBox.Texts = this._emp.MADV;
        }


        private async void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic updateData = new ExpandoObject();
            var dict = (IDictionary<string, object>)updateData;

            if (this.EmpCodeTextBox.Texts.Trim() != _emp.MANV)
                dict["MANV"] = this.EmpCodeTextBox.Texts;

            if (this.FullNameTextBox.Texts.Trim() != _emp.HOTEN)
                dict["HOTEN"] = this.FullNameTextBox.Texts;

            if (this.GenderTextBox.Texts.Trim() != _emp.PHAI)
                dict["PHAI"] = this.GenderTextBox.Texts;

            if (this.BirthTextBox.Texts.Trim() != _emp.NGSINH.ToString("dd/MM/yyyy"))
                dict["NGSINH"] = DateTime.ParseExact(this.BirthTextBox.Texts, "d/M/yyyy", CultureInfo.InvariantCulture);

            if (this.RoleTextBox.Texts.Trim() != _emp.VAITRO)
                dict["VAITRO"] = this.RoleTextBox.Texts;

            if (this.SalaryTextBox.Texts.Trim() != _emp.LUONG.ToString())
                dict["LUONG"] = decimal.Parse(this.SalaryTextBox.Texts);

            if (this.AllowanceTextBox.Texts.Trim() != _emp.PHUCAP.ToString())
                dict["PHUCAP"] = decimal.Parse(this.AllowanceTextBox.Texts);

            if (this.PhoneTextBox.Texts.Trim() != _emp.DT)
                dict["DT"] = this.PhoneTextBox.Texts;

            if (this.DepTextBox.Texts.Trim() != _emp.MADV)
                dict["MADV"] = this.DepTextBox.Texts;

            if (dict.Count > 0)
            {
                await _nvController.UpdateEmployeeDetails(_emp.MANV, updateData);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
