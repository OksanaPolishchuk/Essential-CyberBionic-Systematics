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
}