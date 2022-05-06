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
        public async Task<List<Projects>> GetallProjectsWithRelations(int companyID)
        {
            return await context.Project.Where(x => x.CompanyID == companyID && x.IsActive == true).Include(x => x.ProjectsProjectUsers).ThenInclude(x => x.IPUserProjectUser).Include(x => x.IPCompanyProjects).Include(x => x.IPProjectProjectIssues).ThenInclude(x => x.IPUserProjectIssuesUser).ToListAsync();
        }
    }
}