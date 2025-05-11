namespace SchoolManagerApp.src.Views.forms
{
    partial class RolePrivilegeManageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablePrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.tabRolePrivilegesControl = new System.Windows.Forms.TabControl();
            this.tabTablePrivileges = new System.Windows.Forms.TabPage();
            this.tabColumnPrivigleges = new System.Windows.Forms.TabPage();
            this.ColPrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.GrantPrivilegeButton = new SchoolManagerApp.Controls.CTButton();
            this.RevokeButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.tabRolePrivilegesControl.SuspendLayout();
            this.tabTablePrivileges.SuspendLayout();
            this.tabColumnPrivigleges.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePrivilegeManagePanel
            // 
            this.TablePrivilegeManagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePrivilegeManagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablePrivilegeManagePanel.Location = new System.Drawing.Point(124, 20);
            this.TablePrivilegeManagePanel.Name = "TablePrivilegeManagePanel";
            this.TablePrivilegeManagePanel.Padding = new System.Windows.Forms.Padding(4);
            this.TablePrivilegeManagePanel.Size = new System.Drawing.Size(773, 251);
            this.TablePrivilegeManagePanel.TabIndex = 3;
            // 
            // tabRolePrivilegesControl
            // 
            this.tabRolePrivilegesControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRolePrivilegesControl.Controls.Add(this.tabTablePrivileges);
            this.tabRolePrivilegesControl.Controls.Add(this.tabColumnPrivigleges);
            this.tabRolePrivilegesControl.Font = new System.Drawing.Font("Calibri", 13F);
            this.tabRolePrivilegesControl.Location = new System.Drawing.Point(37, 65);
            this.tabRolePrivilegesControl.Name = "tabRolePrivilegesControl";
            this.tabRolePrivilegesControl.SelectedIndex = 0;
            this.tabRolePrivilegesControl.Size = new System.Drawing.Size(1042, 326);
            this.tabRolePrivilegesControl.TabIndex = 5;
            // 
            // tabTablePrivileges
            // 
            this.tabTablePrivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTablePrivileges.Controls.Add(this.TablePrivilegeManagePanel);
            this.tabTablePrivileges.Location = new System.Drawing.Point(4, 30);
            this.tabTablePrivileges.Name = "tabTablePrivileges";
            this.tabTablePrivileges.Padding = new System.Windows.Forms.Padding(3);
            this.tabTablePrivileges.Size = new System.Drawing.Size(1034, 292);
            this.tabTablePrivileges.TabIndex = 0;
            this.tabTablePrivileges.Text = "Quyền trên bảng/ view";
            this.tabTablePrivileges.UseVisualStyleBackColor = true;
            // 
            // tabColumnPrivigleges
            // 
            this.tabColumnPrivigleges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabColumnPrivigleges.Controls.Add(this.ColPrivilegeManagePanel);
            this.tabColumnPrivigleges.Location = new System.Drawing.Point(4, 30);
            this.tabColumnPrivigleges.Name = "tabColumnPrivigleges";
            this.tabColumnPrivigleges.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumnPrivigleges.Size = new System.Drawing.Size(1034, 292);
            this.tabColumnPrivigleges.TabIndex = 1;
            this.tabColumnPrivigleges.Text = "Quyền trên cột";
            this.tabColumnPrivigleges.UseVisualStyleBackColor = true;
            // 
            // ColPrivilegeManagePanel
            // 
            this.ColPrivilegeManagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColPrivilegeManagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColPrivilegeManagePanel.Location = new System.Drawing.Point(140, 22);
            this.ColPrivilegeManagePanel.Name = "ColPrivilegeManagePanel";
            this.ColPrivilegeManagePanel.Padding = new System.Windows.Forms.Padding(4);
            this.ColPrivilegeManagePanel.Size = new System.Drawing.Size(771, 248);
            this.ColPrivilegeManagePanel.TabIndex = 4;
            // 
            // GrantPrivilegeButton
            // 
            this.GrantPrivilegeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrantPrivilegeButton.BackColor = System.Drawing.Color.White;
            this.GrantPrivilegeButton.BackgroundColor = System.Drawing.Color.White;
            this.GrantPrivilegeButton.BorderColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.BorderRadius = 8;
            this.GrantPrivilegeButton.BorderSize = 2;
            this.GrantPrivilegeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantPrivilegeButton.FlatAppearance.BorderSize = 0;
            this.GrantPrivilegeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantPrivilegeButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.GrantPrivilegeButton.ForeColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GrantPrivilegeButton.HoverIconColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.HoverTextColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.GrantPrivilegeButton.IconColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GrantPrivilegeButton.IconSize = 24;
            this.GrantPrivilegeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GrantPrivilegeButton.Location = new System.Drawing.Point(929, 19);
            this.GrantPrivilegeButton.Name = "GrantPrivilegeButton";
            this.GrantPrivilegeButton.Size = new System.Drawing.Size(150, 40);
            this.GrantPrivilegeButton.TabIndex = 0;
            this.GrantPrivilegeButton.Text = "Cấp quyền mới";
            this.GrantPrivilegeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GrantPrivilegeButton.TextColor = System.Drawing.Color.Green;
            this.GrantPrivilegeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GrantPrivilegeButton.UseVisualStyleBackColor = false;
            this.GrantPrivilegeButton.Click += new System.EventHandler(this.GrantPrivilegeButton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RevokeButton.BackColor = System.Drawing.Color.White;
            this.RevokeButton.BackgroundColor = System.Drawing.Color.White;
            this.RevokeButton.BorderColor = System.Drawing.Color.Red;
            this.RevokeButton.BorderRadius = 8;
            this.RevokeButton.BorderSize = 2;
            this.RevokeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevokeButton.FlatAppearance.BorderSize = 0;
            this.RevokeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokeButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.RevokeButton.ForeColor = System.Drawing.Color.Red;
            this.RevokeButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RevokeButton.HoverIconColor = System.Drawing.Color.Red;
            this.RevokeButton.HoverTextColor = System.Drawing.Color.Red;
            this.RevokeButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.RevokeButton.IconColor = System.Drawing.Color.Red;
            this.RevokeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevokeButton.IconSize = 24;
            this.RevokeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevokeButton.Location = new System.Drawing.Point(785, 19);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(113, 40);
            this.RevokeButton.TabIndex = 2;
            this.RevokeButton.Text = "Xóa quyền";
            this.RevokeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RevokeButton.TextColor = System.Drawing.Color.Red;
            this.RevokeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RevokeButton.UseVisualStyleBackColor = false;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(980, 416);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(99, 40);
            this.ReloadButton.TabIndex = 1;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReloadButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RolePrivilegeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 468);
            this.Controls.Add(this.tabRolePrivilegesControl);
            this.Controls.Add(this.GrantPrivilegeButton);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.ReloadButton);
            this.Name = "RolePrivilegeManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quyền role";
            this.tabRolePrivilegesControl.ResumeLayout(false);
            this.tabTablePrivileges.ResumeLayout(false);
            this.tabColumnPrivigleges.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TablePrivilegeManagePanel;
        private Controls.CTButton GrantPrivilegeButton;
        private Controls.CTButton ReloadButton;
        private Controls.CTButton RevokeButton;
        private System.Windows.Forms.TabControl tabRolePrivilegesControl;
        private System.Windows.Forms.TabPage tabTablePrivileges;
        private System.Windows.Forms.TabPage tabColumnPrivigleges;
        private System.Windows.Forms.Panel ColPrivilegeManagePanel;
    }
}