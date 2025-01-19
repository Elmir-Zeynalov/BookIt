using Backend.Database;
using Backend.Dtos;
using Backend.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("/Users")]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserServices _userServices;

        public UsersController(ILogger<UsersController> logger, IUserServices userServices)
        {
            _logger = logger;
            _userServices = userServices;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            var users = await _userServices.GetAllUsersAsync();
            return Ok(users);
        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="userDto">The user data transfer object.</param>
        /// <returns>The created user.</returns>
        [HttpPost("RegisterUser", Name = "PostUser")]
        public async Task<IActionResult> Post(UserCreateDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userServices.CreateUserAsync(userDto.Firstname, userDto.Lastname, userDto.Email, userDto.Password);

            if (user == null)
            {
                return BadRequest(new { message = "User already exists" });
            }

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userServices.GetUserByIdAsync(id);
            if (user == null) return NotFound();

            return Ok(new
            {
                user.Id,
                user.Email
            });
        }
    }
}
