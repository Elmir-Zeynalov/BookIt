using Backend.Database;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly AppDbContext _dbContext;
        public UserServices(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<User> CreateUserAsync(string firstname, string lastname, string email, string password)
        {
            var user = new User 
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Email = email, 
                Password = password 
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
