using FontAwesome.Sharp;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Models;
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

namespace SchoolManagerApp.src.Views.pages
{
    public partial class PolicyPage : UserControl
    {
        private readonly PolicyController _policyController = new PolicyController();

        public PolicyPage()
        {
            InitializeComponent();
            InitializeVPDPolicySINHVIENTable();
            InitializeVPDPolicyDANGKYTable();
            InitializeVPDPolicyMOMONTable();
            InitializeFineGranedAuditTable();
        }
        
        private async void InitializeVPDPolicySINHVIENTable()
        {
            try
            {
                var policies = await this._policyController.GetVPDPoliciesByObjectName("SINHVIEN");

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "POLICY_NAME", 250 }, { "OBJECT_OWNER", 120 }, { "OBJECT_NAME", 120 },
                    { "POLICY_GROUP", 120 }, { "PF_OWNER", 120 },
                    { "FUNCTION", 120 }, { "SEL", 50 }, { "INS", 50 }, { "UPD", 50 }, { "DEL", 50 },
                    { "IDX", 50 }, { "CHK_OPTION", 90 }, { "ENABLE", 60 },
                    { "STATIC_POLICY", 150 }, { "POLICY_TYPE", 150 }, { "LONG_PREDICATE", 150 },
                    { "COMMON", 100 }, { "INHERITED", 80 }
                };
                var data = policies.Select(p => new string[]
                {
                    p.POLICY_NAME, p.OBJECT_OWNER, p.OBJECT_NAME,
                    p.POLICY_GROUP, p.PF_OWNER,
                    p.FUNCTION, p.SEL, p.INS, p.UPD, p.DEL,
                    p.IDX, p.CHK_OPTION, p.ENABLE,
                    p.STATIC_POLICY, p.POLICY_TYPE, p.LONG_PREDICATE,
                    p.COMMON, p.INHERITED
                }).ToList();

                var buttonMatrix = policies.Select(policy => new Control[]
                {
                ToggleButton(policy.OBJECT_OWNER, policy.OBJECT_NAME, policy.POLICY_NAME, policy.ENABLE, "VPD")
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
                table.Dock = DockStyle.Fill;

                this.SINHVIEN_Policies_Panel.Controls.Clear();
                this.SINHVIEN_Policies_Panel.Controls.Add(table);
            }

            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.SINHVIEN_Policies_Panel.Controls.Clear();
                this.SINHVIEN_Policies_Panel.Controls.Add(errorLabel);
            }
        }

        private async void InitializeVPDPolicyMOMONTable()
        {
            try
            {
                var policies = await this._policyController.GetVPDPoliciesByObjectName("MOMON");

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "POLICY_NAME", 250 }, { "OBJECT_OWNER", 120 }, { "OBJECT_NAME", 120 },
                    { "POLICY_GROUP", 120 }, { "PF_OWNER", 120 },
                    { "FUNCTION", 120 }, { "SEL", 50 }, { "INS", 50 }, { "UPD", 50 }, { "DEL", 50 },
                    { "IDX", 50 }, { "CHK_OPTION", 90 }, { "ENABLE", 60 },
                    { "STATIC_POLICY", 150 }, { "POLICY_TYPE", 150 }, { "LONG_PREDICATE", 150 },
                    { "COMMON", 100 }, { "INHERITED", 80 }
                };
                var data = policies.Select(p => new string[]
                {
                    p.POLICY_NAME, p.OBJECT_OWNER, p.OBJECT_NAME,
                    p.POLICY_GROUP, p.PF_OWNER,
                    p.FUNCTION, p.SEL, p.INS, p.UPD, p.DEL,
                    p.IDX, p.CHK_OPTION, p.ENABLE,
                    p.STATIC_POLICY, p.POLICY_TYPE, p.LONG_PREDICATE,
                    p.COMMON, p.INHERITED
                }).ToList();

                var buttonMatrix = policies.Select(policy => new Control[]
                {
                ToggleButton(policy.OBJECT_OWNER, policy.OBJECT_NAME, policy.POLICY_NAME, policy.ENABLE, "VPD")
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
                table.Dock = DockStyle.Fill;

                this.MOMON_Policies_Panel.Controls.Clear();
                this.MOMON_Policies_Panel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.MOMON_Policies_Panel.Controls.Clear();
                this.MOMON_Policies_Panel.Controls.Add(errorLabel);
            }
        }
        private async void InitializeVPDPolicyDANGKYTable()
        {
            try
            {
                var policies = await this._policyController.GetVPDPoliciesByObjectName("DANGKY");
                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "POLICY_NAME", 250 }, { "OBJECT_OWNER", 120 }, { "OBJECT_NAME", 120 },
                    { "POLICY_GROUP", 120 }, { "PF_OWNER", 120 },
                    { "FUNCTION", 120 }, { "SEL", 50 }, { "INS", 50 }, { "UPD", 50 }, { "DEL", 50 },
                    { "IDX", 50 }, { "CHK_OPTION", 90 }, { "ENABLE", 60 },
                    { "STATIC_POLICY", 150 }, { "POLICY_TYPE", 150 }, { "LONG_PREDICATE", 150 },
                    { "COMMON", 100 }, { "INHERITED", 80 }
                };
                var data = policies.Select(p => new string[]
                {
                    p.POLICY_NAME, p.OBJECT_OWNER, p.OBJECT_NAME,
                    p.POLICY_GROUP, p.PF_OWNER,
                    p.FUNCTION, p.SEL, p.INS, p.UPD, p.DEL,
                    p.IDX, p.CHK_OPTION, p.ENABLE,
                    p.STATIC_POLICY, p.POLICY_TYPE, p.LONG_PREDICATE,
                    p.COMMON, p.INHERITED
                }).ToList();


