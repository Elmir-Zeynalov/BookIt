using Backend.Dtos;
using Microsoft.AspNetCore.Mvc;
using Backend.Services.AuthenticationServices;
namespace Backend.Controllers
{
    [ApiController]
    [Route("/Authentication")]
    public class AuthenticationController : Controller
    {

        private readonly ILogger<UsersController> _logger;
        private readonly IAuthenticationService _authService;

        public AuthenticationController(ILogger<UsersController> logger, IAuthenticationService auhtService)
        {
            _logger = logger;
            _authService = auhtService;
        }


        [HttpPost("AuthenticateUser", Name = "AuthenticateUser")]
        public async Task<IActionResult> AuthenticateUser(AuthenticationInformationDto authInfo)
        {
            try
            {
                var result = await _authService.AuthenticateUser(authInfo.Email, authInfo.Password);

                return Ok(result);
            }catch(Exception e)
            {

                return BadRequest();
            }
        }
    }
}
