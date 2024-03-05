using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;

namespace ApiBridge.Trade
{
    internal class OrderManagement
    {
        public OrderManagement(IBrokerContext brokerContext, UserContext userContext, ILogger logger)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public ILogger Logger { get; }

        internal string FireOrder(RequestMessageContext cmd)
        {
            throw new NotImplementedException();
        }
    }
}