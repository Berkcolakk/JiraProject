using JiraProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.ServiceManager.StudentServiceMangers
{
    public class StudentManager
    {
        private readonly JiraProjectContext context;

        public StudentManager(JiraProjectContext context)
        {
            this.context = context;
        }
    }
}
