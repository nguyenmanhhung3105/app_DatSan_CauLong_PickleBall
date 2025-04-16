using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class VoucherDaCapAccess
    {
        public static bool upDateTrangThaiVoucherDaCap(string maVoucher, string maKH)
        {
            string query1 = @"UPDATE VoucherDaCap 
                     SET SoLuongConLai = SoLuongConLai - 1 
                     WHERE MaVoucher = @maVoucher AND MaKhachHang = @maKhachHang AND SoLuongConLai > 0";
            
            string query2 = @"
        UPDATE VoucherDaCap 
        SET TrangThai = N'Đã dùng hết' 
        WHERE MaVoucher = @maVoucher AND MaKhachHang = @maKhachHang AND SoLuongConLai = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@maVoucher", maVoucher },
                { "@maKhachHang", maKH }
            };
            return Connection.actionQuery(query1, parameters) >0 || Connection.actionQuery(query2, parameters) > 0;
        }
        public static bool xoaVoucherDaCapHetHan()
        {
            string query = @"DELETE VC
        FROM VoucherDaCap VC
        JOIN Voucher V ON VC.MaVoucher = V.MaVoucher
        WHERE GETDATE() > V.NgayKetThuc";
            return Connection.actionQuery(query) >0;
        }
        public static DataTable getVoucherDaCapByKhachHang(string maKhachHang)
        {
            string query = @"SELECT * FROM VoucherDaCap WHERE MaKhachHang = @maKhachHang";
            Dictionary<string, object> param = new Dictionary<string, object>
    {
        { "@maKhachHang", maKhachHang }
    };

            return Connection.selectQuery(query, param);
        }
        public static DataTable getVoucherConDungDuoc(string maKhachHang)
        {
            string query = @"
    SELECT VC.*, V.TenVoucher, V.GiaTriGiam, V.KieuGiam , VC.MaVoucher + ' - ' + V.TenVoucher AS HienThi
    FROM VoucherDaCap VC
    JOIN Voucher V ON VC.MaVoucher = V.MaVoucher
    WHERE VC.MaKhachHang = @maKhachHang 
        AND VC.TrangThai = N'Chưa dùng' 
        AND VC.SoLuongConLai > 0
        AND GETDATE() BETWEEN V.NgayBatDau AND V.NgayKetThuc";

            Dictionary<string, object> param = new Dictionary<string, object>
    {
        { "@maKhachHang", maKhachHang }
    };

            return Connection.selectQuery(query, param);
        }
    }
}
