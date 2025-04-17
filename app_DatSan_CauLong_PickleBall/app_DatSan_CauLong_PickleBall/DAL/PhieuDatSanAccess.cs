using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace DAL
{
    public class PhieuDatSanAccess
    {
        public static DataTable selectAllPhieuDatSan()
        {
            string query = "Select * from PhieuDatSan";
            return Connection.selectQuery(query);
        }
        public static DataTable selectTop1PhieuDatSan()
        {
            string query = "select top 1* from PhieuDatSan ORDER BY CAST(RIGHT(maPhieuDatSan, 8) AS bigint) DESC";
            return Connection.selectQuery(query);
        }  
        public static void addPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            string query = "INSERT INTO PhieuDatSan values (@maPhieuDatSan, @maKhachHang, @loaiSan, @ngayDatSan, @thoiGianDat, @thoiGianKT, @tongTien, @trangThai)";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieuDatSan", phieuDatSan.maPhieuDatSan},
                {"@maKhachHang", phieuDatSan.maKhachHang },
                {"@loaiSan", phieuDatSan.loaiSan},
                {"@ngayDatSan", phieuDatSan.ngayDatSan},
                {"@thoiGianDat", phieuDatSan.thoiGianDat},
                {"@thoiGianKT", phieuDatSan.thoiGianKT },
                {"@tongTien", phieuDatSan.tongTien },
                {"@trangThai", phieuDatSan.trangThai }   
            };
            Connection.actionQuery(query, parameters);
        }
        
        public static DataTable xemLichSuDatSan(string maKH)
        {
            string query = @"SELECT 
            pds.maPhieuDatSan AS N'Mã phiếu đặt sân', 
            pds.maKhachHang AS N'Mã khách hàng', 
            pds.maSan AS N'Mã Sân', 
            pds.loaiSan AS N'Loại sân', 
            pds.ngayDatSan AS N'Ngày đặt sân', 
            pds.thoiGianDat AS N'Thời gian đặt', 
            pds.thoiGianKT AS N'Thời gian kết thúc', 
            GROUP_CONCAT(CONCAT(k.tenDungCu, ' (', COALESCE(ct.soLuong, 0), ')')) AS N'Dụng cụ thuê'
            FROM PhieuDatSan pds
            LEFT JOIN ChiTietThueSanDungCu ct ON pds.maPhieuDatSan = ct.maPhieuDatSan
            LEFT JOIN Kho k ON ct.maDungCu = k.maDungCu
            WHERE pds.maKhachHang = @maKH
            GROUP BY pds.maPhieuDatSan, pds.maKhachHang, pds.maNhanVien, pds.maSan, pds.loaiSan, pds.ngayDatSan, pds.thoiGianDat, pds.thoiGianDat, pds.thoiGianKT;
            ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            {"@maKH", maKH}
        };

            return Connection.selectQuery(query, parameters);
        }
        public static DataTable xemAllLichSuDatSanByNgayDat(DateTime ngayDat)
        {
            string query = @"SELECT
                pds.maPhieuDatSan AS N'Mã phiếu',
                pds.maKhachHang AS N'Mã khách hàng', 
                pds.maSan AS N'Mã Sân', 
                pds.loaiSan AS N'Loại sân', 
                pds.ngayDatSan AS N'Ngày đặt sân', 
                pds.thoiGianDat AS N'Thời gian đặt', 
                pds.thoiGianKT AS N'Thời gian kết thúc',
                GROUP_CONCAT(CONCAT(k.tenDungCu, ' (', COALESCE(ct.soLuong, 0), ')')) AS N'Dụng cụ thuê',
                FROM PhieuDatSan pds
                LEFT JOIN ChiTietThueSanDungCu ct ON pds.maPhieuDatSan = ct.maPhieuDatSan
                LEFT JOIN Kho k ON cttsdc.maDungCu = k.maDungCu
                WHERE (pds.thoiGianDa AS DATE) = @ngayDat 
                GROUP BY pds.maPhieuDatSan, pds.maQuanLy, pds.loaiSan, pds.ngayDatSan, pds.thoiGianDa, pds.thoiGianKetThuc, pds.tongTien, pds.tinhTrangXacNhan, pds.tinhTrangThanhToan;
            ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@ngayDat", ngayDat.Date}
            };
            return Connection.selectQuery(query, parameters);
        }
        public static int tinhPhieuDatSanKhongCoDC(string maPhieuDatSan)
        {
            int tongTienSan = 0;
            string query = @"
                SELECT SUM(chiTietPhieuDatSan.giaSanTheoPhut * DATEDIFF(minute, PhieuDatSan.thoiGianDat, PhieuDatSan.thoiGianKetThuc)) AS tien
                FROM ChiTietPhieuDatSan
                JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPDS = PhieuDatSan.maPhieuDatSan
                WHERE chiTietPhieuDatSan.maPDS = @maPDS
                ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPDS", maPhieuDatSan}

            };
            DataTable dtTienSan = Connection.selectQuery(query, parameters);
            if (dtTienSan != null && dtTienSan.Rows.Count > 0 && dtTienSan.Rows[0]["tien"] != DBNull.Value)
            {
                tongTienSan = Convert.ToInt32(dtTienSan.Rows[0]["tien"]);
            }
            return tongTienSan;
        }
        public static void updateTongTienPhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            int tongTienSan = 0;
            string query = @"
                SELECT SUM(chiTietPhieuDatSan.giaSanTheoPhut * DATEDIFF(minute, PhieuDatSan.thoiGianDat, PhieuDatSan.thoiGianKetThuc)) AS tien
                FROM ChiTietPhieuDatSan
                JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPDS = PhieuDatSan.maPhieuDatSan
                WHERE chiTietPhieuDatSan.maPDS = @maPDS
                ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPDS", maPhieuDatSan} 
                
            };
            DataTable dtTienSan = Connection.selectQuery(query, parameters);
            if (dtTienSan != null && dtTienSan.Rows.Count > 0 && dtTienSan.Rows[0]["tien"] != DBNull.Value)
            {
                tongTienSan = Convert.ToInt32(dtTienSan.Rows[0]["tien"]);
            }
            int tongTienDC = 0;
            string queryTongTienDungCu = @"SELECT tongTien AS TongTienDungCu
