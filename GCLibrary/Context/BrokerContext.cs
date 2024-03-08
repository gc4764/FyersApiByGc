using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Context
{
    public class BrokerContext : IBrokerContext
    {

        public BrokerContext() { }
        public string UserName { get; set; } = string.Empty;
        public string AccessToken { get; set; }= string.Empty ;
        public string Pin { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty ;
        public string RouteOrderBook { get; set; } = string .Empty ;

        public string RouteTradeBook { get; set; } = string.Empty;
        public string RoutePosition { get; set; }=string .Empty ;



        public class ContextBuilder
        {
            public static ContextBuilder BrokerName(string brokerName)
            {
                ContextBuilder contextBuilder= new ContextBuilder();
                if (brokerName == "Fyers" )
                {
                    
                    
                }

                return contextBuilder;
            }

            public BrokerContext Build()
            {
                return new BrokerContext();
            }
        }



    }

}
