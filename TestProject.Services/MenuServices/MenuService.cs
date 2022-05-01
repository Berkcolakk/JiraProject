using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.MenuServiceMangers;

namespace TestProject.Services.MenuServices
{
    public class MenuService : IMenuService
    {
        private readonly IGenericRepository<Menu> menuRepo;

        private readonly MenuManager MenuManager;

        private readonly IUnitOfWork unitOfWork;

        public MenuService(IGenericRepository<Menu> menuRepo, MenuManager MenuManager, UnitOfWork unitOfWork)
        {
            this.menuRepo = menuRepo;
            this.MenuManager = MenuManager;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddMenu(Menu Menu)
        {
            if (Menu == null)
            {
                throw new ArgumentNullException("Menu object not found.");
            }
            try
            {
                await menuRepo.Insert(Menu);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> UpdateMenu(Menu Menu)
        {
            if (Menu == null)
            {
                throw new ArgumentNullException("Menu object not found.");
            }

            try
            {
                menuRepo.Update(Menu, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Menu>> GetAllMenus()
        {
            try
            {
                return await menuRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Menu> GetMenuById(int id)
        {
            try
            {
                return await menuRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeleteMenu(int MenuId)
        {
            if (MenuId == 0)
            {
                throw new ArgumentNullException("MenuId not found.");
            }

            try
            {
                Menu Menu = await GetMenuById(MenuId);
                menuRepo.Delete(Menu);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }
    }
}