using JiraProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.ServiceManager.ParentServiceMangers
{
    public class ParentManager
    {
        private readonly JiraProjectContext context;

        public ParentManager(JiraProjectContext context)
        {
            this.context = context;
        }
    }
}
