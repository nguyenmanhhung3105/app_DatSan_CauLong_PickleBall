using BLL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DatSan : Form
    {
        private Software softwareInstance;
        public DatSan(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void comboBox_LoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LoaiSan.SelectedIndex == 0)
            {
                comboBox_ChonSan.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    comboBox_ChonSan.Items.Add("Sân " + i.ToString());
                }
                comboBox_ChonSan.SelectedIndex = 0;
            }
            if (comboBox_LoaiSan.SelectedIndex == 1)
            {
                comboBox_ChonSan.Items.Clear();
                for (int i = 1; i <= 12; i += 3)
                {
                    comboBox_ChonSan.Items.Add("Sân " + i + "-" + (i + 1) + "-" + (i + 2));
                }
                comboBox_ChonSan.SelectedIndex = 0;
            }
            if (comboBox_LoaiSan.SelectedIndex == 2)
            {
                comboBox_ChonSan.Items.Clear();
                comboBox_ChonSan.Items.Add("Sân 4-5-6-7-8-9-10-11-12");
                comboBox_ChonSan.SelectedIndex = 0;
            }
        }

        private void comboBox_ChonSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(label_San1);
            arrayList.Add(label_San2);
            arrayList.Add(label_San3);
            arrayList.Add(label_San4);
            arrayList.Add(label_San5);
            arrayList.Add(label_San6);
            arrayList.Add(label_San7);
            arrayList.Add(label_San8);
            arrayList.Add(label_San9);
            arrayList.Add(label_San10);
            arrayList.Add(label_San11);
            arrayList.Add(label_San12);

            foreach (Label label in arrayList)
            {
                label.ForeColor = Color.White;
            }

            if (comboBox_LoaiSan.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (comboBox_ChonSan.SelectedIndex == i)
                    {
                        ((Label)arrayList[i]).ForeColor = Color.Red; break;
                    }
                }
            }
            if (comboBox_LoaiSan.SelectedIndex == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox_ChonSan.SelectedIndex == i)
                    {
                        ((Label)arrayList[i * 3]).ForeColor = Color.Red;
                        ((Label)arrayList[i * 3 + 1]).ForeColor = Color.Red;
                        ((Label)arrayList[i * 3 + 2]).ForeColor = Color.Red;
                    }
                }
            }
            if (comboBox_LoaiSan.SelectedIndex == 2)
            {
                for (int i = 3; i < 12; i++)
                {
                    ((Label)arrayList[i]).ForeColor = Color.Red;
                }
            }
        }

        private void button_DatSan_Click(object sender, EventArgs e)
        {
            if (!softwareInstance.isLoged)
            {
                label_ThongBao.Text = "Chưa đăng nhập, vui lòng vào mục Tài Khoản để đăng nhập";
                ClearThongBao();
                return;
            }
            if (softwareInstance.isAdmin)
            {
                label_ThongBao.Text = "Chỉ khách hàng mới đặt sân";
                ClearThongBao();
                return;
            }
            if (comboBox_LoaiSan.SelectedIndex == -1 || comboBox_GioDa.SelectedIndex == -1 || comboBox_SoPhutDa.SelectedIndex == -1 || comboBox_ChonSan.SelectedIndex == -1)
            {
                label_ThongBao.Text = "Bạn chưa nhập đủ thông tin đặt sân";
                ClearThongBao();
                return;
            }
            DateTime thoiGianDa = dateTimePicker_NgayDa.Value.Date;
            string[] gioPhut = comboBox_GioDa.SelectedItem.ToString().Split(':');
            int gio = int.Parse(gioPhut[0]);
            int phut = int.Parse(gioPhut[1]);
            thoiGianDa = thoiGianDa.AddHours(gio).AddMinutes(phut);
            DateTime thoiGianKetThuc = thoiGianDa.AddMinutes(Convert.ToInt32(comboBox_SoPhutDa.SelectedItem));

            if (thoiGianDa.CompareTo(DateTime.Now) < 0)
            {
                label_ThongBao.Text = "Thời điểm đá đã qua, vui lòng xem lại";
                ClearThongBao();
                return;
            }

            //Kiểm tra dữ liệu theo ngày đá, giờ đá, đá trong bao lâu coi có trùng không
            if (ChiTietPhieuDatSan_BLL.CheckTrungGioDa(thoiGianDa, thoiGianKetThuc, GetListSanBong()))
            {
                label_ThongBao.Text = "Đã đăng ký trùng lịch, vui lòng chọn lịch trống";
                ClearThongBao();
                return;
            }


            if (!SanBong_BLL.CheckSanBongTonTaiByList(GetListSanBong()))
            {
                label_ThongBao.Text = "Không thể đặt sân, vui lòng liên hệ quản lý Sân Bóng để biết chi tiết";
                ClearThongBao();
                return;
            }
            string maPhieuDatSan = "";
            string maKhachHang = softwareInstance.khachHang.maKhachHang;
            string maQuanLy = "AD001";
            int loaiSan = Convert.ToInt32(comboBox_LoaiSan.SelectedItem);
            DateTime ngayDatSan = DateTime.Now;
            int tongTien = 0;

            // Giả sử thoiGianDa và thoiGianKetThuc đã được khai báo và gán giá trị từ trước
            PhieuDatSan phieuDatSan = new PhieuDatSan(maPhieuDatSan, maKhachHang, maQuanLy, loaiSan, ngayDatSan, thoiGianDa, thoiGianKetThuc, tongTien);

            // Thực hiện thêm phiếu đặt sân
            string maPhieuDatSan_ChiTietPhieuDatSan = PhieuDatSan_BLL.AddPhieuDatSan(phieuDatSan);

            // Thêm chi tiết phiếu đặt sân
            ChiTietPhieuDatSan_BLL.AddChiTietPhieuDatSan(maPhieuDatSan_ChiTietPhieuDatSan, GetListSanBong());

            label_ThongBao.Text = "Đặt sân thành công, bạn có thể xem lại phiếu đặt sân trong mục Tài Khoản";

            // Xóa thông báo sau một khoảng thời gian hoặc một điều kiện nào đó
            ClearThongBao();

        }

        private List<int> GetListSanBong()
        {
            string chonSan = comboBox_ChonSan.Text;
            string[] split = chonSan.Replace("Sân ", "").Split('-');
            List<int> list = new List<int>();
            list = Array.ConvertAll(split, int.Parse).ToList();
            return list;
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            label_ThongBao.Text = "";
        }


        private void button_KhungGioDaBiDat_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(new XemKhungGioBiDat(softwareInstance, this));
        }
    }
}
