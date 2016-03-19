using System;
using GdNet.Domain.Entity.Impl;

namespace GdNet.Domain.Entity
{
    public abstract class EditableEntityBase : EditableEntityBaseT<Guid>, IEditableEntity
    {
        /// <summary>
        /// Entity does not support state. It will be empty.
        /// Entity's availability (IsAvailable) is false by default.
        /// </summary>
        protected EditableEntityBase()
            : this(new NoStateStrategy(), new EntityNotAvailableByDefaultStrategy())
        {
        }

        protected EditableEntityBase(IEntityStateStrategy stateStrategy, IEntityAvailabilityStrategy availabilityStrategy)
            : base(stateStrategy, availabilityStrategy)
        {
        }
    }
}
