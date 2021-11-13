using System;
using TestProject.DAL.Context;

namespace WiodySurvey.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        TestProjectContext Get();
    }
}
