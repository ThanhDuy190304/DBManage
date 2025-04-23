using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.forms
{
    public partial class GrantPrivilegeForm : Form
    {
        public delegate void GrantActionHandler(
            string name,
            string objectType,
            string objectName,
            string privilege,
            string[] columns,
            bool withGrantOption
            );
        public event GrantActionHandler OnGrantClicked;

        private string name;
        public GrantPrivilegeForm(string name)
        {
            this.name = name;
            InitializeComponent();
            this.confirmButton.Click += (s, e) =>
               OnGrantClicked?.Invoke(
                   this.name,
                   this.ObjectTypeComboBox.Texts,
                   this.ObjectNameTextBox.Texts,
                   this.PirivilegeComboBox.Texts,
                   this.splitCols(ColsNameTextBox.Texts),
                   this.WithGrantOptioncheckBox.Checked
                   );
        }

        private string[] splitCols(string colsNameTextBox)
        {
            string[] columns = colsNameTextBox.Split(',')
                                              .Select(col => col.Trim())
                                              .Where(col => !string.IsNullOrEmpty(col))
                                              .ToArray();
            return columns.Length > 0 ? columns : null;
        }


    }
}
