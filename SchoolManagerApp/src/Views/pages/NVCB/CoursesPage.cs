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
    public partial class CoursesPage : UserControl
    {
        private MomonController _mmController;
        public CoursesPage()
        {
            InitializeComponent();
            _mmController = new MomonController();
            InitializeAllCurrentCoursesTable();
            InitializeCoursesIsAssignedToEmpTable();
            InitializeCoursesIsAssignedToEmpThatOneDepartmentTable();
        }

        private async void InitializeAllCurrentCoursesTable()
        {
            try
            {
                var courses = await this._mmController.GETCurrentTeachingAssignments();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 120 },
                    { "MAHP", 120 },
                    { "MAGV", 120 },
                    { "HK", 80 },
                    { "NAM", 100 },
                    { "TENHP", 200 },
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
                    r.SOTC.ToString(),
                    r.STLT.ToString(),
                    r.STTH.ToString()
                }).ToList();

                var buttonMatrix = courses.Select(course => new Control[]
                {
                    EditAEmpButton(new MOMON
                    {
                        MAMM = course.MAMM,
                        MAHP = course.MAHP,
                        MAGV = course.MAGV,
                        HK = course.HK,
                        NAM = course.NAM
                    }),
                    DeleteASubButton(course.MAMM)
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
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

        private async void InitializeCoursesIsAssignedToEmpTable()
        {
            try
            {
                var courses = await this._mmController.GETPersonalTeachingAssignmentsForLecturer();

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 120 },
                    { "MAHP", 120 },
                    { "MAGV", 120 },
                    { "HK", 80 },
                    { "NAM", 100 },
                    { "TENHP", 200 },
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
                    r.SOTC.ToString(),
                    r.STLT.ToString(),
                    r.STTH.ToString()
                }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.TableCoursesIsAssignedToEmpPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableCoursesIsAssignedToEmpPanel.Controls.Add(errorLabel);
            }

        }

        private async void InitializeCoursesIsAssignedToEmpThatOneDepartmentTable()
        {
            try
            {
                var courses = await this._mmController.GETTeachingAssignmentsInManagedUnit();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MAMM", 120 },
                    { "MAHP", 120 },
                    { "MAGV", 120 },
                    { "HK", 80 },
                    { "NAM", 100 },
                    { "TENHP", 200 },
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
                    r.SOTC.ToString(),
                    r.STLT.ToString(),
                    r.STTH.ToString()
                }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Controls.Add(errorLabel);
            }

        }

        private async void HandleDeleteSub(string subCode)
        {
            try
            {
                await this._mmController.DeleteTeachingAssignment(subCode);
                MessageBox.Show($"Đã xoá môn {subCode} thành công.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá môn học: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control DeleteASubButton(string subCode)
        {
            // Nút thao tác
            IconButton trashButton = new IconButton()
            {
                IconChar = IconChar.Trash,
                IconColor = Color.Red,
                IconSize = 20,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                Text = "",
                Cursor = Cursors.Hand,
            };
            trashButton.FlatAppearance.BorderSize = 0;
            trashButton.Size = new Size(24, 24);
            trashButton.Click += (sender, e) =>
            {
                HandleDeleteSub(subCode);
            };

            return trashButton;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TableAllCurrentCoursesPanel.Controls.Clear();
            this.TableCoursesIsAssignedToEmpPanel.Controls.Clear();
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Controls.Clear();
            InitializeAllCurrentCoursesTable();
            InitializeCoursesIsAssignedToEmpTable();
            InitializeCoursesIsAssignedToEmpThatOneDepartmentTable();
        }

        private void CreateSubButton_Click(object sender, EventArgs e)
        {
            CreateCourse createCourseForm = new CreateCourse();
            createCourseForm.ShowDialog();
        }

        private void HandleEditCourse(MOMON course)
        {
            UpdateCourse updateCourseForm = new UpdateCourse(course);
            updateCourseForm.ShowDialog();
        }

        private Control EditAEmpButton(MOMON course)
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
                HandleEditCourse(course);
            };

            return editButton;
        }
    }
}
