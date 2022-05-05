using JiraProject.DAL.Context;

namespace JiraProject.ServiceManager.UserTokenServiceMangers
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