using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
  
    public class SpanMarginCalculatorRequest
    {
        public List<Datum> data { get; set; }
    }

    public class Datum
    {
        public string symbol { get; set; }
        public int qty { get; set; }
        public int side { get; set; }
        public int type { get; set; }
        public string productType { get; set; }
        public float limitPrice { get; set; }
        public float stopLoss { get; set; }
    }

}
