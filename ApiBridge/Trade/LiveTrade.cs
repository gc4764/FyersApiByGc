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
                else
                {
                    return Task.FromResult(string.Empty);
                }
                 

            }
            else
            {
                return Task.FromResult(string.Empty);
            }

        }

        private async Task<bool> RMSTest(UserContext userContext, RequestMessageContext cmd)
        {
            if(await CheckGlobalRisk(_userContext))
            {
                if(await CheckLocalRisk(_userContext, cmd))
                    return true;
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private Task<bool> CheckGlobalRisk(UserContext userContext)
        {
            throw new NotImplementedException();
        }

        private Task<bool> CheckLocalRisk(UserContext userContext, RequestMessageContext cmd)
        {
            throw new NotImplementedException();
        }

        private Task<bool> CheckList(UserContext userContext, RequestMessageContext cmd)
        {
            if(WhiteListModel(userContext, cmd))
            {
                if(BlackListModel(userContext, cmd))
                { return Task.FromResult(false); }
                else { return Task.FromResult(true); }
            }
            else
            {
                return Task.FromResult(false);
            }
            
        }

        private bool BlackListModel(UserContext userContext, RequestMessageContext cmd)
        {
            throw new NotImplementedException();
        }

        private bool WhiteListModel(UserContext userContext, RequestMessageContext cmd)
        {
            throw new NotImplementedException();
        }

        private Task<string> FireOrder(UserContext userContext, RequestMessageContext cmd)
        {
            throw new NotImplementedException();
        }

      
    }
}
