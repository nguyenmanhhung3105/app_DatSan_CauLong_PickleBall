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
    public class CT_PhieuThue_DC_BLL
    {
        public static void addChiTietPhieuThueDC(CT_PhieuThue_DC chiTietPhieuThuDC)
        {
            CT_PhieuThue_DCAccess.addCT_PhieuThue_DC(chiTietPhieuThuDC);
        }
        public static DataTable getChiTietPhieuThueDCByMaPhieuThueDC(string maPhieu)
        {
            return CT_PhieuThue_DCAccess.getChiTietPhieuThueDCByMaPhieuThueDC(maPhieu);
        }
        public static void upDateChiTietPhieuThue_DC(string maPhieu, string maDC_Odd, int soLuong, int donGia, string maDC_New)
        {
            CT_PhieuThue_DCAccess.upDateChiTietPhieuThue_DC(maPhieu, maDC_Odd, soLuong, donGia, maDC_New);
        }
        public static void deleteCTPTDCByMaChiTietPhieuDatDC(string maDC, string maPTDC)
        {
            CT_PhieuThue_DCAccess.deleteCTPTDCByMaChiTietPhieuDatDC(maDC, maPTDC);
        }
    }
}
