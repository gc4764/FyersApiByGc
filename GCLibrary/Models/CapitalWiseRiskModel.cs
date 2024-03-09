using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Models
{
    public class CapitalWiseRiskModel
    {
        public decimal Capital { get; set; }
        public decimal RiskPercent { get; set; }
        public int MaxOpenPosition { get; set; }
        public decimal MaxRiskPerTrade { get; set; }
        public decimal RiskAmount { get; set; }
        public decimal MinimumRiskAmount { get; set; }
        public decimal MaximumRiskAmount { get; set; }
        public string Notes { get; set; }

    }
}
