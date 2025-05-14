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
    public partial class UpdateGrade : Form
    {
        private DangKyController _dkController;
        private readonly DangKy _regis;
        public UpdateGrade(DangKy dk)
        {
            InitializeComponent();
            this.AcceptButton = this.SaveButton;
            _dkController = new DangKyController();
            this._regis = dk;
            InitializeGrade();
        }
        private void InitializeGrade()
        {
            this.CourseCodeTextBox.Texts = this._regis.MAMM;
            this.StuCodeTextBox.Texts = this._regis.MASV;
            this.PracticeGradeTextBox.Texts = this._regis.DIEMTH.ToString();
            this.ProcessGradeTextBox.Texts = this._regis.DIEMQT.ToString();
            this.FinalGradeTextBox.Texts = this._regis.DIEMCK.ToString();
            this.SummaryTextBox.Texts = this._regis.DIEMTK.ToString();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            InitializeGrade();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            double processGrade = double.Parse(this.ProcessGradeTextBox.Texts);
            double finalGrade = double.Parse(this.FinalGradeTextBox.Texts);
            double practiceGrade = double.Parse(this.PracticeGradeTextBox.Texts);
            double summaryGrade = double.Parse(this.SummaryTextBox.Texts);
            try
            {
                await this._dkController.UpdateHocPhan(_regis.MASV, _regis.MAMM, 
                    practiceGrade, processGrade, finalGrade, summaryGrade);
                MessageBox.Show("Cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
