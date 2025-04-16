using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ApiRequest
    {
        public int acqId { get; set; } 
        public long accountNo { get; set; } // Số tài khoản người nhận
        public string accountName { get; set; } // Tên tài khoản người nhận
        public int amount { get; set; } // Số tiền
        public string addInfo { get; set; } // Thông tin bổ sung
        public string format { get; set; } // Định dạng dữ liệu
        public string template { get; set; }
    }
}
