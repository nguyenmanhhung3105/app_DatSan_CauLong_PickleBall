using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CT_PhieuThue_DCAccess
    {
        public static void addCT_PhieuThue_DC(CT_PhieuThue_DC cT_PhieuThue_DC)
        {
            string query = "INSERT INTO CT_PhieuThueDC (maPhieu, maDungCu, maPhieuDatSan, soLuong, donGia)  VALUES (@maPhieu, @maDungCu, @maPhieuDatSan, @soLuong, @donGia)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", cT_PhieuThue_DC.maPhieuThueDC},
                {"@maDungCu", cT_PhieuThue_DC.maDungCu },
                {"@maPhieuDatSan", cT_PhieuThue_DC.maPhieuDatSan },
                {"@soLuong", cT_PhieuThue_DC.soLuong },
                {"@donGia", cT_PhieuThue_DC.donGia }
            };
            Connection.actionQuery(query, parameters);
        }
        
        public static DataTable getChiTietPhieuThueDCByMaPhieuThueDC(string maPhieu)
        {
            string query = "SELECT k.tenDungCu AS N'Tên dụng cụ',ct.soLuong AS N'Số lượng', ct.donGia AS N'Giá Thuê', ct.thanhTien AS N'Thành tiền' FROM CT_PhieuThueDC ct INNER JOIN Kho k ON ct.maDungCu = k.maDungCu WHERE ct.maPhieu = @maPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPhieu}

            };
            return Connection.selectQuery(query, parameters);
        }
        public static void upDateChiTietPhieuThue_DC(string maPhieu, string maDungCu_Odd, int soLuong, int donGia, string maDC_New)
        {
            string query = "UPDATE CT_PhieuThueDC SET maDungCu = @maDC_New,soLuong = @soLuong, donGia = @donGia WHERE maPhieu = @maPhieu AND maDungCu = @maDungCu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPhieu},
                {"@maDungCu", maDungCu_Odd},
                {"@soLuong", soLuong},
                {"@donGia", donGia},
                {"@maDC_New", maDC_New}
            };
            Connection.actionQuery(query, parameters);
        }
        public static void deleteCTPTDCByMaChiTietPhieuDatDC(string maDC, string maPDDC ) {
            string query = "DELETE FROM CT_PhieuThueDC WHERE maPhieu = @maPhieu AND maDungCu = @maDC";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maPhieu", maPDDC},
                {"@maDC", maDC }

            };
            Connection.actionQuery(query, parameters );
        }
        
        
    }
}
