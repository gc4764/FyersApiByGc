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
    public class HoldingModel
    {
        public string  HoldingType { get; set; }
        public int  Qunatity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal MarketVal { get; set; } 
        public int RemainingQuantity  { get; set; }
        public decimal Pl { get; set; }
        public decimal Ltp { get; set; }
        public int Id { get; set; }
        public int FyToken { get; set; }
        public int Exchange { get; set; }
        public string Symbol { get; set; }
        public int Segment { get; set; }
        public string Isin { get; set; }
        public int Qty_T1 { get; set; }
        public int RemainingPledgeQuantity { get; set; }    
        public int CollateralQuantity { get; set; }
        
        
                
    }
}