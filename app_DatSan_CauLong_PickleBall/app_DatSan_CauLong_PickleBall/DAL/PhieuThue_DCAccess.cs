using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuThue_DCAccess
    {

        public static DataTable getPhieuThueDCByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM PhieuThueDC WHERE maPhieu = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieu", maPhieu}
            };
            return Connection.selectQuery(query, parameters);
        }
        public static DataTable selectTop1PhieuThueDungCu()
        {
            string query = "SELECT TOP 1* FROM PhieuThueDC ORDER BY CAST(RIGHT(maPhieu, 8) AS bigint) DESC";
            return Connection.selectQuery(query);
        }
        public static DataTable getAllPhieuThueDC()
        {
            string query = "SELECT * FROM PhieuThueDC";
            return Connection.selectQuery(query);
        }

        public static void insertAPhieuThue_DC(PhieuThue_DC phieuThue_DC)
        {
            string query = @"INSERT INTO PhieuThueDC VALUES (@maPhieuThueDC, @ngayThue, @maKH, @tongTien, @trangThai)";

            Dictionary<string, object> parameters = new Dictionary<string, object> {
                { "@maPhieuThueDC", phieuThue_DC.maPhieuThueDC},
                {"@ngayThue", phieuThue_DC.ngayThue },
                {"@maKH", phieuThue_DC.maKhachHang },
                {"@tongTien", phieuThue_DC.tongTien },
                {"@trangThai", phieuThue_DC.trangThai }

            };
            Connection.actionQuery(query, parameters);
        }
        public static void updatePhieuThueDC(string maPhieuThueDC, DateTime ngayThue, string maKH, int tongTien, string trangThai)
        {
            string query = "UPDATE PhieuThueDC SET maPhieu = @maPhieu, ngayThue = @ngayThue, maKH = @maKH, tongTien = @tongTien, trangThai = @trangThai WHERE maPhieu = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieu", maPhieuThueDC },
                {"@ngayThue", ngayThue },
                {"@maKH", maKH },
                {"@tongTien", tongTien },
                {"@trangThai", trangThai }

            };

            Connection.actionQuery(query, parameters);

        }
        public static bool deletePhieuThueDungCu(string maPhieu)
        {
            string query = "DELETE FROM PhieuThueDC WHERE maPhieu = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieu", maPhieu }

            };
            return Connection.actionQuery(query, parameters) > 0;

        }
        public static void calculateTongTienThueDungCu(string maPhieu)
        {

            string query = "SELECT ct.thanhTien FROM CT_PhieuThueDC ct WHERE ct.maPhieu = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPhieu}
            };
            DataTable dt = Connection.selectQuery(query, parameters);
            int tt = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.Table.Columns.Contains("thanhTien") && row["thanhTien"] != DBNull.Value)
                    {
                        tt += Convert.ToInt32(row["thanhTien"]);
                    }
                }

                string queryUpdate = $"UPDATE PhieuThueDC SET tongTien = @tongTien WHERE maPhieu = @maPhieu";
                Dictionary<string, object> updateParameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPhieu},
                {"@tongTien", tt}
            };
                Connection.actionQuery(queryUpdate, updateParameters);
            }
        }
        
        public static DataTable getPhieuThueDCByMaKH(string maKH)
        {
            string query = "SELECT * FROM PhieuThueDC WHERE maKH = @maKH";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maKH", maKH}
            };
            return Connection.selectQuery(query, parameters);
        }
        public static DataTable xemAllLichSuPTDCByNgayDat(DateTime time)
        {
            string query = "SELECT maPhieu AS N'Mã phiếu', ngayThue AS N'Ngày thuê', maKH AS N'Mã khách hàng', tongTien AS N'Tổng tiền', trangThai AS N'Trạng thái' FROM PhieuThueDC WHERE CAST(ngayThue as DATE) = @ngayDat";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@ngayDat", time.Date }

            };
            return Connection.selectQuery(query, parameters);
        }
        public static PhieuThue_DC selectTop1PTDCForMKH(string maKH, string maPDS)
        {
            string query = @"SELECT TOP 1* FROM PhieuThueDC WHERE maKH = @maKH AND maPhieu IN (
            SELECT maPhieu 
            FROM CT_PhieuThueDC 
            WHERE maPhieuDatSan = @maPDS
        ) and trangThai = N'Chưa thanh toán' ORDER BY maPhieu DESC, ngayThue DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@maKH", maKH },
                { "@maPDS", maPDS }
    };
            DataTable dt = Connection.selectQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new PhieuThue_DC(
                        row["maPhieu"].ToString(),
                        row["maKH"].ToString(),
                        Convert.ToDateTime(row["ngayThue"]),
                        Convert.ToInt32(row["tongTien"]),
                        row["trangThai"].ToString()
                );
            }

            return null;
        }


        public static string LayDanhSachTenDungCu(string maPhieuDatSan)
        {
            string query = @"
        SELECT k.tenDungCu
        FROM PhieuThueDC ptdc
        JOIN CT_PhieuThueDC ctp ON ptdc.maPhieu = ctp.maPhieu
        JOIN Kho k ON ctp.maDungCu = k.maDungCu
        WHERE ctp.maPhieuDatSan = @maPhieuDatSan";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@maPhieuDatSan", maPhieuDatSan }
    };

            DataTable dt = Connection.selectQuery(query, parameters);
            List<string> tenDcs = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                tenDcs.Add(row["tenDungCu"].ToString());
            }

            return string.Join(", ", tenDcs);
        }
        public static PhieuThue_DC selectPTDCByPDS(string mapDS) {
            string query = @"SELECT TOP 1 ptdc.*
        FROM PhieuThueDC ptdc
        JOIN CT_PhieuThueDC ct ON ptdc.maPhieu = ct.maPhieu
        WHERE ct.maPhieuDatSan = @maPDS";
        
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@maPDS", mapDS}
            };
            DataTable dt = Connection.selectQuery (query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                return new PhieuThue_DC(
                        row["maPhieu"].ToString(),
                        row["maKH"].ToString(),
                        Convert.ToDateTime(row["ngayThue"]),
                        Convert.ToInt32(row["tongTien"]),
                        row["trangThai"].ToString()


                );
            }

            return null;
        }
    }
}