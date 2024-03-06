using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FyersApiClient.Request
{
    public class GenerateAuthCodeRequest
    {
        public required string client_id { get; set; }
        public string redirect_uri { get; set; } = "https://trade.fyers.in/api-login/redirect-uri/index.html";
        public string response_typ { get; set; } = "code";
        public string state { get; set; } = "sample_state";
    }
}
