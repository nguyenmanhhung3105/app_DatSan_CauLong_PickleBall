using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BLL
{
    public class KhachHangBLL
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static DataTable SelectAllKhachHang()
        {
            return KhachHangAccess.selectAllKhachHang();
        }
        public static bool checkLoginValid(string soDienThoai_email, string matKhau)
        {
            return KhachHangAccess.checkLoginValid(soDienThoai_email, matKhau);

        }
        public static bool checkEmailExist(string email)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@email", email}
            };
            DataTable res = KhachHangAccess.selectOneKhachHang("email = @email", parameters);




            if (res != null && res.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool checkSoDienThoaiExist(string soDienThoai)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@soDienThoai", soDienThoai}
            };
            DataTable res = KhachHangAccess.selectOneKhachHang("soDienThoai = @soDienThoai", parameters);
            if (res != null && res.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static KhachHang selectOneKhachHang(string soDienThoai_Email) {
            KhachHang khachHang = null;
            string dieuKien = "email = @soDienThoai_email";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@soDienThoai_email", soDienThoai_Email}
            };
            
            DataTable dt = KhachHangAccess.selectOneKhachHang(dieuKien, parameters);
            if(dt!=null && dt.Rows.Count > 0)
            {
                khachHang = CreateKhachHangFromDataRow(dt.Rows[0]);
            }
            else
            {
                dieuKien = "soDienThoai = @soDienThoai_email";
                dt = KhachHangAccess.selectOneKhachHang(dieuKien, parameters);
                if (dt != null && dt.Rows.Count > 0)
                {
                    khachHang = CreateKhachHangFromDataRow(dt.Rows[0]);
                }
            }
            return khachHang;
        }
        private static KhachHang CreateKhachHangFromDataRow(DataRow row)
        {
            string maKhachHang = row["maKhachHang"].ToString();
            string tenKhachHang = row["tenKhachHang"].ToString();
            string soDienThoai = row["soDienThoai"].ToString();
            string email = row["email"].ToString();
            string matKhau = row["matKhau"].ToString();
            string gioiTinh = row["gioiTinh"].ToString();
            DateTime ngaySinh = (DateTime)row["ngaySinh"];
            string diaChi = row["diaChi"].ToString();
            int soLanDatSan = Convert.ToInt32(row["soLanDatSan"]);

            return new KhachHang(maKhachHang, tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan);
        }
        public static void AddKhachHang(KhachHang khachHang)
        {
            khachHang.maKhachHang = autoCreateMaKhachHang();
            KhachHangAccess.AddKhachHang(khachHang);
        }

        //Phương thức trả về mã khách hàng mới tự động
        private static string autoCreateMaKhachHang()
        {
            DataTable dt = KhachHangAccess.selectTopKhachHang(1);
            if (dt.Rows.Count == 0) {
                return "KH00000001";
            }
            string maCurr = dt.Rows[0]["maKhachHang"].ToString();
            if (string.IsNullOrEmpty(maCurr) || maCurr.Length < 10)
            {
                throw new Exception("Mã khách hàng không hợp lệ.");
            }
            string tamSoCuoiString = maCurr.Substring(2); // Cắt "KH"
            if (!int.TryParse(tamSoCuoiString, out int tamSoCuoiInt))
            {
                throw new Exception("Lỗi chuyển đổi số từ mã khách hàng.");
            }

            int tamSoCuoiIntPlusOne = tamSoCuoiInt + 1;
            return $"KH{tamSoCuoiIntPlusOne:D8}";
        }
        public static bool UpdateKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            if (string.IsNullOrEmpty(maKhachHang))
            {
                throw new ArgumentException("Mã khách hàng không hợp lệ.");
            }

            return KhachHangAccess.UpdateKhachHang(maKhachHang, tenKhachHang, gioiTinh, ngaySinh, diaChi);
        }
        public static bool DoiMatKhau(string email, string matKhauMoi)
        {
            return KhachHangAccess.DoiMatKhau(email, matKhauMoi);
        }
        public static KhachHang SelectOneKhachHangByMaKhachHang(string maKhachHang)
        {
            if (string.IsNullOrEmpty(maKhachHang))
            {
                throw new ArgumentException("Mã khách hàng không hợp lệ.");
            }

            return KhachHangAccess.selectOneKhachHangByMaKhachHang(maKhachHang);
        }

        public static KhachHang SelectOneKhachHangByMaPhieuDatSan(string maPhieuDatSan)
        {
            if (string.IsNullOrEmpty(maPhieuDatSan))
            {
                throw new ArgumentException("Mã phiếu đặt sân không hợp lệ.");
            }

            return KhachHangAccess.selectOneKhachHangByMaPhieuDatSan(maPhieuDatSan);
        }

        public static void DeleteKhachHangByMaKhachHang(string maKhachHang)
        {
            if (string.IsNullOrEmpty(maKhachHang))
            {
                throw new ArgumentException("Mã khách hàng không hợp lệ.");
            }

            KhachHang khachHang = KhachHangAccess.selectOneKhachHangByMaKhachHang(maKhachHang);
            if (khachHang == null)
            {
                throw new Exception("Không tìm thấy khách hàng.");
            }

            KhachHangAccess.deleteKhachHangByMaKhachHang(maKhachHang);
        }
    }
}
