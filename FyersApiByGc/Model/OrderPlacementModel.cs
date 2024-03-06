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
public  class OrderPlacementModel
{ 
    public string Symbol { get; set; }
    public int Qty { get; set; }
    public int Type { get; set; }
    public int Side { get; set; }
    public string ProductType { get; set; }
    public decimal LimitPrice { get; set; }
    public decimal StopPrice { get; set; }
    public string Validity { get; set; }
    public decimal StopLoss { get; set; }
    public decimal TakeProfit { get; set; }
    public bool OfflineOrder { get; set; }
    public int DisclosedQty { get; set; }

}
}

// { "symbol": "NSE:SBIN-EQ", "qty": 100, "type": 1, "side": 1, "productType": "INTRADAY", "limitPrice": 100, "stopPrice": 0, "validity": "DAY", "stopLoss": 0, "takeProfit": 0, "offlineOrder": false, "disclosedQty": 0 }
// { "symbol": "NSE:SBIN-EQ", "qty": 100, "type": 2, "side": 1, "productType": "INTRADAY", "limitPrice": 0, "stopPrice": 0, "validity": "DAY", "stopLoss": 0, "takeProfit": 0, "offlineOrder": false, "disclosedQty": 0 }
// { "symbol": "NSE:SBIN-EQ", "qty": 100, "type": 3, "side": 1, "productType": "INTRADAY", "limitPrice": 0, "stopPrice": 100, "validity": "DAY", "stopLoss": 0, "takeProfit": 0, "offlineOrder": false, "disclosedQty": 0 }

// { "symbol": "NSE:SBIN-EQ", "qty": 100, "type": 4, "side": 1, "productType": "INTRADAY", "limitPrice": 100, "stopPrice": 95, "validity": "DAY", "stopLoss": 0, "takeProfit": 0, "offlineOrder": false, "disclosedQty": 0 }
