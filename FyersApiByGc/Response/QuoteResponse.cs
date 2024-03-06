using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
 
    public class QuoteResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public List<D> d { get; set; }
    }

    public class D
    {
        public string n { get; set; }
        public string s { get; set; }
        public V v { get; set; }
    }

    public class V
    {
        public float ch { get; set; }
        public float chp { get; set; }
        public float lp { get; set; }
        public float spread { get; set; }
        public float ask { get; set; }
        public float bid { get; set; }
        public float open_price { get; set; }
        public float high_price { get; set; }
        public float low_price { get; set; }
        public float prev_close_price { get; set; }
        public int volume { get; set; }
        public string short_name { get; set; }
        public string exchange { get; set; }
        public string description { get; set; }
        public string original_name { get; set; }
        public string symbol { get; set; }
        public string fyToken { get; set; }
        public string tt { get; set; }
        public Cmd cmd { get; set; }
    }

    public class Cmd
    {
        public int t { get; set; }
        public float o { get; set; }
        public float h { get; set; }
        public float l { get; set; }
        public float c { get; set; }
        public int v { get; set; }
        public string tf { get; set; }
    }

}
