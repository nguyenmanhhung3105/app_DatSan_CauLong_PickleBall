using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using DTO;
using BLL;
using System.Runtime.CompilerServices;

namespace GUI
{
    
    public partial class Form_Home : Form
    {
        public bool isAdmin = false;

        public KhachHang khachHang;
        //public QuanLy quanLy;
        private UC_Datlich uc_DatLich = null;           // Lưu tham chiếu tới UC_DatLich hiện tại
        private bool daDatLich = false;       // Cờ kiểm tra có đang ở UC_DatLich không
        private string maPhieuDatSan = null;
        private string maPhieuThueDungCu = null;
        public Form_Home(KhachHang kh)
        {
            
            InitializeComponent();
            LoadUC_Datsan();
            this.khachHang = kh;
            this.DoubleBuffered = true;
            txt_Ten_TK.Clear();
            txt_Ten_TK.Text =  kh.tenKhachHang.ToString();
            
            //txt_Ten_TK
            txt_Ten_TK.FillColor = ColorTranslator.FromHtml("#C8DE96");
            txt_Ten_TK.ForeColor = ColorTranslator.FromHtml("#91855A");
            txt_Ten_TK.HoverState.FillColor = ColorTranslator.FromHtml("#FFFF");
            txt_Ten_TK.HoverState.BorderColor = ColorTranslator.FromHtml("#B08968");
          
            txt_Ten_TK.MouseEnter += txt_Ten_TK_MouseEnter;
            txt_Ten_TK.MouseLeave += txt_Ten_TK_MouseLeave;
            

            //dtpk_Ngay
            dtpk_Ngay.FillColor = ColorTranslator.FromHtml("#C8DE96");
            dtpk_Ngay.ForeColor = ColorTranslator.FromHtml("#91855A");
            
            dtpk_Ngay.HoverState.BorderColor = ColorTranslator.FromHtml("#B08968");

            dtpk_Ngay.MouseEnter += dtpk_Ngay_MouseEnter;
            dtpk_Ngay.MouseLeave += dtpk_Ngay_MouseLeave;
            this.Load += Form_Home_Load;

            //txt_Search
            txt_Search.PlaceholderText = "Tìm kiếm...";

            //btn_Search
            btn_Search.MouseEnter += btn_Search_MouseEnter;
            btn_Search.MouseLeave += btn_Search_MouseLeave;
            pb_Menu.Click += (sender, e) => ToggleSidebar();

            
            btn_Home.Click += Btn_Click;
            btn_DatSan.Click += Btn_Click;

            this.Scroll += Form_Home_Scroll;
            
        }
        private void AttachMouseDownEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Đừng gắn vào UC_DatLich vì click trong đó không tính là "ra ngoài"
                if (uc_DatLich == null || ctrl != uc_DatLich)
                {
                    ctrl.MouseDown -= Control_MouseDown; // Gỡ trước cho chắc
                    ctrl.MouseDown += Control_MouseDown;
                }

