namespace GdNet.Domain.Entity
{
    public interface IEntityStateStrategy
    {
        string GetDefaultState();

        bool CanChange(string currentState, string newState);
    }
}
