using System;
using System.IO;
using System.Text;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    public class AbstractHandler
    {
        private readonly IFileWrapper _file;
        private readonly IFileInfoWrapper _fileInfo;
        private readonly IConsoleWrapper _console;
        private readonly IDirectoryWrapper _directory;

        public AbstractHandler(IFileWrapper file,
            IFileInfoWrapper fileInfo,
            IConsoleWrapper console, IDirectoryWrapper directory)
        {
            _file = file;
            _fileInfo = fileInfo;
            _console = console;
            _directory = directory;
        }

        public virtual void Open(string value)
        {
            _console.WriteLine($"Name: {_fileInfo.Name}");
            _console.WriteLine($"Time: {_fileInfo.CreationTime}");
            _console.WriteLine($"Extension: {_fileInfo.Extension}");
        }

        public virtual void Change(string path, string contents)
        {
            _file.AppendAllText(path, contents);
            var text = _file.ReadAllText(path);
            _console.WriteLine(text);
        }

        public virtual void Create(string path)
        {
            _directory.CreateDirectory(path);
            _console.WriteLine($"The directory was created successfully at {_directory.GetCreationTime(path)}.");
        }

        public virtual void Save(string sourceFileName, string destFileName)
        {
            try
            {
                _file.Move(sourceFileName, destFileName);
                _console.WriteLine($"{sourceFileName} was moved to {destFileName}.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex); // Write error
            }
        }
    }
}