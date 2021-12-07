using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestGit1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetJson")]
        public IActionResult GetJson()
        {
            int[] a = new int[3] { 1, 2, 3 };
            object ob = a;
            return Ok(ob);
        }

        [HttpGet("GetJson")]
        public IActionResult GetJsondsfsdfa()
        {
            int[] a = new int[3] { 1, 2, 3 };
            object ob = a;
            return Ok(ob);
        }

        [HttpGet("GetJson")]
        public IActionResult GetJsonasdfadfa()
        {
            int[] a = new int[3] { 1, 2, 3 };
            object ob = a;
            return Ok(ob);
        }
    }
}
