using System;
using System.Drawing;

using System.Windows.Forms;

namespace SchoolManagerApp.Controls
{
    public class CTTableRow : FlowLayoutPanel
    {
        public CTTableRow() : this(Color.Black, Color.White, 40)
        {
        }
        public CTTableRow(Color backColor, Color foreColor, int height)
        {
            this.Height = height;
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.WrapContents = false;
            this.AutoSize = true;
            this.Padding = this.Margin = new Padding(0);
        }

        public void AddCell(Control cell, int width)
        {
            cell.Width = width;
            cell.Height = this.Height - cell.Margin.Vertical;
            cell.Margin = new Padding(2);
            this.Controls.Add(cell);
        }

    }
}
