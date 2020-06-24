using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Crypto.PWA.Shared
{
    public class Coin
    {
        public decimal TotalAsk { get; set; }
        public decimal TotalBid { get; set; }
        public decimal Time { get; set; }

        public decimal Ask { get; set; }
        public decimal Bid { get; set; }

        public string AskStr { get { return Ask.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")); } }
        public string BidStr { get { return Bid.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")); } }

        public string Crypto { get; set; }
        public string Fiat { get; set; }
        public string Exchange { get; set; }
    }
}
