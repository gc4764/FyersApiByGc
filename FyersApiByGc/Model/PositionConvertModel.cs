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
public  class PositionConvertModel
{
    public string Symbol { get; set; }
    public int PositionSide { get; set; }
    public int ConvertQty { get; set; }
    public string ConvertFrom { get; set; }
    public string ConvertTo { get; set; }
    public int Overnight { get; set; }


}
}

