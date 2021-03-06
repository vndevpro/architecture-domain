﻿using System;

namespace GdNet.Domain.Entity
{
    public abstract class EntityBase : EntityBaseT<Guid>, IEntity
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
