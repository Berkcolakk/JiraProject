using System.Threading.Tasks;
using System.Transactions;
using JiraProject.DAL.Context;
using JiraProject.Infrastructure.Infrastructures;
using JiraProject.Repository.GenericRepo;

namespace JiraProject.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;

        private JiraProjectContext dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected JiraProjectContext DataContext => dataContext ?? (dataContext = databaseFactory.Get());

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