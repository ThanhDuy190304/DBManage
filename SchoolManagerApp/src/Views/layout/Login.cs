using SchoolManagerApp.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagerApp.src.Views.layout
{
    public partial class Login : Form
    {
        internal AuthController _authController;    
        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.Load += Login_Load;

            // Cho phép đăng nhập bằng phím Enter
            this.userNameTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) LoginButton.PerformClick();
            };

            this.passwordTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) LoginButton.PerformClick();
            };

            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetRoundedRegion(30);
            userNameTextBox.Select();
            this.AcceptButton = LoginButton;
            this.CancelButton = ExitButton;
        }
        public void SetAuthController(AuthController authController)
        {
            _authController = authController;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.Handled = true;
            }
        }
        private void SetRoundedRegion(int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left
            path.AddArc(bounds.Width - radius, 0, radius, radius, 270, 90); // top-right
            path.AddArc(bounds.Width - radius, bounds.Height - radius, radius, radius, 0, 90); // bottom-right
            path.AddArc(0, bounds.Height - radius, radius, radius, 90, 90); // bottom-left
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Optional: Kéo form khi không có viền
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle fullRect = this.ClientRectangle;

            // Màu sắc chính
            Color lightBlue = Color.FromArgb(220, 173, 216, 230);
            Color transparentWhite = Color.FromArgb(0, 255, 255, 255);

            // Tạo gradient mượt mà toàn bộ form
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, fullRect.Height),
                lightBlue,
                transparentWhite))
            {
                // Điều chỉnh vị trí chuyển màu
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Colors = new Color[] {
            lightBlue,
            Color.FromArgb(180, 173, 216, 230), // Độ trong suốt giảm dần
            transparentWhite
        };
                colorBlend.Positions = new float[] { 0f, 0.25f, 1f };

                gradientBrush.InterpolationColors = colorBlend;
                graphics.FillRectangle(gradientBrush, fullRect);
            }

            // Thêm hiệu ứng ánh sáng (tùy chọn)
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(-100, -50, fullRect.Width + 200, 100);
                using (PathGradientBrush pgb = new PathGradientBrush(path))
                {
                    pgb.CenterColor = Color.FromArgb(80, 255, 255, 255);
                    pgb.SurroundColors = new Color[] { Color.FromArgb(0, 255, 255, 255) };
                    graphics.FillRectangle(pgb, fullRect);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.IconColor = Color.DarkRed;
            ExitButton.Refresh();

            // Delay ngắn để hiển thị hiệu ứng
            System.Threading.Thread.Sleep(100);

            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Hiệu ứng khi click
            LoginButton.BackColor = Color.Lavender;
            LoginButton.Refresh();

            string username = this.userNameTextBox.TextValue;
            string password = this.passwordTextBox.TextValue;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Giả lập quá trình đăng nhập (thay bằng code thực tế của bạn)
                bool loginSuccess = this._authController.Login(username, password);
                if (loginSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
