using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
  
    public class ModifyOrderRequest
    {
        public string id { get; set; }
        public int qty { get; set; }
        public decimal limitPrice { get; set; }
        public decimal stopPrice { get; set; }
        public int type { get; set; }
        public int side { get; set; }
    }



}
