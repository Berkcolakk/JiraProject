﻿using TestProject.DAL.Context;

namespace TestProject.Infrastructure.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private TestProjectContext dataContext;

        public TestProjectContext Get()
        {
            return dataContext ?? (dataContext = new TestProjectContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }
    }
}