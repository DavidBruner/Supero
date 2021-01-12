using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurosFixo.Controllers
{
    [ApiController]
    [Route("JurosFixo")]
    public class JurosFixoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "0,01";
        }
    }
}
