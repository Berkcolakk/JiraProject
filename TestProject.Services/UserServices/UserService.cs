using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.UserServiceMangers;

namespace TestProject.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> userRepo;
        private readonly UserManager userManager;
        private readonly IUnitOfWork unitOfWork;
        public UserService(IGenericRepository<User> userRepo, UserManager userManager, UnitOfWork unitOfWork)
        {
            this.userRepo = userRepo;
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }
            try
            {
                await userRepo.Insert(user);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }

            try
            {
                userRepo.Update(user, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await userRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await userRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> DeleteUser(int userId)
        {
            if (userId == 0)
            {
                throw new ArgumentNullException("UserId not found.");
            }

            try
            {
                User user = await GetUserById(userId);
                userRepo.Delete(user);
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
