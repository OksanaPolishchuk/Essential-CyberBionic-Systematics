using System;
using System.Globalization;
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
        private IDirectoryWrapper _mockDirectory;

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
            _mockFile.ReadAllText(_mockFileInfo.Name).Returns("5545");

            _mockDirectory = Substitute.For<IDirectoryWrapper>();
            _mockDirectory.CreateDirectory(_mockFileInfo.Name);
            _mockDirectory.GetCreationTime(_mockFileInfo.CreationTime.ToString(CultureInfo.InvariantCulture));

            _target = new XmlHandler(_mockFile, _mockFileInfo, _mockConsole, _mockDirectory);
        }

        [TestMethod()]
        public void OpenTest()
        {
            _target.Open("fileInfoName");
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
            _target.Change(_mockFileInfo.Name, "44");
            _mockFile.Received().AppendAllText(_mockFileInfo.Name, "44");
            _mockFile.Received().ReadAllText(_mockFileInfo.Name);
            _mockConsole.Received().WriteLine("5545");
        }

        [TestMethod()]
        public void CreateTest()
        {
            _target.Create(_mockFileInfo.Name);
            _mockDirectory.Received().CreateDirectory(_mockFileInfo.Name);
            _mockDirectory.Received().GetCreationTime(_mockFileInfo.CreationTime.ToString(CultureInfo.InvariantCulture));
            _mockConsole.Received().WriteLine($"The directory was created successfully at {_mockDirectory.GetCreationTime("")}.");
        }

        [TestMethod()]
        public void SaveTest()
        {
            _target.Save(_mockFileInfo.Name, _mockFileInfo.FullName);
            _mockFile.Received().Move(_mockFileInfo.Name, _mockFileInfo.FullName);
            _mockConsole.Received().WriteLine($"{_mockFileInfo.Name} was moved to {_mockFileInfo.FullName}.");
        }
    }
}