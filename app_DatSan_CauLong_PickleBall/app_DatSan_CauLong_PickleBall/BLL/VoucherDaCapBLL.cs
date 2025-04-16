using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class VoucherDaCapBLL
    {
        public static bool upDateTrangThaiVoucherDaCap(string maVoucher, string maKH)
        {
            return VoucherDaCapAccess.upDateTrangThaiVoucherDaCap(maVoucher, maKH);
        }
        public static bool xoaVoucherDaCapHetHan()
        {
            return VoucherDaCapAccess.xoaVoucherDaCapHetHan();
        }
        public static DataTable getVoucherDaCapForKhachHang(string maKhachHang)
        {
            return VoucherDaCapAccess.getVoucherDaCapByKhachHang(maKhachHang);
        }
        public static DataTable getVoucherConDungDuoc(string maKH)
        {
            return VoucherDaCapAccess.getVoucherConDungDuoc(maKH);
        }
    }
}
