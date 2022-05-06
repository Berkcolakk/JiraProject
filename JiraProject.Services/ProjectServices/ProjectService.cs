using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.ProjectServiceMangers;
using JiraProject.Services.UserTokenServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly IGenericRepository<Projects> project;
        private readonly ProjectManager projectsManager;
        private readonly IUserTokenService userTokenService;


        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IGenericRepository<Projects> project, UnitOfWork unitOfWork, ProjectManager projectsManager, IUserTokenService userTokenService)
        {
            this.project = project;
            this.unitOfWork = unitOfWork;
            this.projectsManager = projectsManager;
            this.userTokenService = userTokenService;
        }

        public async Task<List<Projects>> GetAllProjectsWithRelations(UserToken token)
        {
            return await projectsManager.GetallProjectsWithRelations(token.IPUserTokenUser.CompanyID);
        }
        public async Task<bool> AddProject(Projects projects)
        {
            if (projects == null)
            {
                throw new ArgumentNullException("Projects object not found.");
            }
            try
            {
                await project.Insert(projects);
                await Save();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteProject(int projectID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Projects>> GetAllProject()
        {
            throw new NotImplementedException();
        }

        public Task<Projects> GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }

        public async Task<bool> UpdateProject(Projects projects)
        {
            throw new NotImplementedException();
        }
    }
}
