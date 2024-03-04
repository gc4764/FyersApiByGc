using FyersApiByGc.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc
{
    public enum OrderType
    {
        LimitOrder=1,
        MarketOrder=2,
        StopLossMarketOrder=3,
        StopLossLimitOrder=4
    }

    public enum ProductType
    {
        Intraday,
        CNC,
        Margin,
        CO,
        BO
    }

    public enum Validity
    {
        DAY,
        IOC
    }

    public enum OrderSide
    {
        Buy=1,
        Sell=-1
    }

    public enum PositionSide
    {
        Long = 1,
        Short = -1,
        ClosedPosition= 0

    }


    public enum HoldingType
    {
        T1,
        HLD
    }


    public enum OrderSource 
    {
        Mobile= 'M',
        Web='W',
        FyerOne='R',
        Admin='A',
        API='I'
    }




    /*
     * URL update for various APIs
    Enhanced History API available at: https://api-t1.fyers.in/data/history
    New Market Status API introduced at: https://api-t1.fyers.in/data/marketStatus
    Enhanced Quotes API available at: https://api-t1.fyers.in/data/quotes
    Enhanced Market Depth API available at: https://api-t1.fyers.in/data/depth
    */


    public enum Exchanges
    {
        NSE=10,
        MCX=11,
        BSE=12
    }

    
    public enum Segment
    {
        CapitalMarket=10,
        EquityDerivatives=11,
        CurrencyDerivatives=12,
        CommodityDerivatives=20
    }

    public enum OrderStatus
    {
        Cancelled=1,
	    Traded=2,
	    Forfutureuse=3,
	    Transit=4,
	    Rejected=5,
	    Pending=6
    }













}
