using System;
using System.IO;
using System.Text;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    public class AbstractHandler
    {
        private readonly IFileInfoWrapper _fileInfo;
        private readonly IConsoleWrapper _console;

        public AbstractHandler(IFileInfoWrapper fileInfo, IConsoleWrapper console)
        {
            _fileInfo = fileInfo;
            _console = console;
        }

        public virtual void Open()
        {
            _console.WriteLine($"Name: {_fileInfo.Name}");
            _console.WriteLine("Time: {0}", _fileInfo.CreationTime);
            _console.WriteLine("Extension: {0}", _fileInfo.Extension);
        }
    }
}