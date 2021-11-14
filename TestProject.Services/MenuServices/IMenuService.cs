using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.MenuServices
{
    public interface IMenuService
    {
        bool AddMenu(Menu Menu);
        public bool UpdateMenu(Menu Menu);
        public List<Menu> GetAllMenus();
        public Menu GetMenuById(int id);
        bool DeleteMenu(int MenuId);
        public void Save();
    }
}
