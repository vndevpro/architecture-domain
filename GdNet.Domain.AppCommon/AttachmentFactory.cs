using System.Globalization;
using System.IO;
using System.Web;

namespace GdNet.Domain.AppCommon
{
    public class AttachmentFactory
    {
        /// <summary>
        /// Create a object with default available and set value for Size
        /// </summary>
        /// <param name="contentBytes"></param>
        /// <returns></returns>
        public static Attachment Create(byte[] contentBytes)
        {
            return new Attachment()
            {
                Content = contentBytes,
                IsAvailable = true,
                Size = contentBytes.Length,
            };
        }

        public static Attachment Create(string attachmentPath)
        {
            return Create(attachmentPath, false);
        }

        /// <summary>
        /// Create an Attachment object & load information into attributes.
        /// Include - Name, ContentType, Extension, Size and common attributes
        /// </summary>
        public static Attachment Create(string attachmentPath, bool includeContent)
        {
            var fileInfo = new FileInfo(attachmentPath);

            var newAttachment = new Attachment()
            {
                Name = fileInfo.Name,
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