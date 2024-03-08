using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Scrips
{
    public class Option : Derivative
    {
        public string OptionType { get; set; } = string.Empty;
        public decimal Strike { get; set; } = decimal.Zero;

    }
}
