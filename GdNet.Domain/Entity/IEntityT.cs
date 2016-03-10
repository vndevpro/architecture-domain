using System;

namespace GdNet.Domain.Entity
{
    public interface IEntityT<TId> where TId : new()
    {
        TId Id { get; set; }

        DateTime CreatedAt { get; set; }

        string CreatedBy { get; set; }

        string Note { get; set; }
    }
}