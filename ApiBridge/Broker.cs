using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS;
using RMS.Models;

namespace ApiBridge
{
    public class Broker
    {
        public string AccessToken { get; set; }
        public Broker() { }
        public Broker(string name) { }

        public void Run(MessageCommand cmd)
        {
            throw new NotImplementedException();
        }
        public void Run(TradingContext tctx)
        {
            throw new NotImplementedException();
        }

        public void Run(TradingContext tctx, MessageCommand cmd)
        {
            throw new NotImplementedException();
        }
        public List<StockListModel> StockList { get; }
        public List<WhiteListModel> WhiteList { get; }
        public List<BlackListModel> BlackLis { get; }

    }
}
