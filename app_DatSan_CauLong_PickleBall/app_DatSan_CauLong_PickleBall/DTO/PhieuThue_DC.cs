using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThue_DC
    {
        public string maPhieuThueDC {  get; set; }
        public string maKhachHang {  get; set; }
        public DateTime ngayThue {  get; set; }
        public int tongTien { get; set; }
        public string trangThai {  get; set; }
        
        public PhieuThue_DC() { 
        
            this.maPhieuThueDC = string.Empty;
            this.maKhachHang = string.Empty;
            this.ngayThue=DateTime.Now;
            this.tongTien = 0;
            this.trangThai = string.Empty;
        }
        public PhieuThue_DC(string maPhieuThueDC, string maKhachHang, DateTime ngayThue, int tongTien, string trangThai)
        {
            this.maPhieuThueDC = maPhieuThueDC;
            this.maKhachHang = maKhachHang;
            this.ngayThue = ngayThue;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
        }
    }
}
