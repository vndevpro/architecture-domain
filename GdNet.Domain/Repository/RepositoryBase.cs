using GdNet.Domain.Entity;
using System;

namespace GdNet.Domain.Repository
{
    public abstract class RepositoryBase<T> : RepositoryBaseT<T, Guid>, IRepositoryBase<T>
        where T : IAggregateRoot
    {
    }
}
