using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class San_BLL
    {
        public static bool CheckSanBongTonTaiByList(List<string> list)
        {
            return SanAccess.checkSanTonTaiByList(list);
        }
        public static DataTable SelectAllSanBong()
        {
            return SanAccess.selectAllSan();
        }
    }
}
