using TestProject.DAL.Context;

namespace TestProject.ServiceManager.UserServiceMangers
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