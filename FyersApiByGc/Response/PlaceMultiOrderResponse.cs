using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
  
    public class PlaceMultiOrderResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Datum
    {
        public int statusCode { get; set; }
        public Body body { get; set; }
        public string statusDescription { get; set; }
    }

    public class Body
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public string id { get; set; }
    }

}
