namespace SchoolManagerApp.src.Views.pages.NVCB
{
    partial class RegistrationsPage
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
            this.AllRegistrationsTab = new System.Windows.Forms.TabPage();
            this.TableAllRetristrationsPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl = new System.Windows.Forms.TabControl();
            this.AllRegistrationsTab.SuspendLayout();
            this.EmpsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllRegistrationsTab
            // 
            this.AllRegistrationsTab.Controls.Add(this.TableAllRetristrationsPanel);
            this.AllRegistrationsTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.AllRegistrationsTab.Location = new System.Drawing.Point(4, 22);
            this.AllRegistrationsTab.Name = "AllRegistrationsTab";
            this.AllRegistrationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllRegistrationsTab.Size = new System.Drawing.Size(760, 325);
            this.AllRegistrationsTab.TabIndex = 0;
            this.AllRegistrationsTab.Text = "Danh sách đăng ký";
            this.AllRegistrationsTab.UseVisualStyleBackColor = true;
            // 
            // TableAllRetristrationsPanel
            // 
            this.TableAllRetristrationsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableAllRetristrationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableAllRetristrationsPanel.Location = new System.Drawing.Point(31, 35);
            this.TableAllRetristrationsPanel.Name = "TableAllRetristrationsPanel";
            this.TableAllRetristrationsPanel.Size = new System.Drawing.Size(694, 250);
            this.TableAllRetristrationsPanel.TabIndex = 4;
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllRegistrationsTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(64, 83);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 1;
            // 
            // CoursesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "CoursesPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.AllRegistrationsTab.ResumeLayout(false);
            this.EmpsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AllRegistrationsTab;
        private System.Windows.Forms.Panel TableAllRetristrationsPanel;
        private System.Windows.Forms.TabControl EmpsTabControl;
    }
}
