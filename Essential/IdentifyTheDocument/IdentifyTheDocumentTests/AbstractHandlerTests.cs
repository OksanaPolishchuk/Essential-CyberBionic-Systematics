using System;
using System.IO;
using System.Net.Mime;
using System.Text;
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
        private IFileWrapper _mockFile;

        [TestInitialize]
        public void Init()
        {
             _mockFileInfo = Substitute.For<IFileInfoWrapper>();
             _mockFileInfo.Name.Returns("fileInfoName");
             _mockFileInfo.FullName.Returns("fullFileName");
             _mockFileInfo.CreationTime.Returns(new DateTime(2020, 12, 31));
             _mockFileInfo.Extension.Returns(".txt");

            _mockConsole = Substitute.For<IConsoleWrapper>();

            _mockFile = Substitute.For<IFileWrapper>();
            _mockFile.ReadAllText(_mockFileInfo.FullName).Returns(44.ToString());

            _target = new AbstractHandler(_mockFile, _mockFileInfo, _mockConsole);
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
        public void ChangeTest()
        {
            _target.Change("testContent");
            _mockFile.Received().AppendAllText("fullFileName", "testContent");
            _mockFile.Received().ReadAllText("fullFileName");
            _mockConsole.Received().WriteLine("44");
        }

        [TestMethod()]
        public void CreateTest()
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