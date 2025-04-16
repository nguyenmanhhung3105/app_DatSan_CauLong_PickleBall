using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class San
    {
        public string maSan { get; set; }
        public string tenSan { get; set; }
        public string loaiSan { get; set; }
        public int giaSanTheoPhut { get; set; }

        public San(string maSan, string tenSan, string loaiSan, int giaSanTheoPhut)
        {
            this.maSan = maSan;
            this.tenSan = tenSan;
            this.loaiSan = loaiSan;
            this.giaSanTheoPhut = giaSanTheoPhut;
        }
    }
}
