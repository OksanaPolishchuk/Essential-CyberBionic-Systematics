using System;
using System.IO;

namespace IdentifyTheDocument.Wrappers
{
    public class FileInfoWrapper : IFileInfoWrapper
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(string path)
        {
            _fileInfo = new FileInfo(path);
        }

        public string Name => _fileInfo.Name;
        public string Extension => _fileInfo.Extension;
        public DateTime CreationTime => _fileInfo.CreationTime;
    }
}