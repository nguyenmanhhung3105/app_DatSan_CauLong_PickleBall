using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class ChiTietPhieuDatSan_BLL
    {
        public static void addChiTietPhieuDatSan(string maPDS, string maSan, string loaiSan)
        {
            int haiSoCuoi = int.Parse(maSan.Substring(maSan.Length - 2));
        
            ChiTietPhieuDatSanAccess.findSanToAddChiTietDatSan(maPDS, haiSoCuoi, loaiSan);
        }
        public static bool checkTrungGioDat(DateTime thoiGianDat, DateTime thoiGianKT, string maSan)
        {
            return ChiTietPhieuDatSanAccess.checkTrungGio(thoiGianDat, thoiGianKT, maSan);
        }
        public static DataTable XemLichSanBiDat(DateTime ngayXemLichSanBiDat)
        {
            return ChiTietPhieuDatSanAccess.xemLichSanBiDat(ngayXemLichSanBiDat);
        }
        public static void deleteChiTietPhieuDatSan(string maPDS)
        {
            ChiTietPhieuDatSanAccess.deleteChiTietDatSanByMaPDS(maPDS);
        }
    }
}
