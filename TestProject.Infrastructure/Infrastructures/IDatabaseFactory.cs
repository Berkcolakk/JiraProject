using System;
using TestProject.DAL.Context;

namespace TestProject.Infrastructure.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        TestProjectContext Get();
    }
}