using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO;
using BLL;
using Guna.UI2.WinForms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
namespace GUI
{
    public partial class UC_Datlich : UserControl
    {
        public event Action<object, UserControl> SwitchUserControl;
        San san;
        public KhachHang khachHang;
        public bool daDatSan = false;
        public string tempMPDS = "";
        public string tempMPTDC = "";
        public UC_Datlich(San san)
        {
            InitializeComponent();
            lbl_GioDat.Parent = guna2PictureBox1;
            tb_GioDat.Parent = guna2PictureBox1;
            lb_ThoiLuong.Parent = guna2PictureBox1;
            cbb_ThoiLuong.Parent = guna2PictureBox1;
            pdt_NgayDat.Value = DateTime.Now;
            SetupTrackBar();
            loadDungCu();
            this.san = san;
            txt_TenSan.Text = san.tenSan;
            txt_LoaiSan.Text= san.loaiSan;
            List<string> danhSach = new List<string> { "30 phút", "60 phút", "90 phút", "120 phút"};
            cbb_ThoiLuong.DataSource = danhSach;
            cbb_ThoiLuong.SelectedIndex = -1;
            toolTip1.SetToolTip(this.tb_Ton, "Số lượng dụng cụ còn lại trong kho");
            daDatSan = false;
            tempMPDS = "";
            tempMPTDC = "";
        }
       
       
        private void SetupTrackBar()
        {
            tb_GioDat.Minimum = 360; // 0:00
            tb_GioDat.Maximum = 21 * 60 + 59; // 23:59
            tb_GioDat.Value = 360;
           

          

            tb_GioDat.Scroll += tb_GioDat_Scroll;
        }

        private void tb_GioDat_Scroll(object sender, ScrollEventArgs e)
        {
            int totalMinutes = tb_GioDat.Value;
            int hours = totalMinutes / 60; // Lấy giờ
            int minutes = totalMinutes % 60; // Lấy phút

            txt_GioDat.Text = $"{hours:D2}:{minutes:D2}";
        }

        private void loadDungCu()
        {
            DataTable dt = Kho_BLL.SelectAllDungCu();
            DataTable dtFilter = new DataTable();
            if (dt != null && dt.Rows.Count > 0 ) {
                dtFilter = dt.Clone();
                var filterRows = dt.AsEnumerable().Where(row => row.Table.Columns.Contains("soLuong") && row["soLuong"] != DBNull.Value && Convert.ToInt32(row["soLuong"]) > 0);
                foreach (var row in filterRows)
                {
                    dtFilter.ImportRow(row);
                }
                DataRow placeholder = dtFilter.NewRow();
                placeholder["maDungCu"] = "";
                placeholder["tenDungCu"] = "-- Đầu tiên hãy chọn dụng cụ thuê ở đây--";
                dtFilter.Rows.InsertAt(placeholder, 0);
                cb_TenDC.DataSource = dtFilter;
                cb_TenDC.DisplayMember = "tenDungCu";
                cb_TenDC.ValueMember = "maDungCu";
                cb_TenDC.SelectedIndex = 0;
                
            }
        }

