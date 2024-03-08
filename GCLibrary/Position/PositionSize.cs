using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Position
{
    public class PositionSize
    {
        protected decimal _totalRiskAmount;
        protected decimal _riskPerQty;
        protected int _lotSize;
        protected int _lot;
        protected int _qty;
        protected string? _note;


        public PositionSize(decimal totalRiskAmount, decimal riskPerQty, int lotSize = 1, string? note = "Algo")
        {
            _totalRiskAmount = totalRiskAmount;
            _riskPerQty = riskPerQty;
            _lotSize = lotSize;
            _note = note;
            SetLotAndQty(ref _lot, ref _qty);
        }

        private void SetLotAndQty(ref int _lot, ref int _qty)
        {
            if (_riskPerQty != 0) _qty = (int)(_totalRiskAmount / _riskPerQty);
            else _qty = 0;

            _lot = _qty / _lotSize;
        }

        public decimal TotalRiskAmount
        {
            get { return _totalRiskAmount; }

            set
            {
                _totalRiskAmount = value;
                SetLotAndQty(ref _lot, ref _qty);
            }
        }
        public decimal RiskPerQty
        {
            get { return _riskPerQty; }
            set
            {
                _riskPerQty = value;
                SetLotAndQty(ref _lot, ref _qty);
            }
        }
        public int LotSize
        {
            get { return _lotSize; }
            set
            {
                _lotSize = value;
                SetLotAndQty(ref _lot, ref _qty);
            }
        }
        public int Lot
        {
            get { return _lot; }

        }
        public int Qty
        {
            get { return _qty; }
        }
        public string? Note
        {
            get { return _note; }
            set { _note = value; }
        }

    }
}
