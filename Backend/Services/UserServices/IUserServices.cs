using Backend.Models;

namespace Backend.Services.UserServices
{
    public interface IUserServices
    {
        Task<bool> Exists(string email);
        Task Insert(User user);
        Task<User?> GetByEmail(string email);
        Task<User?> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(string firstname, string lastname, string email, string password);

        Task<List<User>> GetAllUsersAsync();
    }
}
