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
        public async Task<IEnumerable<Coin>> GetCoins(string coin = "BTC", string fiat = "ARS")
        {
            Coin[] result = new Coin[2];
            try
            {
                var ripioBTCTask = _client.GetFromJsonAsync<Coin>("ripio/btc");
                var buenbitBTCTask = _client.GetFromJsonAsync<Coin>("buenbit/btc/ars");
                await Task.WhenAll(ripioBTCTask, buenbitBTCTask);

                result[0] = await ripioBTCTask;
                result[0].Crypto = "BTC";
                result[0].Fiat = "ARS";
                result[0].Exchange = "Ripio";

                result[1] = await buenbitBTCTask;
                result[1].Fiat = "ARS";
                result[1].Crypto = "BTC";
                result[1].Exchange = "BuenBit";

            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
