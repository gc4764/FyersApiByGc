using GCLibrary.Logger;
using GCLibrary.Interfaces;


namespace ApiBridge.Trade
{
    public class LiveTrade
    {
        protected IBrokerContext _brokerContext;
        protected UserContext _userContext;
        protected ILogger _logger;


        public LiveTrade(IBrokerContext brokerContext, UserContext userContext, ILogger logger)
        {
            _brokerContext = brokerContext;
            _userContext = userContext;
            _logger = logger;
        }

        public string Run(IRequestMessageContext cmd)
        {
            
            return string.Empty;
        }
      
    }
}
