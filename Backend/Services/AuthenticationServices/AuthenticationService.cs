using Backend.Database;
using Backend.Dtos;
using Backend.Models;
using Backend.Services.PasswordServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;



namespace Backend.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext _dbContext;

        public AuthenticationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Dtos.AuthenticationResult> AuthenticateUser(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return new Dtos.AuthenticationResult() { IsSuccessful = false, Message = "Email not found." };
            }

            PasswordHasher hasher = new PasswordHasher();
            var passwordCheckPassed = hasher.Verify(password, user.Password);
            return new Dtos.AuthenticationResult() { IsSuccessful = passwordCheckPassed, Message = passwordCheckPassed ? "Authentication Successful" : "Password incorrect." };
        }
    }
}
