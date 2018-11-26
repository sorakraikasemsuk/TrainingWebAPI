using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string HelloWorld(){
            return "Hello World";
        }
    }
}