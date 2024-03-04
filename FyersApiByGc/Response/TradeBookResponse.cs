using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
    public class TradeBookResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<Tradebook> tradeBook { get; set; }
    }


    public class Tradebook
    {
        public string clientId { get; set; }
        public string orderDateTime { get; set; }
        public string orderNumber { get; set; }
        public string exchangeOrderNo { get; set; }
        public int exchange { get; set; }
        public int side { get; set; }
        public int segment { get; set; }
        public int orderType { get; set; }
        public string fyToken { get; set; }
        public string productType { get; set; }
        public int tradedQty { get; set; }
        public float tradePrice { get; set; }
        public float tradeValue { get; set; }
        public string tradeNumber { get; set; }
        public int row { get; set; }
        public string symbol { get; set; }
        public string orderTag { get; set; }
    }

}
