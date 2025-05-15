using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class CreateStudent : Form
    {
        private readonly SinhVienController _stuController = new SinhVienController();

        public CreateStudent()
        {
            InitializeComponent();
            this.AcceptButton = this.SaveButton;
        }
        private void ResetEmpForm()
        {
            this.StuCodeTextBox.Texts = "";
            this.FullNameTextBox.Texts = "";
            this.GenderTextBox.Texts = "";
            this.BirthTextBox.Texts = "";
            this.AddressTextBox.Texts = "";
            this.PhoneTextBox.Texts = "";
            this.DepTextBox.Texts = "";
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string stuCode = this.StuCodeTextBox.Texts;
            string fullName = this.FullNameTextBox.Texts;
            string gender = this.GenderTextBox.Texts;
            DateTime birth = DateTime.ParseExact(
                this.BirthTextBox.Texts,
                new[] { "d/M/yyyy", "dd/MM/yyyy" },
                CultureInfo.InvariantCulture,
                DateTimeStyles.None
            );
            string address = this.AddressTextBox.Texts;
            string phone = this.PhoneTextBox.Texts;
            string department = this.DepTextBox.Texts;

            SINHVIEN newStu = new SINHVIEN
            {
                MASV = stuCode,
                HOTEN = fullName,
                PHAI = gender,
                NGSINH = birth,
                DCHI = address,
                DT = phone,
                KHOA = department,
            };

            try
            {
                await _stuController.Insert(newStu);
                MessageBox.Show($"Đã tạo sinh viên {stuCode} thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetEmpForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo sinh viên: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
