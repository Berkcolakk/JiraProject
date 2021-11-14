using TestProject.Repository.GenericRepo;

namespace TestProject.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Save();
        IGenericRepository<T> GetRepository<T>() where T : class;
    }
}
