using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_DatSan_CauLong_PickleBall
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return this.flowLayoutPanel1;
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.AutoScroll = true;
        }
    }
}
