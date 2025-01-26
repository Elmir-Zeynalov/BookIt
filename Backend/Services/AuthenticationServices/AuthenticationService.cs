using Backend.Database;
using Backend.Dtos;
using Backend.Models;
using Backend.Services.PasswordServices;
using Microsoft.EntityFrameworkCore;



namespace Backend.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext _dbContext;

        public AuthenticationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<bool> AuthenticateUser(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return false;
            }

            PasswordHasher hasher = new PasswordHasher();
            var passwordCheckPassed = hasher.Verify(password, user.Password);
            return passwordCheckPassed;
        }
    }
}
