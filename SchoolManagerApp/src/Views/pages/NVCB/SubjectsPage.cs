using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.pages.NVCB
{
    public partial class SubjectsPage : UserControl
    {
        private MomonController _mmController;
        public SubjectsPage()
        {
            InitializeComponent();
            _mmController = new MomonController();
            InitializeAllCurrentSubjectsTable();
            InitializeSubjectsIsAssignedToEmpTable();
            InitializeSubjectsIsAssignedToEmpThatOneDepartmentTable();
        }

        private async void InitializeAllCurrentSubjectsTable()
        {
            try
            {
                var emps = await this._mmController.GETCurrentTeachingAssignments();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 170 },
                    { "MAHP", 170 },
                    { "MAGV", 170 },
                    { "HK", 170 },
                    { "NAM", 170 },
                };

                var data = emps.Select(r => new string[]
                    {
                r.MAMM,
                r.MAHP,
                r.MAGV,
                r.HK,
                r.NAM
                    }).ToList();

                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                this.TableAllCurrentSubjectsPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.TableAllCurrentSubjectsPanel.Controls.Add(errorLabel);
            }

        }

        private async void InitializeSubjectsIsAssignedToEmpTable()
        {
            try
            {
                var emps = await this._mmController.GETPersonalTeachingAssignmentsForLecturer();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 170 },
                    { "MAHP", 170 },
                    { "MAGV", 170 },
                    { "HK", 170 },
                    { "NAM", 170 },
                };

                var data = emps.Select(r => new string[]
                    {
                r.MAMM,
                r.MAHP,
                r.MAGV,
                r.HK,
                r.NAM
                    }).ToList();

                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                this.TableSubsIsAssignedToEmpPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableSubsIsAssignedToEmpPanel.Controls.Add(errorLabel);
            }

        }

        private async void InitializeSubjectsIsAssignedToEmpThatOneDepartmentTable()
        {
            try
            {
                var emps = await this._mmController.GETTeachingAssignmentsInManagedUnit();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 170 },
                    { "MAHP", 170 },
                    { "MAGV", 170 },
                    { "HK", 170 },
                    { "NAM", 170 },
                };

                var data = emps.Select(r => new string[]
                    {
                r.MAMM,
                r.MAHP,
                r.MAGV,
                r.HK,
                r.NAM
                    }).ToList();

                var table = new CTTable(columnDefinitions, data, null, false);
                table.Dock = DockStyle.Fill;
                this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Controls.Add(errorLabel);
            }

        }


    }
}
