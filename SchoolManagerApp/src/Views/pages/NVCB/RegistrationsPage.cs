using FontAwesome.Sharp;
using SchoolManagerApp.Controls;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
using SchoolManagerApp.src.Views.controls;
using SchoolManagerApp.src.Views.forms.NVCB;
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
    public partial class RegistrationsPage : UserControl
    {
        private DangKyController _dkController;
        public RegistrationsPage()
        {
            InitializeComponent();
            _dkController = new DangKyController();
            InitializeAllRegistrationsTable();
        }

        private async void InitializeAllRegistrationsTable()
        {
            try
            {
                var registrations = await this._dkController.GetPoint();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MASV", 200 },
                    { "MAMM", 200 },
                    { "DIEMTH", 120 },
                    { "DIEMQT", 120 },
                    { "DIEMCK", 120 },
                    { "DIEMTK", 120 }
                };

                var data = registrations.Select(r => new string[]
                    {
                r.MASV,
                r.MAMM,
                r.DIEMTH.ToString(),
                r.DIEMQT.ToString(),
                r.DIEMCK.ToString(),
                r.DIEMTK.ToString(),
                }).ToList();


                var buttonMatrix = registrations.Select(regis => new Control[]
                {
                    EditGradeButton(regis),
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
                table.Dock = DockStyle.Fill;
                this.TableAllRetristrationsPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableAllRetristrationsPanel.Controls.Add(errorLabel);
            }

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TableAllRetristrationsPanel.Controls.Clear();
            InitializeAllRegistrationsTable();
        }

        private void CreateEmpButton_Click(object sender, EventArgs e)
        {
            CreateRegistration createRegistrationForm = new CreateRegistration();
            createRegistrationForm.ShowDialog();
        }

        private void HandleEditGrade(DangKy regis)
        {
            UpdateGrade updateGradeForm = new UpdateGrade(regis);
            updateGradeForm.ShowDialog();
        }

        private Control EditGradeButton(DangKy regis)
        {
            // Nút thao tác
            IconButton editButton = new IconButton()
            {
                IconChar = IconChar.Edit,
                IconColor = Color.Blue,
                IconSize = 20,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                Text = "",
                Cursor = Cursors.Hand,
            };
            editButton.FlatAppearance.BorderSize = 0;
            editButton.Size = new Size(24, 24);
            editButton.Click += (sender, e) =>
            {
                HandleEditGrade(regis);
            };

            return editButton;
        }
    }
}
