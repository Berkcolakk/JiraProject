using JiraProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectServices
{
    public interface IProjectService
    {
        public Task<List<Projects>> GetAllProjectsWithRelations(UserToken token);
        public Task<bool> AddProject(Projects projects);

        public Task<bool> UpdateProject(Projects projects);

        public Task<List<Projects>> GetAllProject();

        public Task<Projects> GetProjectById(int id);

        public Task<bool> DeleteProject(int projectID);

        public Task Save();
    }
}
