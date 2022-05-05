using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectIssuesServices
{
    public class ProjectIssuesService : IProjectIssuesService
    {
        private readonly IGenericRepository<ProjectIssues> projectIssues;


        private readonly IUnitOfWork unitOfWork;

        public ProjectIssuesService(IGenericRepository<ProjectIssues> projectIssues, UnitOfWork unitOfWork)
        {
            this.projectIssues = projectIssues;
            this.unitOfWork = unitOfWork;
        }
        public Task<bool> AddProjectIssues(ProjectIssues projectIssues)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjectIssues(int projectIssuesID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Menu>> GetAllProjectIssues()
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetProjectIssuesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectIssues(ProjectIssues projectIssues)
        {
            throw new NotImplementedException();
        }
    }
}
