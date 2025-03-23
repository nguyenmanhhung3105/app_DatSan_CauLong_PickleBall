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
using BLL;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class FormForgotPassword : Form
    {

        public FormForgotPassword()
        {
            InitializeComponent();
            tb_OTP1.TextChanged += OTP_TextChanged;
            tb_OTP2.TextChanged += OTP_TextChanged;
            tb_OTP3.TextChanged += OTP_TextChanged;
            tb_OTP4.TextChanged += OTP_TextChanged;
            tb_OTP1.KeyDown += OTP_KeyDown;
            tb_OTP2.KeyDown += OTP_KeyDown;
            tb_OTP3.KeyDown += OTP_KeyDown;
            tb_OTP4.KeyDown += OTP_KeyDown;
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {

        }


        private bool isPasswordVisible1 = false, isPasswordVisible2 = false;
        private void btn_ShowPass1_Click(object sender, EventArgs e)
        {

            if (!isPasswordVisible1)
            {
                tb_MKNew.PasswordChar = (char)0;
                btn_ShowPass1.BackgroundImage = Image.FromFile("./img/eye_open.png");
                btn_ShowPass1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                tb_MKNew.PasswordChar = '*';
                btn_ShowPass1.BackgroundImage = Image.FromFile("./img/eye_close.png");
                btn_ShowPass1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            isPasswordVisible1 = !isPasswordVisible1;
        }

        private void btn_ShowPass2_Click(object sender, EventArgs e)
        {

            if (!isPasswordVisible2)
            {
                tb_XacnhanMK.PasswordChar = (char)0;
                btn_ShowPass2.BackgroundImage = Image.FromFile("./img/eye_open.png");
                btn_ShowPass2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                tb_XacnhanMK.PasswordChar = '*';
                btn_ShowPass2.BackgroundImage = Image.FromFile("./img/eye_close.png");
                btn_ShowPass2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            isPasswordVisible2 = !isPasswordVisible2;
        }


        private void btn_Otp_Click(object sender, EventArgs e)
        {
            if (tb_Email.Text.Trim() == "" || tb_MKNew.Text.Trim() == "")
            {
                lb_Error.Text = "Bạn cần nhập email và mật khẩu mới!";
                ClearThongBao();
                return;
            }
            if ((tb_Email.Text + tb_MKNew.Text).Contains('\''))
            {
                lb_Error.Text = "Thông tin nhập vào chứa ký tự không hợp lệ: \'";
                ClearThongBao();
                return;
            }
            if (!KhachHangBLL.checkEmailExist(tb_Email.Text))
            {
                lb_Error.Text = "Email không tồn tại";
                ClearThongBao();
                return;
            }
            if(tb_MKNew.Text != tb_XacnhanMK.Text)
            {
                lb_Error.Text = "Mật khẩu xác nhận không chính xác.";
                ClearThongBao();
                return;
            }
            tb_OTP1.Enabled = true;
            tb_OTP2.Enabled = true;
            tb_OTP3.Enabled = true;
            tb_OTP4.Enabled = true;
            btn_OTPAgain.Enabled = true;
            lb_Error.Text = "Đã gửi OTP qua email, vui lòng kiểm tra.";
            ClearThongBao();
            tb_MKNew.Enabled = false;
            tb_XacnhanMK.Enabled = false;
            waitBeforeSentOTP();
        }

        private void tb_MKNew_TextChanged(object sender, EventArgs e)
        {
            if (tb_MKNew.Text.Trim() != "")
            {

                tb_XacnhanMK.Enabled = true;
                
            }
            else
            {
                tb_XacnhanMK.Text = "";
                tb_XacnhanMK.Enabled = false;
                
            }
        }

        private async void waitBeforeSentOTP()
        {
            startCountdown();

            await Task.Delay(2000);
            OTP_BLL.sendOTP(tb_Email.Text, "ChangePassword");
        }
        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            if (tb_Email.Text.Trim() != "")
            {
                tb_MKNew.Enabled = true;
                
            }
            else
            {
                tb_MKNew.Enabled = false;
               
            }
        }


        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_Error.Text = "";
        }
        private int cntDown = 300;

        private void InitTimer()
        {

            timer1.Tick += timer1_Tick;
        }
        private void startCountdown()
        {
            lblCountDown.Visible = true;
            cntDown = 300; // Reset lại 5 phút
            lblCountDown.Text = "05:00"; // Hiển thị ban đầu
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cntDown--;
            int minutes = cntDown / 60;
            int seconds = cntDown % 60;
            lblCountDown.Text = $"{minutes:D2}:{seconds:D2}";
            if (cntDown <= 0)
            {
                timer1.Stop();
                lblCountDown.Visible = false;
            }
        }

        private void btn_OTPAgain_Click(object sender, EventArgs e)
        {
            btn_OTPAgain.Enabled = false;
            waitBeforeSentOTP();
            startCountdown();
        }
        private string GetOTPCode()
        {
            return tb_OTP1.Text + tb_OTP2.Text + tb_OTP3.Text + tb_OTP4.Text;
        }
        private bool isOTPValid(string code)
        {
            return code.All(char.IsDigit);
        }
        private async void WaitBeforeChangeForm(int delayTime)
        {
            await Task.Delay(delayTime);

            this.Close();
        }
        private void btn_XacnhanOTP_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string otpCode = GetOTPCode();
           
            if (!isOTPValid(otpCode))
            {
                lb_Error.Text = "Mã otp chỉ được chứa số, vui lòng kiểm tra OTP đã nhận quan email";
                ClearThongBao();
                return;
            }
            if (OTP_BLL.checkOTP(tb_Email.Text, otpCode))
            {
                
                if (KhachHangBLL.DoiMatKhau(tb_Email.Text, tb_MKNew.Text))
                {
                    
                    lb_Error.Text = "Đổi mật khẩu thành công. Chúc bạn tiếp tục đặt sân vui vẻ :)))";
                    WaitBeforeChangeForm(5000);
                }
                else
                {
                    lb_Error.Text = "Huhu đã có lỗi trong quá trình đổi mật khẩu, vui lòng thử lại.";
                    ClearThongBao();
                    return;
                }
            }
            else
            {
                lbl_Loi.Text = "Mã OTP nhập vào không hợp lệ, vui lòn kiểm tra OTP đã nhận qua email.";
                ClearThongBao();
                return;
            }
        }

        private void HandleOTPTimedOut()
        {
            MessageBox.Show("OTP đã hết hạn! Vui lòng yêu cầu mã OTP mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btn_OTPAgain.Enabled = true; // Cho phép gửi lại OTP
            startCountdown();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void OTP_TextChanged(object sender, EventArgs e)
        {

            if (sender is Guna2TextBox cBox && !string.IsNullOrEmpty(cBox.Text) && cBox.Text.Length == 1)
            {
                Control parent = cBox.Parent;
                if (parent != null)
                {
                    var textBoxes = parent.Controls.OfType<Guna2TextBox>().OrderBy(t => t.TabIndex).ToList();
                    int index = textBoxes.IndexOf(cBox);
                    if (index >= 0 && index < textBoxes.Count - 1)
                    {
                        textBoxes[index + 1].Focus();
                    }
                }
            }
            CheckOTPCompletion();
        }

        private void OTP_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is Guna2TextBox cBox && e.KeyCode == Keys.Back)
            {
                var textBoxes = pn_OTP.Controls.OfType<Guna2TextBox>()
                                              .OrderBy(t => t.TabIndex)
                                              .ToList();
                int index = textBoxes.IndexOf(cBox);

                if (index > 0)
                {
                    if (string.IsNullOrEmpty(cBox.Text))
                    {
              
                        textBoxes[index - 1].Clear();
                        textBoxes[index - 1].Focus();
                    }
                    else
                    {
                     
                        cBox.Clear();
                    }
                }
                else
                {
             
                    cBox.Clear();
                }

                CheckOTPCompletion();

               
                e.SuppressKeyPress = true;
            }
        }
        
        private void CheckOTPCompletion()
        {
            var textBoxes = pn_OTP.Controls.OfType<Guna2TextBox>().Where(tb => tb.Name.StartsWith("tb_OTP")).ToList();

            // Kiểm tra tất cả TextBox đã có 1 ký tự chưa
            bool isCompleted = textBoxes.All(tb => tb.Text.Length == 1);

            // Bật/tắt button Xác nhận
            btn_XacnhanOTP.Enabled = isCompleted;
        }
    }
}
