using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.UserRoleServiceMangers;

namespace TestProject.Services.UserRoleServices
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IGenericRepository<UserRole> userRoleRepo;
        private readonly UserRoleManager userManager;
        private readonly IUnitOfWork unitOfWork;
        public UserRoleService(IGenericRepository<UserRole> userRoleRepo, UserRoleManager userManager, UnitOfWork unitOfWork)
        {
            this.userRoleRepo = userRoleRepo;
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddUserRole(UserRole user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }
            try
            {
                await userRoleRepo.Insert(user);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> UpdateUserRole(UserRole user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }

            try
            {
                userRoleRepo.Update(user, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> DeleteUserRole(int userRoleId)
        {
            if (userRoleId == 0)
            {
                throw new ArgumentNullException("UserId not found.");
            }

            try
            {
                UserRole userRole = await GetUserRoleById(userRoleId);
                userRoleRepo.Delete(userRole);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<List<UserRole>> GetAllUserRoles()
        {
            try
            {
                return await userRoleRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<UserRole> GetUserRoleById(int id)
        {
            try
            {
                return await userRoleRepo.Get(a => a.ID == id);
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
