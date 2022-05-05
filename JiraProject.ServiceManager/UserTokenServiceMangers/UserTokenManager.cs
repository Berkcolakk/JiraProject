using JiraProject.DAL.Context;

namespace JiraProject.ServiceManager.UserTokenServiceMangers
{
    public class UserTokenManager
    {
        private readonly JiraProjectContext context;

        public UserTokenManager(JiraProjectContext context)
        {
            this.context = context;
        }
    }
}