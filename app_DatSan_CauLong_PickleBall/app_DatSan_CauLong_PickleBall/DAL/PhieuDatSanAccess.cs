using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
            string query = "INSERT INTO PhieuDatSan values (@maPhieuDatSan, @maKhachHang, @maNhanVien, @loaiSan, @ngayDatSan, @thoiGianDat, @thoiGianKT, @tongTien, @trangThai)";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieuDatSan", phieuDatSan.maPhieuDatSan},
                {"@maKhachHang", phieuDatSan.maKhachHang },
                {"@maNhanVien", phieuDatSan.maNhanVien },
                {"@loaiSan", phieuDatSan.loaiSan},
                {"@ngayDatSan", phieuDatSan.ngayDatSan},
                
                
            };
        }
        public static void updateTongTienPhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            string query = @"WITH cte AS(
                SELECT ChiTietPhieuDatSan.maPhieuDatSan, ChiTietPhieuDatSan.giaSanTheoPhut * DATEDIFF(minute, PhieuDatSan.thoiGian)
            )";
        }
         
    }
}
