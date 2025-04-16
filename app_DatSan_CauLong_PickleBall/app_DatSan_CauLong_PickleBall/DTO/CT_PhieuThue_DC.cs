using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PhieuThue_DC
    {
        public string maPhieuThueDC {  get; set; }
        public string maDungCu {  get; set; }
        public string maPhieuDatSan { get; set; }
        public int soLuong {  get; set; }
        public int donGia { get; set; }
        public int thanhTien { get; set; }
        public CT_PhieuThue_DC() { 
            this.maPhieuThueDC = string.Empty;
            this.maDungCu = string.Empty;
            this.maPhieuDatSan = string.Empty;
            this.soLuong = 0;
            this.donGia = 0;
            this.thanhTien = 0;
        }
        public CT_PhieuThue_DC(string maPhieuThueDC, string maDungCu, string maPhieuDatSan, int soLuong, int donGia)
        {
            this.maPhieuThueDC = maPhieuThueDC;
            this.maDungCu = maDungCu;
            this.maPhieuDatSan = maPhieuDatSan;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = this.soLuong * this.donGia;
        }
    }
}
