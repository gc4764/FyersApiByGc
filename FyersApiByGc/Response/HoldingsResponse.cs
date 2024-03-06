using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
    public class HoldingsResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<Holding> holdings { get; set; }
        public OverallHoldings overall { get; set; }
    }



    public class OverallHoldings
    {
        public int count_total { get; set; }
        public float total_investment { get; set; }
        public float total_current_value { get; set; }
        public float total_pl { get; set; }
        public float pnl_perc { get; set; }
    }

    public class Holding
    {
        public string holdingType { get; set; }
        public int quantity { get; set; }
        public float costPrice { get; set; }
        public float marketVal { get; set; }
        public int remainingQuantity { get; set; }
        public float pl { get; set; }
        public float ltp { get; set; }
        public int id { get; set; }
        public long fyToken { get; set; }
        public int exchange { get; set; }
        public string symbol { get; set; }
        public int segment { get; set; }
        public string isin { get; set; }
        public int qty_t1 { get; set; }
        public int remainingPledgeQuantity { get; set; }
        public int collateralQuantity { get; set; }
    }

}
