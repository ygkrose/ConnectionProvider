using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace ConnationProvider.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConnController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        public ConnController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var _connstr =  Configuration.GetSection("ConnectionStrings").Get<ConnStr>();
            return Ok( _connstr);
        }
    }
}