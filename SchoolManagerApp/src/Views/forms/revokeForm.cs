using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace SchoolManagerApp.src.Views.forms
{
    public partial class revokeForm : Form
    {
        private string name;
        public delegate void RevokeActionHandler(string name, string objectName, string privilege);
        public event RevokeActionHandler OnRevokeClicked;

        public revokeForm(string name)
        {
            this.name = name;
            InitializeComponent();
            this.confirmButton.Click += (s, e) =>
                OnRevokeClicked?.Invoke(this.name, this.ObjectNameTextBox.Texts, this.PirivilegeComboBox.Texts);

        }

       
    }
}
