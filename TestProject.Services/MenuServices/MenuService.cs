using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;

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
        public bool AddMenu(Menu Menu)
        {
            if (Menu == null)
            {
                throw new ArgumentNullException("Menu object not found.");
            }
            try
            {
                menuRepo.Insert(Menu);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateMenu(Menu Menu)
        {
            if (Menu == null)
            {
                throw new ArgumentNullException("Menu object not found.");
            }

            try
            {
                menuRepo.Update(Menu, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Menu> GetAllMenus()
        {
            try
            {
                return menuRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Menu GetMenuById(int id)
        {
            try
            {
                return menuRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool DeleteMenu(int MenuId)
        {
            if (MenuId == 0)
            {
                throw new ArgumentNullException("MenuId not found.");
            }

            try
            {
                Menu Menu = GetMenuById(MenuId);
                menuRepo.Delete(Menu);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Save()
        {

            unitOfWork.Save();
        }
    }
}
