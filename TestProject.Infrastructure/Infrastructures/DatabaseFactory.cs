using Microsoft.EntityFrameworkCore;
using TestProject.DAL.Context;

namespace TestProject.Infrastructure.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        DbContextOptions<TestProjectContext> options;
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
