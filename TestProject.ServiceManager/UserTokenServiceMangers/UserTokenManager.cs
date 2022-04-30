using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
