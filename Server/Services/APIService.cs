using Crypto.PWA.Server.Interfaces;
using Crypto.PWA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Crypto.PWA.Server.Services
{
    public class APIService : IAPIService
    {
        private readonly HttpClient _client;
        public APIService(HttpClient client)
        {
            _client = client;
        }
        public async Task<Coin> GetCoins(string coin = "BTC", string fiat = "ARS")
        {
            Coin result = null;
            try
            {
                result = await _client.GetFromJsonAsync<Coin>("ripio/btc");
            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
