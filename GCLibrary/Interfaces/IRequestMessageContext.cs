using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Interfaces
{
    public interface IRequestMessageContext
    {
        public string OrderType { set; get; }
    }
}
