using FontAwesome.Sharp;
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
    public partial class StudentsPage : UserControl
    {
        private SinhVienController _svController;
        
        public StudentsPage()
        {
            InitializeComponent();
            _svController = new SinhVienController();
            InitializeAllStudentsTable();
        }

        private async void InitializeAllStudentsTable()
        {
            try
            {
                var students = await this._svController.GetAll();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MASV", 100 },
                    { "HOTEN", 200 },
                    { "PHAI", 80 },
                    { "NGSINH", 120 },
                    { "DCHI", 200 },
                    { "DT", 100 },
                    { "KHOA", 100 },
                    { "TINHTRANG", 100 }
                };

                var data = students.Select(sv => new string[]
                {
                    sv.MASV,
                    sv.HOTEN,
                    sv.PHAI,
                    sv.NGSINH.ToString("dd/MM/yyyy"),
                    sv.DCHI,
                    sv.DT,
                    sv.KHOA,
                    sv.TINHTRANG
                }).ToList();

                var buttonMatrix = students.Select(stu => new Control[]
                {
                    EditStudentButton(stu),
                    DeleteAStuButton(stu.MASV),
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
                table.Dock = DockStyle.Fill;
                this.TableAllStudentsPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableAllStudentsPanel.Controls.Add(errorLabel);
            }

        }

        private void CreateStuButton_Click(object sender, EventArgs e)
        {
            CreateStudent createStuForm = new CreateStudent();
            createStuForm.ShowDialog();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TableAllStudentsPanel.Controls.Clear();
            InitializeAllStudentsTable();
        }

        private void HandleEditStudent(SINHVIEN student)
        {
            UpdateStudent updateStudentForm = new UpdateStudent(student);
            updateStudentForm.ShowDialog();
        }

        private Control EditStudentButton(SINHVIEN student)
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
                HandleEditStudent(student);
            };

            return editButton;
        }

        private async void HandleDeleteStu(string stuCode)
        {
            try
            {
                await this._svController.Delete(stuCode);
                MessageBox.Show($"Đã xoá sinh viên {stuCode} thành công.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá sinh viên: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Control DeleteAStuButton(string stuCode)
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
                HandleDeleteStu(stuCode);
            };

            return trashButton;
        }
    }
}
