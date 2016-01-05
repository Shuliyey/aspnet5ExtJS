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
        public IEnumerable<string> Get()
        {
            return new string[] { "session0", "session1" };
        }

        [HttpPost("{id}")]
        public void Post (int id, [FromBody]string value)
        {
            var test = this.Request.Body;
            var test2 = new MemoryStream();
            test.Read(test2.ToArray(), 0, 1);
            this.Response.StatusCode = 201;
        }
    }
}
