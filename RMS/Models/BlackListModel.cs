using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class BlackListModel : StockListModel
    {
        protected BlackListModel(string mappingSymbol, string tradingSymbol) : base(mappingSymbol, tradingSymbol)
        {
        }
    }
}
