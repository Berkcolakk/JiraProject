using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Infrastructure.Infrastructures;
using TestProject.Repository.GenericRepo;

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
        public bool AddUserRole(UserRole user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }
            try
            {
                userRoleRepo.Insert(user);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateUserRole(UserRole user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User object not found.");
            }

            try
            {
                userRoleRepo.Update(user, x => x.ID, x => x.CREATED_DATE, x => x.CREATED_USER_ID, x => x.CREATED_USER_IP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<UserRole> GetAllUserRoles()
        {
            try
            {
                return userRoleRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public UserRole GetUserRoleById(int id)
        {
            try
            {
                return userRoleRepo.Get(a => a.ID == id);
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
