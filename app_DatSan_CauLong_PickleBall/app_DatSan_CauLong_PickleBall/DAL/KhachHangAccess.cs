using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class KhachHangAccess
    {
        public static DataTable selectOneKhachHang(string dieuKien, Dictionary<string, object> parameters)
        {
            if (string.IsNullOrWhiteSpace(dieuKien))
            {
                return null;
            }
            string query = $"SELECT * FROM KhachHang WHERE({dieuKien})";
            try
            {
                return Connection.selectQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static DataTable selectAllKhachHang()
        {
            string query = @"
                SELECT
                    maKhachHang AS N'Mã khách hàng', 
                    tenKhachHang AS N'Tên khách hàng',
                    soDienThoai AS N'Số điện thoại', 
                    email AS N'Email', 
                    matKhau AS N'Mật khẩu', 
                    gioiTinh AS N'Giới tính', 
                    ngaySinh AS N'Ngày sinh', 
                    diaChi AS N'Địa chỉ', 
                    soLanDatSan AS N'Số lần đặt sân'
                FROM KhachHang 
                ";
            try
            {
                return Connection.selectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static DataTable selectTopKhachHang(int n)
        {
            string query = @"
                SELECT TOP (@limit) *
                FROM KhachHang
                WHERE ISNUMERIC(RIGHT(maKhachHang,8)) = 1
                ORDER BY CAST(RIGHT(maKhachHang, 8) AS bigint) DESC
            ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@limit", n }
            };
            try
            {
                return Connection.selectQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static bool checkLoginValid(string soDienThoai_Email, string matKhau)
        {
            string query = "SELECT * FROM KhachHang WHERE (soDienThoai = @login OR email = @login) AND matKhau = @matKhau";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@login", soDienThoai_Email },
                {"@matKhau", matKhau }
            };
            if (Connection.selectQuery(query, parameters).Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public static void AddKhachHang(KhachHang khachHang) {
            string query = @"INSERT INTO KhachHang (maKhachHang, tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan)
                            VALUES (@maKhachHang, @tenKhachHang, @soDienThoai, @email, @matKhau, @gioiTinh, @ngaySinh, @diaChi, @soLanDatSan)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maKhachHang", khachHang.maKhachHang},
                { "@tenKhachHang", khachHang.tenKhachHang },
            { "@soDienThoai", khachHang.soDienThoai },
            { "@email", khachHang.email },
            { "@matKhau", khachHang.matKhau },
            { "@gioiTinh", khachHang.gioiTinh},
            { "@ngaySinh", khachHang.ngaySinh},
            { "@diaChi", khachHang.diaChi},
            { "@soLanDatSan", khachHang.soLanDatSan}

            };
            int cnt = Connection.actionQuery(query, parameters);
        }
        public static bool UpdateKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            try
            {
                string query = "UPDATE KhachHang SET tenKhachHang = @tenKhachHang, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, diaChi = @diaChi WHERE maKhachHang = @maKhachHang";
                Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@tenKhachHang", tenKhachHang },
                { "@gioiTinh", gioiTinh },
                { "@ngaySinh", ngaySinh },
                { "@diaChi", diaChi },
                { "@maKhachHang", maKhachHang }
            };
                Connection.actionQuery(query, parameters);
                return true;
            }
            catch { return false; }
        }
        public static bool DoiMatKhau(string soDienThoai_email, string matKhauMoi)
        {
            try
            {
                string query = "UPDATE KhachHang SET matKhau = @matKhauMoi WHERE email = @soDienThoai_email or soDienThoai = @soDienThoai_email";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@matKhauMoi", matKhauMoi },
                    {"@soDienThoai_email", soDienThoai_email }
                };
                int row = Connection.actionQuery(query, parameters);
                return row > 0;

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Lỗi khi đổi mật khẩu {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

        }
        public static KhachHang selectOneKhachHangByMaKhachHang(string maKhachHang)
        {
            try
            {
                string query = "SELECT * FROM KhachHang WHERE maKhachHang = @maKhachHang";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@maKhachHang", maKhachHang },


                };
                DataTable dt = Connection.selectQuery(query, parameters);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Không có khách hàng được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                DataRow r = dt.Rows[0];
                return new KhachHang(
                    r["maKhachHang"].ToString(),
                    r["tenKhachHang"].ToString(),
                    r["soDienThoai"].ToString(),
                    r["email"].ToString(),
                    r["matKhau"].ToString(),
                    r["gioiTinh"].ToString(),
                    DateTime.Parse(r["ngaySinh"].ToString()),
                    r["diaChi"].ToString(),
                    int.Parse(r["soLanDatSan"].ToString())
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static KhachHang selectOneKhachHangByMaPhieuDatSan(string maPhieuDatSan)
        {
            try
            {
                string query = "SELECT * FROM KhachHang WHERE maKhachHang IN (SELECT maKhachHang FROM PhieuDatSan WHERE maPhieuDatSan = @maPhieuDatSan)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@maPhieuDatSan", maPhieuDatSan }
            };
                DataTable dt = Connection.selectQuery(query, parameters);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Không có khách hàng được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                DataRow row = dt.Rows[0];
                return new KhachHang(
                    row["maKhachHang"].ToString(),
                    row["tenKhachHang"].ToString(),
                    row["soDienThoai"].ToString(),
                    row["email"].ToString(),
                    row["matKhau"].ToString(),
                    row["gioiTinh"].ToString(),
                    DateTime.Parse(row["ngaySinh"].ToString()),
                    row["diaChi"].ToString(),
                    int.Parse(row["soLanDatSan"].ToString())
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void updateSoLanDatSanThanhCong()
        {
            string query = "UPDATE KhachHang SET soLanDatSan = (SELECT COUNT(maKhachHang) FROM PhieuDatSan WHERE TinhTrangThanhToan = N'Đã thanh toán' AND PhieuDatSan.maKhachHang = KhachHang.maKhachHang)";
            Connection.actionQuery(query);
        }

        public static void deleteKhachHangByMaKhachHang(string maKhachHang)
        {
            string query1 = "DELETE FROM ChiTietPhieuDatSan WHERE maPhieuDatSan IN (SELECT maPhieuDatSan FROM PhieuDatSan WHERE maKhachHang = @maKhachHang)";
            string query2 = "DELETE FROM PhieuDatSan WHERE maKhachHang = @maKhachHang";
            string query3 = "DELETE FROM KhachHang WHERE maKhachHang = @maKhachHang";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@maKhachHang", maKhachHang }
            };

            try
            {

                Connection.actionQuery(query1, parameters);
                Connection.actionQuery(query2, parameters);
                Connection.actionQuery(query3, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void capNhatSoLanDatSan(string maKhachHang)
        {
            string query = @"
        UPDATE KhachHang
        SET soLanDatSan = ISNULL(soLanDatSan, 0) + 1
        WHERE maKhachHang = @maKhachHang";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@maKhachHang", maKhachHang }
    };

            Connection.actionQuery(query, parameters);
        }
    }
}
