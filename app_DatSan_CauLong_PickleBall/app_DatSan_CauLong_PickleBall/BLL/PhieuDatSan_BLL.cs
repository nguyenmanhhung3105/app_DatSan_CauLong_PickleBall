using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class PhieuDatSan_BLL
    {
        public static string AddPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            phieuDatSan.maPhieuDatSan = autoCreateMaPhieuDatSan();
            PhieuDatSanAccess.addPhieuDatSan(phieuDatSan);
            return phieuDatSan.maPhieuDatSan;
        }
        private static string autoCreateMaPhieuDatSan()
        {
            DataTable dataTable = PhieuDatSanAccess.selectTop1PhieuDatSan();

            if (dataTable.Rows.Count > 0)
            {
                string maHienTaiString = dataTable.Rows[0]["maPhieuDatSan"].ToString();
                string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
                int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
                string newPhieuDatSan = "DS" + tamSoCuoiIntPlussOne.ToString("D8");
                return newPhieuDatSan;
            }
            else
            {
                return "DS00000001";
            }

            //if (PhieuDatSanAccess.selectAllPhieuDatSan().Rows.Count == 0)
            //{
            //    return "DS00000001";
            //}
            //else
            //{
            //    DataTable dataTable = PhieuDatSanAccess.selectTop1PhieuDatSan();
            //    string maHienTaiString = dataTable.Rows[0]["maPhieuDatSan"].ToString();
            //    string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
            //    int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
            //    string newPhieuDatSan = "DS" + tamSoCuoiIntPlussOne.ToString("D8");
            //    return newPhieuDatSan;
            //}
        }
        public static string layTenSanByMaPDS(string maPDS)
        {
            return PhieuDatSanAccess.layTenSanTheoPhieuDatSan(maPDS);
        }
        public static PhieuDatSan selectTop1PDSForMKH(string maKH)
        {
            return PhieuDatSanAccess.selectTop1PhieuDatSanForKH(maKH);
        }
        public static int tinhPhieuDatSanKhongCoDC(string maPDS)
        {
            return PhieuDatSanAccess.tinhPhieuDatSanKhongCoDC(maPDS);
        }
        public static DataTable xemLichSuDatSan(string maKH)
        {
            return PhieuDatSanAccess.xemLichSuDatSan(maKH);
        }
        public static DataTable xemAllLichSuDatSanByDate(DateTime ngayDat)
        {
            return PhieuDatSanAccess.xemAllLichSuDatSanByNgayDat(ngayDat);
        }
        public static void upDateTinhTrangPhieuDatSan(string maPDS, string trangThai, string maNV)
        {
            PhieuDatSanAccess.updateTinhTrangPhieuDatSan(maPDS, trangThai, maNV);
        }
        public static void deletePhieuDatSanByMaPDS(string maPDS)
        {
            PhieuDatSanAccess.deletePhieuDatSanByMaPhieuDatSan(maPDS);
        }
        public static string selectTop1MaPDS()
        {
            DataTable dt = PhieuDatSanAccess.selectTop1PhieuDatSan();
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MaPhieuDatSan"].ToString();
            }
            return null;
        }
        public static void upDateTongTienPhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            PhieuDatSanAccess.updateTongTienPhieuDatSanByMaPhieuDatSan(maPhieuDatSan);
        }
    }
}
