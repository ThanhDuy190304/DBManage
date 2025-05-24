using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;
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

namespace SchoolManagerApp.src.Views.pages.SharedPage
{
    public partial class NotificationPage : UserControl
    {
        private readonly OLSController _oLSController = new OLSController(); 

        public NotificationPage()
        {
            InitializeComponent();
            InitializeNotificationTable();
        }

        private async void InitializeNotificationTable()
        {
            try
            {
                var courses = await this._oLSController.GetNotify();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "ID", 100 },
                    { "NOIDUNG", 1080 },
                };
                var data = courses.Select(r => new string[]
                {
                    r.ID,
                    r.NOIDUNG,
                }).ToList();
                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.NotificationPanel.Controls.Add(table);

            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.NotificationPanel.Controls.Add(errorLabel);
            }
        }
    }
}
