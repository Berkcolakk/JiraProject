using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Dto.User.Auth;

namespace TestProject.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> AddUser(User user);
        public Task<bool> UpdateUser(User user);
        public Task<List<User>> GetAllUsers();
        Task<TokenDTO> UserAuthentication(User user);
        public Task<User> GetUserById(int id);
        Task<bool> DeleteUser(int userId);
        public Task Save();
    }
}
