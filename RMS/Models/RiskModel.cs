using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class RiskModel(decimal capital, decimal riskPercent, decimal minimumRiskAmount, decimal maximumRiskAmount, string? note) 
        : Risk(capital, riskPercent, minimumRiskAmount, maximumRiskAmount, note)
    {
    }
}
