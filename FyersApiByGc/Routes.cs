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
public static class Routes
{

    // Base Url
    public  const string API = "https://api-t1.fyers.in/api/v3/";
    public  const string DATA_API = "https://api-t1.fyers.in/data/";

    // Endpoint
    

  
    public  const string market_status = "marketStatus";
    public  const string auth = "generate-authcode";
    public  const string generate_access_token = "validate-authcode";
    public  const string generate_data_token = "data-token";
    public  const string data_vendor_td = "truedata-ws";
    public  const string multi_orders = "multi-order/sync";
    public  const string history = "history";
    public  const string quotes = "quotes";
    public  const string market_depth = "depth";



        public  const string validate_authcode ="validate-authcode";
        public  const string validate_refresh_token = "validate-refresh-token";
        public const string profile = "profile";
        public const string funds = "funds";
        public const string holdings = "holdings";
        public const string orderbook = "orders";
        public const string positions = "positions";
        public const string tradebook = "tradebook";
        public const string orders = "orders/sync";








    }

}

