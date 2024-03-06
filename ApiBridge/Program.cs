using GCLibrary.Logger;
using GCLibrary.Interfaces;


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





        }
    }
}