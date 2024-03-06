using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using RestSharp;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text.Json;


namespace FyersApiClient
{
    public class FundModel
    {
        public int  Id { get; set; }
        public string  Title { get; set; }
        public decimal EquityAmount { get; set; }
        public decimal CommodityAmount { get; set; } 
        
                
    }
}