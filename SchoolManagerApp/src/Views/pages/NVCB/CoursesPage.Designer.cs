using SchoolManagerApp.Controls;

namespace SchoolManagerApp.src.Views.pages.NVCB
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
            this.CoursesIsAssignedToEmpTab = new System.Windows.Forms.TabPage();
            this.TableCoursesIsAssignedToEmpPanel = new System.Windows.Forms.Panel();
            this.CoursesIsAssignedToEmpThatOneDepTab = new System.Windows.Forms.TabPage();
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel = new System.Windows.Forms.Panel();
            this.CreateSubButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.EmpsTabControl.SuspendLayout();
            this.AllCoursesTab.SuspendLayout();
            this.CoursesIsAssignedToEmpTab.SuspendLayout();
            this.CoursesIsAssignedToEmpThatOneDepTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpsTabControl
            // 
            this.EmpsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpsTabControl.Controls.Add(this.AllCoursesTab);
            this.EmpsTabControl.Controls.Add(this.CoursesIsAssignedToEmpTab);
            this.EmpsTabControl.Controls.Add(this.CoursesIsAssignedToEmpThatOneDepTab);
            this.EmpsTabControl.Location = new System.Drawing.Point(64, 83);
            this.EmpsTabControl.Name = "EmpsTabControl";
            this.EmpsTabControl.SelectedIndex = 0;
            this.EmpsTabControl.Size = new System.Drawing.Size(768, 351);
            this.EmpsTabControl.TabIndex = 1;
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
            // CoursesIsAssignedToEmpTab
            // 
            this.CoursesIsAssignedToEmpTab.Controls.Add(this.TableCoursesIsAssignedToEmpPanel);
            this.CoursesIsAssignedToEmpTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.CoursesIsAssignedToEmpTab.Location = new System.Drawing.Point(4, 22);
            this.CoursesIsAssignedToEmpTab.Name = "CoursesIsAssignedToEmpTab";
            this.CoursesIsAssignedToEmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesIsAssignedToEmpTab.Size = new System.Drawing.Size(760, 325);
            this.CoursesIsAssignedToEmpTab.TabIndex = 1;
            this.CoursesIsAssignedToEmpTab.Text = "Khóa học phụ trách";
            this.CoursesIsAssignedToEmpTab.UseVisualStyleBackColor = true;
            // 
            // TableCoursesIsAssignedToEmpPanel
            // 
            this.TableCoursesIsAssignedToEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCoursesIsAssignedToEmpPanel.AutoScroll = true;
            this.TableCoursesIsAssignedToEmpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableCoursesIsAssignedToEmpPanel.Location = new System.Drawing.Point(34, 31);
            this.TableCoursesIsAssignedToEmpPanel.Name = "TableCoursesIsAssignedToEmpPanel";
            this.TableCoursesIsAssignedToEmpPanel.Size = new System.Drawing.Size(694, 250);
            this.TableCoursesIsAssignedToEmpPanel.TabIndex = 5;
            // 
            // CoursesIsAssignedToEmpThatOneDepTab
            // 
            this.CoursesIsAssignedToEmpThatOneDepTab.Controls.Add(this.TableCoursesIsAssignedTOEmpThatOneDepPanel);
            this.CoursesIsAssignedToEmpThatOneDepTab.Location = new System.Drawing.Point(4, 22);
            this.CoursesIsAssignedToEmpThatOneDepTab.Name = "CoursesIsAssignedToEmpThatOneDepTab";
            this.CoursesIsAssignedToEmpThatOneDepTab.Size = new System.Drawing.Size(760, 325);
            this.CoursesIsAssignedToEmpThatOneDepTab.TabIndex = 2;
            this.CoursesIsAssignedToEmpThatOneDepTab.Text = "Khóa học của các giáo viên cùng đơn vị";
            this.CoursesIsAssignedToEmpThatOneDepTab.UseVisualStyleBackColor = true;
            // 
            // TableCoursesIsAssignedTOEmpThatOneDepPanel
            // 
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.AutoScroll = true;
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Location = new System.Drawing.Point(38, 39);
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Name = "TableCoursesIsAssignedTOEmpThatOneDepPanel";
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.Size = new System.Drawing.Size(694, 250);
            this.TableCoursesIsAssignedTOEmpThatOneDepPanel.TabIndex = 6;
            // 
            // CreateSubButton
            // 
            this.CreateSubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSubButton.BackColor = System.Drawing.Color.White;
            this.CreateSubButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateSubButton.BorderColor = System.Drawing.Color.Green;
            this.CreateSubButton.BorderRadius = 8;
            this.CreateSubButton.BorderSize = 2;
            this.CreateSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateSubButton.FlatAppearance.BorderSize = 0;
            this.CreateSubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSubButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateSubButton.ForeColor = System.Drawing.Color.Green;
            this.CreateSubButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateSubButton.HoverIconColor = System.Drawing.Color.Green;
            this.CreateSubButton.HoverTextColor = System.Drawing.Color.Green;
            this.CreateSubButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CreateSubButton.IconColor = System.Drawing.Color.Green;
            this.CreateSubButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateSubButton.IconSize = 24;
            this.CreateSubButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateSubButton.Location = new System.Drawing.Point(701, 37);
            this.CreateSubButton.Name = "CreateSubButton";
            this.CreateSubButton.Size = new System.Drawing.Size(127, 40);
            this.CreateSubButton.TabIndex = 4;
            this.CreateSubButton.Text = "Tạo môn học";
            this.CreateSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateSubButton.TextColor = System.Drawing.Color.Green;
            this.CreateSubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateSubButton.UseVisualStyleBackColor = false;
            this.CreateSubButton.Click += new System.EventHandler(this.CreateSubButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(739, 451);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(89, 40);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // CoursesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.CreateSubButton);
            this.Controls.Add(this.EmpsTabControl);
            this.Name = "CoursesPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.EmpsTabControl.ResumeLayout(false);
            this.AllCoursesTab.ResumeLayout(false);
            this.CoursesIsAssignedToEmpTab.ResumeLayout(false);
            this.CoursesIsAssignedToEmpThatOneDepTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpsTabControl;
        private System.Windows.Forms.TabPage AllCoursesTab;
        private System.Windows.Forms.Panel TableAllCurrentCoursesPanel;
        private System.Windows.Forms.TabPage CoursesIsAssignedToEmpTab;
        private System.Windows.Forms.Panel TableCoursesIsAssignedToEmpPanel;
        private System.Windows.Forms.TabPage CoursesIsAssignedToEmpThatOneDepTab;
        private System.Windows.Forms.Panel TableCoursesIsAssignedTOEmpThatOneDepPanel;
        private Controls.CTButton CreateSubButton;
        private Controls.CTButton ReloadButton;
    }
}
