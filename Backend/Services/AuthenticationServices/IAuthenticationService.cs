

using Backend.Dtos;

namespace Backend.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> AuthenticateUser(string email, string password);
    }
}
