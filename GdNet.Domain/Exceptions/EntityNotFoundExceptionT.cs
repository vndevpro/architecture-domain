using System;

namespace GdNet.Domain.Exceptions
{
    public class EntityNotFoundExceptionT<TId> : ApplicationException, IDomainException
        where TId : new()
    {
        public EntityNotFoundExceptionT(TId entityId)
        {
            EntityId = entityId;
        }

        public TId EntityId { get; private set; }
    }
}