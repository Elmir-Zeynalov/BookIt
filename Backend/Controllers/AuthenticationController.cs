using Backend.Dtos;
using Microsoft.AspNetCore.Mvc;
using Backend.Services.AuthenticationServices;
namespace Backend.Controllers
{
    [ApiController]
    [Route("/Authentication")]
    public class AuthenticationController : Controller
    {

        [HttpPost("AuthenticateUser", Name = "AuthenticateUser")]
        public async Task<IActionResult> AuthenticateUser(AuthenticationInformationDto authInfo)
        {
            try
            {
                AuthenticationService authService = new AuthenticationService();

                var result = authService.AuthenticateUser(authInfo.Email, authInfo.Password);



                return Ok(result);
            }catch(Exception e)
            {

                return BadRequest();
            }
        }
    }
}
