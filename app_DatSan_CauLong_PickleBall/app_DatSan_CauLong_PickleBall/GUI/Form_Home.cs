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

namespace app_DatSan_CauLong_PickleBall
{
    
    public partial class Form_Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form_Home()
        {

            InitializeComponent();
            LoadUC_Datsan();
            this.DoubleBuffered = true;
            
            LoadImagesAsync();
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
        private async void LoadImagesAsync()
        {
            
            btn_Home.Image = await LoadImageAsync("./img/home.png");
            btn_DatSan.Image = await LoadImageAsync("./img/book.png");
            btn_Danhgia.Image = await LoadImageAsync("./img/review.png");
            btn_Account.Image = await LoadImageAsync("./img/account.png");

            // Thiết lập kích thước icon
            btn_Home.ImageSize = btn_DatSan.ImageSize = btn_Danhgia.ImageSize = btn_Account.ImageSize = new Size(50, 50);
            btn_Home.ImageAlign = btn_DatSan.ImageAlign = btn_Danhgia.ImageAlign = btn_Account.ImageAlign = HorizontalAlignment.Left;
            
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



        private void Form_Home_Load(object sender, EventArgs e) {
            add_UControls(new UC_Home());
            //pn_Ngay.Paint += new PaintEventHandler(pn_Ngay_Paint);

        }

        //private void pn_Ngay_Paint(object sender, PaintEventArgs e)
        //{
        //    Color panelColor = Color.FromArgb(10, 0,0,0);
        //    using (SolidBrush brush = new SolidBrush(panelColor))
        //    {
        //        e.Graphics.FillRectangle(brush, pn_Ngay.ClientRectangle);
        //    }
        //}

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
        private void add_UControls(UserControl userControl)
        {
            if (pn_Main.Controls.Count > 0 && pn_Main.Controls[0].GetType() == userControl.GetType())
                return;
            pn_Main.Controls.Clear();
            pn_Main.Controls.Add(userControl);
            userControl.BringToFront();
            

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
            
            UC_Datsan uc_Datsan = new UC_Datsan();

            uc_Datsan.SwitchUserControl += SwitchUserControlHandler;
            add_UControls(uc_Datsan);
        }

        private void SwitchUserControlHandler(object sender, UserControl uc)
        {
            add_UControls(uc); // Thay đổi UserControl trong pn_Main
        }

    }
}
