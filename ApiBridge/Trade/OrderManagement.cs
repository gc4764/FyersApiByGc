using GCLibrary.Logger;
using GCLibrary.Interfaces;
using RMS;

namespace ApiBridge.Trade
{
    internal class OrderManagement
    {
        public OrderManagement(IBrokerContext brokerContext, IUserContext userContext, ILogger logger)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
        }

        public IBrokerContext BrokerContext { get; }
        public IUserContext UserContext { get; }
        public ILogger Logger { get; }

        public string FireOrder(IRequestMessageContext cmd)
        {
            string? result;
            /*Position position = new(BrokerContext, UserContext, Logger, cmd);*/
            Position position = new();
            if (cmd == null) { return string.Empty; }
            if (cmd.OrderType == "LE")
            {
               position.ManageLE();
            } 
            else if (cmd.OrderType == "SE")
            {
                position.ManageSE();
            }
            else if(cmd.OrderType == "LX")
            {
                position.ManageLX();
            }
            else if( cmd.OrderType == "SX")
            {
                position.ManageSX();
            }

            result = string.Empty;  

            return result;
        }
    }
}