        private void cb_TenDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_TenDC.SelectedIndex > 0)
            {
                nu_Soluong.Enabled = true;
                
                string maDC = cb_TenDC.SelectedValue.ToString();
                DataTable dt = Kho_BLL.selectDCByMaDC(maDC);
                if (dt != null && dt.Rows.Count > 0)
                {
                    tb_DonGia.Text = dt.Rows[0]["donGia"].ToString() + " VND/ 1 món";
                    lb_Mota.Text = dt.Rows[0]["moTa"].ToString();
                    tb_maSoDC.Text = dt.Rows[0]["maDungCu"].ToString();
                    SetDungCuImage(maDC);
                    tb_Ton.Text = Kho_BLL.getSoLuongKho(maDC).ToString();

                    nu_Soluong.Maximum = int.Parse(tb_Ton.Text);


                }    
            }
        }
        private void SetDungCuImage(string maDC)
        {

            string fixedMaDC = Regex.Replace(maDC, @"DC0*", "DC");

            string imagePath = $"./img/{fixedMaDC}.jpg";
            if (File.Exists(imagePath))
            {
                try
                {
                    pb_DungCu.Image = Image.FromFile(imagePath);
                    pb_DungCu.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu không thể tải ảnh
                    Console.WriteLine($"Lỗi tải ảnh: {ex.Message}");
                    // Có thể đặt một ảnh mặc định ở đây nếu muốn
                    // pb_DungCu.Image = Image.FromFile("./img/default.jpg");
                    pb_DungCu.Image = null; // Hoặc xóa ảnh nếu không tìm thấy
                }
            }
            else
            {
                // Xử lý trường hợp không tìm thấy ảnh
                Console.WriteLine($"Không tìm thấy ảnh cho mã DC: {maDC} tại đường dẫn: {imagePath}");
                // Có thể đặt một ảnh mặc định ở đây nếu muốn
                // pb_DungCu.Image = Image.FromFile("./img/default.jpg");
                pb_DungCu.Image = null; // Hoặc xóa ảnh nếu không tìm thấy
            }
        }
        
       
        private void btn_Dat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pdt_NgayDat.Text))
            {
                lb_ThongBao.Text = "Vui lòng chọn ngày đặt lịch";
                pdt_NgayDat.Focus();
                ClearThongBao();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_GioDat.Text))
            {
                lb_ThongBao.Text = "Vui lòng nhập giờ đặt lịch";
                txt_GioDat.Focus();
                ClearThongBao();
                return;
            }

            if (cbb_ThoiLuong.SelectedIndex == -1)
            {
                lb_ThongBao.Text = "Vui lòng chọn thời lượng";
                cbb_ThoiLuong.Focus();
                ClearThongBao() ;
                return;
            }
            
            string tenSan = txt_TenSan.Text;
            string maSan = tenSan.Replace("Sân ", "").Replace("-", "");

            DateTime thoigianDat = pdt_NgayDat.Value.Date;
            string[] giophutDat = txt_GioDat.Text.Split(':');
            int gio = int.Parse(giophutDat[0]);
            int phut = int.Parse(giophutDat[1]);
            thoigianDat = thoigianDat.AddHours(gio).AddMinutes(phut);
           
            if (thoigianDat.CompareTo(DateTime.Now) < 0) {
                int phutTre = (int)(DateTime.Now - thoigianDat).TotalMinutes;
                lb_ThongBao.Text = "Bạn yên tâm. Nếu là Doraemon mình sẽ chở bạn về " + phutTre + " phút trước để đặt lịch nhá.";
                tb_GioDat.Focus();
                ClearThongBao();
                return;
            }
            string selectedThoiLuong = cbb_ThoiLuong.SelectedItem?.ToString() ?? "0";
            int soPhut = int.Parse(selectedThoiLuong.Split(' ')[0]);
            DateTime thoiGianKT = thoigianDat.AddMinutes(soPhut);
            DateTime gioToiDa = new DateTime(thoigianDat.Year, thoigianDat.Month, thoigianDat.Day, 22, 0, 0);

            // Kiểm tra
            if (thoiGianKT > gioToiDa)
            {
                lb_ThongBao.Text = "Xin lỗi quý khách thời gian đó sân đã đóng cửa rồi ạ";
                ClearThongBao() ;
                return;
            }
            
            if (ChiTietPhieuDatSan_BLL.checkTrungGioDat(thoigianDat, thoiGianKT, maSan))
            {
                lb_ThongBao.Text = "Huhu! Bạn đã đăng ký trùng lịch rồi á. Vui lòng click vào 'Xem giá sân/Xem sân đã được đặt' để chọn thời gian sân trống nhé";
                btn_XemSan.Focus();
                ClearThongBao() ;
                return;
            }
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đặt lịch này không?",
            "Xác nhận Đặt lịch",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                string maPhieuDatSan = "";
                string maKH = khachHang.maKhachHang;
               
                string loaiSan = txt_LoaiSan.Text;
                DateTime ngayDatSan = pdt_NgayDat.Value.Date;
                int tongTien = 0;
                PhieuDatSan phieuDatSan = new PhieuDatSan(maPhieuDatSan, maKH, loaiSan, ngayDatSan, thoigianDat, thoiGianKT, tongTien);
                string maPhieuDatSan_ChiTietPhieuDatSan = PhieuDatSan_BLL.AddPhieuDatSan(phieuDatSan);
                tempMPDS = maPhieuDatSan_ChiTietPhieuDatSan;
                ChiTietPhieuDatSan_BLL.addChiTietPhieuDatSan(maPhieuDatSan_ChiTietPhieuDatSan, maSan, loaiSan);
                DialogResult re =  MessageBox.Show("Chúc mừng bạn đã đặt lịch thành công!\nBạn có muốn đặt thêm dụng cụ không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    pn_DatDungCu.Enabled = true;
                    pn_DatLich.Enabled = false;
                    dt_Dung_Cu_Thue.Enabled = true;
                    btn_Dat.Enabled = true;
                    btn_XoaDC.Enabled = false;
                    btn_CapNhatDC.Enabled = false;
                    nu_Soluong.Enabled = false;
                }
                else
                {
                    pn_DatDungCu.Enabled = false;
                    btn_ThanhToan.Enabled = true;
                }
                daDatSan = true;
            }
            
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_ThongBao.Text = "";
        }

        private int isEditing = -1;
        private void btn_Dat_DC_Click(object sender, EventArgs e)
        {
            
            btn_XoaDC.Enabled = false;
            btn_CapNhatDC.Enabled = false;
            string tenDC = cb_TenDC.Text;
            string maDC = tb_maSoDC.Text;
            int soLuong = (int)nu_Soluong.Value;
            int donGia = int.Parse(tb_DonGia.Text.Replace(" VND/ 1 món", ""));
            int soLuongKho = Kho_BLL.getSoLuongKho(maDC);
            int thanhTien = soLuong * donGia;
            string maPTDC = "";

            if (isEditing >= 0)
            {
                DataGridViewRow row = dt_Dung_Cu_Thue.Rows[isEditing];
                    string maDC_Odd = row.Cells[0].Value?.ToString();

                    maPTDC = row.Cells[5].Value?.ToString();
                    if (soLuongKho - soLuong < 0)
                    {
                        lb_ThongBao.Text = $"Xin lỗi quý khách dụng cụ {tenDC} chỉ còn lại: {soLuongKho}";
                        nu_Soluong.Focus();
                        ClearThongBao();
                        return;
                    }
                    else
                    {
                           DialogResult result = MessageBox.Show(
                            "Bạn có chắc chắn muốn sửa đổi không?",
                            "Xác nhận sửa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                        if(result == DialogResult.Yes)
                        {
                            CT_PhieuThue_DC_BLL.upDateChiTietPhieuThue_DC(maPTDC, maDC_Odd, soLuong, donGia, maDC);
                        row.Cells[0].Value = maDC;
                        row.Cells[1].Value = tenDC;
                        row.Cells[2].Value = soLuong;
                        row.Cells[3].Value = donGia;
                        row.Cells[4].Value = thanhTien;
                        bool capNhat = Kho_BLL.xuLySauKhiThemChiTiet(maDC, soLuong, false);
                            if (capNhat)
                            {
                                loadDungCu();
                                MessageBox.Show($"Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reload_DungCu();
                            }
                            else
                            {
                                Console.WriteLine("Lỗi load lại dụng cụ khi thêm ctdc");
                                MessageBox.Show($"Cập nhật thất bại cho dụng cụ '{tenDC}'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }



               
                
                isEditing = -1;
                reload_DungCu() ;
            }
            else
            {
                
                
             
                
                if (soLuongKho - soLuong < 0)
                {
                    lb_ThongBao.Text = $"Xin lỗi quý khách dụng cụ {tenDC} chỉ còn lại: {soLuongKho}";
                    nu_Soluong.Focus();
                    ClearThongBao();
                    return;
                }
                else
                {

                    DateTime thoigianDat = pdt_NgayDat.Value.Date;
                    string[] giophutDat = txt_GioDat.Text.Split(':');
                    int gio = int.Parse(giophutDat[0]);
                    int phut = int.Parse(giophutDat[1]);
                    thoigianDat = thoigianDat.AddHours(gio).AddMinutes(phut);
                    string maPDS = PhieuDatSan_BLL.selectTop1PDSForMKH(khachHang.maKhachHang).maPhieuDatSan;
                    PhieuThue_DC ptdc = PhieuThueDC_BLL.selectPTDCByPDS(maPDS);
                    CT_PhieuThue_DC cT_PhieuThue_DC;
                    if (ptdc != null)
                    {
                        cT_PhieuThue_DC = new CT_PhieuThue_DC(ptdc.maPhieuThueDC, maDC, maPDS, soLuong, donGia);
                        tempMPTDC = ptdc.maPhieuThueDC;
                    }
                    else
                    {
                        ptdc = new PhieuThue_DC(maPTDC, khachHang.maKhachHang, thoigianDat, 0, "Chưa thanh toán");
                        string maPTDC_maCTTDC = PhieuThueDC_BLL.addPhieuThueDC(ptdc);
                        tempMPTDC = maPTDC_maCTTDC;
                        cT_PhieuThue_DC = new CT_PhieuThue_DC(maPTDC_maCTTDC, maDC, maPDS, soLuong, donGia);
                    }
                    
                    CT_PhieuThue_DC_BLL.addChiTietPhieuThueDC(cT_PhieuThue_DC);
                    dt_Dung_Cu_Thue.Rows.Add(maDC, tenDC, soLuong, donGia.ToString("N0"), thanhTien.ToString("N0"), ptdc.maPhieuThueDC);
                    bool capNhat = Kho_BLL.xuLySauKhiThemChiTiet(maDC, soLuong, false);
                    if (capNhat)
                    {
                        loadDungCu();
                        MessageBox.Show($"Đặt dụng cụ '{tenDC}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Console.WriteLine("Lỗi load lại dụng cụ khi them ctdc");
                    }
                    reload_DungCu();
                }
            }
            btn_ThanhToan.Enabled = true;
        }
           

        private void btn_XoaDC_Click(object sender, EventArgs e)
        {
            
            if (dt_Dung_Cu_Thue.SelectedRows.Count > 0) { 
                List<(string maDC, string maPDDC)> list = new List<(string, string)>();
                foreach (DataGridViewRow selectedRow in dt_Dung_Cu_Thue.SelectedRows) {
                    if (selectedRow.Cells["ID"].Value != null && selectedRow.Cells["maPTDC"].Value != null)
                    {
                        string maDC = selectedRow.Cells["ID"].Value.ToString();
                        string maPTDC = selectedRow.Cells["maPTDC"].Value.ToString();
                        list.Add((maDC, maPTDC));
                    }
                }
                if (list.Count > 0) { 
                    string message = $"Bạn có chắc chắn muốn xóa {list.Count} dụng cụ đã chọn không?";
                    if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                        int success = 0;
                        string maPTDC = "";
                        foreach (var idToDel in list.ToList()) {
                            CT_PhieuThue_DC_BLL.deleteCTPTDCByMaChiTietPhieuDatDC(idToDel.maDC, idToDel.maPDDC);
                            var rowToDelete = dt_Dung_Cu_Thue.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => row.Cells["ID"].Value?.ToString() == idToDel.maDC && row.Cells["maPTDC"].Value?.ToString() == idToDel.maPDDC);
                            if (rowToDelete != null)
                            {
                                string maDC = rowToDelete.Cells["ID"].Value.ToString();
                                int soLuong = Convert.ToInt32(rowToDelete.Cells["so_Luong"].Value);
                                maPTDC = rowToDelete.Cells["maPTDC"].Value.ToString();
                                dt_Dung_Cu_Thue.Rows.Remove(rowToDelete);
                                success++;
                                bool capNhat = Kho_BLL.xuLySauKhiThemChiTiet(maDC, soLuong, true);
                                if (capNhat)
                                {
                                    loadDungCu();
                                }
                                else
                                {
                                    Console.WriteLine("Lỗi load lại dụng cụ khi them ctdc");
                                    return;
                                }
                            }
                        }

                        MessageBox.Show($"Xóa thành công {success} dụng cụ đã đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(dt_Dung_Cu_Thue.Rows.Count == 0)
                        {
                            if (!string.IsNullOrEmpty(maPTDC))
                            {
                                tempMPTDC = "";
                                bool xoaPhieu = PhieuThueDC_BLL.deletePhieuThueDungCu(maPTDC);
                                if (xoaPhieu) {
                                    MessageBox.Show("Đã xóa hết dụng cụ và phiếu thuê dụng cụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    Console.WriteLine("Không thể xóa phiếu thuê dụng cụ");
                                }
                            }
                        }
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_XoaDC.Enabled = false;
            btn_CapNhatDC.Enabled = false;
            btn_Dat.Enabled = true;

        }

        private void dt_Dung_Cu_Thue_SelectionChanged(object sender, EventArgs e)
        {
            if (dt_Dung_Cu_Thue.SelectedRows.Count > 0)
            {
                btn_Dat_DC.Enabled = false;
                DataGridViewRow selectedRow = dt_Dung_Cu_Thue.SelectedRows[0];
                bool hasData = false;

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString().Trim()))
                    {
                        hasData = true;
                        break; // Tìm thấy dữ liệu, không cần kiểm tra thêm
                    }
                    else { btn_Dat_DC.Enabled = true; }
                }

                btn_XoaDC.Enabled = hasData;
                btn_CapNhatDC.Enabled = hasData;
            }
            else
            {
                btn_XoaDC.Enabled = false;
                btn_CapNhatDC.Enabled = false;
                btn_Dat_DC.Enabled = true;
            }
        }

        private void btn_CapNhatDC_Click(object sender, EventArgs e)
        {
            btn_Dat_DC.Enabled = true;
            btn_CapNhatDC.Enabled = false;
            btn_XoaDC.Enabled = false;
            if (dt_Dung_Cu_Thue.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dt_Dung_Cu_Thue.SelectedRows[0];
                isEditing = selectedRow.Index;
                if (dt_Dung_Cu_Thue.Rows[isEditing].IsNewRow) ;
                

                tb_maSoDC.Text = selectedRow.Cells["ID"].Value.ToString();
                cb_TenDC.Text = selectedRow.Cells["ten_DC"].Value.ToString();
                nu_Soluong.Value = Convert.ToInt32(selectedRow.Cells["so_Luong"].Value);
                tb_DonGia.Text = selectedRow.Cells["don_Gia"].Value.ToString();
                tb_Ton.Text = Kho_BLL.getSoLuongKho(selectedRow.Cells["ID"].Value.ToString()).ToString();
                SetDungCuImage(selectedRow.Cells["ID"].Value.ToString());
                
            }
        }
        private void reload_DungCu()
        {
            pb_DungCu.Image = null;
            lb_Mota.Text = "Mô tả";
            tb_maSoDC.Text = string.Empty;
            nu_Soluong.Value = nu_Soluong.Minimum;
            tb_DonGia.Text = string.Empty;
            
        }

        private void btn_XemSan_Click(object sender, EventArgs e)
        {
            GiaSan_SanBiDat giaSan_SanBiDat = new GiaSan_SanBiDat(this);
            giaSan_SanBiDat.SwitchUserControl += SwitchUserControl;
            SwitchUserControl?.Invoke(this, giaSan_SanBiDat);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thanh toán?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PhieuDatSan pds = PhieuDatSan_BLL.selectTop1PDSForMKH(khachHang.maKhachHang);
                PhieuThue_DC ptdc = PhieuThueDC_BLL.selectTop1PTDCForMKH(khachHang.maKhachHang, pds.maPhieuDatSan);
                if(ptdc != null)
                {
                    PhieuThueDC_BLL.upDateTongTienThueDungCu(ptdc.maPhieuThueDC);
                }
                
                
                PhieuDatSan_BLL.upDateTongTienPhieuDatSanByMaPhieuDatSan(pds.maPhieuDatSan);
                UC_ThanhToan uC_ThanhToan = new UC_ThanhToan(khachHang);
                uC_ThanhToan.SwitchUserControl += SwitchUserControl;
                SwitchUserControl?.Invoke(this, uC_ThanhToan);
            }
        }
    }
}
