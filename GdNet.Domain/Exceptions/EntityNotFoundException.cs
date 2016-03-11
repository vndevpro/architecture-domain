using System;

namespace GdNet.Domain.Exceptions
{
    public class EntityNotFoundException : EntityNotFoundExceptionT<Guid>, IDomainException
    {
        public EntityNotFoundException(Guid entityId)
            : base(entityId)
        {
        }
    }
}
