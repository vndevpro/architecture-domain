namespace GdNet.Domain.Entity.Impl
{
    /// <summary>
    /// This strategy always accepts state changing, only requires different bitween old state and new state
    /// </summary>
    public sealed class DefaultStateStrategy : IEntityStateStrategy
    {
        public string GetDefaultState()
        {
            return string.Empty;
        }

        public bool CanChange(string currentState, string newState)
        {
            return currentState != newState;
        }
    }
}