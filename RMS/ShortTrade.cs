using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    public class ShortTrade : Trade
    {
        public ShortTrade(decimal price, decimal stoploss, decimal target, decimal minimumRisk, decimal maximumRisk, decimal minimumReward, decimal maximumReward, string? note) : base(price, stoploss, target, minimumRisk, maximumRisk, minimumReward, maximumReward, note)
        {
            _price = price;
            _stoplossPrice = stoploss;
            _targetPrice = target;
            _minimumRisk = minimumRisk;
            _maximumRisk = maximumRisk;
            _note = note;
            SetRisk(ref _stoplossPrice, ref _risk);
            SetReward(ref _targetPrice, ref _reward);
        }

        protected override void SetReward(ref decimal _targetPrice, ref decimal _reward)
        {
            decimal reward;
            //if target price is less then price
            if (_targetPrice >= _price) _targetPrice = _price - _minimumReward;
            //calculate reward
            reward = _price - _targetPrice;

            // if reward less then minimum reward
            if (reward < _minimumReward) _reward = _minimumReward;
            // if reward greater then maximum reawrd
            else if (reward > _maximumRisk) _reward = _maximumRisk;
            // if reward is fair value
            else
                _reward = reward;

            _targetPrice = _price - _reward;

        }

        protected override void SetRisk(ref decimal _stoplossPrice, ref decimal _risk)
        {

            decimal risk;
            // if stoploss price is greater then price
            if (_stoplossPrice <= _price) _stoplossPrice = _price + _minimumRisk;
            risk = _stoplossPrice - _price;

            //risk is less then minimum risk
            if (risk < _minimumRisk) _risk = _minimumRisk;

            // if risk is greater then risk
            else if (risk > _maximumRisk) _risk = _maximumRisk;

            // reward is fair value
            else _risk = risk;
            _stoplossPrice = _risk + _price;

        }
    }
}
