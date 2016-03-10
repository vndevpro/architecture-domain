using System;

namespace GdNet.Domain.Entity
{
    public interface IEditableEntityT<TId> : IEntityT<TId> where TId : new()
    {
        DateTime? LastModifiedAt { get; set; }

        string LastModifiedBy { get; set; }

        bool IsAvailable { get; set; }

        string State { get; }

        DateTime? StateLastChangedAt { get; }

        IEditableEntityT<TId> ChangeState(string newState);
    }
}