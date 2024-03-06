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
    public class ProfileModel
    {
        public string  ClientId { get; set; }
        public string  Id { get; set; }
        public string ExchOrdId { get; set; }
        public int Qty { get; set; } 
        public int RemainingQuantity { get; set; }
        public int FilledQty { get; set; }
        public int DiscloseQty { get; set; }
        public decimal LimitPrice { get; set; }  
        public decimal StopPrice { get; set; }
        public decimal TradedPrice { get; set; }
        public int Type { get; set; }
        public string FyToken { get; set; }
        public int Exchange { get; set; }
        public int Segment { get; set; }
        public string Symbol { get; set; }
        public int Instrument { get; set; }
        public string Message { get; set; }
        public bool OfflineOrder { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string OrderValidity { get; set; }
        public string Pan { get; set; }
        public string ProductType { get; set; }
        public int Side { get; set; }
        public int Status { get; set; }
        public string Source { get; set; }
        public string Ex_Sym { get; set; }
        public string Description { get; set; }
        public decimal Ch { get; set; }
        public decimal chp { get; set; }
        public decimal Lp { get; set; }
        public int SlNo { get; set; }
        public int DqQtyRem { get; set; }
        public string OrderNumStatus { get; set; }
        public int DisclosedQty { get; set; }
        public string OrderTag { get; set; }
        
                
    }
}