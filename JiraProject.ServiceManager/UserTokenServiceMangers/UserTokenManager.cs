using JiraProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using JiraProject.DAL.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JiraProject.ServiceManager.UserTokenServiceMangers
{
    public class UserTokenManager
    {
        private readonly JiraProjectContext context;

        public UserTokenManager(JiraProjectContext context)
        {
            this.context = context;
        }
        public async Task<UserToken> CheckTokenByUserToken(string token)
        {
            return await context.UserToken.Where(a => a.Token == token && a.ExpireDate >= DateTime.Now).Include(x => x.IPUserTokenUser).SingleOrDefaultAsync();
        }
    }
}