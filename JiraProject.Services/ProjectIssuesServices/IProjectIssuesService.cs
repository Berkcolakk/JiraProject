using JiraProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectIssuesServices
{
    public interface IProjectIssuesService
    {
        public Task<bool> AddProjectIssues(ProjectIssues projectIssues);

        public Task<bool> UpdateProjectIssues(ProjectIssues projectIssues);

        public Task<List<Menu>> GetAllProjectIssues();

        public Task<Menu> GetProjectIssuesById(int id);

        public Task<bool> DeleteProjectIssues(int projectIssuesID);

        public Task Save();
    }
}
