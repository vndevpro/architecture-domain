using GdNet.Domain.Exceptions;

namespace GdNet.Domain.Entity.Impl
{
    internal sealed class NoStateStrategy : IEntityStateStrategy
    {
        public string GetDefaultState()
        {
            return string.Empty;
        }

        public bool CanChange(string currentState, string newState)
        {
            throw new NoStateException("The entity is not configured to support state");
        }
    }
}
