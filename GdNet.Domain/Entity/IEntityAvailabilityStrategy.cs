namespace GdNet.Domain.Entity
{
    public interface IEntityAvailabilityStrategy
    {
        void SetAvailability<TId>(IEditableEntityT<TId> entity) where TId : new();
    }
}