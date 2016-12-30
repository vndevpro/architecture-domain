using GdNet.Domain.Entity;
using System;

namespace GdNet.Domain.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RepositoryBase<T> : RepositoryBaseT<T, Guid>, IRepositoryBase<T>
        where T : IAggregateRoot
    {
    }
}
