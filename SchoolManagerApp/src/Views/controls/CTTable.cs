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

        public delegate void DeleteActionHandler(string id);
        public event DeleteActionHandler OnDeleteClicked;

        public CTTable(Dictionary<string, int> columnDefinitions, List<string[]> data)
        {
            this.dataRows = new List<CTTableRow>();
            InitializeComponents();
            AddHeaderRow(columnDefinitions);
            AddDataRows(columnDefinitions, data);
        }

        private void InitializeComponents()
        {
            this.AutoScroll = true;
            this.WrapContents = false;
            this.Height = 300;
            this.FlowDirection = FlowDirection.TopDown;
            this.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void AddHeaderRow(Dictionary<string, int> columnDefinitions)
        {
            this.headerRow = new CTTableRow(Color.Navy, Color.White, 40);
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

        private void AddDataRows(
            Dictionary<string, int> columnDefinitions, 
            List<string[]> data)
        {

            for (int i = 0; i < data.Count; i++)
            {
                var rowData = data[i]; // Lấy dữ liệu dòng
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
                    j++; // Tăng j để lấy đúng cột trong rowData
                }

                // Nút thao tác
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
                trashButton.Click += (s, e) => OnDeleteClicked?.Invoke(rowData[0]);

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

                row.AddCell(actionPanel, 80);

                dataRows.Add(row);
                this.Controls.Add(row);
            }

        }

    }


}
