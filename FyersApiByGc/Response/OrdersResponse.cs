using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
    public class OrdersResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<Orderbook> orderBook { get; set; }
    }

 

    public class Orderbook
    {
        public string clientId { get; set; }
        public string id { get; set; }
        public string exchOrdId { get; set; }
        public int qty { get; set; }
        public int remainingQuantity { get; set; }
        public int filledQty { get; set; }
        public int discloseQty { get; set; }
        public float limitPrice { get; set; }
        public int stopPrice { get; set; }
        public float tradedPrice { get; set; }
        public int type { get; set; }
        public string fyToken { get; set; }
        public int exchange { get; set; }
        public int segment { get; set; }
        public string symbol { get; set; }
        public int instrument { get; set; }
        public string message { get; set; }
        public bool offlineOrder { get; set; }
        public string orderDateTime { get; set; }
        public string orderValidity { get; set; }
        public string pan { get; set; }
        public string productType { get; set; }
        public int side { get; set; }
        public int status { get; set; }
        public string source { get; set; }
        public string ex_sym { get; set; }
        public string description { get; set; }
        public float ch { get; set; }
        public float chp { get; set; }
        public float lp { get; set; }
        public int slNo { get; set; }
        public int dqQtyRem { get; set; }
        public string orderNumStatus { get; set; }
        public int disclosedQty { get; set; }
        public string orderTag { get; set; }
    }

}
