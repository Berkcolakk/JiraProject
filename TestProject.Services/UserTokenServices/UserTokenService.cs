using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;

namespace TestProject.Services.UserTokenServices
{
    public class UserTokenService : IUserTokenService
    {
        private readonly IGenericRepository<UserToken> userTokenRepo;
        private readonly IUnitOfWork unitOfWork;
        private readonly IConfiguration config;
        private readonly IBackgroundJobClient backgroundJobs;

        public UserTokenService(IGenericRepository<UserToken> userTokenRepo, UnitOfWork unitOfWork, IConfiguration config, IBackgroundJobClient backgroundJobs)
        {
            this.userTokenRepo = userTokenRepo;
            this.unitOfWork = unitOfWork;
            this.config = config;
            this.backgroundJobs = backgroundJobs;
        }


        public async Task<UserToken> CheckTokenByUserID(int id)
        {
            try
            {
                return await userTokenRepo.Get(x => x.UserID == id && x.ExpireDate >= DateTime.Now && x.IsActive == true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> HasTokenExpired(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentException($"'{nameof(token)}' cannot be null or empty.", nameof(token));
            }
            UserToken userToken = await CheckTokenByUserToken(token);
            if (userToken != null)
            {
                userToken.IsActive = false;
                await TokenExpired(userToken);
            }
            return true;

        }
        public async Task<UserToken> GenerateUserToken(int id)
        {
            try
            {
                UserToken checkUserToken = await CheckTokenByUserID(id);
                if (checkUserToken == null)
                {
                    var secret = config.GetSection("AppIdentitySettings:Key");
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(secret.Value);
                    DateTime expireDate = DateTime.UtcNow.AddDays(7);
                    var securityToken = tokenHandler.CreateToken(new SecurityTokenDescriptor()
                    {
                        Expires = expireDate,
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    });
                    string token = tokenHandler.WriteToken(securityToken);


                    backgroundJobs.Schedule(() => HasTokenExpired(token), expireDate);
                    return await AddToken(new UserToken()
                    {
                        Token = token,
                        ExpireDate = expireDate,
                        UserID = id
                    });
                }
                else
                {
                    return checkUserToken;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserToken> AddToken(UserToken userToken)
        {
            if (userToken == null)
            {
                throw new ArgumentNullException("UserToken object not found.");
            }
            try
            {
                await userTokenRepo.Insert(userToken);
                await Save();
                return userToken;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserToken> CheckTokenByUserToken(string token)
        {
            try
            {
                return await userTokenRepo.Get(a => a.Token == token && a.ExpireDate >= DateTime.Now);
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

        public async Task<bool> TokenExpired(UserToken userToken)
        {
            if (userToken == null)
            {
                throw new ArgumentNullException("User object not found.");
            }
            try
            {
                userTokenRepo.Update(userToken, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}