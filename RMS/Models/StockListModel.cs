using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class StockListModel
    {
        protected int _id;
        protected string _mappingSymbol;
        protected string _tradingSymbol;
        protected string? _exchange;
        protected string? _scripCode;
        protected string? _series;
        protected decimal _strikePrice;
        protected string? _expiry;
        protected StockListModel(string mappingSymbol, string tradingSymbol) 
        {
            _mappingSymbol = mappingSymbol;
            _tradingSymbol = tradingSymbol;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string MappingSymbol { get { return _mappingSymbol; } }
        public string TradingSymbol { get { return _tradingSymbol; } }
        public string Exchange { get { return _exchange; } set { _exchange = value; } }
        public string ScripCode { get { return _scripCode; } set { _scripCode = value; } }
        public string Series { get { return _series; } set { _series = value; } }
        public decimal StrikePrice { get { return _strikePrice; } set { _strikePrice = value; } }
        public string Expiry { get { return _expiry; } set { _expiry=value} }

    }
}
