using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaPhieuDatSan { get; set; }
        public string MaPhieuThueDC { get; set; } // Có thể null nếu không thuê dụng cụ
        public string MaKhachHang { get; set; }

        public DateTime NgayThanhToan { get; set; }
        public int TongTien { get; set; }
        public string Email { get; set; }
        public string PhuongThuc { get; set; }
        public string TrangThai { get; set; }  // Đã thanh toán, Chờ xác nhận,...
        public string GhiChu { get; set; }
        public string DuongDanHoaDonPDF { get; set; }
        public string MaVoucher { get; set; }
        public HoaDon(string maHoaDon, string maPhieuDatSan, string maPhieuThueDC, string maKhachHang, string email,DateTime ngayThanhToan,
                     int tongTien, string phuongThuc, string trangThai, string ghiChu, string duongDanHoaDonPDF, string maVoucher)
        {
            MaHoaDon = maHoaDon;
            MaPhieuDatSan = maPhieuDatSan;
            MaPhieuThueDC = maPhieuThueDC;
            MaKhachHang = maKhachHang;
            Email  = email;
            NgayThanhToan = ngayThanhToan;
            TongTien = tongTien;
            PhuongThuc = phuongThuc;
            TrangThai = trangThai;
            GhiChu = ghiChu;
            DuongDanHoaDonPDF = duongDanHoaDonPDF;
            MaVoucher = maVoucher;
        }
    }
}
