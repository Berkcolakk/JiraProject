using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JiraProject.DAL.Context;
using JiraProject.DAL.Entities;

namespace JiraProject.ServiceManager.CompanyServiceMangers
{
    public class CompanyManager
    {
        private readonly JiraProjectContext context;

        public CompanyManager(JiraProjectContext context)
        {
            this.context = context;
        }

        public async Task<List<Company>> GetAllCompanyWithUserInfo(int companyId)
        {
            return await context.Company.Where(x => x.ID == companyId)
                .Include(x => x.CompanyUsers).ThenInclude(x => x.UserRole).ToListAsync();
        }
    }
}