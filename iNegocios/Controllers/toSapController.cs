using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iNegocios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToSapController : ControllerBase
    {

        public ToSapController(ILogger<ToSapController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ToSap> Get()
        {
            return (index => new ToSap
            {
                Status = "Success",
                NotificationID = "1234567890",
            })
            .ToArray();
        }
    }
}
