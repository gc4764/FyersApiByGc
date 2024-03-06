using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Request
{
    public class ValidateAuthcodeRequest
    {
        public string grant_type { get; set; } = "authorization_code";
        public string appIdHash { get; set; }
        public string code { get; set; }
    }
}

