using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.controls;
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
 
    public partial class ViewGradeOfCourse : Form
    {
        private readonly DangKyController _registrationController = new DangKyController();
        private string _courseCode;
        public ViewGradeOfCourse(string courseCode)
        {
            InitializeComponent();
            this._courseCode = courseCode;
            InitializeGradeTable();
        }

        private async void InitializeGradeTable()
        {
            try
            {
                var registrations = await this._registrationController.GetListStudentOfGV(this._courseCode);
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MASV", 250 },
                    { "DIEMTH", 120 },
                    { "DIEMQT", 120 },
                    { "DIEMCK", 120 },
                    { "DIEMTK", 120 }
                };

                var data = registrations.Select(r => new string[]
                    {
                r.MASV,
                r.DIEMTH.ToString(),
                r.DIEMQT.ToString(),
                r.DIEMCK.ToString(),
                r.DIEMTK.ToString(),
                }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.TableGradePanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableGradePanel.Controls.Add(errorLabel);
            }
        }
    }
}
