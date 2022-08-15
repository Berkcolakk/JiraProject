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
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student> studentRepo;
        private readonly IUnitOfWork unitOfWork;
        public StudentService(IGenericRepository<Student> studentRepo, UnitOfWork unitOfWork)
        {
            this.studentRepo = studentRepo;
            this.unitOfWork = unitOfWork;
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }
    }
}