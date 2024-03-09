using GCLibrary.Logger;
using GCLibrary.Filter;
using ApiBridge.Filter;
using GCLibrary;
using GCLibrary.Models;
using GCLibrary.Repository;


namespace ApiBridge
{
    public class Program
    {
        static void Main(string[] args)
        {


            IGCLogger logger = new ConsoleLogger();

            RMSFilter rmsFilter = new();
            PositionFilter positionFilter = new();

            new FilterManager().Add(rmsFilter);
            new FilterManager().Add(positionFilter);

            Response response = new FilterManager().Filter();

            if (response != null)
            {
                return;
            }



            OrderManagement orderManagement = new OrderManagement()
                .SetLogger(logger)
                .SetRequestMessageContext(requestMessageContext)
                .SetUserContextModel(userContextModel);

            orderManagement.FireOrder();



        }
    }
}