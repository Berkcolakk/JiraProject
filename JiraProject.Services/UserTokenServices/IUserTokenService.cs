using System;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;

namespace JiraProject.Services.UserTokenServices
{
    public interface IUserTokenService
    {
        Task<UserToken> AddToken(UserToken userToken);
        Task<bool> HasTokenExpired(string token);
        Task<bool> TokenExpired(UserToken userToken);
        Task<UserToken> CheckTokenByUserToken(string token);

        Task<UserToken> CheckTokenByUserID(int id);

        Task<UserToken> GenerateUserToken(int id);
        string GenerateToken(DateTime expireDate);

        Task Save();
    }
}