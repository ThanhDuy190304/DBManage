using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;

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

namespace SchoolManagerApp.src.Views.forms.NVCB
{
    public partial class UpdateCourse : Form
    {
        private MomonController _mmController;
        private MOMON _course;
        public UpdateCourse(MOMON course)
        {
            InitializeComponent();
            _mmController = new MomonController();
            this._course = course;
            InitializeCourse();
        }
        private void InitializeCourse()
        {
            this.CourseCodeTextBox.Texts = this._course.MAMM;
            this.EmpCodeTextBox.Texts = this._course.MAGV;
            this.YearTextBox.Texts = this._course.NAM;
            this.SemesterTextBox.Texts = this._course.HK;
            this.SubjectCodeTextBox.Texts = this._course.MAHP;
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic updateData = new ExpandoObject();
            var dict = (IDictionary<string, object>)updateData;

            if (this.CourseCodeTextBox.Texts.Trim() != _course.MAMM)
                dict["MAMM"] = this.CourseCodeTextBox.Texts;

            if (this.EmpCodeTextBox.Texts.Trim() != _course.MAGV)
                dict["MAGV"] = this.EmpCodeTextBox.Texts;

            if (this.YearTextBox.Texts.Trim() != _course.NAM)
                dict["NAM"] = this.YearTextBox.Texts;

            if (this.SemesterTextBox.Texts.Trim() != _course.HK)
                dict["HK"] = this.SemesterTextBox.Texts;

            if (this.SubjectCodeTextBox.Texts.Trim() != _course.MAHP)
                dict["MAHP"] = this.SubjectCodeTextBox.Texts;

            if (dict.Count > 0)
            {
                try
                {
                    await _mmController.UpdateTeachingAssignmentDetails(this._course.MAMM, updateData);
                    MessageBox.Show("Cập nhật khóa học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            InitializeCourse();
        }

      
    }
}
