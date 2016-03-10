using System;

namespace GdNet.Domain.Entity
{
    public abstract class EntityBaseT<TId> : IEntityT<TId> where TId : new()
    {
        protected EntityBaseT()
        {
            Id = new TId();
            CreatedAt = DateTime.Now;
        }

        public TId Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy
        {
            get;
            set;
        }

        public string Note
        {
            get;
            set;
        }
    }
}