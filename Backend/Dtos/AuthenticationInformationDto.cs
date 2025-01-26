using System.ComponentModel.DataAnnotations;

namespace Backend.Dtos
{
    public class AuthenticationInformationDto
    {
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
    }
}
