using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Interfaces
{
    public interface IPosition
    {
        public void AddLong(string long_scrip_symbol);
        public void AddShort(string long_scrip_symbol);
        public HashSet<string> LongPositions();
        public HashSet<string> ShortPositions();
        public HashSet<string> TotalPositions();

        public void RemoveLong(string long_scrip_symbol);
        public void RemoveShort(string short_scrip_symbol);


        public int CountLongPosition { get; }
        public int CountShortPosition { get; }
        public int CountTotalPosition { get; }
    }
}
