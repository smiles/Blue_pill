using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BluePill.Server_Server_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class Info : ControllerBase
    {
        [Route("/.well-known/matrix/server")]
        [HttpGet]
        public IActionResult Ver()
        {
            return Ok();
        }

    }
}
