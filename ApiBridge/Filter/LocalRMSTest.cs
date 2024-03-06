using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;

namespace ApiBridge.Filter
{
    internal class LocalRMSTest
    {
        public LocalRMSTest(IBrokerContext brokerContext, UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public ILogger Logger { get; }
        public RequestMessageContext Cmd { get; }

        internal bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}