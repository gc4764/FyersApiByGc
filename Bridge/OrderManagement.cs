using GCLibrary.Logger;
using GCLibrary.Context;
using GCLibrary.Http;
using GCLibrary.Position;
using GCLibrary.Models;

namespace ApiBridge
{
    public class OrderManagement
    {
        private UserContextModel _userContextModel;
        private IGCLogger _logger = new ConsoleLogger();
       
        private ICommandContext _commandContext = new CommandModel();

        public void FireOrder()
        {
            if (_commandContext != null)
            {
                if (_commandContext.GetOrderType() == "LE") PlaceBuyOrder();
                else if (_commandContext.GetOrderType() == "SE") PlaceSellOrder();
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
           
           
        }

        public OrderManagement SetUserContextModel(UserContextModel userContextModel)
        {
            _userContextModel = userContextModel;
            return this;
        }

  
        public OrderManagement SetRequestMessageContext(ICommandContext commandContext)
        {
            _commandContext = commandContext;
            return this;
        }

        public OrderManagement SetLogger(IGCLogger logger)
        {
            _logger = logger;
            return this;
        }

        public IGCLogger Logger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


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