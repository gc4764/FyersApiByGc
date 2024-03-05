using ApiBridge.Context;
using ApiBridge.Context.Broker;

namespace ApiBridge.Trade
{
    internal class RMSTest
    {
        public RMSTest(IBrokerContext brokerContext, UserContext userContext, RequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Cmd = cmd;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public RequestMessageContext Cmd { get; }

        internal bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}