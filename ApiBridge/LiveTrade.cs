using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBridge
{
    public class LiveTrade
    {
        /* private static bool? _IsValidAccessToken=null;*/
        protected static List<Broker> _brokers = [];

        public static void Run(MessageCommand cmd)
        {
            if (_brokers == null)
            {
                Console.WriteLine("No Broker found for trading");
            }
            else
            {
                foreach (Broker broker in _brokers)
                {
                    broker.Run(cmd);
                }
            }
        }

        public static void AddBroker(Broker broker)
        {
            _brokers.Add(broker);
        }
        public static void RemoveBroker(Broker broker)
        {
            _brokers.Remove(broker);
        }

        public static List<Broker> Brokers {  get { return _brokers; } }

    }
}
