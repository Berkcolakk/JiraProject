using System.Collections.Generic;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;

namespace JiraProject.Services.MenuServices
{
    public interface IParentService
    {
        public Task Save();
    }
}