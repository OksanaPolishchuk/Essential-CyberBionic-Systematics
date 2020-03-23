using System;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IdentifyTheDocument;
using IdentifyTheDocument.Wrappers;
using NSubstitute;

namespace IdentifyTheDocumentTests
{
    [TestClass()]
    public class AbstractHandlerTest
    {
        private AbstractHandler _target;

        private IFileInfoWrapper _mockFileInfo;
        private IConsoleWrapper _mockConsole;

        [TestInitialize]
        public void Init()
        {
             _mockFileInfo = Substitute.For<IFileInfoWrapper>();
             _mockFileInfo.Name.Returns("fileInfoName");
             _mockFileInfo.CreationTime.Returns(new DateTime(2020, 12, 31));
             _mockFileInfo.Extension.Returns(".txt");
            
             _mockConsole = Substitute.For<IConsoleWrapper>();

             _target = new AbstractHandler(_mockFileInfo, _mockConsole);
        }

        [TestMethod()]
        public void OpenTest()
        {
            _target.Open();
            var name = _mockFileInfo.Received().Name;
            var creationTime = _mockFileInfo.Received().CreationTime;
            var extension = _mockFileInfo.Received().Extension;
            _mockConsole.Received().WriteLine($"Name: fileInfoName");
            _mockConsole.Received().WriteLine($"Time: 31.12.2020 0:00:00");
            _mockConsole.Received().WriteLine($"Extension: .txt");
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