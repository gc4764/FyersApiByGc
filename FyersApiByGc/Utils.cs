using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using XAct;

//using XSystem.Security.Cryptography;


namespace FyersApiByGc
{
    public class Utils
    {

        public static string AppIdHash(string client_id, string app_secret)
        {

            string inputString = client_id + ":" + app_secret;
            string hash = string.Empty;

            /*  using (var crypt = new SHA256Managed())
              {
                  var HashInCapital = BitConverter.ToString(crypt.ComputeHash(Encoding.UTF8.GetBytes(inputString))).Replace("-", "");
                  hash = HashInCapital.ToLower();
              }
  */
            var HashInCapital = BitConverter.ToString(SHA256.HashData(Encoding.UTF8.GetBytes(inputString))).Replace("-","");
            hash = HashInCapital.ToLower();
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


        public Dictionary<string, string> ToDictionary(Object obj)
        {
            foreach(var kvp in obj.GetObjectPropertyValues()) 
            {
                var key = kvp.Key;
            }


            return new Dictionary<string, string>();
        }
    }
}
