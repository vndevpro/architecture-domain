using System;

namespace GdNet.Domain.Exceptions
{
    internal class NoStateException : ApplicationException, IDomainException
    {
        public NoStateException()
        {
        }

        public NoStateException(string message)
            : base(message)
        {
        }

        public NoStateException(Exception innerException)
            : base(string.Empty, innerException)
        {
        }
    }
}