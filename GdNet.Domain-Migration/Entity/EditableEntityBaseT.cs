using System;
using GdNet.Domain.Entity.Impl;

namespace GdNet.Domain.Entity
{
    public abstract class EditableEntityBaseT<TId> : EntityBaseT<TId>, IEditableEntityT<TId> where TId : new()
    {
        private readonly IEntityStateStrategy _stateStrategy;
        private readonly IEntityAvailabilityStrategy _availabilityStrategy;

        /// <summary>
        /// Entity does not support state. It will be empty.
        /// Entity's availability (IsAvailable) is false by default.
        /// </summary>
        protected EditableEntityBaseT()
            : this(new NoStateStrategy(), new EntityNotAvailableByDefaultStrategy())
        {
        }

        protected EditableEntityBaseT(IEntityStateStrategy stateStrategy, IEntityAvailabilityStrategy availabilityStrategy)
        {
            _stateStrategy = stateStrategy;
            _availabilityStrategy = availabilityStrategy;
            InitializeValues();
        }

        private void InitializeValues()
        {
            _availabilityStrategy.SetAvailability(this);
            State = _stateStrategy.GetDefaultState();
        }

        public DateTime? LastModifiedAt { get; set; }

        public string LastModifiedBy
        {
            get;
            set;
        }

        public bool IsAvailable
        {
            get;
            set;
        }

        public string State
        {
            get;
            private set;
        }

        public DateTime? StateLastChangedAt
        {
            get;
            private set;
        }

        public IEditableEntityT<TId> ChangeState(string newState)
        {
            if (_stateStrategy.CanChange(State, newState))
            {
                State = newState;
                StateLastChangedAt = DateTime.Now;
            }
            return this;
        }
    }
}