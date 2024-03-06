using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GCLibrary.Http
{
    public class HttpRequestV3(int time_out_in_seconds)
    {
        public int TimeOut { get; set; } = time_out_in_seconds;



        public async Task<string?> GetByGcAsync
            (
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict
            )
        {
            var result = await RequestAsync(HttpMethod.Get, fullAddress, url_parameter_dict, headers_in_dict, null);
            return result;
        }



        public async Task<string?> PostByGcAsync
            (
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            Object daataObject
            )
        {
            var result = await RequestAsync(HttpMethod.Post, fullAddress, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }



        public async Task<string?> DeleteByGcAsync
            (
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            Object daataObject
            )
        {
            var result = await RequestAsync(HttpMethod.Delete, fullAddress, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }




        public async Task<string?> PutByGcAsync
            (
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            Object daataObject
            )
        {
            var result = await RequestAsync(HttpMethod.Put, fullAddress, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }




        public async Task<string?> PatchByGcAsync
            (
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            Object daataObject
            )
        {
            var result = await RequestAsync(HttpMethod.Patch, fullAddress, url_parameter_dict, headers_in_dict, daataObject);
            return result;
        }




        private async Task<string?> RequestAsync
            (
            HttpMethod method,
            string fullAddress,
            Dictionary<string, string>? url_parameter_dict,
            Dictionary<string, string>? headers_in_dict,
            Object? dataObject
            )

        {
            string? result;
            using (HttpClient client = new())
            {
                // time out in seconds
                client.Timeout = TimeSpan.FromSeconds(TimeOut);

                // request message 
                HttpRequestMessage requestMessage = new(method, fullAddress);
                // converting object to json serialized data and inserting it 
                if (dataObject != null)
                {
                    string jsonData = JsonSerializer.Serialize(dataObject);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    requestMessage.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                }

                // adding headers
                if (headers_in_dict != null)
                {
                    foreach (KeyValuePair<string, string> kvp in headers_in_dict)
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation(kvp.Key, kvp.Value);
                    }
                }

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
