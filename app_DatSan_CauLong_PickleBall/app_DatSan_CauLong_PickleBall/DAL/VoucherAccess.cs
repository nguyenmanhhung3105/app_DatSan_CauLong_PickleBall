using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class VoucherAccess
    {
        public static void addVoucher(Voucher voucher)
        {
            // Lấy mã lớn nhất hiện có trong bảng Voucher
            string getMaxMaQuery = "SELECT TOP 1 MaVoucher FROM Voucher WHERE MaVoucher LIKE 'VC%' ORDER BY MaVoucher DESC";
            DataTable dt = Connection.selectQuery(getMaxMaQuery);

            string newMa = "VC001"; // mặc định nếu chưa có mã nào

            if (dt.Rows.Count > 0)
            {
                string lastMa = dt.Rows[0]["MaVoucher"].ToString(); // VD: "VC007"
                int so = int.Parse(lastMa.Substring(3));            // Lấy số: 7
                so++;                                               // Tăng lên: 8
                newMa = $"VC{so.ToString("D3")}";                   // VC008
            }

            voucher.MaVoucher = newMa;

            string query = @"INSERT INTO Voucher 
        (MaVoucher, TenVoucher, GiaTriGiam, KieuGiam, NgayBatDau, NgayKetThuc, DieuKienApDung, SoLuong) 
        VALUES 
        (@maVoucher, @tenVoucher, @giaTriGiam, @kieuGiam, @ngayBatDau, @ngayKetThuc, @dk, @soLuong)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@maVoucher", voucher.MaVoucher },
        {"@tenVoucher", voucher.TenVoucher},
        {"@giaTriGiam", voucher.GiaTriGiam },
        {"@kieuGiam", voucher.KieuGiam},
        {"@ngayBatDau", voucher.NgayBatDau },
        {"@ngayKetThuc", voucher.NgayKetThuc },
        {"@dk", voucher.DieuKienApDung },
        {"@soLuong", voucher.SoLuong }
    };

            Connection.actionQuery(query, parameters);
        }
        public static void UpdateVoucher(Voucher voucher)
        {
            string query = @"UPDATE Voucher SET TenVoucher=@mota, GiaTriGiam=@giatri, KieuGiam=@kieugiam, 
                     DieuKienApDung=@dk, NgayBatDau=@batdau, NgayKetThuc=@ketthuc, SoLuong = @soLuong
                     WHERE MaVoucher=@ma";
            var parameters = new Dictionary<string, object>
    {
        { "@ma", voucher.MaVoucher },
        
        { "@giatri", voucher.GiaTriGiam },
        { "@kieugiam", voucher.KieuGiam },
        { "@dk", voucher.DieuKienApDung },
        { "@batdau", voucher.NgayBatDau },
        { "@ketthuc", voucher.NgayKetThuc },
                {"@soLuong", voucher.SoLuong }
    };
            Connection.actionQuery(query, parameters);
        }
        public static void deleteVoucher(string maVoucher)
        {
            string query = "DELETE FROM Voucher WHERE MaVoucher = @ma";
            var parameters = new Dictionary<string, object> { { "@ma", maVoucher } };
            Connection.actionQuery(query, parameters);
            
        }
        public static void xoaVoucherHetHan()
        {
            string query = "DELETE FROM Voucher WHERE NgayKetThuc < @today";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@today", DateTime.Now}

            };
            Connection.actionQuery(query, parameters);
        }
        public static DataTable getAllVoucher() {
            string query = "SELECT * FROM Voucher";
            return Connection.selectQuery(query);
        }
        public static bool capVoucherChoKhachHang(string maVoucher, string maKhachHang, int soLuong = 1)
        {
            // 1. Kiểm tra số lượng voucher còn lại
            string queryCheck = "SELECT SoLuong FROM Voucher WHERE MaVoucher = @maVoucher";
            Dictionary<string, object> parametersCheck = new Dictionary<string, object>
    {
        { "@maVoucher", maVoucher }
    };
            DataTable dt = Connection.selectQuery(queryCheck, parametersCheck);

            if (dt.Rows.Count == 0) return false;

            int soLuongConLai = Convert.ToInt32(dt.Rows[0]["SoLuong"]);
            if (soLuongConLai < soLuong) return false;

            // 2. Trừ số lượng trong bảng Voucher
            string queryUpdate = "UPDATE Voucher SET SoLuong = SoLuong - @soLuong WHERE MaVoucher = @maVoucher";
            Dictionary<string, object> parametersUpdate = new Dictionary<string, object>
    {
        { "@maVoucher", maVoucher },
        { "@soLuong", soLuong }
    };
            Connection.actionQuery(queryUpdate, parametersUpdate);

            // 3. Cấp voucher cho khách trong bảng VoucherDaCap
            string queryInsert = @"
        INSERT INTO VoucherDaCap (MaVoucher, MaKhachHang, TrangThai, SoLuongConLai)
        VALUES (@maVoucher, @maKhachHang, N'Chưa dùng', @soLuong)";
            Dictionary<string, object> parametersInsert = new Dictionary<string, object>
    {
        { "@maVoucher", maVoucher },
        { "@maKhachHang", maKhachHang },
        { "@soLuong", soLuong }
    };
           return Connection.actionQuery(queryInsert, parametersInsert) > 0;

        }
    }
}
