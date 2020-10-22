namespace GdNet.Domain.Entity.Impl
{
    public sealed class EntityAvailableByDefaultStrategy : IEntityAvailabilityStrategy
    {
        public void SetAvailability<TId>(IEditableEntityT<TId> entity) where TId : new()
        {
            entity.IsAvailable = true;
        }
    }
}