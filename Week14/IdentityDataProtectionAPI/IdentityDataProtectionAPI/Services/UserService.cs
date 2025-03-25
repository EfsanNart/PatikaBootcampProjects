using IdentityDataProtectionAPI.DTOs;
using IdentityDataProtectionAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityDataProtectionAPI.Services
{
    public class UserService:IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

       
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

   
        public async Task<bool> CreateUserAsync(string email, string password)
        {
            var user = new User { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }

    
        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }
    }
}
