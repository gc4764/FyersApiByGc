using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{

    public class WebSocketTradesResponse
    {
        public string s { get; set; }
        public WebSocketTrades trades { get; set; }
    }

    public class WebSocketTrades
    {
        public string tradeNumber { get; set; }
        public string orderNumber { get; set; }
        public int tradedQty { get; set; }
        public float tradePrice { get; set; }
        public float tradeValue { get; set; }
        public string productType { get; set; }
        public string clientId { get; set; }
        public string exchangeOrderNo { get; set; }
        public int orderType { get; set; }
        public int side { get; set; }
        public string symbol { get; set; }
        public string orderDateTime { get; set; }
        public string fyToken { get; set; }
        public int exchange { get; set; }
        public int segment { get; set; }
    }

}
