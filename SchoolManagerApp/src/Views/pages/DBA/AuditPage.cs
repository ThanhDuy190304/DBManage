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

namespace SchoolManagerApp.src.Views.pages.DBA
{
    public partial class AuditPage : UserControl
    {
        private readonly AuditController _auditController = new AuditController(); 
        public AuditPage()
        {
            InitializeComponent();
            InitializeAllStandardAuditTable();
            InitializeAllFineGrantedAuditTable();
        }

        private async void InitializeAllStandardAuditTable()
        {
            try
            {
                var audits = await this._auditController.GetStandardAuditDataAsync();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "OS_USERNAME", 250 }, { "USERNAME", 200 }, { "USERHOST", 200 },
                    { "TIMESTAMP", 120 }, { "ObjectOwner", 120 },
                    { "ObjectName", 120 }, { "ACTION_NAME", 150 }, 
                    { "SQL_TEXT", 400 }
                };
                var data = audits.Select(a => new string[]
                {
                    a.OS_USERNAME,
                    a.USERNAME,
                    a.USERHOST,
                    a.TIMESTAMP.ToString("yyyy-MM-dd HH:mm:ss"),
                    a.ObjectOwner,
                    a.ObjectName,
                    a.ACTION_NAME,
                    a.SQL_TEXT
                }).ToList();
                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;

                this.StandardAuditPanel.Controls.Clear();
                this.StandardAuditPanel.Controls.Add(table);
            }
            catch(Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.StandardAuditPanel.Controls.Clear();
                this.StandardAuditPanel.Controls.Add(errorLabel);
            }
        }

        private async void InitializeStandardAuditSessionsTable()
        {
            try
            {
                var audits = await this._auditController.GetStandardAuditSessions();
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "OS_USERNAME", 250 },
                    { "USERNAME", 200 },
                    { "USERHOST", 200 },
                    { "TERMINAL", 150 },
                    { "TIMESTAMP", 120 },
                    { "ACTION_NAME", 150 },
                    { "LOGOFF_TIME", 120 },
                    { "LOGOFF_LREAD", 120 },
                    { "LOGOFF_PREAD", 120 },
                    { "LOGOFF_LWRITE", 120 },
                    { "LOGOFF_DLOCK", 150 },
                    { "SESSIONID", 100 },
                    { "RETURNCODE", 100 },
                    { "CLIENT_ID", 200 },
                    { "SESSION_CPU", 120 },
                    { "EXTENDED_TIMESTAMP", 120 },
                    { "PROXY_SESSIONID", 100 },
                    { "GLOBAL_UID", 200 },
                    { "INSTANCE_NUMBER", 100 },
                    { "OS_PROCESS", 150 }
                };

                var data = audits.Select(a => new string[]
                {
                    a.OS_USERNAME,
                    a.USERNAME,
                    a.USERHOST,
                    a.TERMINAL,
                    a.TIMESTAMP.ToString("yyyy-MM-dd HH:mm:ss"),
                    a.ACTION_NAME,
                    a.LOGOFF_TIME.ToString("yyyy-MM-dd HH:mm:ss"),
                    a.LOGOFF_LREAD.ToString(),
                    a.LOGOFF_PREAD.ToString(),
                    a.LOGOFF_LWRITE.ToString(),
                    a.LOGOFF_DLOCK,
                    a.SESSIONID.ToString(),
                    a.RETURNCODE.ToString(),
                    a.CLIENT_ID,
                    a.SESSION_CPU.ToString(),
                    a.EXTENDED_TIMESTAMP.ToString("yyyy-MM-dd HH:mm:ss"),
                    a.PROXY_SESSIONID?.ToString(),
                    a.GLOBAL_UID,
                    a.INSTANCE_NUMBER.ToString(),
                    a.OS_PROCESS
                }).ToList();

                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;

                this.StandardAuditPanel.Controls.Clear();
                this.StandardAuditPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.StandardAuditPanel.Controls.Clear();
                this.StandardAuditPanel.Controls.Add(errorLabel);
            }
        }


        private async void InitializeAllFineGrantedAuditTable(string policyName = null)
        {
            try
            {
                var audits = await this._auditController.GetFGAAuditDataAsync(policyName);
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "DB_USER", 200 },
                    { "TIMESTAMP", 150 },
                    { "OBJECT_SCHEMA", 150 },
                    { "OBJECT_NAME", 150 },
                    { "POLICY_NAME", 200 },
                    { "SQL_TEXT", 400 },
                    { "SCN", 100 },
                    { "STATEMENT_TYPE", 150 }
                };
                var data = audits.Select(a => new string[]
                {
                    a.DB_USER,
                    a.TIMESTAMP.ToString("yyyy-MM-dd HH:mm:ss"),
                    a.OBJECT_SCHEMA,
                    a.OBJECT_NAME,
                    a.POLICY_NAME,
                    a.SQL_TEXT,
                    a.SCN.ToString(),
                    a.STATEMENT_TYPE
                }).ToList();
                var table = new CTTable_v2(columnDefinitions, data);
                table.Dock = DockStyle.Fill;
                this.FineGrantedAuditPanel.Controls.Clear();
                this.FineGrantedAuditPanel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;

                this.FineGrantedAuditPanel.Controls.Clear();
                this.FineGrantedAuditPanel.Controls.Add(errorLabel);
            }
        }
        private void StandardAuditSearchButton_Click(object sender, EventArgs e)
        {
            if (this.StandardAuditComboBox.Texts == "All")
            {
                InitializeAllStandardAuditTable();
            }
            else if (this.StandardAuditComboBox.Texts == "Sessions")
            {
                InitializeStandardAuditSessionsTable();
            }
        }

        private void FineGrantedAuditSearchButton_Click(object sender, EventArgs e)
        {
            if (this.FineGrantedAuditComboBox.Texts == "All")
            {
                InitializeAllFineGrantedAuditTable();
            }
            else {
                InitializeAllFineGrantedAuditTable(this.FineGrantedAuditComboBox.Texts);
            }
        }
    }
}
