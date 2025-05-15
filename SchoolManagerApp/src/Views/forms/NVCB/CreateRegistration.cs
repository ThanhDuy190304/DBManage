using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class CreateRegistration : Form
    {
        private DangKyController _dkController;
        public CreateRegistration()
        {
            InitializeComponent();
            _dkController = new DangKyController();
            this.AcceptButton = this.SaveButton;
        }
        private void ResetRegistrationForm()
        {
            this.StuCodeTextBox.Texts = "";
            this.CourseCodeTextBox.Texts = "";
        }
        
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string stuCode = this.StuCodeTextBox.Texts;
            string courseCode = this.CourseCodeTextBox.Texts;
            try
            {
                await _dkController.InsertHocPhan(stuCode, courseCode);
                MessageBox.Show($"Đã tạo đăng ký thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetRegistrationForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo đăng ký: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
