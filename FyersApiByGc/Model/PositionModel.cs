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
public class PositionModel
{
    public int NetQty { get; set; }
    public int Qty { get; set; }
    public decimal AvgPrice { get; set; }
    public decimal NetAvg { get; set; }
    public int Side { get; set; }
    public string ProductType { get; set; }
    public decimal Realized_Profit { get; set; }
    public decimal Unrealized_Profit { get; set; }
    public decimal Pl { get; set; }
    public decimal Ltp { get; set; }
    public int BuyQty { get; set; }
    public decimal BuyAvg { get; set; }
    public decimal BuyVal { get; set; }
    public int SellQty { get; set; }
    public decimal SellAvg { get; set; }
    public decimal SellVal { get; set; }
    public int SlNo { get; set; }
    public string FyToken { get; set; }
    public string CrossCurrency { get; set; }
    public decimal RbiRefRate { get; set; }
    public decimal QyMulti_Com { get; set; }
    public int Segment { get; set; }
    public string Symbol { get; set; }
    public string Id { get; set; }
    public int CfBuyQty { get; set; }
    public int CfSellQty { get; set; }
    public int DayBuyQty { get; set; }
    public int DaySellQty { get; set; }
    public int Exchange { get; set; }

}
}