using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;

namespace TestProject.Services.RoleServices
{
    public class RoleService : IRoleService
    {
        private readonly IGenericRepository<Roles> rolesRepo;
        private readonly RoleManager rolesManager;
        private readonly IUnitOfWork unitOfWork;
        public RoleService(IGenericRepository<Roles> rolesRepo, RoleManager rolesManager, UnitOfWork unitOfWork)
        {
            this.rolesRepo = rolesRepo;
            this.rolesManager = rolesManager;
            this.unitOfWork = unitOfWork;
        }
        public bool AddRoles(Roles Roles)
        {
            if (Roles == null)
            {
                throw new ArgumentNullException("Roles object not found.");
            }
            try
            {
                rolesRepo.Insert(Roles);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateRoles(Roles Roles)
        {
            if (Roles == null)
            {
                throw new ArgumentNullException("Roles object not found.");
            }

            try
            {
                rolesRepo.Update(Roles, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Roles> GetAllRoles()
        {
            try
            {
                return rolesRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Roles GetRolesById(int id)
        {
            try
            {
                return rolesRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool DeleteRoles(int RolesId)
        {
            if (RolesId == 0)
            {
                throw new ArgumentNullException("RolesId not found.");
            }

            try
            {
                Roles Roles = GetRolesById(RolesId);
                rolesRepo.Delete(Roles);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Save()
        {

            unitOfWork.Save();
        }
    }
}
