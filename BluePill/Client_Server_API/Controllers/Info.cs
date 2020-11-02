using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BluePill.Client_Server_API.JSON;

namespace BluePill.Client_Server_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class Info : ControllerBase
    {
        private readonly JSON.Version ver = new JSON.Version();

        [HttpGet]
        [Route("/_matrix/client/versions")]
        public IActionResult Ver()
        {
            return Ok(ver);
        }
        
    }
}
