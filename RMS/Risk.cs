using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public class Risk
    {
        protected decimal _capital;
        protected decimal _riskPercent;

        protected decimal _riskAmount;
        protected decimal _minimumRiskAmount;
        protected decimal _maximumRiskAmount;
        protected string? _note;

        public Risk(decimal capital, decimal riskPercent, decimal minimumRiskAmount, decimal maximumRiskAmount, string? note)
        {
            _capital = capital;
            _riskPercent = riskPercent;
            _minimumRiskAmount = minimumRiskAmount;
            _maximumRiskAmount = maximumRiskAmount;
            _note = note;
            SetRiskAmount(ref _riskAmount);
        }

        private void SetRiskAmount(ref decimal _riskAmount)
        {
            decimal _risk = _capital * RiskPercent / 1000;
            if (_risk < _minimumRiskAmount) _riskAmount = _minimumRiskAmount;
            else if (_risk > _maximumRiskAmount) _riskAmount = _maximumRiskAmount;
            else _riskAmount = _risk;
        }
        public decimal Capital { get
            {
                return _capital;
            }
            set
            {
                _capital = value;
                SetRiskAmount(ref _riskAmount); 
            } }

        
        public decimal RiskPercent
        {
            get
            {
                return _riskPercent;
            }
            set
            {
                _riskPercent = value;
                SetRiskAmount(ref _riskAmount);
            }
        }

        public decimal MinimumRiskAmount 
        {
            get
            {
                return _minimumRiskAmount;

            }
            set
            {
                _minimumRiskAmount = value;
                SetRiskAmount(ref _riskAmount);

            } 
        }

        public decimal MaximumRiskAmount
        {
            get
            {
                return _maximumRiskAmount;
            }
            set
            {
                _maximumRiskAmount = value;
                SetRiskAmount(ref _riskAmount);

            } 
        }


        public decimal RiskAmount
        {
            get
            {
                return _riskAmount;
            }
        }
        public string? Note { get
            {
                return _note;
            } set
            {
                _note = value;

            } 
        }
    }
}
