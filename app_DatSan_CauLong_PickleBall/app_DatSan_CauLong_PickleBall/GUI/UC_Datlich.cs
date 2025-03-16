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

namespace app_DatSan_CauLong_PickleBall
{
    public partial class btn_DatLich : UserControl
    {
        public btn_DatLich()
        {
            InitializeComponent();
            SetupTrackBar();
        }

        private void SetupTrackBar()
        {
            tb_GioDat.Minimum = 360; // 0:00
            tb_GioDat.Maximum = 21 * 60 + 59; // 23:59
            tb_GioDat.Value = 360;
            txt_GioDat.Text = "6:00";// Mặc định là 12:00

          

            tb_GioDat.Scroll += tb_GioDat_Scroll;
        }

        private void tb_GioDat_Scroll(object sender, ScrollEventArgs e)
        {
            int totalMinutes = tb_GioDat.Value;
            int hours = totalMinutes / 60; // Lấy giờ
            int minutes = totalMinutes % 60; // Lấy phút

            txt_GioDat.Text = $"{hours:D2}:{minutes:D2}";
        }
    }
}
