using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;

namespace JiraProject.Services.MenuServices
{
    public interface IMenuService
    {
        Task<bool> AddMenu(Menu Menu);

        public Task<bool> UpdateMenu(Menu Menu);

        public Task<List<Menu>> GetAllMenus();

        public Task<Menu> GetMenuById(int id);

        Task<bool> DeleteMenu(int MenuId);

        public Task Save();
    }
}