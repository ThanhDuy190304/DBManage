namespace SchoolManagerApp.src.Views.pages.NVCB
{
    partial class StudentsPage
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
            this.AllStudentsTab = new System.Windows.Forms.TabPage();
            this.TableAllStudentsPanel = new System.Windows.Forms.Panel();
            this.StudentsOneDepTab = new System.Windows.Forms.TabPage();
            this.TableStudentsOneDepPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl.SuspendLayout();
            this.AllStudentsTab.SuspendLayout();
            this.StudentsOneDepTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllStudentsTab);
            this.EmpsTabControl.Controls.Add(this.StudentsOneDepTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(119, 63);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 1;
            // 
            // AllStudentsTab
            // 
            this.AllStudentsTab.Controls.Add(this.TableAllStudentsPanel);
            this.AllStudentsTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.AllStudentsTab.Location = new System.Drawing.Point(4, 22);
            this.AllStudentsTab.Name = "AllStudentsTab";
            this.AllStudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllStudentsTab.Size = new System.Drawing.Size(760, 325);
            this.AllStudentsTab.TabIndex = 0;
            this.AllStudentsTab.Text = "Tất cả sinh viên";
            this.AllStudentsTab.UseVisualStyleBackColor = true;
            // 
            // TableAllStudentsPanel
            // 
            this.TableAllStudentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableAllStudentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableAllStudentsPanel.Location = new System.Drawing.Point(31, 35);
            this.TableAllStudentsPanel.Name = "TableAllStudentsPanel";
            this.TableAllStudentsPanel.Size = new System.Drawing.Size(694, 250);
            this.TableAllStudentsPanel.TabIndex = 4;
            // 
            // StudentsOneDepTab
            // 
            this.StudentsOneDepTab.Controls.Add(this.TableStudentsOneDepPanel);
            this.StudentsOneDepTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.StudentsOneDepTab.Location = new System.Drawing.Point(4, 22);
            this.StudentsOneDepTab.Name = "StudentsOneDepTab";
            this.StudentsOneDepTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsOneDepTab.Size = new System.Drawing.Size(760, 325);
            this.StudentsOneDepTab.TabIndex = 1;
            this.StudentsOneDepTab.Text = "Sinh viên trong khoa";
            this.StudentsOneDepTab.UseVisualStyleBackColor = true;
            // 
            // TableStudentsOneDepPanel
            // 
            this.TableStudentsOneDepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableStudentsOneDepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableStudentsOneDepPanel.Location = new System.Drawing.Point(34, 31);
            this.TableStudentsOneDepPanel.Name = "TableStudentsOneDepPanel";
            this.TableStudentsOneDepPanel.Size = new System.Drawing.Size(694, 250);
            this.TableStudentsOneDepPanel.TabIndex = 5;
            // 
            // StudentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "StudentsPage";
            this.Size = new System.Drawing.Size(1006, 476);
            this.EmpsTabControl.ResumeLayout(false);
            this.AllStudentsTab.ResumeLayout(false);
            this.StudentsOneDepTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpsTabControl;
        private System.Windows.Forms.TabPage AllStudentsTab;
        private System.Windows.Forms.Panel TableAllStudentsPanel;
        private System.Windows.Forms.TabPage StudentsOneDepTab;
        private System.Windows.Forms.Panel TableStudentsOneDepPanel;
    }
}
