using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TestProject.DAL.Context;
using TestProject.Infrastructure.Infrastructures;

namespace TestProject.Repository.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private TestProjectContext _context;
        private readonly DbSet<T> _entities;
        protected IDatabaseFactory DatabaseFactory { get; private set; }

        public GenericRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected TestProjectContext DataContext => _context ?? (_context = DatabaseFactory.Get());

        public virtual IQueryable<T> Table => Entities;

        public virtual IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _entities ?? DataContext.Set<T>();

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate).SingleOrDefault();
        }

        public virtual T GetById(object id)
        {
            return Entities.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate).ToList();
        }
        public virtual IEnumerable<T> GetManyNoTracking(Expression<Func<T, bool>> predicate)
        {
            return TableNoTracking.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.ToList();
        }

        public virtual void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Entities.Add(entity);
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                {
                    throw new ArgumentNullException("entities");
                }

                foreach (T entity in entities)
                {
                    Entities.Add(entity);
                }
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Entities.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                {
                    throw new ArgumentNullException("entities");
                }

                foreach (T entity in entities)
                {
                    Entities.Attach(entity);
                    DataContext.Entry(entity).State = EntityState.Modified;
                }

            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties)
        {
            Entities.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Modified;

            foreach (Expression<Func<T, object>> property in noUpdateProperties)
            {
                DataContext.Entry(entity).Property(property).IsModified = false;
            }
        }


        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Entities.Remove(entity);
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                {
                    throw new ArgumentNullException("entities");
                }

                foreach (T entity in entities)
                {
                    Entities.Remove(entity);
                }
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }
    }
}
