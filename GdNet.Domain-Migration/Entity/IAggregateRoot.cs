using System;

namespace GdNet.Domain.Entity
{
    public interface IAggregateRoot : IAggregateRootT<Guid>, IEditableEntity
    {
    }
}
