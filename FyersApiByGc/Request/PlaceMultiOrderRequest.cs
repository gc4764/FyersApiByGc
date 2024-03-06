using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Request
{
   
    public class PlaceMultiOrderRequest
    {
        public List<MulitOrder> mulitOrders { get; set; }
    }

    public class MulitOrder
    {
        public string symbol { get; set; }
        public int qty { get; set; }
        public int type { get; set; }
        public int side { get; set; }
        public string productType { get; set; }
        public float limitPrice { get; set; }
        public int stopPrice { get; set; }
        public int disclosedQty { get; set; }
        public string validity { get; set; }
        public string offlineOrder { get; set; }
        public int stopLoss { get; set; }
        public int takeProfit { get; set; }
        public string orderTag { get; set; }
    }

}
