using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TestProject.DAL.Context;
using TestProject.DAL.Entities;

namespace TestProject.ServiceManager.UserServiceMangers
{
    public class UserManager
    {
        private readonly TestProjectContext context;
        public UserManager(TestProjectContext context)
        {
            this.context = context;
        }

        public async Task<bool> GetLoginUser(User user)
        {
            User appUser = await context.User.Where(x => x.Email == user.Email && x.Password == user.Password).SingleOrDefaultAsync();
            if (appUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
