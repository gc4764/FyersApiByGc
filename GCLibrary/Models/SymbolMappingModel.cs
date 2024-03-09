using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Models
{
    public class SymbolMappingModel
    {
        public int Id { get; set; }
        public required string MappedSymbol { get; set; }
        public required string TradingSymbol { get; set; }
        public string Exchange { get; set; }
        public string ScripCode { get; set; }
        public string Series { get; set; }
        public decimal StrikePrice { get; set; }
        public string Expiry { get; set; }

    }
}
