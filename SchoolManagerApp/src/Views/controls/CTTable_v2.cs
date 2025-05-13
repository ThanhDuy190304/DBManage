using SchoolManagerApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.controls
{
    public class CTTable_v2 : FlowLayoutPanel
    {
        private CTTableRow headerRow;
        private List<CTTableRow> dataRows;

        public delegate FlowLayoutPanel CustomActionButtonBuilder(string[] rowData);
        private CustomActionButtonBuilder actionButtonBuilder;
    }
}
