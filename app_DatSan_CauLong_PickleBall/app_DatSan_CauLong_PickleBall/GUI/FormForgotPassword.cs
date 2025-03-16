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
    public partial class FormForgotPassword: Form
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

        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            //background
            this.BackgroundImage = Image.FromFile("./img/bg.jpg"); // Đặt ảnh nền
            this.BackgroundImageLayout = ImageLayout.Stretch; // Căn chỉnh ảnh nền

            //màu chữ
            lb_QuenMatKhau.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_TaiKhoan.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_MatKhau.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_GuiLaiMa.ForeColor = ColorTranslator.FromHtml("#016d3b");
            bt_LayMatKhau.ForeColor = Color.White;
            bt_LayMatKhau.BackColor = ColorTranslator.FromHtml("#016d3b");
            bt_XacNhan.ForeColor = Color.White;
            bt_XacNhan.BackColor = ColorTranslator.FromHtml("#016d3b");


            //bo góc 
            pn_TaiKhoan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_TaiKhoan.Width, pn_TaiKhoan.Height, 30, 30));
            pn_MaCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_MaCode.Width, pn_MaCode.Height, 30, 30));
            bt_LayMatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bt_LayMatKhau.Width, bt_LayMatKhau.Height, 20, 20));
            bt_XacNhan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bt_XacNhan.Width, bt_XacNhan.Height, 20, 20));
            pn_KhungDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_KhungDangNhap.Width, pn_KhungDangNhap.Height, 20, 20));

            //placehoder
            tb_TaiKhoan.GotFocus += new EventHandler(RemoveText);
            tb_TaiKhoan.LostFocus += new EventHandler(AddText);
            tb_MaCode.GotFocus += new EventHandler(RemoveText);
            tb_MaCode.LostFocus += new EventHandler(AddText);

            //làm mờ khung panel để hiển thị background
            pn_KhungDangNhap.Paint += new PaintEventHandler(pn_KhungDangNhap_Paint);

            //lỗi đăng nhập
            lb_ThongTin.Visible = false;
            lb_CauHoi.Visible = false;
            lb_GuiLaiMa.Visible = false;
            pn_MaCode.Visible = false;
            lb_MaCode.Visible = false;
            bt_XacNhan.Visible = false;
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
                else if (tb == tb_MaCode && tb.Text == "Vui lòng nhập mã code")
                {
                    tb.Text = "";
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
                else if (tb == tb_MaCode && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = "Vui lòng nhập mã code";
                }
            }
        }

        private void bt_LayMatKhau_Click(object sender, EventArgs e)
        {
            //ẩn
            lb_TaiKhoan.Visible = false;
            pn_TaiKhoan.Visible = false;
            tb_TaiKhoan.Visible = false;
            bt_LayMatKhau.Visible = false;

            //hiện
            lb_ThongTin.Visible = true;
            lb_CauHoi.Visible = true;
            lb_GuiLaiMa.Visible = true;
            lb_MaCode.Visible = true;
            pn_MaCode.Visible = true;
            tb_MaCode.Visible = true;
            bt_XacNhan.Visible = true;
        }

        private void pt_Hide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pt_MiniMaxmize_Click_1(object sender, EventArgs e)
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

        private void pt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_MaCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
