using ApiBridge.Context;
using ApiBridge.Context.Broker;
using ApiBridge.Filter;
using GCLibrary.Logger;
using RMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public Task<string> Run(RequestMessageContext cmd)
        {
            string result;
            CheckList checkList = new(_userContext, _logger ,cmd);
            if (checkList.Validate())
            {
                RMSTest rmsTest = new(_brokerContext, _userContext, _logger ,cmd);
                if(rmsTest.Validate())
                {
                    OrderManagement orderManagement = new(_brokerContext, _userContext, _logger);
                    result = orderManagement.FireOrder(cmd);
                    
                    return Task.FromResult(result);
                }    
                return Task.FromResult(string.Empty);
            }    
            return Task.FromResult(string.Empty);
        }
      
    }
}
