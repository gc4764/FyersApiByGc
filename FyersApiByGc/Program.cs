using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Json;
using FyersApiByGc.Model;
using System.Threading;
using FyersApiByGc.Response;
using FyersApiByGc.Request;
using FyersApiByGc.FyersApi;
using FyersApiByGc.Http;
using XAct.Messages;
using XAct;


namespace FyersApiByGc
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            Fyers login = new Fyers("https://api-t1.fyers.in/api/v3/", "WX1CU36E86-100", "AFX21W5OED", "1124",7);
            login.AuthCode = Utils.ReadFromFile("authcode.txt");

            //login test 
            //profile 
       
             login.AccessToken = Utils.ReadFromFile("access_token.txt");
             login.RefreshToken = Utils.ReadFromFile("refresh_token.txt");
            //var result = await login.PlaceOrder("NSE:GAIL-EQ",1,1,1,"CNC",124.90m,0,"DAY",0,0,false,0);
            OrderRequest orderRequest;
           /*  orderRequest = new()
            {
                symbol = "NSE:HINDALCO-EQ",
                qty = 2,
                type =1,
                side = 1,
                productType = ProductType.CNC.ToString(),
                validity = "DAY",
                limitPrice = 100 ,
                offlineOrder = false
                          
            };*/
           /* await login.PlaceOrder(orderRequest);*/

            //List<OrderRequest> data = new();
            //data.Add(orderRequest);

            orderRequest = new()
            {
                symbol = "NSE:TATASTEEL-EQ",
                qty = 2,
                type = 1,
                side = 1,
                productType = ProductType.CNC.ToString(),
                validity = "DAY",
                limitPrice = 100,
                offlineOrder = false

            };
            // data.Add(orderRequest);

            // var result = await login.PlaceOrder(orderRequest);
            //var result = await login.ModifyOrder("24030400260908",12,1,1,199.95m,0);
            //var result = await login.CancellOrder("24030400260908");
            //var result = await login.ExitAllOpenPosition();
            //var result = await login.ExitPositionBySymbolId("nse","gail","eq",ProductType.CNC);


            List<int> segemnets = [10];

            List<int> sides = [1, -1];

            List<string> productTypes =
            [
                "CNC"
            ];

            var result = await login.ExitPositionBySegmentsSidesAndProductType(segemnets, sides, productTypes);
            Console.WriteLine(result);
            //var result = await login.Profile();
            //var result =  login.GetLoginUrl();
            //var result = await login.GetAccessTokenFromAuthCodeAsync();

            /* Console.WriteLine(login.AccessToken);
             Console.WriteLine("====================");
             Console.WriteLine(login.RefreshToken);
              Console.WriteLine("====================");*/

            //Console.WriteLine(result);



            /* Console.WriteLine("testing delete with data");
             string access_token = "WX1CU36E86-100:eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhcGkuZnllcnMuaW4iLCJpYXQiOjE3MDg4NTQ4NDMsImV4cCI6MTcwODkwNzQwMywibmJmIjoxNzA4ODU0ODQzLCJhdWQiOlsieDowIiwieDoxIiwieDoyIiwiZDoxIiwiZDoyIiwieDoxIiwieDowIl0sInN1YiI6ImFjY2Vzc190b2tlbiIsImF0X2hhc2giOiJnQUFBQUFCbDJ3NDdfOVFLMkxoZ283VDd0SE9fSEgybHN6U2t5UmNSMFptR2xfSFgwLWhpU2tsaldsWWlXdXlNNlZtUVVQbTBfQWxPVllvYnBnQUNQY1RoRjVJNktaVGtLR3h0T2FqOTE1Nm4tTUVWMk5sdm55cz0iLCJkaXNwbGF5X25hbWUiOiJHVUREVSAgQ0hBVUhBTiIsIm9tcyI6IksxIiwiaHNtX2tleSI6IjUyZjVkNjU5NWRlNWNiMjdmYzcyZWM3M2Q4MGMwNGVlZDA5NWQyZTBiNDRlMTNlZjQyZDhmZTE2IiwiZnlfaWQiOiJYRzAzNTY3IiwiYXBwVHlwZSI6MTAwLCJwb2FfZmxhZyI6Ik4ifQ.Au6yy1R4d93_Jc96y3zJAqYZuqnBaQZVpLbTxDSTbJ8";
             Uri baseAddress = new Uri("https://api-t1.fyers.in/api/v3/");
             Uri baseDataAddress = new Uri("https://api-t1.fyers.in/data/");
             string? endPoint = "orders/sync";

             HttpClient client = new HttpClient();


             //var result =await GetByGC(client, access_token, baseDataAddress, "history?symbol=NSE:GAIL-EQ&resolution=1D&date_format=1&range_from=2024-01-01&range_to=2024-02-24&cont_flag=1");

             var data = "{\r\n  \"id\": \"52009227353\"\r\n}";
             CancellOrderResponse? result;
             client.BaseAddress = baseAddress;
             client.Timeout = TimeSpan.FromSeconds(7);

             string uri = baseAddress + "orders/sync";

             HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, "https://api-t1.fyers.in/api/v3/orders/sync");
             request.Content = new StringContent(data, Encoding.UTF8, "Aplication/json");


             client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", access_token);
             client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "Aplication/json");
             HttpResponseMessage? response;
             try
             {
                 response = await client.SendAsync(request);
                 Console.WriteLine("response.RequestMessage : " + response.RequestMessage);
                 //Console.WriteLine("response.Headers : " + response.Headers);
                 result = await response.Content.ReadFromJsonAsync<CancellOrderResponse>();
                 Console.WriteLine($"id : {result.id}");
                 Console.WriteLine($"message : {result.message}");
                 Console.WriteLine($"s : {result.s}");
                 Console.WriteLine($"id : {result.code}");


             }
             catch (TaskCanceledException e)
             {
                 Console.WriteLine($"TaskCanceledException: {e.Message}");
             }
             catch (Exception e)
             {
                 Console.WriteLine($"Exception Error: {e}");
                 Console.WriteLine(e.Message);
                 Console.WriteLine(e.StackTrace);
                 Console.WriteLine(e.InnerException);

             }



             client.Dispose();*/



            /*   string AuthCode = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhcGkubG9naW4uZnllcnMuaW4iLCJpYXQiOjE3MDg5NjA1NzIsImV4cCI6MTcwODk5MDU3MiwibmJmIjoxNzA4OTU5OTcyLCJhdWQiOiJbXCJ4OjBcIiwgXCJ4OjFcIiwgXCJ4OjJcIiwgXCJkOjFcIiwgXCJkOjJcIiwgXCJ4OjFcIiwgXCJ4OjBcIl0iLCJzdWIiOiJhdXRoX2NvZGUiLCJkaXNwbGF5X25hbWUiOiJYRzAzNTY3Iiwib21zIjoiSzEiLCJoc21fa2V5IjoiNTJmNWQ2NTk1ZGU1Y2IyN2ZjNzJlYzczZDgwYzA0ZWVkMDk1ZDJlMGI0NGUxM2VmNDJkOGZlMTYiLCJub25jZSI6IiIsImFwcF9pZCI6IldYMUNVMzZFODYiLCJ1dWlkIjoiYmUwNGEzMzEzZGYwNDdhM2EwNTdlYTBmMjE4NzYwMTkiLCJpcEFkZHIiOiIwLjAuMC4wIiwic2NvcGUiOiIifQ.aPSh0Yu8C5FnRCcIR_mEkrioLfYVzxfn3E_Pq8ZT0ak";
               string AppIdHash = "19ce8fadfc4d2218dba5d0c7ac988bdfc228e346cd79c1df9b124182aa0c2c1e";


   */
        }












    }
}
/*curl--location--request POST 'https://api-t1.fyers.in/api/v3/validate-authcode' \
--header 'Content-Type: application/json' \
--data-raw '{
    "grant_type":"authorization_code",  
    "appIdHash":"c3efb1075ef2332b3a4ec7d44b0f05c1********************",
    "code":"eyJ0eXAi*******.eyJpc3MiOiJhcGkubG9********.r_65Awa1kGdsNTAgD******"
}'

----------------------------------------------------------------------------------
Sample Success Response               
----------------------------------------------------------------------------------          

{
  's': 'ok',
  'code': 200,
  'message': '',
  'access_token': 'eyJ0eXAiOi***.eyJpc3MiOiJh***.HrSubihiFKXOpUOj_7***',
  'refresh_token': 'eyJ0eXAiO***.eyJpc3MiOiJh***.67mXADDLrrleuEH_EE***'
}
*/