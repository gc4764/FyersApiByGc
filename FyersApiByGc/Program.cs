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


namespace FyersApiByGc
{
    internal class Program
    {
        public static string client_id = "WX1CU36E86-100";
        public static string app_secret = "AFX21W5OED";
        public static string redirect_uri = "https://trade.fyers.in/api-login/redirect-uri/index.html";
        public static string baseurlV2 = "https://api.fyers.in/api/v2/";
        public static string baseurlV3 = " https://api-t1.fyers.in/api/v3/";
        public static string url = $"{baseurlV3}generate-authcode?client_id={client_id}&redirect_uri={redirect_uri}&response_type=code&state=sample_state";

        static string appid = ReadFromFile("./appid.txt");
        static string secret = ReadFromFile("./secret.txt");
        static string authcode = ReadFromFile("./authcode.txt");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            ValidateAuthCode();
            Console.WriteLine();


            Console.WriteLine();
       

        }

        public static string GetLoginUrl()
        { 
            return url; 
        }

        public static void LoginStep1()
        {
         
        }

        public static void ValidateAuthCode()
        {
            string url = "https://api-t1.fyers.in/api/v3/validate-authcode";

            var client =(HttpWebRequest) WebRequest.Create(url);

            client.Method = "POST";
            client.ContentType = "application/json";

            var param = new Dictionary<string, string>();
            param["grant_type"] = "authorization_code";
            param["appIdHash"] = SHA256Hash();
            param["code"] = authcode;


            var restClient = new RestClient(url);
            var request =  new RestRequest();
            restClient.AddDefaultHeader("Content-Type", "application/json");
            restClient.AddDefaultParameter("grant_type", "authorization_code");
            restClient.AddDefaultParameter("appIdHash", SHA256Hash());
            restClient.AddDefaultParameter("code", authcode);

            var data = restClient.PostAsync(request);
            Console.WriteLine(data.Result);

      
        

        }

        public static string SHA256Hash()
        {
           
            string inputString = client_id + ":" + app_secret;
            string hash = string.Empty;

            using( var crypt = new SHA256Managed())
            {
                 hash = BitConverter.ToString(crypt.ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-","");
            }

            Console.WriteLine(inputString);
            Console.WriteLine(hash);
            return hash;

        }

        public static string ReadFromFile(string path)
        {
            string data = "";
            try
            {
                data = File.ReadAllText(path);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
            return data;
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