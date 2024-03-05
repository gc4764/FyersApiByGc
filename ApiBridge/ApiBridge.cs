using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBridge
{
    public class ApiBridge
    {
        protected bool _tradingModeLive = false;


        public ApiBridge( bool tradingModeLive)
        {
            _tradingModeLive = tradingModeLive;
        }

        public void Run(MessageCommand cmd) 
        {
            if (Validate(cmd))
            {
                if (_tradingModeLive)
                {
                    LiveTrade.Run(cmd);
                }
                else
                {
                    PaperTrade.Run(cmd);
                }

            }
            else
            {
                return;
            }

           

        }

        private bool Validate(MessageCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
