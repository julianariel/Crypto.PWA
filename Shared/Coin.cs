using System;
using System.Collections.Generic;
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
    }
}
