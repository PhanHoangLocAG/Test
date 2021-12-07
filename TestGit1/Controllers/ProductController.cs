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
            int[] a = new int[4] { 1, 2, 3 ,4};
            object ob = a;
            return Ok(ob);
        }

        [HttpGet("GetJson")]
        public IActionResult GetJson()
        {
            int[] a = new int[2] { 1, 2 };
            object ob = a;
            return Ok(ob);
        }

        [HttpGet("GetJson")]
        public IActionResult GetJsondsfsdfa()
        {
            int[] a = new int[2] { 2, 3 };
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
