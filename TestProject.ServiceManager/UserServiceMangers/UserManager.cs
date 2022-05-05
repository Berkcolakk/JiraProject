using JiraProject.DAL.Context;

namespace JiraProject.ServiceManager.UserServiceMangers
{
    public class UserManager
    {
        private readonly TestProjectContext context;

        public UserManager(TestProjectContext context)
        {
            this.context = context;
        }
    }
}