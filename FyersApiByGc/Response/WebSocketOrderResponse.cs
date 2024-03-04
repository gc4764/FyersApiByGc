using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
   
    public class WebSocketOrderResponse
    {
        public string s { get; set; }
        public WebSocketOrder orders { get; set; }
    }

    public class WebSocketOrder
    {
        public string clientId { get; set; }
        public string id { get; set; }
        public string exchOrdId { get; set; }
        public int qty { get; set; }
        public int filledQty { get; set; }
        public float limitPrice { get; set; }
        public int type { get; set; }
        public string fyToken { get; set; }
        public int exchange { get; set; }
        public int segment { get; set; }
        public string symbol { get; set; }
        public int instrument { get; set; }
        public bool offlineOrder { get; set; }
        public string orderDateTime { get; set; }
        public string orderValidity { get; set; }
        public string productType { get; set; }
        public int side { get; set; }
        public int status { get; set; }
        public string source { get; set; }
        public string ex_sym { get; set; }
        public string description { get; set; }
        public string orderNumStatus { get; set; }
    }

}
