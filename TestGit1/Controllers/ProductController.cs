using Microsoft.AspNetCore.Mvc;


namespace TestGit1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetJson1")]
        public IActionResult GetJson1()
        {
            int[] a = new int[3] { 1, 2, 3 };
            object ob = a;
            return Ok(ob);
        }

        [HttpGet("GetJson")]
        public IActionResult GetJson()
        {
            int[] a = new int[3] { 1, 2, 3 };
            object ob = a;
            return Ok(ob);
        }
    }
}
