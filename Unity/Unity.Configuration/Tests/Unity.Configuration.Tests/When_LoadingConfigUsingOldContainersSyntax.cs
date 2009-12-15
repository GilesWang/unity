using System.Linq;
using Microsoft.Practices.Unity.Configuration.Tests.ConfigFiles;
using Microsoft.Practices.Unity.TestSupport.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.Unity.Configuration.Tests
{
    /// <summary>
    /// Summary description for When_LoadingConfigUsingOldContainersSyntax
    /// </summary>
    [TestClass]
    public class When_LoadingConfigUsingOldContainersSyntax : SectionLoadingFixture<ConfigFileLocator>
    {
        public When_LoadingConfigUsingOldContainersSyntax()
            : base("OldContainersSyntax")
        {
        }

        [TestMethod]
        public void Then_SectionContainsExpectedNumberOfContainers()
        {
            Assert.AreEqual(2, Section.Containers.Count);
        }

        public void Then_ContainersArePresentInFileOrder()
        {
            CollectionAssert.AreEqual(new[] {"", "two"},
                Section.Containers.Select(c => c.Name).ToList());
        }
    }
}