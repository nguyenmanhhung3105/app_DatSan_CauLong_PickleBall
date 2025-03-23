using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class OTPAccess
    {
        public static void AddOTP(OTP otp)
        {
            string query = "DELETE FROM OTP WHERE email = @email";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@email", otp.email }
            };
            try
            {
                Connection.actionQuery(query, parameters);
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi xóa OTP {ex}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception($"Lỗi xóa OTP {ex}");
            }
            query = @"INSERT INTO OTP (email, otpCode, expiredAt) 
              VALUES (@Email, @OtpCode, DATEADD(MINUTE, 5, GETDATE()))";
            parameters = new Dictionary<string, object>
            {
                {"@email", otp.email },
                {"@otpCode", otp.otpCode }
            };
            try
            {
                Connection.actionQuery(query, parameters);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi thêm OTP {e}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception($"Lỗi thêm OTP {e}");
            }
        }
        public static bool checkOTP(string email, string otpInput) { 
        
            string query = @"SELECT * FROM OTP
                    WHERE email = @Email AND otpCode = @OtpCode 
                     AND expiredAt > GETDATE()";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@Email", email },
        { "@OtpCode", otpInput }
    };
           
            return Connection.selectQuery(query, parameters).Rows.Count > 0;
        }
    }
}
