using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
   
    public class OrderRequest
    {
        public string symbol { get; set; }
        public int qty { get; set; }
        public int type { get; set; }
        public int side { get; set; }
        public string productType { get; set; }
        public decimal limitPrice { get; set; }
        public decimal stopPrice { get; set; }
        public string validity { get; set; }
        public decimal stopLoss { get; set; }
        public decimal takeProfit { get; set; }
        public bool offlineOrder { get; set; }
        public int disclosedQty { get; set; }

        public string orderTag { get; set; } = "gc4764Algo";
    }

}
