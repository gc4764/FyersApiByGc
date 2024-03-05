using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;

namespace ApiBridge.Trade
{
    public class RMSTest
    {
   

        public RMSTest(IBrokerContext brokerContext, UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public RequestMessageContext Cmd { get; }
        public ILogger Logger { get; }

        public bool Validate()
        {
            GlobalRMSTest globalRMSTest = new(BrokerContext, UserContext,Logger ,Cmd);

            LocalRMSTest localRMSTest = new(BrokerContext, UserContext,Logger ,Cmd);

            if(globalRMSTest.Validate())
            {
                if (localRMSTest.Validate())
                {
                    return true;
                }else { return false; }
            } else { return false; }
        }
    }
}