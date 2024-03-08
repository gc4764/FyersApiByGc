using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Context
{
    public class RequestMessageContext : IRequestMessageContext
    {
        public string OrderType { get; set; }= string.Empty;
        public decimal Price { get; set; }
        public decimal StopLossPrice { get; set; }  
    }
}
