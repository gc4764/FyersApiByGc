using GCLibrary.Logger;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using GCLibrary.Filter;
using ApiBridge.Filter;
using ApiBridge.DummyClasses;
using GCLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Bridge.DummyClasses;


namespace ApiBridge
{
    public class Program
    {
        static void Main(string[] args)
        {


            // dummy context
            BrokerContext brokerContext = new BrokerContextDummy();
            UserContext userContext = new UserContextDummy();
            RequestMessageContext requestMessageContext = new RequestMessageContextDummy();

            // get context from db
            string broker_name = "fyers";

            brokerContext = BrokerContext.ContextBuilder.BrokerName(broker_name).Build();

            IGCLogger logger = new ConsoleLogger();


            WhiteListFilter whiteListFilter = new();
            BlackListFilter blackListFilter = new();
            GlobalRMSFilter globalRMSFilter = new();
            LocalRMSFilter localRMSFilter = new();
            PositionFilter positionFilter = new();


            FilterManager filterManager = new();

            filterManager.Add(whiteListFilter);
            filterManager.Add(blackListFilter);
            filterManager.Add(globalRMSFilter);
            filterManager.Add(localRMSFilter);
            filterManager.Add(positionFilter);

            Response response = filterManager.Use();

            if (response != null)
            {
                return;
            }



            OrderManagement orderManagement = new OrderManagement()
                .SetLogger(logger)
                .SetRequestMessageContext(requestMessageContext)
                .SetBrokerContext(brokerContext)
                .SetUserContext(userContext);

            orderManagement.FireOrder();



        }
    }
}