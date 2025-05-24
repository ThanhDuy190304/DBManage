namespace SchoolManagerApp.src.Views.pages.SharedPage
{
    partial class NotificationPage
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
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationPanel.Location = new System.Drawing.Point(66, 50);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(780, 437);
            this.NotificationPanel.TabIndex = 5;
            // 
            // NotificationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotificationPanel);
            this.Name = "NotificationPage";
            this.Size = new System.Drawing.Size(897, 517);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NotificationPanel;
    }
}
