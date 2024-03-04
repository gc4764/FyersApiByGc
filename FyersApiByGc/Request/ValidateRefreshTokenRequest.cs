using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Request
{
    public class ValidateRefreshTokenRequest
    {
        public  string grant_type { get; } ="refresh_token";
        public string appIdHash { get; set; }
        public string refresh_token { get; set; }
        public string pin { get; set; }
    }


}
