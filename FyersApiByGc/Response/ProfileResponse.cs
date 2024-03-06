using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
    public class ProfileResponse
    {
        
            public int code { get; set; }
            public string message { get; set; }
            public string s { get; set; }
            public List<Fund_Limit> fund_limit { get; set; }
    }

        public class Fund_Limit
        {
            public int id { get; set; }
            public string title { get; set; }
            public float equityAmount { get; set; }
            public int commodityAmount { get; set; }
        }

}

