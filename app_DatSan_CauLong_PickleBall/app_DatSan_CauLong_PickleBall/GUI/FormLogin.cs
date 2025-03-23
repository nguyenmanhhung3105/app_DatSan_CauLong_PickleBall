using System;

using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Services;

using System.Threading;

using DTO;
using BLL;
using Google.Apis.Util.Store;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace GUI
{
    

    public partial class FormLogin: Form
    {
        
        

        public FormLogin()
        {
            InitializeComponent();
            tb_SoDTorEmail.Text = Properties.Settings.Default.soDienThoai_Email;
            tb_SoDTorEmail.Focus();
        }

        

        

        


        private void pt_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void lb_DangKy_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.ShowDialog();
            this.Show();
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

        

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            this.Hide();
            formForgotPassword.ShowDialog();
            this.Show();
        }

        private void SaveLoginInfo(string sdt_email)
        {
            Properties.Settings.Default.soDienThoai_Email = sdt_email;
            Properties.Settings.Default.Save();
        }
        private async void btn_LoginGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                var browserProcessesBefore = Process.GetProcessesByName("chrome");
                string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GoogleToken");
                
                if (Directory.Exists(tokenPath))
                {
                    Directory.Delete(tokenPath, true);
                }
                string clientId = "40447139026-3a7695r5bu7o9irrtvr4gudoc7fgebq6.apps.googleusercontent.com";
                string clientSecret = "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";
                string[] scopes = { "https://www.googleapis.com/auth/userinfo.profile", "https://www.googleapis.com/auth/userinfo.email" };
                UserCredential credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets { ClientId = clientId, ClientSecret = clientSecret },
                    scopes,
                    "user",
                    CancellationToken.None,
                    new NullDataStore());
                
                var service = new Oauth2Service(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "QuanLySan_Pickleball_CauLong"
                });
                Userinfo userInfo = await service.Userinfo.Get().ExecuteAsync();
                if (!KhachHangBLL.checkEmailExist(userInfo.Email)) { 
                    MessageBox.Show($"Email {userInfo.Email} chưa được đăng kí trong hệ thống!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                MessageBox.Show($"Xin chào trở lại, {userInfo.Name} , Mình hẹn nhau pickleball nhé!", "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang kh = KhachHangBLL.selectOneKhachHang(userInfo.Email);
                Form_Home mainForm = new Form_Home(kh);
               
                mainForm.ShowDialog(); // Đợi form chính đóng trước khi tiếp tục
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message);
            }
        }

        private bool isPasswordVisible = false;
        private void btn_ShowPassWord_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                tb_MK.PasswordChar = (char)0;
                btn_ShowPassWord.BackgroundImage = Image.FromFile("./img/eye_open.png");
                btn_ShowPassWord.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                tb_MK.PasswordChar = '*';
                btn_ShowPassWord.BackgroundImage = Image.FromFile("./img/eye_close.png");
                btn_ShowPassWord.BackgroundImageLayout = ImageLayout.Zoom;
            }
            isPasswordVisible = !isPasswordVisible;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string soDT_Email = tb_SoDTorEmail.Text;
            string mk = tb_MK.Text;
            if (soDT_Email.Trim() == "" || mk.Trim() == "") { 
                lbl_Loi.Text = "Vui lòng điền đầy đủ thông tin đăng nhập";
                ClearThongBao();
                return;
            }
            else if(soDT_Email.Contains('\'') || mk.Contains('\''))
            {
                lbl_Loi.Text = "Thông tin đăng nhập chứa ký tự không hợp lệ";
                ClearThongBao();
                return;
            }

            if (KhachHangBLL.checkLoginValid(soDT_Email, mk))
            {
                SaveLoginInfo(soDT_Email);
                MessageBox.Show("Xin chào! Mình hẹn nhau picklebal nhé!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang kh = KhachHangBLL.selectOneKhachHang(soDT_Email);
                Form_Home mainForm = new Form_Home(kh);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                lbl_Loi.Text = "Thông tin đăng nhập không hợp lệ";
                ClearThongBao();
            }
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lbl_Loi.Text = "";
        }

        private void lb_Dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.ShowDialog();
            this.Show();
        }
    }
}
