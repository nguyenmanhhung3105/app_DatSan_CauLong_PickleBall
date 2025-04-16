using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatSan
    {
        public string maPhieuDatSan {  get; set; }
        public string maKhachHang {  get; set; }
        
        public string loaiSan {  get; set; }
        public DateTime ngayDatSan { get; set; }
        public DateTime thoiGianDat {  get; set; }
        public DateTime thoiGianKT { get; set; }
        public int tongTien {  get; set; }
        public string trangThai { get; set; }
        public PhieuDatSan(string maPhieuDatSan, string maKhachHang, string loaiSan, DateTime ngayDatSan, DateTime thoiGianDat, DateTime thoiGianKT, int tongTien)
        {
            this.maPhieuDatSan = maPhieuDatSan;
            this.maKhachHang = maKhachHang;
            
            this.loaiSan = loaiSan;
            this.ngayDatSan = ngayDatSan;
            this.thoiGianDat = thoiGianDat;
            this.thoiGianKT = thoiGianKT;
            this.tongTien = tongTien;
            this.trangThai = "Chưa thanh toán";
        }
    }
    
}
