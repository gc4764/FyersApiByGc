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
public  class OrderModifyModel
{
    public int Id { get; set; }
    public int Qty { get; set; }
    public int Type { get; set; }
    public int Side { get; set; }
    public decimal LimitPrice { get; set; }


}
}