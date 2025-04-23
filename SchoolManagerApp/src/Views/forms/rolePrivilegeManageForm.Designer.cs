namespace SchoolManagerApp.src.Views.forms
{
    partial class rolePrivilegeManageForm
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
            this.ColPrivilegeLabel = new System.Windows.Forms.Label();
            this.TablePrivilegeLabel = new System.Windows.Forms.Label();
            this.TablePrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.panelManage = new System.Windows.Forms.Panel();
            this.ColPrivilegeManagePanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.RevokeButton = new SchoolManagerApp.Controls.CTButton();
            this.GrantPrivilegeButton = new SchoolManagerApp.Controls.CTButton();
            this.ReloadButton = new SchoolManagerApp.Controls.CTButton();
            this.panelManage.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColPrivilegeLabel
            // 
            this.ColPrivilegeLabel.AutoSize = true;
            this.ColPrivilegeLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.ColPrivilegeLabel.Location = new System.Drawing.Point(14, 328);
            this.ColPrivilegeLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ColPrivilegeLabel.Name = "ColPrivilegeLabel";
            this.ColPrivilegeLabel.Size = new System.Drawing.Size(119, 22);
            this.ColPrivilegeLabel.TabIndex = 1;
            this.ColPrivilegeLabel.Text = "Quyền trên cột";
            // 
            // TablePrivilegeLabel
            // 
            this.TablePrivilegeLabel.AutoSize = true;
            this.TablePrivilegeLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.TablePrivilegeLabel.Location = new System.Drawing.Point(14, 29);
            this.TablePrivilegeLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.TablePrivilegeLabel.Name = "TablePrivilegeLabel";
            this.TablePrivilegeLabel.Size = new System.Drawing.Size(130, 22);
            this.TablePrivilegeLabel.TabIndex = 2;
            this.TablePrivilegeLabel.Text = "Quyền trên bảng";
            // 
            // TablePrivilegeManagePanel
            // 
            this.TablePrivilegeManagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TablePrivilegeManagePanel.Location = new System.Drawing.Point(18, 70);
            this.TablePrivilegeManagePanel.Name = "TablePrivilegeManagePanel";
            this.TablePrivilegeManagePanel.Size = new System.Drawing.Size(760, 215);
            this.TablePrivilegeManagePanel.TabIndex = 3;
            // 
            // panelManage
            // 
            this.panelManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelManage.Controls.Add(this.ColPrivilegeManagePanel);
            this.panelManage.Controls.Add(this.TablePrivilegeLabel);
            this.panelManage.Controls.Add(this.ColPrivilegeLabel);
            this.panelManage.Controls.Add(this.TablePrivilegeManagePanel);
            this.panelManage.Location = new System.Drawing.Point(190, 93);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(796, 391);
            this.panelManage.TabIndex = 4;
            // 
            // ColPrivilegeManagePanel
            // 
            this.ColPrivilegeManagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColPrivilegeManagePanel.Location = new System.Drawing.Point(18, 364);
            this.ColPrivilegeManagePanel.Name = "ColPrivilegeManagePanel";
            this.ColPrivilegeManagePanel.Size = new System.Drawing.Size(760, 215);
            this.ColPrivilegeManagePanel.TabIndex = 4;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.RevokeButton);
            this.buttonPanel.Controls.Add(this.GrantPrivilegeButton);
            this.buttonPanel.Controls.Add(this.ReloadButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1108, 70);
            this.buttonPanel.TabIndex = 5;
            // 
            // RevokeButton
            // 
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
            this.RevokeButton.Location = new System.Drawing.Point(715, 27);
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
            // GrantPrivilegeButton
            // 
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
            this.GrantPrivilegeButton.Location = new System.Drawing.Point(859, 27);
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
            // ReloadButton
            // 
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
            this.ReloadButton.Location = new System.Drawing.Point(141, 27);
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
            // rolePrivilegeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1108, 484);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.panelManage);
            this.Name = "rolePrivilegeManageForm";
            this.Text = "Quản lý quyền role";
            this.panelManage.ResumeLayout(false);
            this.panelManage.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ColPrivilegeLabel;
        private System.Windows.Forms.Label TablePrivilegeLabel;
        private System.Windows.Forms.Panel TablePrivilegeManagePanel;
        private System.Windows.Forms.Panel panelManage;
        private System.Windows.Forms.Panel ColPrivilegeManagePanel;
        private System.Windows.Forms.Panel buttonPanel;
        private Controls.CTButton GrantPrivilegeButton;
        private Controls.CTButton ReloadButton;
        private Controls.CTButton RevokeButton;
    }
}