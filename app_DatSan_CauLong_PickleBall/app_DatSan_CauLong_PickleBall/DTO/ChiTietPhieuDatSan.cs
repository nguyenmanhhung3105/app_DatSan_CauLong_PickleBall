using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuDatSan
    {
        public string maPhieuDatSan {  get; set; }
        public string maSan {  get; set; }
        public int donGia {  get; set; }
        public ChiTietPhieuDatSan(string maPhieuDatSan, string maSan, int donGia)
        {
            this.maPhieuDatSan = maPhieuDatSan;
            this.maSan = maSan;
            this.donGia = donGia;
        }
    }
}
