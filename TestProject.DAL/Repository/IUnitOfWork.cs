namespace TestProject.DAL.Repository
{
    public interface IUnitOfWork
    {
        void Save();
        IGenericRepository<T> GetRepository<T>() where T : class;
    }
}
