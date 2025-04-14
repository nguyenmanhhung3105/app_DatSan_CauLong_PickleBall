using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class UC_ThanhToan : UserControl
    {
        KhachHang khachHang;
        PhieuDatSan phieuDatSan;
        PhieuThue_DC phieuThue_DC;
        public UC_ThanhToan(KhachHang khachHang)
        {
            InitializeComponent();
            this.khachHang = khachHang;
            phieuDatSan = PhieuDatSan_BLL.selectTop1PDSForMKH(khachHang.maKhachHang);
            phieuThue_DC = PhieuThueDC_BLL.selectTop1PTDCForMKH(khachHang.maKhachHang, phieuDatSan.maPhieuDatSan);
            txt_TenSan.Text = PhieuDatSan_BLL.layTenSanByMaPDS(phieuDatSan.maPhieuDatSan).ToString();
            tb_TenKH.Text = khachHang.tenKhachHang.ToString();
            tb_SODT.Text = khachHang.soDienThoai.ToString();
            tb_email.Text = khachHang.email.ToString();
            txt_LoaiSan.Text = phieuDatSan.loaiSan.ToString();
            pdt_NgayDat.Value = phieuDatSan.ngayDatSan;
            tb_TGBD.Text = phieuDatSan.thoiGianDat.ToString("HH:mm");
            tb_TGKT.Text = phieuDatSan.thoiGianKT.ToString("HH:mm");
            tb_TienDatSan.Text = PhieuDatSan_BLL.tinhPhieuDatSanKhongCoDC(phieuDatSan.maPhieuDatSan).ToString("N0");
            if (phieuThue_DC != null)
            {
                Console.WriteLine(phieuThue_DC.maPhieuThueDC);
                tb_DungCu.Enabled = true;
                tb_DungCu.Text = PhieuThueDC_BLL.layDanhSachTenDungCu(phieuDatSan.maPhieuDatSan);
                tb_TienDC.Text = phieuThue_DC.tongTien.ToString("N0") + " VNĐ";
            }
            else { 
                tb_DungCu.Clear();
                tb_DungCu.Enabled=false;  
            }

            loadVoucher(khachHang.maKhachHang);

            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            tb_TongCong.Text = phieuDatSan.tongTien.ToString("N0") + " VNĐ";
            
        }
        public void loadVoucher(string maKH)
        {
            VoucherDaCapBLL.xoaVoucherDaCapHetHan();
            DataTable dt = VoucherDaCapBLL.getVoucherConDungDuoc(maKH);
            if (dt.Rows.Count == 0)
            {
                cbVoucher.Items.Clear();
                cbVoucher.Items.Add("Không có voucher khả dụng");
                cbVoucher.SelectedIndex = 0;
                cbVoucher.Enabled = false;
            }
            else
            {
                cbVoucher.DataSource = dt;
                DataRow placeholder = dt.NewRow();
                placeholder["MaVoucher"] = "";
                
                dt.Rows.InsertAt(placeholder, 0);
                placeholder["HienThi"] = "-- Không sử dụng voucher --";
                cbVoucher.DisplayMember = "HienThi";
                cbVoucher.ValueMember = "MaVoucher";
                cbVoucher.SelectedIndex = 0;
            }
            
            
        }
        private void tb_DungCu_MouseHover(object sender, EventArgs e)
        {
            if(!tb_DungCu.Enabled) return;
            tb_DC_tooltip.SetToolTip(tb_DungCu, tb_DungCu.Text);
            string maPhieu = phieuDatSan.maPhieuDatSan;
            DataTable dt = CT_PhieuThue_DC_BLL.getChiTietPhieuThueDCByMaPhieuThueDC(phieuThue_DC.maPhieuThueDC);
            dt_Dung_Cu_Thue.DataSource = dt;
            Point screenPoint = tb_DungCu.PointToScreen(Point.Empty);
            
            dt_Dung_Cu_Thue.Visible = true;
            dt_Dung_Cu_Thue.BringToFront();
            
        }
        

        private void tb_DungCu_MouseLeave(object sender, EventArgs e)
        {
            if(tb_DungCu.Enabled)return;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);
            if (!tb_DungCu.Bounds.Contains(mousePos) && !dt_Dung_Cu_Thue.Bounds.Contains(mousePos))
            {
                dt_Dung_Cu_Thue.Visible = false;
                timer1.Stop();
            }
        }

        private void dt_Dung_Cu_Thue_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public event Action<object, UserControl> SwitchUserControl;
        private void btn_Dat_Click(object sender, EventArgs e)
        {
            UC_ChuyenKhoan uC_ChuyenKhoan = new UC_ChuyenKhoan();
            SwitchUserControl?.Invoke(this, uC_ChuyenKhoan);
        }
    }
}
