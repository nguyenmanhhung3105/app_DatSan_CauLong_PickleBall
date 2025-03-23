using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class OTP_BLL
    {
        
            public static void sendOTP(string email, string sendWhat)
        {
            string otpCode = new Random().Next((int)Math.Pow(10, 3), (int)Math.Pow(10, 4)).ToString();
            OTP otp = new OTP(email, otpCode);
            OTPAccess.AddOTP(otp);
            var fromAddress = new MailAddress("dang0582366729@gmail.com");
            var toAddress = new MailAddress(otp.email);
            const string fromPass = "qhta ligu kbnn gjqj";
            string mailSubject = "";
            if (sendWhat == "Register")
            {
                mailSubject = "Đăng ký tài khoản ứng dụng đặt sân pickleball, cầu lông - Mã xác thực OTP"; //Tiêu đề mail gửi mã tạo tài khoản

            }
            if (sendWhat == "ChangePassword")
            {
                mailSubject = "Đổi mật khẩu tài khoản ứng dụng đặt sân pickleball, cầu lông - Mã xác thực OTP"; //Tiêu đề mail gửi mã đổi mật khẩu
            }
            string mailBody = $"Mã xác thực OTP của bạn là:\n{otp.otpCode}\nĐây là mail được gửi tự động, vui lòng không trả lời mail này. Chúc bạn có một ngày tốt lành. Trân trọng.";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                Timeout = 200000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = mailSubject,
                Body = mailBody
            })
            {
                smtp.Send(message);
            }
        }
        public static bool checkOTP(string email, string otpInput)
        {
            return OTPAccess.checkOTP(email, otpInput);
        }
    }
}
