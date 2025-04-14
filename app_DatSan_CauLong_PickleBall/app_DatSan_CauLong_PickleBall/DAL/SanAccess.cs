using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanAccess
    {
        public static bool checkSanTonTaiByList(List<string> list)
        {
            foreach (var item in list) { 
                if(selectSanByName(item) == false) return false;
            }
            return true;
        }
        public static bool selectSanByName(string name) {
            string query = "SELECT * FROM San WHERE tenSan = @tenSan";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@tenSan", name} 
                
            };
            return Connection.selectQuery(query, parameters).Rows.Count == 0? false: true;
        }
        public static DataTable selectAllSan()
        {
            string query = "select * from San";
            return Connection.selectQuery(query);
        }
        public static DataTable selectSanByLoaiSan(string name)
        {
            string query = "SELECT * FROM San WHERE loaiSan = @loaiSan";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@loaiSan", name}

            };
            return Connection.selectQuery(query, parameters);
        }
        public static DataTable xemGiaSan()
        {
            string query = @"SELECT 
                    tenSan AS N'Tên Sân', 
                    FORMAT(giaSanTheoPhut * 30, 'N0') + N' VNĐ' AS N'Giá sân 30 phút', 
                    FORMAT(giaSanTheoPhut * 60, 'N0') + N' VNĐ' AS N'Giá sân 60 phút', 
                    FORMAT(giaSanTheoPhut * 90, 'N0') + N' VNĐ' AS N'Giá sân 90 phút', 
                    FORMAT(giaSanTheoPhut * 120, 'N0') + N' VNĐ' AS N'Giá sân 120 phút'
                FROM San";
            return Connection.selectQuery(query);
        }
    }
}
