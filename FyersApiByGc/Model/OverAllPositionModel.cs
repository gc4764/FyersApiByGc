
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


namespace FyersApiByGc
{
public class OverAllPositionModel
{
    public int Count_Total { get; set; }
    public int Count_Open { get; set; }
    public decimal Pl_Total { get; set; }
    public decimal Pl_Realized { get; set; }
    public decimal Pl_Unrealized { get; set; }
}
}