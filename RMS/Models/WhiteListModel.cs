﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class WhiteListModel : StockListModel
    {
        protected WhiteListModel(string mappingSymbol, string tradingSymbol) : base(mappingSymbol, tradingSymbol)
        {
        }
    }
}
