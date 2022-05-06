﻿using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
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


        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IGenericRepository<Projects> project, UnitOfWork unitOfWork)
        {
            this.project = project;
            this.unitOfWork = unitOfWork;
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

        public Task<bool> DeleteProject(int projectID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Menu>> GetAllProject()
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProject(Projects projects)
        {
            throw new NotImplementedException();
        }
    }
}
