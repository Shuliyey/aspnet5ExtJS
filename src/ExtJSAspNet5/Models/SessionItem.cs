using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtJSAspNet5.Models
{
    public class SessionItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public int sessionLevel { get; set; }
        public bool approved { get; set; }
    }
}
