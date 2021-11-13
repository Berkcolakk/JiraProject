using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserRoleServices
{
    public interface IUserRoleService
    {
        bool AddUserRole(UserRole user);
        public bool UpdateUserRole(UserRole user);
        public List<UserRole> GetAllUserRoles();
        public UserRole GetUserRoleById(int id);
        public void Save();
    }
}
