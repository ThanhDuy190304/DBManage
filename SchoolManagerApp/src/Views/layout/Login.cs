using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;  // Quan trọng nhất
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.Load += Login_Load;

            // Cho phép đăng nhập bằng phím Enter
            this.userNameTextBox.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter) LoginButton.PerformClick();
            };

            this.passrordTextBox.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter) LoginButton.PerformClick();
            };
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetRoundedRegion(30);
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
            string password = this.passrordTextBox.TextValue; 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Giả lập quá trình đăng nhập (thay bằng code thực tế của bạn)
                bool loginSuccess = AuthenticateUser(username, password);

                if (loginSuccess)
                {
                    // Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở form chính
                    var mainForm = new Main();
                    mainForm.Show();

                    // Đóng form đăng nhập
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        // Hàm giả lập kiểm tra đăng nhập (thay bằng code thực tế của bạn)
        private bool AuthenticateUser(string username, string password)
        {
            // Ở đây chỉ là ví dụ, bạn cần thay bằng logic kiểm tra thực tế
            return username == "admin" && password == "1";
        }
    }
}
