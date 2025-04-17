using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class UC_CapNhatTaiKhoan : UserControl
    {
        KhachHang khachHang;
        public UC_CapNhatTaiKhoan(KhachHang kh)
        {
            InitializeComponent();
            khachHang = kh;
            lbl_GioiTinh.Parent = guna2PictureBox2;
            lbl_GioiTinh.Parent = guna2PictureBox2;
            lbl_DiaChi.Parent = guna2PictureBox2;
        }

        private void btn_EditHT_Click(object sender, EventArgs e)
        {
            tb_HoTen.ReadOnly = false;
        }

        private void btn_EditSDT_Click(object sender, EventArgs e)
        {
            tb_SDT.ReadOnly = false;
        }

        private void btn_EditEmail_Click(object sender, EventArgs e)
        {
            tb_Email.ReadOnly = false;
        }

        private void btn_EditDiaChi_Click(object sender, EventArgs e)
        {
            tb_DiaChi.ReadOnly = false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = tb_HoTen.Text.Trim();
            string soDT = tb_SDT.Text.Trim();
            string email = tb_Email.Text.Trim();
            string diaChi = tb_DiaChi.Text.Trim();
            DateTime dt = pdt_NgaySinh.Value;
            string gioiTinh = "";
            if (rb_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rb_Nu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else if (rb_Khac.Checked) {
                gioiTinh = "Khác";
            }
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(soDT) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gioiTinh)) {
                lb_ThongBao.Visible = true;
                lb_ThongBao.Text = "Bạn ơi từ từ. Hãy điền đầy đủ thông tin trước nhé!";
                ClearThongBao();
                return;
            }
            if (!Regex.IsMatch(soDT, @"^0\d{9}$"))
            {
                lb_ThongBao.Visible = true;
                lb_ThongBao.Text = "Số điện thoại không hợp lệ. Vui lòng nhập đúng 10 chữ số bắt đầu bằng 0.";
                ClearThongBao();
                return;
            }
            if(!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lb_ThongBao.Visible = true;
                lb_ThongBao.Text = "Email không hợp lệ. Vui lòng nhập đúng định dạng.";
                ClearThongBao();
                return;
            }
            KhachHangBLL.UpdateKhachHang(khachHang.maKhachHang, hoTen, gioiTinh, dt, diaChi);
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_ThongBao.Text = "";
            lb_ThongBao.Visible = false;
        }
    }
}
