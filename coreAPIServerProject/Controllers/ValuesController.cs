using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreAPIServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>()
        {
            "Value One", "Value Two", "Value Three"
        };
        // GET api/values
        public IList<string> Get()
        {
            return values;
        }
        [HttpGet("{index}")]
        // GET api/values/0
        public string Get(int index)
        {
            return values[index];
        }
    }
}
