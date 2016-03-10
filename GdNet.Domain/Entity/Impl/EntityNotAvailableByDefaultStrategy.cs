namespace GdNet.Domain.Entity.Impl
{
    /// <summary>
    /// This strategy will set IsAvailable to false
    /// </summary>
    public sealed class EntityNotAvailableByDefaultStrategy : IEntityAvailabilityStrategy
    {
        public void SetAvailability<TId>(IEditableEntityT<TId> entity) where TId : new()
        {
            entity.IsAvailable = false;
        }
    }
}