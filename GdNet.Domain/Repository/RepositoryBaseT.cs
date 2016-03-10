using System;
using System.Collections.Generic;
using System.Linq;
using GdNet.Common;
using GdNet.Domain.Entity;

namespace GdNet.Domain.Repository
{
    public abstract class RepositoryBaseT<T, TId> : IRepositoryBaseT<T, TId>
        where T : IAggregateRootT<TId>
        where TId : new()
    {
        public abstract T GetById(TId id);

        public abstract T GetByFilter(Func<T, bool> filter);

        public abstract Result<T> Get(Page page);

        public abstract Result<T> Get(Page page, Func<T, bool> filter);

        public abstract long Count();

        public abstract long Count(Func<T, bool> filter);

        public abstract T Save(T entity);

        public IEnumerable<T> Save(IEnumerable<T> entities)
        {
            return entities.Select(Save);
        }

        public abstract void Delete(TId id);

        public abstract void Delete(T entity);

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Delete(entity);
            }
        }
    }
}