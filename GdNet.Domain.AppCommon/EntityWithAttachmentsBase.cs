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
            : base()
        {
            _attachments = new List<Attachment>();
        }

        protected EntityWithAttachmentsBase(IEntityStateStrategy stateStrategy,
            IEntityAvailabilityStrategy availabilityStrategy)
            : base(stateStrategy, availabilityStrategy)
        {
            _attachments = new List<Attachment>();
        }

        public virtual ISmartList<Attachment> Attachments
        {
            get { return new SmartList<Attachment>(_attachments); }
        }

        public virtual IEntityWithAttachments AddAttachment(Attachment attachment)
        {
            if (Attachments.All(x => x.Id != attachment.Id))
            {
                _attachments.Add(attachment);
            }
            return this;
        }

        public virtual IEntityWithAttachments RemoveAttachment(Guid attachmentId)
        {
            var attachment = GetAttachment(attachmentId);
            if (attachment != null)
            {
                _attachments.Remove(attachment);
            }
            return this;
        }

        public virtual Attachment GetAttachment(Guid attachmentId)
        {
            return Attachments.FirstOrDefault(x => x.Id == attachmentId);
        }
    }
}