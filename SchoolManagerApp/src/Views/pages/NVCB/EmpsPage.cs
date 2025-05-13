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

                var table = new CTTable(columnDefinitions, data, null, false);
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

                var table = new CTTable(columnDefinitions, data, null, false);
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

    }

}
