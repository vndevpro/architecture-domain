﻿using System;

namespace GdNet.Domain.Exceptions
{
    /// <summary>
    /// Use this exception when getting an entity from system and it is not existing
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public class EntityNotFoundException<TId> : ApplicationException, IDomainException
        where TId : new()
    {
        public EntityNotFoundException(TId entityId)
            : this(entityId, string.Empty)
        {
        }

        public EntityNotFoundException(TId entityId, string message)
            : base(message)
        {
            EntityId = entityId;
        }

        /// <summary>
        /// Id of then entity
        /// </summary>
        public TId EntityId { get; private set; }
    }
}