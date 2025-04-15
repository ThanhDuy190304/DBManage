using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;
using FontAwesome.Sharp;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Controls;

using Panel = System.Windows.Forms.Panel;
using Label = System.Windows.Forms.Label;

namespace SchoolManagerApp.Controls
{
    public class CTTable : FlowLayoutPanel
    {
        private CTTableRow headerRow;
        private List<CTTableRow> dataRows;

        public CTTable(Dictionary<string, int> columnDefinitions, List<string[]> data)
        {
            this.dataRows = new List<CTTableRow>();
            this.FlowDirection = FlowDirection.TopDown;
            InitializeComponents();
            AddHeaderRow(columnDefinitions);
            AddDataRows(columnDefinitions, data);
        }

        private void InitializeComponents()
        {
            this.AutoScroll = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AddHeaderRow(Dictionary<string, int> columnDefinitions)
        {
            this.headerRow = new CTTableRow(Color.LightGray, Color.Black, 40);
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

            Label emptyActionHeader = new Label();
            int actionColumnWidth = 80;
            headerRow.AddCell(emptyActionHeader, actionColumnWidth);
            this.Controls.Add(headerRow);
        }

        private void AddDataRows(Dictionary<string, int> columnDefinitions, List<string[]> data)
        {

            foreach (var rowData in data)
            {
                CTTableRow row = new CTTableRow(Color.White, Color.Black, 35);
                int i = 0;
                foreach (var col in columnDefinitions)
                {
                    Label cell = new Label()
                    {
                        Text = rowData[i],
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false
                    };
                    row.AddCell(cell, col.Value);
                    i++;
                }
                IconButton trashButton = new IconButton()
                {
                    IconChar = IconChar.Trash,
                    IconColor = Color.Red,
                    IconSize = 20,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    Text = "",
                    Cursor = Cursors.Hand,
                };
                trashButton.FlatAppearance.BorderSize = 0;
                trashButton.Size = new Size(24, 24);
                IconButton editButton = new IconButton()
                {
                    IconChar = IconChar.UserEdit,
                    IconColor = Color.Blue,
                    IconSize = 20,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    Text = "",
                    Cursor = Cursors.Hand,
                    Padding = new Padding(0),
                    Margin = new Padding(4)
                };
                editButton.FlatAppearance.BorderSize = 0;
                editButton.Size = new Size(24, 24);

                FlowLayoutPanel actionPanel = new FlowLayoutPanel()
                {
                    Width = 80,
                    Height = row.Height,
                    BackColor = Color.Transparent,
                    Margin = new Padding(0),
                    FlowDirection = FlowDirection.LeftToRight
                };
                actionPanel.Controls.Add(editButton);
                actionPanel.Controls.Add(trashButton);

                // Align icons in panel
                editButton.Location = new Point(5, 5);
                trashButton.Location = new Point(10, 5);
                row.AddCell(actionPanel, 80);

                // Add to table
                dataRows.Add(row);
                this.Controls.Add(row);
            }
        }
    }
}
