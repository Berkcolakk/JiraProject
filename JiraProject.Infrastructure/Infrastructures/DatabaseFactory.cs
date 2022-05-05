using Microsoft.EntityFrameworkCore;
using JiraProject.DAL.Context;

namespace JiraProject.Infrastructure.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DbContextOptions<TestProjectContext> options;

        public DatabaseFactory(DbContextOptions<TestProjectContext> options)
        {
            this.options = options;
        }

        private TestProjectContext dataContext;

        public TestProjectContext Get()
        {
            return dataContext ?? (dataContext = new TestProjectContext(options));
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