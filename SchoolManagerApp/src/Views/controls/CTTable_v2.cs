using SchoolManagerApp.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SchoolManagerApp.src.Views.controls
{
    public class CTTable_v2 : FlowLayoutPanel
    {
        public CTTable_v2(Dictionary<string, int> columnDefinitions, List<string[]> data, Control[][] actionButtonBuilders = null)
        {
            InitializeComponents();
            actionButtonBuilders = actionButtonBuilders ?? new Control[0][];
            AddHeaderRow(columnDefinitions, actionButtonBuilders);
            AddDataRows(columnDefinitions, data, actionButtonBuilders);
        }

        private void AddHeaderRow(Dictionary<string, int> columnDefinitions, Control[][] actionButtonBuilders)
        {
            var headerRow = new CTTableRow(Color.Navy, Color.White, 40);
            foreach (var col in columnDefinitions)
            {
                Label label = new Label()
                {
                    Text = col.Key,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.None,
                    AutoSize = false,
                };
                headerRow.AddCell(label, col.Value);
            }
            if (actionButtonBuilders.Length > 0)
            {
                foreach (var actionButtonHeader in actionButtonBuilders[0])
                {
                    headerRow.AddCell(new Label() { Text = "", AutoSize = false }, 30);
                }
            }

            this.Controls.Add(headerRow);
        }

        private void AddDataRows(Dictionary<string, int> columnDefinitions, List<string[]> data, Control[][] actionButtonBuilders)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var rowData = data[i];
                Color rowColor = (i % 2 == 0) ? Color.White : Color.Lavender;

                CTTableRow row = new CTTableRow(rowColor, Color.Black, 35);

                int j = 0;
                foreach (var col in columnDefinitions)
                {
                    Label cell = new Label()
                    {
                        Text = rowData[j],
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false
                    };
                    row.AddCell(cell, col.Value);
                    j++;
                }

                if (actionButtonBuilders.Length > 0)
                {
                    j = 0;
                    foreach (var actionButton in actionButtonBuilders[i])
                    {
                        row.AddCell(actionButton, 30);
                        j++;
                    }
                }    
                this.Controls.Add(row);
            }
        } 
        private void InitializeComponents()
        {
            this.AutoScroll = true;
            this.WrapContents = false;
            this.Height = 300;
            this.FlowDirection = FlowDirection.TopDown;
            this.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

    }
}
