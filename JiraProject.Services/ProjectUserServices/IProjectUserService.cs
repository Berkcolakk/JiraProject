using JiraProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectUserServices
{
    public interface IProjectUserService
    {
        public Task<bool> AddProjectUser(ProjectUser projectUser);

        public Task<bool> UpdateProjectUser(ProjectUser projectUser);

        public Task<List<Menu>> GetAllProjectUsers();

        public Task<Menu> GetProjectUserById(int id);

        public Task<bool> DeleteProjectUser(int projectUserID);

        public Task Save();
    }
}
