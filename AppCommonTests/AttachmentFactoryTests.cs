using GdNet.Domain.AppCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppCommonTests
{
    [TestClass]
    public class AttachmentFactoryTests
    {
        [TestMethod]
        public void CanLoadAttributes()
        {
            var attachment1 = AttachmentFactory.Create(@"D:\Wip\Practices\OpenSource\architecture-domain\AppCommonTests\AttachmentFactoryTests.cs", true);
            var attributes = attachment1.GetAttributes();
            Assert.AreEqual(3, attributes.Count);
        }
    }
}
