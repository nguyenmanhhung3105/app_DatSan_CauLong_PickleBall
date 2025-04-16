using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;
namespace DAL
{
    public class KhoAccess
    {
        public static DataTable selectAllDungCu()
        {
            string query = "select * from Kho";
            return Connection.selectQuery(query);
        }
        public static DataTable selectDCByMaDC(string maDC)
        {
            string query = "SELECT * FROM Kho WHERE maDungCu = @maDungCu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maDungCu", maDC}

            };
            return Connection.selectQuery(query, parameters);
        }
        public static int getSoLuongByMaDC(string maDC)
        {
            DataTable dt = selectDCByMaDC(maDC);
            int soLuong = int.Parse(dt.Rows[0]["soLuong"].ToString());
            return soLuong;
        }
        public static bool capNhatSoLuongVaTrangThai(string maDungCu, int soLuongThue, bool is_Xoa)
        {
            string query = "";
            if (is_Xoa) {
                query = "UPDATE Kho SET soLuong = soLuong + @soLuongThue WHERE maDungCu = @maDungCu";
            }
            else
            {
                query = "UPDATE Kho SET soLuong = soLuong - @soLuongThue WHERE maDungCu = @maDungCu";
            }
            
            Dictionary<string, object> paraSoLuong = new Dictionary<string, object>
            {
                { "@soLuongThue", soLuongThue },
                { "@maDungCu", maDungCu }
            };
            int rows = Connection.actionQuery(query, paraSoLuong);
            return rows > 0;
        }
    }
}
