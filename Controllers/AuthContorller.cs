using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace react_dotnet_realworld.Collections
{
    [Route(template:"")]
    [ApiController]
    public class AuthContorller : Controller
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("success");
        }
    }
}