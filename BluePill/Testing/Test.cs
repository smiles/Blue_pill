using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BluePill.Testing
{
    [Route("[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        public string Get()
        {
            return "Test successful";
        }
    }
}
