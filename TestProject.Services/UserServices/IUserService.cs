using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserServices
{
    public interface IUserService
    {
        bool AddUser(User user);
        public bool UpdateUser(User user);
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        bool DeleteUser(int userId);
        public void Save();
    }
}
