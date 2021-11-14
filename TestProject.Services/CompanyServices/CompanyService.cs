using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;

namespace TestProject.Services.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<Company> companyRepo;
        private readonly CompanyManager companyManager;
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(IGenericRepository<Company> companyRepo, CompanyManager companyManager, UnitOfWork unitOfWork)
        {
            this.companyRepo = companyRepo;
            this.companyManager = companyManager;
            this.unitOfWork = unitOfWork;
        }
        public bool AddCompany(Company Company)
        {
            if (Company == null)
            {
                throw new ArgumentNullException("Company object not found.");
            }
            try
            {
                companyRepo.Insert(Company);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool UpdateCompany(Company Company)
        {
            if (Company == null)
            {
                throw new ArgumentNullException("Company object not found.");
            }

            try
            {
                companyRepo.Update(Company, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Company> GetAllCompanys()
        {
            try
            {
                return companyRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Company GetCompanyById(int id)
        {
            try
            {
                return companyRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool DeleteCompany(int CompanyId)
        {
            if (CompanyId == 0)
            {
                throw new ArgumentNullException("CompanyId not found.");
            }

            try
            {
                Company Company = GetCompanyById(CompanyId);
                companyRepo.Delete(Company);
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
