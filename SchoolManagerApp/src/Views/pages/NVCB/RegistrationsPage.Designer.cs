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
            this.CreateEmpButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
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
            this.CreateEmpButton.Location = new System.Drawing.Point(695, 37);
            this.CreateEmpButton.Name = "CreateEmpButton";
            this.CreateEmpButton.Size = new System.Drawing.Size(133, 40);
            this.CreateEmpButton.TabIndex = 4;
            this.CreateEmpButton.Text = "Đăng ký môn";
            this.CreateEmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateEmpButton.TextColor = System.Drawing.Color.Green;
            this.CreateEmpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateEmpButton.UseVisualStyleBackColor = false;
            this.CreateEmpButton.Click += new System.EventHandler(this.CreateEmpButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(740, 451);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(88, 40);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RegistrationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.CreateEmpButton);
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "RegistrationsPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.AllRegistrationsTab.ResumeLayout(false);
            this.EmpsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AllRegistrationsTab;
        private System.Windows.Forms.Panel TableAllRetristrationsPanel;
        private System.Windows.Forms.TabControl EmpsTabControl;
        private Controls.CTButton CreateEmpButton;
        private Controls.CTButton ReloadButton;
    }
}
