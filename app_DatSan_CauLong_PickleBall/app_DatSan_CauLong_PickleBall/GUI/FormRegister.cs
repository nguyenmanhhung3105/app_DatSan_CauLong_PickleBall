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
    public partial class FormRegister: Form
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

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            //background
            this.BackgroundImage = Image.FromFile("./img/bg.jpg"); // Đặt ảnh nền
            this.BackgroundImageLayout = ImageLayout.Stretch; // Căn chỉnh ảnh nền

            //màu chữ
            lb_DangKy.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_TaiKhoan.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_MatKhau.ForeColor = ColorTranslator.FromHtml("#016d3b");
            lb_DangNhap.ForeColor = ColorTranslator.FromHtml("#016d3b");
            bt_DangKy.ForeColor = Color.White;
            bt_DangKy.BackColor = ColorTranslator.FromHtml("#016d3b");


            //bo góc 
            pn_TaiKhoan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_TaiKhoan.Width, pn_TaiKhoan.Height, 30, 30));
            pn_Ten.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_Ten.Width, pn_Ten.Height, 30, 30));
            pn_MatKhau1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_MatKhau1.Width, pn_MatKhau1.Height, 30, 30));
            pn_MatKhau2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_MatKhau2.Width, pn_MatKhau2.Height, 30, 30));
            bt_DangKy.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bt_DangKy.Width, bt_DangKy.Height, 20, 20));
            pn_KhungDangKy.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_KhungDangKy.Width, pn_KhungDangKy.Height, 20, 20));

            //placehoder
            tb_TaiKhoan.GotFocus += new EventHandler(RemoveText);
            tb_TaiKhoan.LostFocus += new EventHandler(AddText);
            tb_Ten.GotFocus += new EventHandler(RemoveText);
            tb_Ten.LostFocus += new EventHandler(AddText);
            tb_MatKhau1.GotFocus += new EventHandler(RemoveText);
            tb_MatKhau1.LostFocus += new EventHandler(AddText);
            tb_MatKhau2.GotFocus += new EventHandler(RemoveText);
            tb_MatKhau2.LostFocus += new EventHandler(AddText);

            //làm mờ khung panel để hiển thị background
            pn_KhungDangKy.Paint += new PaintEventHandler(pn_KhungDangNhap_Paint);
        }

        private void pn_KhungDangNhap_Paint(object sender, PaintEventArgs e)
        {
            // Màu xanh lá nhạt với độ trong suốt (Alpha = 160)
            Color panelColor = Color.FromArgb(160, 255, 255, 255);
            using (SolidBrush brush = new SolidBrush(panelColor))
            {
                e.Graphics.FillRectangle(brush, pn_KhungDangKy.ClientRectangle);
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
                else if (tb == tb_Ten && tb.Text == "Vui lòng nhập họ và tên")
                {
                    tb.Text = "";
                }
                else if (tb == tb_MatKhau1 && tb.Text == "Vui lòng nhập mật khẩu")
                {
                    tb.Text = "";
                    tb.UseSystemPasswordChar = true; 
                }
                else if (tb == tb_MatKhau2 && tb.Text == "Vui lòng nhập lại mật khẩu")
                {
                    tb.Text = "";
                    tb.UseSystemPasswordChar = true;
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
                else if (tb == tb_Ten && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = "Vui lòng nhập họ và tên";
                }
                else if (tb == tb_MatKhau1 && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.UseSystemPasswordChar = false; 
                    tb.Text = "Vui lòng nhập mật khẩu";
                }
                else if (tb == tb_MatKhau2 && string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.UseSystemPasswordChar = false; 
                    tb.Text = "Vui lòng nhập lại mật khẩu";
                }
            }
        }

        private void pt_MiniMaxmize_Click(object sender, EventArgs e)
        {
            
        }

        private void pt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pt_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
