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
    public partial class UpdateStudent : Form
    {
        private readonly SinhVienController _stuController = new SinhVienController();
        private readonly SINHVIEN _student;
        public UpdateStudent(SINHVIEN student)
        {
            InitializeComponent();
            this.AcceptButton = this.SaveButton;
            this._student = student;
            InitializeStu();
        }
        private void InitializeStu()
        {
            this.StuCodeTextBox.Texts = this._student.MASV;
            this.FullNameTextBox.Texts = this._student.HOTEN;
            this.GenderTextBox.Texts = this._student.PHAI;
            this.BirthTextBox.Texts = this._student.NGSINH.ToString("dd/MM/yyyy");
            this.PhoneTextBox.Texts = this._student.DT;
            this.DepTextBox.Texts = this._student.KHOA;
            this.AddressTextBox.Texts = this._student.DCHI;
            this.CancelStatusIconButton_Click(null, EventArgs.Empty);
        }

        private void CancelStatusIconButton_Click(object sender, EventArgs e)
        {
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.BackColor = Color.FromArgb(240, 240, 240);
            this.StatusTextBox.BorderColor = Color.FromArgb(240, 240, 240);
            this.StatusTextBox.BorderFocusColor = Color.FromArgb(240, 240, 240);
            this.StatusTextBox.Texts = _student.TINHTRANG;

            this.CancelStatusIconButton.Visible = false;
            this.EditStatusIconButton.Visible = true;
        }

        private void EditStatusIconButton_Click(object sender, EventArgs e)
        {
            this.StatusTextBox.ReadOnly = false;
            this.StatusTextBox.BackColor = Color.White;
            this.StatusTextBox.BorderColor = Color.MediumSlateBlue;
            this.StatusTextBox.BorderFocusColor = Color.HotPink;

            this.CancelStatusIconButton.Visible = true;
            this.EditStatusIconButton.Visible = false;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic updatedData = new ExpandoObject();
            var dict = (IDictionary<string, object>)updatedData;

            if (!string.IsNullOrWhiteSpace(this.StuCodeTextBox.Texts) &&
                this.StuCodeTextBox.Texts.Trim() != _student.MASV)
            {
                dict["MASV"] = this.StuCodeTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.FullNameTextBox.Texts) &&
                this.FullNameTextBox.Texts.Trim() != _student.HOTEN)
            {
                dict["HOTEN"] = this.FullNameTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.GenderTextBox.Texts) &&
                this.GenderTextBox.Texts.Trim() != _student.PHAI)
            {
                dict["PHAI"] = this.GenderTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.AddressTextBox.Texts) &&
                this.AddressTextBox.Texts.Trim() != _student.DCHI)
            {
                dict["DCHI"] = this.AddressTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.BirthTextBox.Texts) &&
                this.BirthTextBox.Texts.Trim() != _student.NGSINH.ToString("dd/MM/yyyy"))
            {
                dict["NGSINH"] = DateTime.ParseExact(this.BirthTextBox.Texts.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);
            }

            if (!string.IsNullOrWhiteSpace(this.PhoneTextBox.Texts) &&
                this.PhoneTextBox.Texts.Trim() != _student.DT)
            {
                dict["DT"] = this.PhoneTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.DepTextBox.Texts) &&
                this.DepTextBox.Texts.Trim() != _student.KHOA)
            {
                dict["KHOA"] = this.DepTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.StatusTextBox.Texts) &&
                this.StatusTextBox.Texts.Trim() != _student.TINHTRANG)
            {
                dict["TINHTRANG"] = this.StatusTextBox.Texts.Trim();
            }

            if (dict.Count > 0)
            {
                try
                {
                    await _stuController.UpdateSinhVien(_student.MASV, updatedData);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch(Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            InitializeStu();
        }

        
    }
}
