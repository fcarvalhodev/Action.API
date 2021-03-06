﻿using Action.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace Action.Api.Controllers
{
    [Route("[Controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClient;
        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] CreateUsers command)
        {
            await _busClient.PublishAsync(command);

            return Accepted();
        }
    }
}
