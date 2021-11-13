using TestProject.Repository.GenericRepo;

namespace TestProject.Infrastructure.Infrastructures
{
    public interface IUnitOfWork
    {
        void Save();
        IGenericRepository<T> GetRepository<T>() where T : class;
    }
}
