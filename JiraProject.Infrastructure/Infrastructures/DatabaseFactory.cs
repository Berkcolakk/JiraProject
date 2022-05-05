using Microsoft.EntityFrameworkCore;
using JiraProject.DAL.Context;

namespace JiraProject.Infrastructure.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DbContextOptions<JiraProjectContext> options;

        public DatabaseFactory(DbContextOptions<JiraProjectContext> options)
        {
            this.options = options;
        }

        private JiraProjectContext dataContext;

        public JiraProjectContext Get()
        {
            return dataContext ?? (dataContext = new JiraProjectContext(options));
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }
    }
}