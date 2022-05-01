using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;

namespace TestProject.Services.MenuRoleServices
{
    public interface IMenuRoleService
    {
        Task<bool> AddMenuRole(MenuRole MenuRole);

        public Task<bool> UpdateMenuRole(MenuRole MenuRole);

        public Task<List<MenuRole>> GetAllMenuRoles();

        public Task<MenuRole> GetMenuRoleById(int id);

        Task<bool> DeleteMenuRole(int MenuRoleId);

        public Task Save();
    }
}