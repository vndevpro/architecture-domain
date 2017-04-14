using GdNet.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace GdNet.Domain.AppCommon
{
    public class Attachment : EditableEntityBase, IAggregateRoot
    {
        private IDictionary<string, string> _attributes = new Dictionary<string, string>();

        public string Name { get; set; }

        public string Extension { get; set; }

        public string ContentType { get; set; }

        public long Size { get; set; }

        public string OriginalFilePath { get; set; }

        public virtual byte[] Content { get; set; }

        /// <summary>
        /// Contains XML data of the attributes
        /// </summary>
        public string AttributesData
        {
            get
            {
                var xElem = new XElement(
                    "items",
                    _attributes.Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)))
                 );
                return xElem.ToString();
            }
            set
            {
                var xElem = XElement.Parse(value);
                var dict = xElem.Descendants("item")
                                    .ToDictionary(
                                        x => (string)x.Attribute("key"),
                                        x => (string)x.Attribute("value"));
                _attributes = dict;
            }
        }

        public IDictionary<string, string> GetAttributes()
        {
            return _attributes;
        }

        public Attachment AddAttribute(string key, string value)
        {
            _attributes.Add(key, value);
            return this;
        }
    }
}
