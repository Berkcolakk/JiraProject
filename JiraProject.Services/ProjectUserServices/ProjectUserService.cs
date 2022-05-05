using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectUserServices
{
    public class ProjectUserService : IProjectUserService
    {
        private readonly IGenericRepository<ProjectUser> projectUser;


        private readonly IUnitOfWork unitOfWork;

        public ProjectUserService(IGenericRepository<ProjectUser> projectUser, UnitOfWork unitOfWork)
        {
            this.projectUser = projectUser;
            this.unitOfWork = unitOfWork;
        }
        public Task<bool> AddProjectUser(ProjectUser projectUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjectUser(int projectUserID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Menu>> GetAllProjectUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetProjectUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectUser(ProjectUser projectUser)
        {
            throw new NotImplementedException();
        }
    }
}