                var buttonMatrix = policies.Select(policy => new Control[]
                {
                ToggleButton(policy.OBJECT_OWNER, policy.OBJECT_NAME, policy.POLICY_NAME, policy.ENABLE, "VPD")
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix); 
                table.Dock = DockStyle.Fill;

                this.DANGKY_Policies_Panel.Controls.Clear();
                this.DANGKY_Policies_Panel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.DANGKY_Policies_Panel.Controls.Clear();
                this.DANGKY_Policies_Panel.Controls.Add(errorLabel);
            }
        }

        private async void InitializeFineGranedAuditTable()
        {
            try
            {
                var policies = await this._policyController.GetAuditPolicies();

                var columnDefinitions = new Dictionary<string, int>()
                {
                    { "OBJECT_SCHEMA", 120 }, { "OBJECT_NAME", 120 },
                    { "POLICY_OWNER", 120 }, { "POLICY_NAME", 250 },
                    { "POLICY_TEXT", 250 }, { "POLICY_COLUMNS", 200 }, { "ENABLED", 70 },
                    { "SEL", 50 },  { "INS", 50 }, { "UPD", 50 },  { "DEL", 50 },
                    { "AUDIT_TRAIL", 120 },  { "POLICY_COLUMN_OPTIONS", 200 },
                    { "COMMON", 50 },  { "INHERITED", 80 }
                };

                var data = policies.Select(p => new string[]
                {
                    p.OBJECT_SCHEMA, p.OBJECT_NAME, p.POLICY_OWNER, p.POLICY_NAME,
                    p.POLICY_TEXT, p.POLICY_COLUMNS, p.ENABLED,
                    p.SEL,p.INS, p.UPD, p.DEL,    
                    p.AUDIT_TRAIL, p.POLICY_COLUMN_OPTIONS,
                    p.COMMON, p.INHERITED
                }).ToList();

                var buttonMatrix = policies.Select(policy => new Control[]
                {
                    ToggleButton(policy.OBJECT_SCHEMA, policy.OBJECT_NAME, policy.POLICY_NAME, policy.ENABLED, "FineGrantedAudit")
                }).ToArray();

                var table = new CTTable_v2(columnDefinitions, data, buttonMatrix);
                table.Dock = DockStyle.Fill;

                this.FineGraned_Audit_Policies_Panel.Controls.Clear();
                this.FineGraned_Audit_Policies_Panel.Controls.Add(table);
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Lỗi: " + ex.Message;
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Dock = DockStyle.Top;
                this.FineGraned_Audit_Policies_Panel.Controls.Clear();
                this.FineGraned_Audit_Policies_Panel.Controls.Add(errorLabel);
            }
        }

        private Control ToggleButton(string objectSchema, string objectName, string policyName, string enable, string policyType)
        {
            IconButton toggleButton = new IconButton()
            {
                IconChar = enable == "YES" ? IconChar.ToggleOn : IconChar.ToggleOff,
                IconColor = enable == "YES" ? Color.Green : Color.Gray,
                IconSize = 24,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
            };
            toggleButton.FlatAppearance.BorderSize = 0;
            toggleButton.Size = new Size(40, 24);

            toggleButton.Click += async (sender, e) =>
            {
                try
                {
                    if (enable == "YES")
                    {
                        if (policyType == "VPD")
                        {
                            await _policyController.SetVPDPolicyState(objectSchema, objectName, policyName, false);
                        }
                        else if (policyType == "FineGrantedAudit")
                        {
                            await _policyController.DisableAuditPolicy(objectSchema, objectName, policyName);
                        }

                        toggleButton.IconChar = IconChar.ToggleOff;
                        toggleButton.IconColor = Color.Gray;
                        enable = "NO";
                    }
                    else
                    {
                        if (policyType == "VPD")
                        {
                            await _policyController.SetVPDPolicyState(objectSchema, objectName, policyName, true);
                        }
                        else if (policyType == "FineGrantedAudit")
                        {
                            await _policyController.EnableAuditPolicy(objectSchema, objectName, policyName);
                        }

                        toggleButton.IconChar = IconChar.ToggleOn;
                        toggleButton.IconColor = Color.Green;
                        enable = "YES";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật chính sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            return toggleButton;
        }

    }
}
