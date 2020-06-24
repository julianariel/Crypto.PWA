using Crypto.PWA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.PWA.Server.Interfaces
{
    public interface IAPIService
    {
        Task<IEnumerable<Coin>> GetCoins(string coin = "", string fiat = "ARS");
    }
}
