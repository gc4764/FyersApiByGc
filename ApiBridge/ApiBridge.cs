using GCLibrary.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiBridge.Trade;
using ApiBridge.Context;
using ApiBridge.Context.Broker;

namespace ApiBridge
{
    public class ApiBridge(IBrokerContext brokerContext, UserContext userCtx, ILogger logger)
    {

        protected IBrokerContext _brokerContext = brokerContext;
        protected UserContext _userCtx = userCtx;
        protected ILogger _logger = logger;


        public void Run( RequestMessageContext cmd) 
        {
            if (Validate(cmd))
            {
                LiveTrade liveTrade = new(_brokerContext, _userCtx, _logger);
                liveTrade.Run(cmd);
            }
            else
            {
                return;
            }

        }

        private bool Validate(RequestMessageContext cmd)
        {
            _logger.Log(" cmd validation is successfull");
            return true;
        }
    }
}
