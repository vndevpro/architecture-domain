using GdNet.Domain.Entity;
using Rabbit.Foundation.List;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.Domain.AppCommon
{
    public abstract class EntityWithAttachmentsBase : EditableEntityBase, IEntityWithAttachments
    {
        private readonly IList<Attachment> _attachments;

        protected EntityWithAttachmentsBase()
        {
            _attachments = new List<Attachment>();
        }

        public virtual ISmartList<Attachment> Attachments
        {
            get { return new SmartList<Attachment>(_attachments); }
        }

        public IEntityWithAttachments AddAttachment(Attachment attachment)
        {
            if (_attachments.All(x => x.Id != attachment.Id))
            {
                _attachments.Add(attachment);
            }
            return this;
        }

        public IEntityWithAttachments RemoveAttachment(Guid attachmentId)
        {
            var attachment = GetAttachment(attachmentId);
            if (attachment != null)
            {
                _attachments.Remove(attachment);
            }
            return this;
        }

        public Attachment GetAttachment(Guid attachmentId)
        {
            return Attachments.FirstOrDefault(x => x.Id == attachmentId);
        }
    }
}