using GCLibrary.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiBridge.Trade;
using ApiBridge.Context;
using ApiBridge.Context.Broker;
using System.Configuration.Assemblies;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ApiBridge
{
    public class ApiBridge(IBrokerContext brokerContext, UserContext userCtx, bool IsLiveMode ,ILogger logger)
    {

        protected IBrokerContext _brokerContext = brokerContext;
        protected UserContext _userCtx = userCtx;
        protected ILogger _logger = logger;

        public void Run( RequestMessageContext cmd) 
        {
            if (Validate(cmd))
            {
                if(IsLiveMode)
                {
                    LiveTrade liveTrade = new(_brokerContext, _userCtx, _logger);
                    liveTrade.Run(cmd);
                }
                else
                {
                    PaperTrade paperTrade = new();
                    
                }
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
