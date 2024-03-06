
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
    public  class tradeBookModel
    {
        public string ClientId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string OrderNumber { get; set; }
        public string ExchangeOrderNo { get; set; }
        public int Exchange { get; set; }
        public int Side { get; set; }
        public int Segment { get; set; }
        public int OrderType { get; set; }
        public string FyToken { get; set; }
        public string ProductType { get; set; }
        public int TradedQty { get; set; }
        public decimal TradePrice { get; set; }
        public decimal TradeValue { get; set; }
        public string TradeNumber { get; set; }
        public int Row { get; set; }
        public string Symbol { get; set; }
        public string OrderTag { get; set; }


    
             
    }

}

 