using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GCLibrary.Http
{
    public class HttpRequest(string base_address, int seconds)
    {
        public int TimeOut { get; set; } = seconds;
        public string BaseAddress { get; set; } = base_address;

        //public static string? AccessToken  { get; set; } = null ;
        // public static string? ClientId { get; set; } 
        //public static string? ClientSecret { get; set; } = null;
        // public static string? AuthCode { get; set; } = null;

        public async Task<string?> GetByGcAsync(string? endPoint,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict)
        {
            var result = await RequestAsync(HttpMethod.Get, endPoint, url_parameter_dict, headers_in_dict, null);
            return result;
        }



        public async Task<string?> PostByGcAsync(string? endPoint,
              Dictionary<string, string>? url_parameter_dict,
              Dictionary<string, string>? headers_in_dict,
              object daataObject)
        {
            var result = await RequestAsync(HttpMethod.Post, endPoint, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }



        public async Task<string?> DeleteByGcAsync(string? endPoint,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            object daataObject)
        {
            var result = await RequestAsync(HttpMethod.Delete, endPoint, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }



        /*
                public  async Task<string?> PutByGcAsync(string? endPoint,
                    Dictionary<string, string>? url_parameter_dict,
                    Dictionary<string, string>? headers_in_dict,
                    Object daataObject)
                {
                    var result = await RequestAsync(HttpMethod.Post, endPoint, url_parameter_dict, headers_in_dict, daataObject);
                    return result;
                }
        */



        public async Task<string?> PatchByGcAsync(string? endPoint,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            object daataObject)
        {
            var result = await RequestAsync(HttpMethod.Patch, endPoint, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }




        private async Task<string?> RequestAsync(HttpMethod method,
            string? endPoint,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            object? dataObject)
        {


            string? result;
            using (HttpClient client = new())
            {
                // time out in seconds
                client.Timeout = TimeSpan.FromSeconds(TimeOut);
                // dictionry to url parameter
                string urlParams;
                if (url_parameter_dict != null)

                    urlParams = GetParamsFromDictionary(url_parameter_dict);
                else
                    urlParams = "";
                // full address
                string address;
                endPoint ??= "";
                address = BaseAddress + endPoint + urlParams;

                // request message 
                HttpRequestMessage requestMessage = new(method, address);
                // converting object to json serialized data and inserting it 
                if (dataObject != null)
                {
                    string jsonData = JsonSerializer.Serialize(dataObject);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    requestMessage.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    // requestMessage.Headers.Add("Content-Type", "application/json");

                }

                // adding headers
                if (headers_in_dict != null)
                {
                    foreach (KeyValuePair<string, string> kvp in headers_in_dict)
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation(kvp.Key, kvp.Value);
                    }
                }
                /*if (authheader != null)
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authheader);*/
                // requestMessage.Headers.Add(" Authorization", authheader);
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"{ClientId}:{AccessToken}");
                var response = await client.SendAsync(requestMessage);
                if (response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsStringAsync();
                else
                    result = response.ReasonPhrase;

            }

            return result;
        }
        private static string DictionaryToParams(Dictionary<string, string> dict)
        {
            string raw_parameters = "?";
            foreach (var key in dict.Keys)
            {
                raw_parameters += key + "=" + dict[key] + "&";
            }
            string parameters = raw_parameters.Remove(raw_parameters.LastIndexOf('&'));


            return parameters;
        }

        private static string GetParamsFromDictionary(Dictionary<string, string>? dict = null)
        {
            if (dict == null)
            {
                return "";
            }
            else
            {
                string paramameter = DictionaryToParams(dict);
                return paramameter;
            }
        }
    }
}
