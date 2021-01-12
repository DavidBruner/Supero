using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurosCalculado.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class InfCodigoController : ControllerBase
    {
        private static readonly string _GitCode = "https://github.com/DavidBruner/Supero";

        [HttpGet]
        public string Get()
        {
            return _GitCode;
        }
    }
}
