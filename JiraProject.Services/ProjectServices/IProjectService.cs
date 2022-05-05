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
        public Task<bool> AddProject(Projects projects);

        public Task<bool> UpdateProject(Projects projects);

        public Task<List<Menu>> GetAllProject();

        public Task<Menu> GetProjectById(int id);

        public Task<bool> DeleteProject(int projectID);

        public Task Save();
    }
}
