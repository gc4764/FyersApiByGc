using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{
    public class ValidateAuthcodeResponse
    {
     
            public string s { get; set; }
            public int code { get; set; }
            public string message { get; set; }
            public string access_token { get; set; }
            public string refresh_token { get; set; }

    }
}
