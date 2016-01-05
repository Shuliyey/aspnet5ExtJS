using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtJSAspNet5.Controllers
{
    [Route("")]
    public class IndexController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public void Index()
        {
            Response.Redirect("home");
        }
    }
}