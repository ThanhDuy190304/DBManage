using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;
using System.Net.NetworkInformation;
using FontAwesome.Sharp;

namespace SchoolManagerApp.Controls
{
    public class CTButton : IconButton 
    { 
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Gainsboro;

        private Color originalBackColor;
        private Color hoverBackColor = Color.LightGray;

        private Color originalTextColor;
        private Color hoverTextColor = Color.Blue;

        private Color originalIconColor;
        private Color hoverIconColor = Color.Blue;


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
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set {
                this.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { 
                this.ForeColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color HoverBackColor {
            get { return this.hoverBackColor; }
            set { 
                this.hoverBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color HoverTextColor
        {
            get { return this.hoverTextColor; }
            set
            {
                this.hoverTextColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Style")]
        public Color HoverIconColor
        {
            get { return this.hoverIconColor; }
            set
            {
                this.hoverIconColor = value;
                this.Invalidate();
            }
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            originalBackColor = this.BackColor;
            originalTextColor = this.ForeColor;
            originalIconColor = this.IconColor;
        }
        public CTButton()
        {
            this.IconChar = IconChar.User;
            this.IconColor = Color.DarkSlateBlue;
            this.IconSize = 24;
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleRight;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Resize += new EventHandler(ButtonResize);
            this.Cursor = Cursors.Hand;

            this.MouseEnter += (s, e) =>
            {
                this.BackColor = this.hoverBackColor;
                this.TextColor = this.hoverTextColor;
                this.IconColor = this.hoverIconColor;
            };

            this.MouseLeave += (s, e) =>
            {
                this.BackColor = this.originalBackColor;
                this.TextColor = this.originalTextColor;
                this.IconColor = this.originalIconColor;
            };
        }
        private void ButtonResize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // top-left corner
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Top-right corner
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left corner
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            if (borderSize > 0)
            {
                smoothSize = borderSize;
            }

            if (this.borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetRoundedRectanglePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    if(borderSize > 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }


            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }
}
