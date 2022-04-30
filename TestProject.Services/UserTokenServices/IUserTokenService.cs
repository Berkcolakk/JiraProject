using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserTokenServices
{
    public interface IUserTokenService
    {
        Task<bool> AddToken(UserToken userToken);
        Task<bool> TokenExpired(UserToken userToken);
        Task<UserToken> CheckTokenByUserToken(UserToken userToken);
        Task Save();
    }
}
