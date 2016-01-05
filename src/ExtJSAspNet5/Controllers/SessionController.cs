using ExtJSAspNet5.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExtJSAspNet5.Controllers
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        [HttpGet]
        public IEnumerable<SessionItem> Get()
        {
            return Enumerable.Empty<SessionItem>();
        }

        [HttpPost("{id}")]
        public SessionItem Post (int id, [FromBody]SessionItem value)
        {
            return value;
        }
    }
}
