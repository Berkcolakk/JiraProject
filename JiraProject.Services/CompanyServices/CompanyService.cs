using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.CompanyServiceMangers;
using JiraProject.Services.UserTokenServices;

namespace JiraProject.Services.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<Company> companyRepo;
        private readonly IUserTokenService userTokenService;

        private readonly CompanyManager companyManager;

        private readonly IUnitOfWork unitOfWork;

        public CompanyService(IGenericRepository<Company> companyRepo, CompanyManager companyManager, UnitOfWork unitOfWork, IUserTokenService userTokenService)
        {
            this.companyRepo = companyRepo;
            this.companyManager = companyManager;
            this.unitOfWork = unitOfWork;
            this.userTokenService = userTokenService;
        }

        public async Task<bool> AddCompany(Company Company)
        {
            if (Company == null)
            {
                throw new ArgumentNullException("Company object not found.");
            }
            try
            {
                await companyRepo.Insert(Company);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> UpdateCompany(Company Company)
        {
            if (Company == null)
            {
                throw new ArgumentNullException("Company object not found.");
            }

            try
            {
                companyRepo.Update(Company, x => x.ID, x => x.CrtDate, x => x.CrtUserID, x => x.CrtUserIP);
                await Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Company>> GetAllCompanyWithUserInfo(int companyId)
        {
            return await companyManager.GetAllCompanyWithUserInfo(companyId);
        }

        public async Task<List<Company>> GetAllCompanys()
        {
            try
            {
                return await companyRepo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Company> GetCompanyById(int id)
        {
            try
            {
                return await companyRepo.Get(a => a.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeleteCompany(int CompanyId)
        {
            if (CompanyId == 0)
            {
                throw new ArgumentNullException("CompanyId not found.");
            }

            try
            {
                Company Company = await GetCompanyById(CompanyId);
                companyRepo.Delete(Company);
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