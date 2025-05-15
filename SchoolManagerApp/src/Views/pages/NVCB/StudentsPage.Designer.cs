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
            this.AllStudentsTab = new System.Windows.Forms.TabPage();
            this.TableAllStudentsPanel = new System.Windows.Forms.Panel();
            this.EmpsTabControl = new System.Windows.Forms.TabControl();
            this.CreateStuButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.AllStudentsTab.SuspendLayout();
            this.EmpsTabControl.SuspendLayout();
            this.SuspendLayout();
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
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllStudentsTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(119, 63);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 1;
            // 
            // CreateStuButton
            // 
            this.CreateStuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateStuButton.BackColor = System.Drawing.Color.White;
            this.CreateStuButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateStuButton.BorderColor = System.Drawing.Color.Green;
            this.CreateStuButton.BorderRadius = 8;
            this.CreateStuButton.BorderSize = 2;
            this.CreateStuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateStuButton.FlatAppearance.BorderSize = 0;
            this.CreateStuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStuButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateStuButton.ForeColor = System.Drawing.Color.Green;
            this.CreateStuButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateStuButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateStuButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateStuButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CreateStuButton.IconColor = System.Drawing.Color.Green;
            this.CreateStuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateStuButton.IconSize = 24;
            this.CreateStuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateStuButton.Location = new System.Drawing.Point(732, 17);
            this.CreateStuButton.Name = "CreateStuButton";
            this.CreateStuButton.Size = new System.Drawing.Size(151, 40);
            this.CreateStuButton.TabIndex = 5;
            this.CreateStuButton.Text = "Thêm sinh viên";
            this.CreateStuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateStuButton.TextColor = System.Drawing.Color.Green;
            this.CreateStuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateStuButton.UseVisualStyleBackColor = false;
            this.CreateStuButton.Click += new System.EventHandler(this.CreateStuButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(795, 420);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(88, 40);
            this.ReloadButton.TabIndex = 6;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // StudentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.CreateStuButton);
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "StudentsPage";
            this.Size = new System.Drawing.Size(1006, 476);
            this.AllStudentsTab.ResumeLayout(false);
            this.EmpsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AllStudentsTab;
        private System.Windows.Forms.Panel TableAllStudentsPanel;
        private System.Windows.Forms.TabControl EmpsTabControl;
        private Controls.CTButton CreateStuButton;
        private Controls.CTButton ReloadButton;
    }
}
