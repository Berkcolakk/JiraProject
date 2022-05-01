using System.Threading.Tasks;
using TestProject.DAL.Entities;

namespace TestProject.Services.UserTokenServices
{
    public interface IUserTokenService
    {
        Task<UserToken> AddToken(UserToken userToken);

        Task<bool> TokenExpired(UserToken userToken);

        Task<bool> CheckTokenByUserToken(string token);

        Task<UserToken> CheckTokenByUserID(int id);

        Task<UserToken> GenerateUserToken(int id);

        Task Save();
    }
}