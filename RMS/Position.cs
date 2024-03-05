using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace RMS
{
    public class Position : IPosition
    {
        protected HashSet<string> _longPositions  = [];
        protected HashSet<string> _shortPositions  = [];
        protected HashSet<string> _totalPositions = [];

        protected int _countLongPosition = 0;
        protected int _countShortPosition = 0;
        protected int _countTotalPosition = 0;

        public Position(IBrokerContext brokerContext, UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            BrokerContext = brokerContext;
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public void AddLong(string long_scrip_symbol)
        {
             _longPositions.Add(long_scrip_symbol);
            _totalPositions.Add(long_scrip_symbol);
            _countLongPosition++;
            _countTotalPosition++;

        }

        public HashSet<string> LongPositions()
        {
            return _longPositions;
        }

        public void AddShort(string short_scrip_symbol)
        {
            _shortPositions.Add(short_scrip_symbol);
            _totalPositions.Add(short_scrip_symbol);
            _countShortPosition++;
            _countTotalPosition++;
        }

        public HashSet<string> ShortPositions()
        {
            return _shortPositions;
        }

        public void RemoveLong(string long_scrip_symbol)
        {
             _longPositions.Remove(long_scrip_symbol);
            _totalPositions.Remove(long_scrip_symbol);
            _countLongPosition--;
            _countTotalPosition--;


        }

        public void RemoveShort(string short_scrip_symbol)
        {
            _shortPositions.Remove(short_scrip_symbol);
            _totalPositions.Remove(short_scrip_symbol);
            _countShortPosition--;
            _countTotalPosition--;

        }

        public HashSet<string> TotalPositions()
        {
            return _totalPositions;
        }

        public string ManageLE()
        {
            if (HaveLongPosition())
            {
                return string.Empty;
            }
            else if (HaveShortPosition())
            {
                CloseShortPosition();
                OpenLongPosition();
                return string.Empty;
            }
            else
            {
                OpenLongPosition();
                return string.Empty ;
            }
        }

        private void CloseShortPosition()
        {
            throw new NotImplementedException();
        }

        private void OpenLongPosition()
        {
            throw new NotImplementedException();
        }

        public string ManageSE()
        {
            if (HaveShortPosition())
            {
                return string.Empty;
            }
            else if (HaveLongPosition())
            {
                CloseLongPosition();
                OpenShortPosition();
                return string.Empty;
            }
            else
            {
                OpenShortPosition();
                return string.Empty ;
            }
        }

        private void CloseLongPosition()
        {
            throw new NotImplementedException();
        }

        private void OpenShortPosition()
        {
            throw new NotImplementedException();
        }

        private bool HaveLongPosition()
        {
            throw new NotImplementedException();
        }

        private bool HaveShortPosition()
        {
            throw new NotImplementedException();
        }

        public string ManageLX()
        {
            if(HaveLongPosition())
            {
                CloseLongPosition();
                return string.Empty;
            }
            else
            {
                return string.Empty;
            }
        }

        public string ManageSX()
        {
            if(HaveShortPosition())
            {
                CloseShortPosition();
                return string.Empty;
            }
            else
            {
                return string.Empty;
            }
        }

        public int CountLongPosition
        {
           get
              {
                return _countLongPosition;
            }
        }

        public int CountShortPosition
        {
            get
            {
                return _countShortPosition;
            }
        }

        public int CountTotalPosition
        {
            get
            {
                return _countTotalPosition;
            }
        }

        public global::ApiBridge.Context.Broker.IBrokerContext BrokerContext { get; }
        public global::ApiBridge.UserContext UserContext { get; }
        public global::GCLibrary.Logger.ILogger Logger { get; }
        public global::ApiBridge.Context.RequestMessageContext Cmd { get; }
    }
}
