using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Infrastructure.Infrastructures;
using TestProject.Repository.GenericRepo;

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
        public bool AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }
            try
            {
                userRepo.Insert(user);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }

            try
            {
                userRepo.Update(user, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return userRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public User GetUserById(int id)
        {
            try
            {
                return userRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool DeleteUse(int userId)
        {
            if (userId == 0)
            {
                throw new ArgumentNullException("UserId not found.");
            }

            try
            {
                User user = GetUserById(userId);
                userRepo.Delete(user);
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
