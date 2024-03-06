using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Response
{

    public class TimeOpenHighLowCloseVolumeResponse
    {
        public string s { get; set; }
        public List<Candle> candles { get; set; }
    }
    public class Candle
    {
        public List<float> timeOpenHighLowCloseVolume { get; set; }
    }


}
