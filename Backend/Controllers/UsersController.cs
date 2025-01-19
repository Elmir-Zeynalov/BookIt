using Backend.Database;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("/Users")]
    public class UsersController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;

        public UsersController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUsers")]
        public IActionResult Get()
        {
            return Ok("Users!");
        }
    }
}
