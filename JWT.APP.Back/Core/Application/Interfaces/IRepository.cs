﻿using System.Linq.Expressions;

namespace JWT.APP.Back.Core.Interfaces
{
    public interface IRepository<T> where T : class,new()
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T,bool>> filter);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
