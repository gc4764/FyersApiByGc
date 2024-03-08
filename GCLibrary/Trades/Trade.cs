using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Trades
{
    public abstract class Trade
    {
        protected decimal _price;
        protected decimal _stoplossPrice;
        protected decimal _targetPrice;

        protected decimal _minimumRisk;
        protected decimal _risk = 0;
        protected decimal _maximumRisk;

        protected decimal _minimumReward;
        protected decimal _reward = 0;
        protected decimal _maximumReward;
        protected string? _note = "Algo";

        public Trade(decimal price, decimal stoploss, decimal target, decimal minimumRisk, decimal maximumRisk, decimal minimumReward, decimal maximumReward, string? note)
        {
            _price = price;
            _stoplossPrice = stoploss;
            _targetPrice = target;
            _minimumRisk = minimumRisk;
            _maximumRisk = maximumRisk;
            _minimumReward = minimumReward;
            _maximumReward = maximumReward;
            _note = note;
            SetRisk(ref _stoplossPrice, ref _risk);
            SetReward(ref _targetPrice, ref _reward);
        }

        protected abstract void SetRisk(ref decimal _stoplossPrice, ref decimal _risk);
        protected abstract void SetReward(ref decimal _targetPrice, ref decimal _reward);
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                SetRisk(ref _stoplossPrice, ref _risk);
                SetReward(ref _targetPrice, ref _reward);
            }
        }
        public decimal StopLossPrice
        {
            get
            {
                return _stoplossPrice;
            }
            set
            {
                _stoplossPrice = value;
                SetRisk(ref _stoplossPrice, ref _risk);
            }
        }
        public decimal TargetPrice
        {
            get
            {
                return _targetPrice;
            }
            set
            {
                _targetPrice = value;
                SetReward(ref _targetPrice, ref _reward);
            }
        }
        public decimal MinimumRisk
        {
            get
            {
                return _minimumRisk;
            }
            set
            {
                _minimumRisk = value;
                SetRisk(ref _stoplossPrice, ref _risk);
            }
        }
        public decimal MaximumRisk
        {
            get
            {
                return _minimumRisk;
            }
            set
            {
                _minimumRisk = value;
                SetRisk(ref _stoplossPrice, ref _risk);
            }
        }
        public decimal Risk
        {
            get
            {
                return _risk;
            }
        }
        public decimal Reward
        {
            get
            {
                return _reward;
            }
        }

        public decimal MinimumReward
        {
            get
            {
                return _minimumReward;
            }
            set
            {
                _minimumReward = value;
                SetReward(ref _targetPrice, ref _risk);
            }
        }
        public decimal MaximumReward
        {
            get
            {
                return _maximumReward;
            }
            set
            {
                _maximumReward = value;
                SetReward(ref _targetPrice, ref _risk);
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

        public void Printdata()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($" Price : " + _price);
            Console.WriteLine($" StopLoss : " + _stoplossPrice);
            Console.WriteLine($" Target : " + _targetPrice);

            Console.WriteLine();
            Console.WriteLine($" MinimumRisk : " + _minimumRisk);
            Console.WriteLine($" Risk : " + _risk);
            Console.WriteLine($" MaximumRisk : " + _maximumRisk);

            Console.WriteLine();
            Console.WriteLine($" MinimumReward : " + _minimumReward);
            Console.WriteLine($" Reward : " + _reward);
            Console.WriteLine($" MaximumReward : " + _maximumReward);
            Console.WriteLine();
            Console.WriteLine($" Note : " + _note);
            Console.WriteLine();

        }
    }
}
