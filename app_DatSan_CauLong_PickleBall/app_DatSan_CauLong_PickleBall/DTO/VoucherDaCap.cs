using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VoucherDaCap
    {
        public string MaVoucher { get; set; }
        public string MaKhachHang { get; set; }
        public string TrangThai { get; set; }
        public int SoLuongConLai { get; set; }
        public VoucherDaCap() { }
        public VoucherDaCap(string maVoucher, string maKH, string trangThai, int soLuong)
        {
            MaVoucher = maVoucher;
            MaKhachHang = maKH;
            TrangThai = trangThai;
            SoLuongConLai = soLuong;
        }
    }
}
