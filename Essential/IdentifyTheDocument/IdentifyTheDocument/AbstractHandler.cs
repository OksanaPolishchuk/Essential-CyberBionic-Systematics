using System;
using System.IO;
using System.Text;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    public abstract class AbstractHandler
    {
        private readonly IFileWrapper _file;
        private readonly IFileInfoWrapper _fileInfo;
        private readonly IConsoleWrapper _console;
        private readonly IDirectoryWrapper _directory;

        protected AbstractHandler(IFileWrapper file,
            IFileInfoWrapper fileInfo,
            IConsoleWrapper console, 
            IDirectoryWrapper directory)

        {
            _file = file;
            _fileInfo = fileInfo;
            _console = console;
            _directory = directory;
        }

        public abstract void Create(string path);

        public abstract void Change(string path, string contents);

        public abstract void Open(string value);

        public abstract void Save(string sourceFileName, string destFileName);
    }

    public class XmlHandler : AbstractHandler
    {
        private readonly IFileWrapper _file;
        private readonly IFileInfoWrapper _fileInfo;
        private readonly IConsoleWrapper _console;
        private readonly IDirectoryWrapper _directory;

        public XmlHandler(IFileWrapper file, IFileInfoWrapper fileInfo, IConsoleWrapper console, IDirectoryWrapper directory)
            : base(file, fileInfo, console, directory)
        {
            _file = file;
            _fileInfo = fileInfo;
            _console = console;
            _directory = directory;
        }

        public override void Create(string path)
        {
            _directory.CreateDirectory(path);
            _console.WriteLine($"The directory was created successfully at {_directory.GetCreationTime(path)}.");
        }

        public override void Change(string path, string contents)
        {
            
        }

        public override void Open(string value)
        {
            
        }

        public override void Save(string sourceFileName, string destFileName)
        {
            
        }
    }
}