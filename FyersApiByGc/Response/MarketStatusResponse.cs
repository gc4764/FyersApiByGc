using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
  
    public class MarketStatusResponse
    {
        public int code { get; set; }
        public List<Marketstatu> marketStatus { get; set; }
        public string message { get; set; }
        public string s { get; set; }
    }

    public class Marketstatu
    {
        public int exchange { get; set; }
        public string market_type { get; set; }
        public int segment { get; set; }
        public string status { get; set; }
    }

}
