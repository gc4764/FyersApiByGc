using GCLibrary.Logger;
using ApiBridge.DummyClasses;
using GCLibrary.Context;
using GCLibrary.Http;

namespace ApiBridge
{
    public class OrderManagement
    {
        private IGCLogger _logger = new ConsoleLogger();
        private BrokerContext _brokerContext = new();
        private UserContext _userContext = new();
        private RequestMessageContext _requestMessageContext = new();

        public void FireOrder()
        {
            if (_requestMessageContext != null)
            {
                if (_requestMessageContext.OrderType == "LE") PlaceBuyOrder();
                else if (_requestMessageContext.OrderType == "SE") PlaceSellOrder();
                else LogOrderError();
            }

        }

        private void PlaceSellOrder()
        {
            throw new NotImplementedException();
        }

        private void LogOrderError()
        {
            throw new NotImplementedException();
        }

        private void PlaceBuyOrder()
        {
            HttpRequestByGc httpRequestByGc = new(_brokerContext.BaseUrl, 7);
            httpRequestByGc.PostByGcAsync()
        }

        public OrderManagement SetUserContext(UserContext userContext)
        {
            _userContext = userContext;
            return this;
        }

        public OrderManagement SetBrokerContext(BrokerContext brokerContext)
        {
            _brokerContext = brokerContext;
            return this;
        }

        public OrderManagement SetRequestMessageContext(RequestMessageContext requestMessageContext)
        {
            _requestMessageContext = requestMessageContext;
            return this;
        }

        public OrderManagement SetLogger(IGCLogger logger)
        {
            _logger = logger;
            return this;
        }

        public ILogger Logger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        Position position = new Position();

        /* public string FireOrder(IRequestMessageContext cmd)
         {
             string? result;
             *//*Position position = new(BrokerContext, UserContext, Logger, cmd);*//*
             Position position = new();
             if (cmd == null) { return string.Empty; }
             if (cmd.OrderType == "LE")
             {
                position.ManageLE();
             } 
             else if (cmd.OrderType == "SE")
             {
                 position.ManageSE();
             }
             else if(cmd.OrderType == "LX")
             {
                 position.ManageLX();
             }
             else if( cmd.OrderType == "SX")
             {
                 position.ManageSX();
             }

             result = string.Empty;  

             return result;
         }*/

    }
}