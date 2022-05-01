using System.Threading.Tasks;
using TestProject.Repository.GenericRepo;

namespace TestProject.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task Save();

        IGenericRepository<T> GetRepository<T>() where T : class;
    }
}