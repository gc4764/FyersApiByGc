using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Calculator
{
    public class CapitalRiskCalculator
    {

        protected decimal _capital;
        protected decimal _riskPercent;

        protected int _maxOpenPosition;
        protected decimal _maxRiskPerTrade;


        protected decimal _riskAmount;
        protected decimal _minimumRiskAmount;
        protected decimal _maximumRiskAmount;
        protected string? _note;

        public CapitalRiskCalculator(decimal capital, decimal riskPercent, decimal minimumRiskAmount, decimal maximumRiskAmount, string? note)
        {
            _capital = capital;
            _riskPercent = riskPercent;
            _minimumRiskAmount = minimumRiskAmount;
            _maximumRiskAmount = maximumRiskAmount;
            _note = note;
            SetRiskAmount(ref _riskAmount);
        }

        public int MaxOpenPosition { get { return _maxOpenPosition; } set { _maxOpenPosition = value; } }

        public decimal MaxRiskPerTrade { get { return _maxRiskPerTrade; } set { _maxRiskPerTrade = value; } }
        private void SetRiskAmount(ref decimal _riskAmount)
        {
            decimal _risk = _capital * RiskPercent / 1000;
            if (_risk < _minimumRiskAmount) _riskAmount = _minimumRiskAmount;
            else if (_risk > _maximumRiskAmount) _riskAmount = _maximumRiskAmount;
            else _riskAmount = _risk;
        }
        public decimal Capital
        {
            get
            {
                return _capital;
            }
            set
            {
                _capital = value;
                SetRiskAmount(ref _riskAmount);
            }
        }


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
        public string? Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;

            }
        }
    }
}
