using SchoolManagerApp.src.Service;
using System;
using System.Collections.Generic;
using SchoolManagerApp.src.Controller;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Views.controls;

namespace SchoolManagerApp.src.Views.pages.SV
{
    public partial class CoursesPage : UserControl
    {
        private readonly MomonController _courseController = new MomonController();
        public CoursesPage()
        {
            InitializeComponent();
            InitializeAllCurrentCoursesTable();
        }

        private async void InitializeAllCurrentCoursesTable()
        {
            try
            {
                var courses = await this._courseController.GETTeachingAssignmentsForDepartment();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 100 },
                    { "MAHP", 100 },
                    { "MAGV", 100 },
                    { "HK", 80 },
                    { "NAM", 100 },
                    { "TENHP", 270 },
                    { "KHOA", 100 },
                    { "SOTC", 60 },
                    { "STLT", 60 },
                    { "STTH", 60 }
                };
                var data = courses.Select(r => new string[]
                {
                    r.MAMM,
                    r.MAHP,
                    r.MAGV,
                    r.HK,
                    r.NAM,
                    r.TENHP,
                    r.MADV,
                    r.SOTC.ToString(),
                    r.STLT.ToString(),
                    r.STTH.ToString()
                }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.TableAllCurrentCoursesPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.TableAllCurrentCoursesPanel.Controls.Add(errorLabel);
            }

        }

    }
}
