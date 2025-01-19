using System.Security.Cryptography;

namespace Backend.Services.PasswordServices
{
    public interface IPasswordHasher
    {
        public string Hash(string password);

        public bool Verify(string password, string passwordHash);
    }
}
