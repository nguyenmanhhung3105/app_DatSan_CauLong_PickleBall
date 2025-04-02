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
namespace GUI
{
    public partial class UC_Datlich : UserControl
    {
        San san;
        public UC_Datlich(San san)
        {
            InitializeComponent();
            lbl_GioDat.Parent = guna2PictureBox1;
            tb_GioDat.Parent = guna2PictureBox1;
            lb_ThoiLuong.Parent = guna2PictureBox1;
            cbb_ThoiLuong.Parent = guna2PictureBox1;
            guna2PictureBox3.Parent = guna2Panel3;
            lb_ThongBao.Parent = guna2PictureBox3;
            SetupTrackBar();
            loadDungCu();
            this.san = san;
            txt_TenSan.Text = san.tenSan;
            txt_LoaiSan.Text= san.loaiSan;
            List<string> danhSach = new List<string> { "30 phút", "60 phút", "90 phút"};
            cbb_ThoiLuong.DataSource = danhSach;
            cbb_ThoiLuong.SelectedIndex = -1;
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
            if (dt.Rows.Count > 0) {
                DataRow placeholder = dt.NewRow();
                placeholder["maDungCu"] = "";
                placeholder["tenDungCu"] = "-- Đầu tiên hãy chọn dụng cụ thuê ở đây--";
                dt.Rows.InsertAt(placeholder, 0);
                cb_TenDC.DataSource = dt;
                cb_TenDC.DisplayMember = "tenDungCu";
                cb_TenDC.ValueMember = "maDungCu";
                cb_TenDC.SelectedIndex = 0;
            }
        }

        private void cb_TenDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_TenDC.SelectedIndex > 0)
            {
                string tenDC = cb_TenDC.Text;
                string maDC = cb_TenDC.SelectedValue.ToString();
                DataTable dt = Kho_BLL.selectDCByMaDC(maDC);
                tb_DonGia.Text = dt.Rows[0]["donGia"].ToString() + " VND/ 1 món";
                string path = "";

                if (maDC == "DC01")
                {
                    path = "./img/DC1.jpg";
                }
                else if(maDC == "DC02")
                {
                    path = "./img/DC2.jpg";
                }
                else if (maDC == "DC03")
                {
                    path = "./img/DC3.jpg";
                }
                else if (maDC == "DC04")
                {
                    path = "./img/DC4.jpg";
                }
                else if (maDC == "DC05")
                {
                    path = "./img/DC5.jpg";
                }
                else if (maDC == "DC06")
                {
                    path = "./img/DC6.png";
                }
                else if (maDC == "DC07")
                {
                    path = "./img/DC7.jpg";
                }
                else if (maDC == "DC08")
                {
                    path = "./img/DC8.jpg";
                }
                else if (maDC == "DC09")
                {
                    path = "./img/DC9.jpg";
                }
                pb_DungCu.Image = Image.FromFile(path);
                pb_DungCu.SizeMode = PictureBoxSizeMode.Zoom;
                lb_Mota.Text = dt.Rows[0]["moTa"].ToString();
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
            DateTime thoigianDat = pdt_NgayDat.Value.Date;
            string[] giophutDat = txt_GioDat.Text.Split(':');
            int gio = int.Parse(giophutDat[0]);
            int phut = int.Parse(giophutDat[1]);
            thoigianDat = thoigianDat.AddHours(gio).AddMinutes(phut);
            DateTime thoiGianKT = thoigianDat.AddMinutes(Convert.ToInt32(cbb_ThoiLuong.SelectedItem));
            if (thoigianDat.CompareTo(DateTime.Now) < 0) {
                int phutTre = (int)(DateTime.Now - thoigianDat).TotalMinutes;
                lb_ThongBao.Text = "Bạn yên tâm. Nếu là Doraemon mình sẽ chở bạn về " + phutTre + " phút trước để đặt lịch nhá.";
                tb_GioDat.Focus();
                ClearThongBao();
            }
            
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            lb_ThongBao.Text = "";
        }
     
    }
}
