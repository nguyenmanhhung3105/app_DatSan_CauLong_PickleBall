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
    public class HoaDonBLL
    {
        public static string addHoaDon(HoaDon hoaDon)
        {
            hoaDon.MaHoaDon = autoCreateMaHoaDon();
            HoaDonAccess.addHoaDon(hoaDon);
            return hoaDon.MaHoaDon;
        }
        public static DataTable getHoaDon(string maHD)
        {
            return HoaDonBLL.getHoaDon(maHD);
        }
        private static string autoCreateMaHoaDon() {
            if (HoaDonAccess.selectAllHoaDon().Rows.Count > 0) {
                return "HD00000001";
            }
            else
            {
                DataTable dt = HoaDonAccess.selectTop1HoaDon();
                string maHienTaiString = dt.Rows[0]["MaHoaDon"].ToString();
                string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
                int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
                string newPhieuDatSan = "HD" + tamSoCuoiIntPlussOne.ToString("D8");
                return newPhieuDatSan;
            }
        }
        public static DataTable selectAllHoaDon() { 
            return HoaDonAccess.selectAllHoaDon();
        }
        public static void capNhatTrangThai(string maHoaDon, string trangThai)
        {
            HoaDonAccess.CapnhatTrangThai(maHoaDon, trangThai);
        }
        public static DataTable layHoaDonTheoMa(string maHoaDon)
        {
            return HoaDonAccess.LayHoaDonTheoMa(maHoaDon);
        }
        public static void xoaHoaDon(string maHoaDon) {
            HoaDonAccess.XoaHoaDon(maHoaDon);
        }
        public static DataTable timKiemHoaDon(string tuKhoa)
        {
            return HoaDonAccess.TimKiemHoaDon(tuKhoa);
        }
        public static void upDateTongTienHoaDon(int maHoaDon, Voucher voucher)
        {
            HoaDonAccess.upDateTongTienHoaDon(maHoaDon, voucher);
        }
    }
}
