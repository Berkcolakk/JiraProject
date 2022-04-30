using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Dto.User.Auth;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.UserServiceMangers;
using TestProject.Services.UserTokenServices;

namespace TestProject.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> userRepo;
        private readonly UserManager userManager;
        private readonly IUnitOfWork unitOfWork;
        private readonly IConfiguration config;
        private readonly IUserTokenService userTokenService;
        public UserService(IGenericRepository<User> userRepo, UserManager userManager, UnitOfWork unitOfWork, IConfiguration _config, IUserTokenService userTokenService)
        {
            this.userRepo = userRepo;
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
            this.config = _config;
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
            User appUser = await userRepo.Get(x => x.Email == user.Email && x.Password == user.Password);

            if (appUser != null)
            {
                var secret = config.GetSection("AppIdentitySettings:Password");
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(secret.Value);
                DateTime expireDate = DateTime.UtcNow.AddDays(7);
                var securityToken = tokenHandler.CreateToken(new SecurityTokenDescriptor()
                {
                    Expires = expireDate,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                });
                string token = tokenHandler.WriteToken(securityToken);
                await userTokenService.AddToken(new UserToken()
                {
                    Token = token,
                    ExpireDate = expireDate,
                    UserID = appUser.ID
                });
                return new TokenDTO() { Token = token, ExpireDate = expireDate };
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
            catch (Exception e)
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
