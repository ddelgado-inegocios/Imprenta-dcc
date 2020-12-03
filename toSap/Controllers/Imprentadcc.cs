using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imprentadcc.Models;
using Imprentadcc_respuesta.Models;

namespace Imprentadcc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImprentadccController : ControllerBase
    {
        
        private readonly ILogger<ImprentadccController> _logger;

        public ImprentadccController(ILogger<ImprentadccController> logger)
        {
            _logger = logger;
        }

        
        [HttpPost]
        public IActionResult Responde([FromBody] Entrada Consulta)
        {

            if (!this.ModelState.IsValid)
            {
                
                return BadRequest();
            }
            return Created($"{Consulta}", Consulta);
        }
    }
}
