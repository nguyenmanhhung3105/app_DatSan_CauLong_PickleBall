using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_DatSan_CauLong_PickleBall
{
    public partial class UC_Datsan : UserControl
    {
        private bool menuExpanded = false;
        private int maxMenuHeight = 110; // Chiều cao tối đa của menu
        private int animationTime = 50; // Tổng thời gian chạy animation (ms)
        private int frameRate = 60; // Số frame trên giây
        private int step;
        private CancellationTokenSource scrollCTS = new CancellationTokenSource();
        public event EventHandler<UserControl> SwitchUserControl;
        public UC_Datsan()
        {
            InitializeComponent();
            foreach (Control control in pn_San.Controls)
            {
                if (control is San ucSan)
                {
                    ucSan.OnDatSanClick += UcSan_DatSanClicked;
                }
            }
            pn_San.ControlAdded += Pn_San_ControlAdded;
            this.DoubleBuffered = true;
            pn_Dropdown.Height = 0;  // Ẩn menu ban đầu
            pn_Dropdown.Visible = false;
            step = maxMenuHeight / (animationTime / (1000 / frameRate));
            SetupFlowLayoutPanel();
            
        }
        private void Pn_San_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is San ucSan)
            {
                ucSan.OnDatSanClick += UcSan_DatSanClicked;
            }
        }
        private void UcSan_DatSanClicked(object sender, UserControl uc)
        {
            SwitchUserControl?.Invoke(this, uc);
        }
        


        private async void btn_DropList_Click(object sender, EventArgs e)
        {

            if (menuExpanded)
            {
                await CollapseMenu();
            }
            else
            {
                await ExpandMenu();
            }
            menuExpanded = !menuExpanded;
        }
        private async Task ExpandMenu()
        {
            pn_Dropdown.Visible = true;
            pn_Dropdown.SuspendLayout();
            for (int i = 0; i <= maxMenuHeight; i += step)
            {
                pn_Dropdown.Height = i;
                await Task.Delay(1000 / frameRate); // Tạo hiệu ứng mượt mà
            }
            pn_Dropdown.ResumeLayout();
        }
        private async Task CollapseMenu()
        {
            pn_Dropdown.SuspendLayout();
            for (int i = maxMenuHeight; i >= 0; i -= step)
            {
                pn_Dropdown.Height = i;
                await Task.Delay(1000 / frameRate);
            }
            pn_Dropdown.Visible = false;
            pn_Dropdown.ResumeLayout();
        }

        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return this.pn_San;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel == null) return;

            Rectangle clip = e.ClipRectangle;
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl.Bounds.IntersectsWith(clip))
                {
                    ctrl.Invalidate();
                }
            }
        }
        private void SetDoubleBuffered(Control control)
        {
            if (SystemInformation.TerminalServerSession) return;
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, control, new object[] { true });
        }
        private async Task SmoothScroll()
        {
            scrollCTS.Cancel();
            scrollCTS = new CancellationTokenSource();
            var token = scrollCTS.Token;

            try
            {
                await Task.Delay(10, token); // Chờ 16ms (tương đương 60 FPS)

                if (!token.IsCancellationRequested)
                {
                    pn_San.Invalidate(); // Chỉ vẽ lại vùng bị thay đổi
                }
            }
            catch (TaskCanceledException) { }
        }
        private void SetupFlowLayoutPanel()
        {
            if (pn_San == null) return;
            pn_San.AutoScroll = true;
            SetDoubleBuffered(pn_San);
            pn_San.Scroll += async (s, e) => await SmoothScroll();
        
        }
        
        private void btn_LSDS_Click(object sender, EventArgs e)
        {
            UC_LSDS ucLSDS = new UC_LSDS();
            SwitchUserControl?.Invoke(this, ucLSDS);
        }

        private void btn_LSTT_Click(object sender, EventArgs e)
        {
            UC_LSTT ucLSTT = new UC_LSTT();
            SwitchUserControl?.Invoke(this, ucLSTT);
        }
        public event Action<UserControl> SanDuocChon;
        
        

        
    }
    
}
