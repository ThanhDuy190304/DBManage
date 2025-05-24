using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class CreateEmp : Form
    {
        private NhanVienController _empController;
        public CreateEmp()
        {
            InitializeComponent();
            _empController = new NhanVienController();
            this.AcceptButton = this.SaveButton;
        }
        private void ResetEmpForm()
        {
            this.EmpCodeTextBox.Texts = "";
            this.FullNameTextBox.Texts = "";
            this.GenderComboBox.Texts = "";
            this.BirthTextBox.Texts = "";
            this.RoleComboBox.Texts = "";
            this.SalaryTextBox.Texts = "";
            this.AllowanceTextBox.Texts = "";
            this.PhoneTextBox.Texts = "";
            this.DepComboBox.Texts = "";
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string empCode = this.EmpCodeTextBox.Texts;
            string fullName = this.FullNameTextBox.Texts;
            string gender = this.GenderComboBox.Texts;
            DateTime birth = DateTime.ParseExact(
                this.BirthTextBox.Texts,
                new[] { "d/M/yyyy", "dd/MM/yyyy" },
                CultureInfo.InvariantCulture,
                DateTimeStyles.None
            );
            string role = this.RoleComboBox.Texts;
            decimal salary = decimal.Parse(this.SalaryTextBox.Texts);
            decimal allowance = decimal.Parse(this.AllowanceTextBox.Texts);
            string phone = this.PhoneTextBox.Texts;
            string department = this.DepComboBox.Texts;

            NHANVIEN newEmp = new NHANVIEN { MANV = empCode, HOTEN = fullName, PHAI = gender, NGSINH = birth, 
                VAITRO = role, LUONG = salary, PHUCAP = allowance, DT = phone, MADV = department };

            try
            {
                await _empController.InsertNewEmployee(newEmp);
                MessageBox.Show($"Đã tạo nhân viên {empCode} thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetEmpForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo nhân viên: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
