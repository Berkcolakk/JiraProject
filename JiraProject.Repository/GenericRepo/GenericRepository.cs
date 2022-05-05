﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JiraProject.DAL.Context;
using JiraProject.Infrastructure.Infrastructures;

namespace JiraProject.Repository.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private JiraProjectContext _context;

        private readonly DbSet<T> _entities;

        protected IDatabaseFactory DatabaseFactory { get; private set; }

        public GenericRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected JiraProjectContext DataContext => _context ?? (_context = DatabaseFactory.Get());

        public virtual IQueryable<T> Table => Entities;

        public virtual IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _entities ?? DataContext.Set<T>();

        public virtual async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await Entities.Where(predicate).SingleOrDefaultAsync();
        }

        public virtual async ValueTask<T> GetById(object id)
        {
            return await Entities.FindAsync(id);
        }

        public virtual async Task<List<T>> GetMany(Expression<Func<T, bool>> predicate)
        {
            return await Entities.Where(predicate).ToListAsync();
        }

        public virtual Task<List<T>> GetManyNoTracking(Expression<Func<T, bool>> predicate)
        {
            return TableNoTracking.Where(predicate).ToListAsync();
        }

        public Task<List<T>> GetAll()
        {
            return Entities.ToListAsync();
        }

        public virtual async Task Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                await Entities.AddAsync(entity);
            }
            catch (Exception dbEx)
            {
                //throw new Exception(GetFullErrorText(dbEx), dbEx);
                throw new Exception(dbEx.Message);
            }
        }

        public virtual async Task Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                {
                    throw new ArgumentNullException("entities");
                }

                foreach (T entity in entities)
                {
                    await Entities.AddAsync(entity);
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