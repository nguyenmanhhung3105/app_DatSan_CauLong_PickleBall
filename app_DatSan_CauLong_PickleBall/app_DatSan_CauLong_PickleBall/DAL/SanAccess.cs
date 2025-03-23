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
    }
}