                if (ctrl.HasChildren)
                {
                    AttachMouseDownEvents(ctrl);
                }
            }
        }
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (uc_DatLich == null || !uc_DatLich.daDatSan) return;
            Control clickedControl = sender as Control;
            if (clickedControl != null && !uc_DatLich.Contains(clickedControl))
            {
                DialogResult result = MessageBox.Show(
                    "Nếu bạn thoát thì phiếu đặt sân của bạn sẽ bị xóa. Bạn chắc chứ?",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string maPhieuDatSan = uc_DatLich.tempMPDS;

                    if (!string.IsNullOrEmpty(maPhieuDatSan))
                    {
                        ChiTietPhieuDatSan_BLL.deleteChiTietPhieuDatSan(maPhieuDatSan);
                        PhieuDatSan_BLL.deletePhieuDatSanByMaPDS(maPhieuDatSan);

                        MessageBox.Show("Đã xóa phiếu đặt sân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Reset
                    uc_DatLich = null;
                    LoadUC_Datsan();
                }
            }
        }
        private async Task<Image> LoadImageAsync(string path)
        {
            return await Task.Run(() =>
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException($"Không tìm thấy ảnh: {path}");

                return Image.FromFile(path);
            });
        }


        //form_load
        private void Form_Home_Load(object sender, EventArgs e) {
            add_UControls(new UC_Home());
            btn_Home.Click += MenuButton_Click;
            btn_Danhgia.Click += MenuButton_Click;
            btn_DatSan.Click += MenuButton_Click;
           btn_Account.Click += MenuButton_Click;
            AttachMouseDownEvents(this);

        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            // Đổi màu tất cả button về màu gốc
            btn_Home.BackgroundImage = null;
            btn_Danhgia.BackgroundImage = null;
            btn_DatSan.BackgroundImage = null;
            btn_Account.BackgroundImage = null;


            // Đổi màu của button vừa được nhấn
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.BackgroundImage = Image.FromFile("./img/layered-steps-haikei.png");
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }


        private void txt_Ten_TK_MouseEnter(object sender, EventArgs e)
        {
            txt_Ten_TK.Size = new Size(txt_Ten_TK.Width + 10, txt_Ten_TK.Height + 5);
        }

        private void txt_Ten_TK_MouseLeave(object sender, EventArgs e)
        {
            txt_Ten_TK.Size = new Size(txt_Ten_TK.Width - 10, txt_Ten_TK.Height - 5);
        }

        private void dtpk_Ngay_MouseEnter(object sender, EventArgs e)
        {
            dtpk_Ngay.BackColor = ColorTranslator.FromHtml("#FFFF");
            dtpk_Ngay.Size = new Size(dtpk_Ngay.Width + 10, dtpk_Ngay.Height + 5);
        }

        private void dtpk_Ngay_MouseLeave(object sender, EventArgs e)
        {
            dtpk_Ngay.FillColor = ColorTranslator.FromHtml("#C8DE96");
            dtpk_Ngay.Size = new Size(dtpk_Ngay.Width - 10, dtpk_Ngay.Height - 5);
        }

        private void btn_Search_MouseEnter(object sender, EventArgs e)
        {
            btn_Search.Size = new Size(btn_Search.Width + 3, btn_Search.Height + 3);
        }

        private void btn_Search_MouseLeave(object sender, EventArgs e)
        {
            btn_Search.Size = new Size(btn_Search.Width - 3, btn_Search.Height - 3);
        }


        //sidebar
        bool sidebarExpand = false;
        private async void ToggleSidebar()
        {
            int step;
            int animationTime = 150;
            int frameRate = 60;
            int minWidth = sidebar.MinimumSize.Width;
            int maxWidth = sidebar.MaximumSize.Width;
            step = (maxWidth - minWidth) / (animationTime/(1000/frameRate));
            sidebar.SuspendLayout();
            if (sidebarExpand)
            {
                for (int i = sidebar.Width; i > minWidth; i -= step)
                {
                    sidebar.Width = i;
                    await Task.Delay(1000/frameRate); // Giảm độ trễ để tăng tốc độ animation
                }
                sidebar.Width = minWidth;
            }
            else
            {
                for (int i = sidebar.Width; i < maxWidth; i += step)
                {
                    sidebar.Width = i;
                    await Task.Delay(1000/frameRate); // Giảm độ trễ để tăng tốc độ animation
                }
                sidebar.Width = maxWidth;
            }
            sidebar.ResumeLayout(); // Cho phép UI cập nhật lại
            
            sidebarExpand = !sidebarExpand;
        }

        //add_usercontrol
        private void add_UControls(UserControl userControl)
        {
            if (pn_Main.Controls.Count > 0 && pn_Main.Controls[0].GetType() == userControl.GetType())
                return;
            pn_Main.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            userControl.Size = pn_Main.Size;
            pn_Main.Controls.Add(userControl);
            userControl.BringToFront();
            if (userControl is UC_Datlich)
            {
                uc_DatLich = (UC_Datlich)userControl;
            }
            else
            {
                uc_DatLich = null;
            }
            AttachMouseDownEvents(this);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            switch (btn.Name)
            {
                case "btn_Home":
                    add_UControls(new UC_Home());
                    break;
                case "btn_DatSan":
                    LoadUC_Datsan();
                    break;
                //case "btn_Danhgia":
                //    LoadUC_DanhGia();
                //    break;
                //case "btn_Account":
                //    LoadUC_Account();
                //    break;
            }
        }

        private void Form_Home_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate(new Rectangle(0, e.NewValue, this.Width, this.Height));
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED - Kết hợp vẽ lại mượt hơn
                return cp;
            }
        }
        private void LoadUC_Datsan()
        {
            UC_Datsan uc_Datsan = new UC_Datsan(khachHang);

            uc_Datsan.SwitchUserControl += SwitchUserControlHandler;
            add_UControls(uc_Datsan);
        }
        
        //private void LoaUC_DanhGia()
        //{
        //    UC_Danhgia uc_DanhGia = new UC_Danhgia(khachHang);
        //    uc_DanhGia.SwitchUserControl += SwitchUserControlHandler;
        //}
        private void SwitchUserControlHandler(object sender, UserControl uc)
        {
            add_UControls(uc); // Thay đổi UserControl trong pn_Main
        }

        

        private void pt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
