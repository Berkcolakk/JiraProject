using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.MenuRoleServiceMangers;

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
        public async Task<bool> AddMenuRole(MenuRole MenuRole)
        {
            if (MenuRole == null)
            {
                throw new ArgumentNullException("MenuRole object not found.");
            }
            try
            {
                await menuRoleRepo.Insert(MenuRole);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> UpdateMenuRole(MenuRole MenuRole)
        {
            if (MenuRole == null)
            {
                throw new ArgumentNullException("MenuRole object not found.");
            }

            try
            {
                menuRoleRepo.Update(MenuRole, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<List<MenuRole>> GetAllMenuRoles()
        {
            try
            {
                return await menuRoleRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<MenuRole> GetMenuRoleById(int id)
        {
            try
            {
                return await menuRoleRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> DeleteMenuRole(int MenuRoleId)
        {
            if (MenuRoleId == 0)
            {
                throw new ArgumentNullException("MenuRoleId not found.");
            }

            try
            {
                MenuRole MenuRole = await GetMenuRoleById(MenuRoleId);
                menuRoleRepo.Delete(MenuRole);
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
