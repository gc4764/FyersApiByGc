using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;
using GCLibrary.Interfaces;

namespace ApiBridge.Filter
{
    public class RMSTest
    {


        public RMSTest(IBrokerContext brokerContext, UserContext userContext, ILogger logger, IRequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public IBrokerContext BrokerContext { get; }
        public IUserContext UserContext { get; }
        public IRequestMessageContext Cmd { get; }
        public ILogger Logger { get; }

       
    }
}