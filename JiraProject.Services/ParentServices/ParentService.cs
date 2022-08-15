using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.DAL.Entities.StudentParents;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.MenuServiceMangers;

namespace JiraProject.Services.MenuServices
{
    public class ParentService : IParentService
    {
        private readonly IGenericRepository<Parent> parentRepo;

        private readonly IUnitOfWork unitOfWork;

        public ParentService(IGenericRepository<Parent> parentRepo, UnitOfWork unitOfWork)
        {
            this.parentRepo = parentRepo;
            this.unitOfWork = unitOfWork;
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }
    }
}