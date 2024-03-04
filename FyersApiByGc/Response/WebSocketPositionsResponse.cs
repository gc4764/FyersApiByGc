using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{

    public class WebSocketPositionsResponse
    {
        public string s { get; set; }
        public WebSocketPositions positions { get; set; }
    }

    public class WebSocketPositions
    {
        public string symbol { get; set; }
        public string id { get; set; }
        public int buyAvg { get; set; }
        public int buyQty { get; set; }
        public int buyVal { get; set; }
        public float sellAvg { get; set; }
        public int sellQty { get; set; }
        public float sellVal { get; set; }
        public int netAvg { get; set; }
        public int netQty { get; set; }
        public int side { get; set; }
        public int qty { get; set; }
        public string productType { get; set; }
        public float realized_profit { get; set; }
        public int rbiRefRate { get; set; }
        public string fyToken { get; set; }
        public int exchange { get; set; }
        public int segment { get; set; }
        public int dayBuyQty { get; set; }
        public int daySellQty { get; set; }
        public int cfBuyQty { get; set; }
        public int cfSellQty { get; set; }
        public int qtyMulti_com { get; set; }
    }

}
