using TestProject.DAL.Context;

namespace TestProject.ServiceManager.UserTokenServiceMangers
{
    public class UserTokenManager
    {
        private readonly TestProjectContext context;

        public UserTokenManager(TestProjectContext context)
        {
            this.context = context;
        }
    }
}