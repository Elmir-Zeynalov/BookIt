using Backend.Database;
using Backend.Models;
using Backend.Services.PasswordServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly AppDbContext _dbContext;
        private readonly IPasswordHasher _passwordHasher;

        public UserServices(AppDbContext context, IPasswordHasher passwordHasher)
        {
            _dbContext = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<User?> CreateUserAsync(string firstname, string lastname, string email, string password)
        {
            var userExists = await _dbContext.Users.AnyAsync(u => u.Email == email);
            if (userExists)
            {
                return null;
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Password = _passwordHasher.Hash(password)
            };

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }


        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public Task<bool> Exists(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }


        public Task Insert(User user)
        {
            throw new NotImplementedException();
        }
    }
}
