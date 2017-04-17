using System.Globalization;
using System.IO;
using System.Web;

namespace GdNet.Domain.AppCommon
{
    public class AttachmentFactory
    {
        public static Attachment Create(string attachmentPath)
        {
            return Create(attachmentPath, false);
        }

        public static Attachment Create(string attachmentPath, bool includeContent)
        {
            var fileInfo = new FileInfo(attachmentPath);

            var newAttachment = new Attachment()
            {
                Name = fileInfo.Name,
                // TODO: remove dependent on System.Web
                ContentType = MimeMapping.GetMimeMapping(fileInfo.Name),
                Extension = fileInfo.Extension,
                Size = fileInfo.Length,
                IsAvailable = true
            };

            if (includeContent)
            {
                newAttachment.Content = File.ReadAllBytes(attachmentPath);

                LoadAttributes(newAttachment, fileInfo);
            }

            return newAttachment;
        }

        private static void LoadAttributes(Attachment entity, FileInfo fileInfo)
        {
            var attributes = entity.GetAttributes();

            attributes.Add("CreationTime", fileInfo.CreationTime.ToFileTime().ToString(CultureInfo.InvariantCulture));
            attributes.Add("LastAccessTime", fileInfo.LastAccessTime.ToFileTime().ToString(CultureInfo.InvariantCulture));
            attributes.Add("LastWriteTime", fileInfo.LastWriteTime.ToFileTime().ToString(CultureInfo.InvariantCulture));
        }
    }
}