using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> AddUser(User user);
        public Task<bool> UpdateUser(User user);
        public Task<List<User>> GetAllUsers();
        Task<bool> GetLoginUser(User user);
        public Task<User> GetUserById(int id);
        Task<bool> DeleteUser(int userId);
        public Task Save();
    }
}
