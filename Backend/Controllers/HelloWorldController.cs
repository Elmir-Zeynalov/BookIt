using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("/HelloWorld")]
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;
        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name ="GetHelloWorld")]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}
