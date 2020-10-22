using System;
using System.Collections.Generic;
using GdNet.Common;
using GdNet.Domain.Entity;

namespace GdNet.Domain.Repository
{
    public interface IRepositoryBaseT<T, in TId>
        where T : IAggregateRootT<TId>
        where TId : new()
    {
        T GetById(TId id);

        T GetByFilter(Func<T, bool> filter);

        Result<T> Get(Page page);

        Result<T> Get(Page page, Func<T, bool> filter);

        long Count();

        long Count(Func<T, bool> filter);

        T Save(T entity);

        IEnumerable<T> Save(IEnumerable<T> entities);

        /// <summary>
        /// Delete an entity by its Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(TId id);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);
    }
}