using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Request
{
   
    public class CDSLIndexRequest
    {
        public List<Recordlst> recordLst { get; set; }
    }

    public class Recordlst
    {
        public string isin_code { get; set; }
        public string qty { get; set; }
        public string symbol { get; set; }
    }

}
