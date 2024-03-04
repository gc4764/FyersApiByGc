using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
  
    public class MultiOrderMarginCalculatorRequest
    {
        public List<DatumMultiOrderMarginCalculator> data { get; set; }
    }

    public class DatumMultiOrderMarginCalculator
    {
        public string symbol { get; set; }
        public int qty { get; set; }
        public int side { get; set; }
        public int type { get; set; }
        public string productType { get; set; }
        public float limitPrice { get; set; }
        public float stopLoss { get; set; }
        public float stopPrice { get; set; }
        public float takeProfit { get; set; }
    }

}
