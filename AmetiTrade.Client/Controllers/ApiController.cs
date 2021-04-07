using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmetiTrade.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
            var lista = new List<string>();

            lista.Add("value1");
            lista.Add("value2");
            lista.Add("value3");
            lista.Add("value4");

            return lista.ToList();
        }
    }
}
