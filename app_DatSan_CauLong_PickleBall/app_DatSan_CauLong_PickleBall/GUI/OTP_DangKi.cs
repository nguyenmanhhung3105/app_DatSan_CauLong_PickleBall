using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Guna.UI2.WinForms;
namespace GUI
{
    public partial class OTP_DangKi : UserControl
    {
        private FormRegister dangkyInstance;
        public OTP_DangKi(FormRegister dk)
        {
            InitializeComponent();
            this.dangkyInstance = dk;
            waitBeforeSendOTP();
            tb_OTP1.TextChanged += OTP_TextChanged;
            tb_OTP2.TextChanged += OTP_TextChanged;
            tb_OTP3.TextChanged += OTP_TextChanged;
            tb_OTP4.TextChanged += OTP_TextChanged;
            tb_OTP1.KeyDown += OTP_KeyDown;
            tb_OTP2.KeyDown += OTP_KeyDown;
            tb_OTP3.KeyDown += OTP_KeyDown;
            tb_OTP4.KeyDown += OTP_KeyDown;
        }
        private async void waitBeforeSendOTP()
        {
            startCountdown();
            await Task.Delay(1000);
            OTP_BLL.sendOTP(dangkyInstance.getThongTinDangKy().email, "Register");
        }
        private void InitTimer()
        {
            timer1.Tick += timer1_Tick;
        }
        private int cntDown = 300;
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
        private string GetOTPCode()
        {
            return tb_OTP1.Text + tb_OTP2.Text + tb_OTP3.Text + tb_OTP4.Text;
        }
        private bool isOTPValid(string code)
        {
            return code.All(char.IsDigit);
        }
        private void btn_XacnhanOTP_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string otpCode = GetOTPCode();
            string s = dangkyInstance.getThongTinDangKy().email;
            if (!isOTPValid(otpCode))
            {
                lb_Error.Text = "Mã otp chỉ được chứa số, vui lòng kiểm tra OTP đã nhận quan email";
                ClearThongBao();
                return;
            }
            if (OTP_BLL.checkOTP(s, otpCode))
            {
                btn_XacnhanOTP.Enabled = false;
                KhachHangBLL.AddKhachHang(dangkyInstance.getThongTinDangKy());
               
                ClearThongBao() ;
                MessageBox.Show($"Chào mừng {dangkyInstance.getThongTinDangKy().tenKhachHang}! Chúc quý khách có những trải nghiệm tuyệt vời, 8386 Mãi đỉnh, mãi đỉnh!", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dangkyInstance.Close();
            }
            else
            {
                lb_Error.Text = "Mã OTP nhập vào không hợp lệ, vui lòng kiểm tra OTP đã nhận qua email.";
                ClearThongBao();
            }
        }
        private async void WaitBeforeChangeForm(int delayTime)
        {
            await Task.Delay(delayTime);
            dangkyInstance.del_UControls();
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_Error.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            dangkyInstance.del_UControls();
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

        private void btn_OTPAgain_Click(object sender, EventArgs e)
        {
            waitBeforeSendOTP();
            startCountdown();
        }

        
    }
}
