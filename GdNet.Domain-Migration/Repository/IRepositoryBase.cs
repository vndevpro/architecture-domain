using System;
using GdNet.Domain.Entity;

namespace GdNet.Domain.Repository
{
    public interface IRepositoryBase<T> : IRepositoryBaseT<T, Guid>
        where T : IAggregateRoot
    {
    }
}
