using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.DAL.Context;
using TestProject.DAL.Entities;

namespace TestProject.ServiceManager.CompanyServiceMangers
{
    public class CompanyManager
    {
        private readonly TestProjectContext context;
        public CompanyManager(TestProjectContext context)
        {
            this.context = context;
        }

        public async Task<List<Company>> GetAllCompanyWithUserInfo(int companyId)
        {
            return await context.Company.Where(x => x.ID == companyId)
                .Include(x => x.User).ThenInclude(x => x.UserRole).ToListAsync();
        }
    }
}
