using System.Collections.Generic;
using TestProject.DAL.Entities;

namespace TestProject.Services.CompanyServices
{
    public interface ICompanyService
    {
        bool AddCompany(Company Company);
        public bool UpdateCompany(Company Company);
        public List<Company> GetAllCompanys();
        public Company GetCompanyById(int id);
        bool DeleteCompany(int CompanyId);
        public void Save();
    }
}
