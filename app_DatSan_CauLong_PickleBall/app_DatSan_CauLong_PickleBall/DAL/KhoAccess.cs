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
    }
}
