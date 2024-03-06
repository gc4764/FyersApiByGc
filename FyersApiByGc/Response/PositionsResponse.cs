using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
    public class PositionsResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<Netposition> netPositions { get; set; }
        public OverallPositions overall { get; set; }
    }
  
    public class OverallPositions
    {
        public int count_total { get; set; }
        public int count_open { get; set; }
        public float pl_total { get; set; }
        public float pl_realized { get; set; }
        public float pl_unrealized { get; set; }
    }

    public class Netposition
    {
        public int netQty { get; set; }
        public int qty { get; set; }
        public float avgPrice { get; set; }
        public float netAvg { get; set; }
        public int side { get; set; }
        public string productType { get; set; }
        public float realized_profit { get; set; }
        public float unrealized_profit { get; set; }
        public float pl { get; set; }
        public float ltp { get; set; }
        public int buyQty { get; set; }
        public float buyAvg { get; set; }
        public float buyVal { get; set; }
        public int sellQty { get; set; }
        public float sellAvg { get; set; }
        public float sellVal { get; set; }
        public int slNo { get; set; }
        public string fyToken { get; set; }
        public string crossCurrency { get; set; }
        public float rbiRefRate { get; set; }
        public float qtyMulti_com { get; set; }
        public int segment { get; set; }
        public string symbol { get; set; }
        public string id { get; set; }
        public int cfBuyQty { get; set; }
        public int cfSellQty { get; set; }
        public int dayBuyQty { get; set; }
        public int daySellQty { get; set; }
        public int exchange { get; set; }
    }

}
