using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public class LongTrade : Trade
    {
        public LongTrade(decimal price, decimal stoploss, decimal target, decimal minimumRisk, decimal maximumRisk, string? note) 
            :base(price, stoploss, target, minimumRisk, maximumRisk, note)
        {
            _price = price;
            _stoploss = stoploss;
            _target = target;
            _minimumRisk = minimumRisk;
            _MaximumRisk = maximumRisk;
            _note = note;
            SetRisk();
        }

        protected override void SetRisk()
        {
            decimal risk;
            if (_stoploss >= _price)
            {
                _stoploss = _price - (_minimumRisk + _MaximumRisk) / 2;
            }
            risk = _price - _stoploss;

            if (risk < _minimumRisk) _risk = risk;
            else if (risk > _MaximumRisk) _risk = risk;
            else _risk = risk;
        }

    }
}
