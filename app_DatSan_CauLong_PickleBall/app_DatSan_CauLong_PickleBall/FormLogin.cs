using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_DatSan_CauLong_PickleBall
{
    

    public partial class FormLogin: Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            //background
            this.BackgroundImage = Image.FromFile("./img/bg.jpg"); // Đặt ảnh nền
            this.BackgroundImageLayout = ImageLayout.Stretch; // Căn chỉnh ảnh nền

            //màu chữ
            lb_DangNhap.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_TaiKhoan.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_MatKhau.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_DangKy.ForeColor = ColorTranslator.FromHtml("#016d3b");
            bt_DangNhap.ForeColor = Color.White;
            bt_DangNhap.BackColor = ColorTranslator.FromHtml("#016d3b");


            //bo góc 
            pn_TaiKhoan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_TaiKhoan.Width, pn_TaiKhoan.Height, 30, 30));
            pn_MatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_MatKhau.Width, pn_MatKhau.Height, 30, 30));
            bt_DangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bt_DangNhap.Width, bt_DangNhap.Height, 20, 20));
            pn_KhungDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_KhungDangNhap.Width, pn_KhungDangNhap.Height, 20, 20));

            //placehoder
            tb_TaiKhoan.GotFocus += new EventHandler(RemoveText);
            tb_TaiKhoan.LostFocus += new EventHandler(AddText);
            tb_MatKhau.GotFocus += new EventHandler(RemoveText);
            tb_MatKhau.LostFocus += new EventHandler(AddText);

            //làm mờ khung panel để hiển thị background
            pn_KhungDangNhap.Paint += new PaintEventHandler(pn_KhungDangNhap_Paint);
        }

        private void pn_KhungDangNhap_Paint(object sender, PaintEventArgs e)
        {
            // Màu xanh lá nhạt với độ trong suốt (Alpha = 160)
            Color panelColor = Color.FromArgb(160, 255, 255, 255);
            using (SolidBrush brush = new SolidBrush(panelColor))
            {
                e.Graphics.FillRectangle(brush, pn_KhungDangNhap.ClientRectangle);
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb == tb_TaiKhoan && tb.Text == "Nhập số điện thoại hoặc email")
                {
                    tb.Text = "";
                }
                else if (tb == tb_MatKhau && tb.Text == "Vui lòng nhập mật khẩu")
                {
                    tb.Text = "";
                    tb.UseSystemPasswordChar = true; // Enable password masking
                }
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb == tb_TaiKhoan && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = "Nhập số điện thoại hoặc email";
                }
                else if (tb == tb_MatKhau && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.UseSystemPasswordChar = false; // Disable password masking
                    tb.Text = "Vui lòng nhập mật khẩu";
                }
            }
        }


        private void pt_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_DangKy_Click(object sender, EventArgs e)
        {

        }

        private void pt_MiniMaxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pt_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
