using GCLibrary.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBridge.DummyClasses
{
    public class UserContextDummy : UserContext
    {
        //public string TradeType { get; set; }
        public string AccessToken { get; set; } = string.Empty;

    }
}
