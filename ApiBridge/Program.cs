using GCLibrary.Logger;
using GCLibrary.Interfaces;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;


namespace ApiBridge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // endpoints localhost:67588/trade/fyers
            // endpoints localhost:67588/trade/dhanapi
            // endpoints localhost:67588/trade/zerodha
            // endpoints localhost:67588/trade/paper
            ILogger logger = new ConsoleLogger();
            //logger.TestLogger();

            IRequestMessageContext cmd;

            IConfigurationRoot cfg = new ConfigurationBuilder().AddJsonFile("mySetting.json").Build();

            Console.WriteLine(cfg.GetValue<string>("fname"));
            Console.WriteLine(cfg.GetValue <string>("lname"));
            Console.WriteLine(cfg.GetValue<long>("mob:mob1"));



        }
    }
}