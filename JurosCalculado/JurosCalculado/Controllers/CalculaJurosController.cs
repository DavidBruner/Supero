using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurosCalculado.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private CalculaJuros CalJuros = new CalculaJuros();

        [HttpGet]
        public string Get(double valorInicial, int meses)
        {
            return CalJuros.RealizaCalculo(valorInicial, meses);
        }

    }
}
