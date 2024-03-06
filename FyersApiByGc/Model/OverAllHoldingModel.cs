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
    public class OverAllHoldingModel
    {
        public int  Count_Total { get; set; }
        public decimal  Total_Investment { get; set; }
        public decimal Total_Current_Value { get; set; }
        public decimal Total_Pl { get; set; } 
        public decimal Pnl_Perc { get; set; } 

        
                
    }
}