﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{
    public class ValidateRefreshTokenResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public string access_token { get; set; }
    }

 
}
