using System;

namespace GdNet.Domain.Exceptions
{
    public class CommitDataException : ApplicationException, IDomainException
    {
        public CommitDataException()
        {
        }

        public CommitDataException(Exception innerException)
            : base(string.Empty, innerException)
        {
        }
    }
}
