using System;
using System.Collections.Generic;
using System.Linq;
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
        public UserTokenService(IGenericRepository<UserToken> userTokenRepo, UnitOfWork unitOfWork)
        {
            this.userTokenRepo = userTokenRepo;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddToken(UserToken userToken)
        {
            if (userToken == null)
            {
                throw new ArgumentNullException("UserToken object not found.");
            }
            try
            {
                UserToken existsUserToken = await userTokenRepo.Get(x => x.UserID == userToken.UserID && x.ExpireDate >= DateTime.Now);
                if (existsUserToken == null)
                {
                    await userTokenRepo.Insert(userToken);

                    await Save();
                }
                else
                {
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserToken> CheckTokenByUserToken(UserToken userToken)
        {
            try
            {

                return await userTokenRepo.Get(a => a.Token == userToken.Token);
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
