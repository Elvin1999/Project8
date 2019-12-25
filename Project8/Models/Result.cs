using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project8.Models
{
    public class Result
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public Dictionary<string, object> RouteData = new Dictionary<string, object>();
    }
}
