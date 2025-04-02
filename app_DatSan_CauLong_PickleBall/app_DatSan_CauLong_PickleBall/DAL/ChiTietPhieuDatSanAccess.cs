using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                {"@maSan", chiTietPhieuDatSan.maSan },
                {"@donGia", chiTietPhieuDatSan.donGia } 
            };
            Connection.actionQuery(query, parameters);
        }
        public static void findSanBongToAddChiTietDatSan(string maPhieuDatSan, int haiSoCuoiMaSan, string loaiSan)
        {
            if (loaiSan == "Sân Pickleball")
            {
                string maSan = "PK" + haiSoCuoiMaSan.ToString("D2");
                string query1 = "SELECT * FROM San WHERE maSan = @maSan";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@maSan", maSan }
                };
                DataTable sanTable = Connection.selectQuery(query1, parameters);
                DataRow row = sanTable.Rows[0];
                San san = new San(row["maSan"].ToString(), row["tenSan"].ToString(), row["loaiSan"].ToString(), Convert.ToInt32(row["giaSanTheoPhut"]));
                string query2 = "INSERT INTO ChiTietPhieuDatSan VALUES (@maPhieuDatSan, @maSan, @loaiSan, @giaSanTheoPhan)";
                
            }
        }
        
    }
}
