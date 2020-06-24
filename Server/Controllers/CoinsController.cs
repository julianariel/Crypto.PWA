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
    public class CoinsController : ControllerBase
    {
        private readonly IAPIService _api;
        public CoinsController(IAPIService api)
        {
            _api = api;
        }

        [HttpGet]
        public async Task<IEnumerable<Coin>> GetAsync()
        {
            return await _api.GetCoins();
        }
    }
}
