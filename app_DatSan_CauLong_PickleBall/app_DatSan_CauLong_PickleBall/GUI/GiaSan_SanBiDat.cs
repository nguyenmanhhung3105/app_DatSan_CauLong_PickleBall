using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class GiaSan_SanBiDat : UserControl
    {
        UC_Datlich uC_Datlich;
        public GiaSan_SanBiDat(UC_Datlich uC_Datlich)
        {
            InitializeComponent();
            this.uC_Datlich = uC_Datlich;
        }
        private void LoadXemLichSanBiDat()
        {
            DateTime ngayXemLichSanBiDat = pdt_NgayDat.Value;
            DataTable dtsource = ChiTietPhieuDatSan_BLL.XemLichSanBiDat(ngayXemLichSanBiDat);
            dt_Dung_Cu_Thue.DataSource = dtsource;
            dt_Dung_Cu_Thue.Show();
        }

        private void pdt_NgayDat_ValueChanged(object sender, EventArgs e)
        {
            LoadXemLichSanBiDat();
        }

        private void btn_XemGiaSan_Click(object sender, EventArgs e)
        {
            DataTable dtsource = San_BLL.xemGiaSan();
            dt_Dung_Cu_Thue.DataSource = dtsource;
            dt_Dung_Cu_Thue.Show();
        }

        private void btn_XemSanBiDat_Click(object sender, EventArgs e)
        {
            LoadXemLichSanBiDat();
        }
        public event Action<object, UserControl> SwitchUserControl;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            SwitchUserControl?.Invoke(this, uC_Datlich);
        }

        
    }
}
