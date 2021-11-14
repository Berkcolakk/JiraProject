using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.RoleServices
{
    public interface IRoleService
    {
        bool AddRoles(Roles Roles);
        public bool UpdateRoles(Roles Roles);
        public List<Roles> GetAllRoles();
        public Roles GetRolesById(int id);
        bool DeleteRoles(int RolesId);
        public void Save();
    }
}
