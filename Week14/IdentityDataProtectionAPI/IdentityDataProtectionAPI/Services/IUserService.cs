using IdentityDataProtectionAPI.DTOs;
using IdentityDataProtectionAPI.Entities;

namespace IdentityDataProtectionAPI.Services
{
    public interface IUserService
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> CreateUserAsync(string email, string password);
        Task<bool> CheckPasswordAsync(User user, string password);
    }
}

