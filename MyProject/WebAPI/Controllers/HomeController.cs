using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the WebAPI! Navigate to /api/books to view books.");
        }
    }
}
