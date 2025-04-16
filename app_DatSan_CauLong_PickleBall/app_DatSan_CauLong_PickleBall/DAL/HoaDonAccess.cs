using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDonAccess
    {
        public static DataTable getHoaDon(string maHD)
        {   
            string query = @"
                SELECT hd.MaHoaDon,
                        kh.TenKhachHang,
                        kh.soDienThoai,
                        kh.email,
                        s.tenSan,
                        pds.thoiGianDat,
                        pds.thoiGianKetThuc,
                        ct.giaSanTheoPhut,
                        DATEDIFF(MINUTE, pds.thoiGianDat, pds.thoiGianKetThuc) * ct.giaSanTheoPhut AS ThanhTienSan,
                        ISNULL(k.tenDungCu,N'Không thuê'),                        
                        ISNULL(ctdc.soLuong,0) AS SoLuong,
                        ISNULL(k.DonGia, 0)AS DonGia,
                        
                        ISNULL(ctdc.thanhTien, 0) AS ThanhTienDC,
                       
                        pds.tongtien,
                        ISNULL(v.MaVoucher, N'Không sử dụng') AS MaVoucher,
                        ISNULL(V.TenVoucher, N'Không sử dụng') AS TenVoucher                        
                        ISNULL(v.GiaTriGiam, 0) AS GiaTriGiam,
                        ISNULL(v.KieuGiam, N'') AS KieuGiam,
                        ISNULL(hd.GhiChu, N'') AS GhiChu
                FROM HoaDon hd
                JOIN KhachHang kh ON hd.MaKhachHang = kh.maKhachHang
                JOIN PhieuDatSan pds ON hd.MaPhieuDatSan = pds.maPhieuDatSan
                JOIN ChiTietPhieuDatSan ct ON pds.maPhieuDatSan = ct.maPDS
                JOIN San s ON ct.maSan = s.maSan
                
                LEFT JOIN PhieuThueDC ptdc ON hd.MaPhieuThueDC = ptdc.maPhieu
                LEFT JOIN CT_PhieuThueDC ctdc ON ptdc.maPhieu = ctdc.maPhieu
                LEFT JOIN Kho k ON ctdc.maDungCu= k.maDungCu
                LEFT JOIN Voucher v on hd.MaVoucher = v.maVoucher
                WHERE hd.MaHoaDon = @maHoaDon
            ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@maHoaDon", maHD} 
            };
            return Connection.selectQuery(query, parameters);
        }
        public static void addHoaDon(HoaDon hoaDon)
        {
            hoaDon.MaHoaDon = autoGenerateMaHoaDon();
            string query = "INSERT INTO HoaDon (MaHoaDon, MaPhieuDatSan, MaPhieuThueDC, MaKhachHang, NgayThanhToan, TongTien, PhuongThuc, TrangThai, EmailKhachHang, GhiChu, DuongDanHoaDonPDF, MaVoucher) VALUES(@MaHoaDon, @MaPhieuDatSan, @MaPhieuThueDC, @MaKhachHang, @NgayThanhToan, @TongTien, @PhuongThuc, @TrangThai, @Email, @GhiChu, @DuongDanHoaDonPDF, @maVoucher)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@MaHoaDon",  hoaDon.MaHoaDon},
                {"@MaPhieuDatSan", hoaDon.MaPhieuDatSan },
                {"@MaPhieuThueDC", hoaDon.MaPhieuThueDC != null ? (object)hoaDon.MaPhieuThueDC : DBNull.Value},
                {"@MaKhachHang", hoaDon.MaKhachHang },
                {"@NgayThanhToan", hoaDon.NgayThanhToan },
                {"@TongTien", hoaDon.TongTien },
                { "@PhuongThuc", hoaDon.PhuongThuc},
                {"@TrangThai", hoaDon.TrangThai },
                {"@Email", hoaDon.Email },
                { "@GhiChu",hoaDon.GhiChu != null ? (object)hoaDon.GhiChu : DBNull.Value},
                {"@DuongDanHoaDonPDF",  hoaDon.DuongDanHoaDonPDF },
                {"@maVoucher", hoaDon.MaVoucher != null ? (object)hoaDon.MaVoucher : DBNull.Value}
                
            };
            Connection.actionQuery(query, parameters);
        }
        public static DataTable selectAllHoaDon()
        {
            string query = "SELECT * FROM HoaDon";
            return Connection.selectQuery(query);
        }
        public static DataTable selectTop1HoaDon()
        {
            string query = "SELECT TOP 1* FROM HoaDon ORDER BY CAST(RIGHT(MaHoaDon, 8) AS bigint) DESC";
            return Connection.selectQuery(query);
        }
        public static string autoGenerateMaHoaDon()
        {
            DataTable dt = selectTop1HoaDon();
            if (dt.Rows.Count > 0) {
                string lastCode = dt.Rows[0]["MahoaDon"].ToString();
                int so = int.Parse(lastCode.Substring(2));
                return "HD" + (so + 1).ToString("D8");
            }
            else
            {
                return "HD00000001";
            }
        }
        public static void CapnhatTrangThai(string maHoaDon, string trangThai)
        {
            string query = "UPDATE HoaDon SET TrangThai = @TrangThai WHERE MaHoaDon = @MaHoaDon";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                 {"@TrangThai", trangThai},
                 {"@MaHoaDon", maHoaDon}
            };
            Connection.actionQuery(query, parameters);
        }
        
        public static DataTable LayHoaDonTheoMa(string maHoaDon)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@MaHoaDon", maHoaDon}
    };

            return Connection.selectQuery(query, parameters);
        }
        public static void XoaHoaDon(string maHoaDon)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@MaHoaDon", maHoaDon}
    };

            Connection.actionQuery(query, parameters);
        }

        public static DataTable TimKiemHoaDon(string tuKhoa)
        {
            string query = @"SELECT * FROM HoaDon 
                     WHERE Email LIKE @TuKhoa OR 
                           PhuongThuc LIKE @TuKhoa OR 
                           GhiChu LIKE @TuKhoa";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@TuKhoa", "%" + tuKhoa + "%"}
    };

            return Connection.selectQuery(query, parameters);
        }
        public enum LoaiVoucher
        {
            PhanTram,
            TienMat,
            Khac
        }
        private  static int TinhTongTienSauVoucher(int tongTienGoc, Voucher voucher)
        {
            if (voucher == null) return tongTienGoc;

            if(voucher.KieuGiam == "PhanTram")
            {
                decimal giamGia = tongTienGoc * (voucher.GiaTriGiam / 100m);
                return (int)Math.Round(tongTienGoc - giamGia);
            }
            else if (voucher.KieuGiam == "TienMat"){
                return Math.Max(0, tongTienGoc - (int)voucher.GiaTriGiam);
            }
            else return tongTienGoc;
        }
        public static void upDateTongTienHoaDon(int maHoaDon, Voucher voucher)
        {
            string query = @"SELECT PDS.TongTien
        FROM HoaDon HD
        JOIN PhieuDatSan PDS ON HD.MaPhieuDatSan = PDS.maPhieuDatSan
        WHERE HD.MaHoaDon = @maHoaDon";
            Dictionary<string, object> paramGet = new Dictionary<string, object>
    {
        { "@maHoaDon", maHoaDon }
    };
            DataTable dt = Connection.selectQuery(query, paramGet);
            if (dt.Rows.Count == 0) return;
            int tongTienGoc = Convert.ToInt32(dt.Rows[0]["TongTien"]);
            int tongTienMoi = TinhTongTienSauVoucher(tongTienGoc, voucher);
            query = @"
        UPDATE HoaDon
        SET TongTien = @tongTienMoi,
            MaVoucher = @maVoucher
        WHERE MaHoaDon = @maHoaDon";

            Dictionary<string, object> paramUpdate = new Dictionary<string, object>
    {
        { "@tongTienMoi", tongTienMoi },
        { "@maHoaDon", maHoaDon },
        { "@maVoucher", string.IsNullOrEmpty(voucher.MaVoucher) ? DBNull.Value : (object)voucher.MaVoucher}
    };
            Connection.actionQuery(query, paramUpdate);
        }
    }
}
