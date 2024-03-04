using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiByGc.Response
{

    public class DetailsResponse
    {
        public string s { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<DatumDetails> data { get; set; }
    }

    public class DatumDetails
    {
        public string clientId { get; set; }
        public string isin { get; set; }
        public float qty { get; set; }
        public float qtyUtlize { get; set; }
        public string entryDate { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int noOfDays { get; set; }
        public string source { get; set; }
        public string status { get; set; }
        public string reason { get; set; }
        public string internalTxnId { get; set; }
        public string dpTxnId { get; set; }
        public string errCode { get; set; }
        public string errorCount { get; set; }
        public string transactionId { get; set; }
    }

}
