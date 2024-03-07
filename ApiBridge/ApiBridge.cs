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
using Microsoft.Extensions.Configuration.Json;
using GCLibrary.Interfaces;

namespace ApiBridge
{
    public class ApiBridge(IBrokerContext brokerContext, UserContext userCtx, ILogger logger)
    {

        protected IBrokerContext _brokerContext = brokerContext;
        protected UserContext _userCtx = userCtx;
        protected ILogger _logger = logger;

        public void Run( IRequestMessageContext cmd) 
        {
            IConfigurationRoot appConfig = new ConfigurationBuilder().AddJsonFile("appConfig.json").Build();
            bool IsLiveMode = appConfig.GetValue<bool>("IsLiveMode");

            if(IsLiveMode)    
            {
                FilterManager filterManager = new FilterManager();
               
                

                LiveTrade liveTrade = new(_brokerContext, _userCtx, _logger);
                liveTrade.Run(cmd);
            }
            else
            {
                PaperTrade paperTrade = new();
                    
            }
         

        }

        private bool Validate(IRequestMessageContext cmd)
        {
            _logger.Log(" cmd validation is successfull");
            return true;
        }
    }
}
