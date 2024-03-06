﻿using ApiBridge.Context;
using ApiBridge.Context.Broker;
using GCLibrary.Logger;
using RMS;

namespace ApiBridge.Trade
{
    internal class OrderManagement
    {
        public OrderManagement(IBrokerContext brokerContext, UserContext userContext, ILogger logger)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
        }

        public IBrokerContext BrokerContext { get; }
        public UserContext UserContext { get; }
        public ILogger Logger { get; }

        public string FireOrder(RequestMessageContext cmd)
        {
            string? result;
            Position position = new(BrokerContext, UserContext, Logger, cmd);
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
        }
    }
}