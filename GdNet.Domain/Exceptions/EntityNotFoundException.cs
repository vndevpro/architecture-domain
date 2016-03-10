using System;

namespace GdNet.Domain.Exceptions
{
    public class EntityNotFoundException : ApplicationException, IDomainException
    {
        public EntityNotFoundException(Guid entityId)
        {
            EntityId = entityId;
        }

        public Guid EntityId { get; private set; }
    }
}
