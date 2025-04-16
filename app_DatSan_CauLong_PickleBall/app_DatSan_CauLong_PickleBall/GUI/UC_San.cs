using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DTO;
namespace GUI
{
    public partial class UC_San : UserControl
    {
        private int panelMaxHeight = 95;
        private int animationTime = 20; // Tốc độ trượt panel
        
        private int frameRate = 60;
        private int step;
        private bool isHovered = false;
        private int borderSize = 3;
        
        public UC_San()
        {
            InitializeComponent();
            
            this.BackColor = Color.Transparent;
            btn_DS.Click += btn_DS_Click;
            
            step = panelMaxHeight / (animationTime / (1000 / frameRate));
            pn_Title.Height = 0;  // Ẩn panel ban đầu
            pn_Title.Visible = false;
            this.MouseEnter += San_MouseEnter;
            this.MouseLeave += San_MouseLeave;
            this.ControlAdded += San_ControlAdded;
        }

        private async void San_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            if(!isClicked) btn_DS.FillColor = Color.FromArgb(200,0,0,0);
            this.Invalidate();
            await ExpandPanel();

            
        }
        public void setData(DataRow row)
        {
            lbl_LoaiSan.Text = row["loaiSan"].ToString();
            lbl_Tesan.Text = row["tenSan"].ToString();
            lbl_GiaSan.Text = row["giaSanTheoPhut"].ToString() + " VND/h";
            lbl_MaSan.Text = "ID: " + row["maSan"].ToString();
        }
        public San getDataSan()
        {
            return new San(lbl_MaSan.Text, lbl_Tesan.Text, lbl_LoaiSan.Text, int.Parse(lbl_GiaSan.Text.Replace(" VND/h", "")));
        }
        private async Task ExpandPanel()
        {
            pn_Title.Visible = true;
            pn_Title.SuspendLayout();
            for (int i = 0; i <= panelMaxHeight; i += step)
            {
                pn_Title.Height = i;
                await Task.Delay(1000 / frameRate);
            }
            pn_Title.ResumeLayout();
        }

        private async void San_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            if(!isClicked)btn_DS.FillColor = Color.FromArgb(100, 255, 255, 255);
            this.Invalidate(); // Xóa viền màu xanh
            await CollapsePanel();
        }
        private async Task CollapsePanel()
        {
            pn_Title.SuspendLayout();
            for (int i = panelMaxHeight; i >= 0; i -= step)
            {
                pn_Title.Height = i;
                await Task.Delay(1000 / frameRate);
            }
            pn_Title.Visible = false;
            pn_Title.ResumeLayout();
        }
        private bool isClicked = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (isHovered || isClicked)
            {
                using (Pen pen = new Pen(Color.LimeGreen, 5)) // Viền màu xanh lá khi hover
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private void San_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter += San_MouseEnter;
            e.Control.MouseLeave += San_MouseLeave;
        }
        public event EventHandler<San> OnDatSanClick;
        private void btn_DS_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked) {
                btn_DS.FillColor = Color.Green;
                btn_DS.ForeColor = Color.White;
                
                
            }
            else
            {
                btn_DS.FillColor = Color.FromArgb(200, 0, 0, 0);
                btn_DS.ForeColor = Color.GreenYellow;
            }
            San san = getDataSan();
            OnDatSanClick?.Invoke(this, san);
            this.Invalidate();
        }
    }
}
