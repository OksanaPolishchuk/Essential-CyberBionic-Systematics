using Microsoft.VisualStudio.TestTools.UnitTesting;
using IdentifyTheDocument;
using NSubstitute;

namespace IdentifyTheDocumentTests
{
    [TestClass()]
    public class AbstractHandlerTest
    {
        private AbstractHandler _target;
        private IFileInfoWrapper _mockFileInfo;

        [TestInitialize]
        public void Init()
        {
             _mockFileInfo = Substitute.For<IFileInfoWrapper>();
             _mockFileInfo.Name.Returns("fileInfoName");
            _target = new AbstractHandler(_mockFileInfo);
        }

        [TestMethod()]
        public void OpenTest()
        {
            _target.Open();
            var name = _mockFileInfo.Received().Name;
            var creationTime = _mockFileInfo.Received().CreationTime;
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveTest()
        {
            Assert.Fail();
        }
    }
}