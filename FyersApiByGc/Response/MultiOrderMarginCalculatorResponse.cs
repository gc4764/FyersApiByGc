using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
   
    public class MultiOrderMarginCalculatorResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public DataMultiOrderMarginCalculator data { get; set; }
        public string s { get; set; }
    }

    public class DataMultiOrderMarginCalculator
    {
        public float margin_avail { get; set; }
        public float margin_total { get; set; }
        public float margin_new_order { get; set; }
    }

}
