using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;

namespace TestProject.Services.MenuRoleServices
{
    public class MenuRoleService : IMenuRoleService
    {
        private readonly IGenericRepository<MenuRole> menuRoleRepo;
        private readonly MenuRoleManager MenuRoleManager;
        private readonly IUnitOfWork unitOfWork;
        public MenuRoleService(IGenericRepository<MenuRole> menuRoleRepo, MenuRoleManager MenuRoleManager, UnitOfWork unitOfWork)
        {
            this.menuRoleRepo = menuRoleRepo;
            this.MenuRoleManager = MenuRoleManager;
            this.unitOfWork = unitOfWork;
        }
        public bool AddMenuRole(MenuRole MenuRole)
        {
            if (MenuRole == null)
            {
                throw new ArgumentNullException("MenuRole object not found.");
            }
            try
            {
                menuRoleRepo.Insert(MenuRole);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateMenuRole(MenuRole MenuRole)
        {
            if (MenuRole == null)
            {
                throw new ArgumentNullException("MenuRole object not found.");
            }

            try
            {
                menuRoleRepo.Update(MenuRole, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<MenuRole> GetAllMenuRoles()
        {
            try
            {
                return menuRoleRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public MenuRole GetMenuRoleById(int id)
        {
            try
            {
                return menuRoleRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool DeleteMenuRole(int MenuRoleId)
        {
            if (MenuRoleId == 0)
            {
                throw new ArgumentNullException("MenuRoleId not found.");
            }

            try
            {
                MenuRole MenuRole = GetMenuRoleById(MenuRoleId);
                menuRoleRepo.Delete(MenuRole);
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