FROM PhieuThueDC JOIN CT_PhieuThueDC ON PhieuThueDC.maPhieu = CT_PhieuThueDC.maPhieu
WHERE CT_PhieuThueDC.maPhieuDatSan = @maPhieuDatSan";

            Dictionary<string, object> paramDungCu = new Dictionary<string, object>()
            {
                {"@maPhieuDatSan", maPhieuDatSan}
            };
            DataTable dtTienDungCu = Connection.selectQuery(queryTongTienDungCu, paramDungCu);
            if (dtTienDungCu != null && dtTienDungCu.Rows.Count > 0 && dtTienDungCu.Rows[0]["TongTienDungCu"] != DBNull.Value)
            {
                tongTienDC = Convert.ToInt32(dtTienDungCu.Rows[0]["TongTienDungCu"]);
            }
            int tongTienCuoiCung = tongTienSan + tongTienDC;

            string queryUpdate = "UPDATE PhieuDatSan SET tongTien = @tongTien WHERE maPhieuDatSan = @maPhieuDatSan";
            Dictionary<string, object> updateParams = new Dictionary<string, object>()
        {
            {"@maPhieuDatSan", maPhieuDatSan},
            {"@tongTien", tongTienCuoiCung}
        };

            Connection.actionQuery(queryUpdate, updateParams);
        }
        public static void updateTinhTrangPhieuDatSan(string maPDS, string tinhTrang)
        {
            string query = "UPDATE PhieuDatSan SET trangThai = @tinhTrang WHERE maPhieuDatSan = @maPDS";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@tinhTrang", tinhTrang},
                {"@maPDS", maPDS}
                
            };
            Connection.actionQuery(query, parameters);
        }
        public static void deletePhieuDatSanByMaPhieuDatSan(string maPDS)
        {
            ChiTietPhieuDatSanAccess.deleteChiTietDatSanByMaPDS(maPDS);
            string query = "DELETE FROM PhieuDatSan WHERE maPhieuDatSan = @maPDS";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPDS", maPDS }
            };
            Connection.actionQuery(query, parameters);
        }
        public static PhieuDatSan selectTop1PhieuDatSanForKH(string maKH)
        {
            string query = @"
        SELECT TOP 1 *
        FROM PhieuDatSan
        WHERE maKhachHang = @maKH and trangThai = N'Chưa thanh toán'
        ORDER BY maPhieuDatSan DESC, thoiGianDat DESC";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@maKH", maKH }
    };

            DataTable dt = Connection.selectQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new PhieuDatSan
                (
                    row["maPhieuDatSan"].ToString(),
                    row["maKhachHang"].ToString(),
                    row["loaiSan"].ToString(),
                    Convert.ToDateTime(row["ngayDatSan"]),
                    Convert.ToDateTime(row["thoiGianDat"]),
                    Convert.ToDateTime(row["thoiGianKetThuc"]),
                    Convert.ToInt32(row["tongTien"])
                );
            }

            return null;
        }
        public static string layTenSanTheoPhieuDatSan(string maPhieuDatSan)
        {
            string query = @"
        SELECT s.tenSan 
        FROM San s
        JOIN chiTietPhieuDatSan ctpds ON s.maSan = ctpds.maSan
        JOIN PhieuDatSan pds ON ctpds.maPDS = pds.maPhieuDatSan
        WHERE pds.maPhieuDatSan = @maPhieuDatSan";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@maPhieuDatSan", maPhieuDatSan }
    };

            DataTable dt = Connection.selectQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["tenSan"].ToString();
            }

            return string.Empty;
        }
    }
}



