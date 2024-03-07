using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;
using GCLibrary.Interfaces;

namespace ApiBridge.Filter
{
    internal class LocalRMSTest
    {
        public LocalRMSTest(IBrokerContext brokerContext, UserContext userContext, ILogger logger, IRequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public ILogger Logger { get; }
        public IRequestMessageContext Cmd { get; }

        internal bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}