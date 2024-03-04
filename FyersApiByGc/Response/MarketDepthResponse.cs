using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{

 
    public class MarketDepthResponse
    {
        public string s { get; set; }
        public Depth depth { get; set; }
        public string message { get; set; }
    }

    public class Depth
    {
        public SymbolId symbolId { get; set; }
    }

    public class SymbolId
    {
        public int totalbuyqty { get; set; }
        public int totalsellqty { get; set; }
        public List<Bid> bids { get; set; }
        public List<Ask> ask { get; set; }
        public float o { get; set; }
        public float h { get; set; }
        public float l { get; set; }
        public float c { get; set; }
        public float chp { get; set; }
        public float tick_Size { get; set; }
        public float ch { get; set; }
        public int ltq { get; set; }
        public int ltt { get; set; }
        public float ltp { get; set; }
        public int v { get; set; }
        public float atp { get; set; }
        public float lower_ckt { get; set; }
        public float upper_ckt { get; set; }
        public string expiry { get; set; }
        public int oi { get; set; }
        public bool oiflag { get; set; }
        public int pdoi { get; set; }
        public float oipercent { get; set; }
    }

    public class Bid
    {
        public float price { get; set; }
        public int volume { get; set; }
        public int ord { get; set; }
    }

    public class Ask
    {
        public float price { get; set; }
        public int volume { get; set; }
        public int ord { get; set; }
    }






}
