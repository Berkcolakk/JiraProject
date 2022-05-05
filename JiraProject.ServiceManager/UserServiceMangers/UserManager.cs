using JiraProject.DAL.Context;

namespace JiraProject.ServiceManager.UserServiceMangers
{
    public class UserManager
    {
        private readonly JiraProjectContext context;

        public UserManager(JiraProjectContext context)
        {
            this.context = context;
        }
    }
}