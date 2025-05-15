using FontAwesome.Sharp;
using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.controls;
using SchoolManagerApp.src.Models;
using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SchoolManagerApp.src.Views.pages.SV
{
    public partial class ProfilePage : UserControl
    {
        private readonly SinhVienController _stuController = new SinhVienController();
        private SINHVIEN _stu;
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
            SetTextBoxToInput(this.AddressTextBox);
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            bool result = await this.updateStu();
            if (result)
            {
                this.SaveAndCancelButtonLayoutPanel.Visible = false;
                this.EditButton.Visible = true;
                SetTextBoxToRead(this.PhoneTextBox);
                SetTextBoxToRead(this.AddressTextBox);
            }
        }
        private async Task<bool> updateStu()
        {
            dynamic updatedData = new ExpandoObject();
            var dict = (IDictionary<string, object>)updatedData;

            if (!string.IsNullOrWhiteSpace(this.PhoneTextBox.Texts) &&
               this.PhoneTextBox.Texts.Trim() != _stu.DT)
            {
                dict["DT"] = this.PhoneTextBox.Texts.Trim();
            }

            if (!string.IsNullOrWhiteSpace(this.AddressTextBox.Texts) &&
                this.AddressTextBox.Texts.Trim() != _stu.DCHI)
            {
                dict["DCHI"] = this.AddressTextBox.Texts.Trim();
            }

            if (dict.Count > 0)
            {
                try
                {
                    await _stuController.UpdateSinhVien(_stu.MASV, updatedData);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.SaveAndCancelButtonLayoutPanel.Visible = false;
            this.EditButton.Visible = true;
            SetTextBoxToRead(this.PhoneTextBox);
            SetTextBoxToRead(this.AddressTextBox);
        }
        private void updateUI()
        {
            this.StuCodeTextBox.Texts = _stu.MASV;
            this.GenderTextBox.Texts = _stu.PHAI;
            this.PhoneTextBox.Texts = _stu.DT;
            this.FullNameTextBox.Texts = _stu.HOTEN;
            this.BirthTextBox.Texts = _stu.NGSINH.ToString("dd/MM/yyyy");
            this.StatusTextBox.Texts = _stu.TINHTRANG;
            this.AddressTextBox.Texts = _stu.DCHI;
            this.DepTextBox.Texts = _stu.KHOA;
        }
        private async void GetProfile()
        {
            try
            {
                _stu = await _stuController.GetAStuInf();
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
