using System;

namespace GdNet.Domain.Entity
{
    public interface IEditableEntity : IEditableEntityT<Guid>, IEntity
    {
    }
}
