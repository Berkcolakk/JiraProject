﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JiraProject.Repository.GenericRepo
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll();

        Task<List<T>> GetMany(Expression<Func<T, bool>> predicate);

        ValueTask<T> GetById(object id);

        Task<T> Get(Expression<Func<T, bool>> predicate);

        Task Insert(T entity);

        Task Insert(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        Task<List<T>> GetManyNoTracking(Expression<Func<T, bool>> predicate);
    }
}