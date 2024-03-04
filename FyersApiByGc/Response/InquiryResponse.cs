using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{

    public class InquiryResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public DataInquiry data { get; set; }
    }

    public class DataInquiry
    {
        public int FAILED_CNT { get; set; }
        public int SUCEESS_CNT { get; set; }
    }

}
