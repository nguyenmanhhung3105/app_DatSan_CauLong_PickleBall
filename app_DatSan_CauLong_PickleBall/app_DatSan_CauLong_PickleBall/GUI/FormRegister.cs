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
using DTO;
using BLL;
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class FormRegister: Form
    {
        

        public FormRegister()
        {
            InitializeComponent();
            lb_ThongBao.Parent = guna2PictureBox1;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
           
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
        public KhachHang getThongTinDangKy()
        {
            return new KhachHang(tb_Hoten.Text, tb_SDT.Text,tb_Email.Text , tb_MK.Text);
        }

        private void lb_Dangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin dangnhap = new FormLogin();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string tenKH = tb_Hoten.Text;
            string soDT = tb_SDT.Text;
            string email = tb_Email.Text;
            string matKhau = tb_MK.Text;
            string xacNhanMK = tb_XacnhanMK.Text;
            string allInput = tenKH+soDT+email+matKhau+xacNhanMK;
            if(string.IsNullOrEmpty(tenKH) ||
                string.IsNullOrEmpty(soDT) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(matKhau)||
                string.IsNullOrEmpty(xacNhanMK))
            {
                lb_ThongBao.Text = "Bạn ơi từ từ, điền đầy đủ thông tin rồi hãy đăng ký nha";
                ClearThongBao();
                return;
            }
            if (allInput.Contains("\'"))
            {
                lb_ThongBao.Text = "Thông tin nhập vào chứa kí tự không hợp lệ: \'";
            }
            if (!CheckEmailValid(email))
            {
                lb_ThongBao.Text = "Định dạng email có vẽ không đúng lắm. Gợi ý:'abc@gmail.com'";
                ClearThongBao();
                return;
            }
            if (KhachHangBLL.checkEmailExist(email)) {
                lb_ThongBao.Text = "Huhu! Email đã tồn tại, vui lòng chọn email khác";
                ClearThongBao();
                return;
            }
            if (KhachHangBLL.checkSoDienThoaiExist(soDT)) {
                lb_ThongBao.Text = "Huhu! Số điện thoại đã tồn tại, vui lòng chọn số điện thoại khác";
                ClearThongBao();
                return;
            }
            if (!matKhau.Equals(xacNhanMK))
            {
                lb_ThongBao.Text = "Mật khẩu xác nhận không trùng khớp";
                ClearThongBao();
                return;
            }
            if(!Regex.IsMatch(soDT, @"^0\d{9}$"))
            {
                lb_ThongBao.Text = "Số điện thoại không hợp lệ";
                ClearThongBao();
                return;
            }
            pn_OTPDK.Visible = true;
            pn_OTPDK.BringToFront();
            add_UControls(new OTP_DangKi(this));
            
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_ThongBao.Text = "";
        }
        private bool CheckEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private void add_UControls(UserControl userControl)
        {
            pn_OTPDK.Controls.Clear();
            pn_OTPDK.Controls.Add(userControl);
        }
        public void del_UControls()
        {
            pn_OTPDK.Controls.Clear();
            pn_OTPDK.Controls.Add(ptb_1);
            
        }
        private bool isPasswordVisible1 = false, isPasswordVisible2 = false;

        private void btn_Showpassword2_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible2)
            {
                tb_XacnhanMK.PasswordChar = (char)0;
                btn_Showpassword2.BackgroundImage = Image.FromFile("./img/eye_open.png");
                btn_Showpassword2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                tb_XacnhanMK.PasswordChar = '*';
                btn_Showpassword2.BackgroundImage = Image.FromFile("./img/eye_close.png");
                btn_Showpassword2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            isPasswordVisible2 = !isPasswordVisible2;
        }

        

        private void btn_ShowPassWord1_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible1)
            {
                tb_MK.PasswordChar = (char)0;
                btn_ShowPassWord1.BackgroundImage = Image.FromFile("./img/eye_open.png");
                btn_ShowPassWord1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                tb_XacnhanMK.PasswordChar = '*';
                btn_ShowPassWord1.BackgroundImage = Image.FromFile("./img/eye_close.png");
                btn_ShowPassWord1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            isPasswordVisible1 = !isPasswordVisible1;
        }
    }
}
