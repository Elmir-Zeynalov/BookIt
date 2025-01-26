using Backend.Database;
using Backend.Dtos;
using Backend.Models;
using Backend.Services.PasswordServices;
using Microsoft.EntityFrameworkCore;



namespace Backend.Services.AuthenticationServices
{
    public class AuthenticationService
    {
        private readonly AppDbContext _dbContext;

        public AuthenticationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool AuthenticateUser(string email, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return false;
            }

            PasswordHasher hasher = new PasswordHasher();
            var passwordCheckPassed = hasher.VerifyPassword(password, user.Password);
            return passwordCheckPassed;
        }
    }
}
