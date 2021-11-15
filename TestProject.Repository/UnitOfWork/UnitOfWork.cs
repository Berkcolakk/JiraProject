using System.Threading.Tasks;
using System.Transactions;
using TestProject.DAL.Context;
using TestProject.Infrastructure.Infrastructures;
using TestProject.Repository.GenericRepo;

namespace TestProject.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private TestProjectContext dataContext;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected TestProjectContext DataContext => dataContext ?? (dataContext = databaseFactory.Get());

        public async Task Save()
        {
            using (TransactionScope tScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await DataContext.SaveChangesAsync();
                tScope.Complete();
            }
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(databaseFactory);
        }
    }
}
