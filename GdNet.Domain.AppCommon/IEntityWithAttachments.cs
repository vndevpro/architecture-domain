using GdNet.Domain.Entity;
using Rabbit.Foundation.List;
using System;

namespace GdNet.Domain.AppCommon
{
    public interface IEntityWithAttachments : IEntity
    {
        ISmartList<Attachment> Attachments { get; }

        IEntityWithAttachments AddAttachment(Attachment attachment);

        IEntityWithAttachments RemoveAttachment(Guid attachmentId);

        Attachment GetAttachment(Guid attachmentId);
    }
}