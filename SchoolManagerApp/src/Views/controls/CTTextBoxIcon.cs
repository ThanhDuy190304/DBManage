using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.controls
{
    public partial class CTTextBoxIcon : Control
    {
        private int borderSize = 0;
        private int borderRadius = 0;

        private Color borderColor = Color.Gainsboro;
        private Color originBorderColor = Color.Gainsboro;
        private Color focusBorderColor = Color.Blue;

        private IconPictureBox iconPictureBox;
        private TextBox textBox;

        [Category("Custom Style")]
        public int BorderSize
        {
            get { return this.borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public int BorderRadius
        {
            get { return this.borderRadius; }
            set
            {
                if (value <= this.Height)
                {
                    borderRadius = value;
                }
                else borderRadius = this.Height;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.originBorderColor = value;
                this.borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color FocusBorderColor
        {
            get { return this.focusBorderColor; }
            set
            {
                this.focusBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color TextForeColor
        {
            get { return this.textBox.ForeColor; }
            set
            {
                this.textBox.ForeColor = value;
            }
        }

        [Category("Custom Style")]
        public Color TextBackColor
        {
            get { return this.textBox.BackColor; }
            set
            {
                this.textBox.BackColor = value;
            }
        }

        [Category("Custom Style")]
        public string TextValue
        {
            get { return this.textBox.Text; }
            set { this.textBox.Text = value; }
        }

        [Category("Custom Style")]
        public bool UseSystemPasswordChar
        {
            get { return textBox.UseSystemPasswordChar; }
            set { textBox.UseSystemPasswordChar = value; }
        }

        [Category("Custom Style")]
        public IconChar IconChar
        {
            get { return this.iconPictureBox.IconChar; }
            set
            {
                this.iconPictureBox.IconChar = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public int IconSize
        {
            get { return this.iconPictureBox.IconSize; }
            set
            {
                this.iconPictureBox.IconSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color IconColor
        {
            get { return this.iconPictureBox.IconColor; }
            set
            {
                this.iconPictureBox.IconColor = value;
                this.Invalidate();
            }
        }



        public CTTextBoxIcon()
        {
            // Chỉ khởi tạo khi KHÔNG ở chế độ Designer
            if (!DesignMode)
            {
                InitializeComponents();
            }
        }

        private void InitializeComponents()
        {
            this.Size = new Size(200, 40);

            // 1. Tạo panel với cấu hình an toàn cho Designer
            FlowLayoutPanel panel = new FlowLayoutPanel();

            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.AutoSize = true;
            panel.WrapContents = false;
            panel.Padding = new Padding(5);

            // Giải pháp thay thế Color.Transparent
            panel.BackColor = Color.FromArgb(0, 255, 255, 255); // Màu trắng trong suốt

            // 2. Cấu hình TextBox
            this.textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textBox.ForeColor = Color.Black;
            textBox.BackColor = Color.White; // Thay Gray thành White để dễ nhìn
            textBox.Size = new Size(200, 30);
            // 3. Cấu hình Icon
            this.iconPictureBox = new IconPictureBox();
            iconPictureBox.IconChar = IconChar.User;
            iconPictureBox.IconSize = 20;
            iconPictureBox.IconColor = Color.LightGray;
            iconPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            // 4. Thêm controls vào panel
            panel.Controls.Add(iconPictureBox);
            panel.Controls.Add(textBox);

            // 5. Thêm panel vào control cha
            this.Controls.Add(panel);

            // 6. Sự kiện
            textBox.Enter += (s, e) => {
                borderColor = focusBorderColor;
                Invalidate();
            };

            textBox.Leave += (s, e) => {
                borderColor = originBorderColor;
                Invalidate();
            };
        }
    }
}
