using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.MenuRoleServices
{
    public interface IMenuRoleService
    {
        bool AddMenuRole(MenuRole MenuRole);
        public bool UpdateMenuRole(MenuRole MenuRole);
        public List<MenuRole> GetAllMenuRoles();
        public MenuRole GetMenuRoleById(int id);
        bool DeleteMenuRole(int MenuRoleId);
        public void Save();
    }
}
