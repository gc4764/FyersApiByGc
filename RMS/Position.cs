using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public class Position : IPosition
    {
        protected HashSet<string> _longPositions  = [];
        protected HashSet<string> _shortPositions  = [];
        protected HashSet<string> _totalPositions = [];


        
        public void AddLong(string long_scrip_symbol)
        {
             _longPositions.Add(long_scrip_symbol);
            _totalPositions.Add(long_scrip_symbol);

        }

        public HashSet<string> LongPositions()
        {
            return _longPositions;
        }

        public void AddShort(string short_scrip_symbol)
        {
            _shortPositions.Add(short_scrip_symbol);
            _totalPositions.Add(short_scrip_symbol);
        }

        public HashSet<string> ShortPositions()
        {
            return _shortPositions;
        }

        public void RemoveLong(string long_scrip_symbol)
        {
             _longPositions.Remove(long_scrip_symbol);
            _totalPositions.Remove(long_scrip_symbol);

        }

        public void RemoveShort(string short_scrip_symbol)
        {
            _shortPositions.Remove(short_scrip_symbol);
            _totalPositions.Remove(short_scrip_symbol);

        }

        public HashSet<string> TotalPositions()
        {
            return _totalPositions;
        }
    }
}
