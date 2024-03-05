using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class GlobalProfileModel
    {
        public int Id { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? ProfileDescription { get; set; }
        public string? Note { get; set;}

        public TradingModeModel? TradingMode { get; set; }
        public ExchangeSegmentModel? ExchangeSegment { get; set; }
        public TradeSideModel? TradeSide { get; set; }
        public RiskModel? Risk { get; set;}

        
    }

    
}
