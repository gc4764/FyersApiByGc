using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public abstract  class Trade
    {
        protected decimal _price;
        protected decimal _stoploss;
        protected decimal _target;
        protected decimal _risk;
        protected decimal _minimumRisk;
        protected decimal _MaximumRisk;
        protected decimal _reward;
        protected string? _note;

        public  Trade(decimal price, decimal stoploss, decimal target, decimal minimumRisk, decimal maximumRisk, string? note)
        {
            _price = price;
            _stoploss = stoploss;
            _target = target;
            _minimumRisk = minimumRisk;
            _MaximumRisk = maximumRisk;
            _note = note;
            SetRisk();
        }

        protected abstract void SetRisk();
        public  decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price= value;
                SetRisk() ;
            }
        }
        public  decimal StopLoss
        {
            get
            {
                return _stoploss;
            }
            set
            {
                _stoploss= value;
                SetRisk() ;
            } 
        }
        public  decimal Target
        {
            get
            {
                return _target;
            }
            set
            { 
                _target= value;
            }
        }
        public  decimal MinimumRisk
        {
            get
            {
                return _minimumRisk;
            }
            set
            {
                _minimumRisk= value;
                SetRisk() ;
            }
        }
        public  decimal MaximumRisk
        {
            get
            {
                return _minimumRisk ;
            }
            set
            {
                _minimumRisk= value;
                SetRisk() ;
            } 
        }
        public  decimal Risk 
        {
            get
            {
                return _risk;
            }
        }
        public  decimal Reward 
        {
            get
            {
                return _reward;
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

        public void  Printdata()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($" Price : " + _price);
            Console.WriteLine($" StopLoss : " + _stoploss);
            Console.WriteLine($" Target : " + _target);
            Console.WriteLine($" Risk : " + _risk);
            Console.WriteLine($" Reward : " + _reward);
            Console.WriteLine($" MinimumRisk : " + _minimumRisk);
            Console.WriteLine($" MaximumRisk : " + _MaximumRisk);
            Console.WriteLine($" Note : " + _note);
            Console.WriteLine();

        }
    }
}
