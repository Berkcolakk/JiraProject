using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;

namespace JiraProject.Services.CompanyServices
{
    public interface ICompanyService
    {
        Task<bool> AddCompany(Company Company);

        public Task<bool> UpdateCompany(Company Company);

        public Task<List<Company>> GetAllCompanys();

        public Task<Company> GetCompanyById(int id);

        Task<bool> DeleteCompany(int CompanyId);

        public Task Save();

        Task<List<Company>> GetAllCompanyWithUserInfo(int companyId);
    }
}