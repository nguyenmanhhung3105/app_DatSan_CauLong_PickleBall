using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Voucher
    {
        public string MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public decimal GiaTriGiam { get; set; }
        public string KieuGiam {  get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string DieuKienApDung { get; set; } 
        public int SoLuong { get; set; }
     
        public Voucher(string maVoucher, string tenVoucher, decimal giaTriGiam, string kieuGiam, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKienApDung, int soLuong, string moTa)
        {
            MaVoucher = maVoucher;
            TenVoucher = tenVoucher;
            GiaTriGiam = giaTriGiam;
            KieuGiam = kieuGiam;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DieuKienApDung = dieuKienApDung;
            SoLuong = soLuong;
           
        }
    }
}
