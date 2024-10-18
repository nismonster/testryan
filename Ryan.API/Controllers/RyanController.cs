using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ryan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RyanController : ControllerBase
    {
        public RyanController()
        {
        }

        [HttpGet("test")]
        public async Task<ActionResult> TestPing()
        {
            Random random = new Random();
            var rand = random.Next(random.Next(100));
            return Ok($"Test response {rand}");
        }
    }
}
