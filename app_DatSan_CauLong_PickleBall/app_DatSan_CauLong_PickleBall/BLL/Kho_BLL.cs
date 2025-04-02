using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Kho_BLL
    {
        public static DataTable SelectAllDungCu()
        {
            return KhoAccess.selectAllDungCu();
        }
        public static DataTable selectDCByMaDC(string maDC)
        {
            return KhoAccess.selectDCByMaDC(maDC);
        }
    }
}
