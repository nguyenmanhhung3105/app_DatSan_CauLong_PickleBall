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
    public class VoucherBLL
    {
        public static void addVoucher(Voucher voucher)
        {
            VoucherAccess.addVoucher(voucher);
        }
        public static void updateVoucher(Voucher voucher) { 
            VoucherAccess.UpdateVoucher(voucher);
        }
        public static void deleteVoucher(string maVoucher) { 
            VoucherAccess.deleteVoucher(maVoucher);
        }
        public static void xoaVoucherHetHan()
        {
            VoucherAccess.xoaVoucherHetHan();
        }
        public static DataTable getAllVoucher() { 
            return VoucherAccess.getAllVoucher();
        }
        public static bool capVoucherChoKH(string maVoucher, string maKhachHang, int soLuong)
        {
            return VoucherBLL.capVoucherChoKH(maVoucher, maKhachHang, soLuong);
        }
    }
}
