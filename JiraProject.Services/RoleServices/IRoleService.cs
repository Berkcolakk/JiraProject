using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;

namespace JiraProject.Services.RoleServices
{
    public interface IRoleService
    {
        Task<bool> AddRoles(Roles Roles);

        public Task<bool> UpdateRoles(Roles Roles);

        public Task<List<Roles>> GetAllRoles();

        public Task<Roles> GetRolesById(int id);

        Task<bool> DeleteRoles(int RolesId);

        public Task Save();
    }
}