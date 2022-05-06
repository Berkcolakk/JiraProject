using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.RoleServiceMangers;

namespace JiraProject.Services.RoleServices
{
    public class RoleService : IRoleService
    {
        private readonly IGenericRepository<Roles> rolesRepo;

        private readonly ProjectIssuesManager rolesManager;

        private readonly IUnitOfWork unitOfWork;

        public RoleService(IGenericRepository<Roles> rolesRepo, ProjectIssuesManager rolesManager, UnitOfWork unitOfWork)
        {
            this.rolesRepo = rolesRepo;
            this.rolesManager = rolesManager;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddRoles(Roles Roles)
        {
            if (Roles == null)
            {
                throw new ArgumentNullException("Roles object not found.");
            }
            try
            {
                await rolesRepo.Insert(Roles);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> UpdateRoles(Roles Roles)
        {
            if (Roles == null)
            {
                throw new ArgumentNullException("Roles object not found.");
            }

            try
            {
                rolesRepo.Update(Roles, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Roles>> GetAllRoles()
        {
            try
            {
                return await rolesRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Roles> GetRolesById(int id)
        {
            try
            {
                return await rolesRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeleteRoles(int RolesId)
        {
            if (RolesId == 0)
            {
                throw new ArgumentNullException("RolesId not found.");
            }

            try
            {
                Roles Roles = await GetRolesById(RolesId);
                rolesRepo.Delete(Roles);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Save()
        {
            await unitOfWork.Save();
        }
    }
}