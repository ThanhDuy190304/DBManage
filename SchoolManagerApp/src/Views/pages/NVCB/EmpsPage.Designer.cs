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
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.CreateEmpButton = new SchoolManagerApp.Controls.CTButton();
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
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadButton.BackColor = System.Drawing.Color.White;
            this.ReloadButton.BackgroundColor = System.Drawing.Color.White;
            this.ReloadButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.BorderRadius = 8;
            this.ReloadButton.BorderSize = 2;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.ReloadButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReloadButton.HoverIconColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.ReloadButton.IconColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadButton.IconSize = 24;
            this.ReloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReloadButton.Location = new System.Drawing.Point(720, 449);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(99, 40);
            this.ReloadButton.TabIndex = 2;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // CreateEmpButton
            // 
            this.CreateEmpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateEmpButton.BackColor = System.Drawing.Color.White;
            this.CreateEmpButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateEmpButton.BorderColor = System.Drawing.Color.Green;
            this.CreateEmpButton.BorderRadius = 8;
            this.CreateEmpButton.BorderSize = 2;
            this.CreateEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateEmpButton.FlatAppearance.BorderSize = 0;
            this.CreateEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEmpButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateEmpButton.ForeColor = System.Drawing.Color.Green;
            this.CreateEmpButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateEmpButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateEmpButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateEmpButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CreateEmpButton.IconColor = System.Drawing.Color.Green;
            this.CreateEmpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateEmpButton.IconSize = 24;
            this.CreateEmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateEmpButton.Location = new System.Drawing.Point(669, 24);
            this.CreateEmpButton.Name = "CreateEmpButton";
            this.CreateEmpButton.Size = new System.Drawing.Size(150, 40);
            this.CreateEmpButton.TabIndex = 3;
            this.CreateEmpButton.Text = "Tạo nhân viên";
            this.CreateEmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateEmpButton.TextColor = System.Drawing.Color.Green;
            this.CreateEmpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateEmpButton.UseVisualStyleBackColor = false;
            this.CreateEmpButton.Click += new System.EventHandler(this.CreateEmpButton_Click);
            // 
            // EmpsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateEmpButton);
            this.Controls.Add(this.ReloadButton);
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
        private Controls.CTButton ReloadButton;
        private Controls.CTButton CreateEmpButton;
    }
}
