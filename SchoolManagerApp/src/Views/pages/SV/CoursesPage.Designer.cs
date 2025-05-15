namespace SchoolManagerApp.src.Views.pages.SV
{
    partial class CoursesPage
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
            this.AllCoursesTab = new System.Windows.Forms.TabPage();
            this.TableAllCurrentCoursesPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl.SuspendLayout();
            this.AllCoursesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllCoursesTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(64, 83);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 2;
            // 
            // AllCoursesTab
            // 
            this.AllCoursesTab.Controls.Add(this.TableAllCurrentCoursesPanel);
            this.AllCoursesTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.AllCoursesTab.Location = new System.Drawing.Point(4, 22);
            this.AllCoursesTab.Name = "AllCoursesTab";
            this.AllCoursesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllCoursesTab.Size = new System.Drawing.Size(760, 325);
            this.AllCoursesTab.TabIndex = 0;
            this.AllCoursesTab.Text = "Khóa học hiện tại";
            this.AllCoursesTab.UseVisualStyleBackColor = true;
            // 
            // TableAllCurrentCoursesPanel
            // 
            this.TableAllCurrentCoursesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableAllCurrentCoursesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableAllCurrentCoursesPanel.Location = new System.Drawing.Point(31, 35);
            this.TableAllCurrentCoursesPanel.Name = "TableAllCurrentCoursesPanel";
            this.TableAllCurrentCoursesPanel.Size = new System.Drawing.Size(694, 250);
            this.TableAllCurrentCoursesPanel.TabIndex = 4;
            // 
            // CoursesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "CoursesPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.EmpsTabControl.ResumeLayout(false);
            this.AllCoursesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpsTabControl;
        private System.Windows.Forms.TabPage AllCoursesTab;
        private System.Windows.Forms.Panel TableAllCurrentCoursesPanel;
    }
}
