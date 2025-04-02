using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Kho
    {
        public string maDungCu {  get; set; }
        public string tenDungCu { get; set; }
        public string loaiDungCu { get; set; }
        public int soLuong {  get; set; }
        public int donGia {  get; set; }
        public string moTa { get; set; }
        public Kho(string maDungCu, string tenDungcu, string loaiDungCu, int soLuong, int donGia, string moTa)
        {
            this.maDungCu = maDungCu;
            this.tenDungCu = tenDungCu;
            this.loaiDungCu = loaiDungCu;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.moTa = moTa;
        }

    }
}
