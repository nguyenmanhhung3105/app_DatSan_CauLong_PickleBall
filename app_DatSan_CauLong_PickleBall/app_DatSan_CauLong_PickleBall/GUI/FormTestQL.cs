using System;
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
    public partial class FormTestQL: Form
    {
        public FormTestQL()
        {
            InitializeComponent();
        }

        private void FormTestQL_Load(object sender, EventArgs e)
        {
            UC_QuanLyDatSan ucds = new UC_QuanLyDatSan();
            ucds.Dock = DockStyle.Fill; // Tự động co giãn theo panel
            guna2Panel1.Controls.Clear(); // Xoá control cũ nếu có
            guna2Panel1.Controls.Add(ucds);
        }
    }
}
