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
            string checkQuery = "SELECT COUNT(*) FROM OTP WHERE email = @Email";
            Dictionary<string, object> checkParameters = new Dictionary<string, object>
    {
        {"@Email", otp.email }
    };

            int count = Connection.selectQuery(checkQuery, checkParameters).Rows.Count;

            // Nếu đã tồn tại thì xóa
            if (count > 0)
            {
                string deleteQuery = "DELETE FROM OTP WHERE email = @Email";
                try
                {
                    Connection.actionQuery(deleteQuery, checkParameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa OTP {ex}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception($"Lỗi xóa OTP {ex}");
                }
            }

            // Thêm OTP mới
            string insertQuery = @"INSERT INTO OTP (email, otpCode, expireAt) 
                           VALUES (@Email, @OtpCode, DATEADD(MINUTE, 5, GETDATE()))";
            Dictionary<string, object> insertParameters = new Dictionary<string, object>
    {
        {"@Email", otp.email },
        {"@OtpCode", otp.otpCode }
    };

            try
            {
                Connection.actionQuery(insertQuery, insertParameters);
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
                     AND expireAt > GETDATE()";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@Email", email },
        { "@OtpCode", otpInput }
    };
           
            return Connection.selectQuery(query, parameters).Rows.Count > 0;
        }
    }
}
