using System.Threading.Tasks;
using JiraProject.Repository.GenericRepo;

namespace JiraProject.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task Save();

        IGenericRepository<T> GetRepository<T>() where T : class;
    }
}