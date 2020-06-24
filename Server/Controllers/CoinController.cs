using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crypto.PWA.Server.Interfaces;
using Crypto.PWA.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Crypto.PWA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinController : ControllerBase
    {
        private readonly IAPIService _api;
        public CoinController(IAPIService api)
        {
            _api = api;
        }

        [HttpGet]
        public async Task<Coin> GetAsync()
        {
            return await _api.GetCoins();
        }
    }
}
