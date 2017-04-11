namespace GdNet.Domain.Exceptions
{
    /// <summary>
    /// Domain layer exception
    /// </summary>
    public interface IDomainException
    {
        /// <summary>
        /// Error message
        /// </summary>
        string Message { get; }
    }
}
