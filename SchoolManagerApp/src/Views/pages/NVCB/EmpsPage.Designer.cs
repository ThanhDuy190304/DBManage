namespace SchoolManagerApp.src.Views.pages.NVCB
{
    partial class EmpsPage
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
            this.AllEmpsTab = new System.Windows.Forms.TabPage();
            this.TableAllEmpsPanel = new System.Windows.Forms.Panel();
            this.EmpsOneDepTab = new System.Windows.Forms.TabPage();
            this.TableEmpsOneDepPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl.SuspendLayout();
            this.AllEmpsTab.SuspendLayout();
            this.EmpsOneDepTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllEmpsTab);
            this.EmpsTabControl.Controls.Add(this.EmpsOneDepTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(55, 70);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 0;
            // 
            // AllEmpsTab
            // 
            this.AllEmpsTab.Controls.Add(this.TableAllEmpsPanel);
            this.AllEmpsTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.AllEmpsTab.Location = new System.Drawing.Point(4, 22);
            this.AllEmpsTab.Name = "AllEmpsTab";
            this.AllEmpsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllEmpsTab.Size = new System.Drawing.Size(760, 325);
            this.AllEmpsTab.TabIndex = 0;
            this.AllEmpsTab.Text = "Tất cả nhân viên";
            this.AllEmpsTab.UseVisualStyleBackColor = true;
            // 
            // TableAllEmpsPanel
            // 
            this.TableAllEmpsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableAllEmpsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableAllEmpsPanel.Location = new System.Drawing.Point(31, 35);
            this.TableAllEmpsPanel.Name = "TableAllEmpsPanel";
            this.TableAllEmpsPanel.Size = new System.Drawing.Size(694, 250);
            this.TableAllEmpsPanel.TabIndex = 4;
            // 
            // EmpsOneDepTab
            // 
            this.EmpsOneDepTab.Controls.Add(this.TableEmpsOneDepPanel);
            this.EmpsOneDepTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.EmpsOneDepTab.Location = new System.Drawing.Point(4, 22);
            this.EmpsOneDepTab.Name = "EmpsOneDepTab";
            this.EmpsOneDepTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmpsOneDepTab.Size = new System.Drawing.Size(760, 325);
            this.EmpsOneDepTab.TabIndex = 1;
            this.EmpsOneDepTab.Text = "Nhân viên cùng đơn vị";
            this.EmpsOneDepTab.UseVisualStyleBackColor = true;
            // 
            // TableEmpsOneDepPanel
            // 
            this.TableEmpsOneDepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableEmpsOneDepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableEmpsOneDepPanel.Location = new System.Drawing.Point(34, 31);
            this.TableEmpsOneDepPanel.Name = "TableEmpsOneDepPanel";
            this.TableEmpsOneDepPanel.Size = new System.Drawing.Size(694, 250);
            this.TableEmpsOneDepPanel.TabIndex = 5;
            // 
            // EmpsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "EmpsPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.EmpsTabControl.ResumeLayout(false);
            this.AllEmpsTab.ResumeLayout(false);
            this.EmpsOneDepTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpsTabControl;
        private System.Windows.Forms.TabPage AllEmpsTab;
        private System.Windows.Forms.TabPage EmpsOneDepTab;
        private System.Windows.Forms.Panel TableAllEmpsPanel;
        private System.Windows.Forms.Panel TableEmpsOneDepPanel;
    }
}
