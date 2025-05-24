using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class CreateCourse : Form
    {
        private MomonController _mmController;

        public CreateCourse()
        {
            InitializeComponent();
            _mmController = new MomonController();
            this.AcceptButton = this.SaveButton;
        }

        private void ResetEmpForm()
        {
            this.EmpCodeTextBox.Texts = "";
            this.CourseCodeTextBox.Texts = "";
            this.SubjectCodeTextBox.Texts = "";
            this.SemesterComboBox.Texts = "";
            this.YearTextBox.Texts = "";
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string courseCode = this.CourseCodeTextBox.Texts;
            string empCode = this.EmpCodeTextBox.Texts;
            string subjectCode = this.SubjectCodeTextBox.Texts;
            string semester = this.SemesterComboBox.Texts;
            string year = this.YearTextBox.Texts;

            MOMON newCourse = new MOMON{ MAGV = empCode, MAMM = courseCode, MAHP = subjectCode, HK = semester, NAM = year};
            try
            {
                await _mmController.InsertNewTeachingAssignment(newCourse);
                MessageBox.Show($"Đã tạo khóa học {courseCode} thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetEmpForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo khóa học: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
