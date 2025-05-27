namespace SchoolManagerApp.src.Views.pages.DBA
{
    partial class AuditPage
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
            this.PoliciesTabControl = new System.Windows.Forms.TabControl();
            this.StandardAuditTab = new System.Windows.Forms.TabPage();
            this.StandardAuditSearchButton = new SchoolManagerApp.Controls.CTButton();
            this.StandardAuditComboBox = new SchoolManagerApp.src.Views.controls.CTComboBox();
            this.StandardAuditPanel = new System.Windows.Forms.Panel();
            this.FineGrantedAuditTab = new System.Windows.Forms.TabPage();
            this.FineGrantedAuditSearchButton = new SchoolManagerApp.Controls.CTButton();
            this.FineGrantedAuditPanel = new System.Windows.Forms.Panel();
            this.FineGrantedAuditComboBox = new SchoolManagerApp.src.Views.controls.CTComboBox();
            this.PoliciesTabControl.SuspendLayout();
            this.StandardAuditTab.SuspendLayout();
            this.FineGrantedAuditTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PoliciesTabControl
            // 
            this.PoliciesTabControl.Controls.Add(this.StandardAuditTab);
            this.PoliciesTabControl.Controls.Add(this.FineGrantedAuditTab);
            this.PoliciesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoliciesTabControl.Location = new System.Drawing.Point(0, 0);
            this.PoliciesTabControl.Name = "PoliciesTabControl";
            this.PoliciesTabControl.SelectedIndex = 0;
            this.PoliciesTabControl.Size = new System.Drawing.Size(1054, 517);
            this.PoliciesTabControl.TabIndex = 3;
            // 
            // StandardAuditTab
            // 
            this.StandardAuditTab.Controls.Add(this.StandardAuditSearchButton);
            this.StandardAuditTab.Controls.Add(this.StandardAuditComboBox);
            this.StandardAuditTab.Controls.Add(this.StandardAuditPanel);
            this.StandardAuditTab.Font = new System.Drawing.Font("Calibri", 13F);
            this.StandardAuditTab.Location = new System.Drawing.Point(4, 22);
            this.StandardAuditTab.Name = "StandardAuditTab";
            this.StandardAuditTab.Padding = new System.Windows.Forms.Padding(3);
            this.StandardAuditTab.Size = new System.Drawing.Size(1046, 491);
            this.StandardAuditTab.TabIndex = 1;
            this.StandardAuditTab.Text = "Standard Audit";
            this.StandardAuditTab.UseVisualStyleBackColor = true;
            // 
            // StandardAuditSearchButton
            // 
            this.StandardAuditSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StandardAuditSearchButton.BackColor = System.Drawing.Color.White;
            this.StandardAuditSearchButton.BackgroundColor = System.Drawing.Color.White;
            this.StandardAuditSearchButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.BorderRadius = 8;
            this.StandardAuditSearchButton.BorderSize = 2;
            this.StandardAuditSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StandardAuditSearchButton.FlatAppearance.BorderSize = 0;
            this.StandardAuditSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StandardAuditSearchButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.StandardAuditSearchButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StandardAuditSearchButton.HoverIconColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.StandardAuditSearchButton.IconColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StandardAuditSearchButton.IconSize = 24;
            this.StandardAuditSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StandardAuditSearchButton.Location = new System.Drawing.Point(899, 11);
            this.StandardAuditSearchButton.Name = "StandardAuditSearchButton";
            this.StandardAuditSearchButton.Size = new System.Drawing.Size(115, 40);
            this.StandardAuditSearchButton.TabIndex = 7;
            this.StandardAuditSearchButton.Text = "Tìm kiếm";
            this.StandardAuditSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StandardAuditSearchButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.StandardAuditSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StandardAuditSearchButton.UseVisualStyleBackColor = false;
            this.StandardAuditSearchButton.Click += new System.EventHandler(this.StandardAuditSearchButton_Click);
            // 
            // StandardAuditComboBox
            // 
            this.StandardAuditComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StandardAuditComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StandardAuditComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.StandardAuditComboBox.BorderSize = 1;
            this.StandardAuditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.StandardAuditComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StandardAuditComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.StandardAuditComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.StandardAuditComboBox.Items.AddRange(new object[] {
            "All",
            "Sessions"});
            this.StandardAuditComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.StandardAuditComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.StandardAuditComboBox.Location = new System.Drawing.Point(34, 11);
            this.StandardAuditComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.StandardAuditComboBox.Name = "StandardAuditComboBox";
            this.StandardAuditComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.StandardAuditComboBox.Size = new System.Drawing.Size(850, 40);
            this.StandardAuditComboBox.TabIndex = 6;
            this.StandardAuditComboBox.Texts = "";
            // 
            // StandardAuditPanel
            // 
            this.StandardAuditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StandardAuditPanel.AutoScroll = true;
            this.StandardAuditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StandardAuditPanel.Location = new System.Drawing.Point(34, 57);
            this.StandardAuditPanel.Name = "StandardAuditPanel";
            this.StandardAuditPanel.Size = new System.Drawing.Size(980, 390);
            this.StandardAuditPanel.TabIndex = 5;
            // 
            // FineGrantedAuditTab
            // 
            this.FineGrantedAuditTab.Controls.Add(this.FineGrantedAuditSearchButton);
            this.FineGrantedAuditTab.Controls.Add(this.FineGrantedAuditPanel);
            this.FineGrantedAuditTab.Controls.Add(this.FineGrantedAuditComboBox);
            this.FineGrantedAuditTab.Location = new System.Drawing.Point(4, 22);
            this.FineGrantedAuditTab.Name = "FineGrantedAuditTab";
            this.FineGrantedAuditTab.Size = new System.Drawing.Size(1046, 491);
            this.FineGrantedAuditTab.TabIndex = 2;
            this.FineGrantedAuditTab.Text = "Fine-granted Audit";
            this.FineGrantedAuditTab.UseVisualStyleBackColor = true;
            // 
            // FineGrantedAuditSearchButton
            // 
            this.FineGrantedAuditSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FineGrantedAuditSearchButton.BackColor = System.Drawing.Color.White;
            this.FineGrantedAuditSearchButton.BackgroundColor = System.Drawing.Color.White;
            this.FineGrantedAuditSearchButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.BorderRadius = 8;
            this.FineGrantedAuditSearchButton.BorderSize = 2;
            this.FineGrantedAuditSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FineGrantedAuditSearchButton.FlatAppearance.BorderSize = 0;
            this.FineGrantedAuditSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FineGrantedAuditSearchButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.FineGrantedAuditSearchButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.FineGrantedAuditSearchButton.HoverIconColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.FineGrantedAuditSearchButton.IconColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FineGrantedAuditSearchButton.IconSize = 24;
            this.FineGrantedAuditSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FineGrantedAuditSearchButton.Location = new System.Drawing.Point(903, 26);
            this.FineGrantedAuditSearchButton.Name = "FineGrantedAuditSearchButton";
            this.FineGrantedAuditSearchButton.Size = new System.Drawing.Size(115, 40);
            this.FineGrantedAuditSearchButton.TabIndex = 9;
            this.FineGrantedAuditSearchButton.Text = "Tìm kiếm";
            this.FineGrantedAuditSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FineGrantedAuditSearchButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.FineGrantedAuditSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FineGrantedAuditSearchButton.UseVisualStyleBackColor = false;
            this.FineGrantedAuditSearchButton.Click += new System.EventHandler(this.FineGrantedAuditSearchButton_Click);
            // 
            // FineGrantedAuditPanel
            // 
            this.FineGrantedAuditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FineGrantedAuditPanel.AutoScroll = true;
            this.FineGrantedAuditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FineGrantedAuditPanel.Location = new System.Drawing.Point(38, 84);
            this.FineGrantedAuditPanel.Name = "FineGrantedAuditPanel";
            this.FineGrantedAuditPanel.Size = new System.Drawing.Size(980, 368);
            this.FineGrantedAuditPanel.TabIndex = 6;
            // 
            // FineGrantedAuditComboBox
            // 
            this.FineGrantedAuditComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FineGrantedAuditComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FineGrantedAuditComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.FineGrantedAuditComboBox.BorderSize = 1;
            this.FineGrantedAuditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FineGrantedAuditComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FineGrantedAuditComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.FineGrantedAuditComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.FineGrantedAuditComboBox.Items.AddRange(new object[] {
            "All",
            "AUDIT_LUONG_PHUCAP_NON_TCHC",
            "AUDIT_DIEM_NON_NV_PKT",
            "AUDIT_THAOTAC_TREN_SV_KHAC",
            "AUDIT_THAOTAC_NGOAI_THOI_GIAN"});
            this.FineGrantedAuditComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.FineGrantedAuditComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.FineGrantedAuditComboBox.Location = new System.Drawing.Point(38, 26);
            this.FineGrantedAuditComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.FineGrantedAuditComboBox.Name = "FineGrantedAuditComboBox";
            this.FineGrantedAuditComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.FineGrantedAuditComboBox.Size = new System.Drawing.Size(850, 40);
            this.FineGrantedAuditComboBox.TabIndex = 8;
            this.FineGrantedAuditComboBox.Texts = "";
            // 
            // AuditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PoliciesTabControl);
            this.Name = "AuditPage";
            this.Size = new System.Drawing.Size(1054, 517);
            this.PoliciesTabControl.ResumeLayout(false);
            this.StandardAuditTab.ResumeLayout(false);
            this.FineGrantedAuditTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PoliciesTabControl;
        private System.Windows.Forms.TabPage StandardAuditTab;
        private System.Windows.Forms.Panel StandardAuditPanel;
        private System.Windows.Forms.TabPage FineGrantedAuditTab;
        private System.Windows.Forms.Panel FineGrantedAuditPanel;
        private controls.CTComboBox StandardAuditComboBox;
        private Controls.CTButton StandardAuditSearchButton;
        private Controls.CTButton FineGrantedAuditSearchButton;
        private controls.CTComboBox FineGrantedAuditComboBox;
    }
}
