using FontAwesome.Sharp;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Views.controls;
using SchoolManagerApp.src.Views.forms.NVCB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.pages.NVCB
{
    public partial class EmpsPage : UserControl
    {
        private NhanVienController _empController;
        public EmpsPage()
        {
            InitializeComponent();
            _empController = new NhanVienController();
            InitializeEmpsHasOneDepartmentTable();
            InitializeAllEmpsTable();
        }

        private async void InitializeEmpsHasOneDepartmentTable()
        {
            try
            {
                var emps = await this._empController.GETEmployeesInManagedUnitTRGDV();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MANV", 100 },
                    { "HOTEN", 150 },
                    { "PHAI", 60 },
                    { "NGSINH", 100 },
                    { "LUONG", 100 },
                    { "PHUCAP", 100 },
                    { "DT", 120 },
                    { "VAITRO", 120 },
                    { "MADV", 100 }
                };

                var data = emps.Select(r => new string[]
                    {
                r.MANV,
                r.HOTEN,
                r.PHAI,
                r.NGSINH.ToString("dd/MM/yyyy"),
                r.LUONG.ToString(),
                r.PHUCAP.ToString(),
                r.DT,
                r.VAITRO,
                r.MADV
                    }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.TableEmpsOneDepPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.TableEmpsOneDepPanel.Controls.Add(errorLabel);
            }
          
        }

        private async void InitializeAllEmpsTable()
        {
            try
            {
                var emps = await this._empController.GETAllEmployees();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "MANV", 100 },
                    { "HOTEN", 150 },
                    { "PHAI", 60 },
                    { "NGSINH", 100 },
                    { "LUONG", 100 },
                    { "PHUCAP", 100 },
                    { "DT", 120 },
                    { "VAITRO", 120 },
                    { "MADV", 100 }
                };

                var data = emps.Select(r => new string[]
                    {
                r.MANV,
                r.HOTEN,
                r.PHAI,
                r.NGSINH.ToString("dd/MM/yyyy"),
                r.LUONG.ToString(),
                r.PHUCAP.ToString(),
                r.DT,
                r.VAITRO,
                r.MADV
                    }).ToList();

                var buttonMatrix = emps.Select(emp => new Control[]
                {
                    EditAEmpButton(emp),
                    DeleteAEmpButton(emp.MANV),
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);

                table.Dock = DockStyle.Fill;
                this.TableAllEmpsPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.TableAllEmpsPanel.Controls.Add(errorLabel);
            }

        }

        private async void HandleDeleteEmp(string empCode)
        {
            try
            {
                await this._empController.DeleteEmployee(empCode);
                MessageBox.Show($"Đã xoá nhân viên {empCode} thành công.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá nhân viên: {ex.Message}", "Lỗi",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Control DeleteAEmpButton(string empCode)
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
                HandleDeleteEmp(empCode); 
            };

            return trashButton;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.TableAllEmpsPanel.Controls.Clear();
            this.TableEmpsOneDepPanel.Controls.Clear();

            InitializeEmpsHasOneDepartmentTable();
            InitializeAllEmpsTable();
        }

        private void CreateEmpButton_Click(object sender, EventArgs e)
        {
            CreateEmp createEmpForm = new CreateEmp();
            createEmpForm.ShowDialog();
        }


        private void HandleEditEmp(NHANVIEN emp)
        {
            UpdateEmp updateEmpForm = new UpdateEmp(emp);
            updateEmpForm.ShowDialog();
        }
        private Control EditAEmpButton(NHANVIEN emp)
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
                HandleEditEmp(emp);
            };

            return editButton;
        }
    }

}
