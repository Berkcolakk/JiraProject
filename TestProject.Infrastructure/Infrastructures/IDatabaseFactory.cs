using System;
using JiraProject.DAL.Context;

namespace JiraProject.Infrastructure.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        TestProjectContext Get();
    }
}