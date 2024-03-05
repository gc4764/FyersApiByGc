using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public class Scrip
    {
        public string ExchangeName { get; set; } = string.Empty;
        public string ScripName { get; set; } = string.Empty;
        public string ScripCode  { get; set; } = string.Empty;
        public string Segment { get; set; } = string.Empty;
        public string Series { get; set; } = string.Empty;
        public string Fytoken { get; set; } = string.Empty;

        public int LotSize { get; set; } = 1;
        public decimal TickSize { get; set; } = 0.25m;
        public string ISIN { get; set; } = string.Empty;


    }
}
