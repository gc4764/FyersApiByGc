using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
  
    public class ConvertPositionRequest
    {
        public string symbol { get; set; }
        public int positionSide { get; set; }
        public int convertQty { get; set; }
        public string convertFrom { get; set; }
        public string convertTo { get; set; }
        public int overnight { get; set; }
    }

}
