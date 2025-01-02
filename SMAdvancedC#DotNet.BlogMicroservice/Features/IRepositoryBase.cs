﻿using System.Linq.Expressions;

namespace SMAdvancedC_DotNet.BlogMicroservice.Features
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> Query (Expression<Func<T, bool>>? expression= null);
        IEnumerable<T> GetAll();
        Task AddAsync(T entity, CancellationToken cs = default);
        void Add(T entity);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cs);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Dispose();
        Task SaveChangesAsync(CancellationToken cs = default);
        void SaveChanges();


    }
}