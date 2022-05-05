using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.Dto.User.Auth;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.UserServiceMangers;
using JiraProject.Services.UserTokenServices;

namespace JiraProject.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> userRepo;

        private readonly UserManager userManager;

        private readonly IUnitOfWork unitOfWork;

        private readonly IUserTokenService userTokenService;

        public UserService(IGenericRepository<User> userRepo, UserManager userManager, UnitOfWork unitOfWork, IUserTokenService userTokenService)
        {
            this.userRepo = userRepo;
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
            this.userTokenService = userTokenService;
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TokenDTO> UserAuthentication(User user)
        {
            User appUser = await userRepo.Get(x => x.Email == user.Email && x.Password == user.Password && x.IsActive == true);

            if (appUser != null)
            {
                UserToken userToken = await userTokenService.GenerateUserToken(appUser.ID);
                return new TokenDTO() { Token = userToken.Token, ExpireDate = userToken.ExpireDate };
            }
            else
            {
                return new TokenDTO() { Error = new Dto.Error.Error() { ErrorMessage = "Wrong email or password." } };
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await userRepo.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await userRepo.Get(a => a.ID == id);
            }
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }
    }
}