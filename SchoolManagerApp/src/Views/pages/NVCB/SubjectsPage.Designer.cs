namespace SchoolManagerApp.src.Views.pages.NVCB
{
    partial class SubjectsPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmpsTabControl = new System.Windows.Forms.TabControl();
            this.AllSubjectsTab = new System.Windows.Forms.TabPage();
            this.TableAllCurrentSubjectsPanel = new System.Windows.Forms.Panel();
            this.SubjectsIsAssignedToEmpTab = new System.Windows.Forms.TabPage();
            this.TableSubsIsAssignedToEmpPanel = new System.Windows.Forms.Panel();
            this.SubjectsIsAssignedToEmpThatOneDepTab = new System.Windows.Forms.TabPage();
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl.SuspendLayout();
            this.AllSubjectsTab.SuspendLayout();
            this.SubjectsIsAssignedToEmpTab.SuspendLayout();
            this.SubjectsIsAssignedToEmpThatOneDepTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllSubjectsTab);
            this.EmpsTabControl.Controls.Add(this.SubjectsIsAssignedToEmpTab);
            this.EmpsTabControl.Controls.Add(this.SubjectsIsAssignedToEmpThatOneDepTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(64, 83);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 1;
            // 
            // AllSubjectsTab
            // 
            this.AllSubjectsTab.Controls.Add(this.TableAllCurrentSubjectsPanel);
            this.AllSubjectsTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.AllSubjectsTab.Location = new System.Drawing.Point(4, 22);
            this.AllSubjectsTab.Name = "AllSubjectsTab";
            this.AllSubjectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllSubjectsTab.Size = new System.Drawing.Size(760, 325);
            this.AllSubjectsTab.TabIndex = 0;
            this.AllSubjectsTab.Text = "Môn học hiện tại";
            this.AllSubjectsTab.UseVisualStyleBackColor = true;
            // 
            // TableAllCurrentSubjectsPanel
            // 
            this.TableAllCurrentSubjectsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableAllCurrentSubjectsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableAllCurrentSubjectsPanel.Location = new System.Drawing.Point(31, 35);
            this.TableAllCurrentSubjectsPanel.Name = "TableAllCurrentSubjectsPanel";
            this.TableAllCurrentSubjectsPanel.Size = new System.Drawing.Size(694, 250);
            this.TableAllCurrentSubjectsPanel.TabIndex = 4;
            // 
            // SubjectsIsAssignedToEmpTab
            // 
            this.SubjectsIsAssignedToEmpTab.Controls.Add(this.TableSubsIsAssignedToEmpPanel);
            this.SubjectsIsAssignedToEmpTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.SubjectsIsAssignedToEmpTab.Location = new System.Drawing.Point(4, 22);
            this.SubjectsIsAssignedToEmpTab.Name = "SubjectsIsAssignedToEmpTab";
            this.SubjectsIsAssignedToEmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsIsAssignedToEmpTab.Size = new System.Drawing.Size(760, 325);
            this.SubjectsIsAssignedToEmpTab.TabIndex = 1;
            this.SubjectsIsAssignedToEmpTab.Text = "Môn học phụ trách";
            this.SubjectsIsAssignedToEmpTab.UseVisualStyleBackColor = true;
            // 
            // TableSubsIsAssignedToEmpPanel
            // 
            this.TableSubsIsAssignedToEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableSubsIsAssignedToEmpPanel.AutoScroll = true;
            this.TableSubsIsAssignedToEmpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableSubsIsAssignedToEmpPanel.Location = new System.Drawing.Point(34, 31);
            this.TableSubsIsAssignedToEmpPanel.Name = "TableSubsIsAssignedToEmpPanel";
            this.TableSubsIsAssignedToEmpPanel.Size = new System.Drawing.Size(694, 250);
            this.TableSubsIsAssignedToEmpPanel.TabIndex = 5;
            // 
            // SubjectsIsAssignedToEmpThatOneDepTab
            // 
            this.SubjectsIsAssignedToEmpThatOneDepTab.Controls.Add(this.TableSubjsIsAssignedTOEmpThatOneDepPanel);
            this.SubjectsIsAssignedToEmpThatOneDepTab.Location = new System.Drawing.Point(4, 22);
            this.SubjectsIsAssignedToEmpThatOneDepTab.Name = "SubjectsIsAssignedToEmpThatOneDepTab";
            this.SubjectsIsAssignedToEmpThatOneDepTab.Size = new System.Drawing.Size(760, 325);
            this.SubjectsIsAssignedToEmpThatOneDepTab.TabIndex = 2;
            this.SubjectsIsAssignedToEmpThatOneDepTab.Text = "Môn học của các giáo viên cùng bộ phận";
            this.SubjectsIsAssignedToEmpThatOneDepTab.UseVisualStyleBackColor = true;
            // 
            // TableSubjsIsAssignedTOEmpThatOneDepPanel
            // 
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.AutoScroll = true;
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Location = new System.Drawing.Point(38, 39);
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Name = "TableSubjsIsAssignedTOEmpThatOneDepPanel";
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.Size = new System.Drawing.Size(694, 250);
            this.TableSubjsIsAssignedTOEmpThatOneDepPanel.TabIndex = 6;
            // 
            // SubjectsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "SubjectsPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.EmpsTabControl.ResumeLayout(false);
            this.AllSubjectsTab.ResumeLayout(false);
            this.SubjectsIsAssignedToEmpTab.ResumeLayout(false);
            this.SubjectsIsAssignedToEmpThatOneDepTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpsTabControl;
        private System.Windows.Forms.TabPage AllSubjectsTab;
        private System.Windows.Forms.Panel TableAllCurrentSubjectsPanel;
        private System.Windows.Forms.TabPage SubjectsIsAssignedToEmpTab;
        private System.Windows.Forms.Panel TableSubsIsAssignedToEmpPanel;
        private System.Windows.Forms.TabPage SubjectsIsAssignedToEmpThatOneDepTab;
        private System.Windows.Forms.Panel TableSubjsIsAssignedTOEmpThatOneDepPanel;
    }
}
