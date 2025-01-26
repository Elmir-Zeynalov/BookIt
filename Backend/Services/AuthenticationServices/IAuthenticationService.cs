namespace Backend.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateUser(string email, string password);
    }
}
