using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuerySaver.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpPost]
        public IActionResult Home()
        {
            return Accepted();
        }
    }
}
