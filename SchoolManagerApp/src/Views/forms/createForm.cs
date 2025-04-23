using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.partials
{
    public partial class CreateForm : Form

    {
        private readonly Func<string, string, Task<bool>> onCreateCallback;
        public CreateForm(string title, Func<string, string, Task<bool>> onCreate)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.createLabel.Text = title;
            this.onCreateCallback = onCreate;
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            string name = textNameBox.Texts;
            string password = textPasswordBox.Texts;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên role", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await this.onCreateCallback(name, password);
        }

        private void iconExitButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                iconExitButton_Click(null, null); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

       
    }
}
