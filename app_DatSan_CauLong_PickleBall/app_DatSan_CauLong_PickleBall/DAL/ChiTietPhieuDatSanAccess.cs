using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietPhieuDatSanAccess
    {
        public static void addChiTietPhieuDatSan(ChiTietPhieuDatSan chiTietPhieuDatSan)
        {
            string query = "INSERT INTO chiTietPhieuDatSan VALUES (@maPhieuDatSan, @maSan, @donGia)";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@maPhieuDatSan", chiTietPhieuDatSan.maPhieuDatSan},
                {"@maSan", chiTietPhieuDatSan.maSan},
                {"@donGia", chiTietPhieuDatSan.donGia} 
            };
            Connection.actionQuery(query, parameters);
        }
        public static void findSanToAddChiTietDatSan(string maPhieuDatSan, int haiSoCuoiMaSan, string loaiSan)
        {
            string maSan = "";
            if (loaiSan == "Sân Pickleball")
            {
                maSan = "PK" + haiSoCuoiMaSan.ToString("D2");
            }
            else { 
                maSan = "BA"+ haiSoCuoiMaSan.ToString("D2");
            }
            string query1 = "SELECT * FROM San WHERE maSan = @maSan";
            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@maSan", maSan }
                };
            DataTable sanTable = Connection.selectQuery(query1, parameters);
            DataRow row = sanTable.Rows[0];
            San san = new San(row["maSan"].ToString(), row["tenSan"].ToString(), row["loaiSan"].ToString(), Convert.ToInt32(row["giaSanTheoPhut"]));
            string query2 = "INSERT INTO ChiTietPhieuDatSan (maPDS, maSan, giaSanTheoPhut ) VALUES (@maPhieuDatSan, @maSan, @giaSanTheoPhut)";
            parameters = new Dictionary<string, object>
                {
                    {"@maSan", maSan },
                    {"@maPhieuDatSan", maPhieuDatSan},
                   
                    {"@giaSanTheoPhut", san.giaSanTheoPhut}
                };
            Connection.actionQuery(query2, parameters);
        }
        public static bool checkTrungGio(DateTime thoiGianDat, DateTime thoiGianKetThuc, string maSan)
        {
            
                string query = @"SELECT *
                    FROM chiTietPhieuDatSan
                    JOIN PhieuDatSan ON chiTietPhieuDatSan.maPDS = PhieuDatSan.maPhieuDatSan
                    WHERE chiTietPhieuDatSan.maSan = @maSan
                    AND PhieuDatSan.thoiGianDat < @thoiGianKetThuc
                    AND PhieuDatSan.thoiGianKetThuc > @thoiGianDat";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@maSan", maSan},
                    {"@thoiGianDat", thoiGianDat},
                    {"@thoiGianKetThuc", thoiGianKetThuc}
                    
                };
                Console.WriteLine("hello");
                DataTable dt = Connection.selectQuery(query, parameters);
                return dt.Rows.Count > 0;
        }
        public static void deleteChiTietDatSanByMaPDS(string maPhieu)
        {
            string query = "DELETE FROM ChiTietPhieuDatSan WHERE maPDS = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPhieu}
            };
            Connection.actionQuery(query, parameters);
        }
        public static DataTable xemLichSanBiDat(DateTime ngayXem)
        {
            string query = @"SELECT San.tenSan AS N'Tên Sân', PhieuDatSan.thoiGianDat AS N'Thời gian bắt đầu', PhieuDatSan.thoiGianKetThuc AS N'Thời gian kết thúc'
                            FROM ChiTietPhieuDatSan
                            INNER JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPDS = PhieuDatSan.maPhieuDatSan
                            INNER JOIN San ON ChiTietPhieuDatSan.maSan = San.maSan
                            WHERE CAST(PhieuDatSan.ngayDatSan AS DATE) = @ngayXem
                        ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@ngayXem", ngayXem.ToString("yyyy-MM-dd")} 
            };
            return Connection.selectQuery(query, parameters);

        }
        
    }
}
