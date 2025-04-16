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
    public class PhieuThueDC_BLL
    {
        public static string addPhieuThueDC(PhieuThue_DC phieuThue_DC)
        {
            phieuThue_DC.maPhieuThueDC = autoCreatMaPhieuThueDC();
            PhieuThue_DCAccess.insertAPhieuThue_DC(phieuThue_DC);
            return phieuThue_DC.maPhieuThueDC;
        }
        public static string autoCreatMaPhieuThueDC()
        {
            if (PhieuThue_DCAccess.getAllPhieuThueDC().Rows.Count == 0) {
                return "DC00000001";

            }
            else
            {
                DataTable dt = PhieuThue_DCAccess.selectTop1PhieuThueDungCu();
                string currCode = dt.Rows[0]["maPhieu"].ToString();
                string so = currCode.Substring(2);
                int soMoi = int.Parse(so) + 1;
                string newCode = "DC" + soMoi.ToString("D8"); // D8 để giữ 8 chữ số
                return newCode;
            }
        }
        public static DataTable getPhieuThueDungCuByMaPhieu(string maPhieu)
        {
            return PhieuThue_DCAccess.getPhieuThueDCByMaPhieu(maPhieu);
        }
        public static DataTable selectTop1PhieuThueDungCu()
        {
            return PhieuThue_DCAccess.selectTop1PhieuThueDungCu();
        }
        public static DataTable getAllPhieuThueDC()
        {
            return PhieuThue_DCAccess.getAllPhieuThueDC();
        }
        public static PhieuThue_DC selectTop1PTDCForMKH(string maKh, string maPDS)
        {
            return PhieuThue_DCAccess.selectTop1PTDCForMKH(maKh, maPDS);
        }
        public static void insertAtPhieuThue_DC(PhieuThue_DC phieuThueDC)
        {
            PhieuThue_DCAccess.insertAPhieuThue_DC(phieuThueDC);
        }
        public static void upDatePhieuThueDC(string maPhieuThueDC, DateTime ngayThue, string maKH, int tongTien, string trangThai)
        {
            PhieuThue_DCAccess.updatePhieuThueDC(maPhieuThueDC, ngayThue, maKH, tongTien, trangThai);
        }
        public static bool deletePhieuThueDungCu(string maPhieuThueDC) { 
            return PhieuThue_DCAccess.deletePhieuThueDungCu(maPhieuThueDC);
        }
        public static void upDateTongTienThueDungCu(string maPhieuThueDC) {
            PhieuThue_DCAccess.calculateTongTienThueDungCu(maPhieuThueDC);
        }
        public static DataTable getPhieuThueDCByMaKH(string maKH) { 
            return PhieuThue_DCAccess.getPhieuThueDCByMaKH (maKH);
        }
        public static DataTable xemAllLichSuPTDCByNgayDat(DateTime time) { 
            return PhieuThue_DCAccess.xemAllLichSuPTDCByNgayDat (time);
        }
        public static string layDanhSachTenDungCu(string maPDS)
        {
            return PhieuThue_DCAccess.LayDanhSachTenDungCu (maPDS);
        }
        public static PhieuThue_DC selectPTDCByPDS(string maPDS)
        {
            return PhieuThue_DCAccess.selectPTDCByPDS (maPDS);
        }
    }
}
