using JiraProject.DAL.Context;
using JiraProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiraProject.ServiceManager.ProjectServiceMangers
{
    public class ProjectManager
    {
        private readonly JiraProjectContext context;

        public ProjectManager(JiraProjectContext context)
        {
            this.context = context;
        }
        //public async Task<List<Projects>> GetAllProjectsWithRelations()
        //{
        //    return await context.Project.Include(x => x.ProjectUsersID).ThenInclude(x => x.UserID).Include(x => x.ProjectIssuespProjectID).ThenInclude(x => x.)
        //}
    }
}