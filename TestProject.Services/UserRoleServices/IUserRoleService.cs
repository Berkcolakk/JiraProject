using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserRoleServices
{
    public interface IUserRoleService
    {
        Task<bool> AddUserRole(UserRole user);
        public Task<bool> UpdateUserRole(UserRole user);
        public Task<List<UserRole>> GetAllUserRoles();
        public Task<UserRole> GetUserRoleById(int id);
        Task<bool> DeleteUserRole(int userId);
        public Task Save();
    }
}
