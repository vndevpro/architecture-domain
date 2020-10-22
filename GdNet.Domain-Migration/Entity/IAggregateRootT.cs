namespace GdNet.Domain.Entity
{
    public interface IAggregateRootT<TId> : IEditableEntityT<TId> where TId : new()
    {
    }
}